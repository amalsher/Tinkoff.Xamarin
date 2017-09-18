using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='ConstructorConstructor']"
	[global::Android.Runtime.Register ("com/google/gson/internal/ConstructorConstructor", DoNotGenerateAcw=true)]
	public sealed partial class ConstructorConstructor : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/ConstructorConstructor", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ConstructorConstructor); }
		}

		internal ConstructorConstructor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_util_Map_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='ConstructorConstructor']/constructor[@name='ConstructorConstructor' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.reflect.Type, com.google.gson.InstanceCreator&lt;?&gt;&gt;']]"
		[Register (".ctor", "(Ljava/util/Map;)V", "")]
		public unsafe ConstructorConstructor (global::System.Collections.Generic.IDictionary<global::Java.Lang.Reflect.IType, global::Com.Google.Gson.IInstanceCreator> p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<global::Java.Lang.Reflect.IType, global::Com.Google.Gson.IInstanceCreator>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (ConstructorConstructor)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/Map;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/Map;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_Map_ == IntPtr.Zero)
					id_ctor_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/Map;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_Map_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_Map_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_get_Lcom_google_gson_reflect_TypeToken_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='ConstructorConstructor']/method[@name='get' and count(parameter)=1 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("get", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/internal/ObjectConstructor;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Com.Google.Gson.Internal.IObjectConstructor Get (global::Com.Google.Gson.Reflect.TypeToken p0)
		{
			if (id_get_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_get_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "get", "(Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/internal/ObjectConstructor;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.Internal.IObjectConstructor __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.IObjectConstructor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
