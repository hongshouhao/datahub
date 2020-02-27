// System.Web.Services.Description.OperationBindingCollection

public sealed class OperationBindingCollection : ServiceDescriptionBaseCollection
{
    public OperationBinding this[int index]
    {
        get
        {
            return (OperationBinding)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    internal OperationBindingCollection(Binding binding)
        : base(binding)
    {
    }

    public int Add(OperationBinding bindingOperation)
    {
        return base.List.Add(bindingOperation);
    }

    public void Insert(int index, OperationBinding bindingOperation)
    {
        base.List.Insert(index, bindingOperation);
    }

    public int IndexOf(OperationBinding bindingOperation)
    {
        return base.List.IndexOf(bindingOperation);
    }

    public bool Contains(OperationBinding bindingOperation)
    {
        return base.List.Contains(bindingOperation);
    }

    public void Remove(OperationBinding bindingOperation)
    {
        base.List.Remove(bindingOperation);
    }

    public void CopyTo(OperationBinding[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override void SetParent(object value, object parent)
    {
        ((OperationBinding)value).SetParent((Binding)parent);
    }
}
