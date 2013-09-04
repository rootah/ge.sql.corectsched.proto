using System;
using System.Collections;
using System.Linq;
using DevExpress.XtraScheduler;

namespace ge.sql.corectsched.proto
{
    public class SchedCalc
    {
        static string[] _resArr;
        static string[] _dates;

        public static void DatesArray(Form1 mainForm1, string days, int achours, int dayofweek, DateTime currentDateTime, string group, TimeSpan time)
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

            _dates = new string[dayscount];

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
                        _dates[finaldate] = sunday.AddDays(7).ToShortDateString();
                    }
                    else
                    {
                        _dates[finaldate] = sunday.AddDays(Convert.ToInt32(_resArr[firstcount])).ToShortDateString();
                    }
                    firstcount++;
                    finaldate++;
                }

                firstcount = 0;
                count++;
                sunday = nextsunday;
                nextsunday = sunday.AddDays(7);
            }

            mainForm1.gridControl1.DataSource = new ArrayList(_dates);
            SchedFill(mainForm1, group, time, achours, _dates);
        }

        private static void SchedFill(Form1 mainForm1, string group, TimeSpan time, int achour, string[] dates)
        {
            const string teacher = "Rozary";

            for (int i = 0; i < dates.Count(); i++)
            {
                var date = DateTime.Parse(dates[i]);
                var apt = new Appointment(AppointmentType.Normal)
                {
                    Subject = teacher,
                    Start = date.Add(time),
                    Location = group,
                    StatusId = 2,
                    LabelId = 2,
                    End = date.Add(time).AddHours(achour)
                };

                mainForm1.schedulerStorage.Appointments.Add(apt);
            }
        }
    }
}
