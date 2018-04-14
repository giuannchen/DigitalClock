using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount3
{
    /// <summary>
    /// 會員服務
    /// </summary>
    public class MemberService
    {
        /// <summary>
        /// 會員資料
        /// </summary>
       private Member MemberData = new Member();

        public Member Member
        {
            get => default(Member);
            set
            {
            }
        }

        /// <summary>
        /// 建查是否為會員
        /// </summary>
        /// <param name="account">會員帳號</param>
        /// <returns>會員資料</returns>
        public Member IsMember(string account)
        {
            if (account == "Sam")
            {
                this.MemberData.IsMember = true;
                this.MemberData.MemberYear = 2;
                this.MemberData.Isactivity = true;
            }
            else if (account == "Leo")
            {
                this.MemberData.IsMember = true;
                this.MemberData.MemberYear = 1;
                this.MemberData.Isactivity = false;
            }

            return this.MemberData;
        }
    }
}
