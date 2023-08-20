using OpenAI_API;
using OpenAI_API.Completions;

namespace alurachallengebackend7.Services
{
    public class AiService
    {
        public static async Task<string> UseChatGPTAsync(string prompt)
        {
            string outputResult = "";

            var openai = new OpenAIAPI("OPENAIA_APIKEY");
            CompletionRequest completionRequest = new()
            {
                Prompt = prompt,
                Model = OpenAI_API.Models.Model.DavinciText,
                MaxTokens = 1024
            };

            var completions = await openai.Completions.CreateCompletionAsync(completionRequest);

            foreach (var completion in completions.Completions)
            {
                outputResult += completion.Text;
            }


            return outputResult;
        }
    }
}