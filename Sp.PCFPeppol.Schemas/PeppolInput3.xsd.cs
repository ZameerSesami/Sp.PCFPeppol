namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"InvoicePeriod", @"OrderReference", @"BillingReference", @"DespatchDocumentReference", @"ReceiptDocumentReference", @"OriginatorDocumentReference", @"ContractDocumentReference", @"AdditionalDocumentReference", @"ProjectReference", @"AccountingSupplierParty", @"AccountingCustomerParty", @"PayeeParty", @"TaxRepresentativeParty", @"Delivery", @"PaymentMeans", @"PaymentTerms", @"AllowanceCharge", @"TaxTotal", @"LegalMonetaryTotal", @"InvoiceLine", @"CreditNoteLine"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput2", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput2))]
    public sealed class PeppolInput3 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" attributeFormDefault=""unqualified"" elementFormDefault=""unqualified"" targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Sp.PCFPeppol.Schemas.PeppolInput2"" namespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
  <xs:annotation>
    <xs:appinfo>
      <b:references>
        <b:reference targetNamespace=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" />
      </b:references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""InvoicePeriod"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q1=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q1:StartDate"" />
        <xs:element xmlns:q2=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q2:EndDate"" />
        <xs:element xmlns:q3=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q3:DescriptionCode"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OrderReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q4=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q4:ID"" />
        <xs:element xmlns:q5=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q5:SalesOrderID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BillingReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""InvoiceDocumentReference"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q6=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q6:ID"" />
              <xs:element xmlns:q7=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q7:IssueDate"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""DespatchDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q8=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q8:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ReceiptDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q9=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q9:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""OriginatorDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q10=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q10:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ContractDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q11=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q11:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AdditionalDocumentReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q12=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q12:ID"" />
        <xs:element xmlns:q13=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q13:DocumentTypeCode"" />
        <xs:element xmlns:q14=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q14:DocumentDescription"" />
        <xs:element name=""Attachment"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ExternalReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q15=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q15:URI"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element xmlns:q16=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q16:EmbeddedDocumentBinaryObject"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""ProjectReference"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q17=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q17:ID"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountingSupplierParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q18=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q18:EndpointID"" />
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q19=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q19:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q20=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q20:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q21=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q21:StreetName"" />
                    <xs:element xmlns:q22=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q22:AdditionalStreetName"" />
                    <xs:element xmlns:q23=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q23:CityName"" />
                    <xs:element xmlns:q24=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q24:PostalZone"" />
                    <xs:element xmlns:q25=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q25:CountrySubentity"" />
                    <xs:element name=""AddressLine"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q26=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q26:Line"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q27=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q27:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyTaxScheme"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q28=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q28:CompanyID"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q29=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q29:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyLegalEntity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q30=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q30:RegistrationName"" />
                    <xs:element xmlns:q31=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q31:CompanyID"" />
                    <xs:element xmlns:q32=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q32:CompanyLegalForm"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q33=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q33:Name"" />
                    <xs:element xmlns:q34=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q34:Telephone"" />
                    <xs:element xmlns:q35=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q35:ElectronicMail"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AccountingCustomerParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Party"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q36=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q36:EndpointID"" />
              <xs:element name=""PartyIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q37=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q37:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q38=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q38:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PostalAddress"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q39=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q39:StreetName"" />
                    <xs:element xmlns:q40=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q40:AdditionalStreetName"" />
                    <xs:element xmlns:q41=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q41:CityName"" />
                    <xs:element xmlns:q42=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q42:PostalZone"" />
                    <xs:element xmlns:q43=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q43:CountrySubentity"" />
                    <xs:element name=""AddressLine"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q44=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q44:Line"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q45=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q45:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyTaxScheme"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q46=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q46:CompanyID"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q47=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q47:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""PartyLegalEntity"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q48=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q48:RegistrationName"" />
                    <xs:element xmlns:q49=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q49:CompanyID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Contact"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q50=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q50:Name"" />
                    <xs:element xmlns:q51=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q51:Telephone"" />
                    <xs:element xmlns:q52=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q52:ElectronicMail"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PayeeParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PartyIdentification"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q53=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q53:ID"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""PartyName"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q54=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q54:Name"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""PartyLegalEntity"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q55=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q55:CompanyID"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxRepresentativeParty"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""PartyName"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q56=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q56:Name"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""PostalAddress"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q57=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q57:StreetName"" />
              <xs:element xmlns:q58=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q58:AdditionalStreetName"" />
              <xs:element xmlns:q59=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q59:CityName"" />
              <xs:element xmlns:q60=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q60:PostalZone"" />
              <xs:element xmlns:q61=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q61:CountrySubentity"" />
              <xs:element name=""AddressLine"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q62=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q62:Line"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Country"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q63=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q63:IdentificationCode"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""PartyTaxScheme"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q64=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q64:CompanyID"" />
              <xs:element name=""TaxScheme"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q65=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q65:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""Delivery"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q66=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q66:ActualDeliveryDate"" />
        <xs:element name=""DeliveryLocation"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q67=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q67:ID"" />
              <xs:element name=""Address"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q68=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q68:StreetName"" />
                    <xs:element xmlns:q69=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q69:AdditionalStreetName"" />
                    <xs:element xmlns:q70=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q70:CityName"" />
                    <xs:element xmlns:q71=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q71:PostalZone"" />
                    <xs:element xmlns:q72=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q72:CountrySubentity"" />
                    <xs:element name=""AddressLine"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q73=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q73:Line"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""Country"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q74=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q74:IdentificationCode"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DeliveryParty"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""PartyName"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q75=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q75:Name"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PaymentMeans"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q76=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q76:PaymentMeansCode"" />
        <xs:element xmlns:q77=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q77:PaymentID"" />
        <xs:element name=""CardAccount"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q78=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q78:PrimaryAccountNumberID"" />
              <xs:element xmlns:q79=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q79:NetworkID"" />
              <xs:element xmlns:q80=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q80:HolderName"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""PayeeFinancialAccount"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q81=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q81:ID"" />
              <xs:element xmlns:q82=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q82:Name"" />
              <xs:element name=""FinancialInstitutionBranch"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q83=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q83:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""PaymentMandate"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q84=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q84:ID"" />
              <xs:element name=""PayerFinancialAccount"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q85=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q85:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""PaymentTerms"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q86=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q86:Note"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""AllowanceCharge"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q87=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q87:ChargeIndicator"" />
        <xs:element xmlns:q88=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q88:AllowanceChargeReasonCode"" />
        <xs:element xmlns:q89=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q89:AllowanceChargeReason"" />
        <xs:element xmlns:q90=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q90:MultiplierFactorNumeric"" />
        <xs:element xmlns:q91=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q91:Amount"" />
        <xs:element xmlns:q92=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q92:BaseAmount"" />
        <xs:element name=""TaxCategory"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q93=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q93:ID"" />
              <xs:element xmlns:q94=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q94:Percent"" />
              <xs:element name=""TaxScheme"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q95=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q95:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""TaxTotal"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q96=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q96:TaxAmount"" />
        <xs:element name=""TaxSubtotal"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q97=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q97:TaxableAmount"" />
              <xs:element xmlns:q98=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q98:TaxAmount"" />
              <xs:element name=""TaxCategory"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q99=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q99:ID"" />
                    <xs:element xmlns:q100=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q100:Percent"" />
                    <xs:element xmlns:q101=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q101:TaxExemptionReasonCode"" />
                    <xs:element xmlns:q102=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q102:TaxExemptionReason"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q103=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q103:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""LegalMonetaryTotal"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q104=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q104:LineExtensionAmount"" />
        <xs:element xmlns:q105=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q105:TaxExclusiveAmount"" />
        <xs:element xmlns:q106=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q106:TaxInclusiveAmount"" />
        <xs:element xmlns:q107=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q107:AllowanceTotalAmount"" />
        <xs:element xmlns:q108=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q108:ChargeTotalAmount"" />
        <xs:element xmlns:q109=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q109:PrepaidAmount"" />
        <xs:element xmlns:q110=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q110:PayableRoundingAmount"" />
        <xs:element xmlns:q111=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q111:PayableAmount"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""InvoiceLine"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q112=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q112:ID"" />
        <xs:element xmlns:q113=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q113:Note"" />
        <xs:element xmlns:q114=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q114:InvoicedQuantity"" />
        <xs:element xmlns:q115=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q115:LineExtensionAmount"" />
        <xs:element xmlns:q116=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q116:AccountingCost"" />
        <xs:element name=""InvoicePeriod"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q117=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q117:StartDate"" />
              <xs:element xmlns:q118=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q118:EndDate"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OrderLineReference"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q119=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q119:LineID"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DocumentReference"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q120=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q120:ID"" />
              <xs:element xmlns:q121=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q121:DocumentTypeCode"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""AllowanceCharge"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q122=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q122:ChargeIndicator"" />
              <xs:element xmlns:q123=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q123:AllowanceChargeReasonCode"" />
              <xs:element xmlns:q124=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q124:AllowanceChargeReason"" />
              <xs:element xmlns:q125=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q125:MultiplierFactorNumeric"" />
              <xs:element xmlns:q126=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q126:Amount"" />
              <xs:element xmlns:q127=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q127:BaseAmount"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Item"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q128=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q128:Description"" />
              <xs:element xmlns:q129=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q129:Name"" />
              <xs:element name=""BuyersItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q130=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q130:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""SellersItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q131=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q131:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""StandardItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q132=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q132:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""OriginCountry"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q133=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q133:IdentificationCode"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""CommodityClassification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q134=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q134:ItemClassificationCode"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ClassifiedTaxCategory"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q135=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q135:ID"" />
                    <xs:element xmlns:q136=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q136:Percent"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q137=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q137:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""AdditionalItemProperty"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q138=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q138:Name"" />
                    <xs:element xmlns:q139=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q139:Value"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Price"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q140=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q140:PriceAmount"" />
              <xs:element xmlns:q141=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q141:BaseQuantity"" />
              <xs:element name=""AllowanceCharge"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q142=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q142:ChargeIndicator"" />
                    <xs:element xmlns:q143=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q143:Amount"" />
                    <xs:element xmlns:q144=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q144:BaseAmount"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:element name=""CreditNoteLine"">
    <xs:complexType>
      <xs:sequence>
        <xs:element xmlns:q145=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q145:ID"" />
        <xs:element xmlns:q146=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q146:Note"" />
        <xs:element xmlns:q147=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q147:CreditedQuantity"" />
        <xs:element xmlns:q148=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q148:LineExtensionAmount"" />
        <xs:element xmlns:q149=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q149:AccountingCost"" />
        <xs:element name=""InvoicePeriod"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q150=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q150:StartDate"" />
              <xs:element xmlns:q151=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q151:EndDate"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""OrderLineReference"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q152=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q152:LineID"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DocumentReference"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q153=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q153:ID"" />
              <xs:element xmlns:q154=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q154:DocumentTypeCode"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""AllowanceCharge"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q155=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q155:ChargeIndicator"" />
              <xs:element xmlns:q156=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q156:AllowanceChargeReasonCode"" />
              <xs:element xmlns:q157=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q157:AllowanceChargeReason"" />
              <xs:element xmlns:q158=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q158:MultiplierFactorNumeric"" />
              <xs:element xmlns:q159=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q159:Amount"" />
              <xs:element xmlns:q160=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q160:BaseAmount"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Item"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q161=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q161:Description"" />
              <xs:element xmlns:q162=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q162:Name"" />
              <xs:element name=""BuyersItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q163=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q163:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""SellersItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q164=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q164:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""StandardItemIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q165=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q165:ID"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""OriginCountry"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q166=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q166:IdentificationCode"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""CommodityClassification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q167=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q167:ItemClassificationCode"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ClassifiedTaxCategory"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q168=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q168:ID"" />
                    <xs:element xmlns:q169=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q169:Percent"" />
                    <xs:element name=""TaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element xmlns:q170=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q170:ID"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""AdditionalItemProperty"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q171=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q171:Name"" />
                    <xs:element xmlns:q172=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q172:Value"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Price"">
          <xs:complexType>
            <xs:sequence>
              <xs:element xmlns:q173=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q173:PriceAmount"" />
              <xs:element xmlns:q174=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q174:BaseQuantity"" />
              <xs:element name=""AllowanceCharge"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element xmlns:q175=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q175:ChargeIndicator"" />
                    <xs:element xmlns:q176=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q176:Amount"" />
                    <xs:element xmlns:q177=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" ref=""q177:BaseAmount"" />
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
        
        public PeppolInput3() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [21];
                _RootElements[0] = "InvoicePeriod";
                _RootElements[1] = "OrderReference";
                _RootElements[2] = "BillingReference";
                _RootElements[3] = "DespatchDocumentReference";
                _RootElements[4] = "ReceiptDocumentReference";
                _RootElements[5] = "OriginatorDocumentReference";
                _RootElements[6] = "ContractDocumentReference";
                _RootElements[7] = "AdditionalDocumentReference";
                _RootElements[8] = "ProjectReference";
                _RootElements[9] = "AccountingSupplierParty";
                _RootElements[10] = "AccountingCustomerParty";
                _RootElements[11] = "PayeeParty";
                _RootElements[12] = "TaxRepresentativeParty";
                _RootElements[13] = "Delivery";
                _RootElements[14] = "PaymentMeans";
                _RootElements[15] = "PaymentTerms";
                _RootElements[16] = "AllowanceCharge";
                _RootElements[17] = "TaxTotal";
                _RootElements[18] = "LegalMonetaryTotal";
                _RootElements[19] = "InvoiceLine";
                _RootElements[20] = "CreditNoteLine";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"InvoicePeriod")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoicePeriod"})]
        public sealed class InvoicePeriod : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InvoicePeriod() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InvoicePeriod";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"OrderReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OrderReference"})]
        public sealed class OrderReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OrderReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OrderReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"BillingReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BillingReference"})]
        public sealed class BillingReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BillingReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BillingReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"DespatchDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DespatchDocumentReference"})]
        public sealed class DespatchDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DespatchDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DespatchDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"ReceiptDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ReceiptDocumentReference"})]
        public sealed class ReceiptDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ReceiptDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ReceiptDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"OriginatorDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"OriginatorDocumentReference"})]
        public sealed class OriginatorDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public OriginatorDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "OriginatorDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"ContractDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ContractDocumentReference"})]
        public sealed class ContractDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ContractDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ContractDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AdditionalDocumentReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AdditionalDocumentReference"})]
        public sealed class AdditionalDocumentReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AdditionalDocumentReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AdditionalDocumentReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"ProjectReference")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"ProjectReference"})]
        public sealed class ProjectReference : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public ProjectReference() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "ProjectReference";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AccountingSupplierParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountingSupplierParty"})]
        public sealed class AccountingSupplierParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountingSupplierParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountingSupplierParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AccountingCustomerParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountingCustomerParty"})]
        public sealed class AccountingCustomerParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountingCustomerParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountingCustomerParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"PayeeParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PayeeParty"})]
        public sealed class PayeeParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PayeeParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PayeeParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"TaxRepresentativeParty")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxRepresentativeParty"})]
        public sealed class TaxRepresentativeParty : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxRepresentativeParty() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxRepresentativeParty";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"Delivery")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"Delivery"})]
        public sealed class Delivery : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public Delivery() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "Delivery";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"PaymentMeans")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PaymentMeans"})]
        public sealed class PaymentMeans : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PaymentMeans() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PaymentMeans";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"PaymentTerms")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PaymentTerms"})]
        public sealed class PaymentTerms : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PaymentTerms() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PaymentTerms";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"AllowanceCharge")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AllowanceCharge"})]
        public sealed class AllowanceCharge : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AllowanceCharge() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AllowanceCharge";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"TaxTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"TaxTotal"})]
        public sealed class TaxTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public TaxTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "TaxTotal";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"LegalMonetaryTotal")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"LegalMonetaryTotal"})]
        public sealed class LegalMonetaryTotal : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public LegalMonetaryTotal() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "LegalMonetaryTotal";
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"InvoiceLine")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InvoiceLine"})]
        public sealed class InvoiceLine : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
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
        
        [Schema(@"urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2",@"CreditNoteLine")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CreditNoteLine"})]
        public sealed class CreditNoteLine : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CreditNoteLine() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CreditNoteLine";
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
