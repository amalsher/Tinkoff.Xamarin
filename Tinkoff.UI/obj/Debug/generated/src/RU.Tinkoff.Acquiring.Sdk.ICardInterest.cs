using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='ICardInterest']"
	[Register ("ru/tinkoff/acquiring/sdk/ICardInterest", "", "RU.Tinkoff.Acquiring.Sdk.ICardInterestInvoker")]
	public partial interface ICardInterest : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/interface[@name='ICardInterest']/method[@name='onCardReady' and count(parameter)=0]"
		[Register ("onCardReady", "()V", "GetOnCardReadyHandler:RU.Tinkoff.Acquiring.Sdk.ICardInterestInvoker, Tinkoff.UI")]
		void OnCardReady ();

	}

	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/ICardInterest", DoNotGenerateAcw=true)]
	internal class ICardInterestInvoker : global::Java.Lang.Object, ICardInterest {

		static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/ICardInterest");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICardInterestInvoker); }
		}

		IntPtr class_ref;

		public static ICardInterest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICardInterest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.ICardInterest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICardInterestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onCardReady;
#pragma warning disable 0169
		static Delegate GetOnCardReadyHandler ()
		{
			if (cb_onCardReady == null)
				cb_onCardReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCardReady);
			return cb_onCardReady;
		}

		static void n_OnCardReady (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.ICardInterest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.ICardInterest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCardReady ();
		}
#pragma warning restore 0169

		IntPtr id_onCardReady;
		public unsafe void OnCardReady ()
		{
			if (id_onCardReady == IntPtr.Zero)
				id_onCardReady = JNIEnv.GetMethodID (class_ref, "onCardReady", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCardReady);
		}

	}

}
