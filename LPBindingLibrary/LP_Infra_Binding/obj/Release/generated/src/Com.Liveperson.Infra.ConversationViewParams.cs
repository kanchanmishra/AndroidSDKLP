using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ConversationViewParams", DoNotGenerateAcw=true)]
	public partial class ConversationViewParams : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/liveperson/infra/ConversationViewParams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConversationViewParams); }
		}

		protected ConversationViewParams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/constructor[@name='ConversationViewParams' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe ConversationViewParams (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ConversationViewParams)) {
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

		static IntPtr id_ctor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/constructor[@name='ConversationViewParams' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register (".ctor", "(Z)V", "")]
		public unsafe ConversationViewParams (bool p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (ConversationViewParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Z)V", __args);
					return;
				}

				if (id_ctor_Z == IntPtr.Zero)
					id_ctor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/constructor[@name='ConversationViewParams' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ConversationViewParams ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ConversationViewParams)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getCampaignInfo;
#pragma warning disable 0169
		static Delegate GetGetCampaignInfoHandler ()
		{
			if (cb_getCampaignInfo == null)
				cb_getCampaignInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCampaignInfo);
			return cb_getCampaignInfo;
		}

		static IntPtr n_GetCampaignInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CampaignInfo);
		}
#pragma warning restore 0169

		static IntPtr id_getCampaignInfo;
		public virtual unsafe global::Com.Liveperson.Infra.CampaignInfo CampaignInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='getCampaignInfo' and count(parameter)=0]"
			[Register ("getCampaignInfo", "()Lcom/liveperson/infra/CampaignInfo;", "GetGetCampaignInfoHandler")]
			get {
				if (id_getCampaignInfo == IntPtr.Zero)
					id_getCampaignInfo = JNIEnv.GetMethodID (class_ref, "getCampaignInfo", "()Lcom/liveperson/infra/CampaignInfo;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCampaignInfo), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCampaignInfo", "()Lcom/liveperson/infra/CampaignInfo;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHistoryConversationMaxDaysType;
#pragma warning disable 0169
		static Delegate GetGetHistoryConversationMaxDaysTypeHandler ()
		{
			if (cb_getHistoryConversationMaxDaysType == null)
				cb_getHistoryConversationMaxDaysType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHistoryConversationMaxDaysType);
			return cb_getHistoryConversationMaxDaysType;
		}

		static IntPtr n_GetHistoryConversationMaxDaysType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HistoryConversationMaxDaysType);
		}
#pragma warning restore 0169

		static IntPtr id_getHistoryConversationMaxDaysType;
		public virtual unsafe global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType HistoryConversationMaxDaysType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='getHistoryConversationMaxDaysType' and count(parameter)=0]"
			[Register ("getHistoryConversationMaxDaysType", "()Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;", "GetGetHistoryConversationMaxDaysTypeHandler")]
			get {
				if (id_getHistoryConversationMaxDaysType == IntPtr.Zero)
					id_getHistoryConversationMaxDaysType = JNIEnv.GetMethodID (class_ref, "getHistoryConversationMaxDaysType", "()Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHistoryConversationMaxDaysType), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHistoryConversationMaxDaysType", "()Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHistoryConversationsMaxDays;
#pragma warning disable 0169
		static Delegate GetGetHistoryConversationsMaxDaysHandler ()
		{
			if (cb_getHistoryConversationsMaxDays == null)
				cb_getHistoryConversationsMaxDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHistoryConversationsMaxDays);
			return cb_getHistoryConversationsMaxDays;
		}

		static int n_GetHistoryConversationsMaxDays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HistoryConversationsMaxDays;
		}
#pragma warning restore 0169

		static IntPtr id_getHistoryConversationsMaxDays;
		public virtual unsafe int HistoryConversationsMaxDays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='getHistoryConversationsMaxDays' and count(parameter)=0]"
			[Register ("getHistoryConversationsMaxDays", "()I", "GetGetHistoryConversationsMaxDaysHandler")]
			get {
				if (id_getHistoryConversationsMaxDays == IntPtr.Zero)
					id_getHistoryConversationsMaxDays = JNIEnv.GetMethodID (class_ref, "getHistoryConversationsMaxDays", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHistoryConversationsMaxDays);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHistoryConversationsMaxDays", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getHistoryConversationsStateToDisplay;
#pragma warning disable 0169
		static Delegate GetGetHistoryConversationsStateToDisplayHandler ()
		{
			if (cb_getHistoryConversationsStateToDisplay == null)
				cb_getHistoryConversationsStateToDisplay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHistoryConversationsStateToDisplay);
			return cb_getHistoryConversationsStateToDisplay;
		}

		static IntPtr n_GetHistoryConversationsStateToDisplay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HistoryConversationsStateToDisplay);
		}
