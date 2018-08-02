using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']"
	[global::Android.Runtime.Register ("com/liveperson/infra/utils/DateUtils", DoNotGenerateAcw=true)]
	public partial class DateUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/utils/DateUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (DateUtils); }
		}

		protected DateUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/constructor[@name='DateUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (DateUtils)) {
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

		static IntPtr id_getEndOfToday;
		public static unsafe long EndOfToday {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getEndOfToday' and count(parameter)=0]"
			[Register ("getEndOfToday", "()J", "GetGetEndOfTodayHandler")]
			get {
				if (id_getEndOfToday == IntPtr.Zero)
					id_getEndOfToday = JNIEnv.GetStaticMethodID (class_ref, "getEndOfToday", "()J");
				try {
					return JNIEnv.CallStaticLongMethod  (class_ref, id_getEndOfToday);
				} finally {
				}
			}
		}

		static IntPtr id_getBeginningOfDayTime_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getBeginningOfDayTime' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getBeginningOfDayTime", "(J)J", "")]
		public static unsafe long GetBeginningOfDayTime (long p0)
		{
			if (id_getBeginningOfDayTime_J == IntPtr.Zero)
				id_getBeginningOfDayTime_J = JNIEnv.GetStaticMethodID (class_ref, "getBeginningOfDayTime", "(J)J");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticLongMethod  (class_ref, id_getBeginningOfDayTime_J, __args);
			} finally {
			}
		}

		static IntPtr id_getDateFormat_Ljava_lang_String_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getDateFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("getDateFormat", "(Ljava/lang/String;II)Ljava/text/DateFormat;", "")]
		public static unsafe global::Java.Text.DateFormat GetDateFormat (string p0, int p1, int p2)
		{
			if (id_getDateFormat_Ljava_lang_String_II == IntPtr.Zero)
				id_getDateFormat_Ljava_lang_String_II = JNIEnv.GetStaticMethodID (class_ref, "getDateFormat", "(Ljava/lang/String;II)Ljava/text/DateFormat;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Java.Text.DateFormat __ret = global::Java.Lang.Object.GetObject<global::Java.Text.DateFormat> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDateFormat_Ljava_lang_String_II, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getDayOfTheWeek_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getDayOfTheWeek' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDayOfTheWeek", "(J)Ljava/lang/String;", "")]
		public static unsafe string GetDayOfTheWeek (long p0)
		{
			if (id_getDayOfTheWeek_J == IntPtr.Zero)
				id_getDayOfTheWeek_J = JNIEnv.GetStaticMethodID (class_ref, "getDayOfTheWeek", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDayOfTheWeek_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getDurationString_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getDurationString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getDurationString", "(J)Ljava/lang/String;", "")]
		public static unsafe string GetDurationString (long p0)
		{
			if (id_getDurationString_J == IntPtr.Zero)
				id_getDurationString_J = JNIEnv.GetStaticMethodID (class_ref, "getDurationString", "(J)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getDurationString_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_getFormattedDate_Ljava_lang_String_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getFormattedDate' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("getFormattedDate", "(Ljava/lang/String;IJ)Ljava/lang/String;", "")]
		public static unsafe string GetFormattedDate (string p0, int p1, long p2)
		{
			if (id_getFormattedDate_Ljava_lang_String_IJ == IntPtr.Zero)
				id_getFormattedDate_Ljava_lang_String_IJ = JNIEnv.GetStaticMethodID (class_ref, "getFormattedDate", "(Ljava/lang/String;IJ)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormattedDate_Ljava_lang_String_IJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFormattedDateAndTime_Ljava_lang_String_IIJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getFormattedDateAndTime' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("getFormattedDateAndTime", "(Ljava/lang/String;IIJ)Ljava/lang/String;", "")]
		public static unsafe string GetFormattedDateAndTime (string p0, int p1, int p2, long p3)
		{
			if (id_getFormattedDateAndTime_Ljava_lang_String_IIJ == IntPtr.Zero)
				id_getFormattedDateAndTime_Ljava_lang_String_IIJ = JNIEnv.GetStaticMethodID (class_ref, "getFormattedDateAndTime", "(Ljava/lang/String;IIJ)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormattedDateAndTime_Ljava_lang_String_IIJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFormattedDateAndTime_Ljava_lang_String_IIJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getFormattedDateAndTime' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='java.lang.String']]"
		[Register ("getFormattedDateAndTime", "(Ljava/lang/String;IIJLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFormattedDateAndTime (string p0, int p1, int p2, long p3, string p4)
		{
			if (id_getFormattedDateAndTime_Ljava_lang_String_IIJLjava_lang_String_ == IntPtr.Zero)
				id_getFormattedDateAndTime_Ljava_lang_String_IIJLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFormattedDateAndTime", "(Ljava/lang/String;IIJLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (native_p4);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormattedDateAndTime_Ljava_lang_String_IIJLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static IntPtr id_getFormattedTime_Ljava_lang_String_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getFormattedTime' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("getFormattedTime", "(Ljava/lang/String;IJ)Ljava/lang/String;", "")]
		public static unsafe string GetFormattedTime (string p0, int p1, long p2)
		{
			if (id_getFormattedTime_Ljava_lang_String_IJ == IntPtr.Zero)
				id_getFormattedTime_Ljava_lang_String_IJ = JNIEnv.GetStaticMethodID (class_ref, "getFormattedTime", "(Ljava/lang/String;IJ)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormattedTime_Ljava_lang_String_IJ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getFormattedTime_Ljava_lang_String_IJLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='getFormattedTime' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='long'] and parameter[4][@type='java.lang.String']]"
		[Register ("getFormattedTime", "(Ljava/lang/String;IJLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetFormattedTime (string p0, int p1, long p2, string p3)
		{
			if (id_getFormattedTime_Ljava_lang_String_IJLjava_lang_String_ == IntPtr.Zero)
				id_getFormattedTime_Ljava_lang_String_IJLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getFormattedTime", "(Ljava/lang/String;IJLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getFormattedTime_Ljava_lang_String_IJLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		static IntPtr id_isInTheLast24hours_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='isInTheLast24hours' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isInTheLast24hours", "(J)Z", "")]
		public static unsafe bool IsInTheLast24hours (long p0)
		{
			if (id_isInTheLast24hours_J == IntPtr.Zero)
				id_isInTheLast24hours_J = JNIEnv.GetStaticMethodID (class_ref, "isInTheLast24hours", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isInTheLast24hours_J, __args);
			} finally {
			}
		}

		static IntPtr id_isToday_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='isToday' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isToday", "(J)Z", "")]
		public static unsafe bool IsToday (long p0)
		{
			if (id_isToday_J == IntPtr.Zero)
				id_isToday_J = JNIEnv.GetStaticMethodID (class_ref, "isToday", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isToday_J, __args);
			} finally {
			}
		}

		static IntPtr id_isTomorrow_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='isTomorrow' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isTomorrow", "(J)Z", "")]
		public static unsafe bool IsTomorrow (long p0)
		{
			if (id_isTomorrow_J == IntPtr.Zero)
				id_isTomorrow_J = JNIEnv.GetStaticMethodID (class_ref, "isTomorrow", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isTomorrow_J, __args);
			} finally {
			}
		}

		static IntPtr id_isYesterday_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.utils']/class[@name='DateUtils']/method[@name='isYesterday' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("isYesterday", "(J)Z", "")]
		public static unsafe bool IsYesterday (long p0)
		{
			if (id_isYesterday_J == IntPtr.Zero)
				id_isYesterday_J = JNIEnv.GetStaticMethodID (class_ref, "isYesterday", "(J)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isYesterday_J, __args);
			} finally {
			}
		}

	}
}
