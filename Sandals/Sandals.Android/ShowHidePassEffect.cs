using Android.Content.Res;
using Android.Support.Design.Widget;
using Android.Support.V4.Content;
using Android.Support.V4.Content.Res;
using Android.Text.Method;
using Android.Views;
using Android.Widget;
using Sandals.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(ShowHidePassEffect), "ShowHidePassEffect")]
namespace Sandals.Droid
{
    public class ShowHidePassEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            ConfigureControl();
        }

        protected override void OnDetached()
        {
        }

        private void ConfigureControl()
        {
            TextInputLayout textInputLayout = ((TextInputLayout)Control);
            EditText edit = textInputLayout.EditText;
            edit.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, Resource.Drawable.hide_password, 0);
            edit.SetOnTouchListener(new OnDrawableTouchListener());
        }
    }

    public class OnDrawableTouchListener : Java.Lang.Object, Android.Views.View.IOnTouchListener
    {
        public bool OnTouch(Android.Views.View v, MotionEvent e)
        {
            if (v is EditText && e.Action == MotionEventActions.Up)
            {
                EditText editText = (EditText)v;
                if (e.RawX >= (editText.Right - editText.GetCompoundDrawables()[2].Bounds.Width()))
                {
                    if (editText.TransformationMethod == null)
                    {
                        editText.TransformationMethod = PasswordTransformationMethod.Instance;
                        editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, Resource.Drawable.hide_password , 0);
                    }
                    else
                    {
                        editText.TransformationMethod = null;
                        editText.SetCompoundDrawablesRelativeWithIntrinsicBounds(0, 0, Resource.Drawable.show_password, 0);
                    }

                    return true;
                }
            }

            return false;
        }
    }
}