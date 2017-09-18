using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']"
	[global::Android.Runtime.Register ("com/google/gson/internal/UnsafeAllocator", DoNotGenerateAcw=true)]
	public abstract partial class UnsafeAllocator : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/UnsafeAllocator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnsafeAllocator); }
		}

		protected UnsafeAllocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/constructor[@name='UnsafeAllocator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnsafeAllocator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (UnsafeAllocator)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_create;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lcom/google/gson/internal/UnsafeAllocator;", "")]
		public static unsafe global::Com.Google.Gson.Internal.UnsafeAllocator Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetStaticMethodID (class_ref, "create", "()Lcom/google/gson/internal/UnsafeAllocator;");
			try {
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.UnsafeAllocator> (JNIEnv.CallStaticObjectMethod  (class_ref, id_create), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_newInstance_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetNewInstance_Ljava_lang_Class_Handler ()
		{
			if (cb_newInstance_Ljava_lang_Class_ == null)
				cb_newInstance_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_NewInstance_Ljava_lang_Class_);
			return cb_newInstance_Ljava_lang_Class_;
		}

		static IntPtr n_NewInstance_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Google.Gson.Internal.UnsafeAllocator __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.UnsafeAllocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewInstance (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("newInstance", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetNewInstance_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public abstract global::Java.Lang.Object NewInstance (global::Java.Lang.Class p0);

	}

	[global::Android.Runtime.Register ("com/google/gson/internal/UnsafeAllocator", DoNotGenerateAcw=true)]
	internal partial class UnsafeAllocatorInvoker : UnsafeAllocator {

		public UnsafeAllocatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UnsafeAllocatorInvoker); }
		}

		static IntPtr id_newInstance_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='UnsafeAllocator']/method[@name='newInstance' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("newInstance", "(Ljava/lang/Class;)Ljava/lang/Object;", "GetNewInstance_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public override unsafe global::Java.Lang.Object NewInstance (global::Java.Lang.Class p0)
		{
			if (id_newInstance_Ljava_lang_Class_ == IntPtr.Zero)
				id_newInstance_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "newInstance", "(Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_newInstance_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}

}
