namespace Sp.PCFPeppol.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.unece.org/cefact/namespaces/InternalXml",@"StandardBusinessDocument")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"StandardBusinessDocument"})]
    public sealed class PCFPeppolInternalXML : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://www.unece.org/cefact/namespaces/InternalXml"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://www.unece.org/cefact/namespaces/InternalXml"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""StandardBusinessDocument"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""StandardBusinessDocumentHeader"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""HeaderVersion"" type=""xs:string"" />
              <xs:element name=""Sender"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Identifier"" type=""xs:string"" />
                    <xs:element name=""Authority"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Receiver"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Identifier"" type=""xs:string"" />
                    <xs:element name=""Authority"" type=""xs:string"" />
                    <xs:element name=""RcvId"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""DocumentIdentification"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Standard"" type=""xs:string"" />
                    <xs:element name=""TypeVersion"" type=""xs:string"" />
                    <xs:element name=""InstanceIdentifier"" type=""xs:string"" />
                    <xs:element name=""Type"" type=""xs:string"" />
                    <xs:element name=""CreationDateAndTime"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""BusinessScope"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element maxOccurs=""unbounded"" name=""Scope"">
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
        <xs:element name=""Invoice"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""UBLVersionID"" type=""xs:string"" />
              <xs:element name=""CustomizationID"" type=""xs:string"" />
              <xs:element name=""ProfileID"" type=""xs:string"" />
              <xs:element name=""ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DocumentId"" type=""xs:string"" />
              <xs:element name=""IssueDate"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DueDate"" type=""xs:string"" />
              <xs:element name=""InvoiceTypeCode"" type=""xs:string"" />
              <xs:element name=""CreditNoteTypeCode"" type=""xs:string"" />
              <xs:element name=""Note"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TaxPointDate"" type=""xs:string"" />
              <xs:element name=""DocumentCurrencyCode"" type=""xs:string"" />
              <xs:element name=""TaxCurrencyCode"" type=""xs:string"" />
              <xs:element name=""AccountingCost"" type=""xs:string"" />
              <xs:element name=""BuyerReference"" type=""xs:string"" />
              <xs:element name=""InvoiceInPath"" type=""xs:string"" />
              <xs:element name=""AttachmentPath"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""InvoicePeriod"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""StartDate"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""EndDate"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""DescriptionCode"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""OrderReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                    <xs:element name=""SalesOrderID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""BillingReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""InvoiceDocumentReference"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ID"" type=""xs:string"" />
                          <xs:element name=""IssueDate"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""DespatchDocumentReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""ReceiptDocumentReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""OriginatorDocumentReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""ContractDocumentReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AdditionalDocumentReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SchemeID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""DocumentTypeCode"" type=""xs:string"" />
                    <xs:element name=""DocumentDescription"" type=""xs:string"" />
                    <xs:element name=""Attachment"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""ExternalReference"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""URI"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element minOccurs=""0"" name=""EmbeddedDocumentBinaryObject"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""FileName"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""MimeCode"" type=""xs:string"" />
                          <xs:element maxOccurs=""1"" default=""0"" name=""AttachmentSize"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""ProjectReference"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""AccountingSupplierParty"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Party"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""EndpointID"" type=""xs:string"" />
                          <xs:element name=""SchemeID"" type=""xs:string"" />
                          <xs:element maxOccurs=""unbounded"" name=""PartyIdentification"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ID"" type=""xs:string"" />
                                <xs:element name=""SchemeID"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""PartyName"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Name"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""PostalAddress"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""StreetName"" type=""xs:string"" />
                                <xs:element name=""AdditionalStreetName"" type=""xs:string"" />
                                <xs:element name=""CityName"" type=""xs:string"" />
                                <xs:element name=""PostalZone"" type=""xs:string"" />
                                <xs:element name=""CountrySubentity"" type=""xs:string"" />
                                <xs:element name=""AddressLine"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""Line"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""Country"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""IdentificationCode"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""PartyTaxScheme"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""CompanyID"" type=""xs:string"" />
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
                          <xs:element name=""PartyLegalEntity"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""RegistrationName"" type=""xs:string"" />
                                <xs:element name=""CompanyID"" type=""xs:string"" />
                                <xs:element name=""SchemeID"" type=""xs:string"" />
                                <xs:element default=""20"" name=""CompanyLegalForm"">
                                  <xs:simpleType>
                                    <xs:restriction base=""xs:string"" />
                                  </xs:simpleType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""Contact"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Name"" type=""xs:string"" />
                                <xs:element name=""Telephone"" type=""xs:string"" />
                                <xs:element name=""ElectronicMail"" type=""xs:string"" />
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
                          <xs:element name=""EndpointID"" type=""xs:string"" />
                          <xs:element name=""SchemeID"" type=""xs:string"" />
                          <xs:element name=""PartyIdentification"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ID"" type=""xs:string"" />
                                <xs:element name=""SchemeID"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""PartyName"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Name"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""PostalAddress"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""StreetName"" type=""xs:string"" />
                                <xs:element name=""AdditionalStreetName"" type=""xs:string"" />
                                <xs:element name=""CityName"" type=""xs:string"" />
                                <xs:element name=""PostalZone"" type=""xs:string"" />
                                <xs:element name=""CountrySubentity"" type=""xs:string"" />
                                <xs:element name=""AddressLine"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""Line"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""Country"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""IdentificationCode"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""PartyTaxScheme"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""CompanyID"" type=""xs:string"" />
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
                          <xs:element name=""PartyLegalEntity"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""RegistrationName"" type=""xs:string"" />
                                <xs:element name=""CompanyID"" type=""xs:string"" />
                                <xs:element name=""SchemeID"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""Contact"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Name"" type=""xs:string"" />
                                <xs:element name=""Telephone"" type=""xs:string"" />
                                <xs:element name=""ElectronicMail"" type=""xs:string"" />
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
                          <xs:element name=""ID"" type=""xs:string"" />
                          <xs:element name=""SchemeID"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PartyName"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Name"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PartyLegalEntity"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""CompanyID"" type=""xs:string"" />
                          <xs:element name=""SchemeID"" type=""xs:string"" />
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
                          <xs:element name=""Name"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PostalAddress"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""StreetName"" type=""xs:string"" />
                          <xs:element name=""AdditionalStreetName"" type=""xs:string"" />
                          <xs:element name=""CityName"" type=""xs:string"" />
                          <xs:element name=""PostalZone"" type=""xs:string"" />
                          <xs:element name=""CountrySubentity"" type=""xs:string"" />
                          <xs:element name=""AddressLine"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""Line"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""Country"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""IdentificationCode"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PartyTaxScheme"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""CompanyID"" type=""xs:string"" />
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
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""Delivery"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ActualDeliveryDate"" type=""xs:string"" />
                    <xs:element name=""DeliveryLocation"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ID"" type=""xs:string"" />
                          <xs:element name=""SchemeID"" type=""xs:string"" />
                          <xs:element name=""Address"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""StreetName"" type=""xs:string"" />
                                <xs:element name=""AdditionalStreetName"" type=""xs:string"" />
                                <xs:element name=""CityName"" type=""xs:string"" />
                                <xs:element name=""PostalZone"" type=""xs:string"" />
                                <xs:element name=""CountrySubentity"" type=""xs:string"" />
                                <xs:element name=""AddressLine"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""Line"" type=""xs:string"" />
                                    </xs:sequence>
                                  </xs:complexType>
                                </xs:element>
                                <xs:element name=""Country"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""IdentificationCode"" type=""xs:string"" />
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
                                <xs:element name=""Name"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""PaymentMeans"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""PaymentMeansCode"" type=""xs:string"" />
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""PaymentID"" type=""xs:string"" />
                    <xs:element name=""CardAccount"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PrimaryAccountNumberID"" type=""xs:string"" />
                          <xs:element name=""NetworkID"" type=""xs:string"" />
                          <xs:element name=""HolderName"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PayeeFinancialAccount"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ID"" type=""xs:string"" />
                          <xs:element name=""Name"" type=""xs:string"" />
                          <xs:element name=""FinancialInstitutionBranch"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ID"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PaymentMandate"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ID"" type=""xs:string"" />
                          <xs:element name=""PayerFinancialAccount"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ID"" type=""xs:string"" />
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
                    <xs:element name=""Note"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""AllowanceCharge"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ChargeIndicator"" type=""xs:string"" />
                    <xs:element name=""AllowanceChargeReasonCode"" type=""xs:string"" />
                    <xs:element name=""AllowanceChargeReason"" type=""xs:string"" />
                    <xs:element name=""MultiplierFactorNumeric"" type=""xs:string"" />
                    <xs:element name=""Amount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDA"" type=""xs:string"" />
                    <xs:element name=""BaseAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDB"" type=""xs:string"" />
                    <xs:element name=""TaxCategory"">
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
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""TaxTotal"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""TaxAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyID"" type=""xs:string"" />
                    <xs:element name=""TaxSubtotal"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""TaxableAmount"" type=""xs:string"" />
                          <xs:element name=""CurrencyIDA1"" type=""xs:string"" />
                          <xs:element name=""TaxAmount"" type=""xs:string"" />
                          <xs:element name=""CurrencyIDA2"" type=""xs:string"" />
                          <xs:element name=""TaxCategory"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ID"" type=""xs:string"" />
                                <xs:element name=""Percent"" type=""xs:string"" />
                                <xs:element name=""TaxExemptionReasonCode"" type=""xs:string"" />
                                <xs:element name=""TaxExemptionReason"" type=""xs:string"" />
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
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""LegalMonetaryTotal"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""LineExtensionAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDL"" type=""xs:string"" />
                    <xs:element name=""TaxExclusiveAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDT1"" type=""xs:string"" />
                    <xs:element name=""TaxInclusiveAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDT2"" type=""xs:string"" />
                    <xs:element name=""AllowanceTotalAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDA"" type=""xs:string"" />
                    <xs:element name=""ChargeTotalAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDC"" type=""xs:string"" />
                    <xs:element name=""PrepaidAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDP1"" type=""xs:string"" />
                    <xs:element name=""PayableRoundingAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDP2"" type=""xs:string"" />
                    <xs:element name=""PayableAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyIDP3"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""InvoiceLine"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ID"" type=""xs:unsignedByte"" />
                    <xs:element name=""Note"" type=""xs:string"" />
                    <xs:element name=""InvoicedQuantity"" type=""xs:string"" />
                    <xs:element name=""UnitCode"" type=""xs:string"" />
                    <xs:element name=""LineExtensionAmount"" type=""xs:string"" />
                    <xs:element name=""CurrencyID"" type=""xs:string"" />
                    <xs:element name=""AccountingCost"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""InvoicePeriod"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""StartDate"" type=""xs:string"" />
                          <xs:element name=""EndDate"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""OrderLineReference"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""LineID"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""DocumentReference"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ID"" type=""xs:string"" />
                          <xs:element name=""SchemeID"" type=""xs:string"" />
                          <xs:element name=""DocumentTypeCode"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""AllowanceCharge"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""ChargeIndicator"" type=""xs:string"" />
                          <xs:element name=""AllowanceChargeReasonCode"" type=""xs:string"" />
                          <xs:element name=""AllowanceChargeReason"" type=""xs:string"" />
                          <xs:element name=""MultiplierFactorNumeric"" type=""xs:string"" />
                          <xs:element name=""Amount"" type=""xs:string"" />
                          <xs:element name=""CurrencyIDA"" type=""xs:string"" />
                          <xs:element name=""BaseAmount"" type=""xs:string"" />
                          <xs:element name=""CurrencyIDB"" type=""xs:string"" />
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
                                <xs:element name=""SchemeID"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element name=""OriginCountry"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""IdentificationCode"" type=""xs:string"" />
                                <xs:element name=""ListID"" type=""xs:string"" />
                              </xs:sequence>
                            </xs:complexType>
                          </xs:element>
                          <xs:element maxOccurs=""unbounded"" name=""CommodityClassification"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ItemClassificationCode"" type=""xs:string"" />
                                <xs:element name=""ListID"" type=""xs:string"" />
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
                          <xs:element name=""CurrencyID"" type=""xs:string"" />
                          <xs:element name=""BaseQuantity"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""AllowanceCharge"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""ChargeIndicator"" type=""xs:string"" />
                                <xs:element name=""Amount"" type=""xs:string"" />
                                <xs:element name=""CurrencyIDA"" type=""xs:string"" />
                                <xs:element name=""BaseAmount"" type=""xs:string"" />
                                <xs:element name=""CurrencyIDB"" type=""xs:string"" />
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
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public PCFPeppolInternalXML() {
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
