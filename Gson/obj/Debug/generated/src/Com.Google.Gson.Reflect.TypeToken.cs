using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Reflect {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']"
	[global::Android.Runtime.Register ("com/google/gson/reflect/TypeToken", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class TypeToken : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/reflect/TypeToken", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypeToken); }
		}

		protected TypeToken (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/constructor[@name='TypeToken' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe TypeToken ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (TypeToken)) {
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

		static IntPtr id_getRawType;
		public unsafe global::Java.Lang.Class RawType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='getRawType' and count(parameter)=0]"
			[Register ("getRawType", "()Ljava/lang/Class;", "GetGetRawTypeHandler")]
			get {
				if (id_getRawType == IntPtr.Zero)
					id_getRawType = JNIEnv.GetMethodID (class_ref, "getRawType", "()Ljava/lang/Class;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRawType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getType;
		public unsafe global::Java.Lang.Reflect.IType Type {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='getType' and count(parameter)=0]"
			[Register ("getType", "()Ljava/lang/reflect/Type;", "GetGetTypeHandler")]
			get {
				if (id_getType == IntPtr.Zero)
					id_getType = JNIEnv.GetMethodID (class_ref, "getType", "()Ljava/lang/reflect/Type;");
				try {
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getType), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_equals_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;)Z", "")]
		public override sealed unsafe bool Equals (global::Java.Lang.Object p0)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("get", "(Ljava/lang/Class;)Lcom/google/gson/reflect/TypeToken;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Google.Gson.Reflect.TypeToken Get (global::Java.Lang.Class p0)
		{
			if (id_get_Ljava_lang_Class_ == IntPtr.Zero)
				id_get_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/Class;)Lcom/google/gson/reflect/TypeToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.Reflect.TypeToken __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_get_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='get' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("get", "(Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;", "")]
		public static unsafe global::Com.Google.Gson.Reflect.TypeToken Get (global::Java.Lang.Reflect.IType p0)
		{
			if (id_get_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_get_Ljava_lang_reflect_Type_ = JNIEnv.GetStaticMethodID (class_ref, "get", "(Ljava/lang/reflect/Type;)Lcom/google/gson/reflect/TypeToken;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.Reflect.TypeToken __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (JNIEnv.CallStaticObjectMethod  (class_ref, id_get_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_hashCode;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='hashCode' and count(parameter)=0]"
		[Register ("hashCode", "()I", "")]
		public override sealed unsafe int GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			} finally {
			}
		}

		static Delegate cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_;
#pragma warning disable 0169
		static Delegate GetIsAssignableFrom_Lcom_google_gson_reflect_TypeToken_Handler ()
		{
			if (cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_ == null)
				cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAssignableFrom_Lcom_google_gson_reflect_TypeToken_);
			return cb_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_;
		}

		static bool n_IsAssignableFrom_Lcom_google_gson_reflect_TypeToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Reflect.TypeToken __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Reflect.TypeToken p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAssignableFrom (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='isAssignableFrom' and count(parameter)=1 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;?&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("isAssignableFrom", "(Lcom/google/gson/reflect/TypeToken;)Z", "GetIsAssignableFrom_Lcom_google_gson_reflect_TypeToken_Handler")]
		public virtual unsafe bool IsAssignableFrom (global::Com.Google.Gson.Reflect.TypeToken p0)
		{
			if (id_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "isAssignableFrom", "(Lcom/google/gson/reflect/TypeToken;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAssignableFrom_Lcom_google_gson_reflect_TypeToken_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAssignableFrom", "(Lcom/google/gson/reflect/TypeToken;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isAssignableFrom_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetIsAssignableFrom_Ljava_lang_Class_Handler ()
		{
			if (cb_isAssignableFrom_Ljava_lang_Class_ == null)
				cb_isAssignableFrom_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAssignableFrom_Ljava_lang_Class_);
			return cb_isAssignableFrom_Ljava_lang_Class_;
		}

		static bool n_IsAssignableFrom_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Reflect.TypeToken __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAssignableFrom (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isAssignableFrom_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='isAssignableFrom' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("isAssignableFrom", "(Ljava/lang/Class;)Z", "GetIsAssignableFrom_Ljava_lang_Class_Handler")]
		public virtual unsafe bool IsAssignableFrom (global::Java.Lang.Class p0)
		{
			if (id_isAssignableFrom_Ljava_lang_Class_ == IntPtr.Zero)
				id_isAssignableFrom_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "isAssignableFrom", "(Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAssignableFrom_Ljava_lang_Class_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAssignableFrom", "(Ljava/lang/Class;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_isAssignableFrom_Ljava_lang_reflect_Type_;
#pragma warning disable 0169
		static Delegate GetIsAssignableFrom_Ljava_lang_reflect_Type_Handler ()
		{
			if (cb_isAssignableFrom_Ljava_lang_reflect_Type_ == null)
				cb_isAssignableFrom_Ljava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAssignableFrom_Ljava_lang_reflect_Type_);
			return cb_isAssignableFrom_Ljava_lang_reflect_Type_;
		}

		static bool n_IsAssignableFrom_Ljava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Reflect.TypeToken __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p0 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAssignableFrom (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_isAssignableFrom_Ljava_lang_reflect_Type_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='isAssignableFrom' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Obsolete (@"deprecated")]
		[Register ("isAssignableFrom", "(Ljava/lang/reflect/Type;)Z", "GetIsAssignableFrom_Ljava_lang_reflect_Type_Handler")]
		public virtual unsafe bool IsAssignableFrom (global::Java.Lang.Reflect.IType p0)
		{
			if (id_isAssignableFrom_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_isAssignableFrom_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "isAssignableFrom", "(Ljava/lang/reflect/Type;)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAssignableFrom_Ljava_lang_reflect_Type_, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAssignableFrom", "(Ljava/lang/reflect/Type;)Z"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_toString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.reflect']/class[@name='TypeToken']/method[@name='toString' and count(parameter)=0]"
		[Register ("toString", "()Ljava/lang/String;", "")]
		public override sealed unsafe string ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
