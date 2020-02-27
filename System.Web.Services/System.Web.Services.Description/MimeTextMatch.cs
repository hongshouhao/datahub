// System.Web.Services.Description.MimeTextMatch
using System.Xml.Serialization;
using System;
using System.ComponentModel;
using System.Globalization;

public sealed class MimeTextMatch
{
    private string name;

    private string type;

    private int repeats = 1;

    private string pattern;

    private int group = 1;

    private int capture;

    private bool ignoreCase;

    private MimeTextMatchCollection matches = new MimeTextMatchCollection();

    [XmlAttribute("name")]
    public string Name
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

    [XmlAttribute("type")]
    public string Type
    {
        get
        {
            if (type != null)
            {
                return type;
            }
            return string.Empty;
        }
        set
        {
            type = value;
        }
    }

    [XmlAttribute("group")]
    [DefaultValue(1)]
    public int Group
    {
        get
        {
            return group;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(ResWebServices.GetString(ResWebServices.WebNegativeValue, "group"));
            }
            group = value;
        }
    }

    [XmlAttribute("capture")]
    [DefaultValue(0)]
    public int Capture
    {
        get
        {
            return capture;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(ResWebServices.GetString(ResWebServices.WebNegativeValue, "capture"));
            }
            capture = value;
        }
    }

    [XmlIgnore]
    public int Repeats
    {
        get
        {
            return repeats;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(ResWebServices.GetString(ResWebServices.WebNegativeValue, "repeats"));
            }
            repeats = value;
        }
    }

    [XmlAttribute("repeats")]
    [DefaultValue("1")]
    public string RepeatsString
    {
        get
        {
            if (repeats != 2147483647)
            {
                return repeats.ToString(CultureInfo.InvariantCulture);
            }
            return "*";
        }
        set
        {
            if (value == "*")
            {
                repeats = 2147483647;
            }
            else
            {
                Repeats = int.Parse(value, CultureInfo.InvariantCulture);
            }
        }
    }

    [XmlAttribute("pattern")]
    public string Pattern
    {
        get
        {
            if (pattern != null)
            {
                return pattern;
            }
            return string.Empty;
        }
        set
        {
            pattern = value;
        }
    }

    [XmlAttribute("ignoreCase")]
    public bool IgnoreCase
    {
        get
        {
            return ignoreCase;
        }
        set
        {
            ignoreCase = value;
        }
    }

    [XmlElement("match")]
    public MimeTextMatchCollection Matches
    {
        get
        {
            return matches;
        }
    }
}
