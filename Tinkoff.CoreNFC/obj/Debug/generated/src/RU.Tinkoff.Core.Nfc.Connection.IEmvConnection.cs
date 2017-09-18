using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Connection {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/interface[@name='EmvConnection']"
	[Register ("ru/tinkoff/core/nfc/connection/EmvConnection", "", "RU.Tinkoff.Core.Nfc.Connection.IEmvConnectionInvoker")]
	public partial interface IEmvConnection : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/interface[@name='EmvConnection']/method[@name='transceive' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("transceive", "([B)[B", "GetTransceive_arrayBHandler:RU.Tinkoff.Core.Nfc.Connection.IEmvConnectionInvoker, Tinkoff.CoreNFC")]
		byte[] Transceive (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.connection']/interface[@name='EmvConnection']/method[@name='transceive' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("transceive", "(Ljava/lang/String;)[B", "GetTransceive_Ljava_lang_String_Handler:RU.Tinkoff.Core.Nfc.Connection.IEmvConnectionInvoker, Tinkoff.CoreNFC")]
		byte[] Transceive (string p0);

	}

	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/connection/EmvConnection", DoNotGenerateAcw=true)]
	internal class IEmvConnectionInvoker : global::Java.Lang.Object, IEmvConnection {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/core/nfc/connection/EmvConnection");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IEmvConnectionInvoker); }
		}

		IntPtr class_ref;

		public static IEmvConnection GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IEmvConnection> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.core.nfc.connection.EmvConnection"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IEmvConnectionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Transceive (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_transceive_arrayB;
		public unsafe byte[] Transceive (byte[] p0)
		{
			if (id_transceive_arrayB == IntPtr.Zero)
				id_transceive_arrayB = JNIEnv.GetMethodID (class_ref, "transceive", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transceive_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
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
			global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Transceive (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_transceive_Ljava_lang_String_;
		public unsafe byte[] Transceive (string p0)
		{
			if (id_transceive_Ljava_lang_String_ == IntPtr.Zero)
				id_transceive_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "transceive", "(Ljava/lang/String;)[B");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_transceive_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
