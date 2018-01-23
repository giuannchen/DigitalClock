using CosplayBuilder.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Pokemon
{
    /// <summary>
    /// 寶可夢頭盔
    /// </summary>
    internal class PokemonHelmet : Helmet
    {
        /// <summary>
        /// 製造頭盔
        /// </summary>
        /// <returns>回傳頭盔訊息</returns>
        public override string MakeHelmet()
        {
            return "寶可夢頭盔";
        }
    }
}