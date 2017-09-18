using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='Logger']"
	[Register ("ru/tinkoff/acquiring/sdk/Logger", "", "RU.Tinkoff.Acquiring.Sdk.ILoggerInvoker")]
	public partial interface ILogger : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='Logger']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("log", "(Ljava/lang/CharSequence;)V", "GetLog_Ljava_lang_CharSequence_Handler:RU.Tinkoff.Acquiring.Sdk.ILoggerInvoker, Tinkoff.Core")]
		void Log (global::Java.Lang.ICharSequence p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='Logger']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/lang/Throwable;)V", "GetLog_Ljava_lang_Throwable_Handler:RU.Tinkoff.Acquiring.Sdk.ILoggerInvoker, Tinkoff.Core")]
		void Log (global::Java.Lang.Throwable p0);

	}

	public static partial class ILoggerExtensions {

		public static void Log (this RU.Tinkoff.Acquiring.Sdk.ILogger self, string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			self.Log (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}
	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Logger", DoNotGenerateAcw=true)]
	internal class ILoggerInvoker : global::Java.Lang.Object, ILogger {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Logger");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoggerInvoker); }
		}

		IntPtr class_ref;

		public static ILogger GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogger> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.Logger"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_log_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_log_Ljava_lang_CharSequence_ == null)
				cb_log_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Log_Ljava_lang_CharSequence_);
			return cb_log_Ljava_lang_CharSequence_;
		}

		static void n_Log_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ILogger __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_lang_CharSequence_;
		public unsafe void Log (global::Java.Lang.ICharSequence p0)
		{
			if (id_log_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_log_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_lang_CharSequence_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

		static Delegate cb_log_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetLog_Ljava_lang_Throwable_Handler ()
		{
			if (cb_log_Ljava_lang_Throwable_ == null)
				cb_log_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Log_Ljava_lang_Throwable_);
			return cb_log_Ljava_lang_Throwable_;
		}

		static void n_Log_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ILogger __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ILogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0);
		}
#pragma warning restore 0169

		IntPtr id_log_Ljava_lang_Throwable_;
		public unsafe void Log (global::Java.Lang.Throwable p0)
		{
			if (id_log_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "log", "(Ljava/lang/Throwable;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_Ljava_lang_Throwable_, __args);
		}

	}

}
