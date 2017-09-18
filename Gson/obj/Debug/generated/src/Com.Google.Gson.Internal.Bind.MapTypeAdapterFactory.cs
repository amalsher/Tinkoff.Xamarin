using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='MapTypeAdapterFactory']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/MapTypeAdapterFactory", DoNotGenerateAcw=true)]
	public sealed partial class MapTypeAdapterFactory : global::Java.Lang.Object, global::Com.Google.Gson.ITypeAdapterFactory {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/MapTypeAdapterFactory", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MapTypeAdapterFactory); }
		}

		internal MapTypeAdapterFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Z;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='MapTypeAdapterFactory']/constructor[@name='MapTypeAdapterFactory' and count(parameter)=2 and parameter[1][@type='com.google.gson.internal.ConstructorConstructor'] and parameter[2][@type='boolean']]"
		[Register (".ctor", "(Lcom/google/gson/internal/ConstructorConstructor;Z)V", "")]
		public unsafe MapTypeAdapterFactory (global::Com.Google.Gson.Internal.ConstructorConstructor p0, bool p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (MapTypeAdapterFactory)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/google/gson/internal/ConstructorConstructor;Z)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/google/gson/internal/ConstructorConstructor;Z)V", __args);
					return;
				}

				if (id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Z == IntPtr.Zero)
					id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Z = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/google/gson/internal/ConstructorConstructor;Z)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Z, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_google_gson_internal_ConstructorConstructor_Z, __args);
			} finally {
			}
		}

		static IntPtr id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='MapTypeAdapterFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
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

	}
}
