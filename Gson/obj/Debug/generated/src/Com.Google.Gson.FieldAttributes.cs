using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']"
	[global::Android.Runtime.Register ("com/google/gson/FieldAttributes", DoNotGenerateAcw=true)]
	public sealed partial class FieldAttributes : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/FieldAttributes", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FieldAttributes); }
		}

		internal FieldAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_reflect_Field_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/constructor[@name='FieldAttributes' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register (".ctor", "(Ljava/lang/reflect/Field;)V", "")]
		public unsafe FieldAttributes (global::Java.Lang.Reflect.Field p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (FieldAttributes)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/reflect/Field;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/reflect/Field;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_reflect_Field_ == IntPtr.Zero)
					id_ctor_Ljava_lang_reflect_Field_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/reflect/Field;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_reflect_Field_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_reflect_Field_, __args);
			} finally {
			}
		}

		static IntPtr id_getAnnotations;
		public unsafe global::System.Collections.Generic.ICollection<global::Java.Lang.Annotation.IAnnotation> Annotations {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getAnnotations' and count(parameter)=0]"
			[Register ("getAnnotations", "()Ljava/util/Collection;", "GetGetAnnotationsHandler")]
			get {
				if (id_getAnnotations == IntPtr.Zero)
					id_getAnnotations = JNIEnv.GetMethodID (class_ref, "getAnnotations", "()Ljava/util/Collection;");
				try {
					return global::Android.Runtime.JavaCollection<global::Java.Lang.Annotation.IAnnotation>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotations), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeclaredClass;
		public unsafe global::Java.Lang.Class DeclaredClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getDeclaredClass' and count(parameter)=0]"
			[Register ("getDeclaredClass", "()Ljava/lang/Class;", "GetGetDeclaredClassHandler")]
			get {
				if (id_getDeclaredClass == IntPtr.Zero)
					id_getDeclaredClass = JNIEnv.GetMethodID (class_ref, "getDeclaredClass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredClass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeclaredType;
		public unsafe global::Java.Lang.Reflect.IType DeclaredType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getDeclaredType' and count(parameter)=0]"
			[Register ("getDeclaredType", "()Ljava/lang/reflect/Type;", "GetGetDeclaredTypeHandler")]
			get {
				if (id_getDeclaredType == IntPtr.Zero)
					id_getDeclaredType = JNIEnv.GetMethodID (class_ref, "getDeclaredType", "()Ljava/lang/reflect/Type;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaredType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getDeclaringClass;
		public unsafe global::Java.Lang.Class DeclaringClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getDeclaringClass' and count(parameter)=0]"
			[Register ("getDeclaringClass", "()Ljava/lang/Class;", "GetGetDeclaringClassHandler")]
			get {
				if (id_getDeclaringClass == IntPtr.Zero)
					id_getDeclaringClass = JNIEnv.GetMethodID (class_ref, "getDeclaringClass", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeclaringClass), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getName;
		public unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				if (id_getName == IntPtr.Zero)
					id_getName = JNIEnv.GetMethodID (class_ref, "getName", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getName), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getAnnotation_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='getAnnotation' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.annotation.Annotation"})]
		public unsafe global::Java.Lang.Object GetAnnotation (global::Java.Lang.Class p0)
		{
			if (id_getAnnotation_Ljava_lang_Class_ == IntPtr.Zero)
				id_getAnnotation_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAnnotation_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hasModifier_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='FieldAttributes']/method[@name='hasModifier' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("hasModifier", "(I)Z", "")]
		public unsafe bool HasModifier (int p0)
		{
			if (id_hasModifier_I == IntPtr.Zero)
				id_hasModifier_I = JNIEnv.GetMethodID (class_ref, "hasModifier", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasModifier_I, __args);
			} finally {
			}
		}

	}
}
