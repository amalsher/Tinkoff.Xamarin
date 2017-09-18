using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/Money", DoNotGenerateAcw=true)]
	public partial class Money : global::Java.Lang.Object, global::Java.IO.ISerializable, global::Java.Lang.IComparable {


		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/field[@name='DEFAULT_INT_DIVIDER']"
		[Register ("DEFAULT_INT_DIVIDER")]
		public const string DefaultIntDivider = (string) " ";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/field[@name='DEFAULT_INT_FRACT_DIVIDER']"
		[Register ("DEFAULT_INT_FRACT_DIVIDER")]
		public const string DefaultIntFractDivider = (string) ",";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/Money", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Money); }
		}

		protected Money (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/constructor[@name='Money' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Money ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (Money)) {
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

		static Delegate cb_getCoins;
#pragma warning disable 0169
		static Delegate GetGetCoinsHandler ()
		{
			if (cb_getCoins == null)
				cb_getCoins = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetCoins);
			return cb_getCoins;
		}

		static long n_GetCoins (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Money __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Coins;
		}
#pragma warning restore 0169

		static IntPtr id_getCoins;
		public virtual unsafe long Coins {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='getCoins' and count(parameter)=0]"
			[Register ("getCoins", "()J", "GetGetCoinsHandler")]
			get {
				if (id_getCoins == IntPtr.Zero)
					id_getCoins = JNIEnv.GetMethodID (class_ref, "getCoins", "()J");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCoins);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCoins", "()J"));
				} finally {
				}
			}
		}

		static Delegate cb_getIntegralDivider;
#pragma warning disable 0169
		static Delegate GetGetIntegralDividerHandler ()
		{
			if (cb_getIntegralDivider == null)
				cb_getIntegralDivider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntegralDivider);
			return cb_getIntegralDivider;
		}

		static IntPtr n_GetIntegralDivider (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Money __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IntegralDivider);
		}
#pragma warning restore 0169

		static Delegate cb_setIntegralDivider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIntegralDivider_Ljava_lang_String_Handler ()
		{
			if (cb_setIntegralDivider_Ljava_lang_String_ == null)
				cb_setIntegralDivider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntegralDivider_Ljava_lang_String_);
			return cb_setIntegralDivider_Ljava_lang_String_;
		}

		static void n_SetIntegralDivider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Money __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IntegralDivider = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIntegralDivider;
		static IntPtr id_setIntegralDivider_Ljava_lang_String_;
		public virtual unsafe string IntegralDivider {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='getIntegralDivider' and count(parameter)=0]"
			[Register ("getIntegralDivider", "()Ljava/lang/String;", "GetGetIntegralDividerHandler")]
			get {
				if (id_getIntegralDivider == IntPtr.Zero)
					id_getIntegralDivider = JNIEnv.GetMethodID (class_ref, "getIntegralDivider", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntegralDivider), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntegralDivider", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='setIntegralDivider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIntegralDivider", "(Ljava/lang/String;)V", "GetSetIntegralDivider_Ljava_lang_String_Handler")]
			set {
				if (id_setIntegralDivider_Ljava_lang_String_ == IntPtr.Zero)
					id_setIntegralDivider_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIntegralDivider", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntegralDivider_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntegralDivider", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getIntegralFractionDivider;
#pragma warning disable 0169
		static Delegate GetGetIntegralFractionDividerHandler ()
		{
			if (cb_getIntegralFractionDivider == null)
				cb_getIntegralFractionDivider = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIntegralFractionDivider);
			return cb_getIntegralFractionDivider;
		}

		static IntPtr n_GetIntegralFractionDivider (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Money __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IntegralFractionDivider);
		}
