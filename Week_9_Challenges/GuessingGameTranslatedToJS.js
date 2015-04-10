

function GuessingGame (answer, solved){
	
	this.answer =  answer;
	this.Solved =  Solved


GuessingGame.prototype.Guess = function(guess) {
	
		if (guess > answer)
		{
			return "high"
			Solved === false;
		}

		else if (guess === answer)
		{
			return "correct"
			Solved === true;
		}

		else if (guess < answer)
		{
			return "low";
			Solved === false;
		}
		else return "try again";
	}

GuessingGame.prototype.Issolved = function() {
	 
	 if (solved === true)
	 {
	 	return true;
	 }
	 else {
	 	return false;
	 }
}

}

function assert (test, message, test_number){
	if (!test) {
		console.log (test_number + "false");
		throw "ERROR: " + message;
	}
	console.log(test_number + "true");
	return true;
}

assert(
  (GuessingGame instanceof Object),
  "The value of GuessingGame should be an Object.\n",
  "1. "
)

assert(
  (GuessingGame.prototype.Guess instanceof Object),
  "The value of gradebook's getAverage property should be a Function.",
  "2. "
)

