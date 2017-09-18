using System;

namespace Com.Google.Gson.Annotations {

	[global::Android.Runtime.Annotation ("com.google.gson.annotations.Since")]
	public partial class SinceAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public double Value { get; set; }

	}
}
