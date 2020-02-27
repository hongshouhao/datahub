using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

[DebuggerNonUserCode]
[CompilerGenerated]
internal class ResWebServices
{
    private static ResourceManager resourceMan;

    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
        get
        {
            if (resourceMan == null)
            {
                ResourceManager temp = resourceMan = new ResourceManager("Microsoft.Tools.ServiceModel.Svcutil.System.Web.Services.ResWebServices", typeof(ResWebServices).GetTypeInfo().Assembly);
            }
            return resourceMan;
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
        get
        {
            return resourceCulture;
        }
        set
        {
            resourceCulture = value;
        }
    }

    internal static string Binding => ResourceManager.GetString("Binding", resourceCulture);

    internal static string CanTSpecifyElementOnEncodedMessagePartsPart => ResourceManager.GetString("CanTSpecifyElementOnEncodedMessagePartsPart", resourceCulture);

    internal static string CodegenWarningDetails => ResourceManager.GetString("CodegenWarningDetails", resourceCulture);

    internal static string Description => ResourceManager.GetString("Description", resourceCulture);

    internal static string Element => ResourceManager.GetString("Element", resourceCulture);

    internal static string Fault => ResourceManager.GetString("Fault", resourceCulture);

    internal static string FaultBinding => ResourceManager.GetString("FaultBinding", resourceCulture);

    internal static string HeaderFault => ResourceManager.GetString("HeaderFault", resourceCulture);

    internal static string Message => ResourceManager.GetString("Message", resourceCulture);

    internal static string MissingMessagePartForMessageFromNamespace3 => ResourceManager.GetString("MissingMessagePartForMessageFromNamespace3", resourceCulture);

    internal static string OnlyOperationInputOrOperationOutputTypes => ResourceManager.GetString("OnlyOperationInputOrOperationOutputTypes", resourceCulture);

    internal static string OnlyXmlElementsOrTypesDerivingFromServiceDescriptionFormatExtension0 => ResourceManager.GetString("OnlyXmlElementsOrTypesDerivingFromServiceDescriptionFormatExtension0", resourceCulture);

    internal static string Operation => ResourceManager.GetString("Operation", resourceCulture);

    internal static string OperationBinding => ResourceManager.GetString("OperationBinding", resourceCulture);

    internal static string Part => ResourceManager.GetString("Part", resourceCulture);

    internal static string Port => ResourceManager.GetString("Port", resourceCulture);

    internal static string ProtocolWithNameIsNotRecognized1 => ResourceManager.GetString("ProtocolWithNameIsNotRecognized1", resourceCulture);

    internal static string RequiredXmlFormatExtensionAttributeIsMissing1 => ResourceManager.GetString("RequiredXmlFormatExtensionAttributeIsMissing1", resourceCulture);

    internal static string SchemaSyntaxErrorDetails => ResourceManager.GetString("SchemaSyntaxErrorDetails", resourceCulture);

    internal static string SchemaValidationError => ResourceManager.GetString("SchemaValidationError", resourceCulture);

    internal static string TheSyntaxOfTypeMayNotBeExtended1 => ResourceManager.GetString("TheSyntaxOfTypeMayNotBeExtended1", resourceCulture);

    internal static string ValidationError => ResourceManager.GetString("ValidationError", resourceCulture);

    internal static string WebDescriptionMissing => ResourceManager.GetString("WebDescriptionMissing", resourceCulture);

    internal static string WebDescriptionMissingItem => ResourceManager.GetString("WebDescriptionMissingItem", resourceCulture);

    internal static string WebDescriptionTooManyMessages => ResourceManager.GetString("WebDescriptionTooManyMessages", resourceCulture);

    internal static string WebDuplicateBinding => ResourceManager.GetString("WebDuplicateBinding", resourceCulture);

    internal static string WebDuplicateFaultBinding => ResourceManager.GetString("WebDuplicateFaultBinding", resourceCulture);

    internal static string WebDuplicateFormatExtension => ResourceManager.GetString("WebDuplicateFormatExtension", resourceCulture);

    internal static string WebDuplicateImport => ResourceManager.GetString("WebDuplicateImport", resourceCulture);

    internal static string WebDuplicateMessage => ResourceManager.GetString("WebDuplicateMessage", resourceCulture);

    internal static string WebDuplicateMessagePart => ResourceManager.GetString("WebDuplicateMessagePart", resourceCulture);

    internal static string WebDuplicateOperation => ResourceManager.GetString("WebDuplicateOperation", resourceCulture);

    internal static string WebDuplicateOperationBinding => ResourceManager.GetString("WebDuplicateOperationBinding", resourceCulture);

    internal static string WebDuplicateOperationFault => ResourceManager.GetString("WebDuplicateOperationFault", resourceCulture);

    internal static string WebDuplicateOperationMessage => ResourceManager.GetString("WebDuplicateOperationMessage", resourceCulture);

    internal static string WebDuplicatePort => ResourceManager.GetString("WebDuplicatePort", resourceCulture);

    internal static string WebDuplicatePortType => ResourceManager.GetString("WebDuplicatePortType", resourceCulture);

    internal static string WebDuplicateService => ResourceManager.GetString("WebDuplicateService", resourceCulture);

    internal static string WebDuplicateUnknownElement => ResourceManager.GetString("WebDuplicateUnknownElement", resourceCulture);

    internal static string WebNegativeValue => ResourceManager.GetString("WebNegativeValue", resourceCulture);

    internal static string WsdlInstanceValidation => ResourceManager.GetString("WsdlInstanceValidation", resourceCulture);

    internal static string WsdlInstanceValidationDetails => ResourceManager.GetString("WsdlInstanceValidationDetails", resourceCulture);

    internal static string XmlLang => ResourceManager.GetString("XmlLang", resourceCulture);

    internal static string XmlSchema => ResourceManager.GetString("XmlSchema", resourceCulture);

    internal static string XmlSchemaAttributeReference => ResourceManager.GetString("XmlSchemaAttributeReference", resourceCulture);

    internal static string XmlSchemaContentDef => ResourceManager.GetString("XmlSchemaContentDef", resourceCulture);

    internal static string XmlSchemaElementReference => ResourceManager.GetString("XmlSchemaElementReference", resourceCulture);

    internal static string XmlSchemaItem => ResourceManager.GetString("XmlSchemaItem", resourceCulture);

    internal static string XmlSchemaNamedItem => ResourceManager.GetString("XmlSchemaNamedItem", resourceCulture);

    internal static string GetString(string format, params object[] values)
    {
        return string.Format(format, values);
    }

    internal ResWebServices()
    {
    }
}
