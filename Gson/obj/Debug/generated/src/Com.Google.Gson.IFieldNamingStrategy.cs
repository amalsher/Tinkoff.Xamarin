using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson']/interface[@name='FieldNamingStrategy']"
	[Register ("com/google/gson/FieldNamingStrategy", "", "Com.Google.Gson.IFieldNamingStrategyInvoker")]
	public partial interface IFieldNamingStrategy : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/interface[@name='FieldNamingStrategy']/method[@name='translateName' and count(parameter)=1 and parameter[1][@type='java.lang.reflect.Field']]"
		[Register ("translateName", "(Ljava/lang/reflect/Field;)Ljava/lang/String;", "GetTranslateName_Ljava_lang_reflect_Field_Handler:Com.Google.Gson.IFieldNamingStrategyInvoker, Gson")]
		string TranslateName (global::Java.Lang.Reflect.Field p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/FieldNamingStrategy", DoNotGenerateAcw=true)]
	internal class IFieldNamingStrategyInvoker : global::Java.Lang.Object, IFieldNamingStrategy {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/FieldNamingStrategy");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IFieldNamingStrategyInvoker); }
		}

		IntPtr class_ref;

		public static IFieldNamingStrategy GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFieldNamingStrategy> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.FieldNamingStrategy"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFieldNamingStrategyInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_translateName_Ljava_lang_reflect_Field_;
#pragma warning disable 0169
		static Delegate GetTranslateName_Ljava_lang_reflect_Field_Handler ()
		{
			if (cb_translateName_Ljava_lang_reflect_Field_ == null)
				cb_translateName_Ljava_lang_reflect_Field_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TranslateName_Ljava_lang_reflect_Field_);
			return cb_translateName_Ljava_lang_reflect_Field_;
		}

		static IntPtr n_TranslateName_Ljava_lang_reflect_Field_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.IFieldNamingStrategy __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.IFieldNamingStrategy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Reflect.Field p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Reflect.Field> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.TranslateName (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_translateName_Ljava_lang_reflect_Field_;
		public unsafe string TranslateName (global::Java.Lang.Reflect.Field p0)
		{
			if (id_translateName_Ljava_lang_reflect_Field_ == IntPtr.Zero)
				id_translateName_Ljava_lang_reflect_Field_ = JNIEnv.GetMethodID (class_ref, "translateName", "(Ljava/lang/reflect/Field;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_translateName_Ljava_lang_reflect_Field_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
