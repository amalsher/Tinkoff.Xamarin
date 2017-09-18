using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/class[@name='NfcEmvConnection']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/connection/NfcEmvConnection", DoNotGenerateAcw=true)]
	public partial class NfcEmvConnection : global::RU.Tinkoff.Core.Nfc.Connection.AbstractEmvConnection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/connection/NfcEmvConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NfcEmvConnection); }
		}

		protected NfcEmvConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_nfc_Tag_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/class[@name='NfcEmvConnection']/constructor[@name='NfcEmvConnection' and count(parameter)=1 and parameter[1][@type='android.nfc.Tag']]"
		[Register (".ctor", "(Landroid/nfc/Tag;)V", "")]
		public unsafe NfcEmvConnection (global::Android.Nfc.Tag p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (NfcEmvConnection)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/nfc/Tag;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/nfc/Tag;)V", __args);
					return;
				}

				if (id_ctor_Landroid_nfc_Tag_ == IntPtr.Zero)
					id_ctor_Landroid_nfc_Tag_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/nfc/Tag;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_nfc_Tag_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_nfc_Tag_, __args);
			} finally {
			}
		}

		static Delegate cb_transceive_arrayB;
#pragma warning disable 0169
		static Delegate GetTransceive_arrayBHandler ()
		{
			if (cb_transceive_arrayB == null)
				cb_transceive_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transceive_arrayB);
			return cb_transceive_arrayB;
		}

		static IntPtr n_Transceive_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Core.Nfc.Connection.NfcEmvConnection __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Connection.NfcEmvConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Transceive (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transceive_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/class[@name='NfcEmvConnection']/method[@name='transceive' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("transceive", "([B)[B", "GetTransceive_arrayBHandler")]
		public override unsafe byte[] Transceive (byte[] p0)
		{
			if (id_transceive_arrayB == IntPtr.Zero)
				id_transceive_arrayB = JNIEnv.GetMethodID (class_ref, "transceive", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transceive_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transceive", "([B)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
