using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    public class MessageArgument<T> : EventArgs
    {
        public MessageArgument(T message)
        {
            Message = message;
        }

        public T Message { get; set; }
    }
}