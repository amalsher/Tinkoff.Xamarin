using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']"
	[global::Android.Runtime.Register ("com/google/gson/JsonObject", DoNotGenerateAcw=true)]
	public sealed partial class JsonObject : global::Com.Google.Gson.JsonElement {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/JsonObject", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonObject); }
		}

		internal JsonObject (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/constructor[@name='JsonObject' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonObject ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JsonObject)) {
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

		static IntPtr id_add_Ljava_lang_String_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='add' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.google.gson.JsonElement']]"
		[Register ("add", "(Ljava/lang/String;Lcom/google/gson/JsonElement;)V", "")]
		public unsafe void Add (string p0, global::Com.Google.Gson.JsonElement p1)
		{
			if (id_add_Ljava_lang_String_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Lcom/google/gson/JsonElement;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_Lcom_google_gson_JsonElement_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addProperty_Ljava_lang_String_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Boolean']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/Boolean;)V", "")]
		public unsafe void AddProperty (string p0, global::Java.Lang.Boolean p1)
		{
			if (id_addProperty_Ljava_lang_String_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_addProperty_Ljava_lang_String_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "addProperty", "(Ljava/lang/String;Ljava/lang/Boolean;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProperty_Ljava_lang_String_Ljava_lang_Boolean_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addProperty_Ljava_lang_String_Ljava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Character']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/Character;)V", "")]
		public unsafe void AddProperty (string p0, global::Java.Lang.Character p1)
		{
			if (id_addProperty_Ljava_lang_String_Ljava_lang_Character_ == IntPtr.Zero)
				id_addProperty_Ljava_lang_String_Ljava_lang_Character_ = JNIEnv.GetMethodID (class_ref, "addProperty", "(Ljava/lang/String;Ljava/lang/Character;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProperty_Ljava_lang_String_Ljava_lang_Character_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addProperty_Ljava_lang_String_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Number']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/Number;)V", "")]
		public unsafe void AddProperty (string p0, global::Java.Lang.Number p1)
		{
			if (id_addProperty_Ljava_lang_String_Ljava_lang_Number_ == IntPtr.Zero)
				id_addProperty_Ljava_lang_String_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "addProperty", "(Ljava/lang/String;Ljava/lang/Number;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProperty_Ljava_lang_String_Ljava_lang_Number_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addProperty_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='addProperty' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addProperty", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe void AddProperty (string p0, string p1)
		{
			if (id_addProperty_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addProperty_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addProperty", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addProperty_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_entrySet;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='entrySet' and count(parameter)=0]"
		[Register ("entrySet", "()Ljava/util/Set;", "")]
		public unsafe global::System.Collections.Generic.ICollection<global::Java.Util.IMapEntry> EntrySet ()
		{
			if (id_entrySet == IntPtr.Zero)
				id_entrySet = JNIEnv.GetMethodID (class_ref, "entrySet", "()Ljava/util/Set;");
			try {
				return global::Android.Runtime.JavaSet<global::Java.Util.IMapEntry>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_entrySet), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("get", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Get (string p0)
		{
			if (id_get_Ljava_lang_String_ == IntPtr.Zero)
				id_get_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAsJsonArray_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='getAsJsonArray' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJsonArray", "(Ljava/lang/String;)Lcom/google/gson/JsonArray;", "")]
		public unsafe global::Com.Google.Gson.JsonArray GetAsJsonArray (string p0)
		{
			if (id_getAsJsonArray_Ljava_lang_String_ == IntPtr.Zero)
				id_getAsJsonArray_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAsJsonArray", "(Ljava/lang/String;)Lcom/google/gson/JsonArray;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.JsonArray __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJsonArray_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAsJsonObject_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='getAsJsonObject' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJsonObject", "(Ljava/lang/String;)Lcom/google/gson/JsonObject;", "")]
		public unsafe global::Com.Google.Gson.JsonObject GetAsJsonObject (string p0)
		{
			if (id_getAsJsonObject_Ljava_lang_String_ == IntPtr.Zero)
				id_getAsJsonObject_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAsJsonObject", "(Ljava/lang/String;)Lcom/google/gson/JsonObject;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.JsonObject __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJsonObject_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_getAsJsonPrimitive_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='getAsJsonPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getAsJsonPrimitive", "(Ljava/lang/String;)Lcom/google/gson/JsonPrimitive;", "")]
		public unsafe global::Com.Google.Gson.JsonPrimitive GetAsJsonPrimitive (string p0)
		{
			if (id_getAsJsonPrimitive_Ljava_lang_String_ == IntPtr.Zero)
				id_getAsJsonPrimitive_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getAsJsonPrimitive", "(Ljava/lang/String;)Lcom/google/gson/JsonPrimitive;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.JsonPrimitive __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonPrimitive> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJsonPrimitive_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_has_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='has' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("has", "(Ljava/lang/String;)Z", "")]
		public unsafe bool Has (string p0)
		{
			if (id_has_Ljava_lang_String_ == IntPtr.Zero)
				id_has_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "has", "(Ljava/lang/String;)Z");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_has_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_remove_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonObject']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("remove", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Remove (string p0)
		{
			if (id_remove_Ljava_lang_String_ == IntPtr.Zero)
				id_remove_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "remove", "(Ljava/lang/String;)Lcom/google/gson/JsonElement;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}
}
