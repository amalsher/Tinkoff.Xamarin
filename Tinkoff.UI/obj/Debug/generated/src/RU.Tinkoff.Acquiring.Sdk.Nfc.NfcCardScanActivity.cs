using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Nfc {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.nfc']/class[@name='NfcCardScanActivity']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/nfc/NfcCardScanActivity", DoNotGenerateAcw=true)]
	public partial class NfcCardScanActivity : global::Android.Support.V7.App.AppCompatActivity {


		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.nfc']/class[@name='NfcCardScanActivity']/field[@name='EXTRA_CARD']"
		[Register ("EXTRA_CARD")]
		public const string ExtraCard = (string) "card_extra";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.nfc']/class[@name='NfcCardScanActivity']/field[@name='RESULT_ERROR']"
		[Register ("RESULT_ERROR")]
		public const int ResultError = (int) 256;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/nfc/NfcCardScanActivity", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (NfcCardScanActivity); }
		}

		protected NfcCardScanActivity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.nfc']/class[@name='NfcCardScanActivity']/constructor[@name='NfcCardScanActivity' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe NfcCardScanActivity ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (NfcCardScanActivity)) {
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

	}
}
