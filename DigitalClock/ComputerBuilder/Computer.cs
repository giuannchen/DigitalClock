using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    /// <summary>
    /// 電腦
    /// </summary>
    internal class Computer
    {
        /// <summary>
        /// 所有的零件
        /// </summary>
        private IList<string> Parts = new List<string>();

        /// <summary>
        /// 加零件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            this.Parts.Add((part));
        }

        /// <summary>
        /// 所有內容
        /// </summary>
        /// <returns></returns>
        public string Show()
        {
            string allparts = string.Empty;
            foreach (string part in this.Parts)
            {
                allparts += part + " ";
            }
            return allparts;
        }
    }
}