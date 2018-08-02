using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Liveperson.Infra.UI.View.UI {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']"
	[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView", DoNotGenerateAcw=true)]
	public partial class touchImageView : global::Android.Widget.ImageView {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$CompatScroller", DoNotGenerateAcw=true)]
		public partial class CompatScroller : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$CompatScroller", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CompatScroller); }
			}

			protected CompatScroller (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']/constructor[@name='TouchImageView.CompatScroller' and count(parameter)=2 and parameter[1][@type='com.liveperson.infra.ui.view.ui.TouchImageView'] and parameter[2][@type='android.content.Context']]"
			[Register (".ctor", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView;Landroid/content/Context;)V", "")]
			public unsafe CompatScroller (global::Com.Liveperson.Infra.UI.View.UI.touchImageView __self, global::Android.Content.Context p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (CompatScroller)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView;Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static Delegate cb_getCurrX;
#pragma warning disable 0169
			static Delegate GetGetCurrXHandler ()
			{
				if (cb_getCurrX == null)
					cb_getCurrX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrX);
				return cb_getCurrX;
			}

			static int n_GetCurrX (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CurrX;
			}
#pragma warning restore 0169

			static IntPtr id_getCurrX;
			public virtual unsafe int CurrX {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']/method[@name='getCurrX' and count(parameter)=0]"
				[Register ("getCurrX", "()I", "GetGetCurrXHandler")]
				get {
					if (id_getCurrX == IntPtr.Zero)
						id_getCurrX = JNIEnv.GetMethodID (class_ref, "getCurrX", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrX);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrX", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getCurrY;
#pragma warning disable 0169
			static Delegate GetGetCurrYHandler ()
			{
				if (cb_getCurrY == null)
					cb_getCurrY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrY);
				return cb_getCurrY;
			}

			static int n_GetCurrY (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.CurrY;
			}
#pragma warning restore 0169

			static IntPtr id_getCurrY;
			public virtual unsafe int CurrY {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']/method[@name='getCurrY' and count(parameter)=0]"
				[Register ("getCurrY", "()I", "GetGetCurrYHandler")]
				get {
					if (id_getCurrY == IntPtr.Zero)
						id_getCurrY = JNIEnv.GetMethodID (class_ref, "getCurrY", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCurrY);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrY", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_isFinished;
#pragma warning disable 0169
			static Delegate GetIsFinishedHandler ()
			{
				if (cb_isFinished == null)
					cb_isFinished = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFinished);
				return cb_isFinished;
			}

			static bool n_IsFinished (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsFinished;
			}
#pragma warning restore 0169

			static IntPtr id_isFinished;
			public virtual unsafe bool IsFinished {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']/method[@name='isFinished' and count(parameter)=0]"
				[Register ("isFinished", "()Z", "GetIsFinishedHandler")]
				get {
					if (id_isFinished == IntPtr.Zero)
						id_isFinished = JNIEnv.GetMethodID (class_ref, "isFinished", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFinished);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFinished", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_computeScrollOffset;
#pragma warning disable 0169
			static Delegate GetComputeScrollOffsetHandler ()
			{
				if (cb_computeScrollOffset == null)
					cb_computeScrollOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ComputeScrollOffset);
				return cb_computeScrollOffset;
			}

			static bool n_ComputeScrollOffset (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.ComputeScrollOffset ();
			}
#pragma warning restore 0169

			static IntPtr id_computeScrollOffset;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']/method[@name='computeScrollOffset' and count(parameter)=0]"
			[Register ("computeScrollOffset", "()Z", "GetComputeScrollOffsetHandler")]
			public virtual unsafe bool ComputeScrollOffset ()
			{
				if (id_computeScrollOffset == IntPtr.Zero)
					id_computeScrollOffset = JNIEnv.GetMethodID (class_ref, "computeScrollOffset", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_computeScrollOffset);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "computeScrollOffset", "()Z"));
				} finally {
				}
			}

			static Delegate cb_fling_IIIIIIII;
#pragma warning disable 0169
			static Delegate GetFling_IIIIIIIIHandler ()
			{
				if (cb_fling_IIIIIIII == null)
					cb_fling_IIIIIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int, int, int, int>) n_Fling_IIIIIIII);
				return cb_fling_IIIIIIII;
			}

			static void n_Fling_IIIIIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Fling (p0, p1, p2, p3, p4, p5, p6, p7);
			}
#pragma warning restore 0169

			static IntPtr id_fling_IIIIIIII;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']/method[@name='fling' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int']]"
			[Register ("fling", "(IIIIIIII)V", "GetFling_IIIIIIIIHandler")]
			public virtual unsafe void Fling (int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7)
			{
				if (id_fling_IIIIIIII == IntPtr.Zero)
					id_fling_IIIIIIII = JNIEnv.GetMethodID (class_ref, "fling", "(IIIIIIII)V");
				try {
					JValue* __args = stackalloc JValue [8];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					__args [5] = new JValue (p5);
					__args [6] = new JValue (p6);
					__args [7] = new JValue (p7);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fling_IIIIIIII, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "fling", "(IIIIIIII)V"), __args);
				} finally {
				}
			}

			static Delegate cb_forceFinished_Z;
