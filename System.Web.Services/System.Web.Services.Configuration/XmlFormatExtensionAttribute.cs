// System.Web.Services.Configuration.XmlFormatExtensionAttribute
using System;

[AttributeUsage(AttributeTargets.Class)]
public sealed class XmlFormatExtensionAttribute : Attribute
{
    private Type[] types;

    private string name;

    private string ns;

    public Type[] ExtensionPoints
    {
        get
        {
            if (types != null)
            {
                return types;
            }
            return new Type[0];
        }
        set
        {
            types = value;
        }
    }

    public string Namespace
    {
        get
        {
            if (ns != null)
            {
                return ns;
            }
            return string.Empty;
        }
        set
        {
            ns = value;
        }
    }

    public string ElementName
    {
        get
        {
            if (name != null)
            {
                return name;
            }
            return string.Empty;
        }
        set
        {
            name = value;
        }
    }

    public XmlFormatExtensionAttribute()
    {
    }

    public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1)
        : this(elementName, ns, new Type[1]
        {
            extensionPoint1
        })
    {
    }

    public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2)
        : this(elementName, ns, new Type[2]
        {
            extensionPoint1,
            extensionPoint2
        })
    {
    }

    public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2, Type extensionPoint3)
        : this(elementName, ns, new Type[3]
        {
            extensionPoint1,
            extensionPoint2,
            extensionPoint3
        })
    {
    }

    public XmlFormatExtensionAttribute(string elementName, string ns, Type extensionPoint1, Type extensionPoint2, Type extensionPoint3, Type extensionPoint4)
        : this(elementName, ns, new Type[4]
        {
            extensionPoint1,
            extensionPoint2,
            extensionPoint3,
            extensionPoint4
        })
    {
    }

    public XmlFormatExtensionAttribute(string elementName, string ns, Type[] extensionPoints)
    {
        name = elementName;
        this.ns = ns;
        types = extensionPoints;
    }
}
