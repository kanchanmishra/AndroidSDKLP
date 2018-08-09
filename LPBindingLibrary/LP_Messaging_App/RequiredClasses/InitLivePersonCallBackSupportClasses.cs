using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V4.App;
using Android.Util;
using Java.Lang;
using Android.Views;
using Android.Widget;
using Com.Liveperson.Infra.Callbacks;
using Com.Liveperson.Infra.Messaging_ui.Uicomponents.List;
using Com.Liveperson.Infra.Messaging_ui;
using Com.Liveperson.Infra;
using Com.Liveperson.Messaging.Sdk.Api;
using Com.Liveperson.Messaging.Sdk.Api.Model;
using Com.Liveperson.Infra.Messaging_ui.Fragment;

namespace LP_Messaging_App
{

    
    public class InitLivePersonCallBackStartActivity : Java.Lang.Object, IInitLivePersonCallBack
    {
         static Context contextStartActivity;
        public InitLivePersonCallBackStartActivity() {

            
            try
            {
                OnInitSucceed();
            }
            catch (Java.Lang.Exception var1)
            {
                OnInitFailed(var1);
            }
        }

        public InitLivePersonCallBackStartActivity(Context context)
        {
            contextStartActivity = context;
        }

        //public IntPtr Handle ;// => throw new NotImplementedException();

        
        //public void onInitFailed(Java.Lang.Exception var1)
        //{
        //    Toast.MakeText(this.context, "Init failed", ToastLength.Long).Show();
        //}

        public  void OnInitFailed(Java.Lang.Exception p0)
        {
            Toast.MakeText(contextStartActivity, "Init failed", ToastLength.Long).Show();
        }

        public  void OnInitSucceed()
        {
            Intent intent = new Intent(contextStartActivity, typeof(Activity_Message));

            contextStartActivity.StartActivity(intent);
            //Application.Context.StartActivity(intent);
        }
    }

    public class InitLivePersonCallBackInFragment : AppCompatActivity, IInitLivePersonCallBack
    {
        private static Context CallBackInFragmentcontext;
        private static string Tag;
        private static string LivepersonFragment;
        private static string FirstName;
        private static string LastName;
        private static string Phone;
        
        public InitLivePersonCallBackInFragment(Context context, string tag, string livepersonFragment, string firstName, string lastName, string phone)
        {
            CallBackInFragmentcontext = context;
            Tag = tag;
            LivepersonFragment = livepersonFragment;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public InitLivePersonCallBackInFragment() {

            try
            {
                OnInitSucceed();
            }
            catch (Java.Lang.Exception var1)
            {
                OnInitFailed(var1);
            }

        }

        public void OnInitFailed(Java.Lang.Exception p0)
        {
            Log.Error(Tag, "onInitFailed : " + p0.Message);
        }

        public void OnInitSucceed()
        {
            Log.Info(Tag, "onInitSucceed");
            var runnableHelper = new RunnableHelper(Tag, LivepersonFragment, CallBackInFragmentcontext);

            /*
            RunOnUiThread(() =>
                //{
                // Run()
                InitFragment()
            // }
            );

            */

             RunOnUiThread(new RunnableHelper());

            /* original Android implementaion
            runOnUiThread(new Runnable() {
                    @Override
                    public void run()
            {
                initFragment(fragment_container_id);
            }
            }); */

            SetCallBack();

            ConsumerProfile consumerProfile = new ConsumerProfile.Builder()
                    .SetFirstName(FirstName)
                    .SetLastName(LastName)
                    .SetPhoneNumber(Phone)
                    .Build();
            LivePerson.SetUserProfile(consumerProfile);

            //Constructing the notification builder for the upload/download foreground service and passing it to the SDK.
            /*

             Notification.Builder uploadBuilder = NotificationUI.createUploadNotificationBuilder(getApplicationContext());
             Notification.Builder downloadBuilder = NotificationUI.createDownloadNotificationBuilder(getApplicationContext());
             LivePerson.setImageServiceUploadNotificationBuilder(uploadBuilder);
             LivePerson.setImageServiceDownloadNotificationBuilder(downloadBuilder);
             */

        }

        private void SetCallBack()
        {
            //register via callback, also available to listen via BroadCastReceiver in Main Application
            MainApplication.Instance.RegisterToLivePersonCallbacks();
        }
    }

