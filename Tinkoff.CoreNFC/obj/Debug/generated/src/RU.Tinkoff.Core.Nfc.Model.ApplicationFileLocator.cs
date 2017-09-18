using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/model/ApplicationFileLocator", DoNotGenerateAcw=true)]
	public partial class ApplicationFileLocator : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/model/ApplicationFileLocator", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ApplicationFileLocator); }
		}

		protected ApplicationFileLocator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/constructor[@name='ApplicationFileLocator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ApplicationFileLocator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (ApplicationFileLocator)) {
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

		static Delegate cb_getFirstRecord;
#pragma warning disable 0169
		static Delegate GetGetFirstRecordHandler ()
		{
			if (cb_getFirstRecord == null)
				cb_getFirstRecord = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFirstRecord);
			return cb_getFirstRecord;
		}

		static int n_GetFirstRecord (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FirstRecord;
		}
#pragma warning restore 0169

		static Delegate cb_setFirstRecord_I;
#pragma warning disable 0169
		static Delegate GetSetFirstRecord_IHandler ()
		{
			if (cb_setFirstRecord_I == null)
				cb_setFirstRecord_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFirstRecord_I);
			return cb_setFirstRecord_I;
		}

		static void n_SetFirstRecord_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FirstRecord = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getFirstRecord;
		static IntPtr id_setFirstRecord_I;
		public virtual unsafe int FirstRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='getFirstRecord' and count(parameter)=0]"
			[Register ("getFirstRecord", "()I", "GetGetFirstRecordHandler")]
			get {
				if (id_getFirstRecord == IntPtr.Zero)
					id_getFirstRecord = JNIEnv.GetMethodID (class_ref, "getFirstRecord", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFirstRecord);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirstRecord", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='setFirstRecord' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFirstRecord", "(I)V", "GetSetFirstRecord_IHandler")]
			set {
				if (id_setFirstRecord_I == IntPtr.Zero)
					id_setFirstRecord_I = JNIEnv.GetMethodID (class_ref, "setFirstRecord", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstRecord_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstRecord", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLastRecord;
#pragma warning disable 0169
		static Delegate GetGetLastRecordHandler ()
		{
			if (cb_getLastRecord == null)
				cb_getLastRecord = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLastRecord);
			return cb_getLastRecord;
		}

		static int n_GetLastRecord (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastRecord;
		}
#pragma warning restore 0169

		static Delegate cb_setLastRecord_I;
#pragma warning disable 0169
		static Delegate GetSetLastRecord_IHandler ()
		{
			if (cb_setLastRecord_I == null)
				cb_setLastRecord_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLastRecord_I);
			return cb_setLastRecord_I;
		}

		static void n_SetLastRecord_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LastRecord = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getLastRecord;
		static IntPtr id_setLastRecord_I;
		public virtual unsafe int LastRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='getLastRecord' and count(parameter)=0]"
			[Register ("getLastRecord", "()I", "GetGetLastRecordHandler")]
			get {
				if (id_getLastRecord == IntPtr.Zero)
					id_getLastRecord = JNIEnv.GetMethodID (class_ref, "getLastRecord", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getLastRecord);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLastRecord", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='setLastRecord' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLastRecord", "(I)V", "GetSetLastRecord_IHandler")]
			set {
				if (id_setLastRecord_I == IntPtr.Zero)
					id_setLastRecord_I = JNIEnv.GetMethodID (class_ref, "setLastRecord", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLastRecord_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLastRecord", "(I)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_isOfflineAuthenticationAvailable;
#pragma warning disable 0169
		static Delegate GetIsOfflineAuthenticationAvailableHandler ()
		{
			if (cb_isOfflineAuthenticationAvailable == null)
				cb_isOfflineAuthenticationAvailable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsOfflineAuthenticationAvailable);
			return cb_isOfflineAuthenticationAvailable;
		}

		static bool n_IsOfflineAuthenticationAvailable (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OfflineAuthenticationAvailable;
		}
#pragma warning restore 0169

		static Delegate cb_setOfflineAuthenticationAvailable_Z;
#pragma warning disable 0169
		static Delegate GetSetOfflineAuthenticationAvailable_ZHandler ()
		{
			if (cb_setOfflineAuthenticationAvailable_Z == null)
				cb_setOfflineAuthenticationAvailable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetOfflineAuthenticationAvailable_Z);
			return cb_setOfflineAuthenticationAvailable_Z;
		}

		static void n_SetOfflineAuthenticationAvailable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OfflineAuthenticationAvailable = p0;
		}
#pragma warning restore 0169

		static IntPtr id_isOfflineAuthenticationAvailable;
		static IntPtr id_setOfflineAuthenticationAvailable_Z;
		public virtual unsafe bool OfflineAuthenticationAvailable {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='isOfflineAuthenticationAvailable' and count(parameter)=0]"
			[Register ("isOfflineAuthenticationAvailable", "()Z", "GetIsOfflineAuthenticationAvailableHandler")]
			get {
				if (id_isOfflineAuthenticationAvailable == IntPtr.Zero)
					id_isOfflineAuthenticationAvailable = JNIEnv.GetMethodID (class_ref, "isOfflineAuthenticationAvailable", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isOfflineAuthenticationAvailable);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isOfflineAuthenticationAvailable", "()Z"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='setOfflineAuthenticationAvailable' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setOfflineAuthenticationAvailable", "(Z)V", "GetSetOfflineAuthenticationAvailable_ZHandler")]
			set {
				if (id_setOfflineAuthenticationAvailable_Z == IntPtr.Zero)
					id_setOfflineAuthenticationAvailable_Z = JNIEnv.GetMethodID (class_ref, "setOfflineAuthenticationAvailable", "(Z)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOfflineAuthenticationAvailable_Z, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOfflineAuthenticationAvailable", "(Z)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShortFileId;
#pragma warning disable 0169
		static Delegate GetGetShortFileIdHandler ()
		{
			if (cb_getShortFileId == null)
				cb_getShortFileId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShortFileId);
			return cb_getShortFileId;
		}

		static int n_GetShortFileId (IntPtr jnienv, IntPtr native__this)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShortFileId;
		}
#pragma warning restore 0169

		static Delegate cb_setShortFileId_I;
#pragma warning disable 0169
		static Delegate GetSetShortFileId_IHandler ()
		{
			if (cb_setShortFileId_I == null)
				cb_setShortFileId_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShortFileId_I);
			return cb_setShortFileId_I;
		}

		static void n_SetShortFileId_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator __this = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.ApplicationFileLocator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShortFileId = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getShortFileId;
		static IntPtr id_setShortFileId_I;
		public virtual unsafe int ShortFileId {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='getShortFileId' and count(parameter)=0]"
			[Register ("getShortFileId", "()I", "GetGetShortFileIdHandler")]
			get {
				if (id_getShortFileId == IntPtr.Zero)
					id_getShortFileId = JNIEnv.GetMethodID (class_ref, "getShortFileId", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getShortFileId);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShortFileId", "()I"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='ApplicationFileLocator']/method[@name='setShortFileId' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShortFileId", "(I)V", "GetSetShortFileId_IHandler")]
			set {
				if (id_setShortFileId_I == IntPtr.Zero)
					id_setShortFileId_I = JNIEnv.GetMethodID (class_ref, "setShortFileId", "(I)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShortFileId_I, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShortFileId", "(I)V"), __args);
				} finally {
				}
			}
		}

	}
}
