using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardManager']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CardManager", DoNotGenerateAcw=true)]
	public partial class CardManager : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CardManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardManager); }
		}

		protected CardManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lru_tinkoff_acquiring_sdk_AcquiringSdk_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardManager']/constructor[@name='CardManager' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.AcquiringSdk']]"
		[Register (".ctor", "(Lru/tinkoff/acquiring/sdk/AcquiringSdk;)V", "")]
		public unsafe CardManager (global::RU.Tinkoff.Acquiring.Sdk.AcquiringSdk p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CardManager)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lru/tinkoff/acquiring/sdk/AcquiringSdk;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lru/tinkoff/acquiring/sdk/AcquiringSdk;)V", __args);
					return;
				}

				if (id_ctor_Lru_tinkoff_acquiring_sdk_AcquiringSdk_ == IntPtr.Zero)
					id_ctor_Lru_tinkoff_acquiring_sdk_AcquiringSdk_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/acquiring/sdk/AcquiringSdk;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_AcquiringSdk_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_AcquiringSdk_, __args);
			} finally {
			}
		}

		static Delegate cb_clear_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClear_Ljava_lang_String_Handler ()
		{
			if (cb_clear_Ljava_lang_String_ == null)
				cb_clear_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Clear_Ljava_lang_String_);
			return cb_clear_Ljava_lang_String_;
		}

		static void n_Clear_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardManager __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Clear (p0);
		}
#pragma warning restore 0169

		static IntPtr id_clear_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardManager']/method[@name='clear' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("clear", "(Ljava/lang/String;)V", "GetClear_Ljava_lang_String_Handler")]
		public virtual unsafe void Clear (string p0)
		{
			if (id_clear_Ljava_lang_String_ == IntPtr.Zero)
				id_clear_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clear", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCardById_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCardById_Ljava_lang_String_Handler ()
		{
			if (cb_getCardById_Ljava_lang_String_ == null)
				cb_getCardById_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCardById_Ljava_lang_String_);
			return cb_getCardById_Ljava_lang_String_;
		}

		static IntPtr n_GetCardById_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardManager __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCardById (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCardById_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardManager']/method[@name='getCardById' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCardById", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Card;", "GetGetCardById_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Card GetCardById (string p0)
		{
			if (id_getCardById_Ljava_lang_String_ == IntPtr.Zero)
				id_getCardById_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCardById", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Card;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.Card __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardById_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardById", "(Ljava/lang/String;)Lru/tinkoff/acquiring/sdk/Card;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getCards_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetCards_Ljava_lang_String_Handler ()
		{
			if (cb_getCards_Ljava_lang_String_ == null)
				cb_getCards_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCards_Ljava_lang_String_);
			return cb_getCards_Ljava_lang_String_;
		}

		static IntPtr n_GetCards_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardManager __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetCards (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getCards_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardManager']/method[@name='getCards' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getCards", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;", "GetGetCards_Ljava_lang_String_Handler")]
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Card[] GetCards (string p0)
		{
			if (id_getCards_Ljava_lang_String_ == IntPtr.Zero)
				id_getCards_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCards", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::RU.Tinkoff.Acquiring.Sdk.Card[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCards_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
				else
					__ret = (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCards", "(Ljava/lang/String;)[Lru/tinkoff/acquiring/sdk/Card;"), __args), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
