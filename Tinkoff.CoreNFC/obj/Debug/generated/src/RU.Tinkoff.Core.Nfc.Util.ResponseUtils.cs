using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='ResponseUtils']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/util/ResponseUtils", DoNotGenerateAcw=true)]
	public partial class ResponseUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/util/ResponseUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ResponseUtils); }
		}

		protected ResponseUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='ResponseUtils']/constructor[@name='ResponseUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResponseUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ResponseUtils)) {
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

		static IntPtr id_isSucceed_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='ResponseUtils']/method[@name='isSucceed' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("isSucceed", "([B)Z", "")]
		public static unsafe bool IsSucceed (byte[] p0)
		{
			if (id_isSucceed_arrayB == IntPtr.Zero)
				id_isSucceed_arrayB = JNIEnv.GetStaticMethodID (class_ref, "isSucceed", "([B)Z");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSucceed_arrayB, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
