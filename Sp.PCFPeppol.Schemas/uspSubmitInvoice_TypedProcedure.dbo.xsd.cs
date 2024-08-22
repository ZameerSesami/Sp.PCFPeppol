namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InterfacePCFPeppolInvoiceSubmit", @"InterfacePCFPeppolInvoiceSubmitResponse"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.uspSubmitInvoice_ProcedureResultSet_dbo_InterfacePCFPeppolInvoiceSubmit", typeof(global::Sp.PCFPeppol.Schemas.uspSubmitInvoice_ProcedureResultSet_dbo_InterfacePCFPeppolInvoiceSubmit))]
    public sealed class uspSubmitInvoice_TypedProcedure_dbo : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePCFPeppolInvoiceSubmit"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" version=""1.0"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.PCFPeppol.Schemas.uspSubmitInvoice_ProcedureResultSet_dbo_InterfacePCFPeppolInvoiceSubmit"" namespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePCFPeppolInvoiceSubmit"" />
  <xs:annotation>
    <xs:appinfo>
      <fileNameHint xmlns=""http://schemas.microsoft.com/servicemodel/adapters/metadata/xsd"">TypedProcedure.dbo</fileNameHint>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePCFPeppolInvoiceSubmit"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""InterfacePCFPeppolInvoiceSubmit"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/InterfacePCFPeppolInvoiceSubmit</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ID"" nillable=""true"">
          <xs:simpleType>
            <xs:restriction base=""xs:string"">
              <xs:maxLength value=""100"" />
            </xs:restriction>
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InterfacePCFPeppolInvoiceSubmitResponse"">
    <xs:annotation>
      <xs:documentation>
        <doc:action xmlns:doc=""http://schemas.microsoft.com/servicemodel/adapters/metadata/documentation"">TypedProcedure/dbo/InterfacePCFPeppolInvoiceSubmit/response</doc:action>
      </xs:documentation>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""1"" name=""StoredProcedureResultSet0"" nillable=""true"" type=""ns3:ArrayOfStoredProcedureResultSet0"" />
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ReturnValue"" type=""xs:int"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public uspSubmitInvoice_TypedProcedure_dbo() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [2];
                _RootElements[0] = "InterfacePCFPeppolInvoiceSubmit";
                _RootElements[1] = "InterfacePCFPeppolInvoiceSubmitResponse";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"InterfacePCFPeppolInvoiceSubmit")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InterfacePCFPeppolInvoiceSubmit"})]
        public sealed class InterfacePCFPeppolInvoiceSubmit : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InterfacePCFPeppolInvoiceSubmit() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InterfacePCFPeppolInvoiceSubmit";
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
        
        [Schema(@"http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo",@"InterfacePCFPeppolInvoiceSubmitResponse")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InterfacePCFPeppolInvoiceSubmitResponse"})]
        public sealed class InterfacePCFPeppolInvoiceSubmitResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InterfacePCFPeppolInvoiceSubmitResponse() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InterfacePCFPeppolInvoiceSubmitResponse";
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
}
