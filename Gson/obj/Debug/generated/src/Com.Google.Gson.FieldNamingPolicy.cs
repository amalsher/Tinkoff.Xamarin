using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']"
	[global::Android.Runtime.Register ("com/google/gson/FieldNamingPolicy", DoNotGenerateAcw=true)]
	public abstract partial class FieldNamingPolicy : global::Java.Lang.Enum, global::Com.Google.Gson.IFieldNamingStrategy {


		static IntPtr IDENTITY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='IDENTITY']"
		[Register ("IDENTITY")]
		public static global::Com.Google.Gson.FieldNamingPolicy Identity {
			get {
				if (IDENTITY_jfieldId == IntPtr.Zero)
					IDENTITY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IDENTITY", "Lcom/google/gson/FieldNamingPolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IDENTITY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOWER_CASE_WITH_DASHES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='LOWER_CASE_WITH_DASHES']"
		[Register ("LOWER_CASE_WITH_DASHES")]
		public static global::Com.Google.Gson.FieldNamingPolicy LowerCaseWithDashes {
			get {
				if (LOWER_CASE_WITH_DASHES_jfieldId == IntPtr.Zero)
					LOWER_CASE_WITH_DASHES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWER_CASE_WITH_DASHES", "Lcom/google/gson/FieldNamingPolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWER_CASE_WITH_DASHES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOWER_CASE_WITH_UNDERSCORES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='LOWER_CASE_WITH_UNDERSCORES']"
		[Register ("LOWER_CASE_WITH_UNDERSCORES")]
		public static global::Com.Google.Gson.FieldNamingPolicy LowerCaseWithUnderscores {
			get {
				if (LOWER_CASE_WITH_UNDERSCORES_jfieldId == IntPtr.Zero)
					LOWER_CASE_WITH_UNDERSCORES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOWER_CASE_WITH_UNDERSCORES", "Lcom/google/gson/FieldNamingPolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOWER_CASE_WITH_UNDERSCORES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPPER_CAMEL_CASE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='UPPER_CAMEL_CASE']"
		[Register ("UPPER_CAMEL_CASE")]
		public static global::Com.Google.Gson.FieldNamingPolicy UpperCamelCase {
			get {
				if (UPPER_CAMEL_CASE_jfieldId == IntPtr.Zero)
					UPPER_CAMEL_CASE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPPER_CAMEL_CASE", "Lcom/google/gson/FieldNamingPolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPPER_CAMEL_CASE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UPPER_CAMEL_CASE_WITH_SPACES_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/field[@name='UPPER_CAMEL_CASE_WITH_SPACES']"
		[Register ("UPPER_CAMEL_CASE_WITH_SPACES")]
		public static global::Com.Google.Gson.FieldNamingPolicy UpperCamelCaseWithSpaces {
			get {
				if (UPPER_CAMEL_CASE_WITH_SPACES_jfieldId == IntPtr.Zero)
					UPPER_CAMEL_CASE_WITH_SPACES_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPPER_CAMEL_CASE_WITH_SPACES", "Lcom/google/gson/FieldNamingPolicy;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPPER_CAMEL_CASE_WITH_SPACES_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/FieldNamingPolicy", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FieldNamingPolicy); }
		}

		protected FieldNamingPolicy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/google/gson/FieldNamingPolicy;", "")]
		public static unsafe global::Com.Google.Gson.FieldNamingPolicy ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/google/gson/FieldNamingPolicy;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.FieldNamingPolicy __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldNamingPolicy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/google/gson/FieldNamingPolicy;", "")]
		public static unsafe global::Com.Google.Gson.FieldNamingPolicy[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/google/gson/FieldNamingPolicy;");
			try {
				return (global::Com.Google.Gson.FieldNamingPolicy[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Google.Gson.FieldNamingPolicy));
			} finally {
			}
		}

		static Delegate cb_translateName_Ljava_lang_reflect_Field_;
#pragma warning disable 0169
		static Delegate GetTranslateName_Ljava_lang_reflect_Field_Handler ()
		{
			if (cb_translateName_Ljava_lang_reflect_Field_ == null)
				cb_translateName_Ljava_lang_reflect_Field_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TranslateName_Ljava_lang_reflect_Field_);
			return cb_translateName_Ljava_lang_reflect_Field_;
		}

		static IntPtr n_TranslateName_Ljava_lang_reflect_Field_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.FieldNamingPolicy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldNamingPolicy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.Field p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.TranslateName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='FieldNamingStrategy']/method[@name='translateName' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("translateName", "(Ljava/lang/reflect/Field;)Ljava/lang/String;", "GetTranslateName_Ljava_lang_reflect_Field_Handler")]
		public abstract string TranslateName (global::Java.Lang.Reflect.Field p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/FieldNamingPolicy", DoNotGenerateAcw=true)]
	internal partial class FieldNamingPolicyInvoker : FieldNamingPolicy {

		public FieldNamingPolicyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (FieldNamingPolicyInvoker); }
		}

		static IntPtr id_translateName_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='FieldNamingStrategy']/method[@name='translateName' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("translateName", "(Ljava/lang/reflect/Field;)Ljava/lang/String;", "GetTranslateName_Ljava_lang_reflect_Field_Handler")]
		public override unsafe string TranslateName (global::Java.Lang.Reflect.Field p0)
		{
			if (id_translateName_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_translateName_Ljava_lang_reflect_Field_ = JNIEnv.GetMethodID (class_ref, "translateName", "(Ljava/lang/reflect/Field;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_translateName_Ljava_lang_reflect_Field_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
