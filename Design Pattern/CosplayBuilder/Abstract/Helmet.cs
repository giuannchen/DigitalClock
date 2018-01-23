using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Aabstract
{
    /// <summary>
    /// 生產頭盔的抽像類別
    /// </summary>
    internal abstract class Helmet
    {
        /// <summary>
        /// 生產頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        public abstract string MakeHelmet();
    }
}