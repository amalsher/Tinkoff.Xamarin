using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='IBundlePacker']"
	[Register ("ru/tinkoff/acquiring/sdk/IBundlePacker", "", "RU.Tinkoff.Acquiring.Sdk.IBundlePackerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IBundlePacker : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='IBundlePacker']/method[@name='pack' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("pack", "(Ljava/lang/Object;)Landroid/os/Bundle;", "GetPack_Ljava_lang_Object_Handler:RU.Tinkoff.Acquiring.Sdk.IBundlePackerInvoker, Tinkoff.UI")]
		global::Android.OS.Bundle Pack (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='IBundlePacker']/method[@name='unpack' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("unpack", "(Landroid/os/Bundle;)Ljava/lang/Object;", "GetUnpack_Landroid_os_Bundle_Handler:RU.Tinkoff.Acquiring.Sdk.IBundlePackerInvoker, Tinkoff.UI")]
		global::Java.Lang.Object Unpack (global::Android.OS.Bundle p0);

	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/IBundlePacker", DoNotGenerateAcw=true)]
	internal class IBundlePackerInvoker : global::Java.Lang.Object, IBundlePacker {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/IBundlePacker");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IBundlePackerInvoker); }
		}

		IntPtr class_ref;

		public static IBundlePacker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBundlePacker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.IBundlePacker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBundlePackerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_pack_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetPack_Ljava_lang_Object_Handler ()
		{
			if (cb_pack_Ljava_lang_Object_ == null)
				cb_pack_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Pack_Ljava_lang_Object_);
			return cb_pack_Ljava_lang_Object_;
		}

		static IntPtr n_Pack_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.IBundlePacker __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.IBundlePacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Pack (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_pack_Ljava_lang_Object_;
		public unsafe global::Android.OS.Bundle Pack (global::Java.Lang.Object p0)
		{
			if (id_pack_Ljava_lang_Object_ == IntPtr.Zero)
				id_pack_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "pack", "(Ljava/lang/Object;)Landroid/os/Bundle;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Android.OS.Bundle __ret = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_pack_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_unpack_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUnpack_Landroid_os_Bundle_Handler ()
		{
			if (cb_unpack_Landroid_os_Bundle_ == null)
				cb_unpack_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Unpack_Landroid_os_Bundle_);
			return cb_unpack_Landroid_os_Bundle_;
		}

		static IntPtr n_Unpack_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.IBundlePacker __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.IBundlePacker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Unpack (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_unpack_Landroid_os_Bundle_;
		public unsafe global::Java.Lang.Object Unpack (global::Android.OS.Bundle p0)
		{
			if (id_unpack_Landroid_os_Bundle_ == IntPtr.Zero)
				id_unpack_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "unpack", "(Landroid/os/Bundle;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_unpack_Landroid_os_Bundle_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}
