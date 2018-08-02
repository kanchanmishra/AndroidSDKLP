using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra {

	[Register ("com/liveperson/infra/IConfiguration", DoNotGenerateAcw=true)]
	public abstract class ConfigurationNewConsts : Java.Lang.Object {

		internal ConfigurationNewConsts ()
		{
		}

		static IntPtr mFeaturesMap_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra']/interface[@name='IConfiguration']/field[@name='mFeaturesMap']"
		[Register ("mFeaturesMap")]
		public static global::System.Collections.IDictionary MFeaturesMap {
			get {
				if (mFeaturesMap_jfieldId == IntPtr.Zero)
					mFeaturesMap_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "mFeaturesMap", "Ljava/util/HashMap;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, mFeaturesMap_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		new static IntPtr class_ref = JNIEnv.FindClass ("com/liveperson/infra/IConfiguration");
	}

}
