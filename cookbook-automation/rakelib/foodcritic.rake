namespace :style do
  desc 'Run foodcritic linting against the cookbook.'
  FoodCritic::Rake::LintTask.new(:foodcritic) do |task|
    task.options = {
      progress: true,
      fail_tags: ['any']
    }
  end
end
