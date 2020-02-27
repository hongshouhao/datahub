// System.Web.Services.Description.MessagePartCollection

public sealed class MessagePartCollection : ServiceDescriptionBaseCollection
{
    public MessagePart this[int index]
    {
        get
        {
            return (MessagePart)base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public MessagePart this[string name]
    {
        get
        {
            return (MessagePart)Table[name];
        }
    }

    internal MessagePartCollection(Message message)
        : base(message)
    {
    }

    public int Add(MessagePart messagePart)
    {
        return base.List.Add(messagePart);
    }

    public void Insert(int index, MessagePart messagePart)
    {
        base.List.Insert(index, messagePart);
    }

    public int IndexOf(MessagePart messagePart)
    {
        return base.List.IndexOf(messagePart);
    }

    public bool Contains(MessagePart messagePart)
    {
        return base.List.Contains(messagePart);
    }

    public void Remove(MessagePart messagePart)
    {
        base.List.Remove(messagePart);
    }

    public void CopyTo(MessagePart[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    protected override string GetKey(object value)
    {
        return ((MessagePart)value).Name;
    }

    protected override void SetParent(object value, object parent)
    {
        ((MessagePart)value).SetParent((Message)parent);
    }
}
