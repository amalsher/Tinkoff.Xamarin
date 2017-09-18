using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Log.Internal {

	[Register ("ru/tinkoff/core/log/internal/LoggerDelegate", DoNotGenerateAcw=true)]
	public abstract class LoggerDelegate : Java.Lang.Object {

		internal LoggerDelegate ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/interface[@name='LoggerDelegate']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public const int Debug = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/interface[@name='LoggerDelegate']/field[@name='ERROR']"
		[Register ("ERROR")]
		public const int Error = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/interface[@name='LoggerDelegate']/field[@name='INFO']"
		[Register ("INFO")]
		public const int Info = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/interface[@name='LoggerDelegate']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public const int Verbose = (int) 1;
	}

	[Register ("ru/tinkoff/core/log/internal/LoggerDelegate", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'LoggerDelegate' type. This type will be removed in a future release.")]
	public abstract class LoggerDelegateConsts : LoggerDelegate {

		private LoggerDelegateConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/interface[@name='LoggerDelegate']"
	[Register ("ru/tinkoff/core/log/internal/LoggerDelegate", "", "RU.Tinkoff.Core.Log.Internal.ILoggerDelegateInvoker")]
	public partial interface ILoggerDelegate : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/interface[@name='LoggerDelegate']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/Throwable;Ljava/lang/String;Ljava/lang/String;)V", "GetLog_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_Handler:RU.Tinkoff.Core.Log.Internal.ILoggerDelegateInvoker, Tinkoff.CoreLog")]
		void Log (int p0, global::Java.Lang.Throwable p1, string p2, string p3);

	}

	[global::Android.Runtime.Register ("ru/tinkoff/core/log/internal/LoggerDelegate", DoNotGenerateAcw=true)]
	internal class ILoggerDelegateInvoker : global::Java.Lang.Object, ILoggerDelegate {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/core/log/internal/LoggerDelegate");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ILoggerDelegateInvoker); }
		}

		IntPtr class_ref;

		public static ILoggerDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILoggerDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.core.log.internal.LoggerDelegate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILoggerDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_);
			return cb_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_Log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::RU.Tinkoff.Core.Log.Internal.ILoggerDelegate __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Log.Internal.ILoggerDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void Log (int p0, global::Java.Lang.Throwable p1, string p2, string p3)
		{
			if (id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(ILjava/lang/Throwable;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			JNIEnv.DeleteLocalRef (native_p3);
		}

	}

}