#pragma warning disable 0169
			static Delegate GetForceFinished_ZHandler ()
			{
				if (cb_forceFinished_Z == null)
					cb_forceFinished_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_ForceFinished_Z);
				return cb_forceFinished_Z;
			}

			static void n_ForceFinished_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.CompatScroller> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.ForceFinished (p0);
			}
#pragma warning restore 0169

			static IntPtr id_forceFinished_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.CompatScroller']/method[@name='forceFinished' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("forceFinished", "(Z)V", "GetForceFinished_ZHandler")]
			public virtual unsafe void ForceFinished (bool p0)
			{
				if (id_forceFinished_Z == IntPtr.Zero)
					id_forceFinished_Z = JNIEnv.GetMethodID (class_ref, "forceFinished", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_forceFinished_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "forceFinished", "(Z)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.DoubleTapZoom']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$DoubleTapZoom", DoNotGenerateAcw=true)]
		public partial class DoubleTapZoom : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$DoubleTapZoom", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DoubleTapZoom); }
			}

			protected DoubleTapZoom (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.DoubleTapZoom __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.DoubleTapZoom> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.DoubleTapZoom']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.Fling']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$Fling", DoNotGenerateAcw=true)]
		public partial class Fling : global::Java.Lang.Object, global::Java.Lang.IRunnable {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$Fling", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Fling); }
			}

			protected Fling (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_cancelFling;
#pragma warning disable 0169
			static Delegate GetCancelFlingHandler ()
			{
				if (cb_cancelFling == null)
					cb_cancelFling = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CancelFling);
				return cb_cancelFling;
			}

			static void n_CancelFling (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.Fling __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.Fling> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.CancelFling ();
			}
#pragma warning restore 0169

			static IntPtr id_cancelFling;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.Fling']/method[@name='cancelFling' and count(parameter)=0]"
			[Register ("cancelFling", "()V", "GetCancelFlingHandler")]
			public virtual unsafe void CancelFling ()
			{
				if (id_cancelFling == IntPtr.Zero)
					id_cancelFling = JNIEnv.GetMethodID (class_ref, "cancelFling", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_cancelFling);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "cancelFling", "()V"));
				} finally {
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.Fling __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.Fling> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			static IntPtr id_run;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.Fling']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				if (id_run == IntPtr.Zero)
					id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");
				try {

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_run);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.GestureListener']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$GestureListener", DoNotGenerateAcw=true)]
		public partial class GestureListener : global::Android.Views.GestureDetector.SimpleOnGestureListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$GestureListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GestureListener); }
			}

			protected GestureListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/interface[@name='TouchImageView.OnTouchImageViewListener']"
		[Register ("com/liveperson/infra/ui/view/ui/TouchImageView$OnTouchImageViewListener", "", "Com.Liveperson.Infra.UI.View.UI.touchImageView/IOnTouchImageViewListenerInvoker")]
		public partial interface IOnTouchImageViewListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/interface[@name='TouchImageView.OnTouchImageViewListener']/method[@name='onMove' and count(parameter)=0]"
			[Register ("onMove", "()V", "GetOnMoveHandler:Com.Liveperson.Infra.UI.View.UI.touchImageView/IOnTouchImageViewListenerInvoker, LP_UI_Binding")]
			void OnMove ();

		}

		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$OnTouchImageViewListener", DoNotGenerateAcw=true)]
		internal class IOnTouchImageViewListenerInvoker : global::Java.Lang.Object, IOnTouchImageViewListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$OnTouchImageViewListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnTouchImageViewListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnTouchImageViewListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnTouchImageViewListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.liveperson.infra.ui.view.ui.TouchImageView.OnTouchImageViewListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnTouchImageViewListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onMove;
