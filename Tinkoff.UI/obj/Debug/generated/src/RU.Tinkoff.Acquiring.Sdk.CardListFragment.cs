using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Acquiring.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment']"
	[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CardListFragment", DoNotGenerateAcw=true)]
	public partial class CardListFragment : global::Android.Support.V4.App.Fragment, global::Android.Widget.AdapterView.IOnItemClickListener, global::Android.Widget.AdapterView.IOnItemLongClickListener, global::RU.Tinkoff.Acquiring.Sdk.ICardInterest {


		static IntPtr EXTRA_CUSTOMER_KEY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment']/field[@name='EXTRA_CUSTOMER_KEY']"
		[Register ("EXTRA_CUSTOMER_KEY")]
		public static string ExtraCustomerKey {
			get {
				if (EXTRA_CUSTOMER_KEY_jfieldId == IntPtr.Zero)
					EXTRA_CUSTOMER_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_CUSTOMER_KEY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_CUSTOMER_KEY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EXTRA_CUSTOMER_KEY_jfieldId == IntPtr.Zero)
					EXTRA_CUSTOMER_KEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA_CUSTOMER_KEY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EXTRA_CUSTOMER_KEY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardLongPressCallback']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CardListFragment$CardLongPressCallback", DoNotGenerateAcw=true)]
		public partial class CardLongPressCallback : global::Java.Lang.Object, global::Android.Support.V7.View.ActionMode.ICallback {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CardListFragment$CardLongPressCallback", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CardLongPressCallback); }
			}

			protected CardLongPressCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_;
#pragma warning disable 0169
			static Delegate GetOnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_Handler ()
			{
				if (cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ == null)
					cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_);
				return cb_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_;
			}

			static bool n_OnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenuItem p1 = (global::Android.Views.IMenuItem)global::Java.Lang.Object.GetObject<global::Android.Views.IMenuItem> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnActionItemClicked (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardLongPressCallback']/method[@name='onActionItemClicked' and count(parameter)=2 and parameter[1][@type='android.support.v7.view.ActionMode'] and parameter[2][@type='android.view.MenuItem']]"
			[Register ("onActionItemClicked", "(Landroid/support/v7/view/ActionMode;Landroid/view/MenuItem;)Z", "GetOnActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_Handler")]
			public virtual unsafe bool OnActionItemClicked (global::Android.Support.V7.View.ActionMode p0, global::Android.Views.IMenuItem p1)
			{
				if (id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ == IntPtr.Zero)
					id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_ = JNIEnv.GetMethodID (class_ref, "onActionItemClicked", "(Landroid/support/v7/view/ActionMode;Landroid/view/MenuItem;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onActionItemClicked_Landroid_support_v7_view_ActionMode_Landroid_view_MenuItem_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActionItemClicked", "(Landroid/support/v7/view/ActionMode;Landroid/view/MenuItem;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler ()
			{
				if (cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == null)
					cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_);
				return cb_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			}

			static bool n_OnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnCreateActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardLongPressCallback']/method[@name='onCreateActionMode' and count(parameter)=2 and parameter[1][@type='android.support.v7.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
			[Register ("onCreateActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z", "GetOnCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler")]
			public virtual unsafe bool OnCreateActionMode (global::Android.Support.V7.View.ActionMode p0, global::Android.Views.IMenu p1)
			{
				if (id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
					id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onCreateActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onCreateActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z"), __args);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_;
#pragma warning disable 0169
			static Delegate GetOnDestroyActionMode_Landroid_support_v7_view_ActionMode_Handler ()
			{
				if (cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ == null)
					cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDestroyActionMode_Landroid_support_v7_view_ActionMode_);
				return cb_onDestroyActionMode_Landroid_support_v7_view_ActionMode_;
			}

			static void n_OnDestroyActionMode_Landroid_support_v7_view_ActionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnDestroyActionMode (p0);
			}
#pragma warning restore 0169

			static IntPtr id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardLongPressCallback']/method[@name='onDestroyActionMode' and count(parameter)=1 and parameter[1][@type='android.support.v7.view.ActionMode']]"
			[Register ("onDestroyActionMode", "(Landroid/support/v7/view/ActionMode;)V", "GetOnDestroyActionMode_Landroid_support_v7_view_ActionMode_Handler")]
			public virtual unsafe void OnDestroyActionMode (global::Android.Support.V7.View.ActionMode p0)
			{
				if (id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ == IntPtr.Zero)
					id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_ = JNIEnv.GetMethodID (class_ref, "onDestroyActionMode", "(Landroid/support/v7/view/ActionMode;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroyActionMode_Landroid_support_v7_view_ActionMode_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroyActionMode", "(Landroid/support/v7/view/ActionMode;)V"), __args);
				} finally {
				}
			}

			static Delegate cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
#pragma warning disable 0169
			static Delegate GetOnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler ()
			{
				if (cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == null)
					cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_);
				return cb_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			}

			static bool n_OnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardLongPressCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Support.V7.View.ActionMode p0 = global::Java.Lang.Object.GetObject<global::Android.Support.V7.View.ActionMode> (native_p0, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.IMenu p1 = (global::Android.Views.IMenu)global::Java.Lang.Object.GetObject<global::Android.Views.IMenu> (native_p1, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.OnPrepareActionMode (p0, p1);
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardLongPressCallback']/method[@name='onPrepareActionMode' and count(parameter)=2 and parameter[1][@type='android.support.v7.view.ActionMode'] and parameter[2][@type='android.view.Menu']]"
			[Register ("onPrepareActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z", "GetOnPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_Handler")]
			public virtual unsafe bool OnPrepareActionMode (global::Android.Support.V7.View.ActionMode p0, global::Android.Views.IMenu p1)
			{
				if (id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ == IntPtr.Zero)
					id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_ = JNIEnv.GetMethodID (class_ref, "onPrepareActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z");
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);

					bool __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onPrepareActionMode_Landroid_support_v7_view_ActionMode_Landroid_view_Menu_, __args);
					else
						__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareActionMode", "(Landroid/support/v7/view/ActionMode;Landroid/view/Menu;)Z"), __args);
					return __ret;
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CardListFragment$CardsAdapter", DoNotGenerateAcw=true)]
		public partial class CardsAdapter : global::Android.Widget.BaseAdapter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CardListFragment$CardsAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (CardsAdapter); }
			}

			protected CardsAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Landroid_app_Activity_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']/constructor[@name='CardListFragment.CardsAdapter' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
			[Register (".ctor", "(Landroid/app/Activity;)V", "")]
			public unsafe CardsAdapter (global::Android.App.Activity p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (CardsAdapter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/app/Activity;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/app/Activity;)V", __args);
						return;
					}

					if (id_ctor_Landroid_app_Activity_ == IntPtr.Zero)
						id_ctor_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/app/Activity;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_app_Activity_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_app_Activity_, __args);
				} finally {
				}
			}

			static Delegate cb_getCount;
