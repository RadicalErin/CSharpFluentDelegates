namespace CSharpFluentDelegates
{
    public class ActionContainer : DelegateContainer
    {
        public Action DelegateEntity { get; set; }

        public ActionContainer(Action delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(), onSuccess, onFail);
        }
    }

    public class ActionContainer<T> : DelegateContainer
    {
        public Action<T> DelegateEntity { get; set; }

        public ActionContainer(Action<T> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T t, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2> : DelegateContainer
    {
        public Action<T1, T2> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3> : DelegateContainer
    {
        public Action<T1, T2, T3> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4> : DelegateContainer
    {
        public Action<T1, T2, T3, T4> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15), onSuccess, onFail);
        }
    }

    public class ActionContainer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : DelegateContainer
    {
        public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> DelegateEntity { get; set; }

        public ActionContainer(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> delegateEntity)
        {
            DelegateEntity = delegateEntity;
            isSuccessful = false;
        }

        public void Invoke(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5, T6 t6, T7 t7, T8 t8, T9 t9, T10 t10, T11 t11, T12 t12, T13 t13, T14 t14, T15 t15, T16 t16, Action? onSuccess = null, Action? onFail = null)
        {
            InvokeAction(() => DelegateEntity.Invoke(t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16), onSuccess, onFail);
        }
    }
}
