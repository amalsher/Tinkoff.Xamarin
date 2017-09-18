using System;
using System.Collections.Generic;
using Android.Runtime;

namespace RU.Tinkoff.Core.Nfc.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']"
	[global::Android.Runtime.Register ("ru/tinkoff/core/nfc/model/StatusWord", DoNotGenerateAcw=true)]
	public sealed partial class StatusWord : global::Java.Lang.Enum {


		static IntPtr SW_AUTH_METHOD_LOCKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_AUTH_METHOD_LOCKED']"
		[Register ("SW_AUTH_METHOD_LOCKED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwAuthMethodLocked {
			get {
				if (SW_AUTH_METHOD_LOCKED_jfieldId == IntPtr.Zero)
					SW_AUTH_METHOD_LOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_AUTH_METHOD_LOCKED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_AUTH_METHOD_LOCKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_CMD_ABORTED_UNKNOWN_ERR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_CMD_ABORTED_UNKNOWN_ERR']"
		[Register ("SW_CMD_ABORTED_UNKNOWN_ERR")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwCmdAbortedUnknownErr {
			get {
				if (SW_CMD_ABORTED_UNKNOWN_ERR_jfieldId == IntPtr.Zero)
					SW_CMD_ABORTED_UNKNOWN_ERR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_CMD_ABORTED_UNKNOWN_ERR", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_CMD_ABORTED_UNKNOWN_ERR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_CMD_CLASS_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_CMD_CLASS_NOT_SUPPORTED']"
		[Register ("SW_CMD_CLASS_NOT_SUPPORTED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwCmdClassNotSupported {
			get {
				if (SW_CMD_CLASS_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					SW_CMD_CLASS_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_CMD_CLASS_NOT_SUPPORTED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_CMD_CLASS_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_CMD_INCOMPATIBLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_CMD_INCOMPATIBLE']"
		[Register ("SW_CMD_INCOMPATIBLE")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwCmdIncompatible {
			get {
				if (SW_CMD_INCOMPATIBLE_jfieldId == IntPtr.Zero)
					SW_CMD_INCOMPATIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_CMD_INCOMPATIBLE", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_CMD_INCOMPATIBLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_CMD_NOT_ALLOWED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_CMD_NOT_ALLOWED']"
		[Register ("SW_CMD_NOT_ALLOWED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwCmdNotAllowed {
			get {
				if (SW_CMD_NOT_ALLOWED_jfieldId == IntPtr.Zero)
					SW_CMD_NOT_ALLOWED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_CMD_NOT_ALLOWED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_CMD_NOT_ALLOWED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_CMD_NOT_ALLOWED_NO_EF_SEL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_CMD_NOT_ALLOWED_NO_EF_SEL']"
		[Register ("SW_CMD_NOT_ALLOWED_NO_EF_SEL")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwCmdNotAllowedNoEfSel {
			get {
				if (SW_CMD_NOT_ALLOWED_NO_EF_SEL_jfieldId == IntPtr.Zero)
					SW_CMD_NOT_ALLOWED_NO_EF_SEL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_CMD_NOT_ALLOWED_NO_EF_SEL", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_CMD_NOT_ALLOWED_NO_EF_SEL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_COMMAND_NOT_ALLOWED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_COMMAND_NOT_ALLOWED']"
		[Register ("SW_COMMAND_NOT_ALLOWED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwCommandNotAllowed {
			get {
				if (SW_COMMAND_NOT_ALLOWED_jfieldId == IntPtr.Zero)
					SW_COMMAND_NOT_ALLOWED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_COMMAND_NOT_ALLOWED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_COMMAND_NOT_ALLOWED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_DATA_FAILURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_DATA_FAILURE']"
		[Register ("SW_DATA_FAILURE")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwDataFailure {
			get {
				if (SW_DATA_FAILURE_jfieldId == IntPtr.Zero)
					SW_DATA_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_DATA_FAILURE", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_DATA_FAILURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_FILE_END_REACHED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_FILE_END_REACHED']"
		[Register ("SW_FILE_END_REACHED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwFileEndReached {
			get {
				if (SW_FILE_END_REACHED_jfieldId == IntPtr.Zero)
					SW_FILE_END_REACHED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_FILE_END_REACHED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_FILE_END_REACHED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_FILE_INFO_ISO_FAILURE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_FILE_INFO_ISO_FAILURE']"
		[Register ("SW_FILE_INFO_ISO_FAILURE")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwFileInfoIsoFailure {
			get {
				if (SW_FILE_INFO_ISO_FAILURE_jfieldId == IntPtr.Zero)
					SW_FILE_INFO_ISO_FAILURE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_FILE_INFO_ISO_FAILURE", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_FILE_INFO_ISO_FAILURE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_FILE_LOCKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_FILE_LOCKED']"
		[Register ("SW_FILE_LOCKED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwFileLocked {
			get {
				if (SW_FILE_LOCKED_jfieldId == IntPtr.Zero)
					SW_FILE_LOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_FILE_LOCKED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_FILE_LOCKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_FILE_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_FILE_NOT_FOUND']"
		[Register ("SW_FILE_NOT_FOUND")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwFileNotFound {
			get {
				if (SW_FILE_NOT_FOUND_jfieldId == IntPtr.Zero)
					SW_FILE_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_FILE_NOT_FOUND", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_FILE_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_FUNC_CLASS_BYTE_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_FUNC_CLASS_BYTE_NOT_SUPPORTED']"
		[Register ("SW_FUNC_CLASS_BYTE_NOT_SUPPORTED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwFuncClassByteNotSupported {
			get {
				if (SW_FUNC_CLASS_BYTE_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					SW_FUNC_CLASS_BYTE_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_FUNC_CLASS_BYTE_NOT_SUPPORTED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_FUNC_CLASS_BYTE_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_FUNC_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_FUNC_NOT_SUPPORTED']"
		[Register ("SW_FUNC_NOT_SUPPORTED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwFuncNotSupported {
			get {
				if (SW_FUNC_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					SW_FUNC_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_FUNC_NOT_SUPPORTED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_FUNC_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_INCORRECT_DATA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_INCORRECT_DATA']"
		[Register ("SW_INCORRECT_DATA")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwIncorrectData {
			get {
				if (SW_INCORRECT_DATA_jfieldId == IntPtr.Zero)
					SW_INCORRECT_DATA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_INCORRECT_DATA", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_INCORRECT_DATA_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_INCORRECT_PARAMETERS_P1_P2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_INCORRECT_PARAMETERS_P1_P2']"
		[Register ("SW_INCORRECT_PARAMETERS_P1_P2")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwIncorrectParametersP1P2 {
			get {
				if (SW_INCORRECT_PARAMETERS_P1_P2_jfieldId == IntPtr.Zero)
					SW_INCORRECT_PARAMETERS_P1_P2_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_INCORRECT_PARAMETERS_P1_P2", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_INCORRECT_PARAMETERS_P1_P2_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_INCORRECT_PARAMS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_INCORRECT_PARAMS']"
		[Register ("SW_INCORRECT_PARAMS")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwIncorrectParams {
			get {
				if (SW_INCORRECT_PARAMS_jfieldId == IntPtr.Zero)
					SW_INCORRECT_PARAMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_INCORRECT_PARAMS", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_INCORRECT_PARAMS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_INS_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_INS_NOT_SUPPORTED']"
		[Register ("SW_INS_NOT_SUPPORTED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwInsNotSupported {
			get {
				if (SW_INS_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					SW_INS_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_INS_NOT_SUPPORTED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_INS_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_LENGTH_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_LENGTH_ERROR']"
		[Register ("SW_LENGTH_ERROR")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwLengthError {
			get {
				if (SW_LENGTH_ERROR_jfieldId == IntPtr.Zero)
					SW_LENGTH_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_LENGTH_ERROR", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_LENGTH_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_LOGIC_CHAN_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_LOGIC_CHAN_NOT_SUPPORTED']"
		[Register ("SW_LOGIC_CHAN_NOT_SUPPORTED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwLogicChanNotSupported {
			get {
				if (SW_LOGIC_CHAN_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					SW_LOGIC_CHAN_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_LOGIC_CHAN_NOT_SUPPORTED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_LOGIC_CHAN_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_MEMORY_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_MEMORY_ERROR']"
		[Register ("SW_MEMORY_ERROR")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwMemoryError {
			get {
				if (SW_MEMORY_ERROR_jfieldId == IntPtr.Zero)
					SW_MEMORY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_MEMORY_ERROR", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_MEMORY_ERROR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_RECORD_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_RECORD_NOT_FOUND']"
		[Register ("SW_RECORD_NOT_FOUND")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwRecordNotFound {
			get {
				if (SW_RECORD_NOT_FOUND_jfieldId == IntPtr.Zero)
					SW_RECORD_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_RECORD_NOT_FOUND", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_RECORD_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_REFERENCED_DATA_LOCKED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_REFERENCED_DATA_LOCKED']"
		[Register ("SW_REFERENCED_DATA_LOCKED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwReferencedDataLocked {
			get {
				if (SW_REFERENCED_DATA_LOCKED_jfieldId == IntPtr.Zero)
					SW_REFERENCED_DATA_LOCKED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_REFERENCED_DATA_LOCKED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_REFERENCED_DATA_LOCKED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_REFERENCED_DATA_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_REFERENCED_DATA_NOT_FOUND']"
		[Register ("SW_REFERENCED_DATA_NOT_FOUND")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwReferencedDataNotFound {
			get {
				if (SW_REFERENCED_DATA_NOT_FOUND_jfieldId == IntPtr.Zero)
					SW_REFERENCED_DATA_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_REFERENCED_DATA_NOT_FOUND", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_REFERENCED_DATA_NOT_FOUND_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_SEC_MSG_NOT_SUPPORTED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_SEC_MSG_NOT_SUPPORTED']"
		[Register ("SW_SEC_MSG_NOT_SUPPORTED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwSecMsgNotSupported {
			get {
				if (SW_SEC_MSG_NOT_SUPPORTED_jfieldId == IntPtr.Zero)
					SW_SEC_MSG_NOT_SUPPORTED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_SEC_MSG_NOT_SUPPORTED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_SEC_MSG_NOT_SUPPORTED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_SEC_STATE_NOT_FULFILLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_SEC_STATE_NOT_FULFILLED']"
		[Register ("SW_SEC_STATE_NOT_FULFILLED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwSecStateNotFulfilled {
			get {
				if (SW_SEC_STATE_NOT_FULFILLED_jfieldId == IntPtr.Zero)
					SW_SEC_STATE_NOT_FULFILLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_SEC_STATE_NOT_FULFILLED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_SEC_STATE_NOT_FULFILLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_SUCCESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_SUCCESS']"
		[Register ("SW_SUCCESS")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwSuccess {
			get {
				if (SW_SUCCESS_jfieldId == IntPtr.Zero)
					SW_SUCCESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_SUCCESS", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_SUCCESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SW_USAGE_CONDITIONS_NOT_FULFILLED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/field[@name='SW_USAGE_CONDITIONS_NOT_FULFILLED']"
		[Register ("SW_USAGE_CONDITIONS_NOT_FULFILLED")]
		public static global::RU.Tinkoff.Core.Nfc.Model.StatusWord SwUsageConditionsNotFulfilled {
			get {
				if (SW_USAGE_CONDITIONS_NOT_FULFILLED_jfieldId == IntPtr.Zero)
					SW_USAGE_CONDITIONS_NOT_FULFILLED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SW_USAGE_CONDITIONS_NOT_FULFILLED", "Lru/tinkoff/core/nfc/model/StatusWord;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SW_USAGE_CONDITIONS_NOT_FULFILLED_jfieldId);
				return global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("ru/tinkoff/core/nfc/model/StatusWord", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (StatusWord); }
		}

		internal StatusWord (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getDetail;
		public unsafe string Detail {
			// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/method[@name='getDetail' and count(parameter)=0]"
			[Register ("getDetail", "()Ljava/lang/String;", "GetGetDetailHandler")]
			get {
				if (id_getDetail == IntPtr.Zero)
					id_getDetail = JNIEnv.GetMethodID (class_ref, "getDetail", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDetail), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getSW_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/method[@name='getSW' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getSW", "([B)Lru/tinkoff/core/nfc/model/StatusWord;", "")]
		public static unsafe global::RU.Tinkoff.Core.Nfc.Model.StatusWord GetSW (byte[] p0)
		{
			if (id_getSW_arrayB == IntPtr.Zero)
				id_getSW_arrayB = JNIEnv.GetStaticMethodID (class_ref, "getSW", "([B)Lru/tinkoff/core/nfc/model/StatusWord;");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Core.Nfc.Model.StatusWord __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (JNIEnv.CallStaticObjectMethod  (class_ref, id_getSW_arrayB, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static IntPtr id_getStatus;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/method[@name='getStatus' and count(parameter)=0]"
		[Register ("getStatus", "()[B", "")]
		public unsafe byte[] GetStatus ()
		{
			if (id_getStatus == IntPtr.Zero)
				id_getStatus = JNIEnv.GetMethodID (class_ref, "getStatus", "()[B");
			try {
				return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getStatus), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lru/tinkoff/core/nfc/model/StatusWord;", "")]
		public static unsafe global::RU.Tinkoff.Core.Nfc.Model.StatusWord ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lru/tinkoff/core/nfc/model/StatusWord;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::RU.Tinkoff.Core.Nfc.Model.StatusWord __ret = global::Java.Lang.Object.GetObject<global::RU.Tinkoff.Core.Nfc.Model.StatusWord> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='ru.tinkoff.core.nfc.model']/class[@name='StatusWord']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lru/tinkoff/core/nfc/model/StatusWord;", "")]
		public static unsafe global::RU.Tinkoff.Core.Nfc.Model.StatusWord[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lru/tinkoff/core/nfc/model/StatusWord;");
			try {
				return (global::RU.Tinkoff.Core.Nfc.Model.StatusWord[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::RU.Tinkoff.Core.Nfc.Model.StatusWord));
			} finally {
			}
		}

	}
}
