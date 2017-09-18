using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']"
	[global::Android.Runtime.Register ("com/google/gson/internal/JsonReaderInternalAccess", DoNotGenerateAcw=true)]
	public abstract partial class JsonReaderInternalAccess : global::Java.Lang.Object {


		static IntPtr INSTANCE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/field[@name='INSTANCE']"
		[Register ("INSTANCE")]
		public static global::Com.Google.Gson.Internal.JsonReaderInternalAccess Instance {
			get {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/google/gson/internal/JsonReaderInternalAccess;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTANCE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.JsonReaderInternalAccess> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INSTANCE_jfieldId == IntPtr.Zero)
					INSTANCE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTANCE", "Lcom/google/gson/internal/JsonReaderInternalAccess;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, INSTANCE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/JsonReaderInternalAccess", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonReaderInternalAccess); }
		}

		protected JsonReaderInternalAccess (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/constructor[@name='JsonReaderInternalAccess' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonReaderInternalAccess ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JsonReaderInternalAccess)) {
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

		static Delegate cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_;
#pragma warning disable 0169
		static Delegate GetPromoteNameToValue_Lcom_google_gson_stream_JsonReader_Handler ()
		{
			if (cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_ == null)
				cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PromoteNameToValue_Lcom_google_gson_stream_JsonReader_);
			return cb_promoteNameToValue_Lcom_google_gson_stream_JsonReader_;
		}

		static void n_PromoteNameToValue_Lcom_google_gson_stream_JsonReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Internal.JsonReaderInternalAccess __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.JsonReaderInternalAccess> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Stream.JsonReader p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PromoteNameToValue (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/method[@name='promoteNameToValue' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("promoteNameToValue", "(Lcom/google/gson/stream/JsonReader;)V", "GetPromoteNameToValue_Lcom_google_gson_stream_JsonReader_Handler")]
		public abstract void PromoteNameToValue (global::Com.Google.Gson.Stream.JsonReader p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/internal/JsonReaderInternalAccess", DoNotGenerateAcw=true)]
	internal partial class JsonReaderInternalAccessInvoker : JsonReaderInternalAccess {

		public JsonReaderInternalAccessInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonReaderInternalAccessInvoker); }
		}

		static IntPtr id_promoteNameToValue_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='JsonReaderInternalAccess']/method[@name='promoteNameToValue' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("promoteNameToValue", "(Lcom/google/gson/stream/JsonReader;)V", "GetPromoteNameToValue_Lcom_google_gson_stream_JsonReader_Handler")]
		public override unsafe void PromoteNameToValue (global::Com.Google.Gson.Stream.JsonReader p0)
		{
			if (id_promoteNameToValue_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_promoteNameToValue_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "promoteNameToValue", "(Lcom/google/gson/stream/JsonReader;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_promoteNameToValue_Lcom_google_gson_stream_JsonReader_, __args);
			} finally {
			}
		}

	}

}
