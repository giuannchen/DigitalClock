using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Aabstract
{
    /// <summary>
    /// 生產帽子的抽像類別
    /// </summary>
    internal abstract class Hat
    {
        /// <summary>
        /// 生產帽子
        /// </summary>
        /// <returns>帽子</returns>
        public abstract string MakeHat();
    }
}