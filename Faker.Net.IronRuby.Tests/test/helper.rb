require 'test/unit'
require File.dirname(__FILE__) + '\..\..\Faker.Net\bin\Debug\Faker.dll'

# this is a hack which will force us to load our sugar assembly.
# from: http://typesafe.be/2011/05/27/loading-assemblies-in-the-load-context-with-ironruby/  
class TestAddress < Test::Unit::TestCase
    def test_load
        do_in File.dirname(__FILE__) + '\..\..\Faker.Net\bin\Debug\\' do 
            require 'sugar.dll' 
            Faker::Address.street_address
        end 
    end
private
    def do_in(working_dir)
        dir = Dir.pwd
        Dir.chdir working_dir
        yield
        Dir.chdir dir
    end
end 

class Object
    # override join to handle IEnumerable
    def join(s)
        System::Collections::Generic::List.of(System::String).new(self).join(s)
    end    
end

module Faker
    class Internet 
        #define a method because we tweaked the name
        def self.ip_v4_address
            Internet.IP_V4_Address
        end    
    end
end


