using OpenAI.Chat;

namespace ClassLibrary
{
    public static class OpenAICaller
    {
        public static string SaySomethingFunny(Dictionary<string, int> gameWins)
        {
            try
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
            catch (Exception m)
            {

                throw;
            }




        }
    }
}
