using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='CommandApdu']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/model/CommandApdu", DoNotGenerateAcw=true)]
	public partial class CommandApdu : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/model/CommandApdu", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CommandApdu); }
		}

		protected CommandApdu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lru_tinkoff_core_nfc_model_Command_arrayBI;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=3 and parameter[1][@type='ru.tinkoff.core.nfc.model.Command'] and parameter[2][@type='byte[]'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lru/tinkoff/core/nfc/model/Command;[BI)V", "")]
		public unsafe CommandApdu (global::RU.Tinkoff.Core.Nfc.Model.Command p0, byte[] p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (CommandApdu)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lru/tinkoff/core/nfc/model/Command;[BI)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lru/tinkoff/core/nfc/model/Command;[BI)V", __args);
					return;
				}

				if (id_ctor_Lru_tinkoff_core_nfc_model_Command_arrayBI == IntPtr.Zero)
					id_ctor_Lru_tinkoff_core_nfc_model_Command_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/core/nfc/model/Command;[BI)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_core_nfc_model_Command_arrayBI, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lru_tinkoff_core_nfc_model_Command_arrayBI, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		static IntPtr id_ctor_Lru_tinkoff_core_nfc_model_Command_III;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='CommandApdu']/constructor[@name='CommandApdu' and count(parameter)=4 and parameter[1][@type='ru.tinkoff.core.nfc.model.Command'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Lru/tinkoff/core/nfc/model/Command;III)V", "")]
		public unsafe CommandApdu (global::RU.Tinkoff.Core.Nfc.Model.Command p0, int p1, int p2, int p3)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				if (((object) this).GetType () != typeof (CommandApdu)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lru/tinkoff/core/nfc/model/Command;III)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lru/tinkoff/core/nfc/model/Command;III)V", __args);
					return;
				}

				if (id_ctor_Lru_tinkoff_core_nfc_model_Command_III == IntPtr.Zero)
					id_ctor_Lru_tinkoff_core_nfc_model_Command_III = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/core/nfc/model/Command;III)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_core_nfc_model_Command_III, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lru_tinkoff_core_nfc_model_Command_III, __args);
			} finally {
			}
		}

		static Delegate cb_toBytes;
#pragma warning disable 0169
		static Delegate GetToBytesHandler ()
		{
			if (cb_toBytes == null)
				cb_toBytes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToBytes);
			return cb_toBytes;
		}

		static IntPtr n_ToBytes (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Core.Nfc.Model.CommandApdu __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.CommandApdu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToBytes ());
		}
#pragma warning restore 0169

		static IntPtr id_toBytes;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='CommandApdu']/method[@name='toBytes' and count(parameter)=0]"
		[Register ("toBytes", "()[B", "GetToBytesHandler")]
		public virtual unsafe byte[] ToBytes ()
		{
			if (id_toBytes == IntPtr.Zero)
				id_toBytes = JNIEnv.GetMethodID (class_ref, "toBytes", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toBytes), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toBytes", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

	}
}
