using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk.Views {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView", DoNotGenerateAcw=true)]
	public partial class EditCardView : global::Android.Views.ViewGroup {

		// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/interface[@name='EditCardView.Actions']"
		[Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$Actions", "", "RU.Tinkoff.Acquiring.Sdk.Views.EditCardView/IActionsInvoker")]
		public partial interface IActions : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/interface[@name='EditCardView.Actions']/method[@name='onPressScanCard' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.views.EditCardView']]"
			[Register ("onPressScanCard", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;)V", "GetOnPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_Handler:RU.Tinkoff.Acquiring.Sdk.Views.EditCardView/IActionsInvoker, Tinkoff.UI")]
			void OnPressScanCard (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView p0);

			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/interface[@name='EditCardView.Actions']/method[@name='onUpdate' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.views.EditCardView']]"
			[Register ("onUpdate", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;)V", "GetOnUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_Handler:RU.Tinkoff.Acquiring.Sdk.Views.EditCardView/IActionsInvoker, Tinkoff.UI")]
			void OnUpdate (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView p0);

		}

		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$Actions", DoNotGenerateAcw=true)]
		internal class IActionsInvoker : global::Java.Lang.Object, IActions {

			static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$Actions");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IActionsInvoker); }
			}

			IntPtr class_ref;

			public static IActions GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IActions> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.views.EditCardView.Actions"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IActionsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_;
#pragma warning disable 0169
			static Delegate GetOnPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_Handler ()
			{
				if (cb_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_ == null)
					cb_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_);
				return cb_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_;
			}

			static void n_OnPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPressScanCard (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_;
			public unsafe void OnPressScanCard (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView p0)
			{
				if (id_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_ == IntPtr.Zero)
					id_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_ = JNIEnv.GetMethodID (class_ref, "onPressScanCard", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPressScanCard_Lru_tinkoff_acquiring_sdk_views_EditCardView_, __args);
			}

			static Delegate cb_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_;
#pragma warning disable 0169
			static Delegate GetOnUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_Handler ()
			{
				if (cb_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_ == null)
					cb_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_);
				return cb_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_;
			}

			static void n_OnUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView p0 = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnUpdate (p0);
			}
#pragma warning restore 0169

			IntPtr id_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_;
			public unsafe void OnUpdate (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView p0)
			{
				if (id_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_ == IntPtr.Zero)
					id_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_ = JNIEnv.GetMethodID (class_ref, "onUpdate", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onUpdate_Lru_tinkoff_acquiring_sdk_views_EditCardView_, __args);
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$CardFormatter", DoNotGenerateAcw=true)]
		public partial class CardFormatter : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public const int Default = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/field[@name='MAESTRO']"
			[Register ("MAESTRO")]
			public const int Maestro = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/field[@name='UNKNOWN']"
			[Register ("UNKNOWN")]
			public const int Unknown = (int) 0;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$CardFormatter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CardFormatter); }
			}

			protected CardFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/constructor[@name='EditCardView.CardFormatter' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.views.EditCardView']]"
			[Register (".ctor", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;)V", "")]
			public unsafe CardFormatter (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (__self);
					if (((object) this).GetType () != typeof (CardFormatter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V", __args);
						return;
					}

					if (id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_ == IntPtr.Zero)
						id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_, __args);
				} finally {
				}
			}

			static Delegate cb_isLimited;
#pragma warning disable 0169
			static Delegate GetIsLimitedHandler ()
			{
				if (cb_isLimited == null)
					cb_isLimited = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLimited);
				return cb_isLimited;
			}

			static bool n_IsLimited (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsLimited;
			}
#pragma warning restore 0169

			static IntPtr id_isLimited;
			public virtual unsafe bool IsLimited {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/method[@name='isLimited' and count(parameter)=0]"
				[Register ("isLimited", "()Z", "GetIsLimitedHandler")]
				get {
					if (id_isLimited == IntPtr.Zero)
						id_isLimited = JNIEnv.GetMethodID (class_ref, "isLimited", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isLimited);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isLimited", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getMaxLength;
#pragma warning disable 0169
			static Delegate GetGetMaxLengthHandler ()
			{
				if (cb_getMaxLength == null)
					cb_getMaxLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxLength);
				return cb_getMaxLength;
			}

			static int n_GetMaxLength (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.MaxLength;
			}
#pragma warning restore 0169

			static IntPtr id_getMaxLength;
			public virtual unsafe int MaxLength {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/method[@name='getMaxLength' and count(parameter)=0]"
				[Register ("getMaxLength", "()I", "GetGetMaxLengthHandler")]
				get {
					if (id_getMaxLength == IntPtr.Zero)
						id_getMaxLength = JNIEnv.GetMethodID (class_ref, "getMaxLength", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxLength);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxLength", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetDoFormat_Ljava_lang_String_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_ == null)
					cb_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DoFormat_Ljava_lang_String_Ljava_lang_CharSequence_);
				return cb_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_;
			}

			static IntPtr n_DoFormat_Ljava_lang_String_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.DoFormat (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/method[@name='doFormat' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence']]"
			[Register ("doFormat", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/String;", "GetDoFormat_Ljava_lang_String_Ljava_lang_CharSequence_Handler")]
			protected virtual unsafe string DoFormat (string p0, global::Java.Lang.ICharSequence p1)
			{
				if (id_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "doFormat", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					string __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_doFormat_Ljava_lang_String_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "doFormat", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			protected string DoFormat (string p0, string p1)
			{
				global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
				string __result = DoFormat (p0, jls_p1);
				if (jls_p1 != null) jls_p1.Dispose ();
				return __result;
			}

			static Delegate cb_format_Ljava_lang_String_Ljava_lang_CharSequence_;
#pragma warning disable 0169
			static Delegate GetFormat_Ljava_lang_String_Ljava_lang_CharSequence_Handler ()
			{
				if (cb_format_Ljava_lang_String_Ljava_lang_CharSequence_ == null)
					cb_format_Ljava_lang_String_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Format_Ljava_lang_String_Ljava_lang_CharSequence_);
				return cb_format_Ljava_lang_String_Ljava_lang_CharSequence_;
			}

			static IntPtr n_Format_Ljava_lang_String_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.ICharSequence p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_p1, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.NewString (__this.Format (p0, p1));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_format_Ljava_lang_String_Ljava_lang_CharSequence_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/method[@name='format' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.CharSequence']]"
			[Register ("format", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/String;", "GetFormat_Ljava_lang_String_Ljava_lang_CharSequence_Handler")]
			public virtual unsafe string Format (string p0, global::Java.Lang.ICharSequence p1)
			{
				if (id_format_Ljava_lang_String_Ljava_lang_CharSequence_ == IntPtr.Zero)
					id_format_Ljava_lang_String_Ljava_lang_CharSequence_ = JNIEnv.GetMethodID (class_ref, "format", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/String;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = CharSequence.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);

					string __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_format_Ljava_lang_String_Ljava_lang_CharSequence_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "format", "(Ljava/lang/String;Ljava/lang/CharSequence;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

			public string Format (string p0, string p1)
			{
				global::Java.Lang.String jls_p1 = p1 == null ? null : new global::Java.Lang.String (p1);
				string __result = Format (p0, jls_p1);
				if (jls_p1 != null) jls_p1.Dispose ();
				return __result;
			}

			static Delegate cb_getValidationRanges;
#pragma warning disable 0169
			static Delegate GetGetValidationRangesHandler ()
			{
				if (cb_getValidationRanges == null)
					cb_getValidationRanges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValidationRanges);
				return cb_getValidationRanges;
			}

			static IntPtr n_GetValidationRanges (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetValidationRanges ());
			}
#pragma warning restore 0169

			static IntPtr id_getValidationRanges;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/method[@name='getValidationRanges' and count(parameter)=0]"
			[Register ("getValidationRanges", "()[I", "GetGetValidationRangesHandler")]
			public virtual unsafe int[] GetValidationRanges ()
			{
				if (id_getValidationRanges == IntPtr.Zero)
					id_getValidationRanges = JNIEnv.GetMethodID (class_ref, "getValidationRanges", "()[I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValidationRanges), JniHandleOwnership.TransferLocalRef, typeof (int));
					else
						return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getValidationRanges", "()[I")), JniHandleOwnership.TransferLocalRef, typeof (int));
				} finally {
				}
			}

			static Delegate cb_isNeedToCheck_I;
#pragma warning disable 0169
			static Delegate GetIsNeedToCheck_IHandler ()
			{
				if (cb_isNeedToCheck_I == null)
					cb_isNeedToCheck_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_IsNeedToCheck_I);
				return cb_isNeedToCheck_I;
			}

			static bool n_IsNeedToCheck_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsNeedToCheck (p0);
			}
#pragma warning restore 0169

			static IntPtr id_isNeedToCheck_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/method[@name='isNeedToCheck' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("isNeedToCheck", "(I)Z", "GetIsNeedToCheck_IHandler")]
			public virtual unsafe bool IsNeedToCheck (int p0)
			{
				if (id_isNeedToCheck_I == IntPtr.Zero)
					id_isNeedToCheck_I = JNIEnv.GetMethodID (class_ref, "isNeedToCheck", "(I)Z");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isNeedToCheck_I, __args);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isNeedToCheck", "(I)Z"), __args);
				} finally {
				}
			}

			static Delegate cb_setType_I;
#pragma warning disable 0169
			static Delegate GetSetType_IHandler ()
			{
				if (cb_setType_I == null)
					cb_setType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetType_I);
				return cb_setType_I;
			}

			static void n_SetType_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetType (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setType_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardFormatter']/method[@name='setType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setType", "(I)V", "GetSetType_IHandler")]
			public virtual unsafe void SetType (int p0)
			{
				if (id_setType_I == IntPtr.Zero)
					id_setType_I = JNIEnv.GetMethodID (class_ref, "setType", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setType_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setType", "(I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$CardNumberEditText", DoNotGenerateAcw=true)]
		public partial class CardNumberEditText : global::Android.Widget.EditText {


			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/field[@name='FULL_MODE']"
			[Register ("FULL_MODE")]
			public const int FullMode = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/field[@name='SHORT_MODE']"
			[Register ("SHORT_MODE")]
			public const int ShortMode = (int) 1;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$CardNumberEditText", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CardNumberEditText); }
			}

			protected CardNumberEditText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_content_Context_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/constructor[@name='EditCardView.CardNumberEditText' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
			[Register (".ctor", "(Landroid/content/Context;)V", "")]
			public unsafe CardNumberEditText (global::Android.Content.Context p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (CardNumberEditText)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/constructor[@name='EditCardView.CardNumberEditText' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
			[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
			public unsafe CardNumberEditText (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (CardNumberEditText)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
						return;
					}

					if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
						id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
				} finally {
				}
			}

			static Delegate cb_getCustomOnFocusChangedListener;
#pragma warning disable 0169
			static Delegate GetGetCustomOnFocusChangedListenerHandler ()
			{
				if (cb_getCustomOnFocusChangedListener == null)
					cb_getCustomOnFocusChangedListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCustomOnFocusChangedListener);
				return cb_getCustomOnFocusChangedListener;
			}

			static IntPtr n_GetCustomOnFocusChangedListener (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.CustomOnFocusChangedListener);
			}
#pragma warning restore 0169

			static Delegate cb_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_;
#pragma warning disable 0169
			static Delegate GetSetCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_Handler ()
			{
				if (cb_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_ == null)
					cb_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_);
				return cb_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_;
			}

			static void n_SetCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View.IOnFocusChangeListener p0 = (global::Android.Views.View.IOnFocusChangeListener)global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnFocusChangeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.CustomOnFocusChangedListener = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getCustomOnFocusChangedListener;
			static IntPtr id_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_;
			public virtual unsafe global::Android.Views.View.IOnFocusChangeListener CustomOnFocusChangedListener {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/method[@name='getCustomOnFocusChangedListener' and count(parameter)=0]"
				[Register ("getCustomOnFocusChangedListener", "()Landroid/view/View$OnFocusChangeListener;", "GetGetCustomOnFocusChangedListenerHandler")]
				get {
					if (id_getCustomOnFocusChangedListener == IntPtr.Zero)
						id_getCustomOnFocusChangedListener = JNIEnv.GetMethodID (class_ref, "getCustomOnFocusChangedListener", "()Landroid/view/View$OnFocusChangeListener;");
					try {

						if (((object) this).GetType () == ThresholdType)
							return global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnFocusChangeListener> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCustomOnFocusChangedListener), JniHandleOwnership.TransferLocalRef);
						else
							return global::Java.Lang.Object.GetObject<global::Android.Views.View.IOnFocusChangeListener> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCustomOnFocusChangedListener", "()Landroid/view/View$OnFocusChangeListener;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/method[@name='setCustomOnFocusChangedListener' and count(parameter)=1 and parameter[1][@type='android.view.View.OnFocusChangeListener']]"
				[Register ("setCustomOnFocusChangedListener", "(Landroid/view/View$OnFocusChangeListener;)V", "GetSetCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_Handler")]
				set {
					if (id_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_ == IntPtr.Zero)
						id_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_ = JNIEnv.GetMethodID (class_ref, "setCustomOnFocusChangedListener", "(Landroid/view/View$OnFocusChangeListener;)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCustomOnFocusChangedListener_Landroid_view_View_OnFocusChangeListener_, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCustomOnFocusChangedListener", "(Landroid/view/View$OnFocusChangeListener;)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_getMode;
#pragma warning disable 0169
			static Delegate GetGetModeHandler ()
			{
				if (cb_getMode == null)
					cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMode);
				return cb_getMode;
			}

			static int n_GetMode (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Mode;
			}
#pragma warning restore 0169

			static Delegate cb_setMode_I;
#pragma warning disable 0169
			static Delegate GetSetMode_IHandler ()
			{
				if (cb_setMode_I == null)
					cb_setMode_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMode_I);
				return cb_setMode_I;
			}

			static void n_SetMode_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Mode = p0;
			}
#pragma warning restore 0169

			static IntPtr id_getMode;
			static IntPtr id_setMode_I;
			public virtual unsafe int Mode {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/method[@name='getMode' and count(parameter)=0]"
				[Register ("getMode", "()I", "GetGetModeHandler")]
				get {
					if (id_getMode == IntPtr.Zero)
						id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMode);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMode", "()I"));
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='int']]"
				[Register ("setMode", "(I)V", "GetSetMode_IHandler")]
				set {
					if (id_setMode_I == IntPtr.Zero)
						id_setMode_I = JNIEnv.GetMethodID (class_ref, "setMode", "(I)V");
					try {
						JValue* __args = stackalloc JValue [1];
						__args [0] = new JValue (value);

						if (((object) this).GetType () == ThresholdType)
							JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_I, __args);
						else
							JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(I)V"), __args);
					} finally {
					}
				}
			}

			static Delegate cb_setAnimationFactor_F;
#pragma warning disable 0169
			static Delegate GetSetAnimationFactor_FHandler ()
			{
				if (cb_setAnimationFactor_F == null)
					cb_setAnimationFactor_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAnimationFactor_F);
				return cb_setAnimationFactor_F;
			}

			static void n_SetAnimationFactor_F (IntPtr jnienv, IntPtr native__this, float p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.CardNumberEditText> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetAnimationFactor (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setAnimationFactor_F;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.CardNumberEditText']/method[@name='setAnimationFactor' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAnimationFactor", "(F)V", "GetSetAnimationFactor_FHandler")]
			public virtual unsafe void SetAnimationFactor (float p0)
			{
				if (id_setAnimationFactor_F == IntPtr.Zero)
					id_setAnimationFactor_F = JNIEnv.GetMethodID (class_ref, "setAnimationFactor", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAnimationFactor_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAnimationFactor", "(F)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath interface reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/interface[@name='EditCardView.CardSystemIconsHolder']"
		[Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$CardSystemIconsHolder", "", "RU.Tinkoff.Acquiring.Sdk.Views.EditCardView/ICardSystemIconsHolderInvoker")]
		public partial interface ICardSystemIconsHolder : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/interface[@name='EditCardView.CardSystemIconsHolder']/method[@name='getCardSystemBitmap' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("getCardSystemBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;", "GetGetCardSystemBitmap_Ljava_lang_String_Handler:RU.Tinkoff.Acquiring.Sdk.Views.EditCardView/ICardSystemIconsHolderInvoker, Tinkoff.UI")]
			global::Android.Graphics.Bitmap GetCardSystemBitmap (string p0);

		}

		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$CardSystemIconsHolder", DoNotGenerateAcw=true)]
		internal class ICardSystemIconsHolderInvoker : global::Java.Lang.Object, ICardSystemIconsHolder {

			static IntPtr java_class_ref = JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$CardSystemIconsHolder");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ICardSystemIconsHolderInvoker); }
			}

			IntPtr class_ref;

			public static ICardSystemIconsHolder GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ICardSystemIconsHolder> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "ru.tinkoff.acquiring.sdk.views.EditCardView.CardSystemIconsHolder"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ICardSystemIconsHolderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getCardSystemBitmap_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetGetCardSystemBitmap_Ljava_lang_String_Handler ()
			{
				if (cb_getCardSystemBitmap_Ljava_lang_String_ == null)
					cb_getCardSystemBitmap_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetCardSystemBitmap_Ljava_lang_String_);
				return cb_getCardSystemBitmap_Ljava_lang_String_;
			}

			static IntPtr n_GetCardSystemBitmap_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.ICardSystemIconsHolder __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.ICardSystemIconsHolder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetCardSystemBitmap (p0));
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_getCardSystemBitmap_Ljava_lang_String_;
			public unsafe global::Android.Graphics.Bitmap GetCardSystemBitmap (string p0)
			{
				if (id_getCardSystemBitmap_Ljava_lang_String_ == IntPtr.Zero)
					id_getCardSystemBitmap_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getCardSystemBitmap", "(Ljava/lang/String;)Landroid/graphics/Bitmap;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Android.Graphics.Bitmap __ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardSystemBitmap_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				JNIEnv.DeleteLocalRef (native_p0);
				return __ret;
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.DisableCopyPasteActionModeCallback']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$DisableCopyPasteActionModeCallback", DoNotGenerateAcw=true)]
		public partial class DisableCopyPasteActionModeCallback : global::Java.Lang.Object, global::Android.Views.ActionMode.ICallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$DisableCopyPasteActionModeCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (DisableCopyPasteActionModeCallback); }
			}

			protected DisableCopyPasteActionModeCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_;
#pragma warning disable 0169
			static Delegate GetOnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_Handler ()
			{
				if (cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ == null)
					cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_);
				return cb_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_;
			}

			static bool n_OnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenuItem p1 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnActionItemClicked (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.DisableCopyPasteActionModeCallback']/method[@name='onActionItemClicked' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode'] and parameter[2][@type='android.view.MenuItem']]"
			[Register ("onActionItemClicked", "(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z", "GetOnActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_Handler")]
			public virtual unsafe bool OnActionItemClicked (global::Android.Views.ActionMode p0, global::Android.Views.IMenuItem p1)
			{
				if (id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ == IntPtr.Zero)
					id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onActionItemClicked", "(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onActionItemClicked_Landroid_view_ActionMode_Landroid_view_MenuItem_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActionItemClicked", "(Landroid/view/ActionMode;Landroid/view/MenuItem;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler ()
			{
				if (cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == null)
					cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_);
				return cb_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
			}

			static bool n_OnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreateActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.DisableCopyPasteActionModeCallback']/method[@name='onCreateActionMode' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
			[Register ("onCreateActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", "GetOnCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler")]
			public virtual unsafe bool OnCreateActionMode (global::Android.Views.ActionMode p0, global::Android.Views.IMenu p1)
			{
				if (id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
					id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCreateActionMode_Landroid_view_ActionMode_Landroid_view_Menu_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onDestroyActionMode_Landroid_view_ActionMode_;
#pragma warning disable 0169
			static Delegate GetOnDestroyActionMode_Landroid_view_ActionMode_Handler ()
			{
				if (cb_onDestroyActionMode_Landroid_view_ActionMode_ == null)
					cb_onDestroyActionMode_Landroid_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroyActionMode_Landroid_view_ActionMode_);
				return cb_onDestroyActionMode_Landroid_view_ActionMode_;
			}

			static void n_OnDestroyActionMode_Landroid_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyActionMode (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDestroyActionMode_Landroid_view_ActionMode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.DisableCopyPasteActionModeCallback']/method[@name='onDestroyActionMode' and count(parameter)=1 and parameter[1][@type='android.view.ActionMode']]"
			[Register ("onDestroyActionMode", "(Landroid/view/ActionMode;)V", "GetOnDestroyActionMode_Landroid_view_ActionMode_Handler")]
			public virtual unsafe void OnDestroyActionMode (global::Android.Views.ActionMode p0)
			{
				if (id_onDestroyActionMode_Landroid_view_ActionMode_ == IntPtr.Zero)
					id_onDestroyActionMode_Landroid_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onDestroyActionMode", "(Landroid/view/ActionMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroyActionMode_Landroid_view_ActionMode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroyActionMode", "(Landroid/view/ActionMode;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler ()
			{
				if (cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == null)
					cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_);
				return cb_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
			}

			static bool n_OnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.DisableCopyPasteActionModeCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Views.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPrepareActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.DisableCopyPasteActionModeCallback']/method[@name='onPrepareActionMode' and count(parameter)=2 and parameter[1][@type='android.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
			[Register ("onPrepareActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z", "GetOnPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_Handler")]
			public virtual unsafe bool OnPrepareActionMode (global::Android.Views.ActionMode p0, global::Android.Views.IMenu p1)
			{
				if (id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
					id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPrepareActionMode_Landroid_view_ActionMode_Landroid_view_Menu_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareActionMode", "(Landroid/view/ActionMode;Landroid/view/Menu;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.MutableColorSpan']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$MutableColorSpan", DoNotGenerateAcw=true)]
		public partial class MutableColorSpan : global::Android.Text.Style.CharacterStyle, global::Android.Text.Style.IUpdateAppearance {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$MutableColorSpan", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MutableColorSpan); }
			}

			protected MutableColorSpan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.MutableColorSpan']/constructor[@name='EditCardView.MutableColorSpan' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe MutableColorSpan (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (MutableColorSpan)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
						return;
					}

					if (id_ctor_I == IntPtr.Zero)
						id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
				} finally {
				}
			}

			static Delegate cb_setAlpha_I;
#pragma warning disable 0169
			static Delegate GetSetAlpha_IHandler ()
			{
				if (cb_setAlpha_I == null)
					cb_setAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAlpha_I);
				return cb_setAlpha_I;
			}

			static void n_SetAlpha_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.MutableColorSpan __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.MutableColorSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetAlpha (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setAlpha_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.MutableColorSpan']/method[@name='setAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAlpha", "(I)V", "GetSetAlpha_IHandler")]
			public virtual unsafe void SetAlpha (int p0)
			{
				if (id_setAlpha_I == IntPtr.Zero)
					id_setAlpha_I = JNIEnv.GetMethodID (class_ref, "setAlpha", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAlpha_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAlpha", "(I)V"), __args);
				} finally {
				}
			}

			static Delegate cb_updateDrawState_Landroid_text_TextPaint_;
#pragma warning disable 0169
			static Delegate GetUpdateDrawState_Landroid_text_TextPaint_Handler ()
			{
				if (cb_updateDrawState_Landroid_text_TextPaint_ == null)
					cb_updateDrawState_Landroid_text_TextPaint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UpdateDrawState_Landroid_text_TextPaint_);
				return cb_updateDrawState_Landroid_text_TextPaint_;
			}

			static void n_UpdateDrawState_Landroid_text_TextPaint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.MutableColorSpan __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.MutableColorSpan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Text.TextPaint p0 = global::Java.Lang.Object.GetObject<global::Android.Text.TextPaint> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.UpdateDrawState (p0);
			}
#pragma warning restore 0169

			static IntPtr id_updateDrawState_Landroid_text_TextPaint_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.MutableColorSpan']/method[@name='updateDrawState' and count(parameter)=1 and parameter[1][@type='android.text.TextPaint']]"
			[Register ("updateDrawState", "(Landroid/text/TextPaint;)V", "GetUpdateDrawState_Landroid_text_TextPaint_Handler")]
			public override unsafe void UpdateDrawState (global::Android.Text.TextPaint p0)
			{
				if (id_updateDrawState_Landroid_text_TextPaint_ == IntPtr.Zero)
					id_updateDrawState_Landroid_text_TextPaint_ = JNIEnv.GetMethodID (class_ref, "updateDrawState", "(Landroid/text/TextPaint;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateDrawState_Landroid_text_TextPaint_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateDrawState", "(Landroid/text/TextPaint;)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SavedState']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$SavedState", DoNotGenerateAcw=true)]
		public partial class SavedState : global::Android.Views.View.BaseSavedState {


			static IntPtr CREATOR_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SavedState']/field[@name='CREATOR']"
			[Register ("CREATOR")]
			public static global::Android.OS.IParcelableCreator Creator {
				get {
					if (CREATOR_jfieldId == IntPtr.Zero)
						CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$SavedState", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SavedState); }
			}

			protected SavedState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/views/EditCardView$SimpleButton", DoNotGenerateAcw=true)]
		public partial class SimpleButton : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView$SimpleButton", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (SimpleButton); }
			}

			protected SimpleButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/constructor[@name='EditCardView.SimpleButton' and count(parameter)=2 and parameter[1][@type='ru.tinkoff.acquiring.sdk.views.EditCardView'] and parameter[2][@type='android.graphics.Bitmap']]"
			[Register (".ctor", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;Landroid/graphics/Bitmap;)V", "")]
			public unsafe SimpleButton (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __self, global::Android.Graphics.Bitmap p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (__self);
					__args [1] = new JValue (p1);
					if (((object) this).GetType () != typeof (SimpleButton)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/graphics/Bitmap;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/graphics/Bitmap;)V", __args);
						return;
					}

					if (id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_Landroid_graphics_Bitmap_ == IntPtr.Zero)
						id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/acquiring/sdk/views/EditCardView;Landroid/graphics/Bitmap;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_Landroid_graphics_Bitmap_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_views_EditCardView_Landroid_graphics_Bitmap_, __args);
				} finally {
				}
			}

			static Delegate cb_getHeight;
#pragma warning disable 0169
			static Delegate GetGetHeightHandler ()
			{
				if (cb_getHeight == null)
					cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
				return cb_getHeight;
			}

			static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Height;
			}
#pragma warning restore 0169

			static IntPtr id_getHeight;
			public virtual unsafe int Height {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/method[@name='getHeight' and count(parameter)=0]"
				[Register ("getHeight", "()I", "GetGetHeightHandler")]
				get {
					if (id_getHeight == IntPtr.Zero)
						id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHeight", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_isVisible;
#pragma warning disable 0169
			static Delegate GetIsVisibleHandler ()
			{
				if (cb_isVisible == null)
					cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
				return cb_isVisible;
			}

			static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.IsVisible;
			}
#pragma warning restore 0169

			static IntPtr id_isVisible;
			public virtual unsafe bool IsVisible {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/method[@name='isVisible' and count(parameter)=0]"
				[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
				get {
					if (id_isVisible == IntPtr.Zero)
						id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
						else
							return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isVisible", "()Z"));
					} finally {
					}
				}
			}

			static Delegate cb_getWidth;
#pragma warning disable 0169
			static Delegate GetGetWidthHandler ()
			{
				if (cb_getWidth == null)
					cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
				return cb_getWidth;
			}

			static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Width;
			}
#pragma warning restore 0169

			static IntPtr id_getWidth;
			public virtual unsafe int Width {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/method[@name='getWidth' and count(parameter)=0]"
				[Register ("getWidth", "()I", "GetGetWidthHandler")]
				get {
					if (id_getWidth == IntPtr.Zero)
						id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getWidth", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
#pragma warning disable 0169
			static Delegate GetDrawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler ()
			{
				if (cb_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == null)
					cb_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_);
				return cb_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
			}

			static void n_DrawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Paint p1 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p1, JniHandleOwnership.DoNotTransfer);
				__this.DrawWithPaint (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/method[@name='drawWithPaint' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Paint']]"
			[Register ("drawWithPaint", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V", "GetDrawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_Handler")]
			protected virtual unsafe void DrawWithPaint (global::Android.Graphics.Canvas p0, global::Android.Graphics.Paint p1)
			{
				if (id_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_ == IntPtr.Zero)
					id_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "drawWithPaint", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_drawWithPaint_Landroid_graphics_Canvas_Landroid_graphics_Paint_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "drawWithPaint", "(Landroid/graphics/Canvas;Landroid/graphics/Paint;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_layoutIn_II;
#pragma warning disable 0169
			static Delegate GetLayoutIn_IIHandler ()
			{
				if (cb_layoutIn_II == null)
					cb_layoutIn_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_LayoutIn_II);
				return cb_layoutIn_II;
			}

			static void n_LayoutIn_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.LayoutIn (p0, p1);
			}
#pragma warning restore 0169

			static IntPtr id_layoutIn_II;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/method[@name='layoutIn' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("layoutIn", "(II)V", "GetLayoutIn_IIHandler")]
			protected virtual unsafe void LayoutIn (int p0, int p1)
			{
				if (id_layoutIn_II == IntPtr.Zero)
					id_layoutIn_II = JNIEnv.GetMethodID (class_ref, "layoutIn", "(II)V");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_layoutIn_II, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "layoutIn", "(II)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
			static Delegate GetSetBitmap_Landroid_graphics_Bitmap_Handler ()
			{
				if (cb_setBitmap_Landroid_graphics_Bitmap_ == null)
					cb_setBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitmap_Landroid_graphics_Bitmap_);
				return cb_setBitmap_Landroid_graphics_Bitmap_;
			}

			static void n_SetBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.SetBitmap (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setBitmap_Landroid_graphics_Bitmap_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
			public virtual unsafe void SetBitmap (global::Android.Graphics.Bitmap p0)
			{
				if (id_setBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setBitmap", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBitmap_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_setVisibility_Z;
#pragma warning disable 0169
			static Delegate GetSetVisibility_ZHandler ()
			{
				if (cb_setVisibility_Z == null)
					cb_setVisibility_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisibility_Z);
				return cb_setVisibility_Z;
			}

			static void n_SetVisibility_Z (IntPtr jnienv, IntPtr native__this, bool p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.SimpleButton> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetVisibility (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setVisibility_Z;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView.SimpleButton']/method[@name='setVisibility' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisibility", "(Z)V", "GetSetVisibility_ZHandler")]
			public virtual unsafe void SetVisibility (bool p0)
			{
				if (id_setVisibility_Z == IntPtr.Zero)
					id_setVisibility_Z = JNIEnv.GetMethodID (class_ref, "setVisibility", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisibility_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVisibility", "(Z)V"), __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/views/EditCardView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (EditCardView); }
		}

		protected EditCardView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/constructor[@name='EditCardView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe EditCardView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				if (((object) this).GetType () != typeof (EditCardView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/constructor[@name='EditCardView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe EditCardView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				if (((object) this).GetType () != typeof (EditCardView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/constructor[@name='EditCardView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe EditCardView (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (EditCardView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getCardNumber;
#pragma warning disable 0169
		static Delegate GetGetCardNumberHandler ()
		{
			if (cb_getCardNumber == null)
				cb_getCardNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardNumber);
			return cb_getCardNumber;
		}

		static IntPtr n_GetCardNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setCardNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setCardNumber_Ljava_lang_String_ == null)
				cb_setCardNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCardNumber_Ljava_lang_String_);
			return cb_setCardNumber_Ljava_lang_String_;
		}

		static void n_SetCardNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.CardNumber = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCardNumber;
		static IntPtr id_setCardNumber_Ljava_lang_String_;
		public virtual unsafe string CardNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='getCardNumber' and count(parameter)=0]"
			[Register ("getCardNumber", "()Ljava/lang/String;", "GetGetCardNumberHandler")]
			get {
				if (id_getCardNumber == IntPtr.Zero)
					id_getCardNumber = JNIEnv.GetMethodID (class_ref, "getCardNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setCardNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCardNumber", "(Ljava/lang/String;)V", "GetSetCardNumber_Ljava_lang_String_Handler")]
			set {
				if (id_setCardNumber_Ljava_lang_String_ == IntPtr.Zero)
					id_setCardNumber_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardNumber", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardNumber_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardNumber", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCardSystemLogoAnimationFactor;
#pragma warning disable 0169
		static Delegate GetGetCardSystemLogoAnimationFactorHandler ()
		{
			if (cb_getCardSystemLogoAnimationFactor == null)
				cb_getCardSystemLogoAnimationFactor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCardSystemLogoAnimationFactor);
			return cb_getCardSystemLogoAnimationFactor;
		}

		static float n_GetCardSystemLogoAnimationFactor (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CardSystemLogoAnimationFactor;
		}
#pragma warning restore 0169

		static Delegate cb_setCardSystemLogoAnimationFactor_F;
#pragma warning disable 0169
		static Delegate GetSetCardSystemLogoAnimationFactor_FHandler ()
		{
			if (cb_setCardSystemLogoAnimationFactor_F == null)
				cb_setCardSystemLogoAnimationFactor_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCardSystemLogoAnimationFactor_F);
			return cb_setCardSystemLogoAnimationFactor_F;
		}

		static void n_SetCardSystemLogoAnimationFactor_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CardSystemLogoAnimationFactor = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getCardSystemLogoAnimationFactor;
		static IntPtr id_setCardSystemLogoAnimationFactor_F;
		public virtual unsafe float CardSystemLogoAnimationFactor {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='getCardSystemLogoAnimationFactor' and count(parameter)=0]"
			[Register ("getCardSystemLogoAnimationFactor", "()F", "GetGetCardSystemLogoAnimationFactorHandler")]
			get {
				if (id_getCardSystemLogoAnimationFactor == IntPtr.Zero)
					id_getCardSystemLogoAnimationFactor = JNIEnv.GetMethodID (class_ref, "getCardSystemLogoAnimationFactor", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getCardSystemLogoAnimationFactor);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardSystemLogoAnimationFactor", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setCardSystemLogoAnimationFactor' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCardSystemLogoAnimationFactor", "(F)V", "GetSetCardSystemLogoAnimationFactor_FHandler")]
			set {
				if (id_setCardSystemLogoAnimationFactor_F == IntPtr.Zero)
					id_setCardSystemLogoAnimationFactor_F = JNIEnv.GetMethodID (class_ref, "setCardSystemLogoAnimationFactor", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardSystemLogoAnimationFactor_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardSystemLogoAnimationFactor", "(F)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCvc;
#pragma warning disable 0169
		static Delegate GetGetCvcHandler ()
		{
			if (cb_getCvc == null)
				cb_getCvc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCvc);
			return cb_getCvc;
		}

		static IntPtr n_GetCvc (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Cvc);
		}
#pragma warning restore 0169

		static IntPtr id_getCvc;
		public virtual unsafe string Cvc {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='getCvc' and count(parameter)=0]"
			[Register ("getCvc", "()Ljava/lang/String;", "GetGetCvcHandler")]
			get {
				if (id_getCvc == IntPtr.Zero)
					id_getCvc = JNIEnv.GetMethodID (class_ref, "getCvc", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCvc), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCvc", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExpireDate;
#pragma warning disable 0169
		static Delegate GetGetExpireDateHandler ()
		{
			if (cb_getExpireDate == null)
				cb_getExpireDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExpireDate);
			return cb_getExpireDate;
		}

		static IntPtr n_GetExpireDate (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExpireDate);
		}
#pragma warning restore 0169

		static Delegate cb_setExpireDate_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExpireDate_Ljava_lang_String_Handler ()
		{
			if (cb_setExpireDate_Ljava_lang_String_ == null)
				cb_setExpireDate_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExpireDate_Ljava_lang_String_);
			return cb_setExpireDate_Ljava_lang_String_;
		}

		static void n_SetExpireDate_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExpireDate = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getExpireDate;
		static IntPtr id_setExpireDate_Ljava_lang_String_;
		public virtual unsafe string ExpireDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='getExpireDate' and count(parameter)=0]"
			[Register ("getExpireDate", "()Ljava/lang/String;", "GetGetExpireDateHandler")]
			get {
				if (id_getExpireDate == IntPtr.Zero)
					id_getExpireDate = JNIEnv.GetMethodID (class_ref, "getExpireDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExpireDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExpireDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setExpireDate' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setExpireDate", "(Ljava/lang/String;)V", "GetSetExpireDate_Ljava_lang_String_Handler")]
			set {
				if (id_setExpireDate_Ljava_lang_String_ == IntPtr.Zero)
					id_setExpireDate_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setExpireDate", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExpireDate_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExpireDate", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isFilledAndCorrect;
#pragma warning disable 0169
		static Delegate GetIsFilledAndCorrectHandler ()
		{
			if (cb_isFilledAndCorrect == null)
				cb_isFilledAndCorrect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFilledAndCorrect);
			return cb_isFilledAndCorrect;
		}

		static bool n_IsFilledAndCorrect (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFilledAndCorrect;
		}
#pragma warning restore 0169

		static IntPtr id_isFilledAndCorrect;
		public virtual unsafe bool IsFilledAndCorrect {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='isFilledAndCorrect' and count(parameter)=0]"
			[Register ("isFilledAndCorrect", "()Z", "GetIsFilledAndCorrectHandler")]
			get {
				if (id_isFilledAndCorrect == IntPtr.Zero)
					id_isFilledAndCorrect = JNIEnv.GetMethodID (class_ref, "isFilledAndCorrect", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFilledAndCorrect);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFilledAndCorrect", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_applyBehaviour_arrayLandroid_widget_EditText_;
#pragma warning disable 0169
		static Delegate GetApplyBehaviour_arrayLandroid_widget_EditText_Handler ()
		{
			if (cb_applyBehaviour_arrayLandroid_widget_EditText_ == null)
				cb_applyBehaviour_arrayLandroid_widget_EditText_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ApplyBehaviour_arrayLandroid_widget_EditText_);
			return cb_applyBehaviour_arrayLandroid_widget_EditText_;
		}

		static void n_ApplyBehaviour_arrayLandroid_widget_EditText_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.EditText[] p0 = (global::Android.Widget.EditText[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Widget.EditText));
			__this.ApplyBehaviour (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_applyBehaviour_arrayLandroid_widget_EditText_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='applyBehaviour' and count(parameter)=1 and parameter[1][@type='android.widget.EditText...']]"
		[Register ("applyBehaviour", "([Landroid/widget/EditText;)V", "GetApplyBehaviour_arrayLandroid_widget_EditText_Handler")]
		protected virtual unsafe void ApplyBehaviour (params global:: Android.Widget.EditText[] p0)
		{
			if (id_applyBehaviour_arrayLandroid_widget_EditText_ == IntPtr.Zero)
				id_applyBehaviour_arrayLandroid_widget_EditText_ = JNIEnv.GetMethodID (class_ref, "applyBehaviour", "([Landroid/widget/EditText;)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_applyBehaviour_arrayLandroid_widget_EditText_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "applyBehaviour", "([Landroid/widget/EditText;)V"), __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
			} finally {
			}
		}

		static Delegate cb_disableCopyPaste;
#pragma warning disable 0169
		static Delegate GetDisableCopyPasteHandler ()
		{
			if (cb_disableCopyPaste == null)
				cb_disableCopyPaste = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableCopyPaste);
			return cb_disableCopyPaste;
		}

		static void n_DisableCopyPaste (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableCopyPaste ();
		}
#pragma warning restore 0169

		static IntPtr id_disableCopyPaste;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='disableCopyPaste' and count(parameter)=0]"
		[Register ("disableCopyPaste", "()V", "GetDisableCopyPasteHandler")]
		public virtual unsafe void DisableCopyPaste ()
		{
			if (id_disableCopyPaste == IntPtr.Zero)
				id_disableCopyPaste = JNIEnv.GetMethodID (class_ref, "disableCopyPaste", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disableCopyPaste);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disableCopyPaste", "()V"));
			} finally {
			}
		}

		static Delegate cb_dispatchFocus;
#pragma warning disable 0169
		static Delegate GetDispatchFocusHandler ()
		{
			if (cb_dispatchFocus == null)
				cb_dispatchFocus = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DispatchFocus);
			return cb_dispatchFocus;
		}

		static void n_DispatchFocus (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DispatchFocus ();
		}
#pragma warning restore 0169

		static IntPtr id_dispatchFocus;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='dispatchFocus' and count(parameter)=0]"
		[Register ("dispatchFocus", "()V", "GetDispatchFocusHandler")]
		public virtual unsafe void DispatchFocus ()
		{
			if (id_dispatchFocus == IntPtr.Zero)
				id_dispatchFocus = JNIEnv.GetMethodID (class_ref, "dispatchFocus", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_dispatchFocus);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "dispatchFocus", "()V"));
			} finally {
			}
		}

		static Delegate cb_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_;
#pragma warning disable 0169
		static Delegate GetOnCreateField_Landroid_content_Context_Landroid_util_AttributeSet_Handler ()
		{
			if (cb_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_ == null)
				cb_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreateField_Landroid_content_Context_Landroid_util_AttributeSet_);
			return cb_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_;
		}

		static IntPtr n_OnCreateField_Landroid_content_Context_Landroid_util_AttributeSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Util.IAttributeSet p1 = (global::Android.Util.IAttributeSet)global::Java.Lang.Object.GetObject<global::Android.Util.IAttributeSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnCreateField (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='onCreateField' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register ("onCreateField", "(Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/widget/EditText;", "GetOnCreateField_Landroid_content_Context_Landroid_util_AttributeSet_Handler")]
		protected virtual unsafe global::Android.Widget.EditText OnCreateField (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1)
		{
			if (id_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "onCreateField", "(Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/widget/EditText;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				global::Android.Widget.EditText __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onCreateField_Landroid_content_Context_Landroid_util_AttributeSet_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Widget.EditText> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateField", "(Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/widget/EditText;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool p0, int p1, int p2, int p3, int p4)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_onLayout_ZIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool p0, int p1, int p2, int p3, int p4)
		{
			if (id_onLayout_ZIIII == IntPtr.Zero)
				id_onLayout_ZIIII = JNIEnv.GetMethodID (class_ref, "onLayout", "(ZIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onLayout_ZIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onLayout", "(ZIIII)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRestoreInstanceState_Landroid_os_Parcelable_;
#pragma warning disable 0169
		static Delegate GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler ()
		{
			if (cb_onRestoreInstanceState_Landroid_os_Parcelable_ == null)
				cb_onRestoreInstanceState_Landroid_os_Parcelable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnRestoreInstanceState_Landroid_os_Parcelable_);
			return cb_onRestoreInstanceState_Landroid_os_Parcelable_;
		}

		static void n_OnRestoreInstanceState_Landroid_os_Parcelable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IParcelable p0 = (global::Android.OS.IParcelable)global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnRestoreInstanceState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onRestoreInstanceState_Landroid_os_Parcelable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='onRestoreInstanceState' and count(parameter)=1 and parameter[1][@type='android.os.Parcelable']]"
		[Register ("onRestoreInstanceState", "(Landroid/os/Parcelable;)V", "GetOnRestoreInstanceState_Landroid_os_Parcelable_Handler")]
		public virtual unsafe void OnRestoreInstanceState (global::Android.OS.IParcelable p0)
		{
			if (id_onRestoreInstanceState_Landroid_os_Parcelable_ == IntPtr.Zero)
				id_onRestoreInstanceState_Landroid_os_Parcelable_ = JNIEnv.GetMethodID (class_ref, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRestoreInstanceState_Landroid_os_Parcelable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRestoreInstanceState", "(Landroid/os/Parcelable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSaveInstanceState;
#pragma warning disable 0169
		static Delegate GetOnSaveInstanceStateHandler ()
		{
			if (cb_onSaveInstanceState == null)
				cb_onSaveInstanceState = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OnSaveInstanceState);
			return cb_onSaveInstanceState;
		}

		static IntPtr n_OnSaveInstanceState (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSaveInstanceState ());
		}
#pragma warning restore 0169

		static IntPtr id_onSaveInstanceState;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='onSaveInstanceState' and count(parameter)=0]"
		[Register ("onSaveInstanceState", "()Landroid/os/Parcelable;", "GetOnSaveInstanceStateHandler")]
		public virtual unsafe global::Android.OS.IParcelable OnSaveInstanceState ()
		{
			if (id_onSaveInstanceState == IntPtr.Zero)
				id_onSaveInstanceState = JNIEnv.GetMethodID (class_ref, "onSaveInstanceState", "()Landroid/os/Parcelable;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_onSaveInstanceState), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelable> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSaveInstanceState", "()Landroid/os/Parcelable;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_;
#pragma warning disable 0169
		static Delegate GetSetActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_Handler ()
		{
			if (cb_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_ == null)
				cb_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_);
			return cb_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_;
		}

		static void n_SetActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions p0 = (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions)global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetActions (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setActions' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.views.EditCardView.Actions']]"
		[Register ("setActions", "(Lru/tinkoff/acquiring/sdk/views/EditCardView$Actions;)V", "GetSetActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_Handler")]
		public virtual unsafe void SetActions (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.IActions p0)
		{
			if (id_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_ == IntPtr.Zero)
				id_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_ = JNIEnv.GetMethodID (class_ref, "setActions", "(Lru/tinkoff/acquiring/sdk/views/EditCardView$Actions;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setActions_Lru_tinkoff_acquiring_sdk_views_EditCardView_Actions_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setActions", "(Lru/tinkoff/acquiring/sdk/views/EditCardView$Actions;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBtnScanIcon_I;
#pragma warning disable 0169
		static Delegate GetSetBtnScanIcon_IHandler ()
		{
			if (cb_setBtnScanIcon_I == null)
				cb_setBtnScanIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBtnScanIcon_I);
			return cb_setBtnScanIcon_I;
		}

		static void n_SetBtnScanIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBtnScanIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBtnScanIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setBtnScanIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBtnScanIcon", "(I)V", "GetSetBtnScanIcon_IHandler")]
		public virtual unsafe void SetBtnScanIcon (int p0)
		{
			if (id_setBtnScanIcon_I == IntPtr.Zero)
				id_setBtnScanIcon_I = JNIEnv.GetMethodID (class_ref, "setBtnScanIcon", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBtnScanIcon_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBtnScanIcon", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setCardHint_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCardHint_Ljava_lang_String_Handler ()
		{
			if (cb_setCardHint_Ljava_lang_String_ == null)
				cb_setCardHint_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCardHint_Ljava_lang_String_);
			return cb_setCardHint_Ljava_lang_String_;
		}

		static void n_SetCardHint_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCardHint (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCardHint_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setCardHint' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCardHint", "(Ljava/lang/String;)V", "GetSetCardHint_Ljava_lang_String_Handler")]
		public virtual unsafe void SetCardHint (string p0)
		{
			if (id_setCardHint_Ljava_lang_String_ == IntPtr.Zero)
				id_setCardHint_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setCardHint", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardHint_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardHint", "(Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_;
#pragma warning disable 0169
		static Delegate GetSetCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_Handler ()
		{
			if (cb_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_ == null)
				cb_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_);
			return cb_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_;
		}

		static void n_SetCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.ICardSystemIconsHolder p0 = (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.ICardSystemIconsHolder)global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.ICardSystemIconsHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetCardSystemIconsHolder (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setCardSystemIconsHolder' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.views.EditCardView.CardSystemIconsHolder']]"
		[Register ("setCardSystemIconsHolder", "(Lru/tinkoff/acquiring/sdk/views/EditCardView$CardSystemIconsHolder;)V", "GetSetCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_Handler")]
		public virtual unsafe void SetCardSystemIconsHolder (global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView.ICardSystemIconsHolder p0)
		{
			if (id_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_ == IntPtr.Zero)
				id_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_ = JNIEnv.GetMethodID (class_ref, "setCardSystemIconsHolder", "(Lru/tinkoff/acquiring/sdk/views/EditCardView$CardSystemIconsHolder;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCardSystemIconsHolder_Lru_tinkoff_acquiring_sdk_views_EditCardView_CardSystemIconsHolder_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCardSystemIconsHolder", "(Lru/tinkoff/acquiring/sdk/views/EditCardView$CardSystemIconsHolder;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setChangeModeIcon_I;
#pragma warning disable 0169
		static Delegate GetSetChangeModeIcon_IHandler ()
		{
			if (cb_setChangeModeIcon_I == null)
				cb_setChangeModeIcon_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetChangeModeIcon_I);
			return cb_setChangeModeIcon_I;
		}

		static void n_SetChangeModeIcon_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChangeModeIcon (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setChangeModeIcon_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setChangeModeIcon' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setChangeModeIcon", "(I)V", "GetSetChangeModeIcon_IHandler")]
		public virtual unsafe void SetChangeModeIcon (int p0)
		{
			if (id_setChangeModeIcon_I == IntPtr.Zero)
				id_setChangeModeIcon_I = JNIEnv.GetMethodID (class_ref, "setChangeModeIcon", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setChangeModeIcon_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setChangeModeIcon", "(I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFullCardNumberModeEnable_Z;
#pragma warning disable 0169
		static Delegate GetSetFullCardNumberModeEnable_ZHandler ()
		{
			if (cb_setFullCardNumberModeEnable_Z == null)
				cb_setFullCardNumberModeEnable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFullCardNumberModeEnable_Z);
			return cb_setFullCardNumberModeEnable_Z;
		}

		static void n_SetFullCardNumberModeEnable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFullCardNumberModeEnable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setFullCardNumberModeEnable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setFullCardNumberModeEnable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFullCardNumberModeEnable", "(Z)V", "GetSetFullCardNumberModeEnable_ZHandler")]
		public virtual unsafe void SetFullCardNumberModeEnable (bool p0)
		{
			if (id_setFullCardNumberModeEnable_Z == IntPtr.Zero)
				id_setFullCardNumberModeEnable_Z = JNIEnv.GetMethodID (class_ref, "setFullCardNumberModeEnable", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFullCardNumberModeEnable_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFullCardNumberModeEnable", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SetHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_);
			return cb_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SetHints (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setHints' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setHints", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "GetSetHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetHints (string p0, string p1, string p2)
		{
			if (id_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setHints", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHints_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHints", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static Delegate cb_setMode_Z;
#pragma warning disable 0169
		static Delegate GetSetMode_ZHandler ()
		{
			if (cb_setMode_Z == null)
				cb_setMode_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetMode_Z);
			return cb_setMode_Z;
		}

		static void n_SetMode_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setMode_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setMode", "(Z)V", "GetSetMode_ZHandler")]
		public virtual unsafe void SetMode (bool p0)
		{
			if (id_setMode_Z == IntPtr.Zero)
				id_setMode_Z = JNIEnv.GetMethodID (class_ref, "setMode", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMode_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMode", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSavedCardState_Z;
#pragma warning disable 0169
		static Delegate GetSetSavedCardState_ZHandler ()
		{
			if (cb_setSavedCardState_Z == null)
				cb_setSavedCardState_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSavedCardState_Z);
			return cb_setSavedCardState_Z;
		}

		static void n_SetSavedCardState_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.Views.EditCardView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSavedCardState (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setSavedCardState_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk.views']/class[@name='EditCardView']/method[@name='setSavedCardState' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSavedCardState", "(Z)V", "GetSetSavedCardState_ZHandler")]
		public virtual unsafe void SetSavedCardState (bool p0)
		{
			if (id_setSavedCardState_Z == IntPtr.Zero)
				id_setSavedCardState_Z = JNIEnv.GetMethodID (class_ref, "setSavedCardState", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSavedCardState_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSavedCardState", "(Z)V"), __args);
			} finally {
			}
		}

	}
}
