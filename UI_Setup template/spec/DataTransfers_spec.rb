require_relative '../lib/includes'

describe '' do
   before{
       @elsurl = ElsUrl.new
    }
    context '' do
        
        it '' do
           expect(@elsurl.).to eq()
        end
    end
    after(:each) do |example|
	if example.exception != nil
		# driver.save_screenshot "C:/RubyScripts/rspec/error.png"
	end
  end
end