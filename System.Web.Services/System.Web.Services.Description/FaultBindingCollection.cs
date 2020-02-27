// System.Web.Services.Description.FaultBindingCollection

public sealed class FaultBindingCollection : ServiceDescriptionBaseCollection
{
    public FaultBinding this[int index]
    {
        get
        {
            return (FaultBinding)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public FaultBinding this[string name]
    {
        get
        {
            return (FaultBinding)Table[name];
        }
    }

    internal FaultBindingCollection(OperationBinding operationBinding)
        : base(operationBinding)
    {
    }

    public int Add(FaultBinding bindingOperationFault)
    {
        return base.List.Add(bindingOperationFault);
    }

    public void Insert(int index, FaultBinding bindingOperationFault)
    {
        base.List.Insert(index, bindingOperationFault);
    }

    public int IndexOf(FaultBinding bindingOperationFault)
    {
        return base.List.IndexOf(bindingOperationFault);
    }

    public bool Contains(FaultBinding bindingOperationFault)
    {
        return base.List.Contains(bindingOperationFault);
    }

    public void Remove(FaultBinding bindingOperationFault)
    {
        base.List.Remove(bindingOperationFault);
    }

    public void CopyTo(FaultBinding[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override string GetKey(object value)
    {
        return ((FaultBinding)value).Name;
    }

    protected override void SetParent(object value, object parent)
    {
        ((FaultBinding)value).SetParent((OperationBinding)parent);
    }
}
