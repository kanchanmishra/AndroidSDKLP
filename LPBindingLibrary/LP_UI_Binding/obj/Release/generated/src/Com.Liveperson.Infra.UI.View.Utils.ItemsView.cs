using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/utils/ItemsView", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"DataClass"})]
	public partial class ItemsView : global::Android.Support.V7.Widget.RecyclerView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.CellHolder']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/utils/ItemsView$CellHolder", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"CellDataType"})]
		public abstract partial class CellHolder : global::Android.Support.V7.Widget.RecyclerView.ViewHolder {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/utils/ItemsView$CellHolder", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CellHolder); }
			}

			protected CellHolder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_view_View_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.CellHolder']/constructor[@name='ItemsView.CellHolder' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register (".ctor", "(Landroid/view/View;)V", "")]
			public unsafe CellHolder (global::Android.Views.View p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (CellHolder)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/view/View;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/view/View;)V", __args);
						return;
					}

					if (id_ctor_Landroid_view_View_ == IntPtr.Zero)
						id_ctor_Landroid_view_View_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/view/View;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_view_View_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_view_View_, __args);
				} finally {
				}
			}

			static Delegate cb_getData;
#pragma warning disable 0169
			static Delegate GetGetDataHandler ()
			{
				if (cb_getData == null)
					cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
				return cb_getData;
			}

			static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Data);
			}
