namespace ClassLibrary
{
    public static class GameProcessor
    {
        public static string MatchResult(string playerChoice, string computerChoice)
        {
            if (playerChoice == "Rock" && computerChoice == "Paper")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Rock" && computerChoice == "Scissors")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Rock" && computerChoice == "Lizard")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Rock" && computerChoice == "Spock")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Paper" && computerChoice == "Rock")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Paper" && computerChoice == "Scissors")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Paper" && computerChoice == "Lizard")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Paper" && computerChoice == "Spock")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Scissors" && computerChoice == "Rock")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Scissors" && computerChoice == "Paper")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Scissors" && computerChoice == "Lizard")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Scissors" && computerChoice == "Spock")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Lizard" && computerChoice == "Rock")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Lizard" && computerChoice == "Paper")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Lizard" && computerChoice == "Scissors")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Lizard" && computerChoice == "Spock")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Spock" && computerChoice == "Rock")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Spock" && computerChoice == "Paper")
            {
                return "ComputerWins";
            }
            else if (playerChoice == "Spock" && computerChoice == "Scissors")
            {
                return "PlayerWins";
            }
            else if (playerChoice == "Spock" && computerChoice == "Lizard")
            {
                return "ComputerWins";
            }
            else
            {
                return "Draw";
            }
        }

        public static Dictionary<string, int> GameChoiceFrequency(Dictionary<string, int> gameChoiceFrequency, string playerCoice, string computerChoice) 
        {
            if(playerCoice == "Rock")
            {
                gameChoiceFrequency["Rock"] += 1;
            }
            else if (playerCoice == "Paper")
            {
                gameChoiceFrequency["Paper"] += 1;
            }
            else if (playerCoice == "Scissors")
            {
                gameChoiceFrequency["Scissors"] += 1;
            }
            else if (playerCoice == "Lizard")
            {
                gameChoiceFrequency["Lizard"] += 1;
            }
            else if (playerCoice == "Spock")
            {
                gameChoiceFrequency["Spock"] += 1;
            }

            if (computerChoice == "Rock")
            {
                gameChoiceFrequency["Rock"] += 1;
            }
            else if(computerChoice == "Paper")
            {
                gameChoiceFrequency["Paper"] += 1;
            }
            else if (computerChoice == "Scissors")
            {
                gameChoiceFrequency["Scissors"] += 1;
            }
            else if (computerChoice == "Lizard")
            {
                gameChoiceFrequency["Lizard"] += 1;
            }
            else if (computerChoice == "Spock")
            {
                gameChoiceFrequency["Spock"] += 1;
            }

            return gameChoiceFrequency;

        }

        public static Dictionary<string, int> MatchWinsCounter(Dictionary<string, int> matchWins,string matchResult)
        {
            if (matchResult == "PlayerWins")
            {
                matchWins["PlayerWins"] += 1;
            }
            else if (matchResult == "ComputerWins")
            {
                matchWins["ComputerWins"] += 1;
            }
            else
            {
                matchWins["Draw"] += 1;
            }

            return matchWins;
        }

    }
}
