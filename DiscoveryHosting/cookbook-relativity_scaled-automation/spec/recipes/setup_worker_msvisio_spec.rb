require_relative '../spec_helper'

describe 'relativity-scaled-automation-sri::setup_worker_msvisio' do
  let(:chef_run) do
    ChefSpec::SoloRunner.new(
      log_level: :error,
      platform: 'windows',
      version: '2012',
      file_cache_path: '/var/chef/cache'
    ) .converge('relativity-scaled-automation-sri::setup_worker_msvisio')
  end

  it 'Downloads MSVisio ISO to the server' do
    expect(chef_run).to create_remote_file('Download ISO')
  end

  it 'Creates a directory for extracted files' do
    expect(chef_run).to create_directory('ISO Output Directory')
  end

  it 'executes 7zip to extract ISO files' do
    allow(File).to receive(:exist?).and_call_original
    expect(chef_run).to run_execute('extract_msvisio_iso')
  end

  it 'Creates Silent Install Config for Visio on server' do
    allow(File::Dir).to receive(:exist?).and_return(true)
    expect(chef_run).to create_template('copy_silent_install_config_locally')
  end

  it 'Installs MSVisio' do
    expect(chef_run).to install_package('Microsoft Office Visio')
  end
end
