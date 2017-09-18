using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc']/class[@name='CardParser']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/CardParser", DoNotGenerateAcw=true)]
	public partial class CardParser : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/CardParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardParser); }
		}

		protected CardParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc']/class[@name='CardParser']/constructor[@name='CardParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CardParser)) {
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

		static Delegate cb_extractAfl_arrayB;
#pragma warning disable 0169
		static Delegate GetExtractAfl_arrayBHandler ()
		{
			if (cb_extractAfl_arrayB == null)
				cb_extractAfl_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExtractAfl_arrayB);
			return cb_extractAfl_arrayB;
		}

		static IntPtr n_ExtractAfl_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Core.Nfc.CardParser __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.CardParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = global::Android.Runtime.JavaList<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator>.ToLocalJniHandle (__this.ExtractAfl (p0));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_extractAfl_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc']/class[@name='CardParser']/method[@name='extractAfl' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("extractAfl", "([B)Ljava/util/List;", "GetExtractAfl_arrayBHandler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> ExtractAfl (byte[] p0)
		{
			if (id_extractAfl_arrayB == IntPtr.Zero)
				id_extractAfl_arrayB = JNIEnv.GetMethodID (class_ref, "extractAfl", "([B)Ljava/util/List;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::System.Collections.Generic.IList<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Android.Runtime.JavaList<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_extractAfl_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Android.Runtime.JavaList<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "extractAfl", "([B)Ljava/util/List;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_;
#pragma warning disable 0169
		static Delegate GetGetGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_Handler ()
		{
			if (cb_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_ == null)
				cb_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_);
			return cb_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_;
		}

		static IntPtr n_GetGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Core.Nfc.CardParser __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.CardParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection p1 = (global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection)global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetGetProcessingOptions (p0, p1));
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc']/class[@name='CardParser']/method[@name='getGetProcessingOptions' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='ru.tinkoff.core.nfc.connection.EmvConnection']]"
		[Register ("getGetProcessingOptions", "([BLru/tinkoff/core/nfc/connection/EmvConnection;)[B", "GetGetGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_Handler")]
		protected virtual unsafe byte[] GetGetProcessingOptions (byte[] p0, global::RU.Tinkoff.Core.Nfc.Connection.IEmvConnection p1)
		{
			if (id_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_ == IntPtr.Zero)
				id_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_ = JNIEnv.GetMethodID (class_ref, "getGetProcessingOptions", "([BLru/tinkoff/core/nfc/connection/EmvConnection;)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);

				byte[] __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGetProcessingOptions_arrayBLru_tinkoff_core_nfc_connection_EmvConnection_, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					__ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGetProcessingOptions", "([BLru/tinkoff/core/nfc/connection/EmvConnection;)[B"), __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_parse_Landroid_nfc_Tag_;
#pragma warning disable 0169
		static Delegate GetParse_Landroid_nfc_Tag_Handler ()
		{
			if (cb_parse_Landroid_nfc_Tag_ == null)
				cb_parse_Landroid_nfc_Tag_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Parse_Landroid_nfc_Tag_);
			return cb_parse_Landroid_nfc_Tag_;
		}

		static IntPtr n_Parse_Landroid_nfc_Tag_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Core.Nfc.CardParser __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.CardParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Nfc.Tag p0 = global::Java.Lang.Object.GetObject<global::Android.Nfc.Tag> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Parse (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_parse_Landroid_nfc_Tag_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc']/class[@name='CardParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='android.nfc.Tag']]"
		[Register ("parse", "(Landroid/nfc/Tag;)Lru/tinkoff/core/nfc/model/Card;", "GetParse_Landroid_nfc_Tag_Handler")]
		public virtual unsafe global::RU.Tinkoff.Core.Nfc.Model.Card Parse (global::Android.Nfc.Tag p0)
		{
			if (id_parse_Landroid_nfc_Tag_ == IntPtr.Zero)
				id_parse_Landroid_nfc_Tag_ = JNIEnv.GetMethodID (class_ref, "parse", "(Landroid/nfc/Tag;)Lru/tinkoff/core/nfc/model/Card;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::RU.Tinkoff.Core.Nfc.Model.Card __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.Card> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Landroid_nfc_Tag_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.Card> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "parse", "(Landroid/nfc/Tag;)Lru/tinkoff/core/nfc/model/Card;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
