using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Messaging.Controller {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']"
	[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ClientProperties", DoNotGenerateAcw=true)]
	public partial class ClientProperties : global::Java.Lang.Object, global::Com.Liveperson.Infra.IClearable {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Browser']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ClientProperties$Browser", DoNotGenerateAcw=true)]
		public sealed partial class Browser : global::Java.Lang.Enum {


			static IntPtr CHROME_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Browser']/field[@name='CHROME']"
			[Register ("CHROME")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser Chrome {
				get {
					if (CHROME_jfieldId == IntPtr.Zero)
						CHROME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHROME", "Lcom/liveperson/messaging/controller/ClientProperties$Browser;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHROME_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FIREFOX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Browser']/field[@name='FIREFOX']"
			[Register ("FIREFOX")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser Firefox {
				get {
					if (FIREFOX_jfieldId == IntPtr.Zero)
						FIREFOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FIREFOX", "Lcom/liveperson/messaging/controller/ClientProperties$Browser;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FIREFOX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Browser']/field[@name='IE']"
			[Register ("IE")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser Ie {
				get {
					if (IE_jfieldId == IntPtr.Zero)
						IE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IE", "Lcom/liveperson/messaging/controller/ClientProperties$Browser;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OPERA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Browser']/field[@name='OPERA']"
			[Register ("OPERA")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser Opera {
				get {
					if (OPERA_jfieldId == IntPtr.Zero)
						OPERA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OPERA", "Lcom/liveperson/messaging/controller/ClientProperties$Browser;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OPERA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Browser']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/liveperson/messaging/controller/ClientProperties$Browser;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SAFARI_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Browser']/field[@name='SAFARI']"
			[Register ("SAFARI")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser Safari {
				get {
					if (SAFARI_jfieldId == IntPtr.Zero)
						SAFARI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SAFARI", "Lcom/liveperson/messaging/controller/ClientProperties$Browser;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SAFARI_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Browser> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/ClientProperties$Browser", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Browser); }
			}

			internal Browser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.DeviceFamily']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ClientProperties$DeviceFamily", DoNotGenerateAcw=true)]
		public sealed partial class DeviceFamily : global::Java.Lang.Enum {


			static IntPtr MOBILE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.DeviceFamily']/field[@name='MOBILE']"
			[Register ("MOBILE")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily Mobile {
				get {
					if (MOBILE_jfieldId == IntPtr.Zero)
						MOBILE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE", "Lcom/liveperson/messaging/controller/ClientProperties$DeviceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.DeviceFamily']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/liveperson/messaging/controller/ClientProperties$DeviceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PDA_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.DeviceFamily']/field[@name='PDA']"
			[Register ("PDA")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily Pda {
				get {
					if (PDA_jfieldId == IntPtr.Zero)
						PDA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PDA", "Lcom/liveperson/messaging/controller/ClientProperties$DeviceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PDA_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PERSONAL_COMPUTER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.DeviceFamily']/field[@name='PERSONAL_COMPUTER']"
			[Register ("PERSONAL_COMPUTER")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily PersonalComputer {
				get {
					if (PERSONAL_COMPUTER_jfieldId == IntPtr.Zero)
						PERSONAL_COMPUTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PERSONAL_COMPUTER", "Lcom/liveperson/messaging/controller/ClientProperties$DeviceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PERSONAL_COMPUTER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr TABLET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.DeviceFamily']/field[@name='TABLET']"
			[Register ("TABLET")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily Tablet {
				get {
					if (TABLET_jfieldId == IntPtr.Zero)
						TABLET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TABLET", "Lcom/liveperson/messaging/controller/ClientProperties$DeviceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TABLET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr UNKNOWN_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.DeviceFamily']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily Unknown {
				get {
					if (UNKNOWN_jfieldId == IntPtr.Zero)
						UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lcom/liveperson/messaging/controller/ClientProperties$DeviceFamily;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.DeviceFamily> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/ClientProperties$DeviceFamily", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DeviceFamily); }
			}

			internal DeviceFamily (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ClientProperties$Features", DoNotGenerateAcw=true)]
		public sealed partial class Features : global::Java.Lang.Enum {


			static IntPtr AUTO_MESSAGES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/field[@name='AUTO_MESSAGES']"
			[Register ("AUTO_MESSAGES")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Features AutoMessages {
				get {
					if (AUTO_MESSAGES_jfieldId == IntPtr.Zero)
						AUTO_MESSAGES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTO_MESSAGES", "Lcom/liveperson/messaging/controller/ClientProperties$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTO_MESSAGES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CO_APP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/field[@name='CO_APP']"
			[Register ("CO_APP")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Features CoApp {
				get {
					if (CO_APP_jfieldId == IntPtr.Zero)
						CO_APP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CO_APP", "Lcom/liveperson/messaging/controller/ClientProperties$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CO_APP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CO_BROWSE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/field[@name='CO_BROWSE']"
			[Register ("CO_BROWSE")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Features CoBrowse {
				get {
					if (CO_BROWSE_jfieldId == IntPtr.Zero)
						CO_BROWSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CO_BROWSE", "Lcom/liveperson/messaging/controller/ClientProperties$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CO_BROWSE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr PHOTO_SHARING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/field[@name='PHOTO_SHARING']"
			[Register ("PHOTO_SHARING")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Features PhotoSharing {
				get {
					if (PHOTO_SHARING_jfieldId == IntPtr.Zero)
						PHOTO_SHARING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PHOTO_SHARING", "Lcom/liveperson/messaging/controller/ClientProperties$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PHOTO_SHARING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr QUICK_REPLIES_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/field[@name='QUICK_REPLIES']"
			[Register ("QUICK_REPLIES")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Features QuickReplies {
				get {
					if (QUICK_REPLIES_jfieldId == IntPtr.Zero)
						QUICK_REPLIES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QUICK_REPLIES", "Lcom/liveperson/messaging/controller/ClientProperties$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QUICK_REPLIES_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr RICH_CONTENT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/field[@name='RICH_CONTENT']"
			[Register ("RICH_CONTENT")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Features RichContent {
				get {
					if (RICH_CONTENT_jfieldId == IntPtr.Zero)
						RICH_CONTENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RICH_CONTENT", "Lcom/liveperson/messaging/controller/ClientProperties$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RICH_CONTENT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr SECURE_FORMS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/field[@name='SECURE_FORMS']"
			[Register ("SECURE_FORMS")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Features SecureForms {
				get {
					if (SECURE_FORMS_jfieldId == IntPtr.Zero)
						SECURE_FORMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SECURE_FORMS", "Lcom/liveperson/messaging/controller/ClientProperties$Features;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SECURE_FORMS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/ClientProperties$Features", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Features); }
			}

			internal Features (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/controller/ClientProperties$Features;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Controller.ClientProperties.Features ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/liveperson/messaging/controller/ClientProperties$Features;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Liveperson.Messaging.Controller.ClientProperties.Features __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Features> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Features']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/liveperson/messaging/controller/ClientProperties$Features;", "")]
			public static unsafe global::Com.Liveperson.Messaging.Controller.ClientProperties.Features[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/liveperson/messaging/controller/ClientProperties$Features;");
				try {
					return (global::Com.Liveperson.Messaging.Controller.ClientProperties.Features[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Liveperson.Messaging.Controller.ClientProperties.Features));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Integration']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ClientProperties$Integration", DoNotGenerateAcw=true)]
		public sealed partial class Integration : global::Java.Lang.Enum {


			static IntPtr BRAND_SDK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Integration']/field[@name='BRAND_SDK']"
			[Register ("BRAND_SDK")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Integration BrandSdk {
				get {
					if (BRAND_SDK_jfieldId == IntPtr.Zero)
						BRAND_SDK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BRAND_SDK", "Lcom/liveperson/messaging/controller/ClientProperties$Integration;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BRAND_SDK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Integration> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MOBILE_SDK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Integration']/field[@name='MOBILE_SDK']"
			[Register ("MOBILE_SDK")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Integration MobileSdk {
				get {
					if (MOBILE_SDK_jfieldId == IntPtr.Zero)
						MOBILE_SDK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MOBILE_SDK", "Lcom/liveperson/messaging/controller/ClientProperties$Integration;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MOBILE_SDK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Integration> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WEB_SDK_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.Integration']/field[@name='WEB_SDK']"
			[Register ("WEB_SDK")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.Integration WebSdk {
				get {
					if (WEB_SDK_jfieldId == IntPtr.Zero)
						WEB_SDK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_SDK", "Lcom/liveperson/messaging/controller/ClientProperties$Integration;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_SDK_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.Integration> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/ClientProperties$Integration", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Integration); }
			}

			internal Integration (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.OS']"
		[global::Android.Runtime.Register ("com/liveperson/messaging/controller/ClientProperties$OS", DoNotGenerateAcw=true)]
		public sealed partial class OS : global::Java.Lang.Enum {


			static IntPtr ANDROID_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.OS']/field[@name='ANDROID']"
			[Register ("ANDROID")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.OS Android {
				get {
					if (ANDROID_jfieldId == IntPtr.Zero)
						ANDROID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANDROID", "Lcom/liveperson/messaging/controller/ClientProperties$OS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANDROID_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.OS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr IOS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.OS']/field[@name='IOS']"
			[Register ("IOS")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.OS Ios {
				get {
					if (IOS_jfieldId == IntPtr.Zero)
						IOS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IOS", "Lcom/liveperson/messaging/controller/ClientProperties$OS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IOS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.OS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr LINUX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.OS']/field[@name='LINUX']"
			[Register ("LINUX")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.OS Linux {
				get {
					if (LINUX_jfieldId == IntPtr.Zero)
						LINUX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINUX", "Lcom/liveperson/messaging/controller/ClientProperties$OS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINUX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.OS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OSX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.OS']/field[@name='OSX']"
			[Register ("OSX")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.OS Osx {
				get {
					if (OSX_jfieldId == IntPtr.Zero)
						OSX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OSX", "Lcom/liveperson/messaging/controller/ClientProperties$OS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OSX_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.OS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr OTHER_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.OS']/field[@name='OTHER']"
			[Register ("OTHER")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.OS Other {
				get {
					if (OTHER_jfieldId == IntPtr.Zero)
						OTHER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OTHER", "Lcom/liveperson/messaging/controller/ClientProperties$OS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OTHER_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.OS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr WINDOWS_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties.OS']/field[@name='WINDOWS']"
			[Register ("WINDOWS")]
			public static global::Com.Liveperson.Messaging.Controller.ClientProperties.OS Windows {
				get {
					if (WINDOWS_jfieldId == IntPtr.Zero)
						WINDOWS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WINDOWS", "Lcom/liveperson/messaging/controller/ClientProperties$OS;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WINDOWS_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties.OS> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/messaging/controller/ClientProperties$OS", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (OS); }
			}

			internal OS (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/messaging/controller/ClientProperties", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ClientProperties); }
		}

		protected ClientProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']/constructor[@name='ClientProperties' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ClientProperties (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (ClientProperties)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']/constructor[@name='ClientProperties' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ClientProperties ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ClientProperties)) {
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

		static Delegate cb_getJsonString;
#pragma warning disable 0169
		static Delegate GetGetJsonStringHandler ()
		{
			if (cb_getJsonString == null)
				cb_getJsonString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJsonString);
			return cb_getJsonString;
		}

		static IntPtr n_GetJsonString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.ClientProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.JsonString);
		}
#pragma warning restore 0169

		static IntPtr id_getJsonString;
		public virtual unsafe string JsonString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']/method[@name='getJsonString' and count(parameter)=0]"
			[Register ("getJsonString", "()Ljava/lang/String;", "GetGetJsonStringHandler")]
			get {
				if (id_getJsonString == IntPtr.Zero)
					id_getJsonString = JNIEnv.GetMethodID (class_ref, "getJsonString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getJsonString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getJsonString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addToUriBuilder_Landroid_net_Uri_Builder_;
#pragma warning disable 0169
		static Delegate GetAddToUriBuilder_Landroid_net_Uri_Builder_Handler ()
		{
			if (cb_addToUriBuilder_Landroid_net_Uri_Builder_ == null)
				cb_addToUriBuilder_Landroid_net_Uri_Builder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddToUriBuilder_Landroid_net_Uri_Builder_);
			return cb_addToUriBuilder_Landroid_net_Uri_Builder_;
		}

		static void n_AddToUriBuilder_Landroid_net_Uri_Builder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ClientProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri.Builder p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri.Builder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddToUriBuilder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addToUriBuilder_Landroid_net_Uri_Builder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']/method[@name='addToUriBuilder' and count(parameter)=1 and parameter[1][@type='android.net.Uri.Builder']]"
		[Register ("addToUriBuilder", "(Landroid/net/Uri$Builder;)V", "GetAddToUriBuilder_Landroid_net_Uri_Builder_Handler")]
		public virtual unsafe void AddToUriBuilder (global::Android.Net.Uri.Builder p0)
		{
			if (id_addToUriBuilder_Landroid_net_Uri_Builder_ == IntPtr.Zero)
				id_addToUriBuilder_Landroid_net_Uri_Builder_ = JNIEnv.GetMethodID (class_ref, "addToUriBuilder", "(Landroid/net/Uri$Builder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addToUriBuilder_Landroid_net_Uri_Builder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addToUriBuilder", "(Landroid/net/Uri$Builder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Messaging.Controller.ClientProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveAppId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveAppId_Ljava_lang_String_Handler ()
		{
			if (cb_saveAppId_Ljava_lang_String_ == null)
				cb_saveAppId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveAppId_Ljava_lang_String_);
			return cb_saveAppId_Ljava_lang_String_;
		}

		static void n_SaveAppId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ClientProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveAppId (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveAppId_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']/method[@name='saveAppId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveAppId", "(Ljava/lang/String;)V", "GetSaveAppId_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveAppId (string p0)
		{
			if (id_saveAppId_Ljava_lang_String_ == IntPtr.Zero)
				id_saveAppId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveAppId", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveAppId_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveAppId", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_saveSDKVersion_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveSDKVersion_Ljava_lang_String_Handler ()
		{
			if (cb_saveSDKVersion_Ljava_lang_String_ == null)
				cb_saveSDKVersion_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveSDKVersion_Ljava_lang_String_);
			return cb_saveSDKVersion_Ljava_lang_String_;
		}

		static void n_SaveSDKVersion_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Messaging.Controller.ClientProperties __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Messaging.Controller.ClientProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SaveSDKVersion (p0);
		}
#pragma warning restore 0169

		static IntPtr id_saveSDKVersion_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.messaging.controller']/class[@name='ClientProperties']/method[@name='saveSDKVersion' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveSDKVersion", "(Ljava/lang/String;)V", "GetSaveSDKVersion_Ljava_lang_String_Handler")]
		public virtual unsafe void SaveSDKVersion (string p0)
		{
			if (id_saveSDKVersion_Ljava_lang_String_ == IntPtr.Zero)
				id_saveSDKVersion_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "saveSDKVersion", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveSDKVersion_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveSDKVersion", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
