using ClassLibrary;

namespace UnitTests
{
    public class Tests
    {

        [Test]
        public void GivenRockAndPaperValues_GameResult_ReturnsCorrectResult()
        {
            string playerChoice = "Rock";
            string computerChoice = "Paper";
            string expected = "ComputerWins";
            string result = GameProcessor.MatchResult(playerChoice, computerChoice);
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void GivenRockAndSpockValues_GameResult_ReturnsCorrectResult()
        {
            string playerChoice = "Rock";
            string computerChoice = "Spock";
            string expected = "ComputerWins";
            string result = GameProcessor.MatchResult(playerChoice, computerChoice);
            Assert.That(result, Is.EqualTo(expected));

        }

        [Test]
        public void GivenLizardAndSpockValues_GameResult_ReturnsCorrectResult()
        {
            string playerChoice = "Lizard";
            string computerChoice = "Spock";
            string expected = "PlayerWins";
            string result = GameProcessor.MatchResult(playerChoice, computerChoice);
            Assert.That(result, Is.EqualTo(expected));

        }
        [Test] 
        public void GivenTwoRockValues_GameChoiceFrequency_ReturnsCorrectResult()
        {
            Dictionary<string, int> gameChoiceFrequency = new Dictionary<string, int>()
            {
                {"Rock", 0 },
                {"Paper", 0 },
                {"Scissors", 0 },
                {"Lizard", 0 },
                {"Spock", 0 }
            };
            string playerChoice = "Rock";
            string computerChoice = "Rock";
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Rock", 2 },
                {"Paper", 0 },
                {"Scissors", 0 },
                {"Lizard", 0 },
                {"Spock", 0 }
            };
            var result = GameProcessor.GameChoiceFrequency(gameChoiceFrequency, playerChoice, computerChoice);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}