namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:Invoice-2",@"Invoice")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Invoice"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput2", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput2))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput3", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput3))]
    public sealed class PeppolInput1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.PCFPeppol.Schemas.PeppolInput2"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
  <xs:import schemaLocation=""Sp.PCFPeppol.Schemas.PeppolInput3"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Invoice"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q1:UBLVersionID"" />
        <xs:element xmlns:q2=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q2:CustomizationID"" />
        <xs:element xmlns:q3=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q3:ProfileID"" />
        <xs:element xmlns:q4=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q4:ID"" />
        <xs:element xmlns:q4=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q4:UUID"" />
        <xs:element xmlns:q5=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q5:IssueDate"" />
        <xs:element xmlns:q6=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q6:DueDate"" />
        <xs:element xmlns:q7=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q7:InvoiceTypeCode"" />
        <xs:element xmlns:q8=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q8:Note"" />
        <xs:element xmlns:q9=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q9:TaxPointDate"" />
        <xs:element xmlns:q10=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q10:DocumentCurrencyCode"" />
        <xs:element xmlns:q11=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q11:TaxCurrencyCode"" />
        <xs:element xmlns:q12=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q12:AccountingCost"" />
        <xs:element xmlns:q13=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q13:BuyerReference"" />
        <xs:element xmlns:q14=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q14:InvoicePeriod"" />
        <xs:element xmlns:q15=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q15:OrderReference"" />
        <xs:element xmlns:q16=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q16:BillingReference"" />
        <xs:element xmlns:q17=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q17:DespatchDocumentReference"" />
        <xs:element xmlns:q18=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q18:ReceiptDocumentReference"" />
        <xs:element xmlns:q19=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q19:OriginatorDocumentReference"" />
        <xs:element xmlns:q20=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q20:ContractDocumentReference"" />
        <xs:element xmlns:q21=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q21:AdditionalDocumentReference"" />
        <xs:element xmlns:q22=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q22:ProjectReference"" />
        <xs:element xmlns:q23=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q23:AccountingSupplierParty"" />
        <xs:element xmlns:q24=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q24:AccountingCustomerParty"" />
        <xs:element xmlns:q25=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q25:PayeeParty"" />
        <xs:element xmlns:q26=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q26:TaxRepresentativeParty"" />
        <xs:element xmlns:q27=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q27:Delivery"" />
        <xs:element xmlns:q28=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q28:PaymentMeans"" />
        <xs:element xmlns:q29=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q29:PaymentTerms"" />
        <xs:element xmlns:q30=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q30:AllowanceCharge"" />
        <xs:element xmlns:q31=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q31:TaxTotal"" />
        <xs:element xmlns:q32=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q32:LegalMonetaryTotal"" />
        <xs:element xmlns:q33=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" ref=""q33:InvoiceLine"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PeppolInput1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Invoice";
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
