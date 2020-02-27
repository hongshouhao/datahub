// System.Web.Services.Description.OperationCollection

public sealed class OperationCollection : ServiceDescriptionBaseCollection
{
    public Operation this[int index]
    {
        get
        {
            return (Operation)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    internal OperationCollection(PortType portType)
        : base(portType)
    {
    }

    public int Add(Operation operation)
    {
        return base.List.Add(operation);
    }

    public void Insert(int index, Operation operation)
    {
        base.List.Insert(index, operation);
    }

    public int IndexOf(Operation operation)
    {
        return base.List.IndexOf(operation);
    }

    public bool Contains(Operation operation)
    {
        return base.List.Contains(operation);
    }

    public void Remove(Operation operation)
    {
        base.List.Remove(operation);
    }

    public void CopyTo(Operation[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override void SetParent(object value, object parent)
    {
        ((Operation)value).SetParent((PortType)parent);
    }
}
