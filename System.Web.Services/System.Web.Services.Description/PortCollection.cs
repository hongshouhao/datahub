// System.Web.Services.Description.PortCollection

public sealed class PortCollection : ServiceDescriptionBaseCollection
{
    public Port this[int index]
    {
        get
        {
            return (Port)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public Port this[string name]
    {
        get
        {
            return (Port)Table[name];
        }
    }

    internal PortCollection(Service service)
        : base(service)
    {
    }

    public int Add(Port port)
    {
        return base.List.Add(port);
    }

    public void Insert(int index, Port port)
    {
        base.List.Insert(index, port);
    }

    public int IndexOf(Port port)
    {
        return base.List.IndexOf(port);
    }

    public bool Contains(Port port)
    {
        return base.List.Contains(port);
    }

    public void Remove(Port port)
    {
        base.List.Remove(port);
    }

    public void CopyTo(Port[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override string GetKey(object value)
    {
        return ((Port)value).Name;
    }

    protected override void SetParent(object value, object parent)
    {
        ((Port)value).SetParent((Service)parent);
    }
}
