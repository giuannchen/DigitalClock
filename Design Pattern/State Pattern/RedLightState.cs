using State_Pattern.Interfaces;
using static State_Pattern.LightEnum;

namespace State_Pattern
{
    /// <summary>
    /// 紅燈
    /// </summary>
    class RedLightState : ITrafficState
    {
        /// <summary>
        /// 檢查是否可以切換燈號
        /// </summary>
        /// <param name="state">目前燈號</param>
        /// <returns>是否可以切換</returns>
        public bool ChkContext(ITrafficState state)
        {
            return state.GetMessage() == MessageEnum.Yellow;
        }

        /// <summary>
        /// 取得燈號
        /// </summary>
        /// <returns>紅燈</returns>
        public MessageEnum GetMessage()
        {
            return MessageEnum.Red;
        }

        /// <summary>
        /// 回傳下一個燈號
        /// </summary>
        /// <returns>綠燈</returns>
        public ITrafficState Handle()
        {
            return new GreenLightState();
        }
    }
}
