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
						"com/liveperson/infra/ui/view/ui",
					},
					new Converter<string, Type>[]{
						lookup_com_liveperson_infra_ui_view_ui_package,
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

		static string[] package_com_liveperson_infra_ui_view_ui_mappings;
		static Type lookup_com_liveperson_infra_ui_view_ui_package (string klass)
		{
			if (package_com_liveperson_infra_ui_view_ui_mappings == null) {
				package_com_liveperson_infra_ui_view_ui_mappings = new string[]{
					"com/liveperson/infra/ui/view/ui/TouchImageView:Com.Liveperson.Infra.UI.View.UI.touchImageView",
					"com/liveperson/infra/ui/view/ui/TouchImageView$CompatScroller:Com.Liveperson.Infra.UI.View.UI.touchImageView/CompatScroller",
					"com/liveperson/infra/ui/view/ui/TouchImageView$DoubleTapZoom:Com.Liveperson.Infra.UI.View.UI.touchImageView/DoubleTapZoom",
					"com/liveperson/infra/ui/view/ui/TouchImageView$Fling:Com.Liveperson.Infra.UI.View.UI.touchImageView/Fling",
					"com/liveperson/infra/ui/view/ui/TouchImageView$GestureListener:Com.Liveperson.Infra.UI.View.UI.touchImageView/GestureListener",
					"com/liveperson/infra/ui/view/ui/TouchImageView$PrivateOnTouchListener:Com.Liveperson.Infra.UI.View.UI.touchImageView/PrivateOnTouchListener",
					"com/liveperson/infra/ui/view/ui/TouchImageView$ScaleListener:Com.Liveperson.Infra.UI.View.UI.touchImageView/ScaleListener",
					"com/liveperson/infra/ui/view/ui/TouchImageView$State:Com.Liveperson.Infra.UI.View.UI.touchImageView/State",
					"com/liveperson/infra/ui/view/ui/TouchImageView$ZoomVariables:Com.Liveperson.Infra.UI.View.UI.touchImageView/ZoomVariables",
				};
			}

			return Lookup (package_com_liveperson_infra_ui_view_ui_mappings, klass);
		}
	}
}
