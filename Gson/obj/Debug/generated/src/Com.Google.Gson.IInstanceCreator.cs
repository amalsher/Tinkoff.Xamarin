using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='InstanceCreator']"
	[Register ("com/google/gson/InstanceCreator", "", "Com.Google.Gson.IInstanceCreatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IInstanceCreator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='InstanceCreator']/method[@name='createInstance' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Type']]"
		[Register ("createInstance", "(Ljava/lang/reflect/Type;)Ljava/lang/Object;", "GetCreateInstance_Ljava_lang_reflect_Type_Handler:Com.Google.Gson.IInstanceCreatorInvoker, Gson")]
		global::Java.Lang.Object CreateInstance (global::Java.Lang.Reflect.IType p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/InstanceCreator", DoNotGenerateAcw=true)]
	internal class IInstanceCreatorInvoker : global::Java.Lang.Object, IInstanceCreator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/InstanceCreator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IInstanceCreatorInvoker); }
		}

		IntPtr class_ref;

		public static IInstanceCreator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInstanceCreator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.InstanceCreator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInstanceCreatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_createInstance_Ljava_lang_reflect_Type_;
#pragma warning disable 0169
		static Delegate GetCreateInstance_Ljava_lang_reflect_Type_Handler ()
		{
			if (cb_createInstance_Ljava_lang_reflect_Type_ == null)
				cb_createInstance_Ljava_lang_reflect_Type_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateInstance_Ljava_lang_reflect_Type_);
			return cb_createInstance_Ljava_lang_reflect_Type_;
		}

		static IntPtr n_CreateInstance_Ljava_lang_reflect_Type_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.IInstanceCreator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IInstanceCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.IType p0 = (global::Java.Lang.Reflect.IType)global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.IType> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_createInstance_Ljava_lang_reflect_Type_;
		public unsafe global::Java.Lang.Object CreateInstance (global::Java.Lang.Reflect.IType p0)
		{
			if (id_createInstance_Ljava_lang_reflect_Type_ == IntPtr.Zero)
				id_createInstance_Ljava_lang_reflect_Type_ = JNIEnv.GetMethodID (class_ref, "createInstance", "(Ljava/lang/reflect/Type;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_createInstance_Ljava_lang_reflect_Type_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
