using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/liveperson/infra/messaging_ui/fragment",
						"com/liveperson/infra/messaging_ui/uicomponents",
					},
					new Converter<string, Type>[]{
						lookup_com_liveperson_infra_messaging_ui_fragment_package,
						lookup_com_liveperson_infra_messaging_ui_uicomponents_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_liveperson_infra_messaging_ui_fragment_mappings;
		static Type lookup_com_liveperson_infra_messaging_ui_fragment_package (string klass)
		{
			if (package_com_liveperson_infra_messaging_ui_fragment_mappings == null) {
				package_com_liveperson_infra_messaging_ui_fragment_mappings = new string[]{
					"com/liveperson/infra/messaging_ui/fragment/ConversationFragmentCallbacks$NullConversationFragmentCallbacks:Com.Liveperson.Infra.Messaging_ui.Fragment.ConversationFragmentCallbacksNullConversationFragmentCallbacks",
					"com/liveperson/infra/messaging_ui/fragment/NestedFragmentsContainerCallbacks$NullNestedFragmentsContainerCallbacks:Com.Liveperson.Infra.Messaging_ui.Fragment.NestedFragmentsContainerCallbacksNullNestedFragmentsContainerCallbacks",
				};
			}

			return Lookup (package_com_liveperson_infra_messaging_ui_fragment_mappings, klass);
		}

		static string[] package_com_liveperson_infra_messaging_ui_uicomponents_mappings;
		static Type lookup_com_liveperson_infra_messaging_ui_uicomponents_package (string klass)
		{
			if (package_com_liveperson_infra_messaging_ui_uicomponents_mappings == null) {
				package_com_liveperson_infra_messaging_ui_uicomponents_mappings = new string[]{
					"com/liveperson/infra/messaging_ui/uicomponents/IScrollDownIndicator$NullImplementation:Com.Liveperson.Infra.Messaging_ui.Uicomponents.ScrollDownIndicatorNullImplementation",
				};
			}

			return Lookup (package_com_liveperson_infra_messaging_ui_uicomponents_mappings, klass);
		}
	}
}
