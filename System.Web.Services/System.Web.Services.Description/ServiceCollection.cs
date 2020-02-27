// System.Web.Services.Description.ServiceCollection

public sealed class ServiceCollection : ServiceDescriptionBaseCollection
{
    public Service this[int index]
    {
        get
        {
            return (Service)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public Service this[string name]
    {
        get
        {
            return (Service)Table[name];
        }
    }

    internal ServiceCollection(ServiceDescription serviceDescription)
        : base(serviceDescription)
    {
    }

    public int Add(Service service)
    {
        return base.List.Add(service);
    }

    public void Insert(int index, Service service)
    {
        base.List.Insert(index, service);
    }

    public int IndexOf(Service service)
    {
        return base.List.IndexOf(service);
    }

    public bool Contains(Service service)
    {
        return base.List.Contains(service);
    }

    public void Remove(Service service)
    {
        base.List.Remove(service);
    }

    public void CopyTo(Service[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override string GetKey(object value)
    {
        return ((Service)value).Name;
    }

    protected override void SetParent(object value, object parent)
    {
        ((Service)value).SetParent((ServiceDescription)parent);
    }
}
