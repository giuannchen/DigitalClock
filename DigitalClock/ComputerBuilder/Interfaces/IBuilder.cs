using System;

namespace ComputerBuilder.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    internal interface IBuilder
    {
        /// <summary>
        /// 加顯卡
        /// </summary>
        void AddDisplayCard();

        /// <summary>
        /// 加硬碟
        /// </summary>
        void AddHdd();

        /// <summary>
        /// 加主機板
        /// </summary>
        void AddMainBord();

        /// <summary>
        /// 加電源
        /// </summary>
        void AddPower();

        /// <summary>
        /// 加記憶體
        /// </summary>
        void AddRam();

        /// <summary>
        /// 總結
        /// </summary>
        /// <returns>電腦</returns>
        Computer GetResult();
    }
}