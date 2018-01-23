using ComputerBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    /// <summary>
    /// RD電腦
    /// </summary>
    internal class ConcreteBuilderB : IBuilder
    {
        /// <summary>
        /// 電腦
        /// </summary>
        private readonly Computer Computer = new Computer();

        /// <summary>
        /// 加顯卡
        /// </summary>
        public void AddDisplayCard()
        {
            this.Computer.Add("2G 顯卡");
        }

        /// <summary>
        /// 加硬碟
        /// </summary>
        public void AddHdd()
        {
            this.Computer.Add("1TB SSD");
        }

        /// <summary>
        /// 加主機板
        /// </summary>
        public void AddMainBord()
        {
            this.Computer.Add("BX 主機板");
        }

        /// <summary>
        /// 加電源
        /// </summary>
        public void AddPower()
        {
            this.Computer.Add("999W Power");
        }

        /// <summary>
        /// 加記憶體
        /// </summary>
        public void AddRam()
        {
            this.Computer.Add("16G Ram");
        }

        /// <summary>
        /// 總結
        /// </summary>
        /// <returns>電腦</returns>
        public Computer GetResult()
        {
            return this.Computer;
        }
    }
}