using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Connection {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/class[@name='AbstractEmvConnection']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/connection/AbstractEmvConnection", DoNotGenerateAcw=true)]
	public abstract partial class AbstractEmvConnection : global::Java.Lang.Object, global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/connection/AbstractEmvConnection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractEmvConnection); }
		}

		protected AbstractEmvConnection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/class[@name='AbstractEmvConnection']/constructor[@name='AbstractEmvConnection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractEmvConnection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (AbstractEmvConnection)) {
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

		static Delegate cb_transceive_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetTransceive_Ljava_lang_String_Handler ()
		{
			if (cb_transceive_Ljava_lang_String_ == null)
				cb_transceive_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Transceive_Ljava_lang_String_);
			return cb_transceive_Ljava_lang_String_;
		}

		static IntPtr n_Transceive_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Core.Nfc.Connection.AbstractEmvConnection __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Connection.AbstractEmvConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Transceive (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_transceive_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/class[@name='AbstractEmvConnection']/method[@name='transceive' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("transceive", "(Ljava/lang/String;)[B", "GetTransceive_Ljava_lang_String_Handler")]
		public virtual unsafe byte[] Transceive (string p0)
		{
			if (id_transceive_Ljava_lang_String_ == IntPtr.Zero)
				id_transceive_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transceive", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transceive_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "transceive", "(Ljava/lang/String;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
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
			global::RU.Tinkoff.Core.Nfc.Connection.AbstractEmvConnection __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Connection.AbstractEmvConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Transceive (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/interface[@name='EmvConnection']/method[@name='transceive' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("transceive", "([B)[B", "GetTransceive_arrayBHandler")]
		public abstract byte[] Transceive (byte[] p0);

	}

	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/connection/AbstractEmvConnection", DoNotGenerateAcw=true)]
	internal partial class AbstractEmvConnectionInvoker : AbstractEmvConnection {

		public AbstractEmvConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (AbstractEmvConnectionInvoker); }
		}

		static IntPtr id_transceive_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/interface[@name='EmvConnection']/method[@name='transceive' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("transceive", "([B)[B", "GetTransceive_arrayBHandler")]
		public override unsafe byte[] Transceive (byte[] p0)
		{
			if (id_transceive_arrayB == IntPtr.Zero)
				id_transceive_arrayB = JNIEnv.GetMethodID (class_ref, "transceive", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transceive_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
