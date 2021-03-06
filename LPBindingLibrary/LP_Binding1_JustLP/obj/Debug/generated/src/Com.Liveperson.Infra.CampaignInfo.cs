using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']"
	[global::Android.Runtime.Register ("com/liveperson/infra/CampaignInfo", DoNotGenerateAcw=true)]
	public partial class CampaignInfo : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/CampaignInfo", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CampaignInfo); }
		}

		protected CampaignInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/constructor[@name='CampaignInfo' and count(parameter)=5 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CampaignInfo (global::Java.Lang.Long p0, global::Java.Lang.Long p1, string p2, string p3, string p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				if (((object) this).GetType () != typeof (CampaignInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/constructor[@name='CampaignInfo' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe CampaignInfo (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CampaignInfo)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getCampaignId;
#pragma warning disable 0169
		static Delegate GetGetCampaignIdHandler ()
		{
			if (cb_getCampaignId == null)
				cb_getCampaignId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampaignId);
			return cb_getCampaignId;
		}

		static IntPtr n_GetCampaignId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CampaignId);
		}
#pragma warning restore 0169

		static Delegate cb_setCampaignId_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetCampaignId_Ljava_lang_Long_Handler ()
		{
			if (cb_setCampaignId_Ljava_lang_Long_ == null)
				cb_setCampaignId_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCampaignId_Ljava_lang_Long_);
			return cb_setCampaignId_Ljava_lang_Long_;
		}

		static void n_SetCampaignId_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CampaignId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCampaignId;
		static IntPtr id_setCampaignId_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long CampaignId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='getCampaignId' and count(parameter)=0]"
			[Register ("getCampaignId", "()Ljava/lang/Long;", "GetGetCampaignIdHandler")]
			get {
				if (id_getCampaignId == IntPtr.Zero)
					id_getCampaignId = JNIEnv.GetMethodID (class_ref, "getCampaignId", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCampaignId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCampaignId", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='setCampaignId' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setCampaignId", "(Ljava/lang/Long;)V", "GetSetCampaignId_Ljava_lang_Long_Handler")]
			set {
				if (id_setCampaignId_Ljava_lang_Long_ == IntPtr.Zero)
					id_setCampaignId_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setCampaignId", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCampaignId_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCampaignId", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getContextId;
#pragma warning disable 0169
		static Delegate GetGetContextIdHandler ()
		{
			if (cb_getContextId == null)
				cb_getContextId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContextId);
			return cb_getContextId;
		}

		static IntPtr n_GetContextId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ContextId);
		}
#pragma warning restore 0169

		static Delegate cb_setContextId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetContextId_Ljava_lang_String_Handler ()
		{
			if (cb_setContextId_Ljava_lang_String_ == null)
				cb_setContextId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetContextId_Ljava_lang_String_);
			return cb_setContextId_Ljava_lang_String_;
		}

		static void n_SetContextId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ContextId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getContextId;
		static IntPtr id_setContextId_Ljava_lang_String_;
		public virtual unsafe string ContextId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='getContextId' and count(parameter)=0]"
			[Register ("getContextId", "()Ljava/lang/String;", "GetGetContextIdHandler")]
			get {
				if (id_getContextId == IntPtr.Zero)
					id_getContextId = JNIEnv.GetMethodID (class_ref, "getContextId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContextId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContextId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='setContextId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setContextId", "(Ljava/lang/String;)V", "GetSetContextId_Ljava_lang_String_Handler")]
			set {
				if (id_setContextId_Ljava_lang_String_ == IntPtr.Zero)
					id_setContextId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setContextId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContextId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContextId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEngagementId;
#pragma warning disable 0169
		static Delegate GetGetEngagementIdHandler ()
		{
			if (cb_getEngagementId == null)
				cb_getEngagementId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEngagementId);
			return cb_getEngagementId;
		}

		static IntPtr n_GetEngagementId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EngagementId);
		}
#pragma warning restore 0169

		static Delegate cb_setEngagementId_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSetEngagementId_Ljava_lang_Long_Handler ()
		{
			if (cb_setEngagementId_Ljava_lang_Long_ == null)
				cb_setEngagementId_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEngagementId_Ljava_lang_Long_);
			return cb_setEngagementId_Ljava_lang_Long_;
		}

		static void n_SetEngagementId_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.EngagementId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getEngagementId;
		static IntPtr id_setEngagementId_Ljava_lang_Long_;
		public virtual unsafe global::Java.Lang.Long EngagementId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='getEngagementId' and count(parameter)=0]"
			[Register ("getEngagementId", "()Ljava/lang/Long;", "GetGetEngagementIdHandler")]
			get {
				if (id_getEngagementId == IntPtr.Zero)
					id_getEngagementId = JNIEnv.GetMethodID (class_ref, "getEngagementId", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEngagementId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEngagementId", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='setEngagementId' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
			[Register ("setEngagementId", "(Ljava/lang/Long;)V", "GetSetEngagementId_Ljava_lang_Long_Handler")]
			set {
				if (id_setEngagementId_Ljava_lang_Long_ == IntPtr.Zero)
					id_setEngagementId_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "setEngagementId", "(Ljava/lang/Long;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setEngagementId_Ljava_lang_Long_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setEngagementId", "(Ljava/lang/Long;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		static Delegate cb_setSessionId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSessionId_Ljava_lang_String_Handler ()
		{
			if (cb_setSessionId_Ljava_lang_String_ == null)
				cb_setSessionId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSessionId_Ljava_lang_String_);
			return cb_setSessionId_Ljava_lang_String_;
		}

		static void n_SetSessionId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SessionId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSessionId;
		static IntPtr id_setSessionId_Ljava_lang_String_;
		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='setSessionId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSessionId", "(Ljava/lang/String;)V", "GetSetSessionId_Ljava_lang_String_Handler")]
			set {
				if (id_setSessionId_Ljava_lang_String_ == IntPtr.Zero)
					id_setSessionId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSessionId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSessionId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSessionId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVisitorId;
#pragma warning disable 0169
		static Delegate GetGetVisitorIdHandler ()
		{
			if (cb_getVisitorId == null)
				cb_getVisitorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisitorId);
			return cb_getVisitorId;
		}

		static IntPtr n_GetVisitorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VisitorId);
		}
#pragma warning restore 0169

		static Delegate cb_setVisitorId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVisitorId_Ljava_lang_String_Handler ()
		{
			if (cb_setVisitorId_Ljava_lang_String_ == null)
				cb_setVisitorId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVisitorId_Ljava_lang_String_);
			return cb_setVisitorId_Ljava_lang_String_;
		}

		static void n_SetVisitorId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.VisitorId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getVisitorId;
		static IntPtr id_setVisitorId_Ljava_lang_String_;
		public virtual unsafe string VisitorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='getVisitorId' and count(parameter)=0]"
			[Register ("getVisitorId", "()Ljava/lang/String;", "GetGetVisitorIdHandler")]
			get {
				if (id_getVisitorId == IntPtr.Zero)
					id_getVisitorId = JNIEnv.GetMethodID (class_ref, "getVisitorId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVisitorId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisitorId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='setVisitorId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVisitorId", "(Ljava/lang/String;)V", "GetSetVisitorId_Ljava_lang_String_Handler")]
			set {
				if (id_setVisitorId_Ljava_lang_String_ == IntPtr.Zero)
					id_setVisitorId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setVisitorId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisitorId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisitorId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Liveperson.Infra.CampaignInfo __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='CampaignInfo']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
