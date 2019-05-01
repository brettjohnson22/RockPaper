using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
        }
    }
}
//Game should greet the user and ask how many players.
//Readline after every display, even if AI player is doing something.
//If one player, create AI player then start game
//If two players, prompt for P1 name, then P2 name.
//Player can be an abstract class, userplayer and AIplayer can be subclasses.
//Randomly choose who goes first.
//AI player can use same framework as regular player, except substitue a random choice for a user prompt.
//Each game will be up to 3 battles.
//Prompt players to discreetly enter their choice.
//Choice comes from a list of gestures
//Gesture can be an abstract class, each type of gesture can be a child class.
//**Resolve battle.
//This will be judging player 1's gesture against player 2's gesture and then determining winner.
//So can the actual resolve be an if-else if nested within player 1's gesture type that will plug in player 2's input?
//How can we actually compare the two values? There must be a battle class that can plug in each player value and compare.
//Each battle needs 2 player gestures.
//Each gesture must come from a list of possible gestures.
//Display winner, track score.
//Check score to see if game continues.
//If game over, display winner and ask if they'd like to play again.
//Otherwise, begin a new round.
//Must capture returned values in variable
//So input string would be filtered to a list object ie case rock: gesture = list[0]
//Does each gesture need to be its own object? Or will it work as a string?
//Do I have to code each and every possiblity? Is there a way 