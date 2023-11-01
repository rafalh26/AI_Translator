using OpenAI_API;
using OpenAI_API.Moderation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Translator
{
    internal class TalkWithMe
    {
        OpenAIAPI openAI;
        string result;
        public string prompt;
        async public Task<string> talkToMe(string inputData)
        {
            prompt = inputData;
            return await executeAI();
        }
        async private Task<string> executeAI()
        {
            openAI = new OpenAIAPI("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");

            try
            {
                var completion = await openAI.Completions.CreateCompletionAsync(
                    model: "text-davinci-003",
                    prompt: prompt,
                    max_tokens: 200,
                    temperature: 0.2
                );
                result = completion.ToString();
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }
    }
}
