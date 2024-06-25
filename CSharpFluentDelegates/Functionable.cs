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

        protected void InvokeFuncWithExceptionRetryAndDelay(Func<TResult> del, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(
                () => {
                    result = del.Invoke();
                },
                maxAttempts,
                delayMs,
                onSuccess,
                onFail
            );
        }

        protected void InvokeFuncWithTimeout(Func<TResult> del, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(
                () => {
                    result = del.Invoke();
                },
                timeoutMs,
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
            InvokeFunc(() => { return DelegateEntity.Invoke(); }, onSuccess, onFail);
            return this;
        }

        public Functionable<TResult> InvokeAndRetry(int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<TResult> InvokeAndRetryWithDelay(int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() =>  { return DelegateEntity.Invoke(); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<TResult> InvokeWithTimeout(int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T, TResult> InvokeAndRetry(T t, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T, TResult> InvokeAndRetryWithDelay(T t, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T, TResult> InvokeWithTimeout(T t, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, TResult> InvokeAndRetry(T1 t1, T2 t2, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, TResult> InvokeWithTimeout(T1 t1, T2 t2, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15); }, timeoutMs, onSuccess, onFail);
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
            InvokeFunc(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16); }, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetry(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16); }, maxAttempts, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithExceptionRetryAndDelay(() => { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16); }, maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Functionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeFuncWithTimeout(() =>  { return DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16); }, timeoutMs, onSuccess, onFail);
            return this;
        }
    }
}