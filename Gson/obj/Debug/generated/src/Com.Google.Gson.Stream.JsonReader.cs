using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']"
	[global::Android.Runtime.Register ("com/google/gson/stream/JsonReader", DoNotGenerateAcw=true)]
	public partial class JsonReader : global::Java.Lang.Object, global::Java.IO.ICloseable {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/stream/JsonReader", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonReader); }
		}

		protected JsonReader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_io_Reader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/constructor[@name='JsonReader' and count(parameter)=1 and parameter[1][@type='java.io.Reader']]"
		[Register (".ctor", "(Ljava/io/Reader;)V", "")]
		public unsafe JsonReader (global::Java.IO.Reader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (JsonReader)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/io/Reader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/io/Reader;)V", __args);
					return;
				}

				if (id_ctor_Ljava_io_Reader_ == IntPtr.Zero)
					id_ctor_Ljava_io_Reader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/io/Reader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_io_Reader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_io_Reader_, __args);
			} finally {
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		static IntPtr id_hasNext;
		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				if (id_hasNext == IntPtr.Zero)
					id_hasNext = JNIEnv.GetMethodID (class_ref, "hasNext", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasNext);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasNext", "()Z"));
				} finally {
				}
			}
		}

		static IntPtr id_isLenient;
		static IntPtr id_setLenient_Z;
		public unsafe bool Lenient {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='isLenient' and count(parameter)=0]"
			[Register ("isLenient", "()Z", "GetIsLenientHandler")]
			get {
				if (id_isLenient == IntPtr.Zero)
					id_isLenient = JNIEnv.GetMethodID (class_ref, "isLenient", "()Z");
				try {
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLenient);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='setLenient' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLenient", "(Z)V", "GetSetLenient_ZHandler")]
			set {
				if (id_setLenient_Z == IntPtr.Zero)
					id_setLenient_Z = JNIEnv.GetMethodID (class_ref, "setLenient", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLenient_Z, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		static IntPtr id_getPath;
		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				if (id_getPath == IntPtr.Zero)
					id_getPath = JNIEnv.GetMethodID (class_ref, "getPath", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPath), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPath", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_beginArray;
#pragma warning disable 0169
		static Delegate GetBeginArrayHandler ()
		{
			if (cb_beginArray == null)
				cb_beginArray = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeginArray);
			return cb_beginArray;
		}

		static void n_BeginArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginArray ();
		}
#pragma warning restore 0169

		static IntPtr id_beginArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='beginArray' and count(parameter)=0]"
		[Register ("beginArray", "()V", "GetBeginArrayHandler")]
		public virtual unsafe void BeginArray ()
		{
			if (id_beginArray == IntPtr.Zero)
				id_beginArray = JNIEnv.GetMethodID (class_ref, "beginArray", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beginArray);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beginArray", "()V"));
			} finally {
			}
		}

		static Delegate cb_beginObject;
#pragma warning disable 0169
		static Delegate GetBeginObjectHandler ()
		{
			if (cb_beginObject == null)
				cb_beginObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_BeginObject);
			return cb_beginObject;
		}

		static void n_BeginObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BeginObject ();
		}
#pragma warning restore 0169

		static IntPtr id_beginObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='beginObject' and count(parameter)=0]"
		[Register ("beginObject", "()V", "GetBeginObjectHandler")]
		public virtual unsafe void BeginObject ()
		{
			if (id_beginObject == IntPtr.Zero)
				id_beginObject = JNIEnv.GetMethodID (class_ref, "beginObject", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_beginObject);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "beginObject", "()V"));
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		static IntPtr id_close;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "close", "()V"));
			} finally {
			}
		}

		static Delegate cb_endArray;
#pragma warning disable 0169
		static Delegate GetEndArrayHandler ()
		{
			if (cb_endArray == null)
				cb_endArray = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndArray);
			return cb_endArray;
		}

		static void n_EndArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndArray ();
		}
