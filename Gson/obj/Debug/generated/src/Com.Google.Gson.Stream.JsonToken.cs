using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']"
	[global::Android.Runtime.Register ("com/google/gson/stream/JsonToken", DoNotGenerateAcw=true)]
	public sealed partial class JsonToken : global::Java.Lang.Enum {


		static IntPtr BEGIN_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='BEGIN_ARRAY']"
		[Register ("BEGIN_ARRAY")]
		public static global::Com.Google.Gson.Stream.JsonToken BeginArray {
			get {
				if (BEGIN_ARRAY_jfieldId == IntPtr.Zero)
					BEGIN_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEGIN_ARRAY", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEGIN_ARRAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BEGIN_OBJECT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='BEGIN_OBJECT']"
		[Register ("BEGIN_OBJECT")]
		public static global::Com.Google.Gson.Stream.JsonToken BeginObject {
			get {
				if (BEGIN_OBJECT_jfieldId == IntPtr.Zero)
					BEGIN_OBJECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BEGIN_OBJECT", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BEGIN_OBJECT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BOOLEAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='BOOLEAN']"
		[Register ("BOOLEAN")]
		public static global::Com.Google.Gson.Stream.JsonToken Boolean {
			get {
				if (BOOLEAN_jfieldId == IntPtr.Zero)
					BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr END_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='END_ARRAY']"
		[Register ("END_ARRAY")]
		public static global::Com.Google.Gson.Stream.JsonToken EndArray {
			get {
				if (END_ARRAY_jfieldId == IntPtr.Zero)
					END_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END_ARRAY", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, END_ARRAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr END_DOCUMENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='END_DOCUMENT']"
		[Register ("END_DOCUMENT")]
		public static global::Com.Google.Gson.Stream.JsonToken EndDocument {
			get {
				if (END_DOCUMENT_jfieldId == IntPtr.Zero)
					END_DOCUMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END_DOCUMENT", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, END_DOCUMENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr END_OBJECT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='END_OBJECT']"
		[Register ("END_OBJECT")]
		public static global::Com.Google.Gson.Stream.JsonToken EndObject {
			get {
				if (END_OBJECT_jfieldId == IntPtr.Zero)
					END_OBJECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "END_OBJECT", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, END_OBJECT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='NAME']"
		[Register ("NAME")]
		public static global::Com.Google.Gson.Stream.JsonToken Name {
			get {
				if (NAME_jfieldId == IntPtr.Zero)
					NAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NAME", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NAME_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='NULL']"
		[Register ("NULL")]
		public static global::Com.Google.Gson.Stream.JsonToken Null {
			get {
				if (NULL_jfieldId == IntPtr.Zero)
					NULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NULL", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NULL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='NUMBER']"
		[Register ("NUMBER")]
		public static global::Com.Google.Gson.Stream.JsonToken Number {
			get {
				if (NUMBER_jfieldId == IntPtr.Zero)
					NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMBER", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/field[@name='STRING']"
		[Register ("STRING")]
		public static global::Com.Google.Gson.Stream.JsonToken String {
			get {
				if (STRING_jfieldId == IntPtr.Zero)
					STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/gson/stream/JsonToken;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/stream/JsonToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonToken); }
		}

		internal JsonToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonToken;", "")]
		public static unsafe global::Com.Google.Gson.Stream.JsonToken ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/gson/stream/JsonToken;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.Stream.JsonToken __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonToken']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/gson/stream/JsonToken;", "")]
		public static unsafe global::Com.Google.Gson.Stream.JsonToken[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/gson/stream/JsonToken;");
			try {
				return (global::Com.Google.Gson.Stream.JsonToken[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Gson.Stream.JsonToken));
			} finally {
			}
		}

	}
}
