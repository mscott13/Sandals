using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using Sandals.Droid.Other;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Shell), typeof(CustomShellRenderer))]
namespace Sandals.Droid.Other
{
    public class CustomShellRenderer:ShellRenderer
    {
        public CustomShellRenderer(Context context) : base(context)
        {
        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new CustomBottomNavView();
        }

        public class CustomBottomNavView : IShellBottomNavViewAppearanceTracker
        {
            public void Dispose()
            {

            }

            public void ResetAppearance(BottomNavigationView bottomView)
            {

            }

            public void SetAppearance(BottomNavigationView bottomView, ShellAppearance appearance)
            {
                bottomView.SetBackgroundColor(Android.Graphics.Color.White);
                bottomView.SetElevation(4);
                bottomView.TextAlignment = Android.Views.TextAlignment.Center;
            }

            public void SetAppearance(BottomNavigationView bottomView, IShellAppearanceElement appearance)
            {
                throw new NotImplementedException();
            }
        }
    }
}