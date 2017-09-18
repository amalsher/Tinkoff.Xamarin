using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/util/TlvUtils", DoNotGenerateAcw=true)]
	public partial class TlvUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='ADF_NAME']"
		[Register ("ADF_NAME")]
		public const string AdfName = (string) "4F";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='APPLICATION_LABEL']"
		[Register ("APPLICATION_LABEL")]
		public const string ApplicationLabel = (string) "50";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='DF_NAME']"
		[Register ("DF_NAME")]
		public const string DfName = (string) "84";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='LOG_ENTRY']"
		[Register ("LOG_ENTRY")]
		public const string LogEntry = (string) "9F 4D";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='PDOL']"
		[Register ("PDOL")]
		public const string Pdol = (string) "9F 38";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='SFI']"
		[Register ("SFI")]
		public const string Sfi = (string) "88";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='TRACK_2']"
		[Register ("TRACK_2")]
		public const string Track2 = (string) "57";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/field[@name='TRACK_2_MASTERCARD']"
		[Register ("TRACK_2_MASTERCARD")]
		public const string Track2Mastercard = (string) "9F 6B";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/util/TlvUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TlvUtils); }
		}

		protected TlvUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/constructor[@name='TlvUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TlvUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TlvUtils)) {
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

		static IntPtr id_getArrayValue_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/method[@name='getArrayValue' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("getArrayValue", "([BLjava/lang/String;)[B", "")]
		public static unsafe byte[] GetArrayValue (byte[] p0, string p1)
		{
			if (id_getArrayValue_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_getArrayValue_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getArrayValue", "([BLjava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getArrayValue_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getHexaValue_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/method[@name='getHexaValue' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("getHexaValue", "([BLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetHexaValue (byte[] p0, string p1)
		{
			if (id_getHexaValue_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_getHexaValue_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getHexaValue", "([BLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_getHexaValue_arrayBLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_getIntValue_arrayBLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='TlvUtils']/method[@name='getIntValue' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.lang.String']]"
		[Register ("getIntValue", "([BLjava/lang/String;)I", "")]
		public static unsafe int GetIntValue (byte[] p0, string p1)
		{
			if (id_getIntValue_arrayBLjava_lang_String_ == IntPtr.Zero)
				id_getIntValue_arrayBLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "getIntValue", "([BLjava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_getIntValue_arrayBLjava_lang_String_, __args);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
