using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExamples.Code
{
    public  class Logger
    {
        private List<LogMessage> messages = new List<LogMessage>();
        public LogMessage LastMessage { get; set; }
        public event EventHandler<Guid> LogAdded;
        public void Log(LogMessage message)
        {
            if(message == null) throw new ArgumentNullException("Log message is null");
            if (String.IsNullOrWhiteSpace(message.Message) || String.IsNullOrWhiteSpace(message.Message)) throw new ArgumentException("The message text is null, empty or contains just whitespace");
            
            message.Timestamp= DateTime.Now;
            messages.Add(message);
            LastMessage = message;
            LogAdded?.Invoke(this, message.Id);
        }

    }

    public class LogMessage
    {
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid Id { get; set; }
    }
}
