using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/ThreeDsData", DoNotGenerateAcw=true)]
	public partial class ThreeDsData : global::Java.Lang.Object {


		static IntPtr EMPTY_THREE_DS_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/field[@name='EMPTY_THREE_DS_DATA']"
		[Register ("EMPTY_THREE_DS_DATA")]
		public static global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData EmptyThreeDsData {
			get {
				if (EMPTY_THREE_DS_DATA_jfieldId == IntPtr.Zero)
					EMPTY_THREE_DS_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_THREE_DS_DATA", "Lru/tinkoff/acquiring/sdk/ThreeDsData;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_THREE_DS_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/ThreeDsData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ThreeDsData); }
		}

		protected ThreeDsData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/constructor[@name='ThreeDsData' and count(parameter)=6 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.Long'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe ThreeDsData (global::Java.Lang.Long p0, string p1, global::Java.Lang.Long p2, string p3, string p4, string p5)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (native_p3);
				__args [4] = new JValue (native_p4);
				__args [5] = new JValue (native_p5);
				if (((object) this).GetType () != typeof (ThreeDsData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Long;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p3);
				JNIEnv.DeleteLocalRef (native_p4);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		static Delegate cb_getAcsUrl;
#pragma warning disable 0169
		static Delegate GetGetAcsUrlHandler ()
		{
			if (cb_getAcsUrl == null)
				cb_getAcsUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAcsUrl);
			return cb_getAcsUrl;
		}

		static IntPtr n_GetAcsUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AcsUrl);
		}
#pragma warning restore 0169

		static IntPtr id_getAcsUrl;
		public virtual unsafe string AcsUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/method[@name='getAcsUrl' and count(parameter)=0]"
			[Register ("getAcsUrl", "()Ljava/lang/String;", "GetGetAcsUrlHandler")]
			get {
				if (id_getAcsUrl == IntPtr.Zero)
					id_getAcsUrl = JNIEnv.GetMethodID (class_ref, "getAcsUrl", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAcsUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAcsUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAmount;
#pragma warning disable 0169
		static Delegate GetGetAmountHandler ()
		{
			if (cb_getAmount == null)
				cb_getAmount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAmount);
			return cb_getAmount;
		}

		static IntPtr n_GetAmount (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Amount);
		}
#pragma warning restore 0169

		static IntPtr id_getAmount;
		public virtual unsafe global::Java.Lang.Long Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/Long;", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmount), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAmount", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isThreeDsNeed;
#pragma warning disable 0169
		static Delegate GetIsThreeDsNeedHandler ()
		{
			if (cb_isThreeDsNeed == null)
				cb_isThreeDsNeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsThreeDsNeed);
			return cb_isThreeDsNeed;
		}

		static bool n_IsThreeDsNeed (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsThreeDsNeed;
		}
#pragma warning restore 0169

		static IntPtr id_isThreeDsNeed;
		public virtual unsafe bool IsThreeDsNeed {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/method[@name='isThreeDsNeed' and count(parameter)=0]"
			[Register ("isThreeDsNeed", "()Z", "GetIsThreeDsNeedHandler")]
			get {
				if (id_isThreeDsNeed == IntPtr.Zero)
					id_isThreeDsNeed = JNIEnv.GetMethodID (class_ref, "isThreeDsNeed", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isThreeDsNeed);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isThreeDsNeed", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getMd;
#pragma warning disable 0169
		static Delegate GetGetMdHandler ()
		{
			if (cb_getMd == null)
				cb_getMd = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMd);
			return cb_getMd;
		}

		static IntPtr n_GetMd (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Md);
		}
#pragma warning restore 0169

		static IntPtr id_getMd;
		public virtual unsafe string Md {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/method[@name='getMd' and count(parameter)=0]"
			[Register ("getMd", "()Ljava/lang/String;", "GetGetMdHandler")]
			get {
				if (id_getMd == IntPtr.Zero)
					id_getMd = JNIEnv.GetMethodID (class_ref, "getMd", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMd), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMd", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrderId;
#pragma warning disable 0169
		static Delegate GetGetOrderIdHandler ()
		{
			if (cb_getOrderId == null)
				cb_getOrderId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrderId);
			return cb_getOrderId;
		}

		static IntPtr n_GetOrderId (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OrderId);
		}
#pragma warning restore 0169

		static IntPtr id_getOrderId;
		public virtual unsafe string OrderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/method[@name='getOrderId' and count(parameter)=0]"
			[Register ("getOrderId", "()Ljava/lang/String;", "GetGetOrderIdHandler")]
			get {
				if (id_getOrderId == IntPtr.Zero)
					id_getOrderId = JNIEnv.GetMethodID (class_ref, "getOrderId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrderId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOrderId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaReq;
#pragma warning disable 0169
		static Delegate GetGetPaReqHandler ()
		{
			if (cb_getPaReq == null)
				cb_getPaReq = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaReq);
			return cb_getPaReq;
		}

		static IntPtr n_GetPaReq (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PaReq);
		}
#pragma warning restore 0169

		static IntPtr id_getPaReq;
		public virtual unsafe string PaReq {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/method[@name='getPaReq' and count(parameter)=0]"
			[Register ("getPaReq", "()Ljava/lang/String;", "GetGetPaReqHandler")]
			get {
				if (id_getPaReq == IntPtr.Zero)
					id_getPaReq = JNIEnv.GetMethodID (class_ref, "getPaReq", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaReq), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaReq", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaymentId;
#pragma warning disable 0169
		static Delegate GetGetPaymentIdHandler ()
		{
			if (cb_getPaymentId == null)
				cb_getPaymentId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaymentId);
			return cb_getPaymentId;
		}

		static IntPtr n_GetPaymentId (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaymentId);
		}
#pragma warning restore 0169

		static IntPtr id_getPaymentId;
		public virtual unsafe global::Java.Lang.Long PaymentId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='ThreeDsData']/method[@name='getPaymentId' and count(parameter)=0]"
			[Register ("getPaymentId", "()Ljava/lang/Long;", "GetGetPaymentIdHandler")]
			get {
				if (id_getPaymentId == IntPtr.Zero)
					id_getPaymentId = JNIEnv.GetMethodID (class_ref, "getPaymentId", "()Ljava/lang/Long;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaymentId), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPaymentId", "()Ljava/lang/Long;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
