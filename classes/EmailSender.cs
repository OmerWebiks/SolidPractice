using SolidTest.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.classes
{
    internal class EmailSender: IMessageSender
    {
        public void SendMessage(string recipient, string message)
        {
            if (Validators.ValidateEmail(recipient)) { 
            Console.WriteLine($"Email sent to {recipient}, content: {message}");
            
           } else
            {
                throw new Exception("Invalid email, try again");
            }
        }
    }
}