#pragma warning restore 0169

			static IntPtr id_getData;
			public virtual unsafe global::Java.Lang.Object Data {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.CellHolder']/method[@name='getData' and count(parameter)=0]"
				[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler")]
				get {
					if (id_getData == IntPtr.Zero)
						id_getData = JNIEnv.GetMethodID (class_ref, "getData", "()Ljava/lang/Object;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getData), JniHandleOwnership.TransferLocalRef);
						else
							return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getData", "()Ljava/lang/Object;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_configure_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetConfigure_Ljava_lang_Object_Handler ()
			{
				if (cb_configure_Ljava_lang_Object_ == null)
					cb_configure_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Configure_Ljava_lang_Object_);
				return cb_configure_Ljava_lang_Object_;
			}

			static void n_Configure_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Configure (p0);
			}
#pragma warning restore 0169

			static IntPtr id_configure_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.CellHolder']/method[@name='configure' and count(parameter)=1 and parameter[1][@type='CellDataType']]"
			[Register ("configure", "(Ljava/lang/Object;)V", "GetConfigure_Ljava_lang_Object_Handler")]
			public virtual unsafe void Configure (global::Java.Lang.Object p0)
			{
				if (id_configure_Ljava_lang_Object_ == IntPtr.Zero)
					id_configure_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "configure", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_configure_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "configure", "(Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static Delegate cb_prepareForReuse;
#pragma warning disable 0169
			static Delegate GetPrepareForReuseHandler ()
			{
				if (cb_prepareForReuse == null)
					cb_prepareForReuse = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareForReuse);
				return cb_prepareForReuse;
			}

			static void n_PrepareForReuse (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PrepareForReuse ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.CellHolder']/method[@name='prepareForReuse' and count(parameter)=0]"
			[Register ("prepareForReuse", "()V", "GetPrepareForReuseHandler")]
			public abstract void PrepareForReuse ();

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/utils/ItemsView$CellHolder", DoNotGenerateAcw=true)]
		internal partial class CellHolderInvoker : CellHolder {

			public CellHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			protected override global::System.Type ThresholdType {
				get { return typeof (CellHolderInvoker); }
			}

			static IntPtr id_prepareForReuse;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.CellHolder']/method[@name='prepareForReuse' and count(parameter)=0]"
			[Register ("prepareForReuse", "()V", "GetPrepareForReuseHandler")]
			public override unsafe void PrepareForReuse ()
			{
				if (id_prepareForReuse == IntPtr.Zero)
					id_prepareForReuse = JNIEnv.GetMethodID (class_ref, "prepareForReuse", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepareForReuse);
				} finally {
				}
			}

		}


		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/interface[@name='ItemsView.CellsFactory']"
		[Register ("com/liveperson/infra/ui/view/utils/ItemsView$CellsFactory", "", "Com.Liveperson.Infra.UI.View.Utils.ItemsView/ICellsFactoryInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"D"})]
		public partial interface ICellsFactory : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/interface[@name='ItemsView.CellsFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
			[Register ("create", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/utils/ItemsView$CellHolder;", "GetCreate_Landroid_view_ViewGroup_IHandler:Com.Liveperson.Infra.UI.View.Utils.ItemsView/ICellsFactoryInvoker, LP_UI_Binding")]
			global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder Create (global::Android.Views.ViewGroup p0, int p1);

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/utils/ItemsView$CellsFactory", DoNotGenerateAcw=true)]
		internal class ICellsFactoryInvoker : global::Java.Lang.Object, ICellsFactory {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/utils/ItemsView$CellsFactory");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICellsFactoryInvoker); }
			}

			IntPtr class_ref;

			public static ICellsFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICellsFactory> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.utils.ItemsView.CellsFactory"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICellsFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_create_Landroid_view_ViewGroup_I;
#pragma warning disable 0169
			static Delegate GetCreate_Landroid_view_ViewGroup_IHandler ()
			{
				if (cb_create_Landroid_view_ViewGroup_I == null)
					cb_create_Landroid_view_ViewGroup_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_Create_Landroid_view_ViewGroup_I);
				return cb_create_Landroid_view_ViewGroup_I;
			}

			static IntPtr n_Create_Landroid_view_ViewGroup_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.ICellsFactory __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.ICellsFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_create_Landroid_view_ViewGroup_I;
			public unsafe global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder Create (global::Android.Views.ViewGroup p0, int p1)
			{
				if (id_create_Landroid_view_ViewGroup_I == IntPtr.Zero)
					id_create_Landroid_view_ViewGroup_I = JNIEnv.GetMethodID (class_ref, "create", "(Landroid/view/ViewGroup;I)Lcom/liveperson/infra/ui/view/utils/ItemsView$CellHolder;");
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder __ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.CellHolder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Landroid_view_ViewGroup_I, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.RecyclerViewAdapter']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/utils/ItemsView$RecyclerViewAdapter", DoNotGenerateAcw=true)]
		public partial class RecyclerViewAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/utils/ItemsView$RecyclerViewAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RecyclerViewAdapter); }
			}

			protected RecyclerViewAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getItemCount;
#pragma warning disable 0169
			static Delegate GetGetItemCountHandler ()
			{
				if (cb_getItemCount == null)
					cb_getItemCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemCount);
				return cb_getItemCount;
			}

			static int n_GetItemCount (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.RecyclerViewAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.RecyclerViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ItemCount;
			}
#pragma warning restore 0169

			static IntPtr id_getItemCount;
			public override unsafe int ItemCount {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.RecyclerViewAdapter']/method[@name='getItemCount' and count(parameter)=0]"
				[Register ("getItemCount", "()I", "GetGetItemCountHandler")]
				get {
					if (id_getItemCount == IntPtr.Zero)
						id_getItemCount = JNIEnv.GetMethodID (class_ref, "getItemCount", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getItemCount);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemCount", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
#pragma warning disable 0169
			static Delegate GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler ()
			{
				if (cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == null)
					cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I);
				return cb_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
			}

			static void n_OnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
			{
				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.RecyclerViewAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.RecyclerViewAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.Widget.RecyclerView.ViewHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnBindViewHolder (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView.RecyclerViewAdapter']/method[@name='onBindViewHolder' and count(parameter)=2 and parameter[1][@type='android.support.v7.widget.RecyclerView.ViewHolder'] and parameter[2][@type='int']]"
			[Register ("onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V", "GetOnBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IHandler")]
			public override unsafe void OnBindViewHolder (global::Android.Support.V7.Widget.RecyclerView.ViewHolder p0, int p1)
			{
				if (id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I == IntPtr.Zero)
					id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I = JNIEnv.GetMethodID (class_ref, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBindViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onBindViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;I)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/utils/ItemsView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ItemsView); }
		}

		protected ItemsView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/constructor[@name='ItemsView' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int'] and parameter[4][@type='com.liveperson.infra.ui.view.utils.ItemsView.CellsFactory&lt;DataClass&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;ILcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", "")]
		public unsafe ItemsView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2, global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.ICellsFactory p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (ItemsView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;ILcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;ILcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;ILcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ILcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/constructor[@name='ItemsView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='com.liveperson.infra.ui.view.utils.ItemsView.CellsFactory&lt;DataClass&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", "")]
		public unsafe ItemsView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.ICellsFactory p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ItemsView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/constructor[@name='ItemsView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.liveperson.infra.ui.view.utils.ItemsView.CellsFactory&lt;DataClass&gt;']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", "")]
		public unsafe ItemsView (global::Android.Content.Context p0, global::Com.Liveperson.Infra.UI.View.Utils.ItemsView.ICellsFactory p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (ItemsView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Lcom/liveperson/infra/ui/view/utils/ItemsView$CellsFactory;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Lcom_liveperson_infra_ui_view_utils_ItemsView_CellsFactory_, __args);
			} finally {
			}
		}

		static Delegate cb_add_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_Object_Handler ()
		{
			if (cb_add_Ljava_lang_Object_ == null)
				cb_add_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Add_Ljava_lang_Object_);
			return cb_add_Ljava_lang_Object_;
		}

		static void n_Add_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.ItemsView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Add (p0);
		}
#pragma warning restore 0169

		static IntPtr id_add_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/method[@name='add' and count(parameter)=1 and parameter[1][@type='DataClass']]"
		[Register ("add", "(Ljava/lang/Object;)V", "GetAdd_Ljava_lang_Object_Handler")]
		public virtual unsafe void Add (global::Java.Lang.Object p0)
		{
			if (id_add_Ljava_lang_Object_ == IntPtr.Zero)
				id_add_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "add", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_filter_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFilter_Ljava_lang_String_Handler ()
		{
			if (cb_filter_Ljava_lang_String_ == null)
				cb_filter_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Filter_Ljava_lang_String_);
			return cb_filter_Ljava_lang_String_;
		}

		static void n_Filter_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.ItemsView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Filter (p0);
		}
#pragma warning restore 0169

		static IntPtr id_filter_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("filter", "(Ljava/lang/String;)V", "GetFilter_Ljava_lang_String_Handler")]
		public virtual unsafe void Filter (string p0)
		{
			if (id_filter_Ljava_lang_String_ == IntPtr.Zero)
				id_filter_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "filter", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_filter_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "filter", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_reload;
#pragma warning disable 0169
		static Delegate GetReloadHandler ()
		{
			if (cb_reload == null)
				cb_reload = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reload);
			return cb_reload;
		}

		static void n_Reload (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.ItemsView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reload ();
		}
#pragma warning restore 0169

		static IntPtr id_reload;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/method[@name='reload' and count(parameter)=0]"
		[Register ("reload", "()V", "GetReloadHandler")]
		public virtual unsafe void Reload ()
		{
			if (id_reload == IntPtr.Zero)
				id_reload = JNIEnv.GetMethodID (class_ref, "reload", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_reload);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "reload", "()V"));
			} finally {
			}
		}

		static Delegate cb_remove_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetRemove_Ljava_lang_Object_Handler ()
		{
			if (cb_remove_Ljava_lang_Object_ == null)
				cb_remove_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Remove_Ljava_lang_Object_);
			return cb_remove_Ljava_lang_Object_;
		}

		static void n_Remove_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.ItemsView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Remove (p0);
		}
