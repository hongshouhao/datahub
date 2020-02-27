// System.Web.Services.Description.OperationFaultCollection

public sealed class OperationFaultCollection : ServiceDescriptionBaseCollection
{
    public OperationFault this[int index]
    {
        get
        {
            return (OperationFault)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public OperationFault this[string name]
    {
        get
        {
            return (OperationFault)Table[name];
        }
    }

    internal OperationFaultCollection(Operation operation)
        : base(operation)
    {
    }

    public int Add(OperationFault operationFaultMessage)
    {
        return base.List.Add(operationFaultMessage);
    }

    public void Insert(int index, OperationFault operationFaultMessage)
    {
        base.List.Insert(index, operationFaultMessage);
    }

    public int IndexOf(OperationFault operationFaultMessage)
    {
        return base.List.IndexOf(operationFaultMessage);
    }

    public bool Contains(OperationFault operationFaultMessage)
    {
        return base.List.Contains(operationFaultMessage);
    }

    public void Remove(OperationFault operationFaultMessage)
    {
        base.List.Remove(operationFaultMessage);
    }

    public void CopyTo(OperationFault[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override string GetKey(object value)
    {
        return ((OperationFault)value).Name;
    }

    protected override void SetParent(object value, object parent)
    {
        ((OperationFault)value).SetParent((Operation)parent);
    }
}
