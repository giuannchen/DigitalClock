using CosplayBuilder.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Pokemon
{
    /// <summary>
    /// 寶可夢靴子
    /// </summary>
    internal class PokemonBoots : Boots
    {
        /// <summary>
        /// 製造靴子
        /// </summary>
        /// <returns>回傳靴子訊息</returns>
        public override string MakeBoots()
        {
            return "寶可夢靴子";
        }
    }
}