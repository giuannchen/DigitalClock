using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount3
{
    /// <summary>
    /// Proxy Service
    /// </summary>
    public class OrderProxy
    {
        /// <summary>
        /// 訂單服務
        /// </summary>
        private OrderService MyOrderService;

        /// <summary>
        /// 會員服務
        /// </summary>
        private MemberService MyMemberService;

        public OrderService OrderService
        {
            get => default(OrderService);
            set
            {
            }
        }

        public MemberService MemberService
        {
            get => default(MemberService);
            set
            {
            }
        }

        /// <summary>
        /// 訂單結算
        /// </summary>
        /// <param name="buyerName">購買人</param>
        /// <param name="cardType">卡別</param>
        /// <param name="price">購買金額</param>
        /// <returns>結算結果</returns>
        public string GetPrice(string buyerName, string cardType, double price)
        {
            this.MyMemberService = new MemberService();
            this.MyOrderService = new OrderService(this.MyMemberService.IsMember(buyerName));
            return this.MyOrderService.GetPrice(cardType, price);
        }      
    }
}