#pragma warning disable 0169
			static Delegate GetOnMoveHandler ()
			{
				if (cb_onMove == null)
					cb_onMove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnMove);
				return cb_onMove;
			}

			static void n_OnMove (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.OnMove ();
			}
#pragma warning restore 0169

			IntPtr id_onMove;
			public unsafe void OnMove ()
			{
				if (id_onMove == IntPtr.Zero)
					id_onMove = JNIEnv.GetMethodID (class_ref, "onMove", "()V");
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onMove);
			}

		}

		[global::Android.Runtime.Register ("mono/com/liveperson/infra/ui/view/ui/TouchImageView_OnTouchImageViewListenerImplementor")]
		internal sealed partial class IOnTouchImageViewListenerImplementor : global::Java.Lang.Object, IOnTouchImageViewListener {

			object sender;

			public IOnTouchImageViewListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/liveperson/infra/ui/view/ui/TouchImageView_OnTouchImageViewListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler Handler;
#pragma warning restore 0649

			public void OnMove ()
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new EventArgs ());
			}

			internal static bool __IsEmpty (IOnTouchImageViewListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.PrivateOnTouchListener']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$PrivateOnTouchListener", DoNotGenerateAcw=true)]
		public partial class PrivateOnTouchListener : global::Java.Lang.Object, global::Android.Views.View.IOnTouchListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$PrivateOnTouchListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PrivateOnTouchListener); }
			}

			protected PrivateOnTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
			static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
			{
				if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
					cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
				return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			}

			static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::Com.Liveperson.Infra.UI.View.UI.touchImageView.PrivateOnTouchListener __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.PrivateOnTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p0 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnTouch (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.PrivateOnTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
			[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
			public virtual unsafe bool OnTouch (global::Android.Views.View p0, global::Android.Views.MotionEvent p1)
			{
				if (id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == IntPtr.Zero)
					id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onTouch_Landroid_view_View_Landroid_view_MotionEvent_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.ScaleListener']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$ScaleListener", DoNotGenerateAcw=true)]
		public partial class ScaleListener : global::Android.Views.ScaleGestureDetector.SimpleOnScaleGestureListener {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$ScaleListener", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScaleListener); }
			}

			protected ScaleListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.State']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$State", DoNotGenerateAcw=true)]
		public sealed partial class State : global::Java.Lang.Enum {


			static IntPtr ANIMATE_ZOOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.State']/field[@name='ANIMATE_ZOOM']"
			[Register ("ANIMATE_ZOOM")]
			public static global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State AnimateZoom {
				get {
					if (ANIMATE_ZOOM_jfieldId == IntPtr.Zero)
						ANIMATE_ZOOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANIMATE_ZOOM", "Lcom/liveperson/infra/ui/view/ui/TouchImageView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANIMATE_ZOOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr DRAG_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.State']/field[@name='DRAG']"
			[Register ("DRAG")]
			public static global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State Drag {
				get {
					if (DRAG_jfieldId == IntPtr.Zero)
						DRAG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DRAG", "Lcom/liveperson/infra/ui/view/ui/TouchImageView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DRAG_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr FLING_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.State']/field[@name='FLING']"
			[Register ("FLING")]
			public static global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State Fling {
				get {
					if (FLING_jfieldId == IntPtr.Zero)
						FLING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLING", "Lcom/liveperson/infra/ui/view/ui/TouchImageView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLING_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr NONE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.State']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State None {
				get {
					if (NONE_jfieldId == IntPtr.Zero)
						NONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NONE", "Lcom/liveperson/infra/ui/view/ui/TouchImageView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NONE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr ZOOM_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.State']/field[@name='ZOOM']"
			[Register ("ZOOM")]
			public static global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State Zoom {
				get {
					if (ZOOM_jfieldId == IntPtr.Zero)
						ZOOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ZOOM", "Lcom/liveperson/infra/ui/view/ui/TouchImageView$State;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ZOOM_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.State> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$State", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (State); }
			}

			internal State (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.ZoomVariables']"
		[global::Android.Runtime.Register ("com/liveperson/infra/ui/view/ui/TouchImageView$ZoomVariables", DoNotGenerateAcw=true)]
		public partial class ZoomVariables : global::Java.Lang.Object {


			static IntPtr focusX_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.ZoomVariables']/field[@name='focusX']"
			[Register ("focusX")]
			public float FocusX {
				get {
					if (focusX_jfieldId == IntPtr.Zero)
						focusX_jfieldId = JNIEnv.GetFieldID (class_ref, "focusX", "F");
					return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, focusX_jfieldId);
				}
				set {
					if (focusX_jfieldId == IntPtr.Zero)
						focusX_jfieldId = JNIEnv.GetFieldID (class_ref, "focusX", "F");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, focusX_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr focusY_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.ZoomVariables']/field[@name='focusY']"
			[Register ("focusY")]
			public float FocusY {
				get {
					if (focusY_jfieldId == IntPtr.Zero)
						focusY_jfieldId = JNIEnv.GetFieldID (class_ref, "focusY", "F");
					return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, focusY_jfieldId);
				}
				set {
					if (focusY_jfieldId == IntPtr.Zero)
						focusY_jfieldId = JNIEnv.GetFieldID (class_ref, "focusY", "F");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, focusY_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr scale_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.ZoomVariables']/field[@name='scale']"
			[Register ("scale")]
			public float Scale {
				get {
					if (scale_jfieldId == IntPtr.Zero)
						scale_jfieldId = JNIEnv.GetFieldID (class_ref, "scale", "F");
					return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, scale_jfieldId);
				}
				set {
					if (scale_jfieldId == IntPtr.Zero)
						scale_jfieldId = JNIEnv.GetFieldID (class_ref, "scale", "F");
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, scale_jfieldId, value);
					} finally {
					}
				}
			}

			static IntPtr scaleType_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.ZoomVariables']/field[@name='scaleType']"
			[Register ("scaleType")]
			public global::Android.Widget.ImageView.ScaleType ScaleType {
				get {
					if (scaleType_jfieldId == IntPtr.Zero)
						scaleType_jfieldId = JNIEnv.GetFieldID (class_ref, "scaleType", "Landroid/widget/ImageView$ScaleType;");
					IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, scaleType_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (scaleType_jfieldId == IntPtr.Zero)
						scaleType_jfieldId = JNIEnv.GetFieldID (class_ref, "scaleType", "Landroid/widget/ImageView$ScaleType;");
					IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
					try {
						JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, scaleType_jfieldId, native_value);
					} finally {
						JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView$ZoomVariables", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ZoomVariables); }
			}

			protected ZoomVariables (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_FFFLandroid_widget_ImageView_ScaleType_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView.ZoomVariables']/constructor[@name='TouchImageView.ZoomVariables' and count(parameter)=5 and parameter[1][@type='com.liveperson.infra.ui.view.ui.TouchImageView'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.widget.ImageView.ScaleType']]"
			[Register (".ctor", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView;FFFLandroid/widget/ImageView$ScaleType;)V", "")]
			public unsafe ZoomVariables (global::Com.Liveperson.Infra.UI.View.UI.touchImageView __self, float p1, float p2, float p3, global::Android.Widget.ImageView.ScaleType p4)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [5];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					__args [3] = new JValue (p3);
					__args [4] = new JValue (p4);
					if (((object) this).GetType () != typeof (ZoomVariables)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";FFFLandroid/widget/ImageView$ScaleType;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";FFFLandroid/widget/ImageView$ScaleType;)V", __args);
						return;
					}

					if (id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_FFFLandroid_widget_ImageView_ScaleType_ == IntPtr.Zero)
						id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_FFFLandroid_widget_ImageView_ScaleType_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView;FFFLandroid/widget/ImageView$ScaleType;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_FFFLandroid_widget_ImageView_ScaleType_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_liveperson_infra_ui_view_ui_TouchImageView_FFFLandroid_widget_ImageView_ScaleType_, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/liveperson/infra/ui/view/ui/TouchImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (touchImageView); }
		}

		protected touchImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/constructor[@name='TouchImageView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe touchImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (touchImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/constructor[@name='TouchImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe touchImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (touchImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/constructor[@name='TouchImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe touchImageView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (touchImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentZoom;
#pragma warning disable 0169
		static Delegate GetGetCurrentZoomHandler ()
		{
			if (cb_getCurrentZoom == null)
				cb_getCurrentZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCurrentZoom);
			return cb_getCurrentZoom;
		}

		static float n_GetCurrentZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentZoom;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentZoom;
		public virtual unsafe float CurrentZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='getCurrentZoom' and count(parameter)=0]"
			[Register ("getCurrentZoom", "()F", "GetGetCurrentZoomHandler")]
			get {
				if (id_getCurrentZoom == IntPtr.Zero)
					id_getCurrentZoom = JNIEnv.GetMethodID (class_ref, "getCurrentZoom", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentZoom);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentZoom", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_isZoomed;
#pragma warning disable 0169
		static Delegate GetIsZoomedHandler ()
		{
			if (cb_isZoomed == null)
				cb_isZoomed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsZoomed);
			return cb_isZoomed;
		}

		static bool n_IsZoomed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsZoomed;
		}
#pragma warning restore 0169

		static IntPtr id_isZoomed;
		public virtual unsafe bool IsZoomed {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='isZoomed' and count(parameter)=0]"
			[Register ("isZoomed", "()Z", "GetIsZoomedHandler")]
			get {
				if (id_isZoomed == IntPtr.Zero)
					id_isZoomed = JNIEnv.GetMethodID (class_ref, "isZoomed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isZoomed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isZoomed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMaxZoom;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomHandler ()
		{
			if (cb_getMaxZoom == null)
				cb_getMaxZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxZoom);
			return cb_getMaxZoom;
		}

		static float n_GetMaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxZoom_F;
#pragma warning disable 0169
		static Delegate GetSetMaxZoom_FHandler ()
		{
			if (cb_setMaxZoom_F == null)
				cb_setMaxZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxZoom_F);
			return cb_setMaxZoom_F;
		}

		static void n_SetMaxZoom_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxZoom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxZoom;
		static IntPtr id_setMaxZoom_F;
		public virtual unsafe float MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()F", "GetGetMaxZoomHandler")]
			get {
				if (id_getMaxZoom == IntPtr.Zero)
					id_getMaxZoom = JNIEnv.GetMethodID (class_ref, "getMaxZoom", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMaxZoom);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxZoom", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setMaxZoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxZoom", "(F)V", "GetSetMaxZoom_FHandler")]
			set {
				if (id_setMaxZoom_F == IntPtr.Zero)
					id_setMaxZoom_F = JNIEnv.GetMethodID (class_ref, "setMaxZoom", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMaxZoom_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxZoom", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinZoom;
#pragma warning disable 0169
		static Delegate GetGetMinZoomHandler ()
		{
			if (cb_getMinZoom == null)
				cb_getMinZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinZoom);
			return cb_getMinZoom;
		}

		static float n_GetMinZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinZoom;
		}
#pragma warning restore 0169

		static Delegate cb_setMinZoom_F;
#pragma warning disable 0169
		static Delegate GetSetMinZoom_FHandler ()
		{
			if (cb_setMinZoom_F == null)
				cb_setMinZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinZoom_F);
			return cb_setMinZoom_F;
		}

		static void n_SetMinZoom_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinZoom = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinZoom;
		static IntPtr id_setMinZoom_F;
		public virtual unsafe float MinZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='getMinZoom' and count(parameter)=0]"
			[Register ("getMinZoom", "()F", "GetGetMinZoomHandler")]
			get {
				if (id_getMinZoom == IntPtr.Zero)
					id_getMinZoom = JNIEnv.GetMethodID (class_ref, "getMinZoom", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMinZoom);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinZoom", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setMinZoom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinZoom", "(F)V", "GetSetMinZoom_FHandler")]
			set {
				if (id_setMinZoom_F == IntPtr.Zero)
					id_setMinZoom_F = JNIEnv.GetMethodID (class_ref, "setMinZoom", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMinZoom_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinZoom", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScrollPosition;
#pragma warning disable 0169
		static Delegate GetGetScrollPositionHandler ()
		{
			if (cb_getScrollPosition == null)
				cb_getScrollPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScrollPosition);
			return cb_getScrollPosition;
		}

		static IntPtr n_GetScrollPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScrollPosition);
		}
#pragma warning restore 0169

		static IntPtr id_getScrollPosition;
		public virtual unsafe global::Android.Graphics.PointF ScrollPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='getScrollPosition' and count(parameter)=0]"
			[Register ("getScrollPosition", "()Landroid/graphics/PointF;", "GetGetScrollPositionHandler")]
			get {
				if (id_getScrollPosition == IntPtr.Zero)
					id_getScrollPosition = JNIEnv.GetMethodID (class_ref, "getScrollPosition", "()Landroid/graphics/PointF;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScrollPosition), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScrollPosition", "()Landroid/graphics/PointF;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getZoomedRect;
#pragma warning disable 0169
		static Delegate GetGetZoomedRectHandler ()
		{
			if (cb_getZoomedRect == null)
				cb_getZoomedRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetZoomedRect);
			return cb_getZoomedRect;
		}

		static IntPtr n_GetZoomedRect (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoomedRect);
		}
#pragma warning restore 0169

		static IntPtr id_getZoomedRect;
		public virtual unsafe global::Android.Graphics.RectF ZoomedRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='getZoomedRect' and count(parameter)=0]"
			[Register ("getZoomedRect", "()Landroid/graphics/RectF;", "GetGetZoomedRectHandler")]
			get {
				if (id_getZoomedRect == IntPtr.Zero)
					id_getZoomedRect = JNIEnv.GetMethodID (class_ref, "getZoomedRect", "()Landroid/graphics/RectF;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZoomedRect), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getZoomedRect", "()Landroid/graphics/RectF;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_canScrollHorizontallyFroyo_I;
#pragma warning disable 0169
		static Delegate GetCanScrollHorizontallyFroyo_IHandler ()
		{
			if (cb_canScrollHorizontallyFroyo_I == null)
				cb_canScrollHorizontallyFroyo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_CanScrollHorizontallyFroyo_I);
			return cb_canScrollHorizontallyFroyo_I;
		}

		static bool n_CanScrollHorizontallyFroyo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanScrollHorizontallyFroyo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_canScrollHorizontallyFroyo_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='canScrollHorizontallyFroyo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("canScrollHorizontallyFroyo", "(I)Z", "GetCanScrollHorizontallyFroyo_IHandler")]
		public virtual unsafe bool CanScrollHorizontallyFroyo (int p0)
		{
			if (id_canScrollHorizontallyFroyo_I == IntPtr.Zero)
				id_canScrollHorizontallyFroyo_I = JNIEnv.GetMethodID (class_ref, "canScrollHorizontallyFroyo", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_canScrollHorizontallyFroyo_I, __args);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canScrollHorizontallyFroyo", "(I)Z"), __args);
			} finally {
			}
		}

		static Delegate cb_onConfigurationChanged_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_onConfigurationChanged_Landroid_content_res_Configuration_ == null)
				cb_onConfigurationChanged_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnConfigurationChanged_Landroid_content_res_Configuration_);
			return cb_onConfigurationChanged_Landroid_content_res_Configuration_;
		}

		static void n_OnConfigurationChanged_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnConfigurationChanged (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onConfigurationChanged_Landroid_content_res_Configuration_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='onConfigurationChanged' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("onConfigurationChanged", "(Landroid/content/res/Configuration;)V", "GetOnConfigurationChanged_Landroid_content_res_Configuration_Handler")]
		public virtual unsafe void OnConfigurationChanged (global::Android.Content.Res.Configuration p0)
		{
			if (id_onConfigurationChanged_Landroid_content_res_Configuration_ == IntPtr.Zero)
				id_onConfigurationChanged_Landroid_content_res_Configuration_ = JNIEnv.GetMethodID (class_ref, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onConfigurationChanged_Landroid_content_res_Configuration_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onConfigurationChanged", "(Landroid/content/res/Configuration;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resetZoom;
#pragma warning disable 0169
		static Delegate GetResetZoomHandler ()
		{
			if (cb_resetZoom == null)
				cb_resetZoom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetZoom);
			return cb_resetZoom;
		}

		static void n_ResetZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_resetZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='resetZoom' and count(parameter)=0]"
		[Register ("resetZoom", "()V", "GetResetZoomHandler")]
		public virtual unsafe void ResetZoom ()
		{
			if (id_resetZoom == IntPtr.Zero)
				id_resetZoom = JNIEnv.GetMethodID (class_ref, "resetZoom", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_resetZoom);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "resetZoom", "()V"));
			} finally {
			}
		}

		static Delegate cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_Handler ()
		{
			if (cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ == null)
				cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_);
			return cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
		}

		static void n_SetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.GestureDetector.IOnDoubleTapListener p0 = (global::Android.Views.GestureDetector.IOnDoubleTapListener)global::Java.Lang.Object.GetObject<global::Android.Views.GestureDetector.IOnDoubleTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDoubleTapListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setOnDoubleTapListener' and count(parameter)=1 and parameter[1][@type='android.view.GestureDetector.OnDoubleTapListener']]"
		[Register ("setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V", "GetSetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_Handler")]
		public virtual unsafe void SetOnDoubleTapListener (global::Android.Views.GestureDetector.IOnDoubleTapListener p0)
		{
			if (id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ == IntPtr.Zero)
				id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ = JNIEnv.GetMethodID (class_ref, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_Handler ()
		{
			if (cb_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_ == null)
				cb_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_);
			return cb_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_;
		}

		static void n_SetOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener p0 = (global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener)global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnTouchImageViewListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setOnTouchImageViewListener' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.ui.TouchImageView.OnTouchImageViewListener']]"
		[Register ("setOnTouchImageViewListener", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView$OnTouchImageViewListener;)V", "GetSetOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_Handler")]
		public virtual unsafe void SetOnTouchImageViewListener (global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener p0)
		{
			if (id_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_ == IntPtr.Zero)
				id_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_ = JNIEnv.GetMethodID (class_ref, "setOnTouchImageViewListener", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView$OnTouchImageViewListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOnTouchImageViewListener_Lcom_liveperson_infra_ui_view_ui_TouchImageView_OnTouchImageViewListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnTouchImageViewListener", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView$OnTouchImageViewListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScrollPosition_FF;
#pragma warning disable 0169
		static Delegate GetSetScrollPosition_FFHandler ()
		{
			if (cb_setScrollPosition_FF == null)
				cb_setScrollPosition_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetScrollPosition_FF);
			return cb_setScrollPosition_FF;
		}

		static void n_SetScrollPosition_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScrollPosition (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setScrollPosition_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setScrollPosition' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setScrollPosition", "(FF)V", "GetSetScrollPosition_FFHandler")]
		public virtual unsafe void SetScrollPosition (float p0, float p1)
		{
			if (id_setScrollPosition_FF == IntPtr.Zero)
				id_setScrollPosition_FF = JNIEnv.GetMethodID (class_ref, "setScrollPosition", "(FF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScrollPosition_FF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScrollPosition", "(FF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_;
#pragma warning disable 0169
		static Delegate GetSetZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_Handler ()
		{
			if (cb_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_ == null)
				cb_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_);
			return cb_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_;
		}

		static void n_SetZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView p0 = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='com.liveperson.infra.ui.view.ui.TouchImageView']]"
		[Register ("setZoom", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView;)V", "GetSetZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_Handler")]
		public virtual unsafe void SetZoom (global::Com.Liveperson.Infra.UI.View.UI.touchImageView p0)
		{
			if (id_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_ == IntPtr.Zero)
				id_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_ = JNIEnv.GetMethodID (class_ref, "setZoom", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoom_Lcom_liveperson_infra_ui_view_ui_TouchImageView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(Lcom/liveperson/infra/ui/view/ui/TouchImageView;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_F;
#pragma warning disable 0169
		static Delegate GetSetZoom_FHandler ()
		{
			if (cb_setZoom_F == null)
				cb_setZoom_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetZoom_F);
			return cb_setZoom_F;
		}

		static void n_SetZoom_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoom_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setZoom", "(F)V", "GetSetZoom_FHandler")]
		public virtual unsafe void SetZoom (float p0)
		{
			if (id_setZoom_F == IntPtr.Zero)
				id_setZoom_F = JNIEnv.GetMethodID (class_ref, "setZoom", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoom_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_FFF;
#pragma warning disable 0169
		static Delegate GetSetZoom_FFFHandler ()
		{
			if (cb_setZoom_FFF == null)
				cb_setZoom_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetZoom_FFF);
			return cb_setZoom_FFF;
		}

		static void n_SetZoom_FFF (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setZoom_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setZoom' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setZoom", "(FFF)V", "GetSetZoom_FFFHandler")]
		public virtual unsafe void SetZoom (float p0, float p1, float p2)
		{
			if (id_setZoom_FFF == IntPtr.Zero)
				id_setZoom_FFF = JNIEnv.GetMethodID (class_ref, "setZoom", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoom_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_FFFLandroid_widget_ImageView_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetZoom_FFFLandroid_widget_ImageView_ScaleType_Handler ()
		{
			if (cb_setZoom_FFFLandroid_widget_ImageView_ScaleType_ == null)
				cb_setZoom_FFFLandroid_widget_ImageView_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, IntPtr>) n_SetZoom_FFFLandroid_widget_ImageView_ScaleType_);
			return cb_setZoom_FFFLandroid_widget_ImageView_ScaleType_;
		}

		static void n_SetZoom_FFFLandroid_widget_ImageView_ScaleType_ (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, IntPtr native_p3)
		{
			global::Com.Liveperson.Infra.UI.View.UI.touchImageView __this = global::Java.Lang.Object.GetObject<global::Com.Liveperson.Infra.UI.View.UI.touchImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.ImageView.ScaleType p3 = global::Java.Lang.Object.GetObject<global::Android.Widget.ImageView.ScaleType> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setZoom_FFFLandroid_widget_ImageView_ScaleType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.liveperson.infra.ui.view.ui']/class[@name='TouchImageView']/method[@name='setZoom' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='android.widget.ImageView.ScaleType']]"
		[Register ("setZoom", "(FFFLandroid/widget/ImageView$ScaleType;)V", "GetSetZoom_FFFLandroid_widget_ImageView_ScaleType_Handler")]
		public virtual unsafe void SetZoom (float p0, float p1, float p2, global::Android.Widget.ImageView.ScaleType p3)
		{
			if (id_setZoom_FFFLandroid_widget_ImageView_ScaleType_ == IntPtr.Zero)
				id_setZoom_FFFLandroid_widget_ImageView_ScaleType_ = JNIEnv.GetMethodID (class_ref, "setZoom", "(FFFLandroid/widget/ImageView$ScaleType;)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoom_FFFLandroid_widget_ImageView_ScaleType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoom", "(FFFLandroid/widget/ImageView$ScaleType;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener"
		public event EventHandler TouchImageView {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener, global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListenerImplementor>(
						ref weak_implementor_SetOnTouchImageViewListener,
						__CreateIOnTouchImageViewListenerImplementor,
						SetOnTouchImageViewListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListener, global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListenerImplementor>(
						ref weak_implementor_SetOnTouchImageViewListener,
						global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListenerImplementor.__IsEmpty,
						__v => SetOnTouchImageViewListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnTouchImageViewListener;

		global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListenerImplementor __CreateIOnTouchImageViewListenerImplementor ()
		{
			return new global::Com.Liveperson.Infra.UI.View.UI.touchImageView.IOnTouchImageViewListenerImplementor (this);
		}
#endregion
	}
}
