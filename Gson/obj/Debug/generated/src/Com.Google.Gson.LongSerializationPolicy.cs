using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']"
	[global::Android.Runtime.Register ("com/google/gson/LongSerializationPolicy", DoNotGenerateAcw=true)]
	public abstract partial class LongSerializationPolicy : global::Java.Lang.Enum {


		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Google.Gson.LongSerializationPolicy Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/google/gson/LongSerializationPolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/field[@name='STRING']"
		[Register ("STRING")]
		public static global::Com.Google.Gson.LongSerializationPolicy String {
			get {
				if (STRING_jfieldId == IntPtr.Zero)
					STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/gson/LongSerializationPolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/LongSerializationPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LongSerializationPolicy); }
		}

		protected LongSerializationPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_serialize_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetSerialize_Ljava_lang_Long_Handler ()
		{
			if (cb_serialize_Ljava_lang_Long_ == null)
				cb_serialize_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Serialize_Ljava_lang_Long_);
			return cb_serialize_Ljava_lang_Long_;
		}

		static IntPtr n_Serialize_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.LongSerializationPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Serialize (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("serialize", "(Ljava/lang/Long;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_lang_Long_Handler")]
		public abstract global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Long p0);

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/gson/LongSerializationPolicy;", "")]
		public static unsafe global::Com.Google.Gson.LongSerializationPolicy ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/gson/LongSerializationPolicy;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.LongSerializationPolicy __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.LongSerializationPolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/gson/LongSerializationPolicy;", "")]
		public static unsafe global::Com.Google.Gson.LongSerializationPolicy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/gson/LongSerializationPolicy;");
			try {
				return (global::Com.Google.Gson.LongSerializationPolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Gson.LongSerializationPolicy));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/gson/LongSerializationPolicy", DoNotGenerateAcw=true)]
	internal partial class LongSerializationPolicyInvoker : LongSerializationPolicy {

		public LongSerializationPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (LongSerializationPolicyInvoker); }
		}

		static IntPtr id_serialize_Ljava_lang_Long_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='LongSerializationPolicy']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("serialize", "(Ljava/lang/Long;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_lang_Long_Handler")]
		public override unsafe global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Long p0)
		{
			if (id_serialize_Ljava_lang_Long_ == IntPtr.Zero)
				id_serialize_Ljava_lang_Long_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Ljava/lang/Long;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_serialize_Ljava_lang_Long_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
