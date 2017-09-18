using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']"
	[global::Android.Runtime.Register ("com/google/gson/GsonBuilder", DoNotGenerateAcw=true)]
	public sealed partial class GsonBuilder : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/GsonBuilder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GsonBuilder); }
		}

		internal GsonBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/constructor[@name='GsonBuilder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GsonBuilder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GsonBuilder)) {
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

		static IntPtr id_addDeserializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='addDeserializationExclusionStrategy' and count(parameter)=1 and parameter[1][@type='com.google.gson.ExclusionStrategy']]"
		[Register ("addDeserializationExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder AddDeserializationExclusionStrategy (global::Com.Google.Gson.IExclusionStrategy p0)
		{
			if (id_addDeserializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ == IntPtr.Zero)
				id_addDeserializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ = JNIEnv.GetMethodID (class_ref, "addDeserializationExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addDeserializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_addSerializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='addSerializationExclusionStrategy' and count(parameter)=1 and parameter[1][@type='com.google.gson.ExclusionStrategy']]"
		[Register ("addSerializationExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder AddSerializationExclusionStrategy (global::Com.Google.Gson.IExclusionStrategy p0)
		{
			if (id_addSerializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ == IntPtr.Zero)
				id_addSerializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ = JNIEnv.GetMethodID (class_ref, "addSerializationExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_addSerializationExclusionStrategy_Lcom_google_gson_ExclusionStrategy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/google/gson/Gson;", "")]
		public unsafe global::Com.Google.Gson.Gson Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()Lcom/google/gson/Gson;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_disableHtmlEscaping;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='disableHtmlEscaping' and count(parameter)=0]"
		[Register ("disableHtmlEscaping", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder DisableHtmlEscaping ()
		{
			if (id_disableHtmlEscaping == IntPtr.Zero)
				id_disableHtmlEscaping = JNIEnv.GetMethodID (class_ref, "disableHtmlEscaping", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableHtmlEscaping), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_disableInnerClassSerialization;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='disableInnerClassSerialization' and count(parameter)=0]"
		[Register ("disableInnerClassSerialization", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder DisableInnerClassSerialization ()
		{
			if (id_disableInnerClassSerialization == IntPtr.Zero)
				id_disableInnerClassSerialization = JNIEnv.GetMethodID (class_ref, "disableInnerClassSerialization", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableInnerClassSerialization), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_enableComplexMapKeySerialization;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='enableComplexMapKeySerialization' and count(parameter)=0]"
		[Register ("enableComplexMapKeySerialization", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder EnableComplexMapKeySerialization ()
		{
			if (id_enableComplexMapKeySerialization == IntPtr.Zero)
				id_enableComplexMapKeySerialization = JNIEnv.GetMethodID (class_ref, "enableComplexMapKeySerialization", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_enableComplexMapKeySerialization), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_excludeFieldsWithModifiers_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='excludeFieldsWithModifiers' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("excludeFieldsWithModifiers", "([I)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder ExcludeFieldsWithModifiers (params  int[] p0)
		{
			if (id_excludeFieldsWithModifiers_arrayI == IntPtr.Zero)
				id_excludeFieldsWithModifiers_arrayI = JNIEnv.GetMethodID (class_ref, "excludeFieldsWithModifiers", "([I)Lcom/google/gson/GsonBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_excludeFieldsWithModifiers_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_excludeFieldsWithoutExposeAnnotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='excludeFieldsWithoutExposeAnnotation' and count(parameter)=0]"
		[Register ("excludeFieldsWithoutExposeAnnotation", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder ExcludeFieldsWithoutExposeAnnotation ()
		{
			if (id_excludeFieldsWithoutExposeAnnotation == IntPtr.Zero)
				id_excludeFieldsWithoutExposeAnnotation = JNIEnv.GetMethodID (class_ref, "excludeFieldsWithoutExposeAnnotation", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_excludeFieldsWithoutExposeAnnotation), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_generateNonExecutableJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='generateNonExecutableJson' and count(parameter)=0]"
		[Register ("generateNonExecutableJson", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder GenerateNonExecutableJson ()
		{
			if (id_generateNonExecutableJson == IntPtr.Zero)
				id_generateNonExecutableJson = JNIEnv.GetMethodID (class_ref, "generateNonExecutableJson", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateNonExecutableJson), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_registerTypeAdapter_Ljava_lang_reflect_Type_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='registerTypeAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Type'] and parameter[2][@type='java.lang.Object']]"
		[Register ("registerTypeAdapter", "(Ljava/lang/reflect/Type;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder RegisterTypeAdapter (global::Java.Lang.Reflect.IType p0, global::Java.Lang.Object p1)
		{
			if (id_registerTypeAdapter_Ljava_lang_reflect_Type_Ljava_lang_Object_ == IntPtr.Zero)
				id_registerTypeAdapter_Ljava_lang_reflect_Type_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "registerTypeAdapter", "(Ljava/lang/reflect/Type;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_registerTypeAdapter_Ljava_lang_reflect_Type_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_registerTypeAdapterFactory_Lcom_google_gson_TypeAdapterFactory_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='registerTypeAdapterFactory' and count(parameter)=1 and parameter[1][@type='com.google.gson.TypeAdapterFactory']]"
		[Register ("registerTypeAdapterFactory", "(Lcom/google/gson/TypeAdapterFactory;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder RegisterTypeAdapterFactory (global::Com.Google.Gson.ITypeAdapterFactory p0)
		{
			if (id_registerTypeAdapterFactory_Lcom_google_gson_TypeAdapterFactory_ == IntPtr.Zero)
				id_registerTypeAdapterFactory_Lcom_google_gson_TypeAdapterFactory_ = JNIEnv.GetMethodID (class_ref, "registerTypeAdapterFactory", "(Lcom/google/gson/TypeAdapterFactory;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_registerTypeAdapterFactory_Lcom_google_gson_TypeAdapterFactory_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_registerTypeHierarchyAdapter_Ljava_lang_Class_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='registerTypeHierarchyAdapter' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='java.lang.Object']]"
		[Register ("registerTypeHierarchyAdapter", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder RegisterTypeHierarchyAdapter (global::Java.Lang.Class p0, global::Java.Lang.Object p1)
		{
			if (id_registerTypeHierarchyAdapter_Ljava_lang_Class_Ljava_lang_Object_ == IntPtr.Zero)
				id_registerTypeHierarchyAdapter_Ljava_lang_Class_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "registerTypeHierarchyAdapter", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_registerTypeHierarchyAdapter_Ljava_lang_Class_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_serializeNulls;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='serializeNulls' and count(parameter)=0]"
		[Register ("serializeNulls", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SerializeNulls ()
		{
			if (id_serializeNulls == IntPtr.Zero)
				id_serializeNulls = JNIEnv.GetMethodID (class_ref, "serializeNulls", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_serializeNulls), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_serializeSpecialFloatingPointValues;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='serializeSpecialFloatingPointValues' and count(parameter)=0]"
		[Register ("serializeSpecialFloatingPointValues", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SerializeSpecialFloatingPointValues ()
		{
			if (id_serializeSpecialFloatingPointValues == IntPtr.Zero)
				id_serializeSpecialFloatingPointValues = JNIEnv.GetMethodID (class_ref, "serializeSpecialFloatingPointValues", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_serializeSpecialFloatingPointValues), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setDateFormat_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setDateFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDateFormat", "(I)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetDateFormat (int p0)
		{
			if (id_setDateFormat_I == IntPtr.Zero)
				id_setDateFormat_I = JNIEnv.GetMethodID (class_ref, "setDateFormat", "(I)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDateFormat_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setDateFormat_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setDateFormat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDateFormat", "(II)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetDateFormat (int p0, int p1)
		{
			if (id_setDateFormat_II == IntPtr.Zero)
				id_setDateFormat_II = JNIEnv.GetMethodID (class_ref, "setDateFormat", "(II)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDateFormat_II, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setDateFormat_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setDateFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setDateFormat", "(Ljava/lang/String;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetDateFormat (string p0)
		{
			if (id_setDateFormat_Ljava_lang_String_ == IntPtr.Zero)
				id_setDateFormat_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDateFormat", "(Ljava/lang/String;)Lcom/google/gson/GsonBuilder;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setDateFormat_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_setExclusionStrategies_arrayLcom_google_gson_ExclusionStrategy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setExclusionStrategies' and count(parameter)=1 and parameter[1][@type='com.google.gson.ExclusionStrategy...']]"
		[Register ("setExclusionStrategies", "([Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetExclusionStrategies (params global:: Com.Google.Gson.IExclusionStrategy[] p0)
		{
			if (id_setExclusionStrategies_arrayLcom_google_gson_ExclusionStrategy_ == IntPtr.Zero)
				id_setExclusionStrategies_arrayLcom_google_gson_ExclusionStrategy_ = JNIEnv.GetMethodID (class_ref, "setExclusionStrategies", "([Lcom/google/gson/ExclusionStrategy;)Lcom/google/gson/GsonBuilder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setExclusionStrategies_arrayLcom_google_gson_ExclusionStrategy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_setFieldNamingPolicy_Lcom_google_gson_FieldNamingPolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setFieldNamingPolicy' and count(parameter)=1 and parameter[1][@type='com.google.gson.FieldNamingPolicy']]"
		[Register ("setFieldNamingPolicy", "(Lcom/google/gson/FieldNamingPolicy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetFieldNamingPolicy (global::Com.Google.Gson.FieldNamingPolicy p0)
		{
			if (id_setFieldNamingPolicy_Lcom_google_gson_FieldNamingPolicy_ == IntPtr.Zero)
				id_setFieldNamingPolicy_Lcom_google_gson_FieldNamingPolicy_ = JNIEnv.GetMethodID (class_ref, "setFieldNamingPolicy", "(Lcom/google/gson/FieldNamingPolicy;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFieldNamingPolicy_Lcom_google_gson_FieldNamingPolicy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setFieldNamingStrategy_Lcom_google_gson_FieldNamingStrategy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setFieldNamingStrategy' and count(parameter)=1 and parameter[1][@type='com.google.gson.FieldNamingStrategy']]"
		[Register ("setFieldNamingStrategy", "(Lcom/google/gson/FieldNamingStrategy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetFieldNamingStrategy (global::Com.Google.Gson.IFieldNamingStrategy p0)
		{
			if (id_setFieldNamingStrategy_Lcom_google_gson_FieldNamingStrategy_ == IntPtr.Zero)
				id_setFieldNamingStrategy_Lcom_google_gson_FieldNamingStrategy_ = JNIEnv.GetMethodID (class_ref, "setFieldNamingStrategy", "(Lcom/google/gson/FieldNamingStrategy;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setFieldNamingStrategy_Lcom_google_gson_FieldNamingStrategy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setLongSerializationPolicy_Lcom_google_gson_LongSerializationPolicy_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setLongSerializationPolicy' and count(parameter)=1 and parameter[1][@type='com.google.gson.LongSerializationPolicy']]"
		[Register ("setLongSerializationPolicy", "(Lcom/google/gson/LongSerializationPolicy;)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetLongSerializationPolicy (global::Com.Google.Gson.LongSerializationPolicy p0)
		{
			if (id_setLongSerializationPolicy_Lcom_google_gson_LongSerializationPolicy_ == IntPtr.Zero)
				id_setLongSerializationPolicy_Lcom_google_gson_LongSerializationPolicy_ = JNIEnv.GetMethodID (class_ref, "setLongSerializationPolicy", "(Lcom/google/gson/LongSerializationPolicy;)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.GsonBuilder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setLongSerializationPolicy_Lcom_google_gson_LongSerializationPolicy_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_setPrettyPrinting;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setPrettyPrinting' and count(parameter)=0]"
		[Register ("setPrettyPrinting", "()Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetPrettyPrinting ()
		{
			if (id_setPrettyPrinting == IntPtr.Zero)
				id_setPrettyPrinting = JNIEnv.GetMethodID (class_ref, "setPrettyPrinting", "()Lcom/google/gson/GsonBuilder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setPrettyPrinting), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_setVersion_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='GsonBuilder']/method[@name='setVersion' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("setVersion", "(D)Lcom/google/gson/GsonBuilder;", "")]
		public unsafe global::Com.Google.Gson.GsonBuilder SetVersion (double p0)
		{
			if (id_setVersion_D == IntPtr.Zero)
				id_setVersion_D = JNIEnv.GetMethodID (class_ref, "setVersion", "(D)Lcom/google/gson/GsonBuilder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.GsonBuilder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_setVersion_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
