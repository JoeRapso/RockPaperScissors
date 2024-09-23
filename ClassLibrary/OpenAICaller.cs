using OpenAI.Chat;

namespace ClassLibrary
{
    public static class OpenAICaller
    {
        public static string SaySomethingFunny(Dictionary<string, int> gameWins)
        {
            ChatClient client = new(model: "gpt-3.5-turbo", "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");
            var winner = gameWins.OrderByDescending(pair => pair.Value).Take(1).ToDictionary(pair => pair.Key, pair => pair.Value); ;
            if (winner.ContainsKey("PlayerWins"))
            {
                ChatCompletion completion = client.CompleteChat("Say something funny when you lose a game");
                return completion.Content[0].Text;
            }
            else if (winner.ContainsKey("ComputerWins"))
            {
                ChatCompletion completion = client.CompleteChat("Say something funny when you win a game");
                return completion.Content[0].Text;
            }
            else
            {
                ChatCompletion completion = client.CompleteChat("Say something funny when the game is a draw");
                return completion.Content[0].Text;
            }

        }
    }
}
