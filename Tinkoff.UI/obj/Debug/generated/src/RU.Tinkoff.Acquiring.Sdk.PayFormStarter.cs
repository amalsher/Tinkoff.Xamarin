using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormStarter']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/PayFormStarter", DoNotGenerateAcw=true)]
	public partial class PayFormStarter : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/PayFormStarter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PayFormStarter); }
		}

		protected PayFormStarter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormStarter']/constructor[@name='PayFormStarter' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe PayFormStarter (string p0, string p1, string p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				if (((object) this).GetType () != typeof (PayFormStarter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_prepare_Ljava_lang_String_Ljava_lang_Long_Z;
#pragma warning disable 0169
		static Delegate GetPrepare_Ljava_lang_String_Ljava_lang_Long_ZHandler ()
		{
			if (cb_prepare_Ljava_lang_String_Ljava_lang_Long_Z == null)
				cb_prepare_Ljava_lang_String_Ljava_lang_Long_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Prepare_Ljava_lang_String_Ljava_lang_Long_Z);
			return cb_prepare_Ljava_lang_String_Ljava_lang_Long_Z;
		}

		static IntPtr n_Prepare_Ljava_lang_String_Ljava_lang_Long_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool p2)
		{
			global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Prepare (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepare_Ljava_lang_String_Ljava_lang_Long_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormStarter']/method[@name='prepare' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='boolean']]"
		[Register ("prepare", "(Ljava/lang/String;Ljava/lang/Long;Z)Lru/tinkoff/acquiring/sdk/PayFormStarter;", "GetPrepare_Ljava_lang_String_Ljava_lang_Long_ZHandler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter Prepare (string p0, global::Java.Lang.Long p1, bool p2)
		{
			if (id_prepare_Ljava_lang_String_Ljava_lang_Long_Z == IntPtr.Zero)
				id_prepare_Ljava_lang_String_Ljava_lang_Long_Z = JNIEnv.GetMethodID (class_ref, "prepare", "(Ljava/lang/String;Ljava/lang/Long;Z)Lru/tinkoff/acquiring/sdk/PayFormStarter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Ljava_lang_String_Ljava_lang_Long_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "(Ljava/lang/String;Ljava/lang/Long;Z)Lru/tinkoff/acquiring/sdk/PayFormStarter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ;
#pragma warning disable 0169
		static Delegate GetPrepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZHandler ()
		{
			if (cb_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ == null)
				cb_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, bool, IntPtr>) n_Prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ);
			return cb_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ;
		}

		static IntPtr n_Prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, IntPtr native_p5, bool p6, bool p7)
		{
			global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Money p1 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Prepare (p0, p1, p2, p3, p4, p5, p6, p7));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormStarter']/method[@name='prepare' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='ru.tinkoff.acquiring.sdk.Money'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='boolean'] and parameter[8][@type='boolean']]"
		[Register ("prepare", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Lru/tinkoff/acquiring/sdk/PayFormStarter;", "GetPrepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZHandler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter Prepare (string p0, global::RU.Tinkoff.Acquiring.Sdk.Money p1, string p2, string p3, string p4, string p5, bool p6, bool p7)
		{
			if (id_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ == IntPtr.Zero)
				id_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ = JNIEnv.GetMethodID (class_ref, "prepare", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Lru/tinkoff/acquiring/sdk/PayFormStarter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "prepare", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZZ)Lru/tinkoff/acquiring/sdk/PayFormStarter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_setCustomerKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCustomerKey_Ljava_lang_String_Handler ()
		{
			if (cb_setCustomerKey_Ljava_lang_String_ == null)
				cb_setCustomerKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCustomerKey_Ljava_lang_String_);
			return cb_setCustomerKey_Ljava_lang_String_;
		}

		static IntPtr n_SetCustomerKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCustomerKey (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setCustomerKey_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormStarter']/method[@name='setCustomerKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCustomerKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PayFormStarter;", "GetSetCustomerKey_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter SetCustomerKey (string p0)
		{
			if (id_setCustomerKey_Ljava_lang_String_ == IntPtr.Zero)
				id_setCustomerKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCustomerKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PayFormStarter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setCustomerKey_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomerKey", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/PayFormStarter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startActivityForResult_Landroid_app_Activity_I;
#pragma warning disable 0169
		static Delegate GetStartActivityForResult_Landroid_app_Activity_IHandler ()
		{
			if (cb_startActivityForResult_Landroid_app_Activity_I == null)
				cb_startActivityForResult_Landroid_app_Activity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_StartActivityForResult_Landroid_app_Activity_I);
			return cb_startActivityForResult_Landroid_app_Activity_I;
		}

		static void n_StartActivityForResult_Landroid_app_Activity_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayFormStarter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityForResult (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_startActivityForResult_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='PayFormStarter']/method[@name='startActivityForResult' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("startActivityForResult", "(Landroid/app/Activity;I)V", "GetStartActivityForResult_Landroid_app_Activity_IHandler")]
		public virtual unsafe void StartActivityForResult (global::Android.App.Activity p0, int p1)
		{
			if (id_startActivityForResult_Landroid_app_Activity_I == IntPtr.Zero)
				id_startActivityForResult_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "startActivityForResult", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startActivityForResult_Landroid_app_Activity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startActivityForResult", "(Landroid/app/Activity;I)V"), __args);
			} finally {
			}
		}

	}
}