#pragma warning restore 0169

		static IntPtr id_remove_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='DataClass']]"
		[Register ("remove", "(Ljava/lang/Object;)V", "GetRemove_Ljava_lang_Object_Handler")]
		public virtual unsafe void Remove (global::Java.Lang.Object p0)
		{
			if (id_remove_Ljava_lang_Object_ == IntPtr.Zero)
				id_remove_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_Object_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "remove", "(Ljava/lang/Object;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setData_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_util_List_Handler ()
		{
			if (cb_setData_Ljava_util_List_ == null)
				cb_setData_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_util_List_);
			return cb_setData_Ljava_util_List_;
		}

		static void n_SetData_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.ItemsView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setData_Ljava_util_List_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;DataClass&gt;']]"
		[Register ("setData", "(Ljava/util/List;)V", "GetSetData_Ljava_util_List_Handler")]
		public virtual unsafe void SetData (global::System.Collections.IList p0)
		{
			if (id_setData_Ljava_util_List_ == IntPtr.Zero)
				id_setData_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setData", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setData_Ljava_util_List_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setData", "(Ljava/util/List;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_withCellType_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWithCellType_Ljava_lang_Object_Handler ()
		{
			if (cb_withCellType_Ljava_lang_Object_ == null)
				cb_withCellType_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_WithCellType_Ljava_lang_Object_);
			return cb_withCellType_Ljava_lang_Object_;
		}

		static IntPtr n_WithCellType_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.Utils.ItemsView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.WithCellType (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_withCellType_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.utils']/class[@name='ItemsView']/method[@name='withCellType' and count(parameter)=1 and parameter[1][@type='DataClass']]"
		[Register ("withCellType", "(Ljava/lang/Object;)Lcom/liveperson/infra/ui/view/utils/ItemsView;", "GetWithCellType_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Liveperson.Infra.UI.View.Utils.ItemsView WithCellType (global::Java.Lang.Object p0)
		{
			if (id_withCellType_Ljava_lang_Object_ == IntPtr.Zero)
				id_withCellType_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "withCellType", "(Ljava/lang/Object;)Lcom/liveperson/infra/ui/view/utils/ItemsView;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Liveperson.Infra.UI.View.Utils.ItemsView __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withCellType_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.Utils.ItemsView> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "withCellType", "(Ljava/lang/Object;)Lcom/liveperson/infra/ui/view/utils/ItemsView;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
