namespace DigitalClock.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    public interface IDigitalClock
    {
        void update(string hours, string minutes, string seconds);
    }
}