using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Annotations {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson.annotations']/interface[@name='Expose']"
	[Register ("com/google/gson/annotations/Expose", "", "Com.Google.Gson.Annotations.IExposeInvoker")]
	public partial interface IExpose : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.annotations']/interface[@name='Expose']/method[@name='deserialize' and count(parameter)=0]"
		[Register ("deserialize", "()Z", "GetDeserializeHandler:Com.Google.Gson.Annotations.IExposeInvoker, Gson")]
		bool Deserialize ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.annotations']/interface[@name='Expose']/method[@name='serialize' and count(parameter)=0]"
		[Register ("serialize", "()Z", "GetSerializeHandler:Com.Google.Gson.Annotations.IExposeInvoker, Gson")]
		bool Serialize ();

	}

	[global::Android.Runtime.Register ("com/google/gson/annotations/Expose", DoNotGenerateAcw=true)]
	internal class IExposeInvoker : global::Java.Lang.Object, IExpose {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/annotations/Expose");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IExposeInvoker); }
		}

		IntPtr class_ref;

		public static IExpose GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExpose> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.annotations.Expose"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExposeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_deserialize;
#pragma warning disable 0169
		static Delegate GetDeserializeHandler ()
		{
			if (cb_deserialize == null)
				cb_deserialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Deserialize);
			return cb_deserialize;
		}

		static bool n_Deserialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Annotations.IExpose __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Annotations.IExpose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Deserialize ();
		}
#pragma warning restore 0169

		IntPtr id_deserialize;
		public unsafe bool Deserialize ()
		{
			if (id_deserialize == IntPtr.Zero)
				id_deserialize = JNIEnv.GetMethodID (class_ref, "deserialize", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_deserialize);
		}

		static Delegate cb_serialize;
#pragma warning disable 0169
		static Delegate GetSerializeHandler ()
		{
			if (cb_serialize == null)
				cb_serialize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Serialize);
			return cb_serialize;
		}

		static bool n_Serialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Annotations.IExpose __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Annotations.IExpose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Serialize ();
		}
#pragma warning restore 0169

		IntPtr id_serialize;
		public unsafe bool Serialize ()
		{
			if (id_serialize == IntPtr.Zero)
				id_serialize = JNIEnv.GetMethodID (class_ref, "serialize", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_serialize);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Annotations.IExpose __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Annotations.IExpose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Com.Google.Gson.Annotations.IExpose __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Annotations.IExpose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (obj);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Annotations.IExpose __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Annotations.IExpose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Annotations.IExpose __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Annotations.IExpose> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
