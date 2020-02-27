// System.Web.Services.Configuration.XmlFormatExtensionPointAttribute
using System;

[AttributeUsage(AttributeTargets.Class)]
public sealed class XmlFormatExtensionPointAttribute : Attribute
{
    private string name;

    private bool allowElements = true;

    public string MemberName
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

    public bool AllowElements
    {
        get
        {
            return allowElements;
        }
        set
        {
            allowElements = value;
        }
    }

    public XmlFormatExtensionPointAttribute(string memberName)
    {
        name = memberName;
    }
}
