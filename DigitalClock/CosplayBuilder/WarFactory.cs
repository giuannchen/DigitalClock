using CosplayBuilder.Aabstract;
using CosplayBuilder.Interfaces;
using CosplayBuilder.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosplayBuilder
{
    /// <summary>
    /// 魔獸工廠
    /// </summary>
    internal class WarFactory : IAbstractFactory
    {
        /// <summary>
        /// 實作盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        public Armor CreateArmor()
        {
            return new WarArmor();
        }

        /// <summary>
        /// 實作武器
        /// </summary>
        /// <returns>武器</returns>
        public Arms CreateArms()
        {
            return new WarArms();
        }

        /// <summary>
        /// 實作靴子
        /// </summary>
        /// <returns>靴子</returns>
        public Boots CreateBoots()
        {
            return new WarBoots();
        }

        /// <summary>
        /// 實作帽子
        /// </summary>
        /// <returns>帽子</returns>
        public Hat CreateHat()
        {
            return new WarHat();
        }

        /// <summary>
        /// 實作頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        public Helmet CreateHelmet()
        {
            return new WarHelmet();
        }
    }
}