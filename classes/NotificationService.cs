using SolidTest.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.classes
{
    internal class NotificationService
    {
        private readonly IMessageSender _messageSender;

        public NotificationService(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
        }

        public void Notify(string recipient, string message)
        {
            this._messageSender.SendMessage(recipient, message);
        }
    }
}
