using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDiscount3
{
    /// <summary>
    /// 訂單服務
    /// </summary>
    public class OrderService
    {
        /// <summary>
        /// 計算元件
        /// </summary>
        internal PriceComponent PriceComponent
        {
            get => default(PriceComponent);
            set
            {
            }
        }

        internal PriceComponent PriceComponent1
        {
            get => default(PriceComponent);
            set
            {
            }
        }

        internal PriceDecorator PriceDecorator
        {
            get => default(PriceDecorator);
            set
            {
            }
        }

        /// <summary>
        /// 會員資料
        /// </summary>
        private Member MemberData;

        /// <summary>
        /// 注入
        /// </summary>
        /// <param name="memberData">會員資料</param>
        public OrderService(Member memberData)
        {
            this.MemberData = memberData;
        }

        /// <summary>
        /// 計算優惠服務
        /// </summary>
        /// <param name="cardType">卡別</param>
        /// <param name="price">購買金額</param>
        /// <returns>計算結果</returns>
        public string GetPrice(string cardType, double price)
         {
            string message = string.Empty;
            double totalPay = price;
            if (cardType == "A")
            {
                // 會員活動
                if (this.MemberData.IsMember)
                {
                    if (this.MemberData.MemberYear >= 2)
                    {
                        Func<double, double> calculateDiscountPrice = PriceComponent.CalculateDiscountPrice;
                        totalPay = calculateDiscountPrice(totalPay);
                    }

                    // 會員送折價券
                    message = " 會員送100折價券";
                }

                // 滿千送百
                if (totalPay >= 1000)
                {
                    Func<double, double> calculateRebatePrice = PriceDecorator.CalculateRebatePrice;
                    totalPay = calculateRebatePrice(totalPay);
                }                   

                message = "中信卡原價:" + price.ToString() + " 實付:" + totalPay.ToString() + message;
            }
            else if (cardType == "B")
            {
                // 會員活動
                if (this.MemberData.IsMember)
                {
                    if (this.MemberData.MemberYear >= 2)
                    {
                        Func<double, double> calculateDiscountPrice = PriceComponent.CalculateDiscountPrice;
                        totalPay = calculateDiscountPrice(totalPay);
                    }

                    // 會員送折價券
                    message = " 會員送100折價券";
                }

                // 是否活動期間
                if (this.MemberData.Isactivity)
                {
                    message = " 活動期間加一元多一件" + message;
                }
                
                message = "台新卡原價:" + price.ToString() + " 實付:" + totalPay.ToString() + message;
            }
            else if (cardType == "C")
            {
                if (price >= 1000)
                {
                    Func<double, double> calculateRebatePrice = PriceDecorator.CalculateRebatePrice;

                    totalPay = calculateRebatePrice(price);
                }
                else
                {
                    totalPay = price;
                }

                // 是否活動期間
                if (this.MemberData.Isactivity)
                {
                    message = " 活動期間加一元多一件" + message;
                }

                message = "花旗卡原價:" + price.ToString() + " 實付:" + totalPay.ToString() + message + " 紅利點數增加100點";
            }

            return message;            
        } 
    }
}
