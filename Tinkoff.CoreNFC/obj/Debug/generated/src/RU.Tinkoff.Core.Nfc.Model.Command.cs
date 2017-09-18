using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/model/Command", DoNotGenerateAcw=true)]
	public sealed partial class Command : global::Java.Lang.Enum {


		static IntPtr EXTRA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/field[@name='EXTRA']"
		[Register ("EXTRA")]
		public static global::RU.Tinkoff.Core.Nfc.Model.Command Extra {
			get {
				if (EXTRA_jfieldId == IntPtr.Zero)
					EXTRA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EXTRA", "Lru/tinkoff/core/nfc/model/Command;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EXTRA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.Command> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr GPO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/field[@name='GPO']"
		[Register ("GPO")]
		public static global::RU.Tinkoff.Core.Nfc.Model.Command Gpo {
			get {
				if (GPO_jfieldId == IntPtr.Zero)
					GPO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GPO", "Lru/tinkoff/core/nfc/model/Command;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GPO_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.Command> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr READ_RECORD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/field[@name='READ_RECORD']"
		[Register ("READ_RECORD")]
		public static global::RU.Tinkoff.Core.Nfc.Model.Command ReadRecord {
			get {
				if (READ_RECORD_jfieldId == IntPtr.Zero)
					READ_RECORD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ_RECORD", "Lru/tinkoff/core/nfc/model/Command;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_RECORD_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.Command> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SELECT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/field[@name='SELECT']"
		[Register ("SELECT")]
		public static global::RU.Tinkoff.Core.Nfc.Model.Command Select {
			get {
				if (SELECT_jfieldId == IntPtr.Zero)
					SELECT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SELECT", "Lru/tinkoff/core/nfc/model/Command;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SELECT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.Command> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/model/Command", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Command); }
		}

		internal Command (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCommandClass;
		public unsafe int CommandClass {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/method[@name='getCommandClass' and count(parameter)=0]"
			[Register ("getCommandClass", "()I", "GetGetCommandClassHandler")]
			get {
				if (id_getCommandClass == IntPtr.Zero)
					id_getCommandClass = JNIEnv.GetMethodID (class_ref, "getCommandClass", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCommandClass);
				} finally {
				}
			}
		}

		static IntPtr id_getInstruction;
		public unsafe int Instruction {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/method[@name='getInstruction' and count(parameter)=0]"
			[Register ("getInstruction", "()I", "GetGetInstructionHandler")]
			get {
				if (id_getInstruction == IntPtr.Zero)
					id_getInstruction = JNIEnv.GetMethodID (class_ref, "getInstruction", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getInstruction);
				} finally {
				}
			}
		}

		static IntPtr id_getParam1;
		public unsafe int Param1 {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/method[@name='getParam1' and count(parameter)=0]"
			[Register ("getParam1", "()I", "GetGetParam1Handler")]
			get {
				if (id_getParam1 == IntPtr.Zero)
					id_getParam1 = JNIEnv.GetMethodID (class_ref, "getParam1", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getParam1);
				} finally {
				}
			}
		}

		static IntPtr id_getParam2;
		public unsafe int Param2 {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/method[@name='getParam2' and count(parameter)=0]"
			[Register ("getParam2", "()I", "GetGetParam2Handler")]
			get {
				if (id_getParam2 == IntPtr.Zero)
					id_getParam2 = JNIEnv.GetMethodID (class_ref, "getParam2", "()I");
				try {
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getParam2);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/core/nfc/model/Command;", "")]
		public static unsafe global::RU.Tinkoff.Core.Nfc.Model.Command ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/core/nfc/model/Command;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Core.Nfc.Model.Command __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.Command> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='Command']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/core/nfc/model/Command;", "")]
		public static unsafe global::RU.Tinkoff.Core.Nfc.Model.Command[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/core/nfc/model/Command;");
			try {
				return (global::RU.Tinkoff.Core.Nfc.Model.Command[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Core.Nfc.Model.Command));
			} finally {
			}
		}

	}
}
