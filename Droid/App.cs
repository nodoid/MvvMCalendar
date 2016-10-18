using System;
using Android.App;
using Android.Runtime;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Ioc;

namespace MvvMCalendar.Droid
{
    [Application(Icon = "@mipmap/icon")]
    public class App : Application
    {
        private static ViewModelLocator locator;

        public App(IntPtr h, JniHandleOwnership jho)
            : base(h, jho)
        {
        }

        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null)
                {
                    // First time initialization
                    var nav = new NavigationService();
                    nav.Configure(
                        ViewModelLocator.MainKey,
                        typeof(MainActivity));

                    SimpleIoc.Default.Register<INavigationService>(() => nav);

                    locator = new ViewModelLocator();
                }

                return locator;
            }
        }

        public override void OnCreate()
        {
            base.OnCreate();
        }
    }
}
