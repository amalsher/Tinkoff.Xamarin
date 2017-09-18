using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']"
	[global::Android.Runtime.Register ("com/google/gson/JsonElement", DoNotGenerateAcw=true)]
	public abstract partial class JsonElement : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/JsonElement", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonElement); }
		}

		protected JsonElement (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/constructor[@name='JsonElement' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe JsonElement ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (JsonElement)) {
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

		static Delegate cb_getAsBigDecimal;
#pragma warning disable 0169
		static Delegate GetGetAsBigDecimalHandler ()
		{
			if (cb_getAsBigDecimal == null)
				cb_getAsBigDecimal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsBigDecimal);
			return cb_getAsBigDecimal;
		}

		static IntPtr n_GetAsBigDecimal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBigDecimal);
		}
#pragma warning restore 0169

		static IntPtr id_getAsBigDecimal;
		public virtual unsafe global::Java.Math.BigDecimal AsBigDecimal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsBigDecimal' and count(parameter)=0]"
			[Register ("getAsBigDecimal", "()Ljava/math/BigDecimal;", "GetGetAsBigDecimalHandler")]
			get {
				if (id_getAsBigDecimal == IntPtr.Zero)
					id_getAsBigDecimal = JNIEnv.GetMethodID (class_ref, "getAsBigDecimal", "()Ljava/math/BigDecimal;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsBigDecimal), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigDecimal> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsBigDecimal", "()Ljava/math/BigDecimal;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsBigInteger;
#pragma warning disable 0169
		static Delegate GetGetAsBigIntegerHandler ()
		{
			if (cb_getAsBigInteger == null)
				cb_getAsBigInteger = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsBigInteger);
			return cb_getAsBigInteger;
		}

		static IntPtr n_GetAsBigInteger (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBigInteger);
		}
