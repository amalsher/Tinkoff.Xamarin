using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonDeserializationContext']"
	[Register ("com/google/gson/JsonDeserializationContext", "", "Com.Google.Gson.IJsonDeserializationContextInvoker")]
	public partial interface IJsonDeserializationContext : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonDeserializationContext']/method[@name='deserialize' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;", "GetDeserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Handler:Com.Google.Gson.IJsonDeserializationContextInvoker, Gson")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		global::Java.Lang.Object Deserialize (global::Com.Google.Gson.JsonElement p0, global::Java.Lang.Reflect.IType p1);

	}

	[global::Android.Runtime.Register ("com/google/gson/JsonDeserializationContext", DoNotGenerateAcw=true)]
	internal class IJsonDeserializationContextInvoker : global::Java.Lang.Object, IJsonDeserializationContext {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/JsonDeserializationContext");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJsonDeserializationContextInvoker); }
		}

		IntPtr class_ref;

		public static IJsonDeserializationContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonDeserializationContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.JsonDeserializationContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonDeserializationContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_;
#pragma warning disable 0169
		static Delegate GetDeserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Handler ()
		{
			if (cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ == null)
				cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_);
			return cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_;
		}

		static IntPtr n_Deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Gson.IJsonDeserializationContext __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IJsonDeserializationContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.JsonElement p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p1 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Deserialize (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_;
		public unsafe global::Java.Lang.Object Deserialize (global::Com.Google.Gson.JsonElement p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
