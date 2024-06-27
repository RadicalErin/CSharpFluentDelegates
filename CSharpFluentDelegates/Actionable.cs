namespace CSharpFluentDelegates
{
    public class Actionable : ADelegable
    {
        public Action DelegateEntity { get; set; }

        public Actionable(Action delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable Invoke(Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(), onSuccess, onFail);
            return this;
        }

        public Actionable InvokeAndRetry(int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable InvokeAndRetryWithDelay(int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable InvokeAndRetryWithDelayFunction(int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable InvokeWithTimeout(int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable InvokeWithTimeoutAndRetry(Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T> : ADelegable
    {
        public Action<T> DelegateEntity { get; set; }

        public Actionable(Action<T> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T> Invoke(T t, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t), onSuccess, onFail);
            return this;
        }

        public Actionable<T> InvokeAndRetry(T t, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T> InvokeAndRetryWithDelay(T t, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T> InvokeAndRetryWithDelayFunction(T t, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T> InvokeWithTimeout(T t, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T> InvokeWithTimeoutAndRetry(T t, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2> : ADelegable
    {
        public Action<T1, T2> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2> Invoke(T1 t1, T2 t2, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2> InvokeAndRetry(T1 t1, T2 t2, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2> InvokeAndRetryWithDelay(T1 t1, T2 t2, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2> InvokeWithTimeout(T1 t1, T2 t2, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3> : ADelegable
    {
        public Action<T1, T2, T3> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3> Invoke(T1 t1, T2 t2, T3 t3, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3> InvokeAndRetry(T1 t1, T2 t2, T3 t3, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4> : ADelegable
    {
        public Action<T1, T2, T3, T4> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }

    public class Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : ADelegable
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> DelegateEntity { get; set; }

        public Actionable(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> InvokeAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), maxAttempts, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> InvokeAndRetryWithDelay(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelay(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), maxAttempts, delayMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> InvokeAndRetryWithDelayFunction(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int maxAttempts, Func<int, int> delayFunction, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithExceptionRetryAndDelayFunction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), maxAttempts, delayFunction, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> InvokeWithTimeout(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeout(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), timeoutMs, onSuccess, onFail);
            return this;
        }

        public Actionable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> InvokeWithTimeoutAndRetry(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, Action del, int timeoutMs, int retryTimes, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeActionWithTimeoutAndRetry(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), timeoutMs, retryTimes, onSuccess, onFail);
            return this;
        }
    }
}
