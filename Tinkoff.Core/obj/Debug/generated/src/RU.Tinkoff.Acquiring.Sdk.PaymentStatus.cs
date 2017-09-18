using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/PaymentStatus", DoNotGenerateAcw=true)]
	public sealed partial class PaymentStatus : global::Java.Lang.Enum {


		static IntPtr AUTHORIZED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='AUTHORIZED']"
		[Register ("AUTHORIZED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Authorized {
			get {
				if (AUTHORIZED_jfieldId == IntPtr.Zero)
					AUTHORIZED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr AUTHORIZING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='AUTHORIZING']"
		[Register ("AUTHORIZING")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Authorizing {
			get {
				if (AUTHORIZING_jfieldId == IntPtr.Zero)
					AUTHORIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTHORIZING", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTHORIZING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CANCELLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='CANCELLED']"
		[Register ("CANCELLED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Cancelled {
			get {
				if (CANCELLED_jfieldId == IntPtr.Zero)
					CANCELLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CANCELLED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CANCELLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONFIRMED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='CONFIRMED']"
		[Register ("CONFIRMED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Confirmed {
			get {
				if (CONFIRMED_jfieldId == IntPtr.Zero)
					CONFIRMED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFIRMED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONFIRMED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CONFIRMING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='CONFIRMING']"
		[Register ("CONFIRMING")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Confirming {
			get {
				if (CONFIRMING_jfieldId == IntPtr.Zero)
					CONFIRMING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONFIRMING", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONFIRMING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FORMSHOWED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='FORMSHOWED']"
		[Register ("FORMSHOWED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Formshowed {
			get {
				if (FORMSHOWED_jfieldId == IntPtr.Zero)
					FORMSHOWED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FORMSHOWED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FORMSHOWED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NEW_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='NEW']"
		[Register ("NEW")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus New {
			get {
				if (NEW_jfieldId == IntPtr.Zero)
					NEW_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NEW", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NEW_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr PREAUTHORIZING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='PREAUTHORIZING']"
		[Register ("PREAUTHORIZING")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Preauthorizing {
			get {
				if (PREAUTHORIZING_jfieldId == IntPtr.Zero)
					PREAUTHORIZING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PREAUTHORIZING", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PREAUTHORIZING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REFUNDED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='REFUNDED']"
		[Register ("REFUNDED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Refunded {
			get {
				if (REFUNDED_jfieldId == IntPtr.Zero)
					REFUNDED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUNDED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUNDED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REFUNDING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='REFUNDING']"
		[Register ("REFUNDING")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Refunding {
			get {
				if (REFUNDING_jfieldId == IntPtr.Zero)
					REFUNDING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REFUNDING", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REFUNDING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REJECTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='REJECTED']"
		[Register ("REJECTED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Rejected {
			get {
				if (REJECTED_jfieldId == IntPtr.Zero)
					REJECTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REJECTED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REJECTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REVERSED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='REVERSED']"
		[Register ("REVERSED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Reversed {
			get {
				if (REVERSED_jfieldId == IntPtr.Zero)
					REVERSED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REVERSED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr REVERSING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='REVERSING']"
		[Register ("REVERSING")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Reversing {
			get {
				if (REVERSING_jfieldId == IntPtr.Zero)
					REVERSING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "REVERSING", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, REVERSING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_DS_CHECKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='THREE_DS_CHECKED']"
		[Register ("THREE_DS_CHECKED")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus ThreeDsChecked {
			get {
				if (THREE_DS_CHECKED_jfieldId == IntPtr.Zero)
					THREE_DS_CHECKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_DS_CHECKED", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_DS_CHECKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr THREE_DS_CHECKING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='THREE_DS_CHECKING']"
		[Register ("THREE_DS_CHECKING")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus ThreeDsChecking {
			get {
				if (THREE_DS_CHECKING_jfieldId == IntPtr.Zero)
					THREE_DS_CHECKING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THREE_DS_CHECKING", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THREE_DS_CHECKING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UNKNOWN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Unknown {
			get {
				if (UNKNOWN_jfieldId == IntPtr.Zero)
					UNKNOWN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOWN", "Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOWN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/PaymentStatus", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PaymentStatus); }
		}

		internal PaymentStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_fromString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PaymentStatus;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus FromString (string p0)
		{
			if (id_fromString_Ljava_lang_String_ == IntPtr.Zero)
				id_fromString_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "fromString", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PaymentStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PaymentStatus;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PaymentStatus;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PaymentStatus']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/acquiring/sdk/PaymentStatus;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/acquiring/sdk/PaymentStatus;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus));
			} finally {
			}
		}

	}
}
