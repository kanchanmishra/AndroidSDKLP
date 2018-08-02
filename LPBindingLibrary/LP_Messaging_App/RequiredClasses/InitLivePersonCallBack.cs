using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Liveperson.Infra.Callbacks;
using Com.Liveperson.Infra.Messaging_ui.Fragment;
using Java.Lang;
using Com.Liveperson.Infra;
using Com.Liveperson.Messaging.Sdk.Api;
using Com.Liveperson.Messaging.Sdk.Api.Model;

namespace LP_Messaging_App
{
    public class InitLivePersonCallBackStartActivity : AppCompatActivity, IInitLivePersonCallBack
    {
        private Context context;

        public InitLivePersonCallBackStartActivity(Context context)
        {
            this.context = context;

        }

        public IntPtr Handle => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnInitFailed(Java.Lang.Exception p0)
        {
            Toast.MakeText(this.context, "Init failed", ToastLength.Long).Show();
        }

        public void OnInitSucceed()
        {
            Intent intent = new Intent(context, typeof(Activity_Message));

            this.StartActivity(intent);
        }
    }

    class InitLivePersonCallBackInFragment : AppCompatActivity, IInitLivePersonCallBack
    {
        private Context context;
        private string Tag;
        string LivepersonFragment;
        string FirstName;
        string LastName;
        string Phone;
        public InitLivePersonCallBackInFragment(Context context, string tag,  string livepersonFragment, string firstName, string lastName, string phone)
        {
            this.context = context;
            Tag = tag;
            LivepersonFragment = livepersonFragment;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public void OnInitFailed(Java.Lang.Exception p0)
        {
            Log.Error(Tag, "onInitFailed : " + p0.Message);
        }

        public void OnInitSucceed()
        {
            Log.Info(Tag, "onInitSucceed");

            RunOnUiThread(() =>
            {
               var runnableHelper = new RunnableHelper( Tag, LivepersonFragment);
                runnableHelper.Run();
            });

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
            MainActivity.GetInstance().RegisterToLivePersonCallbacks();
        }
    }

    public class RunnableHelper : AppCompatActivity, Java.Lang.IRunnable
    {
        private ConversationFragment mConversationFragment;
        
        public string TAG;
        public string LIVEPERSON_FRAGMENT;
        public RunnableHelper( string tag, string livepersonFragment)
        {
            
            TAG = tag;
            LIVEPERSON_FRAGMENT = livepersonFragment;
        }

        public void Run()
        {
            InitFragment();
        }

        private void InitFragment()
        {
            mConversationFragment = (ConversationFragment)SupportFragmentManager.FindFragmentByTag(LIVEPERSON_FRAGMENT);
            Log.Debug(TAG, "initFragment. mConversationFragment = " + mConversationFragment);
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
                    Intent notificationIntent = new Intent(this, typeof(Activity_Message));
                    notificationIntent.SetFlags(Intent.Flags);
                    PendingIntent pendingIntent = PendingIntent.GetActivity(this, 0, notificationIntent, 0);
                    LivePerson.SetImageServicePendingIntent(pendingIntent);

                    // Notification builder for image upload foreground service
                    Notification.Builder uploadBuilder = new Notification.Builder(this.ApplicationContext);
                    Notification.Builder downloadBuilder = new Notification.Builder(this.ApplicationContext);
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
                    ft.Add(Resource.Id.frameLayout1, mConversationFragment, LIVEPERSON_FRAGMENT).CommitAllowingStateLoss();
                }
            }
            else
            {
                AttachFragment();
            }
        }

        private bool isReadOnly()
        {
            return Intent.GetBooleanExtra(Infra.KeyReadOnly, false);
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
                Log.Debug(TAG, "initFragment. attaching fragment");
                if (isValidState())
                {
                    var ft = SupportFragmentManager.BeginTransaction();
                    ft.Attach(mConversationFragment).CommitAllowingStateLoss();
                }
            }
        }
    }
}

