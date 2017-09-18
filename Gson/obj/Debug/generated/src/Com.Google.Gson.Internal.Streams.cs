using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']"
	[global::Android.Runtime.Register ("com/google/gson/internal/Streams", DoNotGenerateAcw=true)]
	public sealed partial class Streams : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter']"
		[global::Android.Runtime.Register ("com/google/gson/internal/Streams$AppendableWriter", DoNotGenerateAcw=true)]
		public sealed partial class AppendableWriter : global::Java.IO.Writer {

			// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter.CurrentWrite']"
			[global::Android.Runtime.Register ("com/google/gson/internal/Streams$AppendableWriter$CurrentWrite", DoNotGenerateAcw=true)]
			public partial class CurrentWrite : global::Java.Lang.Object, global::Java.Lang.ICharSequence {

				internal static new IntPtr java_class_handle;
				internal static new IntPtr class_ref {
					get {
						return JNIEnv.FindClass ("com/google/gson/internal/Streams$AppendableWriter$CurrentWrite", ref java_class_handle);
					}
				}

				protected override IntPtr ThresholdClass {
					get { return class_ref; }
				}

				protected override global::System.Type ThresholdType {
					get { return typeof (CurrentWrite); }
				}

				protected CurrentWrite (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

				static Delegate cb_charAt_I;
#pragma warning disable 0169
				static Delegate GetCharAt_IHandler ()
				{
					if (cb_charAt_I == null)
						cb_charAt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, char>) n_CharAt_I);
					return cb_charAt_I;
				}

				static char n_CharAt_I (IntPtr jnienv, IntPtr native__this, int p0)
				{
					global::Com.Google.Gson.Internal.Streams.AppendableWriter.CurrentWrite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Streams.AppendableWriter.CurrentWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.CharAt (p0);
				}
#pragma warning restore 0169

				static IntPtr id_charAt_I;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter.CurrentWrite']/method[@name='charAt' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("charAt", "(I)C", "GetCharAt_IHandler")]
				public virtual unsafe char CharAt (int p0)
				{
					if (id_charAt_I == IntPtr.Zero)
						id_charAt_I = JNIEnv.GetMethodID (class_ref, "charAt", "(I)C");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (p0);

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallCharMethod (((global::Java.Lang.Object) this).Handle, id_charAt_I, __args);
						else
							return JNIEnv.CallNonvirtualCharMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "charAt", "(I)C"), __args);
					} finally {
					}
				}

				static Delegate cb_length;
#pragma warning disable 0169
				static Delegate GetLengthHandler ()
				{
					if (cb_length == null)
						cb_length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Length);
					return cb_length;
				}

				static int n_Length (IntPtr jnienv, IntPtr native__this)
				{
					global::Com.Google.Gson.Internal.Streams.AppendableWriter.CurrentWrite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Streams.AppendableWriter.CurrentWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return __this.Length ();
				}
#pragma warning restore 0169

				static IntPtr id_length;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter.CurrentWrite']/method[@name='length' and count(parameter)=0]"
				[Register ("length", "()I", "GetLengthHandler")]
				public virtual unsafe int Length ()
				{
					if (id_length == IntPtr.Zero)
						id_length = JNIEnv.GetMethodID (class_ref, "length", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_length);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "length", "()I"));
					} finally {
					}
				}

				static Delegate cb_subSequence_II;
#pragma warning disable 0169
				static Delegate GetSubSequence_IIHandler ()
				{
					if (cb_subSequence_II == null)
						cb_subSequence_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SubSequence_II);
					return cb_subSequence_II;
				}

				static IntPtr n_SubSequence_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
				{
					global::Com.Google.Gson.Internal.Streams.AppendableWriter.CurrentWrite __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.Internal.Streams.AppendableWriter.CurrentWrite> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
					return CharSequence.ToLocalJniHandle (__this.SubSequenceFormatted (p0, p1));
				}