#pragma warning restore 0169

		static IntPtr id_endArray;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='endArray' and count(parameter)=0]"
		[Register ("endArray", "()V", "GetEndArrayHandler")]
		public virtual unsafe void EndArray ()
		{
			if (id_endArray == IntPtr.Zero)
				id_endArray = JNIEnv.GetMethodID (class_ref, "endArray", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endArray);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endArray", "()V"));
			} finally {
			}
		}

		static Delegate cb_endObject;
#pragma warning disable 0169
		static Delegate GetEndObjectHandler ()
		{
			if (cb_endObject == null)
				cb_endObject = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EndObject);
			return cb_endObject;
		}

		static void n_EndObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndObject ();
		}
#pragma warning restore 0169

		static IntPtr id_endObject;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='endObject' and count(parameter)=0]"
		[Register ("endObject", "()V", "GetEndObjectHandler")]
		public virtual unsafe void EndObject ()
		{
			if (id_endObject == IntPtr.Zero)
				id_endObject = JNIEnv.GetMethodID (class_ref, "endObject", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_endObject);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "endObject", "()V"));
			} finally {
			}
		}

		static Delegate cb_nextBoolean;
#pragma warning disable 0169
		static Delegate GetNextBooleanHandler ()
		{
			if (cb_nextBoolean == null)
				cb_nextBoolean = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NextBoolean);
			return cb_nextBoolean;
		}

		static bool n_NextBoolean (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextBoolean ();
		}
#pragma warning restore 0169

		static IntPtr id_nextBoolean;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextBoolean' and count(parameter)=0]"
		[Register ("nextBoolean", "()Z", "GetNextBooleanHandler")]
		public virtual unsafe bool NextBoolean ()
		{
			if (id_nextBoolean == IntPtr.Zero)
				id_nextBoolean = JNIEnv.GetMethodID (class_ref, "nextBoolean", "()Z");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_nextBoolean);
				else
					return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextBoolean", "()Z"));
			} finally {
			}
		}

		static Delegate cb_nextDouble;
#pragma warning disable 0169
		static Delegate GetNextDoubleHandler ()
		{
			if (cb_nextDouble == null)
				cb_nextDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_NextDouble);
			return cb_nextDouble;
		}

		static double n_NextDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextDouble ();
		}
#pragma warning restore 0169

		static IntPtr id_nextDouble;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextDouble' and count(parameter)=0]"
		[Register ("nextDouble", "()D", "GetNextDoubleHandler")]
		public virtual unsafe double NextDouble ()
		{
			if (id_nextDouble == IntPtr.Zero)
				id_nextDouble = JNIEnv.GetMethodID (class_ref, "nextDouble", "()D");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_nextDouble);
				else
					return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextDouble", "()D"));
			} finally {
			}
		}

		static Delegate cb_nextInt;
#pragma warning disable 0169
		static Delegate GetNextIntHandler ()
		{
			if (cb_nextInt == null)
				cb_nextInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NextInt);
			return cb_nextInt;
		}

		static int n_NextInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextInt ();
		}
#pragma warning restore 0169

		static IntPtr id_nextInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextInt' and count(parameter)=0]"
		[Register ("nextInt", "()I", "GetNextIntHandler")]
		public virtual unsafe int NextInt ()
		{
			if (id_nextInt == IntPtr.Zero)
				id_nextInt = JNIEnv.GetMethodID (class_ref, "nextInt", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_nextInt);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextInt", "()I"));
			} finally {
			}
		}

		static Delegate cb_nextLong;
#pragma warning disable 0169
		static Delegate GetNextLongHandler ()
		{
			if (cb_nextLong == null)
				cb_nextLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_NextLong);
			return cb_nextLong;
		}

		static long n_NextLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextLong ();
		}
