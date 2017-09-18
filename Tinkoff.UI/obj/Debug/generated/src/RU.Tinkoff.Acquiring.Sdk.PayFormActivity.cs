using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/PayFormActivity", DoNotGenerateAcw=true)]
	public sealed partial class PayFormActivity : global::Android.Support.V7.App.AppCompatActivity {


		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']/field[@name='API_ERROR_NO_CUSTOMER']"
		[Register ("API_ERROR_NO_CUSTOMER")]
		public const string ApiErrorNoCustomer = (string) "7";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']/field[@name='RESULT_ERROR']"
		[Register ("RESULT_ERROR")]
		public const int ResultError = (int) 500;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/PayFormActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayFormActivity); }
		}

		internal PayFormActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']/constructor[@name='PayFormActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PayFormActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PayFormActivity)) {
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

		static IntPtr id_isCardChooseEnable;
		public unsafe bool IsCardChooseEnable {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']/method[@name='isCardChooseEnable' and count(parameter)=0]"
			[Register ("isCardChooseEnable", "()Z", "GetIsCardChooseEnableHandler")]
			get {
				if (id_isCardChooseEnable == IntPtr.Zero)
					id_isCardChooseEnable = JNIEnv.GetMethodID (class_ref, "isCardChooseEnable", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCardChooseEnable);
				} finally {
				}
			}
		}

		static IntPtr id_dispatchResult_ILandroid_content_Intent_Lru_tinkoff_acquiring_sdk_OnPaymentListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']/method[@name='dispatchResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='ru.tinkoff.acquiring.sdk.OnPaymentListener']]"
		[Register ("dispatchResult", "(ILandroid/content/Intent;Lru/tinkoff/acquiring/sdk/OnPaymentListener;)V", "")]
		public static unsafe void DispatchResult (int p0, global::Android.Content.Intent p1, global::RU.Tinkoff.Acquiring.Sdk.IOnPaymentListener p2)
		{
			if (id_dispatchResult_ILandroid_content_Intent_Lru_tinkoff_acquiring_sdk_OnPaymentListener_ == IntPtr.Zero)
				id_dispatchResult_ILandroid_content_Intent_Lru_tinkoff_acquiring_sdk_OnPaymentListener_ = JNIEnv.GetStaticMethodID (class_ref, "dispatchResult", "(ILandroid/content/Intent;Lru/tinkoff/acquiring/sdk/OnPaymentListener;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_dispatchResult_ILandroid_content_Intent_Lru_tinkoff_acquiring_sdk_OnPaymentListener_, __args);
			} finally {
			}
		}

		static IntPtr id_init_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']/method[@name='init' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("init", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PayFormStarter;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter Init (string p0, string p1, string p2)
		{
			if (id_init_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_init_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "init", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PayFormStarter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (JNIEnv.CallStaticObjectMethod  (class_ref, id_init_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_onNoNetwork;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormActivity']/method[@name='onNoNetwork' and count(parameter)=0]"
		[Register ("onNoNetwork", "()V", "")]
		public unsafe void OnNoNetwork ()
		{
			if (id_onNoNetwork == IntPtr.Zero)
				id_onNoNetwork = JNIEnv.GetMethodID (class_ref, "onNoNetwork", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNoNetwork);
			} finally {
			}
		}

	}
}
