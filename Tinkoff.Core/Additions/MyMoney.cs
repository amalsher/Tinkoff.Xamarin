using System;
using Android.Runtime;
using Object = Java.Lang.Object;

namespace RU.Tinkoff.Acquiring.Sdk
{
    public partial class Money
    {
        public unsafe int CompareTo(Object p0)
        {
            //return Long.ValueOf(n_GetCoins).CompareTo((o as Money).n_GetCoins);

            if (id_compareTo_Lru_tinkoff_acquiring_sdk_Money_ == IntPtr.Zero)
                id_compareTo_Lru_tinkoff_acquiring_sdk_Money_ = JNIEnv.GetMethodID(class_ref, "compareTo", "(Lru/tinkoff/acquiring/sdk/Money;)I");
            try
            {
                JValue* __args = stackalloc JValue[1];
                __args[0] = new JValue(p0);

                int __ret;
                if (((object)this).GetType() == ThresholdType)
                    __ret = JNIEnv.CallIntMethod(((global::Java.Lang.Object)this).Handle, id_compareTo_Lru_tinkoff_acquiring_sdk_Money_, __args);
                else
                    __ret = JNIEnv.CallNonvirtualIntMethod(((global::Java.Lang.Object)this).Handle, ThresholdClass, JNIEnv.GetMethodID(ThresholdClass, "compareTo", "(Lru/tinkoff/acquiring/sdk/Money;)I"), __args);
                return __ret;
            }
            finally
            {
            }
        }
    }
}
