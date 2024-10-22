using ClassLibrary;
using ClassLibrary.Menu;
using ClassLibrary.UserInput;

/* feedback
-Move choices should be an Enum rather than magic strings.
-Separation of IO and logic is good to see.
-Absolutely no comments in the code. At the very least classes should be commented with what they do.
-Explicit declaration of variable types is poor practice.
-Absolutely no OOP. While not strictly necessary for this project, there's no evidence of knowledge of inheritance or interfaces.
-It should be possible to type for example "rock" or "r" instead of "1".
-Random should be a private static field in the classes it is used in. Otherwise, a new Random object is being instantiated on each method call.
-This line of code: `var winner = gameWins.OrderByDescending(pair => pair.Value).Take(1).ToDictionary(pair => pair.Key, pair => pair.Value);` is very inefficient and wordy.
-After each round there should be some feedback on who won.
-The program crashes at the end of the game due to an invalid API key. Using OpenAI is a nice idea but errors need to be properly handled.
-Tests are correct but very basic. There should be some edge cases and tests that are expected to fail."
*/

//List<string> menuChoices = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

Enums.MenuChoices menuChoices;

Dictionary<string, int> gameChoiceFrequency = new Dictionary<string, int>()
{
    {"Rock", 0 },
    {"Paper", 0 },
    {"Scissors", 0 },
    {"Lizard", 0 },
    {"Spock", 0 }
};

Dictionary<string, int> matchWins = new Dictionary<string, int>()
{
    {"PlayerWins", 0 },
    {"ComputerWins", 0 },
    {"Draw", 0 }
};

int gameTurns = 1;
int maxGameTurns = 3;
Guid gameSessionId = Guid.NewGuid();
MenuText.MainMenu();

for (int i = 1; i <= maxGameTurns; i++)
{
    gameTurns = i;

    if (i > 1)
    {
        MenuText.NextRound();
    }
    string playerChoice = UserInputProcessor.GetMenuChoice();
    string computerChoice = ComputerChoiceGenerator.ComputerChoice();
    gameChoiceFrequency = GameProcessor.GameChoiceFrequency(gameChoiceFrequency, playerChoice, computerChoice);
    string matchResult = GameProcessor.MatchResult(playerChoice, computerChoice);
    MenuMessages.DisplayMatchResult(computerChoice,matchResult);
    matchWins = GameProcessor.MatchWinsCounter(matchWins, matchResult);
    DataAccess.SaveGameHistoryToSQLiteDB(playerChoice, computerChoice, matchResult, gameSessionId);

    if (matchWins["PlayerWins"] == Convert.ToInt16(Math.Ceiling(maxGameTurns / 2.0)))
    {
        gameTurns = i;
        break;
    }
    else if (matchWins["ComputerWins"] == Convert.ToInt16(Math.Ceiling(maxGameTurns / 2.0)))
    {
        gameTurns = i;
        break;
    }
}
MenuMessages.DisplayGameDetails(matchWins, gameChoiceFrequency, gameTurns);
MenuMessages.AIMessage(matchWins);
