using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Util;
using Com.Liveperson.Infra;
using Com.Liveperson.Messaging.Sdk.Api;
using LP_Messaging_App.Utils;

namespace LP_Messaging_App
{
    [Activity(Label = "Activity_Message")]
    public class Activity_Message : AppCompatActivity
    {
        private static String Tag = "Activity_Message";
        private static String livepersonFragment = "liveperson_fragment";
        int containerId;
        // har coaded user info
        string firstName = "K";
        string lastName = "M";
        string phone = string.Empty;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.MessageActivity);
           
            Log.Info(Tag, "onCreate savedInstanceState = " + savedInstanceState);
            LivePerson.Initialize(ApplicationContext, new InitLivePersonProperties(AppStorage.BrandID, AppStorage.FCM_APP_ID, new InitLivePersonCallBackInFragment(ApplicationContext, Tag, livepersonFragment, firstName, lastName, phone)));

        }
    }
}