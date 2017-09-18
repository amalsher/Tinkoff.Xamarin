using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']"
	[global::Android.Runtime.Register ("com/google/gson/stream/JsonWriter", DoNotGenerateAcw=true)]
	public partial class JsonWriter : global::Java.Lang.Object, global::Java.IO.ICloseable, global::Java.IO.IFlushable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/stream/JsonWriter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonWriter); }
		}

		protected JsonWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_Writer_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/constructor[@name='JsonWriter' and count(parameter)=1 and parameter[1][@type='java.io.Writer']]"
		[Register (".ctor", "(Ljava/io/Writer;)V", "")]
		public unsafe JsonWriter (global::Java.IO.Writer p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (JsonWriter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/Writer;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/Writer;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_Writer_ == IntPtr.Zero)
					id_ctor_Ljava_io_Writer_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/Writer;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_Writer_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_Writer_, __args);
			} finally {
			}
		}

		static IntPtr id_isHtmlSafe;
		static IntPtr id_setHtmlSafe_Z;
		public unsafe bool HtmlSafe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='isHtmlSafe' and count(parameter)=0]"
			[Register ("isHtmlSafe", "()Z", "GetIsHtmlSafeHandler")]
			get {
				if (id_isHtmlSafe == IntPtr.Zero)
					id_isHtmlSafe = JNIEnv.GetMethodID (class_ref, "isHtmlSafe", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHtmlSafe);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setHtmlSafe' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHtmlSafe", "(Z)V", "GetSetHtmlSafe_ZHandler")]
			set {
				if (id_setHtmlSafe_Z == IntPtr.Zero)
					id_setHtmlSafe_Z = JNIEnv.GetMethodID (class_ref, "setHtmlSafe", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHtmlSafe_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_isLenient;
		static IntPtr id_setLenient_Z;
		public unsafe bool Lenient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='isLenient' and count(parameter)=0]"
			[Register ("isLenient", "()Z", "GetIsLenientHandler")]
			get {
				if (id_isLenient == IntPtr.Zero)
					id_isLenient = JNIEnv.GetMethodID (class_ref, "isLenient", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLenient);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLenient", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setLenient' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLenient", "(Z)V", "GetSetLenient_ZHandler")]
			set {
				if (id_setLenient_Z == IntPtr.Zero)
					id_setLenient_Z = JNIEnv.GetMethodID (class_ref, "setLenient", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLenient_Z, __args);
				} finally {
				}
			}
		}

		static IntPtr id_getSerializeNulls;
		static IntPtr id_setSerializeNulls_Z;
		public unsafe bool SerializeNulls {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='getSerializeNulls' and count(parameter)=0]"
			[Register ("getSerializeNulls", "()Z", "GetGetSerializeNullsHandler")]
			get {
				if (id_getSerializeNulls == IntPtr.Zero)
					id_getSerializeNulls = JNIEnv.GetMethodID (class_ref, "getSerializeNulls", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getSerializeNulls);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setSerializeNulls' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSerializeNulls", "(Z)V", "GetSetSerializeNulls_ZHandler")]
			set {
				if (id_setSerializeNulls_Z == IntPtr.Zero)
					id_setSerializeNulls_Z = JNIEnv.GetMethodID (class_ref, "setSerializeNulls", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSerializeNulls_Z, __args);
				} finally {
				}
			}
		}

		static Delegate cb_beginArray;
#pragma warning disable 0169
		static Delegate GetBeginArrayHandler ()
		{
			if (cb_beginArray == null)
				cb_beginArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BeginArray);
			return cb_beginArray;
		}

		static IntPtr n_BeginArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeginArray ());
		}
