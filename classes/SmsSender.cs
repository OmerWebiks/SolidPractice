using SolidTest.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.classes
{
    internal class SmsSender : IMessageSender
    {
        
        public void SendMessage(string recipient, string message)
        {
            if (Validators.ValidatePhoneNumber(recipient)) {
                Console.WriteLine($"SMS sent to {recipient}, content: {message}");
            }

        }
    }
}
