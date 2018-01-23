using ComputerBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    internal class Director
    {
        /// <summary>
        /// 組裝電腦
        /// </summary>
        /// <param name="builder">共用的組裝方法</param>
        public void Construct(IBuilder builder)
        {
            builder.AddDisplayCard();
            builder.AddMainBord();
            builder.AddPower();
            builder.AddRam();
            builder.AddHdd();
        }
    }
}