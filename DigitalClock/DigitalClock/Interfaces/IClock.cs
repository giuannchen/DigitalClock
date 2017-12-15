namespace DigitalClock.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    public interface IClock
    {
        void onTick();

        void RegisterObserver(IDigitalClock pObserver);
    }
}