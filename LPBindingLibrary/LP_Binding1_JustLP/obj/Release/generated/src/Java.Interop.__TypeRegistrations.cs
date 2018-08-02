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
						"com/liveperson/infra/database/tables",
						"com/liveperson/infra/utils",
					},
					new Converter<string, Type>[]{
						lookup_com_liveperson_infra_database_tables_package,
						lookup_com_liveperson_infra_utils_package,
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

		static string[] package_com_liveperson_infra_database_tables_mappings;
		static Type lookup_com_liveperson_infra_database_tables_package (string klass)
		{
			if (package_com_liveperson_infra_database_tables_mappings == null) {
				package_com_liveperson_infra_database_tables_mappings = new string[]{
					"com/liveperson/infra/database/tables/FilesTable:Com.Liveperson.Infra.Database.Tables.filesTable",
					"com/liveperson/infra/database/tables/FilesTable$LoadStatus:Com.Liveperson.Infra.Database.Tables.filesTable/LoadStatus",
					"com/liveperson/infra/database/tables/MessagesTable:Com.Liveperson.Infra.Database.Tables.messagesTable",
					"com/liveperson/infra/database/tables/UsersTable:Com.Liveperson.Infra.Database.Tables.usersTable",
				};
			}

			return Lookup (package_com_liveperson_infra_database_tables_mappings, klass);
		}

		static string[] package_com_liveperson_infra_utils_mappings;
		static Type lookup_com_liveperson_infra_utils_package (string klass)
		{
			if (package_com_liveperson_infra_utils_mappings == null) {
				package_com_liveperson_infra_utils_mappings = new string[]{
					"com/liveperson/infra/utils/HandleMessageCallback$NullHandleMessageCallback:Com.Liveperson.Infra.Utils.HandleMessageCallbackNullHandleMessageCallback",
				};
			}

			return Lookup (package_com_liveperson_infra_utils_mappings, klass);
		}
	}
}