#pragma warning disable 0169
			static Delegate GetGetCountHandler ()
			{
				if (cb_getCount == null)
					cb_getCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCount);
				return cb_getCount;
			}

			static int n_GetCount (IntPtr jnienv, IntPtr native__this)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Count;
			}
#pragma warning restore 0169

			static IntPtr id_getCount;
			public override unsafe int Count {
				// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']/method[@name='getCount' and count(parameter)=0]"
				[Register ("getCount", "()I", "GetGetCountHandler")]
				get {
					if (id_getCount == IntPtr.Zero)
						id_getCount = JNIEnv.GetMethodID (class_ref, "getCount", "()I");
					try {

						if (((object) this).GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCount);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCount", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getItem_I;
#pragma warning disable 0169
			static Delegate GetGetItem_IHandler ()
			{
				if (cb_getItem_I == null)
					cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
				return cb_getItem_I;
			}

			static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
			}
#pragma warning restore 0169

			static IntPtr id_getItem_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItem", "(I)Ljava/lang/Object;", "GetGetItem_IHandler")]
			public override unsafe global::Java.Lang.Object GetItem (int p0)
			{
				if (id_getItem_I == IntPtr.Zero)
					id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Ljava/lang/Object;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItem", "(I)Ljava/lang/Object;"), __args), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			static Delegate cb_getItemId_I;
#pragma warning disable 0169
			static Delegate GetGetItemId_IHandler ()
			{
				if (cb_getItemId_I == null)
					cb_getItemId_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_GetItemId_I);
				return cb_getItemId_I;
			}

			static long n_GetItemId_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetItemId (p0);
			}
#pragma warning restore 0169

			static IntPtr id_getItemId_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']/method[@name='getItemId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItemId", "(I)J", "GetGetItemId_IHandler")]
			public override unsafe long GetItemId (int p0)
			{
				if (id_getItemId_I == IntPtr.Zero)
					id_getItemId_I = JNIEnv.GetMethodID (class_ref, "getItemId", "(I)J");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getItemId_I, __args);
					else
						return JNIEnv.CallNonvirtualLongMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getItemId", "(I)J"), __args);
				} finally {
				}
			}

			static Delegate cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
