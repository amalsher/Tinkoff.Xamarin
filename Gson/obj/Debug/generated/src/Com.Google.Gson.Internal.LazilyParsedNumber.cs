using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']"
	[global::Android.Runtime.Register ("com/google/gson/internal/LazilyParsedNumber", DoNotGenerateAcw=true)]
	public sealed partial class LazilyParsedNumber : global::Java.Lang.Number {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/LazilyParsedNumber", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (LazilyParsedNumber); }
		}

		internal LazilyParsedNumber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/constructor[@name='LazilyParsedNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LazilyParsedNumber (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (((object) this).GetType () != typeof (LazilyParsedNumber)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_doubleValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='doubleValue' and count(parameter)=0]"
		[Register ("doubleValue", "()D", "")]
		public override unsafe double DoubleValue ()
		{
			if (id_doubleValue == IntPtr.Zero)
				id_doubleValue = JNIEnv.GetMethodID (class_ref, "doubleValue", "()D");
			try {
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_doubleValue);
			} finally {
			}
		}

		static IntPtr id_floatValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='floatValue' and count(parameter)=0]"
		[Register ("floatValue", "()F", "")]
		public override unsafe float FloatValue ()
		{
			if (id_floatValue == IntPtr.Zero)
				id_floatValue = JNIEnv.GetMethodID (class_ref, "floatValue", "()F");
			try {
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_floatValue);
			} finally {
			}
		}

		static IntPtr id_intValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='intValue' and count(parameter)=0]"
		[Register ("intValue", "()I", "")]
		public override unsafe int IntValue ()
		{
			if (id_intValue == IntPtr.Zero)
				id_intValue = JNIEnv.GetMethodID (class_ref, "intValue", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_intValue);
			} finally {
			}
		}

		static IntPtr id_longValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='LazilyParsedNumber']/method[@name='longValue' and count(parameter)=0]"
		[Register ("longValue", "()J", "")]
		public override unsafe long LongValue ()
		{
			if (id_longValue == IntPtr.Zero)
				id_longValue = JNIEnv.GetMethodID (class_ref, "longValue", "()J");
			try {
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_longValue);
			} finally {
			}
		}

	}
}