#pragma warning restore 0169

				static IntPtr id_subSequence_II;
				// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter.CurrentWrite']/method[@name='subSequence' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
				[Register ("subSequence", "(II)Ljava/lang/CharSequence;", "GetSubSequence_IIHandler")]
				public virtual unsafe global::Java.Lang.ICharSequence SubSequenceFormatted (int p0, int p1)
				{
					if (id_subSequence_II == IntPtr.Zero)
						id_subSequence_II = JNIEnv.GetMethodID (class_ref, "subSequence", "(II)Ljava/lang/CharSequence;");
					try {
						JValue* __args = stackalloc JValue [2];
						__args [0] = new JValue (p0);
						__args [1] = new JValue (p1);

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_subSequence_II, __args), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "subSequence", "(II)Ljava/lang/CharSequence;"), __args), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}

				public string SubSequence (int p0, int p1)
				{
					global::Java.Lang.ICharSequence __result = SubSequenceFormatted (p0, p1);
					return __result == null ? null : __result.ToString ();
				}

				System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator ()
				{
					return GetEnumerator ();
				}

				public System.Collections.Generic.IEnumerator<char> GetEnumerator ()
				{
					for (int i = 0; i < Length(); i++)
						yield return CharAt (i);
				}

			}

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/gson/internal/Streams$AppendableWriter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (AppendableWriter); }
			}

			internal AppendableWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_close;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter']/method[@name='close' and count(parameter)=0]"
			[Register ("close", "()V", "")]
			public override unsafe void Close ()
			{
				if (id_close == IntPtr.Zero)
					id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
				} finally {
				}
			}

			static IntPtr id_flush;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter']/method[@name='flush' and count(parameter)=0]"
			[Register ("flush", "()V", "")]
			public override unsafe void Flush ()
			{
				if (id_flush == IntPtr.Zero)
					id_flush = JNIEnv.GetMethodID (class_ref, "flush", "()V");
				try {
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_flush);
				} finally {
				}
			}

			static IntPtr id_write_arrayCII;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams.AppendableWriter']/method[@name='write' and count(parameter)=3 and parameter[1][@type='char[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
			[Register ("write", "([CII)V", "")]
			public override unsafe void Write (char[] p0, int p1, int p2)
			{
				if (id_write_arrayCII == IntPtr.Zero)
					id_write_arrayCII = JNIEnv.GetMethodID (class_ref, "write", "([CII)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_arrayCII, __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/Streams", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Streams); }
		}

		internal Streams (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_parse_Lcom_google_gson_stream_JsonReader_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
		[Register ("parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;", "")]
		public static unsafe global::Com.Google.Gson.JsonElement Parse (global::Com.Google.Gson.Stream.JsonReader p0)
		{
			if (id_parse_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
				id_parse_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Lcom/google/gson/stream/JsonReader;)Lcom/google/gson/JsonElement;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Com.Google.Gson.JsonElement __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.JsonElement'] and parameter[2][@type='com.google.gson.stream.JsonWriter']]"
		[Register ("write", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V", "")]
		public static unsafe void Write (global::Com.Google.Gson.JsonElement p0, global::Com.Google.Gson.Stream.JsonWriter p1)
		{
			if (id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ == IntPtr.Zero)
				id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_ = JNIEnv.GetStaticMethodID (class_ref, "write", "(Lcom/google/gson/JsonElement;Lcom/google/gson/stream/JsonWriter;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_write_Lcom_google_gson_JsonElement_Lcom_google_gson_stream_JsonWriter_, __args);
			} finally {
			}
		}

		static IntPtr id_writerForAppendable_Ljava_lang_Appendable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal']/class[@name='Streams']/method[@name='writerForAppendable' and count(parameter)=1 and parameter[1][@type='java.lang.Appendable']]"
		[Register ("writerForAppendable", "(Ljava/lang/Appendable;)Ljava/io/Writer;", "")]
		public static unsafe global::Java.IO.Writer WriterForAppendable (global::Java.Lang.IAppendable p0)
		{
			if (id_writerForAppendable_Ljava_lang_Appendable_ == IntPtr.Zero)
				id_writerForAppendable_Ljava_lang_Appendable_ = JNIEnv.GetStaticMethodID (class_ref, "writerForAppendable", "(Ljava/lang/Appendable;)Ljava/io/Writer;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::Java.IO.Writer __ret = global::Java.Lang.Object.GetObject<global::Java.IO.Writer> (JNIEnv.CallStaticObjectMethod  (class_ref, id_writerForAppendable_Ljava_lang_Appendable_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
