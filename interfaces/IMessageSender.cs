using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest.interfaces
{
    internal interface IMessageSender
    {
        public void SendMessage(string recipient, string message);
    }
}
