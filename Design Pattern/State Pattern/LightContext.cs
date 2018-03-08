using State_Pattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static State_Pattern.LightEnum;

namespace State_Pattern
{
    /// <summary>
    /// 紅綠燈
    /// </summary>
    class LightContext
    {
        /// <summary>
        /// 目前燈
        /// </summary>
        private ITrafficState Mystate;

        public ITrafficState State
        {
            get => default(ITrafficState);
            set
            {
            }
        }

        /// <summary>
        /// 換燈
        /// </summary>
        /// <returns>回傳變燈後的燈號</returns>
        public MessageEnum Request() {
            this.Mystate = this.Mystate.Handle();
            return this.Mystate.GetMessage();

            }

        /// <summary>
        /// 判斷是否可以變燈
        /// </summary>
        /// <param name="state">燈</param>
        /// <returns>燈號</returns>
        public MessageEnum SetState(ITrafficState state)
        {
            if (this.Mystate == null)
            {
                this.Mystate = state;
                return this.Mystate.GetMessage();
            }
            else
            {
                if (!state.ChkContext(this.Mystate))
                {
                    return MessageEnum.Null;
                }
                else
                {
                    this.Mystate = state;
                    return this.Mystate.GetMessage();
                }
            }
        }


    }
}
