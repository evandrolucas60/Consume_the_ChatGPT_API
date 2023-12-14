using OpenAI_API;
using System.Runtime.CompilerServices;

namespace ChatGPT.ASP.NET.Integration.Extensions
{
    public static class ChatGptExtensions
    {
        public static WebApplicationBuilder AddChatGpt(
            this WebApplicationBuilder builder, IConfiguration configuration)
        {
            //var key = configuration["ChatGpt:key"];
            var key = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
            var chat = new OpenAIAPI(key);
            builder.Services.AddSingleton(chat);
            return builder;
        }
    }
}
