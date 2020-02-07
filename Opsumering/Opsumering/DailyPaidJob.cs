using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    public class DailyPaidJob : Job
    {
        public int DailyPay { get; set; }

        public DailyPaidJob(int dailyPay)
        {
            DailyPay = dailyPay;
        }

        public override int GetMonthlyPay()
        {
            return DailyPay * 30;
        }
    }
}
