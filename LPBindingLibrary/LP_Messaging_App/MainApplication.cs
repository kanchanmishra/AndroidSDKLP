using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using Com.Liveperson.Api;
using Com.Liveperson.Messaging.Sdk.Api;

namespace LP_Messaging_App
{
    [Application]
    public class MainApplication : Application
    {
        private LivePersonCallbackImpl livePersonCallback;
        private BroadcastReceiver mLivePersonReceiver;
        private bool showToastOnCallback = true;
        public static MainApplication Instance { get; set; }

       
        public MainApplication(IntPtr handle, global::Android.Runtime.JniHandleOwnership transfer)
            : base(handle, transfer)
        {

        }

        public override void OnCreate()
        {
            base.OnCreate();
            Instance = this;
            RegisterToLivePersonEvents();
        }
       
        /// <summary>
        /// RegisterToLivePersonEvents
        /// </summary>
        public void RegisterToLivePersonEvents()
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


            var lPReceiverNew = new LPReceiver(ApplicationContext, showToastOnCallback);
            var lPReceiver = new LPReceiver();
            mLivePersonReceiver = lPReceiver;

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