#pragma warning restore 0169

		static IntPtr id_getAsBigInteger;
		public virtual unsafe global::Java.Math.BigInteger AsBigInteger {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsBigInteger' and count(parameter)=0]"
			[Register ("getAsBigInteger", "()Ljava/math/BigInteger;", "GetGetAsBigIntegerHandler")]
			get {
				if (id_getAsBigInteger == IntPtr.Zero)
					id_getAsBigInteger = JNIEnv.GetMethodID (class_ref, "getAsBigInteger", "()Ljava/math/BigInteger;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsBigInteger), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Math.BigInteger> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsBigInteger", "()Ljava/math/BigInteger;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsBoolean;
#pragma warning disable 0169
		static Delegate GetGetAsBooleanHandler ()
		{
			if (cb_getAsBoolean == null)
				cb_getAsBoolean = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetAsBoolean);
			return cb_getAsBoolean;
		}

		static bool n_GetAsBoolean (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsBoolean;
		}
#pragma warning restore 0169

		static IntPtr id_getAsBoolean;
		public virtual unsafe bool AsBoolean {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsBoolean' and count(parameter)=0]"
			[Register ("getAsBoolean", "()Z", "GetGetAsBooleanHandler")]
			get {
				if (id_getAsBoolean == IntPtr.Zero)
					id_getAsBoolean = JNIEnv.GetMethodID (class_ref, "getAsBoolean", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_getAsBoolean);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsBoolean", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsByte;
#pragma warning disable 0169
		static Delegate GetGetAsByteHandler ()
		{
			if (cb_getAsByte == null)
				cb_getAsByte = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetAsByte);
			return cb_getAsByte;
		}

		static sbyte n_GetAsByte (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsByte;
		}
#pragma warning restore 0169

		static IntPtr id_getAsByte;
		public virtual unsafe sbyte AsByte {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsByte' and count(parameter)=0]"
			[Register ("getAsByte", "()B", "GetGetAsByteHandler")]
			get {
				if (id_getAsByte == IntPtr.Zero)
					id_getAsByte = JNIEnv.GetMethodID (class_ref, "getAsByte", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getAsByte);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsByte", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsCharacter;
#pragma warning disable 0169
		static Delegate GetGetAsCharacterHandler ()
		{
			if (cb_getAsCharacter == null)
				cb_getAsCharacter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetAsCharacter);
			return cb_getAsCharacter;
		}

		static char n_GetAsCharacter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsCharacter;
		}
#pragma warning restore 0169

		static IntPtr id_getAsCharacter;
		public virtual unsafe char AsCharacter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsCharacter' and count(parameter)=0]"
			[Register ("getAsCharacter", "()C", "GetGetAsCharacterHandler")]
			get {
				if (id_getAsCharacter == IntPtr.Zero)
					id_getAsCharacter = JNIEnv.GetMethodID (class_ref, "getAsCharacter", "()C");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallCharMethod (((global::Java.Lang.Object) this).Handle, id_getAsCharacter);
					else
						return JNIEnv.CallNonvirtualCharMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsCharacter", "()C"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsDouble;
#pragma warning disable 0169
		static Delegate GetGetAsDoubleHandler ()
		{
			if (cb_getAsDouble == null)
				cb_getAsDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAsDouble);
			return cb_getAsDouble;
		}

		static double n_GetAsDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsDouble;
		}
#pragma warning restore 0169

		static IntPtr id_getAsDouble;
		public virtual unsafe double AsDouble {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsDouble' and count(parameter)=0]"
			[Register ("getAsDouble", "()D", "GetGetAsDoubleHandler")]
			get {
				if (id_getAsDouble == IntPtr.Zero)
					id_getAsDouble = JNIEnv.GetMethodID (class_ref, "getAsDouble", "()D");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAsDouble);
					else
						return JNIEnv.CallNonvirtualDoubleMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsDouble", "()D"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsFloat;
#pragma warning disable 0169
		static Delegate GetGetAsFloatHandler ()
		{
			if (cb_getAsFloat == null)
				cb_getAsFloat = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAsFloat);
			return cb_getAsFloat;
		}

		static float n_GetAsFloat (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsFloat;
		}
#pragma warning restore 0169

		static IntPtr id_getAsFloat;
		public virtual unsafe float AsFloat {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsFloat' and count(parameter)=0]"
			[Register ("getAsFloat", "()F", "GetGetAsFloatHandler")]
			get {
				if (id_getAsFloat == IntPtr.Zero)
					id_getAsFloat = JNIEnv.GetMethodID (class_ref, "getAsFloat", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getAsFloat);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsFloat", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsInt;
#pragma warning disable 0169
		static Delegate GetGetAsIntHandler ()
		{
			if (cb_getAsInt == null)
				cb_getAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAsInt);
			return cb_getAsInt;
		}

		static int n_GetAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsInt;
		}
#pragma warning restore 0169

		static IntPtr id_getAsInt;
		public virtual unsafe int AsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsInt' and count(parameter)=0]"
			[Register ("getAsInt", "()I", "GetGetAsIntHandler")]
			get {
				if (id_getAsInt == IntPtr.Zero)
					id_getAsInt = JNIEnv.GetMethodID (class_ref, "getAsInt", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAsInt);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsInt", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonArray;
#pragma warning disable 0169
		static Delegate GetGetAsJsonArrayHandler ()
		{
			if (cb_getAsJsonArray == null)
				cb_getAsJsonArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonArray);
			return cb_getAsJsonArray;
		}

		static IntPtr n_GetAsJsonArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonArray);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJsonArray;
		public virtual unsafe global::Com.Google.Gson.JsonArray AsJsonArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonArray' and count(parameter)=0]"
			[Register ("getAsJsonArray", "()Lcom/google/gson/JsonArray;", "GetGetAsJsonArrayHandler")]
			get {
				if (id_getAsJsonArray == IntPtr.Zero)
					id_getAsJsonArray = JNIEnv.GetMethodID (class_ref, "getAsJsonArray", "()Lcom/google/gson/JsonArray;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonArray> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJsonArray), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonArray> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsJsonArray", "()Lcom/google/gson/JsonArray;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonNull;
#pragma warning disable 0169
		static Delegate GetGetAsJsonNullHandler ()
		{
			if (cb_getAsJsonNull == null)
				cb_getAsJsonNull = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonNull);
			return cb_getAsJsonNull;
		}

		static IntPtr n_GetAsJsonNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonNull);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJsonNull;
		public virtual unsafe global::Com.Google.Gson.JsonNull AsJsonNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonNull' and count(parameter)=0]"
			[Register ("getAsJsonNull", "()Lcom/google/gson/JsonNull;", "GetGetAsJsonNullHandler")]
			get {
				if (id_getAsJsonNull == IntPtr.Zero)
					id_getAsJsonNull = JNIEnv.GetMethodID (class_ref, "getAsJsonNull", "()Lcom/google/gson/JsonNull;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonNull> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJsonNull), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonNull> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsJsonNull", "()Lcom/google/gson/JsonNull;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonObject;
#pragma warning disable 0169
		static Delegate GetGetAsJsonObjectHandler ()
		{
			if (cb_getAsJsonObject == null)
				cb_getAsJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonObject);
			return cb_getAsJsonObject;
		}

		static IntPtr n_GetAsJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonObject);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJsonObject;
		public virtual unsafe global::Com.Google.Gson.JsonObject AsJsonObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonObject' and count(parameter)=0]"
			[Register ("getAsJsonObject", "()Lcom/google/gson/JsonObject;", "GetGetAsJsonObjectHandler")]
			get {
				if (id_getAsJsonObject == IntPtr.Zero)
					id_getAsJsonObject = JNIEnv.GetMethodID (class_ref, "getAsJsonObject", "()Lcom/google/gson/JsonObject;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJsonObject), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonObject> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsJsonObject", "()Lcom/google/gson/JsonObject;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsJsonPrimitive;
#pragma warning disable 0169
		static Delegate GetGetAsJsonPrimitiveHandler ()
		{
			if (cb_getAsJsonPrimitive == null)
				cb_getAsJsonPrimitive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsJsonPrimitive);
			return cb_getAsJsonPrimitive;
		}

		static IntPtr n_GetAsJsonPrimitive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsJsonPrimitive);
		}
