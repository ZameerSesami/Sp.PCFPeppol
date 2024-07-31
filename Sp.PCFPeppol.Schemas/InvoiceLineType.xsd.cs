namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Sp.PCFPeppol.Schemas.InvoiceLineType",@"INVOICELINETYPE")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"INVOICELINETYPE"})]
    public sealed class InvoiceLineType : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Sp.PCFPeppol.Schemas.InvoiceLineType"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Sp.PCFPeppol.Schemas.InvoiceLineType"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""INVOICELINETYPE"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""InstanceIdentifier"" type=""xs:string"" />
        <xs:element name=""ID"" type=""xs:string"" />
        <xs:element name=""InvoicedQuantity"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InvoiceLineType() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "INVOICELINETYPE";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
