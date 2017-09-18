using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/ArrayTypeAdapter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
	public sealed partial class ArrayTypeAdapter : global::Com.Google.Gson.TypeAdapter {


		static IntPtr FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/field[@name='FACTORY']"
		[Register ("FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory Factory {
			get {
				if (FACTORY_jfieldId == IntPtr.Zero)
					FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/ArrayTypeAdapter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ArrayTypeAdapter); }
		}

		internal ArrayTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_gson_Gson_Lcom_google_gson_TypeAdapter_Ljava_lang_Class_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/constructor[@name='ArrayTypeAdapter' and count(parameter)=3 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.TypeAdapter&lt;E&gt;'] and parameter[3][@type='java.lang.Class&lt;E&gt;']]"
		[Register (".ctor", "(Lcom/google/gson/Gson;Lcom/google/gson/TypeAdapter;Ljava/lang/Class;)V", "")]
		public unsafe ArrayTypeAdapter (global::Com.Google.Gson.Gson p0, global::Com.Google.Gson.TypeAdapter p1, global::Java.Lang.Class p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (ArrayTypeAdapter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/google/gson/Gson;Lcom/google/gson/TypeAdapter;Ljava/lang/Class;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/gson/Gson;Lcom/google/gson/TypeAdapter;Ljava/lang/Class;)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_gson_Gson_Lcom_google_gson_TypeAdapter_Ljava_lang_Class_ == IntPtr.Zero)
					id_ctor_Lcom_google_gson_Gson_Lcom_google_gson_TypeAdapter_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/gson/Gson;Lcom/google/gson/TypeAdapter;Ljava/lang/Class;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_gson_Gson_Lcom_google_gson_TypeAdapter_Ljava_lang_Class_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_gson_Gson_Lcom_google_gson_TypeAdapter_Ljava_lang_Class_, __args);
			} finally {
			}
		}

		static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "")]
		public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader p0)
		{
			if (id_read_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_read_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='ArrayTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='java.lang.Object']]"
		[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V", "")]
		public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter p0, global::Java.Lang.Object p1)
		{
			if (id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ == IntPtr.Zero)
				id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_, __args);
			} finally {
			}
		}

	}
}
