using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='PdolUtils']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/util/PdolUtils", DoNotGenerateAcw=true)]
	public partial class PdolUtils : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='PdolUtils.RecvTag']"
		[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/util/PdolUtils$RecvTag", DoNotGenerateAcw=true)]
		public partial class RecvTag : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/core/nfc/util/PdolUtils$RecvTag", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RecvTag); }
			}

			protected RecvTag (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_arrayBI;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='PdolUtils.RecvTag']/constructor[@name='PdolUtils.RecvTag' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
			[Register (".ctor", "([BI)V", "")]
			public unsafe RecvTag (byte[] p0, int p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (RecvTag)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BI)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BI)V", __args);
						return;
					}

					if (id_ctor_arrayBI == IntPtr.Zero)
						id_ctor_arrayBI = JNIEnv.GetMethodID (class_ref, "<init>", "([BI)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBI, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBI, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static IntPtr id_ctor_arrayBIarrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='PdolUtils.RecvTag']/constructor[@name='PdolUtils.RecvTag' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
			[Register (".ctor", "([BI[B)V", "")]
			public unsafe RecvTag (byte[] p0, int p1, byte[] p2)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewArray (p0);
				IntPtr native_p2 = JNIEnv.NewArray (p2);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (native_p2);
					if (((object) this).GetType () != typeof (RecvTag)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([BI[B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([BI[B)V", __args);
						return;
					}

					if (id_ctor_arrayBIarrayB == IntPtr.Zero)
						id_ctor_arrayBIarrayB = JNIEnv.GetMethodID (class_ref, "<init>", "([BI[B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayBIarrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayBIarrayB, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
					if (p2 != null) {
						JNIEnv.CopyArray (native_p2, p2);
						JNIEnv.DeleteLocalRef (native_p2);
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/util/PdolUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PdolUtils); }
		}

		protected PdolUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='PdolUtils']/constructor[@name='PdolUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PdolUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (PdolUtils)) {
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

		static IntPtr id_parsePDoL_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.util']/class[@name='PdolUtils']/method[@name='parsePDoL' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("parsePDoL", "([B)[B", "")]
		public static unsafe byte[] ParsePDoL (byte[] p0)
		{
			if (id_parsePDoL_arrayB == IntPtr.Zero)
				id_parsePDoL_arrayB = JNIEnv.GetStaticMethodID (class_ref, "parsePDoL", "([B)[B");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				byte[] __ret = (byte[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_parsePDoL_arrayB, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}
}
