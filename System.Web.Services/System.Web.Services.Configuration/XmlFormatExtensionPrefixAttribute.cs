// System.Web.Services.Configuration.XmlFormatExtensionPrefixAttribute
using System;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class XmlFormatExtensionPrefixAttribute : Attribute
{
    private string prefix;

    private string ns;

    public string Prefix
    {
        get
        {
            if (prefix != null)
            {
                return prefix;
            }
            return string.Empty;
        }
        set
        {
            prefix = value;
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

    public XmlFormatExtensionPrefixAttribute()
    {
    }

    public XmlFormatExtensionPrefixAttribute(string prefix, string ns)
    {
        this.prefix = prefix;
        this.ns = ns;
    }
}
