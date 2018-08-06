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

namespace Com.Liveperson.Api.Request.Message
{

    public partial class TextPublishMessage
    {
        static IntPtr id_getMessage;
        public override unsafe Java.Lang.Object Message
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']/method[@name='getMessage' and count(parameter)=0]"
            [Register("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
            get
            {
                if (id_getMessage == IntPtr.Zero)
                    id_getMessage = JNIEnv.GetMethodID(class_ref, "getMessage", "()Ljava/lang/String;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
                    else
                        return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }

    public partial class JsonPublishMessage
    {
        static IntPtr id_getMessage;
        public override unsafe Java.Lang.Object Message
        {
            // Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.request.message']/class[@name='JsonPublishMessage']/method[@name='getMessage' and count(parameter)=0]"
            [Register("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
            get
            {
                if (id_getMessage == IntPtr.Zero)
                    id_getMessage = JNIEnv.GetMethodID(class_ref, "getMessage", "()Ljava/lang/String;");
                try
                {

                    if (((object)this).GetType() == ThresholdType)
                        return JNIEnv.GetString(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
                    else
                        return JNIEnv.GetString(JNIEnv.CallNonvirtualObjectMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "getMessage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }
}