﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.18051
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.0.30319.17929.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/appx/2010/manifest", IsNullable = false)]
public partial class Extensions
{

    private ExtensionsExtension extensionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Extension")]
    public ExtensionsExtension Extension
    {
        get
        {
            return this.extensionField;
        }
        set
        {
            this.extensionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class ExtensionsExtension
{
    /// <remarks/>
    [XmlElement("Protocol")]
    public ExtensionsExtensionProtocol[] Protocol { get; set; }

    /// <remarks/>
    [XmlElement("InProcessServer")]
    public ExtensionsExtensionInProcessServer[] InProcessServer { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string Category { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string Executable { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string EntryPoint { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class ExtensionsExtensionProtocol
{
    /// <remarks/>
    [XmlAttribute()]
    public string Name { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class ExtensionsExtensionInProcessServer
{
    /// <remarks/>
    public string Path { get; set; }

    /// <remarks/>
    [XmlElement("ActivatableClass")]
    public ExtensionsExtensionInProcessServerActivatableClass[] ActivatableClass { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class ExtensionsExtensionInProcessServerActivatableClass
{
    /// <remarks/>
    [XmlAttribute()]
    public string ActivatableClassId { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string ThreadingModel { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/appx/2010/manifest", IsNullable = false)]
public partial class Package
{
    [XmlElement("Identity")]
    public Identity Identity { get; set; }

    [XmlElement("Properties")]
    public Properties Properties { get; set; }

    [XmlElement("Prerequisites")]
    public Prerequisites Prerequisites { get; set; }

    [System.Xml.Serialization.XmlArrayItemAttribute("Application", typeof(Application), IsNullable = false)]
    public Application[] Applications { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class Identity
{
    /// <remarks/>
    [XmlAttribute()]
    public string Name { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string Version { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string Publisher { get; set; }

    /// <remarks/>
    [XmlAttribute()]
    public string ProcessorArchitecture { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class Properties
{
    /// <remarks/>
    public string DisplayName { get; set; }

    /// <remarks/>
    public string PublisherDisplayName { get; set; }

    /// <remarks/>
    public string Logo { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class Prerequisites
{
    public string OSMinVersion { get; set; }
    public string OSMaxVersionTested { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class PackageResourcesResource
{
    [XmlAttribute()]
    public string Language { get; set; }
}

//[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
//[System.SerializableAttribute()]
//[System.Diagnostics.DebuggerStepThroughAttribute()]
//[System.ComponentModel.DesignerCategoryAttribute("code")]
//[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
//public class Applications
//{
//    [XmlElement("Application")]
//    public Application Application { get; set; }
//}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public class Application
{
    [XmlElement("VisualElements")]
    public VisualElements VisualElements { get; set; }

    [XmlAttribute()]
    public string Id { get; set; }

    [XmlAttribute()]
    public string Executable { get; set; }

    [XmlAttribute()]
    public string EntryPoint { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class VisualElements
{
    [XmlElement("DefaultTile")]
    public DefaultTile DefaultTile { get; set; }

    [XmlElement("SplashScreen")]
    public SplashScreen[] SplashScreen { get; set; }

    [XmlAttribute()]
    public string DisplayName { get; set; }

    [XmlAttribute()]
    public string Logo { get; set; }

    [XmlAttribute()]
    public string SmallLogo { get; set; }

    [XmlAttribute()]
    public string Description { get; set; }

    [XmlAttribute()]
    public string ForegroundText { get; set; }

    [XmlAttribute()]
    public string BackgroundColor { get; set; }

    [XmlAttribute()]
    public string ToastCapable { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class DefaultTile
{
    [XmlAttribute()]
    public string ShowName { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class SplashScreen
{
    [XmlAttribute()]
    public string Image { get; set; }

    [XmlAttribute()]
    public string BackgroundColor { get; set; }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class PackageCapabilities
{

    private PackageCapabilitiesCapability[] capabilityField;

    private PackageCapabilitiesDeviceCapability[] deviceCapabilityField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Capability")]
    public PackageCapabilitiesCapability[] Capability
    {
        get
        {
            return this.capabilityField;
        }
        set
        {
            this.capabilityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DeviceCapability")]
    public PackageCapabilitiesDeviceCapability[] DeviceCapability
    {
        get
        {
            return this.deviceCapabilityField;
        }
        set
        {
            this.deviceCapabilityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class PackageCapabilitiesCapability
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class PackageCapabilitiesDeviceCapability
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
public partial class PackageDependenciesPackageDependency
{

    private string nameField;

    private string minVersionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string MinVersion
    {
        get
        {
            return this.minVersionField;
        }
        set
        {
            this.minVersionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/appx/2012/build")]
public partial class MetadataItem
{

    private string nameField;

    private string valueField;

    private string versionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Version
    {
        get
        {
            return this.versionField;
        }
        set
        {
            this.versionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/appx/2010/manifest")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/appx/2010/manifest", IsNullable = false)]
public partial class NewDataSet
{

    private object[] itemsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Extensions", typeof(Extensions))]
    [System.Xml.Serialization.XmlElementAttribute("Package", typeof(Package))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.17929")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://schemas.microsoft.com/developer/appx/2012/build")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://schemas.microsoft.com/developer/appx/2012/build", IsNullable = false)]
public partial class Metadata
{

    private MetadataItem[] itemField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Item")]
    public MetadataItem[] Item
    {
        get
        {
            return this.itemField;
        }
        set
        {
            this.itemField = value;
        }
    }
}
