using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IfAndElse.Curry
{
    public static class ActionExtensions
    {
        public static Action Curry<T1>(this Action<T1> d, T1 arg1)
        {
            return () => d.Invoke(arg1);
        }

        public static Action<T2> Curry<T1, T2>(this Action<T1, T2> d, T1 arg1)
        {
            return (arg2) => d.Invoke(arg1, arg2);
        }

        public static Action<T3> Curry<T1, T2, T3>(this Action<T1, T2, T3> d, T1 arg1, T2 arg2)
        {
            return (arg3) => d.Invoke(arg1, arg2, arg3);
        }

        public static Action<T4> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> d, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4) => d.Invoke(arg1, arg2, arg3, arg4);
        }

        public static Action<T5> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> d, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5) => d.Invoke(arg1, arg2, arg3, arg4, arg5);
        }

        public static Action<T6> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> d, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6) => d.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Action<T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> d, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7) => d.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Action<T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> d, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8) => d.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Action<T9> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> d, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9) => d.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Action<T10> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> d, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10) => d.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Action<T11> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> d, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (arg11) => d.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
    }
}
