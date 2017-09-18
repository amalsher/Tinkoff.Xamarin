using System;

namespace Com.Google.Gson.Annotations {

	[global::Android.Runtime.Annotation ("com.google.gson.annotations.SerializedName")]
	public partial class SerializedNameAttribute : Attribute
	{
		[global::Android.Runtime.Register ("alternate")]
		public string[] Alternate { get; set; }

		[global::Android.Runtime.Register ("value")]
		public string Value { get; set; }

	}
}
