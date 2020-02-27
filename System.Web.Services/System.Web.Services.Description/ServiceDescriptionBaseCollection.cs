// System.Web.Services.Description.ServiceDescriptionBaseCollection
using System;
using System.Collections;

public abstract class ServiceDescriptionBaseCollection : CollectionBase
{
    private Hashtable table;

    private object parent;

    protected virtual IDictionary Table
    {
        get
        {
            if (table == null)
            {
                table = new Hashtable();
            }
            return table;
        }
    }

    internal ServiceDescriptionBaseCollection(object parent)
    {
        this.parent = parent;
    }

    protected virtual string GetKey(object value)
    {
        return null;
    }

    protected virtual void SetParent(object value, object parent)
    {
    }

    protected override void OnInsertComplete(int index, object value)
    {
        AddValue(value);
    }

    protected override void OnRemove(int index, object value)
    {
        RemoveValue(value);
    }

    protected override void OnClear()
    {
        for (int i = 0; i < base.List.Count; i++)
        {
            RemoveValue(base.List[i]);
        }
    }

    protected override void OnSet(int index, object oldValue, object newValue)
    {
        RemoveValue(oldValue);
        AddValue(newValue);
    }

    private void AddValue(object value)
    {
        string key = GetKey(value);
        if (key != null)
        {
            try
            {
                Table.Add(key, value);
            }
            catch (Exception e)
            {
                if (e is OutOfMemoryException)
                {
                    throw;
                }
                if (Table[key] != null)
                {
                    throw new ArgumentException(GetDuplicateMessage(value.GetType(), key), e.InnerException);
                }
                throw e;
            }
        }
        SetParent(value, parent);
    }

    private void RemoveValue(object value)
    {
        string key = GetKey(value);
        if (key != null)
        {
            Table.Remove(key);
        }
        SetParent(value, null);
    }

    private static string GetDuplicateMessage(Type type, string elemName)
    {
        string message = null;
        if (type == typeof(ServiceDescriptionFormatExtension))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateFormatExtension, elemName);
        }
        if (type == typeof(OperationMessage))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateOperationMessage, elemName);
        }
        if (type == typeof(Import))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateImport, elemName);
        }
        if (type == typeof(Message))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateMessage, elemName);
        }
        if (type == typeof(Port))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicatePort, elemName);
        }
        if (type == typeof(PortType))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicatePortType, elemName);
        }
        if (type == typeof(Binding))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateBinding, elemName);
        }
        if (type == typeof(Service))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateService, elemName);
        }
        if (type == typeof(MessagePart))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateMessagePart, elemName);
        }
        if (type == typeof(OperationBinding))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateOperationBinding, elemName);
        }
        if (type == typeof(FaultBinding))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateFaultBinding, elemName);
        }
        if (type == typeof(Operation))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateOperation, elemName);
        }
        if (type == typeof(OperationFault))
        {
            return ResWebServices.GetString(ResWebServices.WebDuplicateOperationFault, elemName);
        }
        return ResWebServices.GetString(ResWebServices.WebDuplicateUnknownElement, type, elemName);
    }
}
