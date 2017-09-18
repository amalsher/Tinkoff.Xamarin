using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Card", DoNotGenerateAcw=true)]
	public partial class Card : global::Java.Lang.Object, global::Java.IO.ISerializable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Card", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Card); }
		}

		protected Card (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/constructor[@name='Card' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Card ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Card)) {
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

		static Delegate cb_getCardId;
#pragma warning disable 0169
		static Delegate GetGetCardIdHandler ()
		{
			if (cb_getCardId == null)
				cb_getCardId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardId);
			return cb_getCardId;
		}

		static IntPtr n_GetCardId (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardId);
		}
#pragma warning restore 0169

		static Delegate cb_setCardId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardId_Ljava_lang_String_Handler ()
		{
			if (cb_setCardId_Ljava_lang_String_ == null)
				cb_setCardId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCardId_Ljava_lang_String_);
			return cb_setCardId_Ljava_lang_String_;
		}

		static void n_SetCardId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCardId;
		static IntPtr id_setCardId_Ljava_lang_String_;
		public virtual unsafe string CardId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='getCardId' and count(parameter)=0]"
			[Register ("getCardId", "()Ljava/lang/String;", "GetGetCardIdHandler")]
			get {
				if (id_getCardId == IntPtr.Zero)
					id_getCardId = JNIEnv.GetMethodID (class_ref, "getCardId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='setCardId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardId", "(Ljava/lang/String;)V", "GetSetCardId_Ljava_lang_String_Handler")]
			set {
				if (id_setCardId_Ljava_lang_String_ == IntPtr.Zero)
					id_setCardId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardId", "(Ljava/lang/String;)V"), __args);
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
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Pan = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getPan;
		static IntPtr id_setPan_Ljava_lang_String_;
		public virtual unsafe string Pan {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='getPan' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='setPan' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getRebillId;
#pragma warning disable 0169
		static Delegate GetGetRebillIdHandler ()
		{
			if (cb_getRebillId == null)
				cb_getRebillId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRebillId);
			return cb_getRebillId;
		}

		static IntPtr n_GetRebillId (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RebillId);
		}
#pragma warning restore 0169

		static Delegate cb_setRebillId_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRebillId_Ljava_lang_String_Handler ()
		{
			if (cb_setRebillId_Ljava_lang_String_ == null)
				cb_setRebillId_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRebillId_Ljava_lang_String_);
			return cb_setRebillId_Ljava_lang_String_;
		}

		static void n_SetRebillId_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RebillId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getRebillId;
		static IntPtr id_setRebillId_Ljava_lang_String_;
		public virtual unsafe string RebillId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='getRebillId' and count(parameter)=0]"
			[Register ("getRebillId", "()Ljava/lang/String;", "GetGetRebillIdHandler")]
			get {
				if (id_getRebillId == IntPtr.Zero)
					id_getRebillId = JNIEnv.GetMethodID (class_ref, "getRebillId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRebillId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRebillId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='setRebillId' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRebillId", "(Ljava/lang/String;)V", "GetSetRebillId_Ljava_lang_String_Handler")]
			set {
				if (id_setRebillId_Ljava_lang_String_ == IntPtr.Zero)
					id_setRebillId_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setRebillId", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRebillId_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRebillId", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getStatus;
#pragma warning disable 0169
		static Delegate GetGetStatusHandler ()
		{
			if (cb_getStatus == null)
				cb_getStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStatus);
			return cb_getStatus;
		}

		static IntPtr n_GetStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Status);
		}
#pragma warning restore 0169

		static Delegate cb_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_;
#pragma warning disable 0169
		static Delegate GetSetStatus_Lru_tinkoff_acquiring_sdk_CardStatus_Handler ()
		{
			if (cb_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_ == null)
				cb_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStatus_Lru_tinkoff_acquiring_sdk_CardStatus_);
			return cb_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_;
		}

		static void n_SetStatus_Lru_tinkoff_acquiring_sdk_CardStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Card __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Card> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.CardStatus p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Status = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getStatus;
		static IntPtr id_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_;
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.CardStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lru/tinkoff/acquiring/sdk/CardStatus;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lru/tinkoff/acquiring/sdk/CardStatus;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardStatus> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getStatus", "()Lru/tinkoff/acquiring/sdk/CardStatus;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Card']/method[@name='setStatus' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.CardStatus']]"
			[Register ("setStatus", "(Lru/tinkoff/acquiring/sdk/CardStatus;)V", "GetSetStatus_Lru_tinkoff_acquiring_sdk_CardStatus_Handler")]
			set {
				if (id_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_ == IntPtr.Zero)
					id_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_ = JNIEnv.GetMethodID (class_ref, "setStatus", "(Lru/tinkoff/acquiring/sdk/CardStatus;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setStatus_Lru_tinkoff_acquiring_sdk_CardStatus_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setStatus", "(Lru/tinkoff/acquiring/sdk/CardStatus;)V"), __args);
				} finally {
				}
			}
		}

	}
}
