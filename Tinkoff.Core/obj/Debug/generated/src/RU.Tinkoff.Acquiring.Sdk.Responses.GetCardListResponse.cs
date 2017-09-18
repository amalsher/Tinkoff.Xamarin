using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Responses {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetCardListResponse']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/responses/GetCardListResponse", DoNotGenerateAcw=true)]
	public sealed partial class GetCardListResponse : global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/responses/GetCardListResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GetCardListResponse); }
		}

		internal GetCardListResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetCardListResponse']/constructor[@name='GetCardListResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GetCardListResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GetCardListResponse)) {
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

		static IntPtr id_ctor_arrayLru_tinkoff_acquiring_sdk_Card_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetCardListResponse']/constructor[@name='GetCardListResponse' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Card[]']]"
		[Register (".ctor", "([Lru/tinkoff/acquiring/sdk/Card;)V", "")]
		public unsafe GetCardListResponse (global::RU.Tinkoff.Acquiring.Sdk.Card[] p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (GetCardListResponse)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Lru/tinkoff/acquiring/sdk/Card;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Lru/tinkoff/acquiring/sdk/Card;)V", __args);
					return;
				}

				if (id_ctor_arrayLru_tinkoff_acquiring_sdk_Card_ == IntPtr.Zero)
					id_ctor_arrayLru_tinkoff_acquiring_sdk_Card_ = JNIEnv.GetMethodID (class_ref, "<init>", "([Lru/tinkoff/acquiring/sdk/Card;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLru_tinkoff_acquiring_sdk_Card_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLru_tinkoff_acquiring_sdk_Card_, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getCard;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='GetCardListResponse']/method[@name='getCard' and count(parameter)=0]"
		[Register ("getCard", "()[Lru/tinkoff/acquiring/sdk/Card;", "")]
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.Card[] GetCard ()
		{
			if (id_getCard == IntPtr.Zero)
				id_getCard = JNIEnv.GetMethodID (class_ref, "getCard", "()[Lru/tinkoff/acquiring/sdk/Card;");
			try {
				return (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCard), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
			} finally {
			}
		}

	}
}
