// System.Web.Services.Description.Operation
using System.Xml.Serialization;
using System.ComponentModel;
using System.Text;

[XmlFormatExtensionPoint("Extensions")]
public sealed class Operation : NamedItem
{
    private string[] parameters;

    private OperationMessageCollection messages;

    private OperationFaultCollection faults;

    private PortType parent;

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

    public PortType PortType => parent;

    [XmlAttribute("parameterOrder")]
    [DefaultValue("")]
    public string ParameterOrderString
    {
        get
        {
            if (parameters == null)
            {
                return string.Empty;
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < parameters.Length; i++)
            {
                if (i > 0)
                {
                    builder.Append(' ');
                }
                builder.Append(parameters[i]);
            }
            return builder.ToString();
        }
        set
        {
            if (value == null)
            {
                parameters = null;
            }
            else
            {
                parameters = value.Split(new char[1]
                {
                    ' '
                });
            }
        }
    }

    [XmlIgnore]
    public string[] ParameterOrder
    {
        get
        {
            return parameters;
        }
        set
        {
            parameters = value;
        }
    }

    [XmlElement("input", typeof(OperationInput))]
    [XmlElement("output", typeof(OperationOutput))]
    public OperationMessageCollection Messages
    {
        get
        {
            if (messages == null)
            {
                messages = new OperationMessageCollection(this);
            }
            return messages;
        }
    }

    [XmlElement("fault")]
    public OperationFaultCollection Faults
    {
        get
        {
            if (faults == null)
            {
                faults = new OperationFaultCollection(this);
            }
            return faults;
        }
    }

    internal void SetParent(PortType parent)
    {
        this.parent = parent;
    }

    public bool IsBoundBy(OperationBinding operationBinding)
    {
        if (operationBinding.Name != base.Name)
        {
            return false;
        }
        OperationMessage input = Messages.Input;
        if (input != null)
        {
            if (operationBinding.Input == null)
            {
                return false;
            }
            string portTypeInputName = GetMessageName(base.Name, input.Name, true);
            string bindingInputName = GetMessageName(operationBinding.Name, operationBinding.Input.Name, true);
            if (bindingInputName != portTypeInputName)
            {
                return false;
            }
        }
        else if (operationBinding.Input != null)
        {
            return false;
        }
        OperationMessage output = Messages.Output;
        if (output != null)
        {
            if (operationBinding.Output == null)
            {
                return false;
            }
            string portTypeOutputName = GetMessageName(base.Name, output.Name, false);
            string bindingOutputName = GetMessageName(operationBinding.Name, operationBinding.Output.Name, false);
            if (bindingOutputName != portTypeOutputName)
            {
                return false;
            }
        }
        else if (operationBinding.Output != null)
        {
            return false;
        }
        return true;
    }

    private string GetMessageName(string operationName, string messageName, bool isInput)
    {
        if (messageName != null && messageName.Length > 0)
        {
            return messageName;
        }
        switch (Messages.Flow)
        {
            case OperationFlow.RequestResponse:
                if (isInput)
                {
                    return operationName + "Request";
                }
                return operationName + "Response";
            case OperationFlow.OneWay:
                if (isInput)
                {
                    return operationName;
                }
                return null;
            case OperationFlow.SolicitResponse:
                return null;
            case OperationFlow.Notification:
                return null;
            default:
                return null;
        }
    }
}