    public class RunnableHelper : AppCompatActivity, Java.Lang.IRunnable
    {
        private static ConversationFragment mConversationFragment;
        private static Context CallBackInFragmentcontext;
        public static string Tag;
        public static string LivepersonFragment;

        public RunnableHelper(string tag, string livepersonFragment, Context context)
        {
            CallBackInFragmentcontext = context;
            Tag = tag;
            LivepersonFragment = livepersonFragment;
        }
        public RunnableHelper()
        {
            Run();
        }
        public void Run()
        {
            InitFragment();
        }

        private void InitFragment()
        {
            mConversationFragment = (ConversationFragment)SupportFragmentManager.FindFragmentByTag(LivepersonFragment);
            Log.Debug(Tag, "initFragment. mConversationFragment = " + mConversationFragment);

            try
            {
                if (mConversationFragment == null)
                {
                    /*

                    String authCode = SampleAppStorage.getInstance(FragmentContainerActivity.this).getAuthCode();
                    String publicKey = SampleAppStorage.getInstance(FragmentContainerActivity.this).getPublicKey();

                    Log.d(TAG, "initFragment. authCode = "+ authCode);
                    Log.d(TAG, "initFragment. publicKey = "+ publicKey);
                    LPAuthenticationParams authParams = new LPAuthenticationParams();
                    authParams.setAuthKey(authCode);
                    authParams.addCertificatePinningKey(publicKey);
                */
                    LPAuthenticationParams authParams = new LPAuthenticationParams();
                    CampaignInfo campaignInfo = null;//SampleAppUtils.getCampaignInfo(this);
                    ConversationViewParams conversationViewParams = new ConversationViewParams().SetCampaignInfo(campaignInfo).SetReadOnlyMode(isReadOnly());
                    mConversationFragment = (ConversationFragment)LivePerson.GetConversationFragment(authParams, conversationViewParams);

                    if (isValidState())
                    {

                        // Pending intent for image foreground service
                        Intent notificationIntent = new Intent(CallBackInFragmentcontext, typeof(Activity_Message));
                        //notificationIntent.SetFlags(Intent.Flags);
                        PendingIntent pendingIntent = PendingIntent.GetActivity(CallBackInFragmentcontext, 0, notificationIntent, 0);
                        LivePerson.SetImageServicePendingIntent(pendingIntent);

                        // Notification builder for image upload foreground service
                        Notification.Builder uploadBuilder = new Notification.Builder(CallBackInFragmentcontext);
                        Notification.Builder downloadBuilder = new Notification.Builder(CallBackInFragmentcontext);
                        uploadBuilder.SetContentTitle("Uploading image")
                                        //.SetSmallIcon(Android.R.drawable.arrow_up_float)
                                        .SetContentIntent(pendingIntent)
                                        .SetProgress(0, 0, true);

                        downloadBuilder.SetContentTitle("Downloading image")
                                        //.setSmallIcon(Android.R.drawable.arrow_down_float)
                                        .SetContentIntent(pendingIntent)
                                        .SetProgress(0, 0, true);

                        LivePerson.SetImageServiceUploadNotificationBuilder(uploadBuilder);
                        LivePerson.SetImageServiceDownloadNotificationBuilder(downloadBuilder);

                        var ft = SupportFragmentManager.BeginTransaction();
                        ft.Add(Resource.Id.frameLayout1, mConversationFragment, LivepersonFragment).CommitAllowingStateLoss();
                    }
                }
                else
                {
                    AttachFragment();
                }
            }
            catch(Java.Lang.Exception e) { throw e; }
        }

        private bool isReadOnly()
        {
            // return Intent.GetBooleanExtra(Infra.KeyReadOnly, false);
            return false;
        }

        private bool isValidState()
        {
            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.JellyBeanMr1)
            {
                return !IsFinishing && !IsDestroyed;
            }
            else
            {
                return !IsFinishing;
            }
        }


        private void AttachFragment()
        {
            if (mConversationFragment.IsDetached)
            {
                Log.Debug(Tag, "initFragment. attaching fragment");
                if (isValidState())
                {
                    var ft = SupportFragmentManager.BeginTransaction();
                    ft.Attach(mConversationFragment).CommitAllowingStateLoss();
                }
            }
        }
    }
}

