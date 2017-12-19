using System;

namespace DigitalClock.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    public interface IClock<T>
    {
        //發佈時間的主題
        event EventHandler<MessageArgument<T>> DatetimePublisher;

        void OnDatetimePublisher(MessageArgument<T> args);

        void onTick(T data);
    }
}