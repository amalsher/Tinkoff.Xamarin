using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']"
	[global::Android.Runtime.Register ("com/google/gson/JsonParser", DoNotGenerateAcw=true)]
	public sealed partial class JsonParser : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/JsonParser", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonParser); }
		}

		internal JsonParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/constructor[@name='JsonParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonParser ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JsonParser)) {
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

		static IntPtr id_parse_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Parse (global::Com.Google.Gson.Stream.JsonReader p0)
		{
			if (id_parse_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_parse_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_io_Reader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("parse", "(Ljava/io/Reader;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Parse (global::Java.IO.Reader p0)
		{
			if (id_parse_Ljava_io_Reader_ == IntPtr.Zero)
				id_parse_Ljava_io_Reader_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/io/Reader;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_io_Reader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_parse_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Parse (string p0)
		{
			if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
				id_parse_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
