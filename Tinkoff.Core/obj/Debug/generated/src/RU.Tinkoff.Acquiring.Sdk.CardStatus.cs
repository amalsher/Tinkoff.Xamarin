using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardStatus']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CardStatus", DoNotGenerateAcw=true)]
	public sealed partial class CardStatus : global::Java.Lang.Enum {


		static IntPtr ACTIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardStatus']/field[@name='ACTIVE']"
		[Register ("ACTIVE")]
		public static global::RU.Tinkoff.Acquiring.Sdk.CardStatus Active {
			get {
				if (ACTIVE_jfieldId == IntPtr.Zero)
					ACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ACTIVE", "Lru/tinkoff/acquiring/sdk/CardStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ACTIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DELETED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardStatus']/field[@name='DELETED']"
		[Register ("DELETED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.CardStatus Deleted {
			get {
				if (DELETED_jfieldId == IntPtr.Zero)
					DELETED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DELETED", "Lru/tinkoff/acquiring/sdk/CardStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DELETED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INACTIVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardStatus']/field[@name='INACTIVE']"
		[Register ("INACTIVE")]
		public static global::RU.Tinkoff.Acquiring.Sdk.CardStatus Inactive {
			get {
				if (INACTIVE_jfieldId == IntPtr.Zero)
					INACTIVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INACTIVE", "Lru/tinkoff/acquiring/sdk/CardStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INACTIVE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CardStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardStatus); }
		}

		internal CardStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromChar_C;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardStatus']/method[@name='fromChar' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("fromChar", "(C)Lru/tinkoff/acquiring/sdk/CardStatus;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.CardStatus FromChar (char p0)
		{
			if (id_fromChar_C == IntPtr.Zero)
				id_fromChar_C = JNIEnv.GetStaticMethodID (class_ref, "fromChar", "(C)Lru/tinkoff/acquiring/sdk/CardStatus;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromChar_C, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/CardStatus;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.CardStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/CardStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.CardStatus __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/acquiring/sdk/CardStatus;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.CardStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/acquiring/sdk/CardStatus;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.CardStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.CardStatus));
			} finally {
			}
		}

	}
}
