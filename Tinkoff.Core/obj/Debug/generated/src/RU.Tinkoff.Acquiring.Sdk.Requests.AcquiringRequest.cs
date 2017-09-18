using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Requests {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/requests/AcquiringRequest", DoNotGenerateAcw=true)]
	public partial class AcquiringRequest : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='AMOUNT']"
		[Register ("AMOUNT")]
		public const string Amount = (string) "Amount";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='CARD_DATA']"
		[Register ("CARD_DATA")]
		public const string CardData = (string) "CardData";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='CARD_ID']"
		[Register ("CARD_ID")]
		public const string CardId = (string) "CardId";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='CUSTOMER_KEY']"
		[Register ("CUSTOMER_KEY")]
		public const string CustomerKey = (string) "CustomerKey";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='CVV']"
		[Register ("CVV")]
		public const string Cvv = (string) "CVV";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='DATA_KEY_EMAIL']"
		[Register ("DATA_KEY_EMAIL")]
		public const string DataKeyEmail = (string) "Email";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='DESCRIPTION']"
		[Register ("DESCRIPTION")]
		public const string Description = (string) "Description";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='EMAIL']"
		[Register ("EMAIL")]
		public const string Email = (string) "InfoEmail";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='LANGUAGE']"
		[Register ("LANGUAGE")]
		public const string Language = (string) "Language";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='ORDER_ID']"
		[Register ("ORDER_ID")]
		public const string OrderId = (string) "OrderId";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='PAYMENT_ID']"
		[Register ("PAYMENT_ID")]
		public const string PaymentId = (string) "PaymentId";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='PAY_FORM']"
		[Register ("PAY_FORM")]
		public const string PayForm = (string) "PayForm";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='PAY_TYPE']"
		[Register ("PAY_TYPE")]
		public const string PayType = (string) "PayType";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='REBILL_ID']"
		[Register ("REBILL_ID")]
		public const string RebillId = (string) "RebillId";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='RECURRENT']"
		[Register ("RECURRENT")]
		public const string Recurrent = (string) "Recurrent";

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/field[@name='SEND_EMAIL']"
		[Register ("SEND_EMAIL")]
		public const string SendEmail = (string) "SendEmail";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/requests/AcquiringRequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AcquiringRequest); }
		}

		protected AcquiringRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getApiMethod;
#pragma warning disable 0169
		static Delegate GetGetApiMethodHandler ()
		{
			if (cb_getApiMethod == null)
				cb_getApiMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApiMethod);
			return cb_getApiMethod;
		}

		static IntPtr n_GetApiMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ApiMethod);
		}
#pragma warning restore 0169

		static IntPtr id_getApiMethod;
		public virtual unsafe string ApiMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/method[@name='getApiMethod' and count(parameter)=0]"
			[Register ("getApiMethod", "()Ljava/lang/String;", "GetGetApiMethodHandler")]
			get {
				if (id_getApiMethod == IntPtr.Zero)
					id_getApiMethod = JNIEnv.GetMethodID (class_ref, "getApiMethod", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApiMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getApiMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTerminalKey;
#pragma warning disable 0169
		static Delegate GetGetTerminalKeyHandler ()
		{
			if (cb_getTerminalKey == null)
				cb_getTerminalKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTerminalKey);
			return cb_getTerminalKey;
		}

		static IntPtr n_GetTerminalKey (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TerminalKey);
		}
#pragma warning restore 0169

		static IntPtr id_getTerminalKey;
		public virtual unsafe string TerminalKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/method[@name='getTerminalKey' and count(parameter)=0]"
			[Register ("getTerminalKey", "()Ljava/lang/String;", "GetGetTerminalKeyHandler")]
			get {
				if (id_getTerminalKey == IntPtr.Zero)
					id_getTerminalKey = JNIEnv.GetMethodID (class_ref, "getTerminalKey", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTerminalKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTerminalKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTokenIgnoreFields;
#pragma warning disable 0169
		static Delegate GetGetTokenIgnoreFieldsHandler ()
		{
			if (cb_getTokenIgnoreFields == null)
				cb_getTokenIgnoreFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTokenIgnoreFields);
			return cb_getTokenIgnoreFields;
		}

		static IntPtr n_GetTokenIgnoreFields (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaSet<string>.ToLocalJniHandle (__this.TokenIgnoreFields);
		}
#pragma warning restore 0169

		static IntPtr id_getTokenIgnoreFields;
		public virtual unsafe global::System.Collections.Generic.ICollection<string> TokenIgnoreFields {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/method[@name='getTokenIgnoreFields' and count(parameter)=0]"
			[Register ("getTokenIgnoreFields", "()Ljava/util/Set;", "GetGetTokenIgnoreFieldsHandler")]
			get {
				if (id_getTokenIgnoreFields == IntPtr.Zero)
					id_getTokenIgnoreFields = JNIEnv.GetMethodID (class_ref, "getTokenIgnoreFields", "()Ljava/util/Set;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTokenIgnoreFields), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaSet<string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTokenIgnoreFields", "()Ljava/util/Set;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_asMap;
#pragma warning disable 0169
		static Delegate GetAsMapHandler ()
		{
			if (cb_asMap == null)
				cb_asMap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsMap);
			return cb_asMap;
		}

		static IntPtr n_AsMap (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (__this.AsMap ());
		}
#pragma warning restore 0169

		static IntPtr id_asMap;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/method[@name='asMap' and count(parameter)=0]"
		[Register ("asMap", "()Ljava/util/Map;", "GetAsMapHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, string> AsMap ()
		{
			if (id_asMap == IntPtr.Zero)
				id_asMap = JNIEnv.GetMethodID (class_ref, "asMap", "()Ljava/util/Map;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asMap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "asMap", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetPutIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_PutIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_);
			return cb_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		}

		static void n_PutIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Requests.AcquiringRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.PutIfNotNull (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.requests']/class[@name='AcquiringRequest']/method[@name='putIfNotNull' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;']]"
		[Register ("putIfNotNull", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V", "GetPutIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_Handler")]
		protected virtual unsafe void PutIfNotNull (string p0, string p1, global::System.Collections.Generic.IDictionary<string, string> p2)
		{
			if (id_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "putIfNotNull", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_putIfNotNull_Ljava_lang_String_Ljava_lang_String_Ljava_util_Map_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "putIfNotNull", "(Ljava/lang/String;Ljava/lang/String;Ljava/util/Map;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

	}
}
