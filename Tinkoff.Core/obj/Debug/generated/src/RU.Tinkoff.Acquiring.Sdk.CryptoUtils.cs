using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CryptoUtils']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CryptoUtils", DoNotGenerateAcw=true)]
	public partial class CryptoUtils : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CryptoUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CryptoUtils); }
		}

		protected CryptoUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CryptoUtils']/constructor[@name='CryptoUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CryptoUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CryptoUtils)) {
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

		static IntPtr id_encodeBase64_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CryptoUtils']/method[@name='encodeBase64' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("encodeBase64", "([B)Ljava/lang/String;", "")]
		public static unsafe string EncodeBase64 (byte[] p0)
		{
			if (id_encodeBase64_arrayB == IntPtr.Zero)
				id_encodeBase64_arrayB = JNIEnv.GetStaticMethodID (class_ref, "encodeBase64", "([B)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_encodeBase64_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_encryptRsa_Ljava_lang_String_Ljava_security_PublicKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CryptoUtils']/method[@name='encryptRsa' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.security.PublicKey']]"
		[Register ("encryptRsa", "(Ljava/lang/String;Ljava/security/PublicKey;)[B", "")]
		public static unsafe byte[] EncryptRsa (string p0, global::Java.Security.IPublicKey p1)
		{
			if (id_encryptRsa_Ljava_lang_String_Ljava_security_PublicKey_ == IntPtr.Zero)
				id_encryptRsa_Ljava_lang_String_Ljava_security_PublicKey_ = JNIEnv.GetStaticMethodID (class_ref, "encryptRsa", "(Ljava/lang/String;Ljava/security/PublicKey;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_encryptRsa_Ljava_lang_String_Ljava_security_PublicKey_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_sha256_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CryptoUtils']/method[@name='sha256' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("sha256", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string Sha256 (string p0)
		{
			if (id_sha256_Ljava_lang_String_ == IntPtr.Zero)
				id_sha256_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "sha256", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_sha256_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
