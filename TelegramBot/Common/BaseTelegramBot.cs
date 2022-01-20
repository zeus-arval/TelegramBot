using System.Configuration;

namespace TelegramBot.Common
{
    public abstract class BaseTelegramBot : IBaseBot
    {
        private readonly string _token;
        internal protected string GetToken 
        {
            get => _token;
            init => _token = ConfigurationManager.AppSettings.Get("token");
        }
        public abstract void Update();
    }
}
