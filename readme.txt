#####################################
#				    #
#   FizzBuzz Sample: Wayne Denier   #
#   For Headspring		    #
#   9/12/2012			    #
#				    #
#####################################

FizzBuzz Console Command

Args:	/l	Lower range of test
	/u	Upper range of test
	/f	Replace Fizz token
	/b	Replace Buzz token
	/o	Optional text output path

#####################################

wayne.denier@gmail.com

#####################################

Additional Notes:

- Realized after inital tests that should
  not be emitting "foo" for non matched
  values, corrected to emit number

- Can safely remove Rhino.Mocks from my tests
  in this instance since I am only using
  the MockOutputWriter

- IOutputWriter code is not fully covered;
  should put this under test and refactor as
  nessesary

- Currently defering all argument binding to
  Args library from Nuget. Should add validation
  and user feedback after parsing args.