using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='OnBackPressedListener']"
	[Register ("ru/tinkoff/acquiring/sdk/OnBackPressedListener", "", "RU.Tinkoff.Acquiring.Sdk.IOnBackPressedListenerInvoker")]
	public partial interface IOnBackPressedListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='OnBackPressedListener']/method[@name='onBackPressed' and count(parameter)=0]"
		[Register ("onBackPressed", "()Z", "GetOnBackPressedHandler:RU.Tinkoff.Acquiring.Sdk.IOnBackPressedListenerInvoker, Tinkoff.UI")]
		bool OnBackPressed ();

	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/OnBackPressedListener", DoNotGenerateAcw=true)]
	internal class IOnBackPressedListenerInvoker : global::Java.Lang.Object, IOnBackPressedListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/OnBackPressedListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnBackPressedListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnBackPressedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnBackPressedListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.OnBackPressedListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnBackPressedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onBackPressed;
#pragma warning disable 0169
		static Delegate GetOnBackPressedHandler ()
		{
			if (cb_onBackPressed == null)
				cb_onBackPressed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_OnBackPressed);
			return cb_onBackPressed;
		}

		static bool n_OnBackPressed (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.IOnBackPressedListener __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.IOnBackPressedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnBackPressed ();
		}
#pragma warning restore 0169

		IntPtr id_onBackPressed;
		public unsafe bool OnBackPressed ()
		{
			if (id_onBackPressed == IntPtr.Zero)
				id_onBackPressed = JNIEnv.GetMethodID (class_ref, "onBackPressed", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onBackPressed);
		}

	}

	public partial class BackPressedEventArgs : global::System.EventArgs {

		public BackPressedEventArgs (bool handled)
		{
			this.handled = handled;
		}

		bool handled;
		public bool Handled {
			get { return handled; }
			set { handled = value; }
		}
	}

	[global::Android.Runtime.Register ("mono/ru/tinkoff/acquiring/sdk/OnBackPressedListenerImplementor")]
	internal sealed partial class IOnBackPressedListenerImplementor : global::Java.Lang.Object, IOnBackPressedListener {

		object sender;

		public IOnBackPressedListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/ru/tinkoff/acquiring/sdk/OnBackPressedListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler<BackPressedEventArgs> Handler;
#pragma warning restore 0649

		public bool OnBackPressed ()
		{
			var __h = Handler;
			if (__h == null)
				return false;
			var __e = new BackPressedEventArgs (true);
			__h (sender, __e);
			return __e.Handled;
		}

		internal static bool __IsEmpty (IOnBackPressedListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
