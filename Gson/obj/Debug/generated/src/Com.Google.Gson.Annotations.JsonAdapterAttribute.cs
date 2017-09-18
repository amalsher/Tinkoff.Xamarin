using System;

namespace Com.Google.Gson.Annotations {

	[global::Android.Runtime.Annotation ("com.google.gson.annotations.JsonAdapter")]
	public partial class JsonAdapterAttribute : Attribute
	{
		[global::Android.Runtime.Register ("value")]
		public global::Java.Lang.Class Value { get; set; }

	}
}
