namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"UBLVersionID", @"CustomizationID", @"ProfileID", @"ID", @"UUID", @"IssueDate", @"DueDate", @"InvoiceTypeCode", @"Note", @"TaxPointDate", @"DocumentCurrencyCode", @"TaxCurrencyCode", @"AccountingCost", @"BuyerReference", @"StartDate", @"EndDate", @"DescriptionCode", @"SalesOrderID", @"DocumentTypeCode", @"DocumentDescription", @"URI", @"EmbeddedDocumentBinaryObject", @"EndpointID", @"Name", @"StreetName", @"AdditionalStreetName", @"CityName", @"PostalZone", @"CountrySubentity", 
@"Line", @"IdentificationCode", @"CompanyID", @"RegistrationName", @"CompanyLegalForm", @"Telephone", @"ElectronicMail", @"ActualDeliveryDate", @"PaymentMeansCode", @"PaymentID", @"PrimaryAccountNumberID", @"NetworkID", @"HolderName", @"ChargeIndicator", @"AllowanceChargeReasonCode", @"AllowanceChargeReason", @"MultiplierFactorNumeric", @"Amount", @"BaseAmount", @"Percent", @"TaxAmount", @"TaxableAmount", @"TaxExemptionReasonCode", @"TaxExemptionReason", @"LineExtensionAmount", 
@"TaxExclusiveAmount", @"TaxInclusiveAmount", @"AllowanceTotalAmount", @"ChargeTotalAmount", @"PrepaidAmount", @"PayableRoundingAmount", @"PayableAmount", @"InvoicedQuantity", @"LineID", @"Description", @"ItemClassificationCode", @"Value", @"PriceAmount", @"BaseQuantity", @"CreditNoteTypeCode", @"CreditedQuantity"})]
    public sealed class PeppolInput2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" attributeFormDefault=""qualified"" elementFormDefault=""qualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""UBLVersionID"" type=""xs:decimal"" />
  <xs:element name=""CustomizationID"" type=""xs:string"" />
  <xs:element name=""ProfileID"" type=""xs:string"" />
  <xs:element name=""ID"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""UUID"" type=""xs:string"" />
  <xs:element name=""IssueDate"" type=""xs:string"" />
  <xs:element name=""DueDate"" type=""xs:date"" />
  <xs:element name=""InvoiceTypeCode"" type=""xs:unsignedByte"" />
  <xs:element name=""Note"" type=""xs:string"" />
  <xs:element name=""TaxPointDate"" type=""xs:date"" />
  <xs:element name=""DocumentCurrencyCode"" type=""xs:string"" />
  <xs:element name=""TaxCurrencyCode"" type=""xs:string"" />
  <xs:element name=""AccountingCost"" type=""xs:string"" />
  <xs:element name=""BuyerReference"" type=""xs:string"" />
  <xs:element name=""StartDate"" type=""xs:date"" />
  <xs:element name=""EndDate"" type=""xs:date"" />
  <xs:element name=""DescriptionCode"" type=""xs:unsignedByte"" />
  <xs:element name=""SalesOrderID"" type=""xs:unsignedByte"" />
  <xs:element name=""DocumentTypeCode"" type=""xs:unsignedByte"" />
  <xs:element name=""DocumentDescription"" type=""xs:string"" />
  <xs:element name=""URI"" type=""xs:string"" />
  <xs:element name=""EmbeddedDocumentBinaryObject"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""filename"" type=""xs:string"" use=""required"" />
          <xs:attribute name=""mimeCode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""EndpointID"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeID"" type=""xs:unsignedByte"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Name"" type=""xs:string"" />
  <xs:element name=""StreetName"" type=""xs:string"" />
  <xs:element name=""AdditionalStreetName"" type=""xs:string"" />
  <xs:element name=""CityName"" type=""xs:string"" />
  <xs:element name=""PostalZone"" type=""xs:unsignedByte"" />
  <xs:element name=""CountrySubentity"" type=""xs:string"" />
  <xs:element name=""Line"" type=""xs:string"" />
  <xs:element name=""IdentificationCode"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""listID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CompanyID"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:string"">
          <xs:attribute name=""schemeID"" type=""xs:unsignedByte"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""RegistrationName"" type=""xs:string"" />
  <xs:element name=""CompanyLegalForm"" type=""xs:string"" />
  <xs:element name=""Telephone"" type=""xs:string"" />
  <xs:element name=""ElectronicMail"" type=""xs:string"" />
  <xs:element name=""ActualDeliveryDate"" type=""xs:date"" />
  <xs:element name=""PaymentMeansCode"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:unsignedByte"">
          <xs:attribute name=""name"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PaymentID"" type=""xs:string"" />
  <xs:element name=""PrimaryAccountNumberID"" type=""xs:unsignedByte"" />
  <xs:element name=""NetworkID"" type=""xs:string"" />
  <xs:element name=""HolderName"" type=""xs:string"" />
  <xs:element name=""ChargeIndicator"" type=""xs:boolean"" />
  <xs:element name=""AllowanceChargeReasonCode"" type=""xs:string"" />
  <xs:element name=""AllowanceChargeReason"" type=""xs:string"" />
  <xs:element name=""MultiplierFactorNumeric"" type=""xs:unsignedByte"" />
  <xs:element name=""Amount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BaseAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Percent"" type=""xs:decimal"" />
  <xs:element name=""TaxAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxableAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxExemptionReasonCode"" type=""xs:unsignedByte"" />
  <xs:element name=""TaxExemptionReason"" type=""xs:string"" />
  <xs:element name=""LineExtensionAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxExclusiveAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxInclusiveAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AllowanceTotalAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ChargeTotalAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PrepaidAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PayableRoundingAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PayableAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoicedQuantity"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""unitCode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LineID"" type=""xs:unsignedByte"" />
  <xs:element name=""Description"" type=""xs:string"" />
  <xs:element name=""ItemClassificationCode"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:unsignedByte"">
          <xs:attribute name=""listID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Value"" type=""xs:string"" />
  <xs:element name=""PriceAmount"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""currencyID"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BaseQuantity"" type=""xs:unsignedByte"" />
  <xs:element name=""CreditNoteTypeCode"" type=""xs:unsignedByte"" />
  <xs:element name=""CreditedQuantity"">
    <xs:complexType>
      <xs:simpleContent>
        <xs:extension base=""xs:decimal"">
          <xs:attribute name=""unitcode"" type=""xs:string"" use=""required"" />
        </xs:extension>
      </xs:simpleContent>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PeppolInput2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [70];
                _RootElements[0] = "UBLVersionID";
                _RootElements[1] = "CustomizationID";
                _RootElements[2] = "ProfileID";
                _RootElements[3] = "ID";
                _RootElements[4] = "UUID";
                _RootElements[5] = "IssueDate";
                _RootElements[6] = "DueDate";
                _RootElements[7] = "InvoiceTypeCode";
                _RootElements[8] = "Note";
                _RootElements[9] = "TaxPointDate";
                _RootElements[10] = "DocumentCurrencyCode";
                _RootElements[11] = "TaxCurrencyCode";
                _RootElements[12] = "AccountingCost";
                _RootElements[13] = "BuyerReference";
                _RootElements[14] = "StartDate";
                _RootElements[15] = "EndDate";
                _RootElements[16] = "DescriptionCode";
                _RootElements[17] = "SalesOrderID";
                _RootElements[18] = "DocumentTypeCode";
                _RootElements[19] = "DocumentDescription";
                _RootElements[20] = "URI";
                _RootElements[21] = "EmbeddedDocumentBinaryObject";
                _RootElements[22] = "EndpointID";
                _RootElements[23] = "Name";
                _RootElements[24] = "StreetName";
                _RootElements[25] = "AdditionalStreetName";
                _RootElements[26] = "CityName";
                _RootElements[27] = "PostalZone";
                _RootElements[28] = "CountrySubentity";
                _RootElements[29] = "Line";
                _RootElements[30] = "IdentificationCode";
                _RootElements[31] = "CompanyID";
                _RootElements[32] = "RegistrationName";
                _RootElements[33] = "CompanyLegalForm";
                _RootElements[34] = "Telephone";
                _RootElements[35] = "ElectronicMail";
                _RootElements[36] = "ActualDeliveryDate";
                _RootElements[37] = "PaymentMeansCode";
                _RootElements[38] = "PaymentID";
                _RootElements[39] = "PrimaryAccountNumberID";
                _RootElements[40] = "NetworkID";
                _RootElements[41] = "HolderName";
                _RootElements[42] = "ChargeIndicator";
                _RootElements[43] = "AllowanceChargeReasonCode";
                _RootElements[44] = "AllowanceChargeReason";
                _RootElements[45] = "MultiplierFactorNumeric";
                _RootElements[46] = "Amount";
                _RootElements[47] = "BaseAmount";
                _RootElements[48] = "Percent";
                _RootElements[49] = "TaxAmount";
                _RootElements[50] = "TaxableAmount";
                _RootElements[51] = "TaxExemptionReasonCode";
                _RootElements[52] = "TaxExemptionReason";
                _RootElements[53] = "LineExtensionAmount";
                _RootElements[54] = "TaxExclusiveAmount";
                _RootElements[55] = "TaxInclusiveAmount";
                _RootElements[56] = "AllowanceTotalAmount";
                _RootElements[57] = "ChargeTotalAmount";
                _RootElements[58] = "PrepaidAmount";
                _RootElements[59] = "PayableRoundingAmount";
                _RootElements[60] = "PayableAmount";
                _RootElements[61] = "InvoicedQuantity";
                _RootElements[62] = "LineID";
                _RootElements[63] = "Description";
                _RootElements[64] = "ItemClassificationCode";
                _RootElements[65] = "Value";
                _RootElements[66] = "PriceAmount";
                _RootElements[67] = "BaseQuantity";
                _RootElements[68] = "CreditNoteTypeCode";
                _RootElements[69] = "CreditedQuantity";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"UBLVersionID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UBLVersionID"})]
        public sealed class UBLVersionID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UBLVersionID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UBLVersionID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CustomizationID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CustomizationID"})]
        public sealed class CustomizationID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CustomizationID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CustomizationID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ProfileID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProfileID"})]
        public sealed class ProfileID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProfileID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProfileID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ID"})]
        public sealed class ID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"UUID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"UUID"})]
        public sealed class UUID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public UUID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "UUID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"IssueDate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IssueDate"})]
        public sealed class IssueDate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IssueDate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IssueDate";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"DueDate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DueDate"})]
        public sealed class DueDate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DueDate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DueDate";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"InvoiceTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoiceTypeCode"})]
        public sealed class InvoiceTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InvoiceTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InvoiceTypeCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Note")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Note"})]
        public sealed class Note : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Note() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Note";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxPointDate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxPointDate"})]
        public sealed class TaxPointDate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxPointDate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxPointDate";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"DocumentCurrencyCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentCurrencyCode"})]
        public sealed class DocumentCurrencyCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentCurrencyCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentCurrencyCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxCurrencyCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxCurrencyCode"})]
        public sealed class TaxCurrencyCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxCurrencyCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxCurrencyCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"AccountingCost")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountingCost"})]
        public sealed class AccountingCost : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountingCost() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountingCost";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"BuyerReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BuyerReference"})]
        public sealed class BuyerReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BuyerReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BuyerReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"StartDate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StartDate"})]
        public sealed class StartDate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StartDate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StartDate";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"EndDate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EndDate"})]
        public sealed class EndDate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EndDate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EndDate";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"DescriptionCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DescriptionCode"})]
        public sealed class DescriptionCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DescriptionCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DescriptionCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"SalesOrderID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SalesOrderID"})]
        public sealed class SalesOrderID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SalesOrderID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SalesOrderID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"DocumentTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentTypeCode"})]
        public sealed class DocumentTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentTypeCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"DocumentDescription")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DocumentDescription"})]
        public sealed class DocumentDescription : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DocumentDescription() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DocumentDescription";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"URI")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"URI"})]
        public sealed class URI : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public URI() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "URI";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"EmbeddedDocumentBinaryObject")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EmbeddedDocumentBinaryObject"})]
        public sealed class EmbeddedDocumentBinaryObject : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EmbeddedDocumentBinaryObject() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EmbeddedDocumentBinaryObject";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"EndpointID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"EndpointID"})]
        public sealed class EndpointID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public EndpointID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "EndpointID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Name")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Name"})]
        public sealed class Name : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Name() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Name";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"StreetName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"StreetName"})]
        public sealed class StreetName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public StreetName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "StreetName";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"AdditionalStreetName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AdditionalStreetName"})]
        public sealed class AdditionalStreetName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AdditionalStreetName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AdditionalStreetName";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CityName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CityName"})]
        public sealed class CityName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CityName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CityName";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PostalZone")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PostalZone"})]
        public sealed class PostalZone : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PostalZone() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PostalZone";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CountrySubentity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CountrySubentity"})]
        public sealed class CountrySubentity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CountrySubentity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CountrySubentity";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Line")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Line"})]
        public sealed class Line : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Line() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Line";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"IdentificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"IdentificationCode"})]
        public sealed class IdentificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public IdentificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "IdentificationCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CompanyID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CompanyID"})]
        public sealed class CompanyID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CompanyID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CompanyID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"RegistrationName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RegistrationName"})]
        public sealed class RegistrationName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RegistrationName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RegistrationName";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CompanyLegalForm")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CompanyLegalForm"})]
        public sealed class CompanyLegalForm : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CompanyLegalForm() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CompanyLegalForm";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Telephone")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Telephone"})]
        public sealed class Telephone : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Telephone() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Telephone";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ElectronicMail")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ElectronicMail"})]
        public sealed class ElectronicMail : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ElectronicMail() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ElectronicMail";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ActualDeliveryDate")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ActualDeliveryDate"})]
        public sealed class ActualDeliveryDate : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ActualDeliveryDate() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ActualDeliveryDate";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PaymentMeansCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PaymentMeansCode"})]
        public sealed class PaymentMeansCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PaymentMeansCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PaymentMeansCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PaymentID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PaymentID"})]
        public sealed class PaymentID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PaymentID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PaymentID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PrimaryAccountNumberID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PrimaryAccountNumberID"})]
        public sealed class PrimaryAccountNumberID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PrimaryAccountNumberID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PrimaryAccountNumberID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"NetworkID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"NetworkID"})]
        public sealed class NetworkID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public NetworkID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "NetworkID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"HolderName")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"HolderName"})]
        public sealed class HolderName : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public HolderName() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "HolderName";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ChargeIndicator")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ChargeIndicator"})]
        public sealed class ChargeIndicator : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ChargeIndicator() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ChargeIndicator";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"AllowanceChargeReasonCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AllowanceChargeReasonCode"})]
        public sealed class AllowanceChargeReasonCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AllowanceChargeReasonCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AllowanceChargeReasonCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"AllowanceChargeReason")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AllowanceChargeReason"})]
        public sealed class AllowanceChargeReason : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AllowanceChargeReason() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AllowanceChargeReason";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"MultiplierFactorNumeric")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"MultiplierFactorNumeric"})]
        public sealed class MultiplierFactorNumeric : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public MultiplierFactorNumeric() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "MultiplierFactorNumeric";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Amount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Amount"})]
        public sealed class Amount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Amount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Amount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"BaseAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BaseAmount"})]
        public sealed class BaseAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BaseAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BaseAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Percent")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Percent"})]
        public sealed class Percent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Percent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Percent";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxAmount"})]
        public sealed class TaxAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxableAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxableAmount"})]
        public sealed class TaxableAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxableAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxableAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxExemptionReasonCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxExemptionReasonCode"})]
        public sealed class TaxExemptionReasonCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxExemptionReasonCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxExemptionReasonCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxExemptionReason")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxExemptionReason"})]
        public sealed class TaxExemptionReason : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxExemptionReason() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxExemptionReason";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"LineExtensionAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LineExtensionAmount"})]
        public sealed class LineExtensionAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LineExtensionAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LineExtensionAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxExclusiveAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxExclusiveAmount"})]
        public sealed class TaxExclusiveAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxExclusiveAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxExclusiveAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"TaxInclusiveAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxInclusiveAmount"})]
        public sealed class TaxInclusiveAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxInclusiveAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxInclusiveAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"AllowanceTotalAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AllowanceTotalAmount"})]
        public sealed class AllowanceTotalAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AllowanceTotalAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AllowanceTotalAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ChargeTotalAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ChargeTotalAmount"})]
        public sealed class ChargeTotalAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ChargeTotalAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ChargeTotalAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PrepaidAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PrepaidAmount"})]
        public sealed class PrepaidAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PrepaidAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PrepaidAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PayableRoundingAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PayableRoundingAmount"})]
        public sealed class PayableRoundingAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PayableRoundingAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PayableRoundingAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PayableAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PayableAmount"})]
        public sealed class PayableAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PayableAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PayableAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"InvoicedQuantity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoicedQuantity"})]
        public sealed class InvoicedQuantity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InvoicedQuantity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InvoicedQuantity";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"LineID")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LineID"})]
        public sealed class LineID : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LineID() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LineID";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Description")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Description"})]
        public sealed class Description : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Description() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Description";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"ItemClassificationCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ItemClassificationCode"})]
        public sealed class ItemClassificationCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ItemClassificationCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ItemClassificationCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"Value")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Value"})]
        public sealed class Value : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Value() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Value";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"PriceAmount")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PriceAmount"})]
        public sealed class PriceAmount : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PriceAmount() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PriceAmount";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"BaseQuantity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BaseQuantity"})]
        public sealed class BaseQuantity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BaseQuantity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BaseQuantity";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CreditNoteTypeCode")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreditNoteTypeCode"})]
        public sealed class CreditNoteTypeCode : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreditNoteTypeCode() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreditNoteTypeCode";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2",@"CreditedQuantity")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreditedQuantity"})]
        public sealed class CreditedQuantity : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreditedQuantity() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreditedQuantity";
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
