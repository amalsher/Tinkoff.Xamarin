using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']"
	[global::Android.Runtime.Register ("com/google/gson/JsonArray", DoNotGenerateAcw=true)]
	public sealed partial class JsonArray : global::Com.Google.Gson.JsonElement, global::Java.Lang.IIterable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/JsonArray", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonArray); }
		}

		internal JsonArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/constructor[@name='JsonArray' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonArray ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JsonArray)) {
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

		static IntPtr id_add_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("add", "(Lcom/google/gson/JsonElement;)V", "")]
		public unsafe void Add (global::Com.Google.Gson.JsonElement p0)
		{
			if (id_add_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_add_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "add", "(Lcom/google/gson/JsonElement;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Lcom_google_gson_JsonElement_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Ljava_lang_Boolean_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("add", "(Ljava/lang/Boolean;)V", "")]
		public unsafe void Add (global::Java.Lang.Boolean p0)
		{
			if (id_add_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_add_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Boolean;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Boolean_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Ljava_lang_Character_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Character']]"
		[Register ("add", "(Ljava/lang/Character;)V", "")]
		public unsafe void Add (global::Java.Lang.Character p0)
		{
			if (id_add_Ljava_lang_Character_ == IntPtr.Zero)
				id_add_Ljava_lang_Character_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Character;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Character_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Ljava_lang_Number_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.Number']]"
		[Register ("add", "(Ljava/lang/Number;)V", "")]
		public unsafe void Add (global::Java.Lang.Number p0)
		{
			if (id_add_Ljava_lang_Number_ == IntPtr.Zero)
				id_add_Ljava_lang_Number_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/Number;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_Number_, __args);
			} finally {
			}
		}

		static IntPtr id_add_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='add' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("add", "(Ljava/lang/String;)V", "")]
		public unsafe void Add (string p0)
		{
			if (id_add_Ljava_lang_String_ == IntPtr.Zero)
				id_add_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_addAll_Lcom_google_gson_JsonArray_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='addAll' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonArray']]"
		[Register ("addAll", "(Lcom/google/gson/JsonArray;)V", "")]
		public unsafe void AddAll (global::Com.Google.Gson.JsonArray p0)
		{
			if (id_addAll_Lcom_google_gson_JsonArray_ == IntPtr.Zero)
				id_addAll_Lcom_google_gson_JsonArray_ = JNIEnv.GetMethodID (class_ref, "addAll", "(Lcom/google/gson/JsonArray;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addAll_Lcom_google_gson_JsonArray_, __args);
			} finally {
			}
		}

		static IntPtr id_contains_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("contains", "(Lcom/google/gson/JsonElement;)Z", "")]
		public unsafe bool Contains (global::Com.Google.Gson.JsonElement p0)
		{
			if (id_contains_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_contains_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/google/gson/JsonElement;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lcom_google_gson_JsonElement_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='get' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("get", "(I)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Get (int p0)
		{
			if (id_get_I == IntPtr.Zero)
				id_get_I = JNIEnv.GetMethodID (class_ref, "get", "(I)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_iterator;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "")]
		public unsafe global::Java.Util.IIterator Iterator ()
		{
			if (id_iterator == IntPtr.Zero)
				id_iterator = JNIEnv.GetMethodID (class_ref, "iterator", "()Ljava/util/Iterator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_iterator), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_remove_Lcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='com.google.gson.JsonElement']]"
		[Register ("remove", "(Lcom/google/gson/JsonElement;)Z", "")]
		public unsafe bool Remove (global::Com.Google.Gson.JsonElement p0)
		{
			if (id_remove_Lcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_remove_Lcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "remove", "(Lcom/google/gson/JsonElement;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_remove_Lcom_google_gson_JsonElement_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_remove_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='remove' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("remove", "(I)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Remove (int p0)
		{
			if (id_remove_I == IntPtr.Zero)
				id_remove_I = JNIEnv.GetMethodID (class_ref, "remove", "(I)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_remove_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_set_ILcom_google_gson_JsonElement_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='set' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.gson.JsonElement']]"
		[Register ("set", "(ILcom/google/gson/JsonElement;)Lcom/google/gson/JsonElement;", "")]
		public unsafe global::Com.Google.Gson.JsonElement Set (int p0, global::Com.Google.Gson.JsonElement p1)
		{
			if (id_set_ILcom_google_gson_JsonElement_ == IntPtr.Zero)
				id_set_ILcom_google_gson_JsonElement_ = JNIEnv.GetMethodID (class_ref, "set", "(ILcom/google/gson/JsonElement;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_set_ILcom_google_gson_JsonElement_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_size;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonArray']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "")]
		public unsafe int Size ()
		{
			if (id_size == IntPtr.Zero)
				id_size = JNIEnv.GetMethodID (class_ref, "size", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_size);
			} finally {
			}
		}

	}
}
