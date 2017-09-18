using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonSerializer']"
	[Register ("com/google/gson/JsonSerializer", "", "Com.Google.Gson.IJsonSerializerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IJsonSerializer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonSerializer']/method[@name='serialize' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='java.lang.reflect.Type'] and parameter[3][@type='com.google.gson.JsonSerializationContext']]"
		[Register ("serialize", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_Handler:Com.Google.Gson.IJsonSerializerInvoker, Gson")]
		global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1, global::Com.Google.Gson.IJsonSerializationContext p2);

	}

	[global::Android.Runtime.Register ("com/google/gson/JsonSerializer", DoNotGenerateAcw=true)]
	internal class IJsonSerializerInvoker : global::Java.Lang.Object, IJsonSerializer {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/JsonSerializer");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJsonSerializerInvoker); }
		}

		IntPtr class_ref;

		public static IJsonSerializer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonSerializer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.JsonSerializer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonSerializerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_;
#pragma warning disable 0169
		static Delegate GetSerialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_Handler ()
		{
			if (cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ == null)
				cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_);
			return cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_;
		}

		static IntPtr n_Serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Google.Gson.IJsonSerializer __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IJsonSerializer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p1 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.IJsonSerializationContext p2 = (global::Com.Google.Gson.IJsonSerializationContext)global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IJsonSerializationContext> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Serialize (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_;
		public unsafe global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1, global::Com.Google.Gson.IJsonSerializationContext p2)
		{
			if (id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ == IntPtr.Zero)
				id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Ljava/lang/Object;Ljava/lang/reflect/Type;Lcom/google/gson/JsonSerializationContext;)Lcom/google/gson/JsonElement;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Lcom_google_gson_JsonSerializationContext_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