#pragma warning restore 0169

		static IntPtr id_getAsJsonPrimitive;
		public virtual unsafe global::Com.Google.Gson.JsonPrimitive AsJsonPrimitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsJsonPrimitive' and count(parameter)=0]"
			[Register ("getAsJsonPrimitive", "()Lcom/google/gson/JsonPrimitive;", "GetGetAsJsonPrimitiveHandler")]
			get {
				if (id_getAsJsonPrimitive == IntPtr.Zero)
					id_getAsJsonPrimitive = JNIEnv.GetMethodID (class_ref, "getAsJsonPrimitive", "()Lcom/google/gson/JsonPrimitive;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonPrimitive> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsJsonPrimitive), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonPrimitive> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsJsonPrimitive", "()Lcom/google/gson/JsonPrimitive;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsLong;
#pragma warning disable 0169
		static Delegate GetGetAsLongHandler ()
		{
			if (cb_getAsLong == null)
				cb_getAsLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAsLong);
			return cb_getAsLong;
		}

		static long n_GetAsLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsLong;
		}
#pragma warning restore 0169

		static IntPtr id_getAsLong;
		public virtual unsafe long AsLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsLong' and count(parameter)=0]"
			[Register ("getAsLong", "()J", "GetGetAsLongHandler")]
			get {
				if (id_getAsLong == IntPtr.Zero)
					id_getAsLong = JNIEnv.GetMethodID (class_ref, "getAsLong", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAsLong);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsLong", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsNumber;
#pragma warning disable 0169
		static Delegate GetGetAsNumberHandler ()
		{
			if (cb_getAsNumber == null)
				cb_getAsNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsNumber);
			return cb_getAsNumber;
		}

		static IntPtr n_GetAsNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getAsNumber;
		public virtual unsafe global::Java.Lang.Number AsNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsNumber' and count(parameter)=0]"
			[Register ("getAsNumber", "()Ljava/lang/Number;", "GetGetAsNumberHandler")]
			get {
				if (id_getAsNumber == IntPtr.Zero)
					id_getAsNumber = JNIEnv.GetMethodID (class_ref, "getAsNumber", "()Ljava/lang/Number;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsNumber), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Number> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsNumber", "()Ljava/lang/Number;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAsShort;
#pragma warning disable 0169
		static Delegate GetGetAsShortHandler ()
		{
			if (cb_getAsShort == null)
				cb_getAsShort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, short>) n_GetAsShort);
			return cb_getAsShort;
		}

		static short n_GetAsShort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsShort;
		}
#pragma warning restore 0169

		static IntPtr id_getAsShort;
		public virtual unsafe short AsShort {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsShort' and count(parameter)=0]"
			[Register ("getAsShort", "()S", "GetGetAsShortHandler")]
			get {
				if (id_getAsShort == IntPtr.Zero)
					id_getAsShort = JNIEnv.GetMethodID (class_ref, "getAsShort", "()S");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallShortMethod (((global::Java.Lang.Object) this).Handle, id_getAsShort);
					else
						return JNIEnv.CallNonvirtualShortMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsShort", "()S"));
				} finally {
				}
			}
		}

		static Delegate cb_getAsString;
