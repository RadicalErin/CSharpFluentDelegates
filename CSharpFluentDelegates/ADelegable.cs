namespace CSharpFluentDelegates
{
    public abstract class ADelegable
    {
        protected bool isSuccessful;

        protected bool lastTimedOut = false;

        protected Exception? lastException;

        protected Exception[] exceptions = [];

        protected int invokeCount = 0;

        protected int successCount = 0;

        public bool WasSuccessfulLast()
        {
            return isSuccessful;
        }

        public bool WasSuccessfulEver()
        {
            return successCount > 0;
        }

        public bool WasNeverSuccessful()
        {
            return successCount == 0 && invokeCount > 0;
        }

        public Exception GetLastException()
        {
            if (lastException == null)
            {
                throw new InvalidOperationException("Last exception was requested, but none is present");
            }
            return lastException;
        }

        public Exception[] GetAllExceptions()
        {
            return exceptions;
        }

        protected void InvokeAction(Action del, Action? onSuccess = null, Action? onFail = null)
        {
            try
            {
                invokeCount++;
                del.Invoke();
                isSuccessful = true;
                lastException = null;
                successCount++;
                if (onSuccess != null)
                {
                    onSuccess();
                }
            }
            catch (Exception e)
            {
                isSuccessful = false;
                lastException = e;
                exceptions.Append(e);
                if (onFail != null)
                {
                    onFail();
                }
            }
        }

        protected void InvokeActionWithExceptionRetry(Action del, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            int localInvokeCount = 0;
            while (!isSuccessful && localInvokeCount < maxAttempts)
            {
                localInvokeCount++;
                InvokeAction(del, onSuccess, onFail);
            }
        }

        protected void InvokeActionWithExceptionRetryAndDelay(Action del, int maxAttempts, int delayMs, Action? onSuccess = null, Action? onFail = null)
        {
            int localInvokeCount = 0;
            while (!isSuccessful && localInvokeCount < maxAttempts)
            {
                localInvokeCount++;
                InvokeAction(del, onSuccess, onFail);
                if(!isSuccessful)
                {
                    Thread.Sleep(delayMs);
                }
            }
        }

        protected void InvokeActionWithExceptionRetryAndDelayFunction(Action del, int maxAttempts, Func<int, int> calculateDelay, Action? onSuccess = null, Action? onFail = null)
        {
            int localInvokeCount = 0;
            while (!isSuccessful && localInvokeCount < maxAttempts)
            {
                localInvokeCount++;
                InvokeAction(del, onSuccess, onFail);
                if (!isSuccessful)
                {
                    Thread.Sleep(calculateDelay(localInvokeCount));
                }
            }
        }

        protected void InvokeActionWithTimeout(Action del, int timeoutMs, Action? onSuccess = null, Action? onFail = null)
        {
            try
            {
                invokeCount++;
                var task = Task.Run(() => del.Invoke());
                if (task.Wait(TimeSpan.FromMilliseconds(timeoutMs)))
                {
                    lastTimedOut = false;
                }
                else
                {
                    lastTimedOut = true;
                    throw new TimeoutException("Invocation did not succeed or finish within provided timeout window");
                }
                isSuccessful = true;
                lastException = null;
                successCount++;
                if (onSuccess != null)
                {
                    onSuccess();
                }
            }
            catch (Exception e)
            {
                isSuccessful = false;
                lastException = e;
                exceptions.Append(e);
                if (onFail != null)
                {
                    onFail();
                }
            }
        }

        protected void InvokeActionWithTimeoutAndRetry(Action del, int timeoutMs, int maxAttempts, Action? onSuccess = null, Action? onFail = null)
        {
            int localInvokeCount = 0;
            while (!isSuccessful && localInvokeCount < maxAttempts)
            {
                localInvokeCount++;
                InvokeActionWithTimeout(del, timeoutMs, onSuccess, onFail);
            }
        }
    }
}
