using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']"
	[global::Android.Runtime.Register ("com/google/gson/internal/Excluder", DoNotGenerateAcw=true)]
	public sealed partial class Excluder : global::Java.Lang.Object, global::Com.Google.Gson.ITypeAdapterFactory, global::Java.Lang.ICloneable {


		static IntPtr DEFAULT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/field[@name='DEFAULT']"
		[Register ("DEFAULT")]
		public static global::Com.Google.Gson.Internal.Excluder Default {
			get {
				if (DEFAULT_jfieldId == IntPtr.Zero)
					DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/google/gson/internal/Excluder;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/Excluder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Excluder); }
		}

		internal Excluder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/constructor[@name='Excluder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Excluder ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Excluder)) {
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

		static IntPtr id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.TypeAdapter Create (global::Com.Google.Gson.Gson p0, global::Com.Google.Gson.Reflect.TypeToken p1)
		{
			if (id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_disableInnerClassSerialization;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='disableInnerClassSerialization' and count(parameter)=0]"
		[Register ("disableInnerClassSerialization", "()Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder DisableInnerClassSerialization ()
		{
			if (id_disableInnerClassSerialization == IntPtr.Zero)
				id_disableInnerClassSerialization = JNIEnv.GetMethodID (class_ref, "disableInnerClassSerialization", "()Lcom/google/gson/internal/Excluder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_disableInnerClassSerialization), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_excludeClass_Ljava_lang_Class_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='excludeClass' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;?&gt;'] and parameter[2][@type='boolean']]"
		[Register ("excludeClass", "(Ljava/lang/Class;Z)Z", "")]
		public unsafe bool ExcludeClass (global::Java.Lang.Class p0, bool p1)
		{
			if (id_excludeClass_Ljava_lang_Class_Z == IntPtr.Zero)
				id_excludeClass_Ljava_lang_Class_Z = JNIEnv.GetMethodID (class_ref, "excludeClass", "(Ljava/lang/Class;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_excludeClass_Ljava_lang_Class_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_excludeField_Ljava_lang_reflect_Field_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='excludeField' and count(parameter)=2 and parameter[1][@type='java.lang.reflect.Field'] and parameter[2][@type='boolean']]"
		[Register ("excludeField", "(Ljava/lang/reflect/Field;Z)Z", "")]
		public unsafe bool ExcludeField (global::Java.Lang.Reflect.Field p0, bool p1)
		{
			if (id_excludeField_Ljava_lang_reflect_Field_Z == IntPtr.Zero)
				id_excludeField_Ljava_lang_reflect_Field_Z = JNIEnv.GetMethodID (class_ref, "excludeField", "(Ljava/lang/reflect/Field;Z)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_excludeField_Ljava_lang_reflect_Field_Z, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_excludeFieldsWithoutExposeAnnotation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='excludeFieldsWithoutExposeAnnotation' and count(parameter)=0]"
		[Register ("excludeFieldsWithoutExposeAnnotation", "()Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder ExcludeFieldsWithoutExposeAnnotation ()
		{
			if (id_excludeFieldsWithoutExposeAnnotation == IntPtr.Zero)
				id_excludeFieldsWithoutExposeAnnotation = JNIEnv.GetMethodID (class_ref, "excludeFieldsWithoutExposeAnnotation", "()Lcom/google/gson/internal/Excluder;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_excludeFieldsWithoutExposeAnnotation), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_withExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='withExclusionStrategy' and count(parameter)=3 and parameter[1][@type='com.google.gson.ExclusionStrategy'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("withExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;ZZ)Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder WithExclusionStrategy (global::Com.Google.Gson.IExclusionStrategy p0, bool p1, bool p2)
		{
			if (id_withExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ZZ == IntPtr.Zero)
				id_withExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ZZ = JNIEnv.GetMethodID (class_ref, "withExclusionStrategy", "(Lcom/google/gson/ExclusionStrategy;ZZ)Lcom/google/gson/internal/Excluder;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Gson.Internal.Excluder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withExclusionStrategy_Lcom_google_gson_ExclusionStrategy_ZZ, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_withModifiers_arrayI;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='withModifiers' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("withModifiers", "([I)Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder WithModifiers (params  int[] p0)
		{
			if (id_withModifiers_arrayI == IntPtr.Zero)
				id_withModifiers_arrayI = JNIEnv.GetMethodID (class_ref, "withModifiers", "([I)Lcom/google/gson/internal/Excluder;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Google.Gson.Internal.Excluder __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withModifiers_arrayI, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_withVersion_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Excluder']/method[@name='withVersion' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("withVersion", "(D)Lcom/google/gson/internal/Excluder;", "")]
		public unsafe global::Com.Google.Gson.Internal.Excluder WithVersion (double p0)
		{
			if (id_withVersion_D == IntPtr.Zero)
				id_withVersion_D = JNIEnv.GetMethodID (class_ref, "withVersion", "(D)Lcom/google/gson/internal/Excluder;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Excluder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_withVersion_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
