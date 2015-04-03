// Tally Votes in JavaScript

// These are the votes cast by each student. Do not alter these objects here.
var votes = {
  "Alex": { president: "Bob", vicePresident: "Devin", secretary: "Gail", treasurer: "Kerry" },
  "Bob": { president: "Mary", vicePresident: "Hermann", secretary: "Fred", treasurer: "Ivy" },
  "Cindy": { president: "Cindy", vicePresident: "Hermann", secretary: "Bob", treasurer: "Bob" },
  "Devin": { president: "Louise", vicePresident: "John", secretary: "Bob", treasurer: "Fred" },
  "Ernest": { president: "Fred", vicePresident: "Hermann", secretary: "Fred", treasurer: "Ivy" },
  "Fred": { president: "Louise", vicePresident: "Alex", secretary: "Ivy", treasurer: "Ivy" },
  "Gail": { president: "Fred", vicePresident: "Alex", secretary: "Ivy", treasurer: "Bob" },
  "Hermann": { president: "Ivy", vicePresident: "Kerry", secretary: "Fred", treasurer: "Ivy" },
  "Ivy": { president: "Louise", vicePresident: "Hermann", secretary: "Fred", treasurer: "Gail" },
  "John": { president: "Louise", vicePresident: "Hermann", secretary: "Fred", treasurer: "Kerry" },
  "Kerry": { president: "Fred", vicePresident: "Mary", secretary: "Fred", treasurer: "Ivy" },
  "Louise": { president: "Nate", vicePresident: "Alex", secretary: "Mary", treasurer: "Ivy" },
  "Mary": { president: "Louise", vicePresident: "Oscar", secretary: "Nate", treasurer: "Ivy" },
  "Nate": { president: "Oscar", vicePresident: "Hermann", secretary: "Fred", treasurer: "Tracy" },
  "Oscar": { president: "Paulina", vicePresident: "Nate", secretary: "Fred", treasurer: "Ivy" },
  "Paulina": { president: "Louise", vicePresident: "Bob", secretary: "Devin", treasurer: "Ivy" },
  "Quintin": { president: "Fred", vicePresident: "Hermann", secretary: "Fred", treasurer: "Bob" },
  "Romanda": { president: "Louise", vicePresident: "Steve", secretary: "Fred", treasurer: "Ivy" },
  "Steve": { president: "Tracy", vicePresident: "Kerry", secretary: "Oscar", treasurer: "Xavier" },
  "Tracy": { president: "Louise", vicePresident: "Hermann", secretary: "Fred", treasurer: "Ivy" },
  "Ullyses": { president: "Louise", vicePresident: "Hermann", secretary: "Ivy", treasurer: "Bob" },
  "Valorie": { president: "Wesley", vicePresident: "Bob", secretary: "Alex", treasurer: "Ivy" },
  "Wesley": { president: "Bob", vicePresident: "Yvonne", secretary: "Valorie", treasurer: "Ivy" },
  "Xavier": { president: "Steve", vicePresident: "Hermann", secretary: "Fred", treasurer: "Ivy" },
  "Yvonne": { president: "Bob", vicePresident: "Zane", secretary: "Fred", treasurer: "Hermann" },
  "Zane": { president: "Louise", vicePresident: "Hermann", secretary: "Fred", treasurer: "Mary" }
}

// Tally the votes in voteCount.
var voteCount = {
  president: {},
  vicePresident: {},
  secretary: {},
  treasurer: {}
}

/* The name of each student receiving a vote for an office should become a property
of the respective office in voteCount.  After Alex's votes have been tallied,
voteCount would be ...

  var voteCount = {
    president: { Bob: 1 },
    vicePresident: { Devin: 1 },
    secretary: { Gail: 1 },
    treasurer: { Kerry: 1 }
  }

*/


/* Once the votes have been tallied, assign each officer position the name of the
student who received the most votes. */
var officers = {
  president: undefined,
  vicePresident: undefined,
  secretary: undefined,
  treasurer: undefined
}

// __________________________________________
// Your Solution
var presidentsList = {}; //create places to store vote count
var vpresidentsList = {};
var secList = {};
var tresList = {};

