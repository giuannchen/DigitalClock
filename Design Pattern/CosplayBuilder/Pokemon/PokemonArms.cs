using CosplayBuilder.Aabstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder.Pokemon
{
    /// <summary>
    /// 寶可夢武器
    /// </summary>
    internal class PokemonArms : Arms
    {
        /// <summary>
        /// 製造武器
        /// </summary>
        /// <returns>回傳武器訊息</returns>
        public override string MakeArms()
        {
            return "寶可夢武器";
        }
    }
}