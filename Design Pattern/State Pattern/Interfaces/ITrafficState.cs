using System;
using static State_Pattern.LightEnum;

namespace State_Pattern.Interfaces
{
    /// <summary>
    /// 共用燈號狀態
    /// </summary>
    public interface ITrafficState
    {
        /// <summary>
        /// 回傳下一個燈號
        /// </summary>
        /// <returns>燈</returns>
        ITrafficState Handle();

        /// <summary>
        /// 取得目前燈號狀態
        /// </summary>
        /// <returns>燈號</returns>
        MessageEnum GetMessage();

        /// <summary>
        /// 檢查燈號是否可以切換
        /// </summary>
        /// <param name="state">燈號</param>
        /// <returns>是否正確</returns>
        bool ChkContext(ITrafficState state);



    }
}