#pragma warning restore 0169

		static Delegate cb_setIntegralFractionDivider_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetIntegralFractionDivider_Ljava_lang_String_Handler ()
		{
			if (cb_setIntegralFractionDivider_Ljava_lang_String_ == null)
				cb_setIntegralFractionDivider_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIntegralFractionDivider_Ljava_lang_String_);
			return cb_setIntegralFractionDivider_Ljava_lang_String_;
		}

		static void n_SetIntegralFractionDivider_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Money __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IntegralFractionDivider = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getIntegralFractionDivider;
		static IntPtr id_setIntegralFractionDivider_Ljava_lang_String_;
		public virtual unsafe string IntegralFractionDivider {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='getIntegralFractionDivider' and count(parameter)=0]"
			[Register ("getIntegralFractionDivider", "()Ljava/lang/String;", "GetGetIntegralFractionDividerHandler")]
			get {
				if (id_getIntegralFractionDivider == IntPtr.Zero)
					id_getIntegralFractionDivider = JNIEnv.GetMethodID (class_ref, "getIntegralFractionDivider", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIntegralFractionDivider), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntegralFractionDivider", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='setIntegralFractionDivider' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setIntegralFractionDivider", "(Ljava/lang/String;)V", "GetSetIntegralFractionDivider_Ljava_lang_String_Handler")]
			set {
				if (id_setIntegralFractionDivider_Ljava_lang_String_ == IntPtr.Zero)
					id_setIntegralFractionDivider_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setIntegralFractionDivider", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntegralFractionDivider_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntegralFractionDivider", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_compareTo_Lru_tinkoff_acquiring_sdk_Money_;
#pragma warning disable 0169
		static Delegate GetCompareTo_Lru_tinkoff_acquiring_sdk_Money_Handler ()
		{
			if (cb_compareTo_Lru_tinkoff_acquiring_sdk_Money_ == null)
				cb_compareTo_Lru_tinkoff_acquiring_sdk_Money_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CompareTo_Lru_tinkoff_acquiring_sdk_Money_);
			return cb_compareTo_Lru_tinkoff_acquiring_sdk_Money_;
		}

		static int n_CompareTo_Lru_tinkoff_acquiring_sdk_Money_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Money __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Money p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CompareTo (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_compareTo_Lru_tinkoff_acquiring_sdk_Money_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='compareTo' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Money']]"
		[Register ("compareTo", "(Lru/tinkoff/acquiring/sdk/Money;)I", "GetCompareTo_Lru_tinkoff_acquiring_sdk_Money_Handler")]
		public virtual unsafe int CompareTo (global::RU.Tinkoff.Acquiring.Sdk.Money p0)
		{
			if (id_compareTo_Lru_tinkoff_acquiring_sdk_Money_ == IntPtr.Zero)
				id_compareTo_Lru_tinkoff_acquiring_sdk_Money_ = JNIEnv.GetMethodID (class_ref, "compareTo", "(Lru/tinkoff/acquiring/sdk/Money;)I");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				int __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_compareTo_Lru_tinkoff_acquiring_sdk_Money_, __args);
				else
					__ret = JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "compareTo", "(Lru/tinkoff/acquiring/sdk/Money;)I"), __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ofCoins_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='ofCoins' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ofCoins", "(J)Lru/tinkoff/acquiring/sdk/Money;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Money OfCoins (long p0)
		{
			if (id_ofCoins_J == IntPtr.Zero)
				id_ofCoins_J = JNIEnv.GetStaticMethodID (class_ref, "ofCoins", "(J)Lru/tinkoff/acquiring/sdk/Money;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofCoins_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofRubles_D;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='ofRubles' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("ofRubles", "(D)Lru/tinkoff/acquiring/sdk/Money;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Money OfRubles (double p0)
		{
			if (id_ofRubles_D == IntPtr.Zero)
				id_ofRubles_D = JNIEnv.GetStaticMethodID (class_ref, "ofRubles", "(D)Lru/tinkoff/acquiring/sdk/Money;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofRubles_D, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_ofRubles_Ljava_math_BigDecimal_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='ofRubles' and count(parameter)=1 and parameter[1][@type='java.math.BigDecimal']]"
		[Register ("ofRubles", "(Ljava/math/BigDecimal;)Lru/tinkoff/acquiring/sdk/Money;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Money OfRubles (global::Java.Math.BigDecimal p0)
		{
			if (id_ofRubles_Ljava_math_BigDecimal_ == IntPtr.Zero)
				id_ofRubles_Ljava_math_BigDecimal_ = JNIEnv.GetStaticMethodID (class_ref, "ofRubles", "(Ljava/math/BigDecimal;)Lru/tinkoff/acquiring/sdk/Money;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				global::RU.Tinkoff.Acquiring.Sdk.Money __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofRubles_Ljava_math_BigDecimal_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_ofRubles_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='ofRubles' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ofRubles", "(J)Lru/tinkoff/acquiring/sdk/Money;", "")]
		public static unsafe global::RU.Tinkoff.Acquiring.Sdk.Money OfRubles (long p0)
		{
			if (id_ofRubles_J == IntPtr.Zero)
				id_ofRubles_J = JNIEnv.GetStaticMethodID (class_ref, "ofRubles", "(J)Lru/tinkoff/acquiring/sdk/Money;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (JNIEnv.CallStaticObjectMethod  (class_ref, id_ofRubles_J, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toHumanReadableString;
#pragma warning disable 0169
		static Delegate GetToHumanReadableStringHandler ()
		{
			if (cb_toHumanReadableString == null)
				cb_toHumanReadableString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToHumanReadableString);
			return cb_toHumanReadableString;
		}

		static IntPtr n_ToHumanReadableString (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Money __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Money> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToHumanReadableString ());
		}
#pragma warning restore 0169

		static IntPtr id_toHumanReadableString;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='Money']/method[@name='toHumanReadableString' and count(parameter)=0]"
		[Register ("toHumanReadableString", "()Ljava/lang/String;", "GetToHumanReadableStringHandler")]
		public virtual unsafe string ToHumanReadableString ()
		{
			if (id_toHumanReadableString == IntPtr.Zero)
				id_toHumanReadableString = JNIEnv.GetMethodID (class_ref, "toHumanReadableString", "()Ljava/lang/String;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toHumanReadableString), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "toHumanReadableString", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