#pragma warning disable 0169
			static Delegate GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler ()
			{
				if (cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == null)
					cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_);
				return cb_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
			}

			static IntPtr n_GetView_ILandroid_view_View_Landroid_view_ViewGroup_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
				global::Android.Views.ViewGroup p2 = global::Java.Lang.Object.GetObject<global::Android.Views.ViewGroup> (native_p2, JniHandleOwnership.DoNotTransfer);
				IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetView (p0, p1, p2));
				return __ret;
			}
#pragma warning restore 0169

			static IntPtr id_getView_ILandroid_view_View_Landroid_view_ViewGroup_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']/method[@name='getView' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.view.View'] and parameter[3][@type='android.view.ViewGroup']]"
			[Register ("getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;", "GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler")]
			public override unsafe global::Android.Views.View GetView (int p0, global::Android.Views.View p1, global::Android.Views.ViewGroup p2)
			{
				if (id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ == IntPtr.Zero)
					id_getView_ILandroid_view_View_Landroid_view_ViewGroup_ = JNIEnv.GetMethodID (class_ref, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;");
				try {
					JValue* __args = stackalloc JValue [3];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (p1);
					__args [2] = new JValue (p2);

					global::Android.Views.View __ret;
					if (((object) this).GetType () == ThresholdType)
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getView_ILandroid_view_View_Landroid_view_ViewGroup_, __args), JniHandleOwnership.TransferLocalRef);
					else
						__ret = global::Java.Lang.Object.GetObject<global::Android.Views.View> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getView", "(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;"), __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static Delegate cb_setCards_arrayLru_tinkoff_acquiring_sdk_Card_;
#pragma warning disable 0169
			static Delegate GetSetCards_arrayLru_tinkoff_acquiring_sdk_Card_Handler ()
			{
				if (cb_setCards_arrayLru_tinkoff_acquiring_sdk_Card_ == null)
					cb_setCards_arrayLru_tinkoff_acquiring_sdk_Card_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCards_arrayLru_tinkoff_acquiring_sdk_Card_);
				return cb_setCards_arrayLru_tinkoff_acquiring_sdk_Card_;
			}

			static void n_SetCards_arrayLru_tinkoff_acquiring_sdk_Card_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::RU.Tinkoff.Acquiring.Sdk.Card[] p0 = (global::RU.Tinkoff.Acquiring.Sdk.Card[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::RU.Tinkoff.Acquiring.Sdk.Card));
				__this.SetCards (p0);
				if (p0 != null)
					JNIEnv.CopyArray (p0, native_p0);
			}
#pragma warning restore 0169

			static IntPtr id_setCards_arrayLru_tinkoff_acquiring_sdk_Card_;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']/method[@name='setCards' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Card[]']]"
			[Register ("setCards", "([Lru/tinkoff/acquiring/sdk/Card;)V", "GetSetCards_arrayLru_tinkoff_acquiring_sdk_Card_Handler")]
			public virtual unsafe void SetCards (global::RU.Tinkoff.Acquiring.Sdk.Card[] p0)
			{
				if (id_setCards_arrayLru_tinkoff_acquiring_sdk_Card_ == IntPtr.Zero)
					id_setCards_arrayLru_tinkoff_acquiring_sdk_Card_ = JNIEnv.GetMethodID (class_ref, "setCards", "([Lru/tinkoff/acquiring/sdk/Card;)V");
				IntPtr native_p0 = JNIEnv.NewArray (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCards_arrayLru_tinkoff_acquiring_sdk_Card_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCards", "([Lru/tinkoff/acquiring/sdk/Card;)V"), __args);
				} finally {
					if (p0 != null) {
						JNIEnv.CopyArray (native_p0, p0);
						JNIEnv.DeleteLocalRef (native_p0);
					}
				}
			}

			static Delegate cb_setSelectedItemPosition_I;
#pragma warning disable 0169
			static Delegate GetSetSelectedItemPosition_IHandler ()
			{
				if (cb_setSelectedItemPosition_I == null)
					cb_setSelectedItemPosition_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectedItemPosition_I);
				return cb_setSelectedItemPosition_I;
			}

			static void n_SetSelectedItemPosition_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment.CardsAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSelectedItemPosition (p0);
			}
