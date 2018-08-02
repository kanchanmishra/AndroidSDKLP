using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Api.Response.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']"
	[global::Android.Runtime.Register ("com/liveperson/api/response/model/Participants", DoNotGenerateAcw=true)]
	public partial class Participants : global::Java.Lang.Object {


		static IntPtr ALL_AGENTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/field[@name='ALL_AGENTS']"
		[Register ("ALL_AGENTS")]
		public IList<string> AllAgents {
			get {
				if (ALL_AGENTS_jfieldId == IntPtr.Zero)
					ALL_AGENTS_jfieldId = JNIEnv.GetFieldID (class_ref, "ALL_AGENTS", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ALL_AGENTS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ALL_AGENTS_jfieldId == IntPtr.Zero)
					ALL_AGENTS_jfieldId = JNIEnv.GetFieldID (class_ref, "ALL_AGENTS", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ALL_AGENTS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr ASSIGNED_AGENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/field[@name='ASSIGNED_AGENT']"
		[Register ("ASSIGNED_AGENT")]
		public IList<string> AssignedAgent {
			get {
				if (ASSIGNED_AGENT_jfieldId == IntPtr.Zero)
					ASSIGNED_AGENT_jfieldId = JNIEnv.GetFieldID (class_ref, "ASSIGNED_AGENT", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, ASSIGNED_AGENT_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ASSIGNED_AGENT_jfieldId == IntPtr.Zero)
					ASSIGNED_AGENT_jfieldId = JNIEnv.GetFieldID (class_ref, "ASSIGNED_AGENT", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, ASSIGNED_AGENT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONSUMER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/field[@name='CONSUMER']"
		[Register ("CONSUMER")]
		public IList<string> Consumer {
			get {
				if (CONSUMER_jfieldId == IntPtr.Zero)
					CONSUMER_jfieldId = JNIEnv.GetFieldID (class_ref, "CONSUMER", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, CONSUMER_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONSUMER_jfieldId == IntPtr.Zero)
					CONSUMER_jfieldId = JNIEnv.GetFieldID (class_ref, "CONSUMER", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, CONSUMER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONTROLLER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/field[@name='CONTROLLER']"
		[Register ("CONTROLLER")]
		public IList<string> Controller {
			get {
				if (CONTROLLER_jfieldId == IntPtr.Zero)
					CONTROLLER_jfieldId = JNIEnv.GetFieldID (class_ref, "CONTROLLER", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, CONTROLLER_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONTROLLER_jfieldId == IntPtr.Zero)
					CONTROLLER_jfieldId = JNIEnv.GetFieldID (class_ref, "CONTROLLER", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, CONTROLLER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr MANAGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/field[@name='MANAGER']"
		[Register ("MANAGER")]
		public IList<string> Manager {
			get {
				if (MANAGER_jfieldId == IntPtr.Zero)
					MANAGER_jfieldId = JNIEnv.GetFieldID (class_ref, "MANAGER", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, MANAGER_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MANAGER_jfieldId == IntPtr.Zero)
					MANAGER_jfieldId = JNIEnv.GetFieldID (class_ref, "MANAGER", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, MANAGER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr OTHER_AGENTS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/field[@name='OTHER_AGENTS']"
		[Register ("OTHER_AGENTS")]
		public IList<string> OtherAgents {
			get {
				if (OTHER_AGENTS_jfieldId == IntPtr.Zero)
					OTHER_AGENTS_jfieldId = JNIEnv.GetFieldID (class_ref, "OTHER_AGENTS", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, OTHER_AGENTS_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OTHER_AGENTS_jfieldId == IntPtr.Zero)
					OTHER_AGENTS_jfieldId = JNIEnv.GetFieldID (class_ref, "OTHER_AGENTS", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, OTHER_AGENTS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr READER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/field[@name='READER']"
		[Register ("READER")]
		public IList<string> Reader {
			get {
				if (READER_jfieldId == IntPtr.Zero)
					READER_jfieldId = JNIEnv.GetFieldID (class_ref, "READER", "[Ljava/lang/String;");
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, READER_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (READER_jfieldId == IntPtr.Zero)
					READER_jfieldId = JNIEnv.GetFieldID (class_ref, "READER", "[Ljava/lang/String;");
				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, READER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']"
		[global::Android.Runtime.Register ("com/liveperson/api/response/model/Participants$ParticipantRole", DoNotGenerateAcw=true)]
		public sealed partial class ParticipantRole : global::Java.Lang.Enum {


			static IntPtr ASSIGNED_AGENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/field[@name='ASSIGNED_AGENT']"
			[Register ("ASSIGNED_AGENT")]
			public static global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole AssignedAgent {
				get {
					if (ASSIGNED_AGENT_jfieldId == IntPtr.Zero)
						ASSIGNED_AGENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ASSIGNED_AGENT", "Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ASSIGNED_AGENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONSUMER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/field[@name='CONSUMER']"
			[Register ("CONSUMER")]
			public static global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole Consumer {
				get {
					if (CONSUMER_jfieldId == IntPtr.Zero)
						CONSUMER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONSUMER", "Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONSUMER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CONTROLLER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/field[@name='CONTROLLER']"
			[Register ("CONTROLLER")]
			public static global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole Controller {
				get {
					if (CONTROLLER_jfieldId == IntPtr.Zero)
						CONTROLLER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTROLLER", "Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTROLLER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MANAGER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/field[@name='MANAGER']"
			[Register ("MANAGER")]
			public static global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole Manager {
				get {
					if (MANAGER_jfieldId == IntPtr.Zero)
						MANAGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MANAGER", "Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MANAGER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr READER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/field[@name='READER']"
			[Register ("READER")]
			public static global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole Reader {
				get {
					if (READER_jfieldId == IntPtr.Zero)
						READER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READER", "Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/api/response/model/Participants$ParticipantRole", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ParticipantRole); }
			}

			internal ParticipantRole (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_getParticipantRole_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/method[@name='getParticipantRole' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getParticipantRole", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/Participants$ParticipantRole;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole GetParticipantRole (string p0)
			{
				if (id_getParticipantRole_Ljava_lang_String_ == IntPtr.Zero)
					id_getParticipantRole_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getParticipantRole", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getParticipantRole_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/Participants$ParticipantRole;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants.ParticipantRole']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/api/response/model/Participants$ParticipantRole;", "")]
			public static unsafe global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/api/response/model/Participants$ParticipantRole;");
				try {
					return (global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/api/response/model/Participants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Participants); }
		}

		protected Participants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/constructor[@name='Participants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Participants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Participants)) {
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

		static Delegate cb_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_;
#pragma warning disable 0169
		static Delegate GetAdd_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_Handler ()
		{
			if (cb_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_ == null)
				cb_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_);
			return cb_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_;
		}

		static void n_Add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Liveperson.Api.Response.Model.Participants __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] p0 = (string[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (string));
			global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole p1 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.api.response.model']/class[@name='Participants']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='com.liveperson.api.response.model.Participants.ParticipantRole']]"
		[Register ("add", "([Ljava/lang/String;Lcom/liveperson/api/response/model/Participants$ParticipantRole;)V", "GetAdd_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_Handler")]
		public virtual unsafe void Add (string[] p0, global::Com.Liveperson.Api.Response.Model.Participants.ParticipantRole p1)
		{
			if (id_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_ == IntPtr.Zero)
				id_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_ = JNIEnv.GetMethodID (class_ref, "add", "([Ljava/lang/String;Lcom/liveperson/api/response/model/Participants$ParticipantRole;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_arrayLjava_lang_String_Lcom_liveperson_api_response_model_Participants_ParticipantRole_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "([Ljava/lang/String;Lcom/liveperson/api/response/model/Participants$ParticipantRole;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
