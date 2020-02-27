// System.Web.Services.Description.BindingCollection

public sealed class BindingCollection : ServiceDescriptionBaseCollection
{
    public Binding this[int index]
    {
        get
        {
            return (Binding)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public Binding this[string name]
    {
        get
        {
            return (Binding)Table[name];
        }
    }

    internal BindingCollection(ServiceDescription serviceDescription)
        : base(serviceDescription)
    {
    }

    public int Add(Binding binding)
    {
        return base.List.Add(binding);
    }

    public void Insert(int index, Binding binding)
    {
        base.List.Insert(index, binding);
    }

    public int IndexOf(Binding binding)
    {
        return base.List.IndexOf(binding);
    }

    public bool Contains(Binding binding)
    {
        return base.List.Contains(binding);
    }

    public void Remove(Binding binding)
    {
        base.List.Remove(binding);
    }

    public void CopyTo(Binding[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override string GetKey(object value)
    {
        return ((Binding)value).Name;
    }

    protected override void SetParent(object value, object parent)
    {
        ((Binding)value).SetParent((ServiceDescription)parent);
    }
}
