using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace WpfApp3
{
    public class TelegramMessageClient
    {
        private MainWindow w;
        private TelegramBotClient bot;
        public ObservableCollection<MessageLOG> messageLOGs { get; set; }

        private void MessageListener(object sender, Telegram.Bot.Args.MessageEventArgs e )
        {
            if (e.Message == null) return;

            string MessageText = e.Message.Text;

            w.Dispatcher.Invoke(() =>
            {
                messageLOGs.Add(new MessageLOG(e.Message.Chat.FirstName, DateTime.Now.ToLongDateString(), e.Message.Chat.Id, e.Message.Text));
            });

        }
        public TelegramMessageClient(MainWindow w, string token = "1300258598:AAGq-lN7b9F26Od2cgljnqjL59wWo5c0vvI")
        {
            this.messageLOGs = new ObservableCollection<MessageLOG>();
            this.w = w;
            bot = new TelegramBotClient(token);

            bot.OnMessage += MessageListener;
            bot.StartReceiving();
            
            
        }
        public void SendMessage(string id, string text)
        {
            long Id = Convert.ToInt64(id);
            bot.SendTextMessageAsync(Id, text);
        }
    }
}
