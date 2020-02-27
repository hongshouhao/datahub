// System.Web.Services.Description.MessageBinding

public abstract class MessageBinding : NamedItem
{
    private OperationBinding parent;

    public OperationBinding OperationBinding => parent;

    internal void SetParent(OperationBinding parent)
    {
        this.parent = parent;
    }
}
