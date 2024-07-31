namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader",@"StandardBusinessDocument")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"StandardBusinessDocument"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput1", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput4", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput4))]
    public sealed class PeppolInput : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns2=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader"" xmlns:ns3=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" xmlns:ns1=""urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.PCFPeppol.Schemas.PeppolInput1"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" />
  <xs:import schemaLocation=""Sp.PCFPeppol.Schemas.PeppolInput4"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2"" />
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""StandardBusinessDocument"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""StandardBusinessDocumentHeader"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""HeaderVersion"" type=""xs:decimal"" />
              <xs:element name=""Sender"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Identifier"">
                      <xs:complexType>
                        <xs:simpleContent>
                          <xs:extension base=""xs:string"">
                            <xs:attribute name=""Authority"" type=""xs:string"" use=""required"" />
                          </xs:extension>
                        </xs:simpleContent>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Receiver"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Identifier"">
                      <xs:complexType>
                        <xs:simpleContent>
                          <xs:extension base=""xs:string"">
                            <xs:attribute name=""Authority"" type=""xs:string"" use=""required"" />
                          </xs:extension>
                        </xs:simpleContent>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""DocumentIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Standard"" type=""xs:string"" />
                    <xs:element name=""TypeVersion"" type=""xs:decimal"" />
                    <xs:element name=""InstanceIdentifier"" type=""xs:string"" />
                    <xs:element name=""Type"" type=""xs:string"" />
                    <xs:element name=""CreationDateAndTime"" type=""xs:dateTime"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""BusinessScope"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Scope"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Type"" type=""xs:string"" />
                          <xs:element name=""InstanceIdentifier"" type=""xs:string"" />
                          <xs:element name=""Identifier"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element xmlns:q1=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" ref=""q1:Invoice"" />
        <xs:element ref=""ns1:CreditNote"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PeppolInput() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "StandardBusinessDocument";
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