#pragma warning restore 0169

		static IntPtr id_beginArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='beginArray' and count(parameter)=0]"
		[Register ("beginArray", "()Lcom/google/gson/stream/JsonWriter;", "GetBeginArrayHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter BeginArray ()
		{
			if (id_beginArray == IntPtr.Zero)
				id_beginArray = JNIEnv.GetMethodID (class_ref, "beginArray", "()Lcom/google/gson/stream/JsonWriter;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_beginArray), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beginArray", "()Lcom/google/gson/stream/JsonWriter;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_beginObject;
#pragma warning disable 0169
		static Delegate GetBeginObjectHandler ()
		{
			if (cb_beginObject == null)
				cb_beginObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BeginObject);
			return cb_beginObject;
		}

		static IntPtr n_BeginObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BeginObject ());
		}
#pragma warning restore 0169

		static IntPtr id_beginObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='beginObject' and count(parameter)=0]"
		[Register ("beginObject", "()Lcom/google/gson/stream/JsonWriter;", "GetBeginObjectHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter BeginObject ()
		{
			if (id_beginObject == IntPtr.Zero)
				id_beginObject = JNIEnv.GetMethodID (class_ref, "beginObject", "()Lcom/google/gson/stream/JsonWriter;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_beginObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beginObject", "()Lcom/google/gson/stream/JsonWriter;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_endArray;
#pragma warning disable 0169
		static Delegate GetEndArrayHandler ()
		{
			if (cb_endArray == null)
				cb_endArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EndArray);
			return cb_endArray;
		}

		static IntPtr n_EndArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndArray ());
		}
#pragma warning restore 0169

		static IntPtr id_endArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='endArray' and count(parameter)=0]"
		[Register ("endArray", "()Lcom/google/gson/stream/JsonWriter;", "GetEndArrayHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter EndArray ()
		{
			if (id_endArray == IntPtr.Zero)
				id_endArray = JNIEnv.GetMethodID (class_ref, "endArray", "()Lcom/google/gson/stream/JsonWriter;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_endArray), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endArray", "()Lcom/google/gson/stream/JsonWriter;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_endObject;
#pragma warning disable 0169
		static Delegate GetEndObjectHandler ()
		{
			if (cb_endObject == null)
				cb_endObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_EndObject);
			return cb_endObject;
		}

		static IntPtr n_EndObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.EndObject ());
		}
#pragma warning restore 0169

		static IntPtr id_endObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='endObject' and count(parameter)=0]"
		[Register ("endObject", "()Lcom/google/gson/stream/JsonWriter;", "GetEndObjectHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter EndObject ()
		{
			if (id_endObject == IntPtr.Zero)
				id_endObject = JNIEnv.GetMethodID (class_ref, "endObject", "()Lcom/google/gson/stream/JsonWriter;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_endObject), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endObject", "()Lcom/google/gson/stream/JsonWriter;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		static IntPtr id_flush;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			if (id_flush == IntPtr.Zero)
				id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "flush", "()V"));
			} finally {
			}
		}

		static Delegate cb_jsonValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetJsonValue_Ljava_lang_String_Handler ()
		{
			if (cb_jsonValue_Ljava_lang_String_ == null)
				cb_jsonValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_JsonValue_Ljava_lang_String_);
			return cb_jsonValue_Ljava_lang_String_;
		}

		static IntPtr n_JsonValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.JsonValue (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_jsonValue_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='jsonValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("jsonValue", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;", "GetJsonValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter JsonValue (string p0)
		{
			if (id_jsonValue_Ljava_lang_String_ == IntPtr.Zero)
				id_jsonValue_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "jsonValue", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Google.Gson.Stream.JsonWriter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_jsonValue_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "jsonValue", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_name_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetName_Ljava_lang_String_Handler ()
		{
			if (cb_name_Ljava_lang_String_ == null)
				cb_name_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Name_Ljava_lang_String_);
			return cb_name_Ljava_lang_String_;
		}

		static IntPtr n_Name_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Name (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_name_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='name' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("name", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;", "GetName_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Name (string p0)
		{
			if (id_name_Ljava_lang_String_ == IntPtr.Zero)
				id_name_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "name", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Google.Gson.Stream.JsonWriter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "name", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_nullValue;
#pragma warning disable 0169
		static Delegate GetNullValueHandler ()
		{
			if (cb_nullValue == null)
				cb_nullValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NullValue);
			return cb_nullValue;
		}

		static IntPtr n_NullValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NullValue ());
		}
#pragma warning restore 0169

		static IntPtr id_nullValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='nullValue' and count(parameter)=0]"
		[Register ("nullValue", "()Lcom/google/gson/stream/JsonWriter;", "GetNullValueHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter NullValue ()
		{
			if (id_nullValue == IntPtr.Zero)
				id_nullValue = JNIEnv.GetMethodID (class_ref, "nullValue", "()Lcom/google/gson/stream/JsonWriter;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nullValue), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nullValue", "()Lcom/google/gson/stream/JsonWriter;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setIndent_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='setIndent' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setIndent", "(Ljava/lang/String;)V", "")]
		public unsafe void SetIndent (string p0)
		{
			if (id_setIndent_Ljava_lang_String_ == IntPtr.Zero)
				id_setIndent_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIndent", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIndent_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_value_Z;
#pragma warning disable 0169
		static Delegate GetValue_ZHandler ()
		{
			if (cb_value_Z == null)
				cb_value_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Value_Z);
			return cb_value_Z;
		}

		static IntPtr n_Value_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value (p0));
		}
