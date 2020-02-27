// System.Web.Services.Description.MimeTextMatchCollection
using System.Collections;

public sealed class MimeTextMatchCollection : CollectionBase
{
    public MimeTextMatch this[int index]
    {
        get
        {
            return (MimeTextMatch)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public int Add(MimeTextMatch match)
    {
        return base.List.Add(match);
    }

    public void Insert(int index, MimeTextMatch match)
    {
        base.List.Insert(index, match);
    }

    public int IndexOf(MimeTextMatch match)
    {
        return base.List.IndexOf(match);
    }

    public bool Contains(MimeTextMatch match)
    {
        return base.List.Contains(match);
    }

    public void Remove(MimeTextMatch match)
    {
        base.List.Remove(match);
    }

    public void CopyTo(MimeTextMatch[] array, int index)
    {
        base.List.CopyTo(array, index);
    }
}
