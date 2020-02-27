// System.Web.Services.Description.ImportCollection

public sealed class ImportCollection : ServiceDescriptionBaseCollection
{
    public Import this[int index]
    {
        get
        {
            return (Import)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    internal ImportCollection(ServiceDescription serviceDescription)
        : base(serviceDescription)
    {
    }

    public int Add(Import import)
    {
        return base.List.Add(import);
    }

    public void Insert(int index, Import import)
    {
        base.List.Insert(index, import);
    }

    public int IndexOf(Import import)
    {
        return base.List.IndexOf(import);
    }

    public bool Contains(Import import)
    {
        return base.List.Contains(import);
    }

    public void Remove(Import import)
    {
        base.List.Remove(import);
    }

    public void CopyTo(Import[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override void SetParent(object value, object parent)
    {
        ((Import)value).SetParent((ServiceDescription)parent);
    }
}
