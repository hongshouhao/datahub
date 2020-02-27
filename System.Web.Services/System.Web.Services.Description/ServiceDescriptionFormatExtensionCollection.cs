// System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection
using System;
using System.Collections;
using System.Xml;

public sealed class ServiceDescriptionFormatExtensionCollection : ServiceDescriptionBaseCollection
{
    private ArrayList handledElements;

    public object this[int index]
    {
        get
        {
            return base.List[index];
        }
        set
        {
            base.List[index] = value;
        }
    }

    public ServiceDescriptionFormatExtensionCollection(object parent)
        : base(parent)
    {
    }

    public int Add(object extension)
    {
        return base.List.Add(extension);
    }

    public void Insert(int index, object extension)
    {
        base.List.Insert(index, extension);
    }

    public int IndexOf(object extension)
    {
        return base.List.IndexOf(extension);
    }

    public bool Contains(object extension)
    {
        return base.List.Contains(extension);
    }

    public void Remove(object extension)
    {
        base.List.Remove(extension);
    }

    public void CopyTo(object[] array, int index)
    {
        base.List.CopyTo(array, index);
    }

    public object Find(Type type)
    {
        for (int i = 0; i < base.List.Count; i++)
        {
            object item = base.List[i];
            if (type.IsAssignableFrom(item.GetType()))
            {
                ((ServiceDescriptionFormatExtension)item).Handled = true;
                return item;
            }
        }
        return null;
    }

    public object[] FindAll(Type type)
    {
        ArrayList list = new ArrayList();
        for (int i = 0; i < base.List.Count; i++)
        {
            object item = base.List[i];
            if (type.IsAssignableFrom(item.GetType()))
            {
                ((ServiceDescriptionFormatExtension)item).Handled = true;
                list.Add(item);
            }
        }
        return (object[])list.ToArray(type);
    }

    public XmlElement Find(string name, string ns)
    {
        for (int i = 0; i < base.List.Count; i++)
        {
            XmlElement element = base.List[i] as XmlElement;
            if (element != null && element.LocalName == name && element.NamespaceURI == ns)
            {
                SetHandled(element);
                return element;
            }
        }
        return null;
    }

    public XmlElement[] FindAll(string name, string ns)
    {
        ArrayList list = new ArrayList();
        for (int i = 0; i < base.List.Count; i++)
        {
            XmlElement element = base.List[i] as XmlElement;
            if (element != null && element.LocalName == name && element.NamespaceURI == ns)
            {
                SetHandled(element);
                list.Add(element);
            }
        }
        return (XmlElement[])list.ToArray(typeof(XmlElement));
    }

    private void SetHandled(XmlElement element)
    {
        if (handledElements == null)
        {
            handledElements = new ArrayList();
        }
        if (!handledElements.Contains(element))
        {
            handledElements.Add(element);
        }
    }

    public bool IsHandled(object item)
    {
        if (item is XmlElement)
        {
            return IsHandled((XmlElement)item);
        }
        return ((ServiceDescriptionFormatExtension)item).Handled;
    }

    public bool IsRequired(object item)
    {
        if (item is XmlElement)
        {
            return IsRequired((XmlElement)item);
        }
        return ((ServiceDescriptionFormatExtension)item).Required;
    }

    private bool IsHandled(XmlElement element)
    {
        if (handledElements == null)
        {
            return false;
        }
        return handledElements.Contains(element);
    }

    private bool IsRequired(XmlElement element)
    {
        XmlAttribute requiredAttr = element.Attributes["required", "http://schemas.xmlsoap.org/wsdl/"];
        if (requiredAttr != null && requiredAttr.Value != null)
        {
            goto IL_003f;
        }
        requiredAttr = element.Attributes["required"];
        if (requiredAttr != null && requiredAttr.Value != null)
        {
            goto IL_003f;
        }
        return false;
    IL_003f:
        return XmlConvert.ToBoolean(requiredAttr.Value);
    }

    protected override void SetParent(object value, object parent)
    {
        if (value is ServiceDescriptionFormatExtension)
        {
            ((ServiceDescriptionFormatExtension)value).SetParent(parent);
        }
    }

    protected override void OnValidate(object value)
    {
        if (!(value is XmlElement) && !(value is ServiceDescriptionFormatExtension))
        {
            throw new ArgumentException(ResWebServices.GetString(ResWebServices.OnlyXmlElementsOrTypesDerivingFromServiceDescriptionFormatExtension0, Array.Empty<object>()), "value");
        }
        base.OnValidate(value);
    }
}
