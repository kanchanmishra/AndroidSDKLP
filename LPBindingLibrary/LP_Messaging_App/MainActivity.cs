using Android.App;
using Android.Content;
using Android.OS;

using Android.Widget;
//using Com.Bupa.Lpandroidlibrary;
using Com.Liveperson.Api;
using Com.Liveperson.Infra;
using Com.Liveperson.Infra.Callbacks;
using Com.Liveperson.Messaging.Sdk.Api;
using Java.Lang;
using System;
using LP_Messaging_App.Utils;
using Android.Support.V7.App;
using Android.Support.V4.Content;
using Com.Liveperson.Messaging;

namespace LP_Messaging_App
{
    [Activity(Label = "LP_Messaging_App", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private LivePersonCallbackImpl livePersonCallback;
        private BroadcastReceiver mLivePersonReceiver;
        private bool showToastOnCallback;
        public static MainActivity Instance;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            RegisterToLivePersonEvents();
            MonitoringInitParams monitoringInitParams = new MonitoringInitParams(AppStorage.MAppinstallid);

            LivePerson.Initialize(ApplicationContext, new InitLivePersonProperties(AppStorage.BrandID, AppStorage.FCM_APP_ID, monitoringInitParams, new InitLivePersonCallBackStartActivity(this)));


        }
        public static MainActivity GetInstance()
        {
            return Instance;
        }
        /// <summary>
        /// RegisterToLivePersonEvents
        /// </summary>
        protected void RegisterToLivePersonEvents()
        {
            CreateLivePersonReceiver();
            LocalBroadcastManager.GetInstance(ApplicationContext)
                    .RegisterReceiver(mLivePersonReceiver, LivePersonIntents.IntentFilterForAllEvents);
        }
        /// <summary>
        /// CreateLivePersonReceiver
        /// </summary>
        private void CreateLivePersonReceiver()
        {
            if (mLivePersonReceiver != null)
            {
                return;
            }
            mLivePersonReceiver = new LPReceiver(ApplicationContext, showToastOnCallback);

        }

        public void SetShowToastOnCallback(bool showToastOnCallback)
        {
            this.showToastOnCallback = showToastOnCallback;
        }
        /// <summary>
        /// RegisterToLivePersonCallbacks
        /// </summary>
        public void RegisterToLivePersonCallbacks()
        {
            CreateLivePersonCallback();
            LivePerson.SetCallback(livePersonCallback);
        }

        public void CreateLivePersonCallback()
        {
            if (livePersonCallback != null)
            {
                return;
            }
            livePersonCallback = new LivePersonCallback(ApplicationContext);
        }

    }
}

