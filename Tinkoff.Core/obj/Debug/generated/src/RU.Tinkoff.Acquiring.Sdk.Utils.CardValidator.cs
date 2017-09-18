using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/utils/CardValidator", DoNotGenerateAcw=true)]
	public partial class CardValidator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator.RegexpValidator']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/utils/CardValidator$RegexpValidator", DoNotGenerateAcw=true)]
		public partial class RegexpValidator : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/utils/CardValidator$RegexpValidator", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RegexpValidator); }
			}

			protected RegexpValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator.RegexpValidator']/constructor[@name='CardValidator.RegexpValidator' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe RegexpValidator ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (RegexpValidator)) {
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

			static IntPtr id_validate_Ljava_lang_CharSequence_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator.RegexpValidator']/method[@name='validate' and count(parameter)=2 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.String']]"
			[Register ("validate", "(Ljava/lang/CharSequence;Ljava/lang/String;)Z", "")]
			public static unsafe bool Validate (global::Java.Lang.ICharSequence p0, string p1)
			{
				if (id_validate_Ljava_lang_CharSequence_Ljava_lang_String_ == IntPtr.Zero)
					id_validate_Ljava_lang_CharSequence_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validate", "(Ljava/lang/CharSequence;Ljava/lang/String;)Z");
				IntPtr native_p0 = CharSequence.ToLocalJniHandle (p0);
				IntPtr native_p1 = JNIEnv.NewString (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validate_Ljava_lang_CharSequence_Ljava_lang_String_, __args);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			public static bool Validate (string p0, string p1)
			{
				global::Java.Lang.String jls_p0 = p0 == null ? null : new global::Java.Lang.String (p0);
				bool __result = Validate (jls_p0, p1);
				if (jls_p0 != null) jls_p0.Dispose ();
				return __result;
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/utils/CardValidator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardValidator); }
		}

		protected CardValidator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator']/constructor[@name='CardValidator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardValidator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CardValidator)) {
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

		static IntPtr id_validateExpirationDate_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator']/method[@name='validateExpirationDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateExpirationDate", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateExpirationDate (string p0)
		{
			if (id_validateExpirationDate_Ljava_lang_String_ == IntPtr.Zero)
				id_validateExpirationDate_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validateExpirationDate", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validateExpirationDate_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_validateNumber_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator']/method[@name='validateNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateNumber", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateNumber (string p0)
		{
			if (id_validateNumber_Ljava_lang_String_ == IntPtr.Zero)
				id_validateNumber_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validateNumber", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validateNumber_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_validateSecurityCode_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.utils']/class[@name='CardValidator']/method[@name='validateSecurityCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("validateSecurityCode", "(Ljava/lang/String;)Z", "")]
		public static unsafe bool ValidateSecurityCode (string p0)
		{
			if (id_validateSecurityCode_Ljava_lang_String_ == IntPtr.Zero)
				id_validateSecurityCode_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "validateSecurityCode", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_validateSecurityCode_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