#pragma warning restore 0169

			static IntPtr id_setSelectedItemPosition_I;
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.CardsAdapter']/method[@name='setSelectedItemPosition' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectedItemPosition", "(I)V", "GetSetSelectedItemPosition_IHandler")]
			public virtual unsafe void SetSelectedItemPosition (int p0)
			{
				if (id_setSelectedItemPosition_I == IntPtr.Zero)
					id_setSelectedItemPosition_I = JNIEnv.GetMethodID (class_ref, "setSelectedItemPosition", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSelectedItemPosition_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSelectedItemPosition", "(I)V"), __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']"
		[global::Android.Runtime.Register ("ru/tinkoff/acquiring/sdk/CardListFragment$Item", DoNotGenerateAcw=true)]
		public partial class Item : global::Java.Lang.Object {


			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']/field[@name='CARD']"
			[Register ("CARD")]
			public const int Card = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']/field[@name='EMPTY']"
			[Register ("EMPTY")]
			public const int Empty = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']/field[@name='NEW_CARD']"
			[Register ("NEW_CARD")]
			public const int NewCard = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']/field[@name='TYPE_COUNT']"
			[Register ("TYPE_COUNT")]
			public const int TypeCount = (int) 3;
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CardListFragment$Item", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Item); }
			}

			protected Item (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_I;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']/constructor[@name='CardListFragment.Item' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register (".ctor", "(I)V", "")]
			public unsafe Item (int p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Item)) {
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

			static IntPtr id_ctor_Lru_tinkoff_acquiring_sdk_Card_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']/constructor[@name='CardListFragment.Item' and count(parameter)=1 and parameter[1][@type='ru.tinkoff.acquiring.sdk.Card']]"
			[Register (".ctor", "(Lru/tinkoff/acquiring/sdk/Card;)V", "")]
			public unsafe Item (global::RU.Tinkoff.Acquiring.Sdk.Card p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (Item)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lru/tinkoff/acquiring/sdk/Card;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lru/tinkoff/acquiring/sdk/Card;)V", __args);
						return;
					}

					if (id_ctor_Lru_tinkoff_acquiring_sdk_Card_ == IntPtr.Zero)
						id_ctor_Lru_tinkoff_acquiring_sdk_Card_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lru/tinkoff/acquiring/sdk/Card;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_Card_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lru_tinkoff_acquiring_sdk_Card_, __args);
				} finally {
				}
			}

			static IntPtr id_ctor;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment.Item']/constructor[@name='CardListFragment.Item' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Item ()
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					if (((object) this).GetType () != typeof (Item)) {
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

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/acquiring/sdk/CardListFragment", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CardListFragment); }
		}

		protected CardListFragment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment']/constructor[@name='CardListFragment' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CardListFragment ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CardListFragment)) {
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

		static Delegate cb_onCardReady;
#pragma warning disable 0169
		static Delegate GetOnCardReadyHandler ()
		{
			if (cb_onCardReady == null)
				cb_onCardReady = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnCardReady);
			return cb_onCardReady;
		}

		static void n_OnCardReady (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardListFragment __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCardReady ();
		}
#pragma warning restore 0169

		static IntPtr id_onCardReady;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment']/method[@name='onCardReady' and count(parameter)=0]"
		[Register ("onCardReady", "()V", "GetOnCardReadyHandler")]
		public virtual unsafe void OnCardReady ()
		{
			if (id_onCardReady == IntPtr.Zero)
				id_onCardReady = JNIEnv.GetMethodID (class_ref, "onCardReady", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCardReady);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCardReady", "()V"));
			} finally {
			}
		}

		static Delegate cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
#pragma warning disable 0169
		static Delegate GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler ()
		{
			if (cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
				cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ);
			return cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		}

		static void n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardListFragment __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnItemClick (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment']/method[@name='onItemClick' and count(parameter)=4 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
		public virtual unsafe void OnItemClick (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3)
		{
			if (id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == IntPtr.Zero)
				id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNIEnv.GetMethodID (class_ref, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
#pragma warning disable 0169
		static Delegate GetOnItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler ()
		{
			if (cb_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
				cb_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, long, bool>) n_OnItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ);
			return cb_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		}

		static bool n_OnItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, long p3)
		{
			global::RU.Tinkoff.Acquiring.Sdk.CardListFragment __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Acquiring.Sdk.CardListFragment> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView p0 = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View p1 = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnItemLongClick (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.acquiring.sdk']/class[@name='CardListFragment']/method[@name='onItemLongClick' and count(parameter)=4 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z", "GetOnItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
		public virtual unsafe bool OnItemLongClick (global::Android.Widget.AdapterView p0, global::Android.Views.View p1, int p2, long p3)
		{
			if (id_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == IntPtr.Zero)
				id_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNIEnv.GetMethodID (class_ref, "onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);

				bool __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_onItemLongClick_Landroid_widget_AdapterView_Landroid_view_View_IJ, __args);
				else
					__ret = JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onItemLongClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)Z"), __args);
				return __ret;
			} finally {
			}
		}

	}
}
