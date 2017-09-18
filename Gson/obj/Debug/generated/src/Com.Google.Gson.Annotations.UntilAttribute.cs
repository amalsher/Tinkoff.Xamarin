using System;

namespace Com.Google.Gson.Annotations {

	[global::Android.Runtime.Annotation ("com.google.gson.annotations.Until")]
	public partial class UntilAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public double Value { get; set; }

	}
}
