using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Log.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/class[@name='AndroidLogger']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/log/internal/AndroidLogger", DoNotGenerateAcw=true)]
	public partial class AndroidLogger : global::Java.Lang.Object, global::RU.Tinkoff.Core.Log.Internal.ILoggerDelegate {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/log/internal/AndroidLogger", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AndroidLogger); }
		}

		protected AndroidLogger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/class[@name='AndroidLogger']/constructor[@name='AndroidLogger' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AndroidLogger ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AndroidLogger)) {
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
			global::RU.Tinkoff.Core.Log.Internal.AndroidLogger __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Log.Internal.AndroidLogger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Throwable p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.log.internal']/class[@name='AndroidLogger']/method[@name='log' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Throwable'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register ("log", "(ILjava/lang/Throwable;Ljava/lang/String;Ljava/lang/String;)V", "GetLog_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (int p0, global::Java.Lang.Throwable p1, string p2, string p3)
		{
			if (id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "log", "(ILjava/lang/Throwable;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_log_ILjava_lang_Throwable_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "log", "(ILjava/lang/Throwable;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

	}
}