#pragma warning restore 0169

		static IntPtr id_getHistoryConversationsStateToDisplay;
		public virtual unsafe global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay HistoryConversationsStateToDisplay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='getHistoryConversationsStateToDisplay' and count(parameter)=0]"
			[Register ("getHistoryConversationsStateToDisplay", "()Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;", "GetGetHistoryConversationsStateToDisplayHandler")]
			get {
				if (id_getHistoryConversationsStateToDisplay == IntPtr.Zero)
					id_getHistoryConversationsStateToDisplay = JNIEnv.GetMethodID (class_ref, "getHistoryConversationsStateToDisplay", "()Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHistoryConversationsStateToDisplay), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHistoryConversationsStateToDisplay", "()Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isFilterOn;
#pragma warning disable 0169
		static Delegate GetIsFilterOnHandler ()
		{
			if (cb_isFilterOn == null)
				cb_isFilterOn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFilterOn);
			return cb_isFilterOn;
		}

		static bool n_IsFilterOn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFilterOn;
		}
#pragma warning restore 0169

		static IntPtr id_isFilterOn;
		public virtual unsafe bool IsFilterOn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='isFilterOn' and count(parameter)=0]"
			[Register ("isFilterOn", "()Z", "GetIsFilterOnHandler")]
			get {
				if (id_isFilterOn == IntPtr.Zero)
					id_isFilterOn = JNIEnv.GetMethodID (class_ref, "isFilterOn", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFilterOn);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFilterOn", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isViewOnlyMode;
#pragma warning disable 0169
		static Delegate GetIsViewOnlyModeHandler ()
		{
			if (cb_isViewOnlyMode == null)
				cb_isViewOnlyMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsViewOnlyMode);
			return cb_isViewOnlyMode;
		}

		static bool n_IsViewOnlyMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsViewOnlyMode;
		}
#pragma warning restore 0169

		static IntPtr id_isViewOnlyMode;
		public virtual unsafe bool IsViewOnlyMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='isViewOnlyMode' and count(parameter)=0]"
			[Register ("isViewOnlyMode", "()Z", "GetIsViewOnlyModeHandler")]
			get {
				if (id_isViewOnlyMode == IntPtr.Zero)
					id_isViewOnlyMode = JNIEnv.GetMethodID (class_ref, "isViewOnlyMode", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isViewOnlyMode);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isViewOnlyMode", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_clearCampaignInfo;
#pragma warning disable 0169
		static Delegate GetClearCampaignInfoHandler ()
		{
			if (cb_clearCampaignInfo == null)
				cb_clearCampaignInfo = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearCampaignInfo);
			return cb_clearCampaignInfo;
		}

		static void n_ClearCampaignInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearCampaignInfo ();
		}
#pragma warning restore 0169

		static IntPtr id_clearCampaignInfo;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='clearCampaignInfo' and count(parameter)=0]"
		[Register ("clearCampaignInfo", "()V", "GetClearCampaignInfoHandler")]
		public virtual unsafe void ClearCampaignInfo ()
		{
			if (id_clearCampaignInfo == IntPtr.Zero)
				id_clearCampaignInfo = JNIEnv.GetMethodID (class_ref, "clearCampaignInfo", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearCampaignInfo);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearCampaignInfo", "()V"));
			} finally {
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
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='describeContents' and count(parameter)=0]"
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

		static Delegate cb_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_;
