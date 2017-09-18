using System;

namespace Com.Google.Gson.Annotations {

	[global::Android.Runtime.Annotation ("com.google.gson.annotations.Expose")]
	public partial class ExposeAttribute : Attribute
	{
		[global::Android.Runtime.Register ("deserialize")]
		public bool Deserialize { get; set; }

		[global::Android.Runtime.Register ("serialize")]
		public bool Serialize { get; set; }

	}
}
