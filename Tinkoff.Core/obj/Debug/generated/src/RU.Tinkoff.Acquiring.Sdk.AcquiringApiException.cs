using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApiException']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/AcquiringApiException", DoNotGenerateAcw=true)]
	public partial class AcquiringApiException : global::Java.Lang.Exception {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/AcquiringApiException", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AcquiringApiException); }
		}

		protected AcquiringApiException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApiException']/constructor[@name='AcquiringApiException' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.responses.AcquiringResponse']]"
		[Register (".ctor", "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;)V", "")]
		public unsafe AcquiringApiException (global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (AcquiringApiException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;)V", __args);
					return;
				}

				if (id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_ == IntPtr.Zero)
					id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApiException']/constructor[@name='AcquiringApiException' and count(parameter)=2 and parameter[1][@type='ru.tinkoff.acquiring.sdk.responses.AcquiringResponse'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/String;)V", "")]
		public unsafe AcquiringApiException (global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse p0, string p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				if (((object) this).GetType () != typeof (AcquiringApiException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApiException']/constructor[@name='AcquiringApiException' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "")]
		public unsafe AcquiringApiException (string p0, global::Java.Lang.Throwable p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (AcquiringApiException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_Throwable_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApiException']/constructor[@name='AcquiringApiException' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='ru.tinkoff.acquiring.sdk.responses.AcquiringResponse'] and parameter[3][@type='java.lang.Throwable']]"
		[Register (".ctor", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/Throwable;)V", "")]
		public unsafe AcquiringApiException (string p0, global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse p1, global::Java.Lang.Throwable p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (AcquiringApiException)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/Throwable;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/Throwable;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_Throwable_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_Throwable_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;Ljava/lang/Throwable;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_Throwable_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_String_Lru_tinkoff_acquiring_sdk_responses_AcquiringResponse_Ljava_lang_Throwable_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getResponse;
#pragma warning disable 0169
		static Delegate GetGetResponseHandler ()
		{
			if (cb_getResponse == null)
				cb_getResponse = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResponse);
			return cb_getResponse;
		}

		static IntPtr n_GetResponse (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.AcquiringApiException __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.AcquiringApiException> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Response);
		}
#pragma warning restore 0169

		static IntPtr id_getResponse;
		public virtual unsafe global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse Response {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApiException']/method[@name='getResponse' and count(parameter)=0]"
			[Register ("getResponse", "()Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;", "GetGetResponseHandler")]
			get {
				if (id_getResponse == IntPtr.Zero)
					id_getResponse = JNIEnv.GetMethodID (class_ref, "getResponse", "()Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse> (JNIEnv.CallObjectMethod (((global::Java.Lang.Throwable) this).Handle, id_getResponse), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Throwable) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getResponse", "()Lru/tinkoff/acquiring/sdk/responses/AcquiringResponse;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
