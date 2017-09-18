using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayType']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/PayType", DoNotGenerateAcw=true)]
	public sealed partial class PayType : global::Java.Lang.Enum {


		static IntPtr ONE_STEP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayType']/field[@name='ONE_STEP']"
		[Register ("ONE_STEP")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PayType OneStep {
			get {
				if (ONE_STEP_jfieldId == IntPtr.Zero)
					ONE_STEP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ONE_STEP", "Lru/tinkoff/acquiring/sdk/PayType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ONE_STEP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TWO_STEP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayType']/field[@name='TWO_STEP']"
		[Register ("TWO_STEP")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PayType TwoStep {
			get {
				if (TWO_STEP_jfieldId == IntPtr.Zero)
					TWO_STEP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWO_STEP", "Lru/tinkoff/acquiring/sdk/PayType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWO_STEP_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/PayType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayType); }
		}

		internal PayType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PayType;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.PayType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PayType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.PayType __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/acquiring/sdk/PayType;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.PayType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/acquiring/sdk/PayType;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.PayType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.PayType));
			} finally {
			}
		}

	}
}
