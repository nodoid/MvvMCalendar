using System;

using UIKit;
using System.Collections.Generic;
using MvvMCalendar.ViewModel;
using System.Linq;
using CoreGraphics;
using GalaSoft.MvvmLight.Helpers;

namespace MvvMCalendar.iOS
{
    public partial class ViewController : UIViewController
    {
        int currDate;
        List<UIButton> btnList;
        List<int> cal = new List<int>();

        public MainViewModel ViewModel => AppDelegate.Locator.Main;

        public ViewController(IntPtr handle) : base(handle)
        {
            ViewModel.Year = DateTime.Now.Year;
            ViewModel.Month = DateTime.Now.Month;
            ViewModel.Day = DateTime.Now.Day;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetupVars();

            SetupButtonEvents();

            SetupUI();

            SetupBindings();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }

        void SetupVars()
        {
            btnList = new List<UIButton>
            {
                btn1,
                btn2,
                btn3,
                btn4,
                btn5,
                btn6,
                btn7,
                btn8,
                btn9,
                btn10,
                btn11,
                btn12,
                btn13,
                btn14,
                btn15,
                btn16,
                btn17,
                btn18,
                btn19,
                btn20,
                btn21,
                btn22,
                btn23,
                btn24,
                btn25,
                btn26,
                btn27,
                btn28,
                btn29,
                btn30,
                btn31,
                btn32,
                btn33,
                btn34,
                btn35
            };

            cal = ViewModel.GenerateCalendar();
            PopulateCalendar(cal);
        }

        void SetupButtonEvents()
        {
            btnBack.Clicked += delegate
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
            btnNext.Clicked += delegate
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

        void SetupUI()
        {
            btnBack.Title = "Prev";
            btnNext.Title = "Next";
            foreach (var btn in btnList)
            {
                btn.Layer.BorderColor = UIColor.Blue.CGColor;
                btn.Layer.BorderWidth = 2;
            }

            var index = btnList.FirstOrDefault(t => t.Title(UIControlState.Normal) == DateTime.Now.Day.ToString());
            btnList[(int)index.Tag].BackgroundColor = UIColor.LightGray;
            currDate = DateTime.Now.Day;
        }

        void SetupBindings()
        {
            this.SetBinding(
                () => ViewModel.Title,
                () => txtTitle.Text,
                BindingMode.OneWay);

            this.SetBinding(
                () => ViewModel.MonthName,
                () => txtMonth.Title,
                BindingMode.Default).WhenSourceChanges(() => txtMonth.Title = ViewModel.MonthName);
        }

        void ClearCalendar()
        {
            if (btnList.Count != 0)
            {
                foreach (var btn in btnList)
                {
                    foreach (var v in btn.Subviews)
                    {
                        if (v is UILabel)
                        {
                            v.RemoveFromSuperview();
                        }

                        if (v is UIImageView)
                        {
                            v.RemoveFromSuperview();
                        }
                    }

                    btn.TouchUpInside -= SelectedButton;
                }
            }
        }

        void SelectedButton(object sender, EventArgs e)
        {
            var btn = sender as UIButton;
            if ((int)btn.Tag != currDate)
            {
                btnList[(int)btn.Tag].BackgroundColor = UIColor.White;
                currDate = (int)btn.Tag;
                btn.BackgroundColor = UIColor.LightGray;
            }
        }

        void PopulateCalendar(List<int> cald)
        {
            var count = 0;
            if (cald.Count > 35)
            {
                var newDates = new List<int>();
                var over = cald.Count - 35;
                for (var i = 0; i < over; ++i)
                {
                    newDates.Add(cald[35 + i]);
                }

                for (var i = 0; i < 35; ++i)
                {
                    if (cald[i] != 0)
                    {
                        newDates.Add(cald[i]);
                    }
                }

                cald = newDates;
                count = cald.Count;
            }
            else
            {
                count = cald.Count;
            }

            for (var i = 0; i < count; ++i)
            {
                if (cald[i] != 0)
                {
                    var cdate = new DateTime(ViewModel.Year, ViewModel.Month, cald[i]);
                    var tmpLbl = new UILabel(new CGRect(2, 2, 30, 12))
                    {
                        Frame = new CGRect(new CGPoint(2, 2), new CGSize(30, 12)),
                        Text = cald[i].ToString()
                    };
                    btnList[i].Tag = cald[i];
                    btnList[i].AddSubview(tmpLbl);
                }
                else
                {
                    btnList[i].TouchUpInside -= SelectedButton;
                }
            }
        }
    }
}
