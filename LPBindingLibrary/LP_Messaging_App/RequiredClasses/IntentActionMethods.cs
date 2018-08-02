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
using Com.Liveperson.Api.Sdk;
using Com.Liveperson.Infra.Log;
using Com.Liveperson.Messaging;
using Com.Liveperson.Messaging.Model;

namespace LP_Messaging_App
{
    public class IntentActionMethods
    {
        public static bool ShowToastOnCallback;
        public static string Tag = string.Empty;


        public static void ShowToast(Context context, String message)
        {
            if (ShowToastOnCallback)
            {
                Toast.MakeText(context, message, ToastLength.Long).Show();
            }
            else
            {
                LPMobileLog.D(Tag + "_CALLBACK", message);
            }
        }

        public static void OnAgentAvatarTapped(AgentData agentData, Context context)
        {
            ShowToast(context,"on Agent Avatar Tapped - " + agentData.MFirstName + " " + agentData.MLastName);
        }


        public static void OnOfflineHoursChanges(Boolean isOfflineHoursOn, Context context)
        {
            ShowToast(context,"on Offline Hours Changes - " + isOfflineHoursOn);
        }

        public static void OnConversationMarkedAsNormal( Context context)
        {
            ShowToast(context,"Conversation Marked As Normal");
        }

        public static void OnConversationMarkedAsUrgent( Context context)
        {
            ShowToast(context,"Conversation Marked As Urgent");
        }

        public static void OnCsatSubmitted(String conversationId, Context context)
        {
            ShowToast(context,"on CSAT Submitted. ConversationID = " + conversationId);
        }

        public static void OnCsatLaunched(Context context)
        {
            ShowToast(context,"on CSAT Launched");
        }

        public static void OnCsatDismissed(Context context)
        {
            ShowToast(context,"on CSAT Dismissed");
        }

        public static void OnCsatSkipped( Context context)
        {
            ShowToast(context,"on CSAT Skipped");
        }

        public static void OnAgentDetailsChanged(AgentData agentData, Context context)
        {
            ShowToast(context,"Agent Details Changed " + agentData);
        }

        public static void OnAgentTyping(Boolean isTyping, Context context)
        {
            ShowToast(context,"isTyping " + isTyping);
        }

        public static void OnConnectionChanged(Boolean isConnected, Context context)
        {
            ShowToast(context,"onConnectionChanged " + isConnected);
        }

        public static void OnConversationResolved(LPConversationData convData, Context context)
        {
            ShowToast(context,"Conversation resolved " + convData.Id.ToString()
                    + " reason " + convData.CloseReason);
        }

        public static void OnConversationStarted(LPConversationData convData, Context context)
        {
            ShowToast(context,"Conversation started " + convData.Id.ToString()
                    + " reason " + convData.CloseReason);
        }

        public static void OnTokenExpired( Context context)
        {
            ShowToast(context,"onTokenExpired ");

            // Change authentication key here:
            // LivePerson.Reconnect(new LPAuthenticationParams().SetAuthKey(SampleAppStorage.getInstance(getApplicationContext()).getAuthCode()));
        }

        public static void OnError(TaskType type, String message, Context context)
        {
            ShowToast(context," problem " + type.Name());
        }

        public static void OnUserDeniedPermission(PermissionType permissionType, Boolean doNotShowAgainMarked, Context context)
        {
            ShowToast(context,"onUserDeniedPermission " + permissionType.Name() + " doNotShowAgainMarked = " + doNotShowAgainMarked);
        }

        public static void OnUserActionOnPreventedPermission(PermissionType permissionType, Context context)
        {
            ShowToast(context,"onUserActionOnPreventedPermission " + permissionType.Name());
        }

        public static void OnStructuredContentLinkClicked(String uri, Context context)
        {
            ShowToast(context,"onStructuredContentLinkClicked. Uri: " + uri);
        }
    }
}