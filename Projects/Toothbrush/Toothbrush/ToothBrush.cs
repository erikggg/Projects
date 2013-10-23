using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toiletries
{
    public class ToothBrush
    {
        private bool batteryoperated;
        private bool replaceablebrushead;
        private double brushprice;
        private double rpp; //replaceablepartprice
        private TimeSpan rechargetime;
        private DateTime rechargestart;
        private DateTime rechargecomplete;
        private int nextrecharge; //
        private TimeSpan hourspercharge; //total amount of hours brushing on full charge
        private int depletionrate; //how many % of a full charge are used per brushing cycle
        private TimeSpan brushtime; //amount of time spent on one brush cycle
        



        public void CalcFullCharge()
        { 
            TimeSpan oneHour = new TimeSpan(0,1,0,0);
            TimeSpan oneMinute = new TimeSpan(0, 0, 1, 0);

            rechargecomplete = rechargestart + rechargetime;
        }
        public void CalcNextCharging()
        {
            nextrecharge = System.DateTime.DatePart(day, DateTime.Now);
