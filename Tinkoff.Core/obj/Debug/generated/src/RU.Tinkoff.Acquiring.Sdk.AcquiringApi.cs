using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApi']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/AcquiringApi", DoNotGenerateAcw=true)]
	public partial class AcquiringApi : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='AcquiringApi']/field[@name='API_REQUEST_METHOD']"
		[Register ("API_REQUEST_METHOD")]
		public const string ApiRequestMethod = (string) "POST";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/AcquiringApi", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AcquiringApi); }
		}

		protected AcquiringApi (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
