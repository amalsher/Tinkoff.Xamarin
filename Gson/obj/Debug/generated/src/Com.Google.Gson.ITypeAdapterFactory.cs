using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='TypeAdapterFactory']"
	[Register ("com/google/gson/TypeAdapterFactory", "", "Com.Google.Gson.ITypeAdapterFactoryInvoker")]
	public partial interface ITypeAdapterFactory : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='TypeAdapterFactory']/method[@name='create' and count(parameter)=2 and parameter[1][@type='com.google.gson.Gson'] and parameter[2][@type='com.google.gson.reflect.TypeToken&lt;T&gt;']]"
		[Register ("create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;", "GetCreate_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Handler:Com.Google.Gson.ITypeAdapterFactoryInvoker, Gson")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Com.Google.Gson.TypeAdapter Create (global::Com.Google.Gson.Gson p0, global::Com.Google.Gson.Reflect.TypeToken p1);

	}

	[global::Android.Runtime.Register ("com/google/gson/TypeAdapterFactory", DoNotGenerateAcw=true)]
	internal class ITypeAdapterFactoryInvoker : global::Java.Lang.Object, ITypeAdapterFactory {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/TypeAdapterFactory");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ITypeAdapterFactoryInvoker); }
		}

		IntPtr class_ref;

		public static ITypeAdapterFactory GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITypeAdapterFactory> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.TypeAdapterFactory"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITypeAdapterFactoryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
#pragma warning disable 0169
		static Delegate GetCreate_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_Handler ()
		{
			if (cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ == null)
				cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_);
			return cb_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
		}

		static IntPtr n_Create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Gson.ITypeAdapterFactory __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Gson p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Gson> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.Reflect.TypeToken p1 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Reflect.TypeToken> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Create (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_;
		public unsafe global::Com.Google.Gson.TypeAdapter Create (global::Com.Google.Gson.Gson p0, global::Com.Google.Gson.Reflect.TypeToken p1)
		{
			if (id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ == IntPtr.Zero)
				id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_ = JNIEnv.GetMethodID (class_ref, "create", "(Lcom/google/gson/Gson;Lcom/google/gson/reflect/TypeToken;)Lcom/google/gson/TypeAdapter;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Com.Google.Gson.TypeAdapter __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create_Lcom_google_gson_Gson_Lcom_google_gson_reflect_TypeToken_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