#pragma warning restore 0169

		static IntPtr id_value_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("value", "(Z)Lcom/google/gson/stream/JsonWriter;", "GetValue_ZHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (bool p0)
		{
			if (id_value_Z == IntPtr.Zero)
				id_value_Z = JNIEnv.GetMethodID (class_ref, "value", "(Z)Lcom/google/gson/stream/JsonWriter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_Z, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "(Z)Lcom/google/gson/stream/JsonWriter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_value_D;
#pragma warning disable 0169
		static Delegate GetValue_DHandler ()
		{
			if (cb_value_D == null)
				cb_value_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Value_D);
			return cb_value_D;
		}

		static IntPtr n_Value_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value (p0));
		}
#pragma warning restore 0169

		static IntPtr id_value_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("value", "(D)Lcom/google/gson/stream/JsonWriter;", "GetValue_DHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (double p0)
		{
			if (id_value_D == IntPtr.Zero)
				id_value_D = JNIEnv.GetMethodID (class_ref, "value", "(D)Lcom/google/gson/stream/JsonWriter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_D, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "(D)Lcom/google/gson/stream/JsonWriter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_value_Ljava_lang_Number_;
#pragma warning disable 0169
		static Delegate GetValue_Ljava_lang_Number_Handler ()
		{
			if (cb_value_Ljava_lang_Number_ == null)
				cb_value_Ljava_lang_Number_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Value_Ljava_lang_Number_);
			return cb_value_Ljava_lang_Number_;
		}

		static IntPtr n_Value_Ljava_lang_Number_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Number p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Value (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_value_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("value", "(Ljava/lang/Number;)Lcom/google/gson/stream/JsonWriter;", "GetValue_Ljava_lang_Number_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (global::Java.Lang.Number p0)
		{
			if (id_value_Ljava_lang_Number_ == IntPtr.Zero)
				id_value_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "value", "(Ljava/lang/Number;)Lcom/google/gson/stream/JsonWriter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Google.Gson.Stream.JsonWriter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_Ljava_lang_Number_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "(Ljava/lang/Number;)Lcom/google/gson/stream/JsonWriter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_value_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetValue_Ljava_lang_String_Handler ()
		{
			if (cb_value_Ljava_lang_String_ == null)
				cb_value_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Value_Ljava_lang_String_);
			return cb_value_Ljava_lang_String_;
		}

		static IntPtr n_Value_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Value (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_value_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("value", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;", "GetValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (string p0)
		{
			if (id_value_Ljava_lang_String_ == IntPtr.Zero)
				id_value_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "value", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				global::Com.Google.Gson.Stream.JsonWriter __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonWriter;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_value_J;
#pragma warning disable 0169
		static Delegate GetValue_JHandler ()
		{
			if (cb_value_J == null)
				cb_value_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Value_J);
			return cb_value_J;
		}

		static IntPtr n_Value_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Google.Gson.Stream.JsonWriter __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Value (p0));
		}
#pragma warning restore 0169

		static IntPtr id_value_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonWriter']/method[@name='value' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("value", "(J)Lcom/google/gson/stream/JsonWriter;", "GetValue_JHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonWriter Value (long p0)
		{
			if (id_value_J == IntPtr.Zero)
				id_value_J = JNIEnv.GetMethodID (class_ref, "value", "(J)Lcom/google/gson/stream/JsonWriter;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_value_J, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonWriter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "value", "(J)Lcom/google/gson/stream/JsonWriter;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