#pragma warning restore 0169

		static IntPtr id_nextLong;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextLong' and count(parameter)=0]"
		[Register ("nextLong", "()J", "GetNextLongHandler")]
		public virtual unsafe long NextLong ()
		{
			if (id_nextLong == IntPtr.Zero)
				id_nextLong = JNIEnv.GetMethodID (class_ref, "nextLong", "()J");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_nextLong);
				else
					return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextLong", "()J"));
			} finally {
			}
		}

		static Delegate cb_nextName;
#pragma warning disable 0169
		static Delegate GetNextNameHandler ()
		{
			if (cb_nextName == null)
				cb_nextName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextName);
			return cb_nextName;
		}

		static IntPtr n_NextName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextName ());
		}
#pragma warning restore 0169

		static IntPtr id_nextName;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextName' and count(parameter)=0]"
		[Register ("nextName", "()Ljava/lang/String;", "GetNextNameHandler")]
		public virtual unsafe string NextName ()
		{
			if (id_nextName == IntPtr.Zero)
				id_nextName = JNIEnv.GetMethodID (class_ref, "nextName", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextName), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_nextNull;
#pragma warning disable 0169
		static Delegate GetNextNullHandler ()
		{
			if (cb_nextNull == null)
				cb_nextNull = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NextNull);
			return cb_nextNull;
		}

		static void n_NextNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NextNull ();
		}
#pragma warning restore 0169

		static IntPtr id_nextNull;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextNull' and count(parameter)=0]"
		[Register ("nextNull", "()V", "GetNextNullHandler")]
		public virtual unsafe void NextNull ()
		{
			if (id_nextNull == IntPtr.Zero)
				id_nextNull = JNIEnv.GetMethodID (class_ref, "nextNull", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_nextNull);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextNull", "()V"));
			} finally {
			}
		}

		static Delegate cb_nextString;
#pragma warning disable 0169
		static Delegate GetNextStringHandler ()
		{
			if (cb_nextString == null)
				cb_nextString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextString);
			return cb_nextString;
		}

		static IntPtr n_NextString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.NextString ());
		}
#pragma warning restore 0169

		static IntPtr id_nextString;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='nextString' and count(parameter)=0]"
		[Register ("nextString", "()Ljava/lang/String;", "GetNextStringHandler")]
		public virtual unsafe string NextString ()
		{
			if (id_nextString == IntPtr.Zero)
				id_nextString = JNIEnv.GetMethodID (class_ref, "nextString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_nextString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "nextString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peek;
#pragma warning disable 0169
		static Delegate GetPeekHandler ()
		{
			if (cb_peek == null)
				cb_peek = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Peek);
			return cb_peek;
		}

		static IntPtr n_Peek (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Peek ());
		}
#pragma warning restore 0169

		static IntPtr id_peek;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='peek' and count(parameter)=0]"
		[Register ("peek", "()Lcom/google/gson/stream/JsonToken;", "GetPeekHandler")]
		public virtual unsafe global::Com.Google.Gson.Stream.JsonToken Peek ()
		{
			if (id_peek == IntPtr.Zero)
				id_peek = JNIEnv.GetMethodID (class_ref, "peek", "()Lcom/google/gson/stream/JsonToken;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_peek), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonToken> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "peek", "()Lcom/google/gson/stream/JsonToken;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skipValue;
#pragma warning disable 0169
		static Delegate GetSkipValueHandler ()
		{
			if (cb_skipValue == null)
				cb_skipValue = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SkipValue);
			return cb_skipValue;
		}

		static void n_SkipValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.Stream.JsonReader __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Stream.JsonReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipValue ();
		}
#pragma warning restore 0169

		static IntPtr id_skipValue;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.stream']/class[@name='JsonReader']/method[@name='skipValue' and count(parameter)=0]"
		[Register ("skipValue", "()V", "GetSkipValueHandler")]
		public virtual unsafe void SkipValue ()
		{
			if (id_skipValue == IntPtr.Zero)
				id_skipValue = JNIEnv.GetMethodID (class_ref, "skipValue", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_skipValue);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skipValue", "()V"));
			} finally {
			}
		}

	}
}
