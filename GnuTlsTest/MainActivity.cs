using Android.Util;
using System.Net;
using FluentFTP;
using FluentFTP.GnuTLS;
using GnuTlsTestLib;

//using FluentFTP.GnuTLS;

namespace GnuTlsTest
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);
            FindViewById(Resource.Id.app_text).Click += delegate
            {
                Task.Run(() =>
                {
                    new FtpTester().RunTest();
                });
            };

            
        }

    }
}