using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/TypeAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class TypeAdapter : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/TypeAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypeAdapter); }
		}

		protected TypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/constructor[@name='TypeAdapter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TypeAdapter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TypeAdapter)) {
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

		static IntPtr id_fromJson_Ljava_io_Reader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register ("fromJson", "(Ljava/io/Reader;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader p0)
		{
			if (id_fromJson_Ljava_io_Reader_ == IntPtr.Zero)
				id_fromJson_Ljava_io_Reader_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/io/Reader;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_io_Reader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='fromJson' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromJson", "(Ljava/lang/String;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object FromJson (string p0)
		{
			if (id_fromJson_Ljava_lang_String_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/lang/String;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromJsonTree_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='fromJsonTree' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("fromJsonTree", "(Lcom/google/gson/JsonElement;)Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object FromJsonTree (global::Com.Google.Gson.JsonElement p0)
		{
			if (id_fromJsonTree_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_fromJsonTree_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "fromJsonTree", "(Lcom/google/gson/JsonElement;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJsonTree_Lcom_google_gson_JsonElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_nullSafe;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='nullSafe' and count(parameter)=0]"
		[Register ("nullSafe", "()Lcom/google/gson/TypeAdapter;", "")]
		public unsafe global::Com.Google.Gson.TypeAdapter NullSafe ()
		{
			if (id_nullSafe == IntPtr.Zero)
				id_nullSafe = JNIEnv.GetMethodID (class_ref, "nullSafe", "()Lcom/google/gson/TypeAdapter;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nullSafe), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_read_Lcom_google_gson_stream_JsonReader_;
#pragma warning disable 0169
		static Delegate GetRead_Lcom_google_gson_stream_JsonReader_Handler ()
		{
			if (cb_read_Lcom_google_gson_stream_JsonReader_ == null)
				cb_read_Lcom_google_gson_stream_JsonReader_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Read_Lcom_google_gson_stream_JsonReader_);
			return cb_read_Lcom_google_gson_stream_JsonReader_;
		}

		static IntPtr n_Read_Lcom_google_gson_stream_JsonReader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.TypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Stream.JsonReader p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Read (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "GetRead_Lcom_google_gson_stream_JsonReader_Handler")]
		public abstract global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader p0);

		static IntPtr id_toJson_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object p0)
		{
			if (id_toJson_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_toJson_Ljava_io_Writer_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.io.Writer'] and parameter[2][@type='T']]"
		[Register ("toJson", "(Ljava/io/Writer;Ljava/lang/Object;)V", "")]
		public unsafe void ToJson (global::Java.IO.Writer p0, global::Java.Lang.Object p1)
		{
			if (id_toJson_Ljava_io_Writer_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJson_Ljava_io_Writer_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/io/Writer;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_io_Writer_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_toJsonTree_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='toJsonTree' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object p0)
		{
			if (id_toJsonTree_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJsonTree_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonTree_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetWrite_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_Handler ()
		{
			if (cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ == null)
				cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_);
			return cb_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
		}

		static void n_Write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Gson.TypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Stream.JsonWriter p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Write (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "GetWrite_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_Handler")]
		public abstract void Write (global::Com.Google.Gson.Stream.JsonWriter p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/google/gson/TypeAdapter", DoNotGenerateAcw=true)]
	internal partial class TypeAdapterInvoker : TypeAdapter {

		public TypeAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypeAdapterInvoker); }
		}

		static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "GetRead_Lcom_google_gson_stream_JsonReader_Handler")]
		public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader p0)
		{
			if (id_read_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_read_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='TypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "GetWrite_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_Handler")]
		public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter p0, global::Java.Lang.Object p1)
		{
			if (id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ == IntPtr.Zero)
				id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

	}

}
