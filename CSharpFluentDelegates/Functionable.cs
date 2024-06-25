namespace CSharpFluentDelegates
{
    public abstract class AFunctionable<TResult> : Delegable
    {
        protected TResult? result;

        public TResult? Result()
        {
            return result;
        }

        protected void InvokeFunc(Func<TResult> del, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(
                () => {
                    result = del.Invoke();
                },
                onSuccess,
                onFail
            );
        }

        protected void InvokeFuncWithExceptionRetry(Func<TResult> del, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(
                () => {
                    result = del.Invoke();
                },
                maxAttempts,
                onSuccess,
                onFail
            );
        }
    }

    public class Functionable<TResult> : AFunctionable<TResult>
    {
        public Func<TResult> DelegateEntity { get; set; }

        public Functionable(Func<TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<TResult> Invoke(Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(), onSuccess, onFail);
            return this;
        }

        public Functionable<TResult> InvokeAndRetry(int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T, TResult> : AFunctionable<TResult>
    {
        public Func<T, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T, TResult> Invoke(T t, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t), onSuccess, onFail);
            return this;
        }

        public Functionable<T, TResult> InvokeAndRetry(T t, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, TResult> Invoke(T1 t1, T2 t2, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, TResult> InvokeAndRetry(T1 t1, T2 t2, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, TResult> Invoke(T1 t1, T2 t2, T3 t3, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), maxAttempts, onSuccess, onFail);
            return this;
        }
    }

    public class Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> : AFunctionable<TResult>
    {
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> DelegateEntity { get; set; }

        public Functionable(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFunc(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), maxAttempts, onSuccess, onFail);
            return this;
        }
    }
}
