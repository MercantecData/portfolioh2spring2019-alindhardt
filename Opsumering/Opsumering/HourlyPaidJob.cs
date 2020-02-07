using System;
using System.Collections.Generic;
using System.Text;

namespace Opsumering
{
    public class HourlyPaidJob : Job
    {
        private int HourlyPay { get; set; }

        public HourlyPaidJob(int hourlyPay)
        {
            HourlyPay = hourlyPay;
        }

        public override int GetMonthlyPay()
        {
            return HourlyPay;
        }
    }
}