#pragma warning disable 0169
		static Delegate GetGetAsStringHandler ()
		{
			if (cb_getAsString == null)
				cb_getAsString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAsString);
			return cb_getAsString;
		}

		static IntPtr n_GetAsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString);
		}
#pragma warning restore 0169

		static IntPtr id_getAsString;
		public virtual unsafe string AsString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='getAsString' and count(parameter)=0]"
			[Register ("getAsString", "()Ljava/lang/String;", "GetGetAsStringHandler")]
			get {
				if (id_getAsString == IntPtr.Zero)
					id_getAsString = JNIEnv.GetMethodID (class_ref, "getAsString", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAsString), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAsString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isJsonArray;
#pragma warning disable 0169
		static Delegate GetIsJsonArrayHandler ()
		{
			if (cb_isJsonArray == null)
				cb_isJsonArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonArray);
			return cb_isJsonArray;
		}

		static bool n_IsJsonArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonArray;
		}
#pragma warning restore 0169

		static IntPtr id_isJsonArray;
		public virtual unsafe bool IsJsonArray {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonArray' and count(parameter)=0]"
			[Register ("isJsonArray", "()Z", "GetIsJsonArrayHandler")]
			get {
				if (id_isJsonArray == IntPtr.Zero)
					id_isJsonArray = JNIEnv.GetMethodID (class_ref, "isJsonArray", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isJsonArray);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isJsonArray", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isJsonNull;
#pragma warning disable 0169
		static Delegate GetIsJsonNullHandler ()
		{
			if (cb_isJsonNull == null)
				cb_isJsonNull = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonNull);
			return cb_isJsonNull;
		}

		static bool n_IsJsonNull (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonNull;
		}
#pragma warning restore 0169

		static IntPtr id_isJsonNull;
		public virtual unsafe bool IsJsonNull {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonNull' and count(parameter)=0]"
			[Register ("isJsonNull", "()Z", "GetIsJsonNullHandler")]
			get {
				if (id_isJsonNull == IntPtr.Zero)
					id_isJsonNull = JNIEnv.GetMethodID (class_ref, "isJsonNull", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isJsonNull);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isJsonNull", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isJsonObject;
#pragma warning disable 0169
		static Delegate GetIsJsonObjectHandler ()
		{
			if (cb_isJsonObject == null)
				cb_isJsonObject = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonObject);
			return cb_isJsonObject;
		}

		static bool n_IsJsonObject (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonObject;
		}
#pragma warning restore 0169

		static IntPtr id_isJsonObject;
		public virtual unsafe bool IsJsonObject {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonObject' and count(parameter)=0]"
			[Register ("isJsonObject", "()Z", "GetIsJsonObjectHandler")]
			get {
				if (id_isJsonObject == IntPtr.Zero)
					id_isJsonObject = JNIEnv.GetMethodID (class_ref, "isJsonObject", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isJsonObject);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isJsonObject", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isJsonPrimitive;
#pragma warning disable 0169
		static Delegate GetIsJsonPrimitiveHandler ()
		{
			if (cb_isJsonPrimitive == null)
				cb_isJsonPrimitive = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsJsonPrimitive);
			return cb_isJsonPrimitive;
		}

		static bool n_IsJsonPrimitive (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Google.Gson.JsonElement __this = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.JsonElement> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsJsonPrimitive;
		}
#pragma warning restore 0169

		static IntPtr id_isJsonPrimitive;
		public virtual unsafe bool IsJsonPrimitive {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson']/class[@name='JsonElement']/method[@name='isJsonPrimitive' and count(parameter)=0]"
			[Register ("isJsonPrimitive", "()Z", "GetIsJsonPrimitiveHandler")]
			get {
				if (id_isJsonPrimitive == IntPtr.Zero)
					id_isJsonPrimitive = JNIEnv.GetMethodID (class_ref, "isJsonPrimitive", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isJsonPrimitive);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isJsonPrimitive", "()Z"));
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/google/gson/JsonElement", DoNotGenerateAcw=true)]
	internal partial class JsonElementInvoker : JsonElement {

		public JsonElementInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (JsonElementInvoker); }
		}

	}

}
