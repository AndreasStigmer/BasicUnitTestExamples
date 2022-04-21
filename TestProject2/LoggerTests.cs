using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestExamples.Code;

namespace TestProject2
{
    [TestFixture]
    public class LoggerTests
    {

        [Test]
        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void Log_SendEmptyOrNullMessageText_ThrowsException(string message)
        {
           Logger log =new Logger();
           
           LogMessage logpost=new LogMessage();
           logpost.Message = message;
           Assert.That(()=>log.Log(logpost),Throws.TypeOf<ArgumentException>());

        }

        [Test]
        public void Log_AddsCorrectLogMessage_FiresLogAddedEvent()
        {
            Logger logger = new Logger();
           
            LogMessage logmessage = new LogMessage() { Message = "Log this" };
            logmessage.Id= Guid.NewGuid(); ;

            Guid newLogId = Guid.Empty;
            logger.LogAdded += (o, id) => {
                newLogId = id;
            };
            logger.Log(logmessage);
            Assert.That(newLogId,Is.Not.EqualTo(Guid.Empty));

        }

       
    }
}
