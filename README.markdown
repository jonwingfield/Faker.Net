Faker.NET
================================================

As much as possible, a line-for-line port of ffaker for ruby (https://github.com/EmmanuelOga/ffaker).

Relies on my fork (https://github.com/jonwingfield/sugar) of Rob Conery's excellent sugar library (I plan on requesting a pull eventually).


Tests
------------------------------------------------

There is a project in the solution named Faker.Net.IronRuby.Tests that uses the relevant ffaker tests written in Ruby to test the .NET code.
To run these tests, simply run 
	
	irake test

from the command line and the tests will run.  You will need to compile the project first.  For now, it's hard-coded to point at the debug folder.


Contrib
------------------------------------------------
This is my first open source project, so any and all feedback/pull requests are welcomed and requested.
