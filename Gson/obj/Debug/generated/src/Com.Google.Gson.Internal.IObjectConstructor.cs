using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.google.gson.internal']/interface[@name='ObjectConstructor']"
	[Register ("com/google/gson/internal/ObjectConstructor", "", "Com.Google.Gson.Internal.IObjectConstructorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IObjectConstructor : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/interface[@name='ObjectConstructor']/method[@name='construct' and count(parameter)=0]"
		[Register ("construct", "()Ljava/lang/Object;", "GetConstructHandler:Com.Google.Gson.Internal.IObjectConstructorInvoker, Gson")]
		global::Java.Lang.Object Construct ();

	}

	[global::Android.Runtime.Register ("com/google/gson/internal/ObjectConstructor", DoNotGenerateAcw=true)]
	internal class IObjectConstructorInvoker : global::Java.Lang.Object, IObjectConstructor {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/google/gson/internal/ObjectConstructor");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IObjectConstructorInvoker); }
		}

		IntPtr class_ref;

		public static IObjectConstructor GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjectConstructor> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.google.gson.internal.ObjectConstructor"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjectConstructorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_construct;
#pragma warning disable 0169
		static Delegate GetConstructHandler ()
		{
			if (cb_construct == null)
				cb_construct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Construct);
			return cb_construct;
		}

		static IntPtr n_Construct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Internal.IObjectConstructor __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.IObjectConstructor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Construct ());
		}
#pragma warning restore 0169

		IntPtr id_construct;
		public unsafe global::Java.Lang.Object Construct ()
		{
			if (id_construct == IntPtr.Zero)
				id_construct = JNIEnv.GetMethodID (class_ref, "construct", "()Ljava/lang/Object;");
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_construct), JniHandleOwnership.TransferLocalRef);
		}

	}

}
