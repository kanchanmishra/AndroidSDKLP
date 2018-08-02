using Android.App;
using Android.Widget;
using Android.OS;
using Com.Liveperson.Messaging.Model;

using Android.Content;
using System;
using Android.Text;
using Android.Support.V4.Content;
using Android.Util;

using Com.Liveperson.Messaging;
using Com.Liveperson.Messaging.Sdk;
using Com.Liveperson.Messaging.Sdk.Api;
using Com.Liveperson.Messaging.Sdk.Api.Model;
using Com.Liveperson.Messaging.Sdk.Api.Callbacks;
using Com.Liveperson.Api;
using Com.Liveperson.Infra;
using Com.Liveperson.Infra.Messaging;



namespace LP_Messaging_App
{
    [Activity(Label = "LP_Messaging_App", MainLauncher = true)]
    public class MainActivity : Activity
    {



        private static String TAG = MainActivity.GetInstance().LocalClassName;

        public static MainActivity Instance;
        private LivePersonCallbackImpl livePersonCallback;
        private BroadcastReceiver mLivePersonReceiver;
        private Boolean showToastOnCallback;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //ConsumerProfile cp = new ConsumerProfile();

        }

        public static MainActivity GetInstance()
        {
            return Instance;
        }

        public void RegisterToLivePersonEvents()
        {
            CreateLivePersonReceiver();
            LocalBroadcastManager.GetInstance(this.ApplicationContext).RegisterReceiver(mLivePersonReceiver, LivePersonIntents.getIntentFilterForAllEvents());
        }

        private void CreateLivePersonReceiver()
        {
            if (mLivePersonReceiver != null)
            {
                return;
            }
            mLivePersonReceiver = new LPReceiver();
        }

        public void RegisterToLivePersonCallbacks()
        {
            CreateLivePersonCallback();
            SetCallback(livePersonCallback);
        }
        public static void SetCallback(LivePersonCallbackImpl listener)
        {
            if (isValidState())
            {
                MessagingFactory messagingFactory;
                //Com.Liveperson.Messaging.MessagingFactory  = new MessagingFactory();
                messagingFactory.getInstance().getetController().setCallback(listener);
            }
        }



        private static bool isValidState()
        {
            bool initialized = MessagingUIFactory.getInstance().isInitialized();
            string mBrandId = null;
            bool isEmpty = TextUtils.IsEmpty(mBrandId);
            if (initialized && isEmpty)
            {
                mBrandId = MessagingUIFactory.getInstance().getMessagingUi().getInitBrandId();
            }

            Log.D(TAG, "init = " + initialized + " mBrandId = " + mBrandId);
            return initialized && !TextUtils.IsEmpty(mBrandId);
        }

        private void CreateLivePersonCallback()
        {
            if (livePersonCallback != null)
            {
                return;
            }
            livePersonCallback = new LivePersonCallbackImpl(). {
                @Override
                public void onError(TaskType type, String message)
                {
                    MainApplication.this.onError(type, message);
                }

                @Override
                public void onTokenExpired()
                {
                    MainApplication.this.onTokenExpired();
                }

                @Override
                public void onConversationStarted(LPConversationData convData)
                {
                    MainApplication.this.onConversationStarted(convData);
                }

                @Override
                public void onConversationResolved(LPConversationData convData)
                {
                    MainApplication.this.onConversationResolved(convData);
                }

                @Override
                public void onConversationResolved(CloseReason reason)
                {
                    /*Toast.makeText(getApplicationContext(), "onConversationResolved", Toast.LENGTH_LONG).show();*/
                }

                @Override
                public void onConnectionChanged(boolean isConnected)
                {
                    MainApplication.this.onConnectionChanged(isConnected);
                }

                @Override
                public void onAgentTyping(boolean isTyping)
                {
                    MainApplication.this.onAgentTyping(isTyping);
                }

                @Override
                public void onAgentDetailsChanged(AgentData agentData)
                {
                    MainApplication.this.onAgentDetailsChanged(agentData);
                }

                @Override
    
            public void onCsatLaunched()
                {
                    MainApplication.this.onCsatLaunched();
                }

                @Override
                public void onCsatDismissed()
                {
                    MainApplication.this.onCsatDismissed();
                }

                @Override
                public void onCsatSubmitted(String conversationId)
                {
                    MainApplication.this.onCsatSubmitted(conversationId);
                }

                @Override
    
            public void onCsatSkipped()
                {
                    MainApplication.this.onCsatSkipped();
                }

                @Override
                public void onConversationMarkedAsUrgent()
                {
                    MainApplication.this.onConversationMarkedAsUrgent();
                }

                @Override
                public void onConversationMarkedAsNormal()
                {
                    MainApplication.this.onConversationMarkedAsNormal();
                }

                @Override
                public void onOfflineHoursChanges(boolean isOfflineHoursOn)
                {
                    MainApplication.this.onOfflineHoursChanges(isOfflineHoursOn);
                }

                @Override
                public void onAgentAvatarTapped(AgentData agentData)
                {
                    MainApplication.this.onAgentAvatarTapped(agentData);

                }

                @Override
    
            public void onUserDeniedPermission(PermissionType permissionType, boolean doNotShowAgainMarked)
                {
                    MainApplication.this.onUserDeniedPermission(permissionType, doNotShowAgainMarked);
                }

                @Override
    
            public void onUserActionOnPreventedPermission(PermissionType permissionType)
                {
                    MainApplication.this.onUserActionOnPreventedPermission(permissionType);
                }

                @Override
    
            public void onStructuredContentLinkClicked(String uri)
                {
                    MainApplication.this.onStructuredContentLinkClicked(uri);
                }
            };
        }


