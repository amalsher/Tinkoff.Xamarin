using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonDeserializer']"
	[Register ("com/google/gson/JsonDeserializer", "", "Com.Google.Gson.IJsonDeserializerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IJsonDeserializer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonDeserializer']/method[@name='deserialize' and count(parameter)=3 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.JsonDeserializationContext']]"
		[Register ("deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Ljava/lang/Object;", "GetDeserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_Handler:Com.Google.Gson.IJsonDeserializerInvoker, Gson")]
		global::Java.Lang.Object Deserialize (global::Com.Google.Gson.JsonElement p0, global::Java.Lang.Reflect.IType p1, global::Com.Google.Gson.IJsonDeserializationContext p2);

	}

	[global::Android.Runtime.Register ("com/google/gson/JsonDeserializer", DoNotGenerateAcw=true)]
	internal class IJsonDeserializerInvoker : global::Java.Lang.Object, IJsonDeserializer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/JsonDeserializer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJsonDeserializerInvoker); }
		}

		IntPtr class_ref;

		public static IJsonDeserializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonDeserializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.JsonDeserializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonDeserializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
#pragma warning disable 0169
		static Delegate GetDeserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_Handler ()
		{
			if (cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ == null)
				cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_);
			return cb_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
		}

		static IntPtr n_Deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Gson.IJsonDeserializer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IJsonDeserializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.JsonElement p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p1 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.IJsonDeserializationContext p2 = (global::Com.Google.Gson.IJsonDeserializationContext)global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IJsonDeserializationContext> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Deserialize (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_;
		public unsafe global::Java.Lang.Object Deserialize (global::Com.Google.Gson.JsonElement p0, global::Java.Lang.Reflect.IType p1, global::Com.Google.Gson.IJsonDeserializationContext p2)
		{
			if (id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ == IntPtr.Zero)
				id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_ = JNIEnv.GetMethodID (class_ref, "deserialize", "(Lcom/google/gson/JsonElement;Ljava/lang/reflect/Type;Lcom/google/gson/JsonDeserializationContext;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_deserialize_Lcom_google_gson_JsonElement_Ljava_lang_reflect_Type_Lcom_google_gson_JsonDeserializationContext_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
