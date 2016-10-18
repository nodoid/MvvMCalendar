using Android.App;
using Android.Widget;
using Android.OS;
using MvvMCalendar.ViewModel;
using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Helpers;
using Android.Graphics;
using System.Linq;
using GalaSoft.MvvmLight.Views;

namespace MvvMCalendar.Droid
{
    [Activity(Label = "Calendar", MainLauncher = true)]
    public partial class MainActivity : ActivityBase
    {
        int currDay;
        List<int> cal = new List<int>();

        public MainViewModel ViewModel => App.Locator.Main;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Main);

            SetupViewModel();

            SetupVars();

            BindValues();

            SetupUIEvents();

            currDay = btnList.IndexOf(btnList.FirstOrDefault(t => t.Text == DateTime.Now.Day.ToString()));
        }

        void SetupViewModel()
        {
            ViewModel.Year = DateTime.Now.Year;
            ViewModel.Month = DateTime.Now.Month;
            ViewModel.Day = DateTime.Now.Day;
        }

        void SetupVars()
        {
            btnList = new List<TextView>
            {
                TxtDate1,
                TxtDate2,
                TxtDate3,
                TxtDate4,
                TxtDate5,
                TxtDate6,
                TxtDate7,
                TxtDate8,
                TxtDate9,
                TxtDate10,
                TxtDate11,
                TxtDate12,
                TxtDate13,
                TxtDate14,
                TxtDate15,
                TxtDate16,
                TxtDate17,
                TxtDate18,
                TxtDate19,
                TxtDate20,
                TxtDate21,
                TxtDate22,
                TxtDate23,
                TxtDate24,
                TxtDate25,
                TxtDate26,
                TxtDate27,
                TxtDate28,
                TxtDate29,
                TxtDate30,
                TxtDate31,
                TxtDate32,
                TxtDate33,
                TxtDate34,
                TxtDate35
            };

            foreach (var t in btnList)
            {
                t.Text = string.Empty;
                t.SetTextColor(Color.Turquoise);
            }

            btnList[currDay].SetBackgroundColor(Color.Bisque);
        }

        void BindValues()
        {
            this.SetBinding(
                () => ViewModel.MonthName,
                () => TxtMonth.Text);

            this.SetBinding(
                () => this.ViewModel.Title,
                () => this.TxtViewTitle.Text,
                BindingMode.OneWay);
        }

        void SetupUIEvents()
        {
            BtnBack.Click += delegate
            {
                ViewModel.Month--;
                if (ViewModel.Month == 0)
                {
                    ViewModel.Month = 12;
                    ViewModel.Year--;
                }

                cal.Clear();
                cal = ViewModel.GenerateCalendar();
                ClearCalendar();
                PopulateCalendar(cal);
            };

            BtnNext.Click += delegate
            {
                ViewModel.Month++;
                if (ViewModel.Month == 13)
                {
                    ViewModel.Month = 1;
                    ViewModel.Year++;
                }

                cal.Clear();
                cal = ViewModel.GenerateCalendar();
                ClearCalendar();
                PopulateCalendar(cal);
            };
        }

        void ClearCalendar()
        {
            foreach (var btn in btnList)
            {
                btn.Click -= SelectedButton;
                btn.Text = string.Empty;
            }
        }

        void SelectedButton(object s, EventArgs e)
        {
            var day = s as TextView;
            if ((int)day.Tag != currDay)
            {
                btnList[currDay].SetBackgroundColor(Color.White);
                currDay = (int)day.Tag;
                btnList[currDay].SetBackgroundColor(Color.Bisque);
            }
        }

        void PopulateCalendar(List<int> calr)
        {
            var count = 0;
            if (calr.Count > 35)
            {
                var newDates = new List<int>();
                var over = calr.Count - 35;
                for (var i = 0; i < over; ++i)
                {
                    newDates.Add(calr[35 + i]);
                }

                for (var i = 0; i < 35; ++i)
                {
                    if (calr[i] != 0)
                    {
                        newDates.Add(calr[i]);
                    }
                }

                calr = newDates;
                count = calr.Count;
            }
            else
            {
                count = calr.Count;
            }

            for (var i = 0; i < count; ++i)
            {
                if (calr[i] != 0)
                {
                    var cdate = new DateTime(ViewModel.Year, ViewModel.Month, calr[i]);

                    btnList[i].SetTextColor(Color.Black);
                    btnList[i].Text = calr[i].ToString();
                    btnList[i].Tag = (int)i;
                }
                else
                {
                    btnList[i].Click -= SelectedButton;
                }
            }
        }
    }
}

