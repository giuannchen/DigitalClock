using CosplayBuilder.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Pokemon
{
    /// <summary>
    /// 寶可夢帽子
    /// </summary>
    internal class PokemonHat : Hat
    {
        /// <summary>
        /// 製造帽子
        /// </summary>
        /// <returns>回傳帽子訊息</returns>
        public override string MakeHat()
        {
            return "寶可夢帽子";
        }
    }
}