using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']"
	[global::Android.Runtime.Register ("com/google/gson/internal/Primitives", DoNotGenerateAcw=true)]
	public sealed partial class Primitives : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/Primitives", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Primitives); }
		}

		internal Primitives (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isPrimitive_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='isPrimitive' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("isPrimitive", "(Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool IsPrimitive (global::Java.Lang.Reflect.IType p0)
		{
			if (id_isPrimitive_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_isPrimitive_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "isPrimitive", "(Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPrimitive_Ljava_lang_reflect_Type_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_isWrapperType_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='isWrapperType' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("isWrapperType", "(Ljava/lang/reflect/Type;)Z", "")]
		public static unsafe bool IsWrapperType (global::Java.Lang.Reflect.IType p0)
		{
			if (id_isWrapperType_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_isWrapperType_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "isWrapperType", "(Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_isWrapperType_Ljava_lang_reflect_Type_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_unwrap_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='unwrap' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("unwrap", "(Ljava/lang/Class;)Ljava/lang/Class;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Class Unwrap (global::Java.Lang.Class p0)
		{
			if (id_unwrap_Ljava_lang_Class_ == IntPtr.Zero)
				id_unwrap_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "unwrap", "(Ljava/lang/Class;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_unwrap_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_wrap_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Primitives']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("wrap", "(Ljava/lang/Class;)Ljava/lang/Class;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Class Wrap (global::Java.Lang.Class p0)
		{
			if (id_wrap_Ljava_lang_Class_ == IntPtr.Zero)
				id_wrap_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "wrap", "(Ljava/lang/Class;)Ljava/lang/Class;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Class __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallStaticObjectMethod  (class_ref, id_wrap_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
