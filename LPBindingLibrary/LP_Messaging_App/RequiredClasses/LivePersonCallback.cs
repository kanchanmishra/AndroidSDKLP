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
using Com.Liveperson.Api.Response.Types;
using Com.Liveperson.Api.Sdk;
using Com.Liveperson.Messaging;
using Com.Liveperson.Messaging.Model;

namespace LP_Messaging_App
{
    public class LivePersonCallback : LivePersonCallbackImpl
    {
        public Context context;

        public LivePersonCallback(Context appContext)
        {
            context = appContext;
        }

        public override void OnAgentAvatarTapped(AgentData p0)
        {
            IntentActionMethods.OnAgentAvatarTapped(p0, context);
        }

        public override void OnAgentDetailsChanged(AgentData p0)
        {
            IntentActionMethods.OnAgentDetailsChanged(p0, context);
        }

        public override void OnAgentTyping(bool p0)
        {
            IntentActionMethods.OnAgentTyping(p0, context);
        }

        public override void OnConnectionChanged(bool p0)
        {
            IntentActionMethods.OnConnectionChanged(p0, context);
        }

        public override void OnConversationMarkedAsNormal()
        {
            IntentActionMethods.OnConversationMarkedAsNormal(context);
        }

        public override void OnConversationMarkedAsUrgent()
        {
            IntentActionMethods.OnConversationMarkedAsUrgent(context);
        }


        public override void OnConversationResolved(LPConversationData p0)
        {
            IntentActionMethods.OnConversationResolved(p0, context);
        }

      

        public override void OnConversationStarted(LPConversationData p0)
        {
            IntentActionMethods.OnConversationStarted(p0, context);
        }

        public override void OnCsatDismissed()
        {
            IntentActionMethods.OnCsatDismissed(context);
        }

        public override void OnCsatLaunched()
        {
            IntentActionMethods.OnCsatLaunched(context);
        }

        public override void OnCsatSkipped()
        {
            IntentActionMethods.OnCsatSkipped(context);
        }

        public override void OnCsatSubmitted(string p0)
        {
            IntentActionMethods.OnCsatSubmitted(p0, context);
        }

        public override void OnError(TaskType p0, string p1)
        {
            IntentActionMethods.OnError(p0, p1, context);
        }

        public override void OnOfflineHoursChanges(bool p0)
        {
            IntentActionMethods.OnOfflineHoursChanges(p0, context);
        }

        public override void OnStructuredContentLinkClicked(string p0)
        {
            IntentActionMethods.OnStructuredContentLinkClicked(p0, context);
        }

        public override void OnTokenExpired()
        {
            IntentActionMethods.OnTokenExpired( context);
        }

        public override void OnUnauthenticatedUserExpired()
        {
           // IntentActionMethods.OnUnauthenticatedUserExpired(context);
        }

        public override void OnUserActionOnPreventedPermission(PermissionType p0)
        {
            IntentActionMethods.OnUserActionOnPreventedPermission(p0, context);
        }

        public override void OnUserDeniedPermission(PermissionType p0, bool p1)
        {
            IntentActionMethods.OnUserDeniedPermission(p0, p1, context);
        }
    }
}