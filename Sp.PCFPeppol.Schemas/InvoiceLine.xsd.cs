namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Sp.PCFPeppol.Schemas.InvoiceLine",@"InvoiceLine")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InvoiceLine"})]
    public sealed class InvoiceLine : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Sp.PCFPeppol.Schemas.InvoiceLine"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Sp.PCFPeppol.Schemas.InvoiceLine"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""InvoiceLine"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""ID"" type=""xs:string"" />
        <xs:element name=""Note"" type=""xs:string"" />
        <xs:element name=""InvoicedQuantity"" type=""xs:string"" />
        <xs:element name=""LineExtensionAmount"" type=""xs:string"" />
        <xs:element name=""OrderLineReference"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""LineID"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DocumentReference"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ID"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""AllowanceCharge"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ChargeIndicator"" type=""xs:string"" />
              <xs:element name=""AllowanceChargeReasonCode"" type=""xs:string"" />
              <xs:element name=""AllowanceChargeReason"" type=""xs:string"" />
              <xs:element name=""MultiplierFactorNumeric"" type=""xs:string"" />
              <xs:element name=""Amount"" type=""xs:string"" />
              <xs:element name=""BaseAmount"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Item"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Description"" type=""xs:string"" />
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""BuyersItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""SellersItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""StandardItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""OriginCountry"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""IdentificationCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""CommodityClassification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ItemClassificationCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ClassifiedTaxCategory"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                    <xs:element name=""Percent"" type=""xs:string"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ID"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""AdditionalItemProperty"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""Value"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Price"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PriceAmount"" type=""xs:string"" />
              <xs:element name=""BaseQuantity"" type=""xs:string"" />
              <xs:element name=""AllowanceCharge"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ChargeIndicator"" type=""xs:string"" />
                    <xs:element name=""Amount"" type=""xs:string"" />
                    <xs:element name=""BaseAmount"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public InvoiceLine() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "InvoiceLine";
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
