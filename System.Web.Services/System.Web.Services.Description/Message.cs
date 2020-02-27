// System.Web.Services.Description.Message
using System;
using System.Xml.Serialization;

[XmlFormatExtensionPoint("Extensions")]
public sealed class Message : NamedItem
{
    private MessagePartCollection parts;

    private ServiceDescription parent;

    private ServiceDescriptionFormatExtensionCollection extensions;

    [XmlIgnore]
    public override ServiceDescriptionFormatExtensionCollection Extensions
    {
        get
        {
            if (extensions == null)
            {
                extensions = new ServiceDescriptionFormatExtensionCollection(this);
            }
            return extensions;
        }
    }

    public ServiceDescription ServiceDescription => parent;

    [XmlElement("part")]
    public MessagePartCollection Parts
    {
        get
        {
            if (parts == null)
            {
                parts = new MessagePartCollection(this);
            }
            return parts;
        }
    }

    internal void SetParent(ServiceDescription parent)
    {
        this.parent = parent;
    }

    public MessagePart[] FindPartsByName(string[] partNames)
    {
        MessagePart[] partArray = new MessagePart[partNames.Length];
        for (int i = 0; i < partNames.Length; i++)
        {
            partArray[i] = FindPartByName(partNames[i]);
        }
        return partArray;
    }

    public MessagePart FindPartByName(string partName)
    {
        for (int i = 0; i < parts.Count; i++)
        {
            MessagePart part = parts[i];
            if (part.Name == partName)
            {
                return part;
            }
        }
        throw new ArgumentException(ResWebServices.GetString(ResWebServices.MissingMessagePartForMessageFromNamespace3, partName, base.Name, ServiceDescription.TargetNamespace), "partName");
    }
}
