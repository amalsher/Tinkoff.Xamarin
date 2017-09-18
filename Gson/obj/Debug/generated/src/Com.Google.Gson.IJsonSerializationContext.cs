using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonSerializationContext']"
	[Register ("com/google/gson/JsonSerializationContext", "", "Com.Google.Gson.IJsonSerializationContextInvoker")]
	public partial interface IJsonSerializationContext : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonSerializationContext']/method[@name='serialize' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("serialize", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_lang_Object_Handler:Com.Google.Gson.IJsonSerializationContextInvoker, Gson")]
		global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='JsonSerializationContext']/method[@name='serialize' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.reflect.Type']]"
		[Register ("serialize", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;", "GetSerialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Handler:Com.Google.Gson.IJsonSerializationContextInvoker, Gson")]
		global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1);

	}

	[global::Android.Runtime.Register ("com/google/gson/JsonSerializationContext", DoNotGenerateAcw=true)]
	internal class IJsonSerializationContextInvoker : global::Java.Lang.Object, IJsonSerializationContext {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/JsonSerializationContext");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IJsonSerializationContextInvoker); }
		}

		IntPtr class_ref;

		public static IJsonSerializationContext GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IJsonSerializationContext> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.JsonSerializationContext"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IJsonSerializationContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_serialize_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSerialize_Ljava_lang_Object_Handler ()
		{
			if (cb_serialize_Ljava_lang_Object_ == null)
				cb_serialize_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Serialize_Ljava_lang_Object_);
			return cb_serialize_Ljava_lang_Object_;
		}

		static IntPtr n_Serialize_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.IJsonSerializationContext __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IJsonSerializationContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Serialize (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_serialize_Ljava_lang_Object_;
		public unsafe global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Object p0)
		{
			if (id_serialize_Ljava_lang_Object_ == IntPtr.Zero)
				id_serialize_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Ljava/lang/Object;)Lcom/google/gson/JsonElement;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_serialize_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_;
#pragma warning disable 0169
		static Delegate GetSerialize_Ljava_lang_Object_Ljava_lang_reflect_Type_Handler ()
		{
			if (cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_ == null)
				cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_);
			return cb_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		}

		static IntPtr n_Serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Google.Gson.IJsonSerializationContext __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IJsonSerializationContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p1 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Serialize (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_;
		public unsafe global::Com.Google.Gson.JsonElement Serialize (global::Java.Lang.Object p0, global::Java.Lang.Reflect.IType p1)
		{
			if (id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "serialize", "(Ljava/lang/Object;Ljava/lang/reflect/Type;)Lcom/google/gson/JsonElement;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_serialize_Ljava_lang_Object_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
