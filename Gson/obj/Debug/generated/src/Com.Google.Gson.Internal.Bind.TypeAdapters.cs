using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Google.Gson.Internal.Bind {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']"
	[global::Android.Runtime.Register ("com/google/gson/internal/bind/TypeAdapters", DoNotGenerateAcw=true)]
	public sealed partial class TypeAdapters : global::Java.Lang.Object {


		static IntPtr ATOMIC_BOOLEAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='ATOMIC_BOOLEAN']"
		[Register ("ATOMIC_BOOLEAN")]
		public static global::Com.Google.Gson.TypeAdapter AtomicBoolean {
			get {
				if (ATOMIC_BOOLEAN_jfieldId == IntPtr.Zero)
					ATOMIC_BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATOMIC_BOOLEAN", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATOMIC_BOOLEAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ATOMIC_BOOLEAN_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='ATOMIC_BOOLEAN_FACTORY']"
		[Register ("ATOMIC_BOOLEAN_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory AtomicBooleanFactory {
			get {
				if (ATOMIC_BOOLEAN_FACTORY_jfieldId == IntPtr.Zero)
					ATOMIC_BOOLEAN_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATOMIC_BOOLEAN_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATOMIC_BOOLEAN_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ATOMIC_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='ATOMIC_INTEGER']"
		[Register ("ATOMIC_INTEGER")]
		public static global::Com.Google.Gson.TypeAdapter AtomicInteger {
			get {
				if (ATOMIC_INTEGER_jfieldId == IntPtr.Zero)
					ATOMIC_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATOMIC_INTEGER", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATOMIC_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ATOMIC_INTEGER_ARRAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='ATOMIC_INTEGER_ARRAY']"
		[Register ("ATOMIC_INTEGER_ARRAY")]
		public static global::Com.Google.Gson.TypeAdapter AtomicIntegerArray {
			get {
				if (ATOMIC_INTEGER_ARRAY_jfieldId == IntPtr.Zero)
					ATOMIC_INTEGER_ARRAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATOMIC_INTEGER_ARRAY", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATOMIC_INTEGER_ARRAY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ATOMIC_INTEGER_ARRAY_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='ATOMIC_INTEGER_ARRAY_FACTORY']"
		[Register ("ATOMIC_INTEGER_ARRAY_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory AtomicIntegerArrayFactory {
			get {
				if (ATOMIC_INTEGER_ARRAY_FACTORY_jfieldId == IntPtr.Zero)
					ATOMIC_INTEGER_ARRAY_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATOMIC_INTEGER_ARRAY_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATOMIC_INTEGER_ARRAY_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ATOMIC_INTEGER_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='ATOMIC_INTEGER_FACTORY']"
		[Register ("ATOMIC_INTEGER_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory AtomicIntegerFactory {
			get {
				if (ATOMIC_INTEGER_FACTORY_jfieldId == IntPtr.Zero)
					ATOMIC_INTEGER_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ATOMIC_INTEGER_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ATOMIC_INTEGER_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIG_DECIMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BIG_DECIMAL']"
		[Register ("BIG_DECIMAL")]
		public static global::Com.Google.Gson.TypeAdapter BigDecimal {
			get {
				if (BIG_DECIMAL_jfieldId == IntPtr.Zero)
					BIG_DECIMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIG_DECIMAL", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIG_DECIMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIG_INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BIG_INTEGER']"
		[Register ("BIG_INTEGER")]
		public static global::Com.Google.Gson.TypeAdapter BigInteger {
			get {
				if (BIG_INTEGER_jfieldId == IntPtr.Zero)
					BIG_INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIG_INTEGER", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIG_INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIT_SET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BIT_SET']"
		[Register ("BIT_SET")]
		public static global::Com.Google.Gson.TypeAdapter BitSet {
			get {
				if (BIT_SET_jfieldId == IntPtr.Zero)
					BIT_SET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIT_SET", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIT_SET_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BIT_SET_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BIT_SET_FACTORY']"
		[Register ("BIT_SET_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory BitSetFactory {
			get {
				if (BIT_SET_FACTORY_jfieldId == IntPtr.Zero)
					BIT_SET_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BIT_SET_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BIT_SET_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BOOLEAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BOOLEAN']"
		[Register ("BOOLEAN")]
		public static global::Com.Google.Gson.TypeAdapter Boolean {
			get {
				if (BOOLEAN_jfieldId == IntPtr.Zero)
					BOOLEAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BOOLEAN_AS_STRING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BOOLEAN_AS_STRING']"
		[Register ("BOOLEAN_AS_STRING")]
		public static global::Com.Google.Gson.TypeAdapter BooleanAsString {
			get {
				if (BOOLEAN_AS_STRING_jfieldId == IntPtr.Zero)
					BOOLEAN_AS_STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN_AS_STRING", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_AS_STRING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BOOLEAN_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BOOLEAN_FACTORY']"
		[Register ("BOOLEAN_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory BooleanFactory {
			get {
				if (BOOLEAN_FACTORY_jfieldId == IntPtr.Zero)
					BOOLEAN_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BOOLEAN_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BOOLEAN_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BYTE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BYTE']"
		[Register ("BYTE")]
		public static global::Com.Google.Gson.TypeAdapter Byte {
			get {
				if (BYTE_jfieldId == IntPtr.Zero)
					BYTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr BYTE_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='BYTE_FACTORY']"
		[Register ("BYTE_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory ByteFactory {
			get {
				if (BYTE_FACTORY_jfieldId == IntPtr.Zero)
					BYTE_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BYTE_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, BYTE_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CALENDAR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='CALENDAR']"
		[Register ("CALENDAR")]
		public static global::Com.Google.Gson.TypeAdapter Calendar {
			get {
				if (CALENDAR_jfieldId == IntPtr.Zero)
					CALENDAR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALENDAR", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALENDAR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CALENDAR_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='CALENDAR_FACTORY']"
		[Register ("CALENDAR_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory CalendarFactory {
			get {
				if (CALENDAR_FACTORY_jfieldId == IntPtr.Zero)
					CALENDAR_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CALENDAR_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CALENDAR_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHARACTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='CHARACTER']"
		[Register ("CHARACTER")]
		public static global::Com.Google.Gson.TypeAdapter Character {
			get {
				if (CHARACTER_jfieldId == IntPtr.Zero)
					CHARACTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHARACTER", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHARACTER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CHARACTER_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='CHARACTER_FACTORY']"
		[Register ("CHARACTER_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory CharacterFactory {
			get {
				if (CHARACTER_FACTORY_jfieldId == IntPtr.Zero)
					CHARACTER_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHARACTER_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHARACTER_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CLASS_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='CLASS_FACTORY']"
		[Register ("CLASS_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory ClassFactory {
			get {
				if (CLASS_FACTORY_jfieldId == IntPtr.Zero)
					CLASS_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLASS_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLASS_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CURRENCY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='CURRENCY']"
		[Register ("CURRENCY")]
		public static global::Com.Google.Gson.TypeAdapter Currency {
			get {
				if (CURRENCY_jfieldId == IntPtr.Zero)
					CURRENCY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CURRENCY", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CURRENCY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr CURRENCY_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='CURRENCY_FACTORY']"
		[Register ("CURRENCY_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory CurrencyFactory {
			get {
				if (CURRENCY_FACTORY_jfieldId == IntPtr.Zero)
					CURRENCY_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CURRENCY_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CURRENCY_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr DOUBLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='DOUBLE']"
		[Register ("DOUBLE")]
		public static global::Com.Google.Gson.TypeAdapter Double {
			get {
				if (DOUBLE_jfieldId == IntPtr.Zero)
					DOUBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBLE", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBLE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ENUM_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='ENUM_FACTORY']"
		[Register ("ENUM_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory EnumFactory {
			get {
				if (ENUM_FACTORY_jfieldId == IntPtr.Zero)
					ENUM_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ENUM_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ENUM_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr FLOAT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='FLOAT']"
		[Register ("FLOAT")]
		public static global::Com.Google.Gson.TypeAdapter Float {
			get {
				if (FLOAT_jfieldId == IntPtr.Zero)
					FLOAT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLOAT", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLOAT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INET_ADDRESS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='INET_ADDRESS']"
		[Register ("INET_ADDRESS")]
		public static global::Com.Google.Gson.TypeAdapter InetAddress {
			get {
				if (INET_ADDRESS_jfieldId == IntPtr.Zero)
					INET_ADDRESS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INET_ADDRESS", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INET_ADDRESS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INET_ADDRESS_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='INET_ADDRESS_FACTORY']"
		[Register ("INET_ADDRESS_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory InetAddressFactory {
			get {
				if (INET_ADDRESS_FACTORY_jfieldId == IntPtr.Zero)
					INET_ADDRESS_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INET_ADDRESS_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INET_ADDRESS_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTEGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='INTEGER']"
		[Register ("INTEGER")]
		public static global::Com.Google.Gson.TypeAdapter Integer {
			get {
				if (INTEGER_jfieldId == IntPtr.Zero)
					INTEGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTEGER", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTEGER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr INTEGER_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='INTEGER_FACTORY']"
		[Register ("INTEGER_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory IntegerFactory {
			get {
				if (INTEGER_FACTORY_jfieldId == IntPtr.Zero)
					INTEGER_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INTEGER_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INTEGER_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JSON_ELEMENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='JSON_ELEMENT']"
		[Register ("JSON_ELEMENT")]
		public static global::Com.Google.Gson.TypeAdapter JsonElement {
			get {
				if (JSON_ELEMENT_jfieldId == IntPtr.Zero)
					JSON_ELEMENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON_ELEMENT", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSON_ELEMENT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr JSON_ELEMENT_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='JSON_ELEMENT_FACTORY']"
		[Register ("JSON_ELEMENT_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory JsonElementFactory {
			get {
				if (JSON_ELEMENT_FACTORY_jfieldId == IntPtr.Zero)
					JSON_ELEMENT_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON_ELEMENT_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSON_ELEMENT_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOCALE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='LOCALE']"
		[Register ("LOCALE")]
		public static global::Com.Google.Gson.TypeAdapter Locale {
			get {
				if (LOCALE_jfieldId == IntPtr.Zero)
					LOCALE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCALE", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCALE_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LOCALE_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='LOCALE_FACTORY']"
		[Register ("LOCALE_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory LocaleFactory {
			get {
				if (LOCALE_FACTORY_jfieldId == IntPtr.Zero)
					LOCALE_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LOCALE_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LOCALE_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr LONG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='LONG']"
		[Register ("LONG")]
		public static global::Com.Google.Gson.TypeAdapter Long {
			get {
				if (LONG_jfieldId == IntPtr.Zero)
					LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NUMBER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='NUMBER']"
		[Register ("NUMBER")]
		public static global::Com.Google.Gson.TypeAdapter Number {
			get {
				if (NUMBER_jfieldId == IntPtr.Zero)
					NUMBER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMBER", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMBER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NUMBER_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='NUMBER_FACTORY']"
		[Register ("NUMBER_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory NumberFactory {
			get {
				if (NUMBER_FACTORY_jfieldId == IntPtr.Zero)
					NUMBER_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NUMBER_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NUMBER_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHORT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='SHORT']"
		[Register ("SHORT")]
		public static global::Com.Google.Gson.TypeAdapter Short {
			get {
				if (SHORT_jfieldId == IntPtr.Zero)
					SHORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHORT", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHORT_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SHORT_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='SHORT_FACTORY']"
		[Register ("SHORT_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory ShortFactory {
			get {
				if (SHORT_FACTORY_jfieldId == IntPtr.Zero)
					SHORT_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHORT_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHORT_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='STRING']"
		[Register ("STRING")]
		public static global::Com.Google.Gson.TypeAdapter String {
			get {
				if (STRING_jfieldId == IntPtr.Zero)
					STRING_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_BUFFER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='STRING_BUFFER']"
		[Register ("STRING_BUFFER")]
		public static global::Com.Google.Gson.TypeAdapter StringBuffer {
			get {
				if (STRING_BUFFER_jfieldId == IntPtr.Zero)
					STRING_BUFFER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING_BUFFER", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_BUFFER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_BUFFER_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='STRING_BUFFER_FACTORY']"
		[Register ("STRING_BUFFER_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory StringBufferFactory {
			get {
				if (STRING_BUFFER_FACTORY_jfieldId == IntPtr.Zero)
					STRING_BUFFER_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING_BUFFER_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_BUFFER_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_BUILDER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='STRING_BUILDER']"
		[Register ("STRING_BUILDER")]
		public static global::Com.Google.Gson.TypeAdapter StringBuilder {
			get {
				if (STRING_BUILDER_jfieldId == IntPtr.Zero)
					STRING_BUILDER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING_BUILDER", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_BUILDER_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_BUILDER_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='STRING_BUILDER_FACTORY']"
		[Register ("STRING_BUILDER_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory StringBuilderFactory {
			get {
				if (STRING_BUILDER_FACTORY_jfieldId == IntPtr.Zero)
					STRING_BUILDER_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING_BUILDER_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_BUILDER_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr STRING_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='STRING_FACTORY']"
		[Register ("STRING_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory StringFactory {
			get {
				if (STRING_FACTORY_jfieldId == IntPtr.Zero)
					STRING_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "STRING_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, STRING_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TIMESTAMP_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='TIMESTAMP_FACTORY']"
		[Register ("TIMESTAMP_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory TimestampFactory {
			get {
				if (TIMESTAMP_FACTORY_jfieldId == IntPtr.Zero)
					TIMESTAMP_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TIMESTAMP_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TIMESTAMP_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr URI_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='URI']"
		[Register ("URI")]
		public static global::Com.Google.Gson.TypeAdapter Uri {
			get {
				if (URI_jfieldId == IntPtr.Zero)
					URI_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URI", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, URI_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr URI_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='URI_FACTORY']"
		[Register ("URI_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory UriFactory {
			get {
				if (URI_FACTORY_jfieldId == IntPtr.Zero)
					URI_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URI_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, URI_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='URL']"
		[Register ("URL")]
		public static global::Com.Google.Gson.TypeAdapter Url {
			get {
				if (URL_jfieldId == IntPtr.Zero)
					URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URL", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, URL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr URL_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='URL_FACTORY']"
		[Register ("URL_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory UrlFactory {
			get {
				if (URL_FACTORY_jfieldId == IntPtr.Zero)
					URL_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "URL_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, URL_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='UUID']"
		[Register ("UUID")]
		public static global::Com.Google.Gson.TypeAdapter Uuid {
			get {
				if (UUID_jfieldId == IntPtr.Zero)
					UUID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID", "Lcom/google/gson/TypeAdapter;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.TypeAdapter> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UUID_FACTORY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/field[@name='UUID_FACTORY']"
		[Register ("UUID_FACTORY")]
		public static global::Com.Google.Gson.ITypeAdapterFactory UuidFactory {
			get {
				if (UUID_FACTORY_jfieldId == IntPtr.Zero)
					UUID_FACTORY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UUID_FACTORY", "Lcom/google/gson/TypeAdapterFactory;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UUID_FACTORY_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters.EnumTypeAdapter']"
		[global::Android.Runtime.Register ("com/google/gson/internal/bind/TypeAdapters$EnumTypeAdapter", DoNotGenerateAcw=true)]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Enum<T>"})]
		public sealed partial class EnumTypeAdapter : global::Com.Google.Gson.TypeAdapter {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/google/gson/internal/bind/TypeAdapters$EnumTypeAdapter", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (EnumTypeAdapter); }
			}

			internal EnumTypeAdapter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_Class_;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters.EnumTypeAdapter']/constructor[@name='TypeAdapters.EnumTypeAdapter' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
			[Register (".ctor", "(Ljava/lang/Class;)V", "")]
			public unsafe EnumTypeAdapter (global::Java.Lang.Class p0)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					if (((object) this).GetType () != typeof (EnumTypeAdapter)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Class;)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/Class;)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_Class_ == IntPtr.Zero)
						id_ctor_Ljava_lang_Class_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Class;)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Class_, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_Class_, __args);
				} finally {
				}
			}

			static IntPtr id_read_Lcom_google_gson_stream_JsonReader_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters.EnumTypeAdapter']/method[@name='read' and count(parameter)=1 and parameter[1][@type='com.google.gson.stream.JsonReader']]"
			[Register ("read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Enum;", "")]
			public override unsafe global::Java.Lang.Object Read (global::Com.Google.Gson.Stream.JsonReader p0)
			{
				if (id_read_Lcom_google_gson_stream_JsonReader_ == IntPtr.Zero)
					id_read_Lcom_google_gson_stream_JsonReader_ = JNIEnv.GetMethodID (class_ref, "read", "(Lcom/google/gson/stream/JsonReader;)Ljava/lang/Enum;");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (p0);
					global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_read_Lcom_google_gson_stream_JsonReader_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
				}
			}

			static IntPtr id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Enum_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters.EnumTypeAdapter']/method[@name='write' and count(parameter)=2 and parameter[1][@type='com.google.gson.stream.JsonWriter'] and parameter[2][@type='T']]"
			[Register ("write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Enum;)V", "")]
			public override unsafe void Write (global::Com.Google.Gson.Stream.JsonWriter p0, global::Java.Lang.Object p1)
			{
				if (id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Enum_ == IntPtr.Zero)
					id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Enum_ = JNIEnv.GetMethodID (class_ref, "write", "(Lcom/google/gson/stream/JsonWriter;Ljava/lang/Enum;)V");
				IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (p0);
					__args [1] = new JValue (native_p1);
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_write_Lcom_google_gson_stream_JsonWriter_Ljava_lang_Enum_, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/google/gson/internal/bind/TypeAdapters", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TypeAdapters); }
		}

		internal TypeAdapters (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_newFactory_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/method[@name='newFactory' and count(parameter)=2 and parameter[1][@type='com.google.gson.reflect.TypeToken&lt;TT&gt;'] and parameter[2][@type='com.google.gson.TypeAdapter&lt;TT&gt;']]"
		[Register ("newFactory", "(Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TT"})]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactory (global::Com.Google.Gson.Reflect.TypeToken p0, global::Com.Google.Gson.TypeAdapter p1)
		{
			if (id_newFactory_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapter_ == IntPtr.Zero)
				id_newFactory_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "newFactory", "(Lcom/google/gson/reflect/TypeToken;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFactory_Lcom_google_gson_reflect_TypeToken_Lcom_google_gson_TypeAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/method[@name='newFactory' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;TT&gt;'] and parameter[2][@type='com.google.gson.TypeAdapter&lt;TT&gt;']]"
		[Register ("newFactory", "(Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TT"})]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactory (global::Java.Lang.Class p0, global::Com.Google.Gson.TypeAdapter p1)
		{
			if (id_newFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ == IntPtr.Zero)
				id_newFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "newFactory", "(Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newFactory_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/method[@name='newFactory' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;TT&gt;'] and parameter[2][@type='java.lang.Class&lt;TT&gt;'] and parameter[3][@type='com.google.gson.TypeAdapter&lt;? super TT&gt;']]"
		[Register ("newFactory", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TT"})]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactory (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Com.Google.Gson.TypeAdapter p2)
		{
			if (id_newFactory_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ == IntPtr.Zero)
				id_newFactory_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "newFactory", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFactory_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newFactoryForMultipleTypes_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/method[@name='newFactoryForMultipleTypes' and count(parameter)=3 and parameter[1][@type='java.lang.Class&lt;TT&gt;'] and parameter[2][@type='java.lang.Class&lt;? extends TT&gt;'] and parameter[3][@type='com.google.gson.TypeAdapter&lt;? super TT&gt;']]"
		[Register ("newFactoryForMultipleTypes", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TT"})]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewFactoryForMultipleTypes (global::Java.Lang.Class p0, global::Java.Lang.Class p1, global::Com.Google.Gson.TypeAdapter p2)
		{
			if (id_newFactoryForMultipleTypes_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ == IntPtr.Zero)
				id_newFactoryForMultipleTypes_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "newFactoryForMultipleTypes", "(Ljava/lang/Class;Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newFactoryForMultipleTypes_Ljava_lang_Class_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_newTypeHierarchyFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.gson.internal.bind']/class[@name='TypeAdapters']/method[@name='newTypeHierarchyFactory' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;T1&gt;'] and parameter[2][@type='com.google.gson.TypeAdapter&lt;T1&gt;']]"
		[Register ("newTypeHierarchyFactory", "(Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T1"})]
		public static unsafe global::Com.Google.Gson.ITypeAdapterFactory NewTypeHierarchyFactory (global::Java.Lang.Class p0, global::Com.Google.Gson.TypeAdapter p1)
		{
			if (id_newTypeHierarchyFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ == IntPtr.Zero)
				id_newTypeHierarchyFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_ = JNIEnv.GetStaticMethodID (class_ref, "newTypeHierarchyFactory", "(Ljava/lang/Class;Lcom/google/gson/TypeAdapter;)Lcom/google/gson/TypeAdapterFactory;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Com.Google.Gson.ITypeAdapterFactory __ret = global::Java.Lang.Object.GetObject<global::Com.Google.Gson.ITypeAdapterFactory> (JNIEnv.CallStaticObjectMethod  (class_ref, id_newTypeHierarchyFactory_Ljava_lang_Class_Lcom_google_gson_TypeAdapter_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
