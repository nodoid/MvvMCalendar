using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System;

namespace MvvMCalendar.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        List<int> daysInMonth = new List<int> { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        List<string> monthNames = new List<string>
            {
                 "January", "February", "March", "April",
                 "May", "June", "July", "August",
                 "September", "October", "November", "December"
            };

        List<string> dayNames = new List<string>
        {
            "Sunday", "Monday", "Tuesday", "Wednesday",
            "Thursday", "Friday", "Saturday"
        };

        public string Title
        {
            get { return "Calendar"; }
        }

        int month;
        public int Month
        {
            get { return month; }
            set
            {
                Set(() => Month, ref month, value, true);
                MonthName = monthNames[value - 1];
            }
        }

        int year;
        public int Year
        {
            get { return year; }
            set { Set(() => Year, ref year, value, true); }
        }

        int day;
        public int Day
        {
            get { return day; }
            set
            {
                Set(() => Day, ref day, value, true);
                DayName = dayNames[GetDayOfWeek(new DateTime(Year, Month, Day))];
            }
        }

        string dayName;
        public string DayName
        {
            get { return dayName; }
            set { Set(() => DayName, ref dayName, value); }
        }

        string monthName;
        public string MonthName
        {
            get { return monthName; }
            set { Set(() => MonthName, ref monthName, value); }
        }

        DateTime FirstDayOfMonth(DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public List<int> GenerateCalendar()
        {
            var cal = new List<int>();
            daysInMonth[2] = DateTime.IsLeapYear(Year) ? 29 : 28;
            var ddc = (int)FirstDayOfMonth(new DateTime(Year, Month, 1)).DayOfWeek;

            var move = 0;
            if (ddc != 6)
            {
                move = ddc + 1;
                for (var i = 0; i < move; ++i)
                {
                    cal.Add(0);
                }
            }

            for (var i = 0; i < daysInMonth[Month]; ++i)
            {
                cal.Add(i + 1);
            }

            return cal;
        }

        int GetDayOfWeek(DateTime date, int calSys = 0)
        {
            var mon = date.Month;
            var yr = date.Year;
            var dy = date.Day;
            if (mon < 3)
            {
                mon += 12;
                yr--;
            }

            return (dy + (2 * mon) + (int)(6 * (mon + 1) / 10) + yr + (int)(yr / 4) - (int)(yr / 100) +
                    (int)(yr / 400) + calSys) % 7;
        }
    }
}