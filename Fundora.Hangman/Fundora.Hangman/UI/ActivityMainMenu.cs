using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Fundora.Hangman.UI
{
    [Activity(Label = "Fundora Hangman", MainLauncher = true, Icon = "@drawable/icon")]
    public class ActivityMainMenu : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            try
            {
                base.OnCreate(bundle);
                RequestWindowFeature(WindowFeatures.NoTitle);
                Window.SetFlags(WindowManagerFlags.Fullscreen, WindowManagerFlags.Fullscreen);
                SetContentView(Resource.Layout.activity_main_menu);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
    }
}