        public void setShowToastOnCallback(boolean showToastOnCallback)
        {
            this.showToastOnCallback = showToastOnCallback;
        }
        private void showToast(String message)
        {
            if (showToastOnCallback)
            {
                Toast.makeText(getApplicationContext(), message, Toast.LENGTH_SHORT).show();
            }
            else
            {
                LPMobileLog.d(TAG + "_CALLBACK", message);
            }
        }

        private void onAgentAvatarTapped(AgentData agentData)
        {
            showToast("on Agent Avatar Tapped - " + agentData.mFirstName + " " + agentData.mLastName);
        }


        private void onOfflineHoursChanges(boolean isOfflineHoursOn)
        {
            showToast("on Offline Hours Changes - " + isOfflineHoursOn);
        }

        private void onConversationMarkedAsNormal()
        {
            showToast("Conversation Marked As Normal");
        }

        private void onConversationMarkedAsUrgent()
        {
            showToast("Conversation Marked As Urgent");
        }

        private void onCsatSubmitted(String conversationId)
        {
            showToast("on CSAT Submitted. ConversationID = " + conversationId);
        }

        private void onCsatLaunched()
        {
            showToast("on CSAT Launched");
        }

        private void onCsatDismissed()
        {
            showToast("on CSAT Dismissed");
        }

        private void onCsatSkipped()
        {
            showToast("on CSAT Skipped");
        }

        private void onAgentDetailsChanged(AgentData agentData)
        {
            showToast("Agent Details Changed " + agentData);
        }

        private void onAgentTyping(boolean isTyping)
        {
            showToast("isTyping " + isTyping);
        }

        private void onConnectionChanged(boolean isConnected)
        {
            showToast("onConnectionChanged " + isConnected);
        }

        private void onConversationResolved(LPConversationData convData)
        {
            showToast("Conversation resolved " + convData.getId()
                    + " reason " + convData.getCloseReason());
        }

        private void onConversationStarted(LPConversationData convData)
        {
            showToast("Conversation started " + convData.getId()
                    + " reason " + convData.getCloseReason());
        }

        private void onTokenExpired()
        {
            showToast("onTokenExpired ");

            // Change authentication key here:
            LivePerson.reconnect(new LPAuthenticationParams().setAuthKey(SampleAppStorage.getInstance(getApplicationContext()).getAuthCode()));
        }

        private void onError(TaskType type, String message)
        {
            showToast(" problem " + type.name());
        }

        private void onUserDeniedPermission(PermissionType permissionType, boolean doNotShowAgainMarked)
        {
            showToast("onUserDeniedPermission " + permissionType.name() + " doNotShowAgainMarked = " + doNotShowAgainMarked);
        }

        private void onUserActionOnPreventedPermission(PermissionType permissionType)
        {
            showToast("onUserActionOnPreventedPermission " + permissionType.name());
        }

        private void onStructuredContentLinkClicked(String uri)
        {
            showToast("onStructuredContentLinkClicked. Uri: " + uri);
        }

    }
}