#pragma warning disable 0169
		static Delegate GetSetCampaignInfo_Lcom_liveperson_infra_CampaignInfo_Handler ()
		{
			if (cb_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_ == null)
				cb_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCampaignInfo_Lcom_liveperson_infra_CampaignInfo_);
			return cb_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_;
		}

		static IntPtr n_SetCampaignInfo_Lcom_liveperson_infra_CampaignInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.CampaignInfo p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.CampaignInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCampaignInfo (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='setCampaignInfo' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.CampaignInfo']]"
		[Register ("setCampaignInfo", "(Lcom/liveperson/infra/CampaignInfo;)Lcom/liveperson/infra/ConversationViewParams;", "GetSetCampaignInfo_Lcom_liveperson_infra_CampaignInfo_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.ConversationViewParams SetCampaignInfo (global::Com.Liveperson.Infra.CampaignInfo p0)
		{
			if (id_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_ == IntPtr.Zero)
				id_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_ = JNIEnv.GetMethodID (class_ref, "setCampaignInfo", "(Lcom/liveperson/infra/CampaignInfo;)Lcom/liveperson/infra/ConversationViewParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.ConversationViewParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCampaignInfo_Lcom_liveperson_infra_CampaignInfo_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCampaignInfo", "(Lcom/liveperson/infra/CampaignInfo;)Lcom/liveperson/infra/ConversationViewParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_;
#pragma warning disable 0169
		static Delegate GetSetHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_Handler ()
		{
			if (cb_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_ == null)
				cb_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_);
			return cb_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_;
		}

		static IntPtr n_SetHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHistoryConversationMaxDaysType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='setHistoryConversationMaxDaysType' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.LPConversationHistoryMaxDaysDateType']]"
		[Register ("setHistoryConversationMaxDaysType", "(Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;)Lcom/liveperson/infra/ConversationViewParams;", "GetSetHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.ConversationViewParams SetHistoryConversationMaxDaysType (global::Com.Liveperson.Infra.LPConversationHistoryMaxDaysDateType p0)
		{
			if (id_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_ == IntPtr.Zero)
				id_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_ = JNIEnv.GetMethodID (class_ref, "setHistoryConversationMaxDaysType", "(Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;)Lcom/liveperson/infra/ConversationViewParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.ConversationViewParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHistoryConversationMaxDaysType_Lcom_liveperson_infra_LPConversationHistoryMaxDaysDateType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHistoryConversationMaxDaysType", "(Lcom/liveperson/infra/LPConversationHistoryMaxDaysDateType;)Lcom/liveperson/infra/ConversationViewParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setHistoryConversationsMaxDays_I;
#pragma warning disable 0169
		static Delegate GetSetHistoryConversationsMaxDays_IHandler ()
		{
			if (cb_setHistoryConversationsMaxDays_I == null)
				cb_setHistoryConversationsMaxDays_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHistoryConversationsMaxDays_I);
			return cb_setHistoryConversationsMaxDays_I;
		}

		static IntPtr n_SetHistoryConversationsMaxDays_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHistoryConversationsMaxDays (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setHistoryConversationsMaxDays_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='setHistoryConversationsMaxDays' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHistoryConversationsMaxDays", "(I)Lcom/liveperson/infra/ConversationViewParams;", "GetSetHistoryConversationsMaxDays_IHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.ConversationViewParams SetHistoryConversationsMaxDays (int p0)
		{
			if (id_setHistoryConversationsMaxDays_I == IntPtr.Zero)
				id_setHistoryConversationsMaxDays_I = JNIEnv.GetMethodID (class_ref, "setHistoryConversationsMaxDays", "(I)Lcom/liveperson/infra/ConversationViewParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHistoryConversationsMaxDays_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHistoryConversationsMaxDays", "(I)Lcom/liveperson/infra/ConversationViewParams;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_;
#pragma warning disable 0169
		static Delegate GetSetHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_Handler ()
		{
			if (cb_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_ == null)
				cb_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_);
			return cb_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_;
		}

		static IntPtr n_SetHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetHistoryConversationsStateToDisplay (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='setHistoryConversationsStateToDisplay' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.LPConversationsHistoryStateToDisplay']]"
		[Register ("setHistoryConversationsStateToDisplay", "(Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;)Lcom/liveperson/infra/ConversationViewParams;", "GetSetHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.ConversationViewParams SetHistoryConversationsStateToDisplay (global::Com.Liveperson.Infra.LPConversationsHistoryStateToDisplay p0)
		{
			if (id_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_ == IntPtr.Zero)
				id_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_ = JNIEnv.GetMethodID (class_ref, "setHistoryConversationsStateToDisplay", "(Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;)Lcom/liveperson/infra/ConversationViewParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Liveperson.Infra.ConversationViewParams __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setHistoryConversationsStateToDisplay_Lcom_liveperson_infra_LPConversationsHistoryStateToDisplay_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHistoryConversationsStateToDisplay", "(Lcom/liveperson/infra/LPConversationsHistoryStateToDisplay;)Lcom/liveperson/infra/ConversationViewParams;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_setReadOnlyMode_Z;
#pragma warning disable 0169
		static Delegate GetSetReadOnlyMode_ZHandler ()
		{
			if (cb_setReadOnlyMode_Z == null)
				cb_setReadOnlyMode_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetReadOnlyMode_Z);
			return cb_setReadOnlyMode_Z;
		}

		static IntPtr n_SetReadOnlyMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetReadOnlyMode (p0));
		}
#pragma warning restore 0169

		static IntPtr id_setReadOnlyMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='setReadOnlyMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setReadOnlyMode", "(Z)Lcom/liveperson/infra/ConversationViewParams;", "GetSetReadOnlyMode_ZHandler")]
		public virtual unsafe global::Com.Liveperson.Infra.ConversationViewParams SetReadOnlyMode (bool p0)
		{
			if (id_setReadOnlyMode_Z == IntPtr.Zero)
				id_setReadOnlyMode_Z = JNIEnv.GetMethodID (class_ref, "setReadOnlyMode", "(Z)Lcom/liveperson/infra/ConversationViewParams;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setReadOnlyMode_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setReadOnlyMode", "(Z)Lcom/liveperson/infra/ConversationViewParams;"), __args), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Liveperson.Infra.ConversationViewParams __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.ConversationViewParams> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra']/class[@name='ConversationViewParams']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
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
