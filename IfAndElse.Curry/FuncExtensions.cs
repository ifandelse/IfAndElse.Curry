using System;

namespace IfAndElse.Curry
{
    public static class FuncExtensions
    {
        public static Func<TResult> Curry<T1, TResult>(this Func<T1, TResult> f, T1 arg1)
        {
            return () => f.Invoke(arg1);
        }

        public static Func<T2, TResult> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> f, T1 arg1)
        {
            return (arg2) => f.Invoke( arg1, arg2 );
        }

        public static Func<T3, TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> f, T1 arg1, T2 arg2)
        {
            return (arg3) => f.Invoke(arg1, arg2, arg3);
        }

        public static Func<T4, TResult> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> f, T1 arg1, T2 arg2, T3 arg3)
        {
            return (arg4) => f.Invoke(arg1, arg2, arg3, arg4);
        }

        public static Func<T5, TResult> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> f, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            return (arg5) => f.Invoke(arg1, arg2, arg3, arg4, arg5);
        }

        public static Func<T6, TResult> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> f, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            return (arg6) => f.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
        }

        public static Func<T7, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5,T6, T7, TResult> f, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            return (arg7) => f.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }

        public static Func<T8, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> f, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            return (arg8) => f.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }

        public static Func<T9, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> f, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            return (arg9) => f.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }

        public static Func<T10, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> f, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            return (arg10) => f.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }

        public static Func<T11, TResult> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> f, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            return (arg11) => f.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        }
    }
}