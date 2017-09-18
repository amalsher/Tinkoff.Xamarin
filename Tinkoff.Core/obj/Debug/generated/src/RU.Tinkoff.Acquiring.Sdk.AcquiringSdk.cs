using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/AcquiringSdk", DoNotGenerateAcw=true)]
	public partial class AcquiringSdk : global::RU.Tinkoff.Acquiring.Sdk.Journal {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/AcquiringSdk", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AcquiringSdk); }
		}

		protected AcquiringSdk (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/constructor[@name='AcquiringSdk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='ru.tinkoff.acquiring.sdk.KeyCreator']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V", "")]
		public unsafe AcquiringSdk (string p0, string p1, global::RU.Tinkoff.Acquiring.Sdk.IKeyCreator p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AcquiringSdk)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Lru/tinkoff/acquiring/sdk/KeyCreator;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_KeyCreator_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/constructor[@name='AcquiringSdk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe AcquiringSdk (string p0, string p1, string p2)
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
				if (((object) this).GetType () != typeof (AcquiringSdk)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/constructor[@name='AcquiringSdk' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.security.PublicKey']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V", "")]
		public unsafe AcquiringSdk (string p0, string p1, global::Java.Security.IPublicKey p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AcquiringSdk)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/security/PublicKey;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_security_PublicKey_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getPassword;
#pragma warning disable 0169
		static Delegate GetGetPasswordHandler ()
		{
			if (cb_getPassword == null)
				cb_getPassword = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPassword);
			return cb_getPassword;
		}

		static IntPtr n_GetPassword (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Password);
		}
#pragma warning restore 0169

		static IntPtr id_getPassword;
		public virtual unsafe string Password {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getPassword' and count(parameter)=0]"
			[Register ("getPassword", "()Ljava/lang/String;", "GetGetPasswordHandler")]
			get {
				if (id_getPassword == IntPtr.Zero)
					id_getPassword = JNIEnv.GetMethodID (class_ref, "getPassword", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPassword), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPassword", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPublicKey;
#pragma warning disable 0169
		static Delegate GetGetPublicKeyHandler ()
		{
			if (cb_getPublicKey == null)
				cb_getPublicKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPublicKey);
			return cb_getPublicKey;
		}

		static IntPtr n_GetPublicKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PublicKey);
		}
#pragma warning restore 0169

		static IntPtr id_getPublicKey;
		public virtual unsafe global::Java.Security.IPublicKey PublicKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getPublicKey' and count(parameter)=0]"
			[Register ("getPublicKey", "()Ljava/security/PublicKey;", "GetGetPublicKeyHandler")]
			get {
				if (id_getPublicKey == IntPtr.Zero)
					id_getPublicKey = JNIEnv.GetMethodID (class_ref, "getPublicKey", "()Ljava/security/PublicKey;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPublicKey), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPublicKey", "()Ljava/security/PublicKey;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTerminalKey;
#pragma warning disable 0169
		static Delegate GetGetTerminalKeyHandler ()
		{
			if (cb_getTerminalKey == null)
				cb_getTerminalKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminalKey);
			return cb_getTerminalKey;
		}

		static IntPtr n_GetTerminalKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TerminalKey);
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalKey;
		public virtual unsafe string TerminalKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getTerminalKey' and count(parameter)=0]"
			[Register ("getTerminalKey", "()Ljava/lang/String;", "GetGetTerminalKeyHandler")]
			get {
				if (id_getTerminalKey == IntPtr.Zero)
					id_getTerminalKey = JNIEnv.GetMethodID (class_ref, "getTerminalKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTerminalKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminalKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static IntPtr id_getUrl;
		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				if (id_getUrl == IntPtr.Zero)
					id_getUrl = JNIEnv.GetMethodID (class_ref, "getUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_charge_JJ;
#pragma warning disable 0169
		static Delegate GetCharge_JJHandler ()
		{
			if (cb_charge_JJ == null)
				cb_charge_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, IntPtr>) n_Charge_JJ);
			return cb_charge_JJ;
		}

		static IntPtr n_Charge_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Charge (p0, p1));
		}
#pragma warning restore 0169

		static IntPtr id_charge_JJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='charge' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("charge", "(JJ)Lru/tinkoff/acquiring/sdk/PaymentInfo;", "GetCharge_JJHandler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentInfo Charge (long p0, long p1)
		{
			if (id_charge_JJ == IntPtr.Zero)
				id_charge_JJ = JNIEnv.GetMethodID (class_ref, "charge", "(JJ)Lru/tinkoff/acquiring/sdk/PaymentInfo;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_charge_JJ, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentInfo> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "charge", "(JJ)Lru/tinkoff/acquiring/sdk/PaymentInfo;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetFinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Handler ()
		{
			if (cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ == null)
				cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr, IntPtr, IntPtr>) n_FinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_);
			return cb_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_;
		}

		static IntPtr n_FinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, long p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.CardData p1 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FinishAuthorize (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='finishAuthorize' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='ru.tinkoff.acquiring.sdk.CardData'] and parameter[3][@type='java.lang.String']]"
		[Register ("finishAuthorize", "(JLru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/ThreeDsData;", "GetFinishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData FinishAuthorize (long p0, global::RU.Tinkoff.Acquiring.Sdk.CardData p1, string p2)
		{
			if (id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ == IntPtr.Zero)
				id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "finishAuthorize", "(JLru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/ThreeDsData;");
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (native_p2);

				global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finishAuthorize_JLru_tinkoff_acquiring_sdk_CardData_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "finishAuthorize", "(JLru/tinkoff/acquiring/sdk/CardData;Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/ThreeDsData;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_getCardList_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCardList_Ljava_lang_String_Handler ()
		{
			if (cb_getCardList_Ljava_lang_String_ == null)
				cb_getCardList_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCardList_Ljava_lang_String_);
			return cb_getCardList_Ljava_lang_String_;
		}

		static IntPtr n_GetCardList_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetCardList (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCardList_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getCardList' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCardList", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;", "GetGetCardList_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Card[] GetCardList (string p0)
		{
			if (id_getCardList_Ljava_lang_String_ == IntPtr.Zero)
				id_getCardList_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCardList", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.Card[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardList_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
				else
					__ret = (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardList", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getState_J;
#pragma warning disable 0169
		static Delegate GetGetState_JHandler ()
		{
			if (cb_getState_J == null)
				cb_getState_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_GetState_J);
			return cb_getState_J;
		}

		static IntPtr n_GetState_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetState (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getState_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='getState' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("getState", "(J)Lru/tinkoff/acquiring/sdk/PaymentStatus;", "GetGetState_JHandler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus GetState (long p0)
		{
			if (id_getState_J == IntPtr.Zero)
				id_getState_J = JNIEnv.GetMethodID (class_ref, "getState", "(J)Lru/tinkoff/acquiring/sdk/PaymentStatus;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getState_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getState", "(J)Lru/tinkoff/acquiring/sdk/PaymentStatus;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetInit_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler ()
		{
			if (cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == null)
				cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z);
			return cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		}

		static IntPtr n_Init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Money p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Init (p0, p1, p2, p3, p4, p5));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='init' and count(parameter)=6 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Money'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean']]"
		[Register ("init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/Long;", "GetInit_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Java.Lang.Long Init (global::RU.Tinkoff.Acquiring.Sdk.Money p0, string p1, string p2, string p3, string p4, bool p5)
		{
			if (id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z == IntPtr.Zero)
				id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z = JNIEnv.GetMethodID (class_ref, "init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/Long;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);

				global::Java.Lang.Long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)Ljava/lang/Long;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_;
#pragma warning disable 0169
		static Delegate GetInit_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Handler ()
		{
			if (cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_ == null)
				cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr>) n_Init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_);
			return cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_;
		}

		static IntPtr n_Init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5, IntPtr native_p6)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Money p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Language p6 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Language> (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Init (p0, p1, p2, p3, p4, p5, p6));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='init' and count(parameter)=7 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Money'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='ru.tinkoff.acquiring.sdk.Language']]"
		[Register ("init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLru/tinkoff/acquiring/sdk/Language;)Ljava/lang/Long;", "GetInit_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Handler")]
		public virtual unsafe global::Java.Lang.Long Init (global::RU.Tinkoff.Acquiring.Sdk.Money p0, string p1, string p2, string p3, string p4, bool p5, global::RU.Tinkoff.Acquiring.Sdk.Language p6)
		{
			if (id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_ == IntPtr.Zero)
				id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_ = JNIEnv.GetMethodID (class_ref, "init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLru/tinkoff/acquiring/sdk/Language;)Ljava/lang/Long;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [7];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);

				global::Java.Lang.Long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLru/tinkoff/acquiring/sdk/Language;)Ljava/lang/Long;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_;
#pragma warning disable 0169
		static Delegate GetInit_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_Handler ()
		{
			if (cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_ == null)
				cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, IntPtr, IntPtr>) n_Init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_);
			return cb_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_;
		}

		static IntPtr n_Init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, bool p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Money p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Language p6 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Language> (native_p6, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.PayType p7 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PayType> (native_p7, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Init (p0, p1, p2, p3, p4, p5, p6, p7));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='init' and count(parameter)=8 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Money'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='boolean'] and parameter[7][@type='ru.tinkoff.acquiring.sdk.Language'] and parameter[8][@type='ru.tinkoff.acquiring.sdk.PayType']]"
		[Register ("init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLru/tinkoff/acquiring/sdk/Language;Lru/tinkoff/acquiring/sdk/PayType;)Ljava/lang/Long;", "GetInit_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_Handler")]
		public virtual unsafe global::Java.Lang.Long Init (global::RU.Tinkoff.Acquiring.Sdk.Money p0, string p1, string p2, string p3, string p4, bool p5, global::RU.Tinkoff.Acquiring.Sdk.Language p6, global::RU.Tinkoff.Acquiring.Sdk.PayType p7)
		{
			if (id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_ == IntPtr.Zero)
				id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_ = JNIEnv.GetMethodID (class_ref, "init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLru/tinkoff/acquiring/sdk/Language;Lru/tinkoff/acquiring/sdk/PayType;)Ljava/lang/Long;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JValue* __args = stackalloc JValue [8];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (p5);
				__args [6] = new JValue (p6);
				__args [7] = new JValue (p7);

				global::Java.Lang.Long __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_init_Lru_tinkoff_acquiring_sdk_Money_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ZLru_tinkoff_acquiring_sdk_Language_Lru_tinkoff_acquiring_sdk_PayType_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "(Lru/tinkoff/acquiring/sdk/Money;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ZLru/tinkoff/acquiring/sdk/Language;Lru/tinkoff/acquiring/sdk/PayType;)Ljava/lang/Long;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		static Delegate cb_removeCard_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetRemoveCard_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_removeCard_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_removeCard_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_RemoveCard_Ljava_lang_String_Ljava_lang_String_);
			return cb_removeCard_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_RemoveCard_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveCard (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_removeCard_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringSdk']/method[@name='removeCard' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("removeCard", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetRemoveCard_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool RemoveCard (string p0, string p1)
		{
			if (id_removeCard_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_removeCard_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "removeCard", "(Ljava/lang/String;Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeCard_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeCard", "(Ljava/lang/String;Ljava/lang/String;)Z"), __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}
}
