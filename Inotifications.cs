using System;
using System.Collections.Generic;
using System.Text;

namespace lab6_task04
{
    internal interface Inotifications
    {
        public void send(string message);
        public string channel
        {
            get;
        }
    }
}
