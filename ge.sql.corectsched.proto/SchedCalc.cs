using System;
using System.Globalization;
using System.Linq;

namespace ge.sql.corectsched.proto
{
    public class SchedCalc
    {
        static string[] _resArr;
        static string[] _datesarr;

        public static string[] _dates(string days, int achours, int dayofweek, DateTime currentDateTime)
        {
            DateTime sunday;
            DateTime nextsunday;

            var splitarr = new[] { ", " };
            _resArr = days.Split(splitarr, StringSplitOptions.None);

            var count = 0;
            var dayscount = 24 / Convert.ToInt32(achours);
            var weekscount = 24 / (_resArr.Count() * Convert.ToInt32(achours));

            var firstcount = 0;
            var finaldate = 0;

            _datesarr = new string[dayscount];

            var delta = 0 - dayofweek;

            if (dayofweek > Convert.ToInt32(_resArr[0]))
            {
                sunday = currentDateTime.Date.AddDays(delta).AddDays(7);
                nextsunday = currentDateTime.Date.AddDays(delta).AddDays(14);
            }
            else
            {
                sunday = currentDateTime.Date.AddDays(delta);
                nextsunday = currentDateTime.Date.AddDays(delta).AddDays(7);
            }

            while (count < weekscount)
            {
                while (firstcount < _resArr.Count())
                {
                    if (_resArr[firstcount] == "0")
                    {
                        _datesarr[finaldate] = sunday.AddDays(7).ToShortDateString();
                    }
                    else
                    {
                        _datesarr[finaldate] = sunday.AddDays(Convert.ToInt32(_resArr[firstcount])).ToShortDateString();
                    }
                    firstcount++;
                    finaldate++;
                }

                firstcount = 0;
                count++;
                sunday = nextsunday;
                nextsunday = sunday.AddDays(7);
            }

            return _datesarr;
        }

        public static DateTime OneMoreDay(string days, DateTime date)
        {
            var daynum = (int)date.DayOfWeek;

            var splitarr = new[] { ", " };
            string[] calcArr = days.Split(splitarr, StringSplitOptions.None);

            var index = Array.IndexOf(calcArr, daynum.ToString(CultureInfo.InvariantCulture));

            var newdaynum = Convert.ToInt32(index < calcArr.Count() - 1 ? calcArr[index + 1] : calcArr[0]);

            var delta = 0 - daynum;

            DateTime sunday = date.Date.AddDays(delta);

            if (daynum == 0)
                sunday = sunday.AddDays(-7);
            if (newdaynum == 0)
                sunday = sunday.AddDays(7);
            if (Array.IndexOf(calcArr, daynum.ToString(CultureInfo.InvariantCulture)) == calcArr.Count() - 1)
                sunday = sunday.AddDays(7);

            DateTime newdate = sunday.AddDays(newdaynum).Date;

            return newdate;
        }
    }
}
