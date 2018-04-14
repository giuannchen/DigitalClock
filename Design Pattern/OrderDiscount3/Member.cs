using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount3
{
    /// <summary>
    /// 會員資料
    /// </summary>
    public class Member
    {
        /// <summary>
        /// 是否為會員
        /// </summary>
        public bool IsMember = false;
                
        /// <summary>
        /// 會員年資
        /// </summary>
        public int MemberYear = 0;

        /// <summary>
        /// 是否為活動期間
        /// </summary>
        public bool Isactivity = false;
    }
}
