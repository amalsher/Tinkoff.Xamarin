using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeReader']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/JsonTreeReader", DoNotGenerateAcw=true)]
	public sealed partial class JsonTreeReader : global::Com.Google.Gson.Stream.JsonReader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/JsonTreeReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonTreeReader); }
		}

		internal JsonTreeReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeReader']/constructor[@name='JsonTreeReader' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register (".ctor", "(Lcom/google/gson/JsonElement;)V", "")]
		public unsafe JsonTreeReader (global::Com.Google.Gson.JsonElement p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (JsonTreeReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/google/gson/JsonElement;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/gson/JsonElement;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
					id_ctor_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/gson/JsonElement;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_gson_JsonElement_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_gson_JsonElement_, __args);
			} finally {
			}
		}

		static IntPtr id_promoteNameToValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='JsonTreeReader']/method[@name='promoteNameToValue' and count(parameter)=0]"
		[Register ("promoteNameToValue", "()V", "")]
		public unsafe void PromoteNameToValue ()
		{
			if (id_promoteNameToValue == IntPtr.Zero)
				id_promoteNameToValue = JNIEnv.GetMethodID (class_ref, "promoteNameToValue", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_promoteNameToValue);
			} finally {
			}
		}

	}
}
