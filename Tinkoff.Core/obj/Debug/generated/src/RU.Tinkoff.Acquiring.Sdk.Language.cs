using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Language']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Language", DoNotGenerateAcw=true)]
	public sealed partial class Language : global::Java.Lang.Enum {


		static IntPtr ENGLISH_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Language']/field[@name='ENGLISH']"
		[Register ("ENGLISH")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Language English {
			get {
				if (ENGLISH_jfieldId == IntPtr.Zero)
					ENGLISH_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENGLISH", "Lru/tinkoff/acquiring/sdk/Language;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENGLISH_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Language> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RUSSIAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Language']/field[@name='RUSSIAN']"
		[Register ("RUSSIAN")]
		public static global::RU.Tinkoff.Acquiring.Sdk.Language Russian {
			get {
				if (RUSSIAN_jfieldId == IntPtr.Zero)
					RUSSIAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RUSSIAN", "Lru/tinkoff/acquiring/sdk/Language;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RUSSIAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Language> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Language", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Language); }
		}

		internal Language (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Language']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Language;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Language ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Language;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.Language __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Language> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Language']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/acquiring/sdk/Language;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Language[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/acquiring/sdk/Language;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.Language[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Language));
			} finally {
			}
		}

	}
}
