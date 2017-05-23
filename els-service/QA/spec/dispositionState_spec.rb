require_relative '../lib/includes'

describe 'EELS services functionality for DispositionState entity' do
  context 'making a GET request for DispositionState' do
    before {
      @get_call = @eels_auth.get('DispositionState')
    }
    it 'results in a success with 200 as response code and "OK" as response message' do
      expect(@get_call[:code]).to eq 200
      expect(@get_call[:response]).to eq 'OK'
    end
  end
end
