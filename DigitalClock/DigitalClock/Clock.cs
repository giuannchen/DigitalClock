using DigitalClock.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    internal class Clock<T> : IClock<T>
    {
        //Defined datapublisher event
        public event EventHandler<MessageArgument<T>> DatetimePublisher;

        public void OnDatetimePublisher(MessageArgument<T> args)
        {
            var handler = DatetimePublisher;
            if (handler != null)
                handler(this, args);
        }

        public void onTick(T data)
        {
            MessageArgument<T> message = (MessageArgument<T>)Activator.CreateInstance(typeof(MessageArgument<T>), new object[] { data });
            OnDatetimePublisher(message);
        }
    }
}