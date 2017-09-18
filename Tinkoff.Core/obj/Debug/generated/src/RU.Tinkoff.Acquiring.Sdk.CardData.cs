using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CardData", DoNotGenerateAcw=true)]
	public partial class CardData : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CardData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardData); }
		}

		protected CardData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/constructor[@name='CardData' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CardData (string p0, string p1, string p2)
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
				if (((object) this).GetType () != typeof (CardData)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/constructor[@name='CardData' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe CardData (string p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (CardData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getExpiryDate;
#pragma warning disable 0169
		static Delegate GetGetExpiryDateHandler ()
		{
			if (cb_getExpiryDate == null)
				cb_getExpiryDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpiryDate);
			return cb_getExpiryDate;
		}

		static IntPtr n_GetExpiryDate (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpiryDate);
		}
#pragma warning restore 0169

		static Delegate cb_setExpiryDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpiryDate_Ljava_lang_String_Handler ()
		{
			if (cb_setExpiryDate_Ljava_lang_String_ == null)
				cb_setExpiryDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpiryDate_Ljava_lang_String_);
			return cb_setExpiryDate_Ljava_lang_String_;
		}

		static void n_SetExpiryDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpiryDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpiryDate;
		static IntPtr id_setExpiryDate_Ljava_lang_String_;
		public virtual unsafe string ExpiryDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/method[@name='getExpiryDate' and count(parameter)=0]"
			[Register ("getExpiryDate", "()Ljava/lang/String;", "GetGetExpiryDateHandler")]
			get {
				if (id_getExpiryDate == IntPtr.Zero)
					id_getExpiryDate = JNIEnv.GetMethodID (class_ref, "getExpiryDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpiryDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpiryDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/method[@name='setExpiryDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExpiryDate", "(Ljava/lang/String;)V", "GetSetExpiryDate_Ljava_lang_String_Handler")]
			set {
				if (id_setExpiryDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setExpiryDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExpiryDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExpiryDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpiryDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getPan;
#pragma warning disable 0169
		static Delegate GetGetPanHandler ()
		{
			if (cb_getPan == null)
				cb_getPan = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPan);
			return cb_getPan;
		}

		static IntPtr n_GetPan (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Pan);
		}
#pragma warning restore 0169

		static Delegate cb_setPan_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPan_Ljava_lang_String_Handler ()
		{
			if (cb_setPan_Ljava_lang_String_ == null)
				cb_setPan_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPan_Ljava_lang_String_);
			return cb_setPan_Ljava_lang_String_;
		}

		static void n_SetPan_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Pan = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPan;
		static IntPtr id_setPan_Ljava_lang_String_;
		public virtual unsafe string Pan {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/method[@name='getPan' and count(parameter)=0]"
			[Register ("getPan", "()Ljava/lang/String;", "GetGetPanHandler")]
			get {
				if (id_getPan == IntPtr.Zero)
					id_getPan = JNIEnv.GetMethodID (class_ref, "getPan", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPan), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPan", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/method[@name='setPan' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setPan", "(Ljava/lang/String;)V", "GetSetPan_Ljava_lang_String_Handler")]
			set {
				if (id_setPan_Ljava_lang_String_ == IntPtr.Zero)
					id_setPan_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setPan", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPan_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPan", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSecurityCode;
#pragma warning disable 0169
		static Delegate GetGetSecurityCodeHandler ()
		{
			if (cb_getSecurityCode == null)
				cb_getSecurityCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityCode);
			return cb_getSecurityCode;
		}

		static IntPtr n_GetSecurityCode (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecurityCode);
		}
#pragma warning restore 0169

		static Delegate cb_setSecurityCode_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecurityCode_Ljava_lang_String_Handler ()
		{
			if (cb_setSecurityCode_Ljava_lang_String_ == null)
				cb_setSecurityCode_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecurityCode_Ljava_lang_String_);
			return cb_setSecurityCode_Ljava_lang_String_;
		}

		static void n_SetSecurityCode_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SecurityCode = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getSecurityCode;
		static IntPtr id_setSecurityCode_Ljava_lang_String_;
		public virtual unsafe string SecurityCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/method[@name='getSecurityCode' and count(parameter)=0]"
			[Register ("getSecurityCode", "()Ljava/lang/String;", "GetGetSecurityCodeHandler")]
			get {
				if (id_getSecurityCode == IntPtr.Zero)
					id_getSecurityCode = JNIEnv.GetMethodID (class_ref, "getSecurityCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSecurityCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSecurityCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/method[@name='setSecurityCode' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecurityCode", "(Ljava/lang/String;)V", "GetSetSecurityCode_Ljava_lang_String_Handler")]
			set {
				if (id_setSecurityCode_Ljava_lang_String_ == IntPtr.Zero)
					id_setSecurityCode_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setSecurityCode", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecurityCode_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecurityCode", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_encode_Ljava_security_PublicKey_;
#pragma warning disable 0169
		static Delegate GetEncode_Ljava_security_PublicKey_Handler ()
		{
			if (cb_encode_Ljava_security_PublicKey_ == null)
				cb_encode_Ljava_security_PublicKey_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Encode_Ljava_security_PublicKey_);
			return cb_encode_Ljava_security_PublicKey_;
		}

		static IntPtr n_Encode_Ljava_security_PublicKey_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Security.IPublicKey p0 = (global::Java.Security.IPublicKey)global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.Encode (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_encode_Ljava_security_PublicKey_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardData']/method[@name='encode' and count(parameter)=1 and parameter[1][@type='java.security.PublicKey']]"
		[Register ("encode", "(Ljava/security/PublicKey;)Ljava/lang/String;", "GetEncode_Ljava_security_PublicKey_Handler")]
		public virtual unsafe string Encode (global::Java.Security.IPublicKey p0)
		{
			if (id_encode_Ljava_security_PublicKey_ == IntPtr.Zero)
				id_encode_Ljava_security_PublicKey_ = JNIEnv.GetMethodID (class_ref, "encode", "(Ljava/security/PublicKey;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_encode_Ljava_security_PublicKey_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "encode", "(Ljava/security/PublicKey;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
