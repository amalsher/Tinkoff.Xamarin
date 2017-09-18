using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']"
	[global::Android.Runtime.Register ("com/google/gson/Gson", DoNotGenerateAcw=true)]
	public sealed partial class Gson : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']"
		[global::Android.Runtime.Register ("com/google/gson/Gson$FutureTypeAdapter", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial class FutureTypeAdapter : global::Com.Google.Gson.TypeAdapter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/gson/Gson$FutureTypeAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FutureTypeAdapter); }
			}

			protected FutureTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

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
				global::Com.Google.Gson.Gson.FutureTypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson.FutureTypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Gson.Stream.JsonReader p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Read (p0));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
			[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;", "GetRead_Lcom_google_gson_stream_JsonReader_Handler")]
			public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader p0)
			{
				if (id_read_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
					id_read_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					global::Java.Lang.Object __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setDelegate_Lcom_google_gson_TypeAdapter_;
#pragma warning disable 0169
			static Delegate GetSetDelegate_Lcom_google_gson_TypeAdapter_Handler ()
			{
				if (cb_setDelegate_Lcom_google_gson_TypeAdapter_ == null)
					cb_setDelegate_Lcom_google_gson_TypeAdapter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDelegate_Lcom_google_gson_TypeAdapter_);
				return cb_setDelegate_Lcom_google_gson_TypeAdapter_;
			}

			static void n_SetDelegate_Lcom_google_gson_TypeAdapter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::Com.Google.Gson.Gson.FutureTypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson.FutureTypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Gson.TypeAdapter p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetDelegate (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setDelegate_Lcom_google_gson_TypeAdapter_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']/method[@name='setDelegate' and count(parameter)=1 and parameter[1][@type='com.google.gson.TypeAdapter&lt;T&gt;']]"
			[Register ("setDelegate", "(Lcom/google/gson/TypeAdapter;)V", "GetSetDelegate_Lcom_google_gson_TypeAdapter_Handler")]
			public virtual unsafe void SetDelegate (global::Com.Google.Gson.TypeAdapter p0)
			{
				if (id_setDelegate_Lcom_google_gson_TypeAdapter_ == IntPtr.Zero)
					id_setDelegate_Lcom_google_gson_TypeAdapter_ = JNIEnv.GetMethodID (class_ref, "setDelegate", "(Lcom/google/gson/TypeAdapter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDelegate_Lcom_google_gson_TypeAdapter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDelegate", "(Lcom/google/gson/TypeAdapter;)V"), __args);
				} finally {
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
				global::Com.Google.Gson.Gson.FutureTypeAdapter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson.FutureTypeAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Google.Gson.Stream.JsonWriter p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.Write (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson.FutureTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
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

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Object_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Object;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/Gson", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Gson); }
		}

		internal Gson (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/constructor[@name='Gson' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Gson ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Gson)) {
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

		static IntPtr id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.JsonElement p0, global::Java.Lang.Class p1)
		{
			if (id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.JsonElement p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonReader'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Lcom/google/gson/stream/JsonReader;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Com.Google.Gson.Stream.JsonReader p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Lcom/google/gson/stream/JsonReader;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Lcom_google_gson_stream_JsonReader_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_io_Reader_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/io/Reader;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader p0, global::Java.Lang.Class p1)
		{
			if (id_fromJson_Ljava_io_Reader_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromJson_Ljava_io_Reader_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/io/Reader;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_io_Reader_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.io.Reader'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Ljava/io/Reader;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (global::Java.IO.Reader p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/io/Reader;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_io_Reader_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (string p0, global::Java.Lang.Class p1)
		{
			if (id_fromJson_Ljava_lang_String_Ljava_lang_Class_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_lang_String_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='fromJson' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("fromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object FromJson (string p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "fromJson", "(Ljava/lang/String;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_fromJson_Ljava_lang_String_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAdapter_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("getAdapter", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetAdapter (global::Com.Google.Gson.Reflect.TypeToken p0)
		{
			if (id_getAdapter_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_getAdapter_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "getAdapter", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getAdapter_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAdapter", "(Ljava/lang/Class;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetAdapter (global::Java.Lang.Class p0)
		{
			if (id_getAdapter_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAdapter_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getAdapter", "(Ljava/lang/Class;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAdapter_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='getDelegateAdapter' and count(parameter)=2 and parameter[1][@type='com.google.gson.TypeAdapterFactory'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("getDelegateAdapter", "(Lcom/google/gson/TypeAdapterFactory;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter GetDelegateAdapter (global::Com.Google.Gson.ITypeAdapterFactory p0, global::Com.Google.Gson.Reflect.TypeToken p1)
		{
			if (id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "getDelegateAdapter", "(Lcom/google/gson/TypeAdapterFactory;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDelegateAdapter_Lcom_google_gson_TypeAdapterFactory_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newJsonWriter_Ljava_io_Writer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='newJsonWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register ("newJsonWriter", "(Ljava/io/Writer;)Lcom/google/gson/stream/JsonWriter;", "")]
		public unsafe global::Com.Google.Gson.Stream.JsonWriter NewJsonWriter (global::Java.IO.Writer p0)
		{
			if (id_newJsonWriter_Ljava_io_Writer_ == IntPtr.Zero)
				id_newJsonWriter_Ljava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "newJsonWriter", "(Ljava/io/Writer;)Lcom/google/gson/stream/JsonWriter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.Stream.JsonWriter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newJsonWriter_Ljava_io_Writer_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Com.Google.Gson.JsonElement p0)
		{
			if (id_toJson_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_toJson_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lcom/google/gson/JsonElement;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lcom_google_gson_JsonElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public unsafe void ToJson (global::Com.Google.Gson.JsonElement p0, global::Com.Google.Gson.Stream.JsonWriter p1)
		{
			if (id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ == IntPtr.Zero)
				id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Com.Google.Gson.JsonElement p0, global::Java.Lang.IAppendable p1)
		{
			if (id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Lcom/google/gson/JsonElement;Ljava/lang/Appendable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Lcom_google_gson_JsonElement_Ljava_lang_Appendable_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJson", "(Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object p0)
		{
			if (id_toJson_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object p0, global::Java.Lang.IAppendable p1)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/Appendable;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_Appendable_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;", "")]
		public unsafe string ToJson (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1, global::Com.Google.Gson.Stream.JsonWriter p2)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/stream/JsonWriter;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_stream_JsonWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJson' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='java.lang.Appendable']]"
		[Register ("toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/Appendable;)V", "")]
		public unsafe void ToJson (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1, global::Java.Lang.IAppendable p2)
		{
			if (id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_ = JNIEnv.GetMethodID (class_ref, "toJson", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Ljava/lang/Appendable;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_toJson_Ljava_lang_Object_Ljava_lang_reflect_Type_Ljava_lang_Appendable_, __args);
			} finally {
			}
		}

		static IntPtr id_toJsonTree_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJsonTree' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object p0)
		{
			if (id_toJsonTree_Ljava_lang_Object_ == IntPtr.Zero)
				id_toJsonTree_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "toJsonTree", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonTree_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='Gson']/method[@name='toJsonTree' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("toJsonTree", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement ToJsonTree (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "toJsonTree", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJsonTree_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
