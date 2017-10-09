using System;
using System.Globalization;

namespace MovieKillerDesktopApp.Models
{
    public class AppTimerManager
    {
        private readonly int timeToEnd;
        private readonly int timeAtStart;

        public AppTimerManager(int timeToEnd, int timeAtStart)
        {
            this.timeToEnd = timeToEnd;
            this.timeAtStart = timeAtStart;
        }
        public string ShowTimeToEnd()
        {
            var showTimeToEnd = HourConventer(timeToEnd) + @" : " + MinuteConventer(timeToEnd) + @" : " + SecondConventer(timeToEnd);
            return showTimeToEnd;
        }
        public string ShowTimeEndOfOperation(double speed)
        {
            speed /= 1000;
            double seconds = timeToEnd;
            var timeOfEnd = DateTime.Now.AddSeconds(seconds * speed).ToString(CultureInfo.CurrentCulture);
            return timeOfEnd;
        }
        public int GetValueOfprogressBar_TimeToStart()
        {
            return timeToEnd > 0 ? timeToEnd : 0;
        }
        public int GetMaxValueOfprogressBar_TimeToStart()
        {
            return timeAtStart;
        }
        private static string HourConventer(int time)
        {
            var quantityOfHours = (time / 3600).ToString();
            return quantityOfHours;
        }
        private static string MinuteConventer(int time)
        {
            var quantityOfMinutes = time / 60 % 60 >= 10 ? (time / 60 % 60).ToString() : "0" + time / 60 % 60;
            return quantityOfMinutes;
        }
        private static string SecondConventer(int time)
        {
            var quantityOfSeconds = time % 60 >= 10 ? (time % 60).ToString() : "0" + time % 60;
            return quantityOfSeconds;
        }
    }
}
