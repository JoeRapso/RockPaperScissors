﻿using ClassLibrary;
using ClassLibrary.Menu;
using ClassLibrary.UserInput;

List<string> menuChoices = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

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
int maxGameTurns = 5;
Guid gameSessionId = Guid.NewGuid();
MenuText.MainMenu(menuChoices);

for(int i = 1; i <= maxGameTurns; i++)
{
    gameTurns = i;

    if (i > 1)
    {
        MenuText.NextRound(menuChoices);
    }
    string playerChoice = UserInputProcessor.GetMenuChoice(menuChoices);
    string computerChoice = ComputerChoiceGenerator.ComputerChoice();
    MenuMessages.DisplayComputerChoice(computerChoice);
    gameChoiceFrequency = GameProcessor.GameChoiceFrequency(gameChoiceFrequency, playerChoice, computerChoice);
    string matchResult = GameProcessor.MatchResult(playerChoice, computerChoice);
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