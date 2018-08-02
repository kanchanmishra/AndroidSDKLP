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
using Com.Liveperson.Api;
using Com.Liveperson.Infra;

using Com.Liveperson.Messaging.Model;
using Android.Util;
using Com.Liveperson.Api.Sdk;
using Com.Liveperson.Messaging;
using Com.Liveperson.Infra.Log;
using Com.Liveperson.Messaging.Sdk.Api;

namespace LP_Messaging_App
{
    [BroadcastReceiver(Enabled = true, Exported = false)]
    public class LPReceiver : BroadcastReceiver
    {
        private static String TAG = MainActivity.GetInstance().LocalClassName;
        
        public Context context;

        public LPReceiver(Context appContext,bool showToastOnCallback)
        {
            context = appContext;
            IntentActionMethods.ShowToastOnCallback = showToastOnCallback;
            IntentActionMethods.Tag = TAG;
        }

        public override void OnReceive(Context context, Intent intent)
        {
            Log.Debug(TAG, "Got LP intent event with action " + intent.Action);
            switch (intent.Action)
            {
                case LivePersonIntents.LivePersonIntentAction.LpOnAgentAvatarTappedIntentAction:
                    IntentActionMethods.OnAgentAvatarTapped(LivePersonIntents.GetAgentData(intent), context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnAgentDetailsChangedIntentAction:
                    AgentData agentData = LivePersonIntents.GetAgentData(intent);
                    IntentActionMethods.OnAgentDetailsChanged(agentData, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnAgentTypingIntentAction:
                    Boolean isTyping = LivePersonIntents.GetAgentTypingValue(intent);
                    IntentActionMethods.OnAgentTyping(isTyping, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnConnectionChangedIntentAction:
                    Boolean isConnected = LivePersonIntents.GetConnectedValue(intent);
                    IntentActionMethods.OnConnectionChanged(isConnected, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnConversationMarkedAsNormalIntentAction:
                    IntentActionMethods.OnConversationMarkedAsNormal(context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnConversationMarkedAsUrgentIntentAction:
                    IntentActionMethods.OnConversationMarkedAsUrgent(context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnConversationResolvedIntentAction:
                    LPConversationData lpConversationData = LivePersonIntents.GetLPConversationData(intent);
                    IntentActionMethods.OnConversationResolved(lpConversationData, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnConversationStartedIntentAction:
                    LPConversationData lpConversationData1 = LivePersonIntents.GetLPConversationData(intent);
                    IntentActionMethods.OnConversationStarted(lpConversationData1, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnCsatLaunchedIntentAction:
                    IntentActionMethods.OnCsatLaunched(context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnCsatDismissedIntentAction:
                    IntentActionMethods.OnCsatDismissed(context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnCsatSkippedIntentAction:
                    IntentActionMethods.OnCsatSkipped(context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnCsatSubmittedIntentAction:
                    String conversationId = LivePersonIntents.GetConversationID(intent);
                    IntentActionMethods.OnCsatSubmitted(conversationId, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnErrorIntentAction:
                    TaskType type = LivePersonIntents.GetOnErrorTaskType(intent);
                    String message = LivePersonIntents.GetOnErrorMessage(intent);
                    IntentActionMethods.OnError(type, message, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnOfflineHoursChangesIntentAction:
                    IntentActionMethods.OnOfflineHoursChanges(LivePersonIntents.GetOfflineHoursOn(intent), context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnTokenExpiredIntentAction:
                    IntentActionMethods.OnTokenExpired(context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnUserDeniedPermission:
                    PermissionType deniedPermissionType = LivePersonIntents.GetPermissionType(intent);
                    Boolean doNotShowAgainMarked = LivePersonIntents.GetPermissionDoNotShowAgainMarked(intent);
                    IntentActionMethods.OnUserDeniedPermission(deniedPermissionType, doNotShowAgainMarked, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnUserActionOnPreventedPermission:
                    PermissionType preventedPermissionType = LivePersonIntents.GetPermissionType(intent);
                    IntentActionMethods.OnUserActionOnPreventedPermission(preventedPermissionType, context);
                    break;

                case LivePersonIntents.LivePersonIntentAction.LpOnStructuredContentLinkClicked:
                    String uri = LivePersonIntents.GetLinkUri(intent);
                    IntentActionMethods.OnStructuredContentLinkClicked(uri, context);
                    break;
            }
        }

        
    }
}