namespace CSharpFluentDelegates
{
    public abstract class DelegateContainer
    {
        protected bool isSuccessful;

        protected Exception? lastException;

        protected Exception[] exceptions = [];

        protected int invokeCount = 0;

        protected int successCount = 0;

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
    }
}