function CountVotes (votes) //create function to count votes which takes the votes array as input
{
for (var voteA in votes) //create for each loop that sets an element called vote in votes 
  {
      var presidentialVote = votes[voteA].president; // within loop, set var presidential vote which is a vote for the president property
      if (voteCount.president[presidentialVote] === undefined) // if the president property in the votecount object for a presidential vote 
      {                                                        // is undefined - essentially if there no vote there, which is plausible at the beginning where no votes are tallied - then do the following
        voteCount.president[presidentialVote] = 1; // add 1 vote to the president property in the VoteCount object, using presidential vote var
        presidentsList.push[presidentialVote]; // push this 1 vote to the end of the prezlist object using the presidential vote var.
      }
      else { 
        voteCount.president[presidentialVote] += 1; //otherwise, presidential vote will be 1 in voteCount array, so don't shit a brick.
      }
  }

for (var voteB in votes)
  {
      var vicePresidentialVote = votes[voteB].vicePresident;
      if (voteCount.vicePresident[vicePresidentialVote] === undefined)
      {
        voteCount.vicePresident[vicePresidentialVote] + 1;
        vpresidentsList.push[vicePresidentialVote];
      }

      else {
        VoteCount.vicePresident[vicePresidentialVote] +=1;
      }
  }

for (var voteC in votes)
{
      var secretaryVote = votes[voteC].secretary;
      if (voteCount.secretary[secretaryVote] === undefined)
      {
         voteCount.secretary[secretaryVote] +1;
         secList.push[secretaryVote];
      }
      else {
          VoteCount.secretary[secretaryVote] +=1;
      }
  }

for (var voteD in votes)
{
      var treasurerVote = votes[voteD].treasurer;
      if (voteCount.treasurer[treasurerVote] === undefined)
      {
        voteCount.treasurer[treasurerVote] = 1;
        treslist.push[treasurerVote];
      }
      else {
          voteCount.treasurer[treasurerVote] +=1;
      }
    }
}


function appoint () //create appoint function
{
      var minimumVote = 1; // set a var minimum vote as one
      for (var a in presidentsList) // here we are using a for in loop to loop through the lists we created to hold each vote
      {
        var prez = presidentsList[a]; //a variable prez is assigned to the position of var a in the presidents list
        if (voteCount.president[prez] > minimumVote) //if value of prez in the vote count for the president is greater than 1;
        {
          minimumVote = voteCount.president[prez]; // the minimum vote is assigned to the votecount of the president property.
          officers.president = prez; // the value of the president property of the officers object is assigned to the prez var.
        }
      }

      for (var b in vpresidentsList)
      {
        var vprez = vpresidentsList[b];
        if(vote.Count.vicePresident[vprez] > minimumVote)
        {
          minimumVote = voteCount.vicePresident[vprez];
          officers.vicePresident = vprez;
        }
      }

      for (var c in secList)
      {
        var sec = secList[c];
        if (voteCount.secretary[sec] > minimumVote)
        {
          minimumVote = voteCount.secretary[sec];
          officers.secretary = sec;
        }
      }

      for (var d in tresList)
      {
        var tres = treslist[d];
        if (voteCount.secretary[tres] > minimumVote)
        {
          minimumVote = voteCount.treasurer[tres];
          officers.treasurer = tres;
        }
      }
    }
    CountVotes(votes) // call countvotes function
    appoint(); // call appoint method
  }

/* Reflections
To be honest i spent alot of time on this challenge and still couldn't get it to pass.
I am finding the switch back to javascript a challenge after the last few weeks of C#.
I do know its important not to get comfortable with one language though, but I do find javascript a little frustrating sometimes, doesn't everyone?
I also went down the route of trying to use the hasOwnProperty method on a query of the votes object which was a bad move and took
me hours to get the germ of my ideas back.
My code also does not follow the DRY principle.
I also found trying to ascertain what the failure of tests was telling me as hard to interpret. 


*/








// __________________________________________
// Driver Code:  Do not alter code below this line.


function assert(test, message, test_number) {
  if (!test) {
    console.log(test_number + "false");
    throw "ERROR: " + message;
  }
  console.log(test_number + "true");
  return true;
}

assert(
  (voteCount.president["Bob"] === 3),
  "Bob should receive three votes for President.",
  "1. "
)

assert(
  (voteCount.vicePresident["Bob"] === 2),
  "Bob should receive two votes for Vice President.",
  "2. "
)

assert(
  (voteCount.secretary["Bob"] === 2),
  "Bob should receive two votes for Secretary.",
  "3. "
)

assert(
  (voteCount.treasurer["Bob"] === 4),
  "Bob should receive four votes for Treasurer.",
  "4. "
)

assert(
  (officers.president === "Louise"),
  "Louise should be elected President.",
  "5. "
)

assert(
  (officers.vicePresident === "Hermann"),
  "Hermann should be elected Vice President.",
  "6. "
)

assert(
  (officers.secretary === "Fred"),
  "Fred should be elected Secretary.",
  "7. "
)

assert(
  (officers.treasurer === "Ivy"),
  "Ivy should be elected Treasurer.",
  "8. "
)
