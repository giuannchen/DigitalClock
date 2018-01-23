using System;
using CosplayBuilder.Aabstract;

namespace CosplayBuilder.Interfaces
{
    /// <summary>
    /// 抽出共同函式
    /// </summary>
    internal interface IAbstractFactory
    {
        /// <summary>
        /// 生產盔甲
        /// </summary>
        /// <returns>盔甲</returns>
        Armor CreateArmor();

        /// <summary>
        /// 生產武器
        /// </summary>
        /// <returns>武器</returns>
        Arms CreateArms();

        /// <summary>
        /// 生產靴子
        /// </summary>
        /// <returns>靴子</returns>
        Boots CreateBoots();

        /// <summary>
        /// 生產帽子
        /// </summary>
        /// <returns>帽子</returns>
        Hat CreateHat();

        /// <summary>
        /// 生產頭盔
        /// </summary>
        /// <returns>頭盔</returns>
        Helmet CreateHelmet();
    }
}