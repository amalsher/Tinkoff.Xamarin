using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Journal']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Journal", DoNotGenerateAcw=true)]
	public abstract partial class Journal : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Journal", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Journal); }
		}

		protected Journal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Journal']/constructor[@name='Journal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Journal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Journal)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_isDebug;
		static IntPtr id_setDebug_Z;
		public static unsafe bool Debug {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Journal']/method[@name='isDebug' and count(parameter)=0]"
			[Register ("isDebug", "()Z", "GetIsDebugHandler")]
			get {
				if (id_isDebug == IntPtr.Zero)
					id_isDebug = JNIEnv.GetStaticMethodID (class_ref, "isDebug", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isDebug);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Journal']/method[@name='setDebug' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDebug", "(Z)V", "GetSetDebug_ZHandler")]
			set {
				if (id_setDebug_Z == IntPtr.Zero)
					id_setDebug_Z = JNIEnv.GetStaticMethodID (class_ref, "setDebug", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallStaticVoidMethod  (class_ref, id_setDebug_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_log_Ljava_lang_CharSequence_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Journal']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("log", "(Ljava/lang/CharSequence;)V", "")]
		public static unsafe void Log (global::Java.Lang.ICharSequence p0)
		{
			if (id_log_Ljava_lang_CharSequence_ == IntPtr.Zero)
				id_log_Ljava_lang_CharSequence_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Ljava/lang/CharSequence;)V");
			IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Ljava_lang_CharSequence_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		public static void Log (string p0)
		{
			global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
			Log (jls_p0);
			if (jls_p0 != null) jls_p0.Dispose ();
		}

		static IntPtr id_log_Ljava_lang_Throwable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Journal']/method[@name='log' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("log", "(Ljava/lang/Throwable;)V", "")]
		public static unsafe void Log (global::Java.Lang.Throwable p0)
		{
			if (id_log_Ljava_lang_Throwable_ == IntPtr.Zero)
				id_log_Ljava_lang_Throwable_ = JNIEnv.GetStaticMethodID (class_ref, "log", "(Ljava/lang/Throwable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_log_Ljava_lang_Throwable_, __args);
			} finally {
			}
		}

		static IntPtr id_setLogger_Lru_tinkoff_acquiring_sdk_Logger_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Journal']/method[@name='setLogger' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Logger']]"
		[Register ("setLogger", "(Lru/tinkoff/acquiring/sdk/Logger;)V", "")]
		public static unsafe void SetLogger (global::RU.Tinkoff.Acquiring.Sdk.ILogger p0)
		{
			if (id_setLogger_Lru_tinkoff_acquiring_sdk_Logger_ == IntPtr.Zero)
				id_setLogger_Lru_tinkoff_acquiring_sdk_Logger_ = JNIEnv.GetStaticMethodID (class_ref, "setLogger", "(Lru/tinkoff/acquiring/sdk/Logger;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setLogger_Lru_tinkoff_acquiring_sdk_Logger_, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Journal", DoNotGenerateAcw=true)]
	internal partial class JournalInvoker : Journal {

		public JournalInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JournalInvoker); }
		}

	}

}
