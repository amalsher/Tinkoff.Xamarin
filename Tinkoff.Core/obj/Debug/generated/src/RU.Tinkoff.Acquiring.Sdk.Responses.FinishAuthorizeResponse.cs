using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Responses {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/responses/FinishAuthorizeResponse", DoNotGenerateAcw=true)]
	public sealed partial class FinishAuthorizeResponse : global::RU.Tinkoff.Acquiring.Sdk.Responses.AcquiringResponse {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/responses/FinishAuthorizeResponse", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FinishAuthorizeResponse); }
		}

		internal FinishAuthorizeResponse (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/constructor[@name='FinishAuthorizeResponse' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FinishAuthorizeResponse ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (FinishAuthorizeResponse)) {
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

		static IntPtr id_getAcsUrl;
		public unsafe string AcsUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getAcsUrl' and count(parameter)=0]"
			[Register ("getAcsUrl", "()Ljava/lang/String;", "GetGetAcsUrlHandler")]
			get {
				if (id_getAcsUrl == IntPtr.Zero)
					id_getAcsUrl = JNIEnv.GetMethodID (class_ref, "getAcsUrl", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAcsUrl), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAmount;
		public unsafe global::Java.Lang.Long Amount {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getAmount' and count(parameter)=0]"
			[Register ("getAmount", "()Ljava/lang/Long;", "GetGetAmountHandler")]
			get {
				if (id_getAmount == IntPtr.Zero)
					id_getAmount = JNIEnv.GetMethodID (class_ref, "getAmount", "()Ljava/lang/Long;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAmount), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getMd;
		public unsafe string Md {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getMd' and count(parameter)=0]"
			[Register ("getMd", "()Ljava/lang/String;", "GetGetMdHandler")]
			get {
				if (id_getMd == IntPtr.Zero)
					id_getMd = JNIEnv.GetMethodID (class_ref, "getMd", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMd), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getOrderId;
		public unsafe string OrderId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getOrderId' and count(parameter)=0]"
			[Register ("getOrderId", "()Ljava/lang/String;", "GetGetOrderIdHandler")]
			get {
				if (id_getOrderId == IntPtr.Zero)
					id_getOrderId = JNIEnv.GetMethodID (class_ref, "getOrderId", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOrderId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPaReq;
		public unsafe string PaReq {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getPaReq' and count(parameter)=0]"
			[Register ("getPaReq", "()Ljava/lang/String;", "GetGetPaReqHandler")]
			get {
				if (id_getPaReq == IntPtr.Zero)
					id_getPaReq = JNIEnv.GetMethodID (class_ref, "getPaReq", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaReq), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getPaymentId;
		public unsafe global::Java.Lang.Long PaymentId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getPaymentId' and count(parameter)=0]"
			[Register ("getPaymentId", "()Ljava/lang/Long;", "GetGetPaymentIdHandler")]
			get {
				if (id_getPaymentId == IntPtr.Zero)
					id_getPaymentId = JNIEnv.GetMethodID (class_ref, "getPaymentId", "()Ljava/lang/Long;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPaymentId), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getStatus;
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus Status {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getStatus' and count(parameter)=0]"
			[Register ("getStatus", "()Lru/tinkoff/acquiring/sdk/PaymentStatus;", "GetGetStatusHandler")]
			get {
				if (id_getStatus == IntPtr.Zero)
					id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()Lru/tinkoff/acquiring/sdk/PaymentStatus;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.PaymentStatus> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getThreeDsData;
		public unsafe global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData ThreeDsData {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.responses']/class[@name='FinishAuthorizeResponse']/method[@name='getThreeDsData' and count(parameter)=0]"
			[Register ("getThreeDsData", "()Lru/tinkoff/acquiring/sdk/ThreeDsData;", "GetGetThreeDsDataHandler")]
			get {
				if (id_getThreeDsData == IntPtr.Zero)
					id_getThreeDsData = JNIEnv.GetMethodID (class_ref, "getThreeDsData", "()Lru/tinkoff/acquiring/sdk/ThreeDsData;");
				try {
					return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ThreeDsData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getThreeDsData), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
