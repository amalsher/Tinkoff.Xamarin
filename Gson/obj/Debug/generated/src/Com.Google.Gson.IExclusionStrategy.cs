using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='ExclusionStrategy']"
	[Register ("com/google/gson/ExclusionStrategy", "", "Com.Google.Gson.IExclusionStrategyInvoker")]
	public partial interface IExclusionStrategy : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='ExclusionStrategy']/method[@name='shouldSkipClass' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("shouldSkipClass", "(Ljava/lang/Class;)Z", "GetShouldSkipClass_Ljava_lang_Class_Handler:Com.Google.Gson.IExclusionStrategyInvoker, Gson")]
		bool ShouldSkipClass (global::Java.Lang.Class p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='ExclusionStrategy']/method[@name='shouldSkipField' and count(parameter)=1 and parameter[1][@type='com.google.gson.FieldAttributes']]"
		[Register ("shouldSkipField", "(Lcom/google/gson/FieldAttributes;)Z", "GetShouldSkipField_Lcom_google_gson_FieldAttributes_Handler:Com.Google.Gson.IExclusionStrategyInvoker, Gson")]
		bool ShouldSkipField (global::Com.Google.Gson.FieldAttributes p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/ExclusionStrategy", DoNotGenerateAcw=true)]
	internal class IExclusionStrategyInvoker : global::Java.Lang.Object, IExclusionStrategy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/ExclusionStrategy");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IExclusionStrategyInvoker); }
		}

		IntPtr class_ref;

		public static IExclusionStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExclusionStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.ExclusionStrategy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExclusionStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_shouldSkipClass_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetShouldSkipClass_Ljava_lang_Class_Handler ()
		{
			if (cb_shouldSkipClass_Ljava_lang_Class_ == null)
				cb_shouldSkipClass_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldSkipClass_Ljava_lang_Class_);
			return cb_shouldSkipClass_Ljava_lang_Class_;
		}

		static bool n_ShouldSkipClass_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.IExclusionStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IExclusionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldSkipClass (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_shouldSkipClass_Ljava_lang_Class_;
		public unsafe bool ShouldSkipClass (global::Java.Lang.Class p0)
		{
			if (id_shouldSkipClass_Ljava_lang_Class_ == IntPtr.Zero)
				id_shouldSkipClass_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "shouldSkipClass", "(Ljava/lang/Class;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldSkipClass_Ljava_lang_Class_, __args);
			return __ret;
		}

		static Delegate cb_shouldSkipField_Lcom_google_gson_FieldAttributes_;
#pragma warning disable 0169
		static Delegate GetShouldSkipField_Lcom_google_gson_FieldAttributes_Handler ()
		{
			if (cb_shouldSkipField_Lcom_google_gson_FieldAttributes_ == null)
				cb_shouldSkipField_Lcom_google_gson_FieldAttributes_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldSkipField_Lcom_google_gson_FieldAttributes_);
			return cb_shouldSkipField_Lcom_google_gson_FieldAttributes_;
		}

		static bool n_ShouldSkipField_Lcom_google_gson_FieldAttributes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.IExclusionStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IExclusionStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Google.Gson.FieldAttributes p0 = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.FieldAttributes> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldSkipField (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_shouldSkipField_Lcom_google_gson_FieldAttributes_;
		public unsafe bool ShouldSkipField (global::Com.Google.Gson.FieldAttributes p0)
		{
			if (id_shouldSkipField_Lcom_google_gson_FieldAttributes_ == IntPtr.Zero)
				id_shouldSkipField_Lcom_google_gson_FieldAttributes_ = JNIEnv.GetMethodID (class_ref, "shouldSkipField", "(Lcom/google/gson/FieldAttributes;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_shouldSkipField_Lcom_google_gson_FieldAttributes_, __args);
			return __ret;
		}

	}

}
