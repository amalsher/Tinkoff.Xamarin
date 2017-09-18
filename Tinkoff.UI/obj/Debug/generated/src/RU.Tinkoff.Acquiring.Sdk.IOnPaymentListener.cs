using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='OnPaymentListener']"
	[Register ("ru/tinkoff/acquiring/sdk/OnPaymentListener", "", "RU.Tinkoff.Acquiring.Sdk.IOnPaymentListenerInvoker")]
	public partial interface IOnPaymentListener : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='OnPaymentListener']/method[@name='onCancelled' and count(parameter)=0]"
		[Register ("onCancelled", "()V", "GetOnCancelledHandler:RU.Tinkoff.Acquiring.Sdk.IOnPaymentListenerInvoker, Tinkoff.UI")]
		void OnCancelled ();

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='OnPaymentListener']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("onError", "(Ljava/lang/Exception;)V", "GetOnError_Ljava_lang_Exception_Handler:RU.Tinkoff.Acquiring.Sdk.IOnPaymentListenerInvoker, Tinkoff.UI")]
		void OnError (global::Java.Lang.Exception p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='OnPaymentListener']/method[@name='onSuccess' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("onSuccess", "(J)V", "GetOnSuccess_JHandler:RU.Tinkoff.Acquiring.Sdk.IOnPaymentListenerInvoker, Tinkoff.UI")]
		void OnSuccess (long p0);

	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/OnPaymentListener", DoNotGenerateAcw=true)]
	internal class IOnPaymentListenerInvoker : global::Java.Lang.Object, IOnPaymentListener {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/OnPaymentListener");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IOnPaymentListenerInvoker); }
		}

		IntPtr class_ref;

		public static IOnPaymentListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnPaymentListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.OnPaymentListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnPaymentListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCancelled;
#pragma warning disable 0169
		static Delegate GetOnCancelledHandler ()
		{
			if (cb_onCancelled == null)
				cb_onCancelled = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCancelled);
			return cb_onCancelled;
		}

		static void n_OnCancelled (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.IOnPaymentListener __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.IOnPaymentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCancelled ();
		}
#pragma warning restore 0169

		IntPtr id_onCancelled;
		public unsafe void OnCancelled ()
		{
			if (id_onCancelled == IntPtr.Zero)
				id_onCancelled = JNIEnv.GetMethodID (class_ref, "onCancelled", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCancelled);
		}

		static Delegate cb_onError_Ljava_lang_Exception_;
#pragma warning disable 0169
		static Delegate GetOnError_Ljava_lang_Exception_Handler ()
		{
			if (cb_onError_Ljava_lang_Exception_ == null)
				cb_onError_Ljava_lang_Exception_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnError_Ljava_lang_Exception_);
			return cb_onError_Ljava_lang_Exception_;
		}

		static void n_OnError_Ljava_lang_Exception_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.IOnPaymentListener __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.IOnPaymentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Exception p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Exception> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ljava_lang_Exception_;
		public unsafe void OnError (global::Java.Lang.Exception p0)
		{
			if (id_onError_Ljava_lang_Exception_ == IntPtr.Zero)
				id_onError_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ljava/lang/Exception;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ljava_lang_Exception_, __args);
		}

		static Delegate cb_onSuccess_J;
#pragma warning disable 0169
		static Delegate GetOnSuccess_JHandler ()
		{
			if (cb_onSuccess_J == null)
				cb_onSuccess_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_OnSuccess_J);
			return cb_onSuccess_J;
		}

		static void n_OnSuccess_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.IOnPaymentListener __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.IOnPaymentListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnSuccess (p0);
		}
#pragma warning restore 0169

		IntPtr id_onSuccess_J;
		public unsafe void OnSuccess (long p0)
		{
			if (id_onSuccess_J == IntPtr.Zero)
				id_onSuccess_J = JNIEnv.GetMethodID (class_ref, "onSuccess", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSuccess_J, __args);
		}

	}

	public partial class ErrorEventArgs : global::System.EventArgs {

		public ErrorEventArgs (global::Java.Lang.Exception p0)
		{
			this.p0 = p0;
		}

		global::Java.Lang.Exception p0;
		public global::Java.Lang.Exception P0 {
			get { return p0; }
		}
	}

	public partial class SuccessEventArgs : global::System.EventArgs {

		public SuccessEventArgs (long p0)
		{
			this.p0 = p0;
		}

		long p0;
		public long P0 {
			get { return p0; }
		}
	}

	[global::Android.Runtime.Register ("mono/ru/tinkoff/acquiring/sdk/OnPaymentListenerImplementor")]
	internal sealed partial class IOnPaymentListenerImplementor : global::Java.Lang.Object, IOnPaymentListener {

		object sender;

		public IOnPaymentListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/ru/tinkoff/acquiring/sdk/OnPaymentListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler OnCancelledHandler;
#pragma warning restore 0649

		public void OnCancelled ()
		{
			var __h = OnCancelledHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}
#pragma warning disable 0649
		public EventHandler<ErrorEventArgs> OnErrorHandler;
#pragma warning restore 0649

		public void OnError (global::Java.Lang.Exception p0)
		{
			var __h = OnErrorHandler;
			if (__h != null)
				__h (sender, new ErrorEventArgs (p0));
		}
#pragma warning disable 0649
		public EventHandler<SuccessEventArgs> OnSuccessHandler;
#pragma warning restore 0649

		public void OnSuccess (long p0)
		{
			var __h = OnSuccessHandler;
			if (__h != null)
				__h (sender, new SuccessEventArgs (p0));
		}

		internal static bool __IsEmpty (IOnPaymentListenerImplementor value)
		{
			return value.OnCancelledHandler == null && value.OnErrorHandler == null && value.OnSuccessHandler == null;
		}
	}

}
