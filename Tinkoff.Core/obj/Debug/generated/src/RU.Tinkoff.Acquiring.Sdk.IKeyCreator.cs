using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='KeyCreator']"
	[Register ("ru/tinkoff/acquiring/sdk/KeyCreator", "", "RU.Tinkoff.Acquiring.Sdk.IKeyCreatorInvoker")]
	public partial interface IKeyCreator : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='KeyCreator']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Ljava/security/PublicKey;", "GetCreateHandler:RU.Tinkoff.Acquiring.Sdk.IKeyCreatorInvoker, Tinkoff.Core")]
		global::Java.Security.IPublicKey Create ();

	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/KeyCreator", DoNotGenerateAcw=true)]
	internal class IKeyCreatorInvoker : global::Java.Lang.Object, IKeyCreator {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/KeyCreator");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IKeyCreatorInvoker); }
		}

		IntPtr class_ref;

		public static IKeyCreator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IKeyCreator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.KeyCreator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IKeyCreatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_create;
#pragma warning disable 0169
		static Delegate GetCreateHandler ()
		{
			if (cb_create == null)
				cb_create = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Create);
			return cb_create;
		}

		static IntPtr n_Create (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.IKeyCreator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.IKeyCreator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Create ());
		}
#pragma warning restore 0169

		IntPtr id_create;
		public unsafe global::Java.Security.IPublicKey Create ()
		{
			if (id_create == IntPtr.Zero)
				id_create = JNIEnv.GetMethodID (class_ref, "create", "()Ljava/security/PublicKey;");
			return global::Java.Lang.Object.GetObject<global::Java.Security.IPublicKey> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_create), JniHandleOwnership.TransferLocalRef);
		}

	}

}
