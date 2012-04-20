Faker.NET
================================================

As much as possible, a line-for-line port of ffaker for ruby (https://github.com/EmmanuelOga/ffaker).

Relies on ideas taken from Rob Conery's and Jon Wingfield's excellent sugar library (https://github.com/jonwingfield/sugar). I have just taken the idea to minimize the assembly's dependencies.

Supports .NET Framework and Mono.


Building
------------------------------------------------

nant build

nant build -D:mode=Debug


Tests
------------------------------------------------

There is a project in the solution named Faker.Net.NUnit.Tests that uses the relevant ffaker tests written in Ruby to test the .NET code.

NAnt command to run unit-tests

nant test

nant test -D:mode=Debug


Cleaning build output
-------------------------------------------------

nant clean

nant clean -D:mode=Debug


Contrib
------------------------------------------------
This is my first open source project, so any and all feedback/pull requests are welcomed and requested.
