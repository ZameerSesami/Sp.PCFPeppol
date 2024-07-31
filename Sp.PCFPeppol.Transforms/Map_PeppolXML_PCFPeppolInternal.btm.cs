namespace Sp.PCFPeppol.Transforms {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PCFPeppolInternalXML", typeof(global::Sp.PCFPeppol.Schemas.PCFPeppolInternalXML))]
    public sealed class Map_PeppolXML_PCFPeppolInternal : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1 s3 s4 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s0=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" xmlns:s4=""urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2"" xmlns:s2=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"" xmlns:ns0=""http://www.unece.org/cefact/namespaces/InternalXml"" xmlns:s1=""http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader"" xmlns:s3=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output version=""1.0"" omit-xml-declaration=""yes"" method=""xml""/>
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:StandardBusinessDocument""/>
  </xsl:template>
  <xsl:template match=""/s1:StandardBusinessDocument"">
    <xsl:variable name=""DateCurrentDate"" select=""userCSharp:DateCurrentDate()"" />
    <xsl:variable name=""DocumentId"" select=""userCSharp:GetGUID()"" />
    <xsl:variable name=""DateToday"" select=""userCSharp:DateToday()"" />

    <ns0:StandardBusinessDocument>
      <StandardBusinessDocumentHeader>
        <HeaderVersion>
          <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:HeaderVersion/text()"" />
        </HeaderVersion>
        <xsl:if test=""s1:StandardBusinessDocumentHeader/s1:Sender/s1:Identifier/text()"">
          <Sender>
            <Identifier>
              <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:Sender/s1:Identifier/text()"" />
            </Identifier>
            <Authority>
              <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:Sender/s1:Identifier/@Authority"" />
            </Authority>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:Sender/text()"" />
          </Sender>
        </xsl:if>
        <xsl:if test=""s1:StandardBusinessDocumentHeader/s1:Receiver/s1:Identifier/text()"">
          <Receiver>
            <Identifier>
              <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:Receiver/s1:Identifier/text()"" />
            </Identifier>
            <Authority>
              <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:Receiver/s1:Identifier/@Authority"" />
            </Authority>
            <RcvId>
              <xsl:value-of select=""substring-after(s1:StandardBusinessDocumentHeader/s1:Receiver/s1:Identifier/text(),':')"" />
            </RcvId>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:Receiver/text()"" />
          </Receiver>
        </xsl:if>
        <DocumentIdentification>
          <Standard>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:DocumentIdentification/s1:Standard/text()"" />
          </Standard>
          <TypeVersion>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:DocumentIdentification/s1:TypeVersion/text()"" />
          </TypeVersion>
          <InstanceIdentifier>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:DocumentIdentification/s1:InstanceIdentifier/text()"" />
          </InstanceIdentifier>
          <Type>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:DocumentIdentification/s1:Type/text()"" />
          </Type>
          <CreationDateAndTime>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:DocumentIdentification/s1:CreationDateAndTime/text()"" />
          </CreationDateAndTime>
          <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:DocumentIdentification/text()"" />
        </DocumentIdentification>
        <!--Below code comment by Zameer - Surendar informed to check only ""Type"" instead of below 3 elements - 20240201-->
        <!--<xsl:if test=""(s1:StandardBusinessDocumentHeader/s1:BusinessScope/s1:Scope/s1:Type/text() !='') and (s1:StandardBusinessDocumentHeader/s1:BusinessScope/s1:Scope/s1:InstanceIdentifier/text() !='') and (s1:StandardBusinessDocumentHeader/s1:BusinessScope/s1:Scope/s1:Identifier/text() !='')"">-->
        <xsl:if test=""(s1:StandardBusinessDocumentHeader/s1:BusinessScope/s1:Scope/s1:Type/text() !='')"">
          <BusinessScope>
            <xsl:for-each select=""s1:StandardBusinessDocumentHeader/s1:BusinessScope/s1:Scope"">
              <Scope>
                <Type>
                  <xsl:value-of select=""s1:Type/text()"" />
                </Type>
                <InstanceIdentifier>
                  <xsl:value-of select=""s1:InstanceIdentifier/text()"" />
                </InstanceIdentifier>
                <Identifier>
                  <xsl:value-of select=""s1:Identifier/text()"" />
                </Identifier>
                <xsl:value-of select=""./text()"" />
              </Scope>
            </xsl:for-each>
            <xsl:value-of select=""s1:StandardBusinessDocumentHeader/s1:BusinessScope/text()"" />
          </BusinessScope>
        </xsl:if>
        <xsl:value-of select=""s1:StandardBusinessDocumentHeader/text()"" />
      </StandardBusinessDocumentHeader>
      <xsl:if test=""s0:Invoice/s3:InvoiceTypeCode/text() != ''"">
        <Invoice>
          <UBLVersionID>
            <xsl:value-of select=""s0:Invoice/s3:UBLVersionID/text()"" />
          </UBLVersionID>
          <CustomizationID>
            <xsl:value-of select=""s0:Invoice/s3:CustomizationID/text()"" />
          </CustomizationID>
          <ProfileID>
            <xsl:value-of select=""s0:Invoice/s3:ProfileID/text()"" />
          </ProfileID>
          <ID>
            <xsl:value-of select=""s0:Invoice/s3:ID/text()"" />
          </ID>
          <DocumentId>
            <xsl:value-of select=""$DocumentId"" />
          </DocumentId>
          <IssueDate>
            <xsl:value-of select=""s0:Invoice/s3:IssueDate/text()"" />
          </IssueDate>
          <xsl:if test=""s0:Invoice/s3:DueDate"">
            <DueDate>
              <xsl:value-of select=""s0:Invoice/s3:DueDate/text()"" />
            </DueDate>
          </xsl:if>
          <InvoiceTypeCode>
            <xsl:value-of select=""s0:Invoice/s3:InvoiceTypeCode/text()"" />
          </InvoiceTypeCode>
          <Note>
            <xsl:value-of select=""normalize-space(substring(s0:Invoice/s3:Note/text(),1,255))"" />
          </Note>
          <TaxPointDate>
            <xsl:value-of select=""s0:Invoice/s3:TaxPointDate/text()"" />
          </TaxPointDate>
          <DocumentCurrencyCode>
            <xsl:value-of select=""s0:Invoice/s3:DocumentCurrencyCode/text()"" />
          </DocumentCurrencyCode>
          <TaxCurrencyCode>
            <xsl:value-of select=""s0:Invoice/s3:TaxCurrencyCode/text()"" />
          </TaxCurrencyCode>
          <AccountingCost>
            <xsl:value-of select=""s0:Invoice/s3:AccountingCost/text()"" />
          </AccountingCost>
          <BuyerReference>
            <xsl:value-of select=""s0:Invoice/s3:BuyerReference/text()"" />
          </BuyerReference>
          <xsl:variable name=""Z"" select=""&quot;Z:&quot;"" />
          <xsl:variable name=""PeppolInbound"" select=""&quot;Peppol\Inbound&quot;"" />
          <xsl:variable name=""DocType"" select=""&quot;InvCN&quot;"" />
          <xsl:variable name=""BackSlash"" select=""&quot;\&quot;"" />

          <xsl:variable name=""PeppolInvoicePath"" select=""userCSharp:GetPeppolInvoicePath($Z,$DateToday,$PeppolInbound,$DocType,$BackSlash)"" />
          <InvoiceInPath>
            <xsl:value-of select=""$PeppolInvoicePath"" />
          </InvoiceInPath>
          <!--<xsl:variable name=""base64BinaryStr"" select=""string(s0:Invoice/s2:AdditionalDocumentReference/s2:Attachment/s3:EmbeddedDocumentBinaryObject) ""/>
          <xsl:variable name=""mime"" select=""string(s0:Invoice/s2:AdditionalDocumentReference/s2:Attachment/s3:EmbeddedDocumentBinaryObject/@mimeCode)""/>
          <xsl:variable name=""issueDate"" select=""string(s0:Invoice/s3:IssueDate)""/>
          <xsl:variable name=""BU"" select=""string(s0:Invoice/s3:BuyerReference/text())""/>
          <xsl:variable name=""CompanyId"" select=""string(s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text())""/>
          <xsl:variable name=""Invoice"" select=""string(s0:Invoice/s3:ID/text())""/>
             
          <xsl:variable name=""path"" select=""userCSharp:GetAttachment($base64BinaryStr,$mime,$issueDate,$BU,$CompanyId,$Invoice,$DocType,$DocumentId)"" />
          <AttachmentPath>

            <xsl:value-of select=""$path"" />

          </AttachmentPath>-->
          <xsl:if test=""s0:Invoice/s2:InvoicePeriod"">
            <InvoicePeriod>
              <StartDate>
                <xsl:value-of select=""s0:Invoice/s2:InvoicePeriod/s3:StartDate/text()"" />
              </StartDate>
              <EndDate>
                <xsl:value-of select=""s0:Invoice/s2:InvoicePeriod/s3:EndDate/text()"" />
              </EndDate>
              <DescriptionCode>
                <xsl:value-of select=""s0:Invoice/s2:InvoicePeriod/s3:DescriptionCode/text()"" />
              </DescriptionCode>
              <xsl:value-of select=""s0:Invoice/s2:InvoicePeriod/text()"" />
            </InvoicePeriod>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:OrderReference/s3:ID/text()"">
            <OrderReference>
              <ID>
                <xsl:value-of select=""s0:Invoice/s2:OrderReference/s3:ID/text()"" />
              </ID>
              <SalesOrderID>
                <xsl:value-of select=""s0:Invoice/s2:OrderReference/s3:SalesOrderID/text()"" />
              </SalesOrderID>
              <xsl:value-of select=""s0:Invoice/s2:OrderReference/text()"" />
            </OrderReference>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:BillingReference/s2:InvoiceDocumentReference/s3:ID/text()"">
            <BillingReference>
              <InvoiceDocumentReference>
                <ID>
                  <xsl:value-of select=""s0:Invoice/s2:BillingReference/s2:InvoiceDocumentReference/s3:ID/text()"" />
                </ID>
                <IssueDate>
                  <xsl:value-of select=""s0:Invoice/s2:BillingReference/s2:InvoiceDocumentReference/s3:IssueDate/text()"" />
                </IssueDate>
                <xsl:value-of select=""s0:Invoice/s2:BillingReference/s2:InvoiceDocumentReference/text()"" />
              </InvoiceDocumentReference>
              <xsl:value-of select=""s0:Invoice/s2:BillingReference/text()"" />
            </BillingReference>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:DespatchDocumentReference/s3:ID/text()"">
            <DespatchDocumentReference>
              <ID>
                <xsl:value-of select=""s0:Invoice/s2:DespatchDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s0:Invoice/s2:DespatchDocumentReference/text()"" />
            </DespatchDocumentReference>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:ReceiptDocumentReference/s3:ID/text()"">
            <ReceiptDocumentReference>
              <ID>
                <xsl:value-of select=""s0:Invoice/s2:ReceiptDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s0:Invoice/s2:ReceiptDocumentReference/text()"" />
            </ReceiptDocumentReference>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:OriginatorDocumentReference/s3:ID/text()"">
            <OriginatorDocumentReference>
              <ID>
                <xsl:value-of select=""s0:Invoice/s2:OriginatorDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s0:Invoice/s2:OriginatorDocumentReference/text()"" />
            </OriginatorDocumentReference>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:ContractDocumentReference/s3:ID/text()"">
            <ContractDocumentReference>
              <ID>
                <xsl:value-of select=""s0:Invoice/s2:ContractDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s0:Invoice/s2:ContractDocumentReference/text()"" />
            </ContractDocumentReference>
          </xsl:if>
          <xsl:if test=""(s0:Invoice/s2:AdditionalDocumentReference/s3:ID/text() !='')"">
            <xsl:for-each select=""s0:Invoice/s2:AdditionalDocumentReference"">
              <AdditionalDocumentReference>
                <ID>
                  <xsl:value-of select=""s3:ID/text()"" />
                </ID>
                <xsl:if test=""s3:ID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s3:ID/@schemeID"" />
                  </SchemeID>
                </xsl:if>
                <xsl:if test=""s3:DocumentTypeCode/text()"">
                  <DocumentTypeCode>
                    <xsl:value-of select=""s3:DocumentTypeCode"" />
                  </DocumentTypeCode>
                </xsl:if>
                <DocumentDescription>
                  <xsl:value-of select=""s3:DocumentDescription/text()"" />
                </DocumentDescription>
                <Attachment>
                  <xsl:for-each select=""s2:Attachment/s2:ExternalReference"">
                    <ExternalReference>
                      <URI>
                        <xsl:value-of select=""s3:URI/text()"" />
                      </URI>
                      <xsl:value-of select=""./text()"" />
                    </ExternalReference>
                  </xsl:for-each>
                  <xsl:if test=""s2:Attachment/s3:EmbeddedDocumentBinaryObject"">
                    <EmbeddedDocumentBinaryObject>
                      <xsl:value-of select=""s2:Attachment/s3:EmbeddedDocumentBinaryObject/text()"" />
                    </EmbeddedDocumentBinaryObject>
                  </xsl:if>
                  <FileName>
                    <xsl:value-of select=""s2:Attachment/s3:EmbeddedDocumentBinaryObject/@filename"" />
                  </FileName>
                  <MimeCode>
                    <xsl:value-of select=""s2:Attachment/s3:EmbeddedDocumentBinaryObject/@mimeCode"" />
                  </MimeCode>
                  <xsl:variable name=""InvoiceNumber"" select=""userCSharp:ReplaceSpecialChars(string(../s3:ID/text()))""/>
                  <xsl:variable name=""BuyerReference"" select=""userCSharp:ReplaceSpecialChars(string(../s3:BuyerReference/text()))""/>
                  <xsl:variable name=""CompanyID"" select=""userCSharp:ReplaceSpecialChars(string(../s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text()))""/>

                  <xsl:variable name=""var:v1"" select=""userCSharp:GetAttachmentSize(string(s2:Attachment/s3:EmbeddedDocumentBinaryObject/text()) , string(s2:Attachment/s3:EmbeddedDocumentBinaryObject/@mimeCode) , string(../s3:IssueDate/text()) , $BuyerReference , $CompanyID , $InvoiceNumber)"" />
                  <xsl:variable name=""var:v2"" select=""userCSharp:AttachmentSize(string($var:v1))"" />
                  <AttachmentSize>
                    <xsl:value-of select=""$var:v2"" />
                  </AttachmentSize>
                  <xsl:value-of select=""s2:Attachment/text()"" />
                </Attachment>
                <xsl:value-of select=""./text()"" />
              </AdditionalDocumentReference>
            </xsl:for-each>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:ProjectReference/s3:ID/text()"">
            <ProjectReference>
              <ID>
                <xsl:value-of select=""s0:Invoice/s2:ProjectReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s0:Invoice/s2:ProjectReference/text()"" />
            </ProjectReference>
          </xsl:if>
          <xsl:if test=""(s0:Invoice/s2:AccountingSupplierParty/s2:Party/s3:EndpointID/text() !='') and (s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text() !='')"">
            <AccountingSupplierParty>
              <Party>
                <EndpointID>
                  <xsl:value-of select=""normalize-space(s0:Invoice/s2:AccountingSupplierParty/s2:Party/s3:EndpointID/text())"" />
                </EndpointID>
                <SchemeID>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s3:EndpointID/@schemeID"" />
                </SchemeID>
                <xsl:for-each select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyIdentification"">
                  <PartyIdentification>
                    <ID>
                      <xsl:value-of select=""s3:ID/text()"" />
                    </ID>
                    <xsl:if test=""s3:ID/@schemeID"">
                      <SchemeID>
                        <xsl:value-of select=""s3:ID/@schemeID"" />
                      </SchemeID>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </PartyIdentification>
                </xsl:for-each>
                <PartyName>
                  <Name>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyName/s3:Name/text()"" />
                  </Name>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyName/text()"" />
                </PartyName>
                <PostalAddress>
                  <StreetName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:StreetName/text()"" />
                  </StreetName>
                  <AdditionalStreetName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:AdditionalStreetName/text()"" />
                  </AdditionalStreetName>
                  <CityName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:CityName/text()"" />
                  </CityName>
                  <PostalZone>
                    <xsl:value-of select=""substring(s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:PostalZone/text(),1,20)"" />
                  </PostalZone>
                  <CountrySubentity>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:CountrySubentity/text()"" />
                  </CountrySubentity>
                  <AddressLine>
                    <Line>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:AddressLine/s3:Line/text()"" />
                    </Line>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:AddressLine/text()"" />
                  </AddressLine>
                  <Country>
                    <IdentificationCode>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:Country/s3:IdentificationCode/text()"" />
                    </IdentificationCode>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:Country/text()"" />
                  </Country>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/text()"" />
                </PostalAddress>
                <PartyTaxScheme>
                  <CompanyID>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/s3:CompanyID/text()"" />
                  </CompanyID>
                  <TaxScheme>
                    <ID>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/s3:ID/text()"" />
                    </ID>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/text()"" />
                  </TaxScheme>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/text()"" />
                </PartyTaxScheme>
                <PartyLegalEntity>
                  <RegistrationName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text()"" />
                  </RegistrationName>
                  <CompanyID>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text()"" />
                  </CompanyID>
                  <xsl:if test=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"">
                    <SchemeID>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"" />
                    </SchemeID>
                  </xsl:if>
                  <CompanyLegalForm>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyLegalForm/text()"" />
                  </CompanyLegalForm>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/text()"" />
                </PartyLegalEntity>
                <Contact>
                  <Name>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:Contact/s3:Name/text()"" />
                  </Name>
                  <Telephone>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:Contact/s3:Telephone/text()"" />
                  </Telephone>
                  <ElectronicMail>
                    <xsl:value-of select=""userCSharp:ReturnElectronicEmail(s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:Contact/s3:ElectronicMail/text())"" />
                  </ElectronicMail>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/s2:Contact/text()"" />
                </Contact>
                <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/s2:Party/text()"" />
              </Party>
              <xsl:value-of select=""s0:Invoice/s2:AccountingSupplierParty/text()"" />
            </AccountingSupplierParty>
          </xsl:if>
          <xsl:if test=""(s0:Invoice/s2:AccountingCustomerParty/s2:Party/s3:EndpointID/text() !='') and (s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text() != '')"">
            <AccountingCustomerParty>
              <Party>
                <EndpointID>
                  <xsl:value-of select=""normalize-space(s0:Invoice/s2:AccountingCustomerParty/s2:Party/s3:EndpointID/text())"" />
                </EndpointID>
                <SchemeID>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s3:EndpointID/@schemeID"" />
                </SchemeID>
                <PartyIdentification>
                  <ID>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/s3:ID/text()"" />
                  </ID>
                  <xsl:if test=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/s3:ID/@schemeID"">
                    <SchemeID>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/s3:ID/@schemeID"" />
                    </SchemeID>
                  </xsl:if>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/text()"" />
                </PartyIdentification>
                <PartyName>
                  <Name>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyName/s3:Name/text()"" />
                  </Name>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyName/text()"" />
                </PartyName>
                <PostalAddress>
                  <StreetName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:StreetName/text()"" />
                  </StreetName>
                  <AdditionalStreetName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:AdditionalStreetName/text()"" />
                  </AdditionalStreetName>
                  <CityName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:CityName/text()"" />
                  </CityName>
                  <PostalZone>
                    <xsl:value-of select=""substring(s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:PostalZone/text(),1,20)"" />
                  </PostalZone>
                  <CountrySubentity>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:CountrySubentity/text()"" />
                  </CountrySubentity>
                  <AddressLine>
                    <Line>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:AddressLine/s3:Line/text()"" />
                    </Line>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:AddressLine/text()"" />
                  </AddressLine>
                  <Country>
                    <IdentificationCode>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:Country/s3:IdentificationCode/text()"" />
                    </IdentificationCode>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:Country/text()"" />
                  </Country>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/text()"" />
                </PostalAddress>
                <PartyTaxScheme>
                  <CompanyID>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/s3:CompanyID/text()"" />
                  </CompanyID>
                  <TaxScheme>
                    <ID>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/s3:ID/text()"" />
                    </ID>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/text()"" />
                  </TaxScheme>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/text()"" />
                </PartyTaxScheme>
                <PartyLegalEntity>
                  <RegistrationName>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text()"" />
                  </RegistrationName>
                  <CompanyID>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text()"" />
                  </CompanyID>
                  <xsl:if test=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"">
                    <SchemeID>
                      <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"" />
                    </SchemeID>
                  </xsl:if>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/text()"" />
                </PartyLegalEntity>
                <Contact>
                  <Name>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:Contact/s3:Name/text()"" />
                  </Name>
                  <Telephone>
                    <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:Contact/s3:Telephone/text()"" />
                  </Telephone>
                  <ElectronicMail>
                    <xsl:value-of select=""userCSharp:ReturnElectronicEmail(s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:Contact/s3:ElectronicMail/text())"" />
                  </ElectronicMail>
                  <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/s2:Contact/text()"" />
                </Contact>
                <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/s2:Party/text()"" />
              </Party>
              <xsl:value-of select=""s0:Invoice/s2:AccountingCustomerParty/text()"" />
            </AccountingCustomerParty>
          </xsl:if>
          <xsl:if test=""(s0:Invoice/s2:PayeeParty/s2:PartyIdentification/s3:ID/text() !='')"">
            <PayeeParty>
              <PartyIdentification>
                <ID>
                  <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyIdentification/s3:ID/text()"" />
                </ID>
                <xsl:if test=""s0:Invoice/s2:PayeeParty/s2:PartyIdentification/s3:ID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyIdentification/s3:ID/@schemeID"" />
                  </SchemeID>
                </xsl:if>
                <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyIdentification/text()"" />
              </PartyIdentification>
              <PartyName>
                <Name>
                  <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyName/s3:Name/text()"" />
                </Name>
                <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyName/text()"" />
              </PartyName>
              <PartyLegalEntity>
                <CompanyID>
                  <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyLegalEntity/s3:CompanyID/text()"" />
                </CompanyID>
                <xsl:if test=""s0:Invoice/s2:PayeeParty/s2:PartyLegalEntity/s3:CompanyID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyLegalEntity/s3:CompanyID/@schemeID"" />
                  </SchemeID>
                </xsl:if>
                <xsl:value-of select=""s0:Invoice/s2:PayeeParty/s2:PartyLegalEntity/text()"" />
              </PartyLegalEntity>
              <xsl:value-of select=""s0:Invoice/s2:PayeeParty/text()"" />
            </PayeeParty>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:TaxRepresentativeParty/s2:PartyName/text()"">
            <TaxRepresentativeParty>
              <PartyName>
                <Name>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PartyName/s3:Name/text()"" />
                </Name>
                <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PartyName/text()"" />
              </PartyName>
              <PostalAddress>
                <StreetName>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s3:StreetName/text()"" />
                </StreetName>
                <AdditionalStreetName>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s3:AdditionalStreetName/text()"" />
                </AdditionalStreetName>
                <CityName>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s3:CityName/text()"" />
                </CityName>
                <PostalZone>
                  <xsl:value-of select=""substring(s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s3:PostalZone/text(),1,20)"" />
                </PostalZone>
                <CountrySubentity>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s3:CountrySubentity/text()"" />
                </CountrySubentity>
                <AddressLine>
                  <Line>
                    <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s2:AddressLine/s3:Line/text()"" />
                  </Line>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s2:AddressLine/text()"" />
                </AddressLine>
                <Country>
                  <IdentificationCode>
                    <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s2:Country/s3:IdentificationCode/text()"" />
                  </IdentificationCode>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/s2:Country/text()"" />
                </Country>
                <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PostalAddress/text()"" />
              </PostalAddress>
              <PartyTaxScheme>
                <CompanyID>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PartyTaxScheme/s3:CompanyID/text()"" />
                </CompanyID>
                <TaxScheme>
                  <ID>
                    <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PartyTaxScheme/s2:TaxScheme/s3:ID/text()"" />
                  </ID>
                  <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PartyTaxScheme/s2:TaxScheme/text()"" />
                </TaxScheme>
                <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/s2:PartyTaxScheme/text()"" />
              </PartyTaxScheme>
              <xsl:value-of select=""s0:Invoice/s2:TaxRepresentativeParty/text()"" />
            </TaxRepresentativeParty>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:Delivery"">
            <Delivery>
              <ActualDeliveryDate>
                <xsl:value-of select=""s0:Invoice/s2:Delivery/s3:ActualDeliveryDate/text()"" />
              </ActualDeliveryDate>
              <DeliveryLocation>
                <ID>
                  <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s3:ID/text()"" />
                </ID>
                <xsl:if test=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s3:ID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s3:ID/@schemeID"" />
                  </SchemeID>
                </xsl:if>
                <Address>
                  <StreetName>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:StreetName/text()"" />
                  </StreetName>
                  <AdditionalStreetName>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:AdditionalStreetName/text()"" />
                  </AdditionalStreetName>
                  <CityName>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:CityName/text()"" />
                  </CityName>
                  <PostalZone>
                    <xsl:value-of select=""substring(s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:PostalZone/text(),1,20)"" />
                  </PostalZone>
                  <CountrySubentity>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:CountrySubentity/text()"" />
                  </CountrySubentity>
                  <AddressLine>
                    <Line>
                      <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:AddressLine/s3:Line/text()"" />
                    </Line>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:AddressLine/text()"" />
                  </AddressLine>
                  <Country>
                    <IdentificationCode>
                      <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:Country/s3:IdentificationCode/text()"" />
                    </IdentificationCode>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:Country/text()"" />
                  </Country>
                  <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/s2:Address/text()"" />
                </Address>
                <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryLocation/text()"" />
              </DeliveryLocation>
              <DeliveryParty>
                <PartyName>
                  <Name>
                    <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryParty/s2:PartyName/s3:Name/text()"" />
                  </Name>
                  <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryParty/s2:PartyName/text()"" />
                </PartyName>
                <xsl:value-of select=""s0:Invoice/s2:Delivery/s2:DeliveryParty/text()"" />
              </DeliveryParty>
              <xsl:value-of select=""s0:Invoice/s2:Delivery/text()"" />
            </Delivery>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:PaymentMeans/s3:PaymentMeansCode/text()"">
            <PaymentMeans>
              <PaymentMeansCode>
                <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s3:PaymentMeansCode/text()"" />
              </PaymentMeansCode>
              <Name>
                <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s3:PaymentMeansCode/@name"" />
              </Name>
              <PaymentID>
                <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s3:PaymentID/text()"" />
              </PaymentID>
              <CardAccount>
                <PrimaryAccountNumberID>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:CardAccount/s3:PrimaryAccountNumberID/text()"" />
                </PrimaryAccountNumberID>
                <NetworkID>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:CardAccount/s3:NetworkID/text()"" />
                </NetworkID>
                <HolderName>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:CardAccount/s3:HolderName/text()"" />
                </HolderName>
                <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:CardAccount/text()"" />
              </CardAccount>
              <PayeeFinancialAccount>
                <ID>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PayeeFinancialAccount/s3:ID/text()"" />
                </ID>
                <Name>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PayeeFinancialAccount/s3:Name/text()"" />
                </Name>
                <FinancialInstitutionBranch>
                  <ID>
                    <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PayeeFinancialAccount/s2:FinancialInstitutionBranch/s3:ID/text()"" />
                  </ID>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PayeeFinancialAccount/s2:FinancialInstitutionBranch/text()"" />
                </FinancialInstitutionBranch>
                <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PayeeFinancialAccount/text()"" />
              </PayeeFinancialAccount>
              <PaymentMandate>
                <ID>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PaymentMandate/s3:ID/text()"" />
                </ID>
                <PayerFinancialAccount>
                  <ID>
                    <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PaymentMandate/s2:PayerFinancialAccount/s3:ID/text()"" />
                  </ID>
                  <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PaymentMandate/s2:PayerFinancialAccount/text()"" />
                </PayerFinancialAccount>
                <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/s2:PaymentMandate/text()"" />
              </PaymentMandate>
              <xsl:value-of select=""s0:Invoice/s2:PaymentMeans/text()"" />
            </PaymentMeans>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:PaymentTerms/s3:Note/text()"">
            <PaymentTerms>
              <Note>
                <xsl:value-of select=""s0:Invoice/s2:PaymentTerms/s3:Note/text()"" />
              </Note>
              <xsl:value-of select=""s0:Invoice/s2:PaymentTerms/text()"" />
            </PaymentTerms>
          </xsl:if>

          <xsl:if test=""(s0:Invoice/s2:AllowanceCharge/s3:ChargeIndicator/text() !='') and (s0:Invoice/s2:AllowanceCharge/s3:Amount/text() !='') and (s0:Invoice/s2:AllowanceCharge/s3:Amount/@currencyID !='')"">
            <xsl:for-each select=""s0:Invoice/s2:AllowanceCharge"">
              <AllowanceCharge>
                <ChargeIndicator>
                  <xsl:value-of select=""s3:ChargeIndicator/text()"" />
                </ChargeIndicator>
                <AllowanceChargeReasonCode>
                  <xsl:value-of select=""s3:AllowanceChargeReasonCode/text()"" />
                </AllowanceChargeReasonCode>
                <AllowanceChargeReason>
                  <xsl:value-of select=""s3:AllowanceChargeReason/text()"" />
                </AllowanceChargeReason>
                <MultiplierFactorNumeric>
                  <xsl:value-of select=""s3:MultiplierFactorNumeric/text()"" />
                </MultiplierFactorNumeric>
                <Amount>
                  <xsl:value-of select=""s3:Amount/text()"" />
                </Amount>
                <CurrencyIDA>
                  <xsl:value-of select=""s3:Amount/@currencyID"" />
                </CurrencyIDA>
                <BaseAmount>
                  <xsl:value-of select=""s3:BaseAmount/text()"" />
                </BaseAmount>
                <CurrencyIDB>
                  <xsl:value-of select=""s3:BaseAmount/@currencyID"" />
                </CurrencyIDB>
                <TaxCategory>
                  <ID>
                    <xsl:value-of select=""s2:TaxCategory/s3:ID/text()"" />
                  </ID>
                  <Percent>
                    <xsl:value-of select=""s2:TaxCategory/s3:Percent/text()"" />
                  </Percent>
                  <TaxScheme>
                    <ID>
                      <xsl:value-of select=""s2:TaxCategory/s2:TaxScheme/s3:ID/text()"" />
                    </ID>
                    <xsl:value-of select=""s2:TaxCategory/s2:TaxScheme/text()"" />
                  </TaxScheme>
                  <xsl:value-of select=""s2:TaxCategory/text()"" />
                </TaxCategory>
                <!--<xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/text()"" />-->
              </AllowanceCharge>
            </xsl:for-each>
          </xsl:if>

          <!--below is old code-->
          <!--<AllowanceCharge>
                <ChargeIndicator>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:ChargeIndicator/text()"" />
                </ChargeIndicator>
                <AllowanceChargeReasonCode>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:AllowanceChargeReasonCode/text()"" />
                </AllowanceChargeReasonCode>
                <AllowanceChargeReason>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:AllowanceChargeReason/text()"" />
                </AllowanceChargeReason>
                <MultiplierFactorNumeric>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:MultiplierFactorNumeric/text()"" />
                </MultiplierFactorNumeric>
                <Amount>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:Amount/text()"" />
                </Amount>
                <CurrencyIDA>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:Amount/@currencyID"" />
                </CurrencyIDA>
                <BaseAmount>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:BaseAmount/text()"" />
                </BaseAmount>
                <CurrencyIDB>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s3:BaseAmount/@currencyID"" />
                </CurrencyIDB>
                <TaxCategory>
                  <ID>
                    <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s2:TaxCategory/s3:ID/text()"" />
                  </ID>
                  <Percent>
                    <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s2:TaxCategory/s3:Percent/text()"" />
                  </Percent>
                  <TaxScheme>
                    <ID>
                      <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s2:TaxCategory/s2:TaxScheme/s3:ID/text()"" />
                    </ID>
                    <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s2:TaxCategory/s2:TaxScheme/text()"" />
                  </TaxScheme>
                  <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/s2:TaxCategory/text()"" />
                </TaxCategory>
                <xsl:value-of select=""s0:Invoice/s2:AllowanceCharge/text()"" />
              </AllowanceCharge>-->

          <xsl:if test=""(s0:Invoice/s2:TaxTotal/s3:TaxAmount/text() !='') and (s0:Invoice/s2:TaxTotal/s3:TaxAmount/@currencyID !='')"">
            <xsl:for-each select=""s0:Invoice/s2:TaxTotal"">
              <TaxTotal>
                <TaxAmount>
                  <xsl:value-of select=""s3:TaxAmount/text()"" />
                </TaxAmount>
                <CurrencyID>
                  <xsl:value-of select=""s3:TaxAmount/@currencyID"" />
                </CurrencyID>
                <xsl:if test=""(s2:TaxSubtotal/s3:TaxableAmount/@currencyID) and (s2:TaxSubtotal/s3:TaxAmount/@currencyID)"">
                  <xsl:for-each select=""s2:TaxSubtotal"">
                    <TaxSubtotal>
                      <TaxableAmount>
                        <xsl:value-of select=""s3:TaxableAmount/text()"" />
                      </TaxableAmount>
                      <CurrencyIDA1>
                        <xsl:value-of select=""s3:TaxableAmount/@currencyID"" />
                      </CurrencyIDA1>
                      <TaxAmount>
                        <xsl:value-of select=""s3:TaxAmount/text()"" />
                      </TaxAmount>
                      <CurrencyIDA2>
                        <xsl:value-of select=""s3:TaxAmount/@currencyID"" />
                      </CurrencyIDA2>
                      <TaxCategory>
                        <ID>
                          <xsl:value-of select=""s2:TaxCategory/s3:ID/text()"" />
                        </ID>
                        <Percent>
                          <xsl:value-of select=""s2:TaxCategory/s3:Percent/text()"" />
                        </Percent>
                        <TaxExemptionReasonCode>
                          <xsl:value-of select=""s2:TaxCategory/s3:TaxExemptionReasonCode/text()"" />
                        </TaxExemptionReasonCode>
                        <TaxExemptionReason>
                          <xsl:value-of select=""s2:TaxCategory/s3:TaxExemptionReason/text()"" />
                        </TaxExemptionReason>
                        <TaxScheme>
                          <ID>
                            <xsl:value-of select=""s2:TaxCategory/s2:TaxScheme/s3:ID/text()"" />
                          </ID>
                          <xsl:value-of select=""s2:TaxCategory/s2:TaxScheme/text()"" />
                        </TaxScheme>
                        <xsl:value-of select=""s2:TaxCategory/text()"" />
                      </TaxCategory>
                      <xsl:value-of select=""./text()"" />
                    </TaxSubtotal>
                  </xsl:for-each>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </TaxTotal>
            </xsl:for-each>
          </xsl:if>
          <xsl:if test=""(s0:Invoice/s2:LegalMonetaryTotal/s3:LineExtensionAmount/text() !='') and (s0:Invoice/s2:LegalMonetaryTotal/s3:LineExtensionAmount/@currencyID !='') and (s0:Invoice/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/text() !='') and (s0:Invoice/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/@currencyID !='') and (s0:Invoice/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/text() !='') and (s0:Invoice/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/@currencyID !='')"">
            <LegalMonetaryTotal>
              <LineExtensionAmount>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:LineExtensionAmount/text()"" />
              </LineExtensionAmount>
              <CurrencyIDL>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:LineExtensionAmount/@currencyID"" />
              </CurrencyIDL>
              <TaxExclusiveAmount>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/text()"" />
              </TaxExclusiveAmount>
              <CurrencyIDT1>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/@currencyID"" />
              </CurrencyIDT1>
              <TaxInclusiveAmount>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/text()"" />
              </TaxInclusiveAmount>
              <CurrencyIDT2>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/@currencyID"" />
              </CurrencyIDT2>
              <xsl:if test=""s0:Invoice/s2:LegalMonetaryTotal/s3:AllowanceTotalAmount"">
                <AllowanceTotalAmount>
                  <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:AllowanceTotalAmount/text()"" />
                </AllowanceTotalAmount>
              </xsl:if>
              <CurrencyIDA>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:AllowanceTotalAmount/@currencyID"" />
              </CurrencyIDA>
              <ChargeTotalAmount>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:ChargeTotalAmount/text()"" />
              </ChargeTotalAmount>
              <CurrencyIDC>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:ChargeTotalAmount/@currencyID"" />
              </CurrencyIDC>
              <PrepaidAmount>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:PrepaidAmount/text()"" />
              </PrepaidAmount>
              <CurrencyIDP1>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:PrepaidAmount/@currencyID"" />
              </CurrencyIDP1>
              <PayableRoundingAmount>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:PayableRoundingAmount/text()"" />
              </PayableRoundingAmount>
              <CurrencyIDP2>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:PayableRoundingAmount/@currencyID"" />
              </CurrencyIDP2>
              <PayableAmount>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:PayableAmount/text()"" />
              </PayableAmount>
              <CurrencyIDP3>
                <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/s3:PayableAmount/@currencyID"" />
              </CurrencyIDP3>
              <xsl:value-of select=""s0:Invoice/s2:LegalMonetaryTotal/text()"" />
            </LegalMonetaryTotal>
          </xsl:if>
          <xsl:if test=""s0:Invoice/s2:InvoiceLine/s3:ID/text()"">
            <xsl:for-each select=""s0:Invoice/s2:InvoiceLine"">
              <InvoiceLine>
                <ID>
                  <xsl:value-of select=""s3:ID/text()"" />
                </ID>
                <xsl:if test=""s3:Note"">
                  <Note>
                    <xsl:value-of select=""substring(s3:Note/text(),1,255)"" />
                  </Note>
                </xsl:if>
                <InvoicedQuantity>
                  <xsl:value-of select=""s3:InvoicedQuantity/text()"" />
                </InvoicedQuantity>
                <UnitCode>
                  <xsl:value-of select=""s3:InvoicedQuantity/@unitCode"" />
                </UnitCode>
                <LineExtensionAmount>
                  <xsl:value-of select=""s3:LineExtensionAmount/text()"" />
                </LineExtensionAmount>
                <CurrencyID>
                  <xsl:value-of select=""s3:LineExtensionAmount/@currencyID"" />
                </CurrencyID>
                <xsl:if test=""s3:AccountingCost"">
                  <AccountingCost>
                    <xsl:value-of select=""s3:AccountingCost/text()"" />
                  </AccountingCost>
                </xsl:if>
                <xsl:if test=""s2:InvoicePeriod"">
                  <InvoicePeriod>
                    <StartDate>
                      <xsl:value-of select=""s2:InvoicePeriod/s3:StartDate/text()"" />
                    </StartDate>
                    <EndDate>
                      <xsl:value-of select=""s2:InvoicePeriod/s3:EndDate/text()"" />
                    </EndDate>
                    <xsl:value-of select=""s2:InvoicePeriod/text()"" />
                  </InvoicePeriod>
                </xsl:if>
                <xsl:if test=""s2:OrderLineReference"">
                  <OrderLineReference>
                    <LineID>
                      <xsl:value-of select=""s2:OrderLineReference/s3:LineID/text()"" />
                    </LineID>
                    <xsl:value-of select=""s2:OrderLineReference/text()"" />
                  </OrderLineReference>
                </xsl:if>
                <xsl:if test=""s2:DocumentReference/s3:ID"">
                  <DocumentReference>
                    <ID>
                      <xsl:value-of select=""s2:DocumentReference/s3:ID/text()"" />
                    </ID>
                    <xsl:if test=""s2:DocumentReference/s3:ID/@schemeID"">
                      <SchemeID>
                        <xsl:value-of select=""s2:DocumentReference/s3:ID/@schemeID"" />
                      </SchemeID>
                    </xsl:if>
                    <DocumentTypeCode>
                      <xsl:value-of select=""s2:DocumentReference/s3:DocumentTypeCode/text()"" />
                    </DocumentTypeCode>
                    <xsl:value-of select=""s2:DocumentReference/text()"" />
                  </DocumentReference>
                </xsl:if>
                <xsl:if test=""s2:AllowanceCharge"">
                  <AllowanceCharge>
                    <ChargeIndicator>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:ChargeIndicator/text()"" />
                    </ChargeIndicator>
                    <AllowanceChargeReasonCode>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:AllowanceChargeReasonCode/text()"" />
                    </AllowanceChargeReasonCode>
                    <AllowanceChargeReason>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:AllowanceChargeReason/text()"" />
                    </AllowanceChargeReason>
                    <MultiplierFactorNumeric>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:MultiplierFactorNumeric/text()"" />
                    </MultiplierFactorNumeric>
                    <Amount>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:Amount/text()"" />
                    </Amount>
                    <CurrencyIDA>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:Amount/@currencyID"" />
                    </CurrencyIDA>
                    <BaseAmount>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:BaseAmount/text()"" />
                    </BaseAmount>
                    <CurrencyIDB>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:BaseAmount/@currencyID"" />
                    </CurrencyIDB>
                    <xsl:value-of select=""s2:AllowanceCharge/text()"" />
                  </AllowanceCharge>
                </xsl:if>
                <Item>
                  <xsl:if test=""s2:Item/s3:Description"">
                    <Description>
                      <xsl:value-of select=""normalize-space(substring(s2:Item/s3:Description/text(),1,255))"" />
                    </Description>
                  </xsl:if>
                  <Name>
                    <xsl:value-of select=""normalize-space(substring(s2:Item/s3:Name/text(),1,255))"" />
                  </Name>
                  <xsl:if test=""s2:Item/s2:BuyersItemIdentification"">
                    <BuyersItemIdentification>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:BuyersItemIdentification/s3:ID/text()"" />
                      </ID>
                      <xsl:value-of select=""s2:Item/s2:BuyersItemIdentification/text()"" />
                    </BuyersItemIdentification>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:SellersItemIdentification"">
                    <SellersItemIdentification>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:SellersItemIdentification/s3:ID/text()"" />
                      </ID>
                      <xsl:value-of select=""s2:Item/s2:SellersItemIdentification/text()"" />
                    </SellersItemIdentification>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:StandardItemIdentification"">
                    <StandardItemIdentification>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:StandardItemIdentification/s3:ID/text()"" />
                      </ID>
                      <xsl:if test=""s2:Item/s2:StandardItemIdentification/s3:ID/@schemeID"">
                        <SchemeID>
                          <xsl:value-of select=""s2:Item/s2:StandardItemIdentification/s3:ID/@schemeID"" />
                        </SchemeID>
                      </xsl:if>
                      <xsl:value-of select=""s2:Item/s2:StandardItemIdentification/text()"" />
                    </StandardItemIdentification>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:OriginCountry"">
                    <OriginCountry>
                      <IdentificationCode>
                        <xsl:value-of select=""s2:Item/s2:OriginCountry/s3:IdentificationCode/text()"" />
                      </IdentificationCode>
                      <xsl:if test=""s2:Item/s2:OriginCountry/s3:IdentificationCode/@listID"">
                        <ListID>
                          <xsl:value-of select=""s2:Item/s2:OriginCountry/s3:IdentificationCode/@listID"" />
                        </ListID>
                      </xsl:if>
                      <xsl:value-of select=""s2:Item/s2:OriginCountry/text()"" />
                    </OriginCountry>
                  </xsl:if>
                  <xsl:if test=""(s2:Item/s2:CommodityClassification/s3:ItemClassificationCode/@listID !='')"">
                    <xsl:for-each select=""s2:Item/s2:CommodityClassification"">
                      <CommodityClassification>
                        <ItemClassificationCode>
                          <xsl:value-of select=""s3:ItemClassificationCode/text()"" />
                        </ItemClassificationCode>
                        <ListID>
                          <xsl:value-of select=""s3:ItemClassificationCode/@listID"" />
                        </ListID>
                        <xsl:value-of select=""./text()"" />
                      </CommodityClassification>
                    </xsl:for-each>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:ClassifiedTaxCategory"">
                    <ClassifiedTaxCategory>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s3:ID/text()"" />
                      </ID>
                      <Percent>
                        <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s3:Percent/text()"" />
                      </Percent>
                      <TaxScheme>
                        <ID>
                          <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s2:TaxScheme/s3:ID/text()"" />
                        </ID>
                        <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s2:TaxScheme/text()"" />
                      </TaxScheme>
                      <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/text()"" />
                    </ClassifiedTaxCategory>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:AdditionalItemProperty/s3:Name/text()"">
                    <AdditionalItemProperty>
                      <Name>
                        <xsl:value-of select=""s2:Item/s2:AdditionalItemProperty/s3:Name/text()"" />
                      </Name>
                      <Value>
                        <xsl:value-of select=""s2:Item/s2:AdditionalItemProperty/s3:Value/text()"" />
                      </Value>
                      <xsl:value-of select=""s2:Item/s2:AdditionalItemProperty/text()"" />
                    </AdditionalItemProperty>
                  </xsl:if>
                  <xsl:value-of select=""s2:Item/text()"" />
                </Item>
                <xsl:if test=""s2:Price/s3:PriceAmount"">
                  <Price>
                    <PriceAmount>
                      <xsl:value-of select=""s2:Price/s3:PriceAmount/text()"" />
                    </PriceAmount>
                    <CurrencyID>
                      <xsl:value-of select=""s2:Price/s3:PriceAmount/@currencyID"" />
                    </CurrencyID>
                    <xsl:if test=""s2:Price/s3:BaseQuantity"">
                      <BaseQuantity>
                        <xsl:value-of select=""s2:Price/s3:BaseQuantity/text()"" />
                      </BaseQuantity>
                    </xsl:if>
                    <AllowanceCharge>
                      <ChargeIndicator>
                        <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:ChargeIndicator/text()"" />
                      </ChargeIndicator>
                      <Amount>
                        <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:Amount/text()"" />
                      </Amount>
                      <CurrencyIDA>
                        <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:Amount/@currencyID"" />
                      </CurrencyIDA>
                      <BaseAmount>
                        <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:BaseAmount/text()"" />
                      </BaseAmount>
                      <CurrencyIDB>
                        <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:BaseAmount/@currencyID"" />
                      </CurrencyIDB>
                      <xsl:value-of select=""s2:Price/s2:AllowanceCharge/text()"" />
                    </AllowanceCharge>
                    <xsl:value-of select=""s2:Price/text()"" />
                  </Price>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </InvoiceLine>
            </xsl:for-each>
          </xsl:if>
          <xsl:value-of select=""s0:Invoice/text()"" />
        </Invoice>
      </xsl:if>
      <xsl:if test=""s4:CreditNote/s3:CreditNoteTypeCode/text() != ''"">
        <Invoice>
          <UBLVersionID>
            <xsl:value-of select=""s4:CreditNote/s3:UBLVersionID/text()"" />
          </UBLVersionID>
          <CustomizationID>
            <xsl:value-of select=""s4:CreditNote/s3:CustomizationID/text()"" />
          </CustomizationID>
          <ProfileID>
            <xsl:value-of select=""s4:CreditNote/s3:ProfileID/text()"" />
          </ProfileID>
          <ID>
            <xsl:value-of select=""s4:CreditNote/s3:ID/text()"" />
          </ID>
          <DocumentId>
            <xsl:value-of select=""$DocumentId"" />
          </DocumentId>
          <IssueDate>
            <xsl:value-of select=""s4:CreditNote/s3:IssueDate/text()"" />
          </IssueDate>
          <xsl:if test=""s4:CreditNote/s3:DueDate"">
            <DueDate>
              <xsl:value-of select=""s4:CreditNote/s3:DueDate/text()"" />
            </DueDate>
          </xsl:if>
          <InvoiceTypeCode>
            <xsl:value-of select=""s4:CreditNote/s3:CreditNoteTypeCode/text()"" />
          </InvoiceTypeCode>
          <Note>
            <xsl:value-of select=""substring(s4:CreditNote/s3:Note/text(),1,255)"" />
          </Note>
          <xsl:if test=""s4:CreditNote/s3:TaxPointDate"">
            <TaxPointDate>
              <xsl:value-of select=""s4:CreditNote/s3:TaxPointDate/text()"" />
            </TaxPointDate>
          </xsl:if>
          <DocumentCurrencyCode>
            <xsl:value-of select=""s4:CreditNote/s3:DocumentCurrencyCode/text()"" />
          </DocumentCurrencyCode>
          <TaxCurrencyCode>
            <xsl:value-of select=""s4:CreditNote/s3:TaxCurrencyCode/text()"" />
          </TaxCurrencyCode>
          <AccountingCost>
            <xsl:value-of select=""s4:CreditNote/s3:AccountingCost/text()"" />
          </AccountingCost>
          <BuyerReference>
            <xsl:value-of select=""s4:CreditNote/s3:BuyerReference/text()"" />
          </BuyerReference>
          <xsl:variable name=""Z"" select=""&quot;Z:&quot;"" />
          <xsl:variable name=""PeppolInbound"" select=""&quot;Peppol\Inbound&quot;"" />
          <xsl:variable name=""DocType"" select=""&quot;InvCN&quot;"" />
          <xsl:variable name=""BackSlash"" select=""&quot;\&quot;"" />

          <xsl:variable name=""PeppolInvoicePath"" select=""userCSharp:GetPeppolInvoicePath($Z,$DateToday,$PeppolInbound,$DocType,$BackSlash)"" />
          <InvoiceInPath>
            <xsl:value-of select=""$PeppolInvoicePath"" />
          </InvoiceInPath>
          <!--<xsl:variable name=""base64BinaryStr"" select=""string(s4:CreditNote/s2:AdditionalDocumentReference/s2:Attachment/s3:EmbeddedDocumentBinaryObject) ""/>
          <xsl:variable name=""mime"" select=""string(s4:CreditNote/s2:AdditionalDocumentReference/s2:Attachment/s3:EmbeddedDocumentBinaryObject/@mimeCode)""/>
          <xsl:variable name=""issueDate"" select=""string(s4:CreditNote/s3:IssueDate)""/>
          <xsl:variable name=""BU"" select=""string(s4:CreditNote/s3:BuyerReference/text())""/>
          <xsl:variable name=""CompanyId"" select=""string(s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text())""/>
          <xsl:variable name=""Invoice"" select=""string(s4:CreditNote/s3:ID/text())""/>
          <xsl:variable name=""DocType"" select=""&quot;CreditNote&quot;"" />
          <xsl:variable name=""path"" select=""userCSharp:GetAttachment($base64BinaryStr,$mime,$issueDate,$BU,$CompanyId,$Invoice,$DocType,$DocumentId)"" />
          <AttachmentPath>

            <xsl:value-of select=""$path"" />

          </AttachmentPath>-->
          <xsl:if test=""s4:CreditNote/s2:InvoicePeriod"">
            <InvoicePeriod>
              <StartDate>
                <xsl:value-of select=""s4:CreditNote/s2:InvoicePeriod/s3:StartDate/text()"" />
              </StartDate>
              <EndDate>
                <xsl:value-of select=""s4:CreditNote/s2:InvoicePeriod/s3:EndDate/text()"" />
              </EndDate>
              <DescriptionCode>
                <xsl:value-of select=""s4:CreditNote/s2:InvoicePeriod/s3:DescriptionCode/text()"" />
              </DescriptionCode>
              <xsl:value-of select=""s4:CreditNote/s2:InvoicePeriod/text()"" />
            </InvoicePeriod>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:OrderReference/s3:ID/text()"">
            <OrderReference>
              <ID>
                <xsl:value-of select=""s4:CreditNote/s2:OrderReference/s3:ID/text()"" />
              </ID>
              <SalesOrderID>
                <xsl:value-of select=""s4:CreditNote/s2:OrderReference/s3:SalesOrderID/text()"" />
              </SalesOrderID>
              <xsl:value-of select=""s4:CreditNote/s2:OrderReference/text()"" />
            </OrderReference>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:BillingReference/s2:InvoiceDocumentReference/s3:ID/text()"">
            <BillingReference>
              <InvoiceDocumentReference>
                <ID>
                  <xsl:value-of select=""s4:CreditNote/s2:BillingReference/s2:InvoiceDocumentReference/s3:ID/text()"" />
                </ID>
                <IssueDate>
                  <xsl:value-of select=""s4:CreditNote/s2:BillingReference/s2:InvoiceDocumentReference/s3:IssueDate/text()"" />
                </IssueDate>
                <xsl:value-of select=""s4:CreditNote/s2:BillingReference/s2:InvoiceDocumentReference/text()"" />
              </InvoiceDocumentReference>
              <xsl:value-of select=""s4:CreditNote/s2:BillingReference/text()"" />
            </BillingReference>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:DespatchDocumentReference/s3:ID/text()"">
            <DespatchDocumentReference>
              <ID>
                <xsl:value-of select=""s4:CreditNote/s2:DespatchDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s4:CreditNote/s2:DespatchDocumentReference/text()"" />
            </DespatchDocumentReference>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:ReceiptDocumentReference/s3:ID/text()"">
            <ReceiptDocumentReference>
              <ID>
                <xsl:value-of select=""s4:CreditNote/s2:ReceiptDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s4:CreditNote/s2:ReceiptDocumentReference/text()"" />
            </ReceiptDocumentReference>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:OriginatorDocumentReference/s3:ID/text()"">
            <OriginatorDocumentReference>
              <ID>
                <xsl:value-of select=""s4:CreditNote/s2:OriginatorDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s4:CreditNote/s2:OriginatorDocumentReference/text()"" />
            </OriginatorDocumentReference>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:ContractDocumentReference/s3:ID/text()"">
            <ContractDocumentReference>
              <ID>
                <xsl:value-of select=""s4:CreditNote/s2:ContractDocumentReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s4:CreditNote/s2:ContractDocumentReference/text()"" />
            </ContractDocumentReference>
          </xsl:if>
          <xsl:if test=""(s4:CreditNote/s2:AdditionalDocumentReference/s3:ID/text() !='')"">
            <xsl:for-each select=""s4:CreditNote/s2:AdditionalDocumentReference"">
              <AdditionalDocumentReference>
                <ID>
                  <xsl:value-of select=""s3:ID/text()"" />
                </ID>
                <xsl:if test=""s3:ID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s3:ID/@schemeID"" />
                  </SchemeID>
                </xsl:if>

                <xsl:if test=""s3:DocumentTypeCode/text()"">
                  <DocumentTypeCode>
                    <xsl:value-of select=""s3:DocumentTypeCode"" />
                  </DocumentTypeCode>
                </xsl:if>

                <DocumentDescription>
                  <xsl:value-of select=""s3:DocumentDescription/text()"" />
                </DocumentDescription>
                <Attachment>
                  <xsl:for-each select=""s2:Attachment/s2:ExternalReference"">
                    <ExternalReference>
                      <URI>
                        <xsl:value-of select=""s3:URI/text()"" />
                      </URI>
                      <xsl:value-of select=""./text()"" />
                    </ExternalReference>
                  </xsl:for-each>
                  <xsl:if test=""s2:Attachment/s3:EmbeddedDocumentBinaryObject"">
                    <EmbeddedDocumentBinaryObject>
                      <xsl:value-of select=""s2:Attachment/s3:EmbeddedDocumentBinaryObject/text()"" />
                    </EmbeddedDocumentBinaryObject>
                  </xsl:if>
                  <FileName>
                    <xsl:value-of select=""s2:Attachment/s3:EmbeddedDocumentBinaryObject/@filename"" />
                  </FileName>
                  <MimeCode>
                    <xsl:value-of select=""s2:Attachment/s3:EmbeddedDocumentBinaryObject/@mimeCode"" />
                  </MimeCode>
                  <xsl:variable name=""InvoiceNumber"" select=""userCSharp:ReplaceSpecialChars(string(../s3:ID/text()))""/>
                  <xsl:variable name=""BuyerReference"" select=""userCSharp:ReplaceSpecialChars(string(../s3:BuyerReference/text()))""/>
                  <xsl:variable name=""CompanyID"" select=""userCSharp:ReplaceSpecialChars(string(../s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text()))""/>

                  <xsl:variable name=""var:v1"" select=""userCSharp:GetAttachmentSize(string(s2:Attachment/s3:EmbeddedDocumentBinaryObject/text()) , string(s2:Attachment/s3:EmbeddedDocumentBinaryObject/@mimeCode) , string(../s3:IssueDate/text()) , $BuyerReference , $CompanyID , $InvoiceNumber)"" />
                  <xsl:variable name=""var:v2"" select=""userCSharp:AttachmentSize(string($var:v1))"" />
                  <!--<xsl:variable name=""var:v1"" select=""userCSharp:GetAttachmentSize(string(s2:Attachment/s3:EmbeddedDocumentBinaryObject/text()) , string(s2:Attachment/s3:EmbeddedDocumentBinaryObject/@mimeCode) , string(../s3:IssueDate/text()) , string(../s3:BuyerReference/text()) , string(../s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text()) , string(../s3:ID/text()))"" />-->
                  <!--<xsl:variable name=""var:v2"" select=""userCSharp:AttachmentSize(string($var:v1))"" />-->
                  <AttachmentSize>
                    <xsl:value-of select=""$var:v2"" />
                  </AttachmentSize>
                  <xsl:value-of select=""s2:Attachment/text()"" />
                </Attachment>
                <xsl:value-of select=""./text()"" />
              </AdditionalDocumentReference>
            </xsl:for-each>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:ProjectReference/s3:ID/text()"">
            <ProjectReference>
              <ID>
                <xsl:value-of select=""s4:CreditNote/s2:ProjectReference/s3:ID/text()"" />
              </ID>
              <xsl:value-of select=""s4:CreditNote/s2:ProjectReference/text()"" />
            </ProjectReference>
          </xsl:if>
          <xsl:if test=""(s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s3:EndpointID/text() !='') and (s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text() !='')"">
            <AccountingSupplierParty>
              <Party>
                <EndpointID>
                  <xsl:value-of select=""normalize-space(s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s3:EndpointID/text())"" />
                </EndpointID>
                <SchemeID>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s3:EndpointID/@schemeID"" />
                </SchemeID>
                <xsl:for-each select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyIdentification"">
                  <PartyIdentification>
                    <ID>
                      <xsl:value-of select=""s3:ID/text()"" />
                    </ID>
                    <xsl:if test=""s3:ID/@schemeID"">
                      <SchemeID>
                        <xsl:value-of select=""s3:ID/@schemeID"" />
                      </SchemeID>
                    </xsl:if>
                    <xsl:value-of select=""./text()"" />
                  </PartyIdentification>
                </xsl:for-each>
                <PartyName>
                  <Name>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyName/s3:Name/text()"" />
                  </Name>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyName/text()"" />
                </PartyName>
                <PostalAddress>
                  <StreetName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:StreetName/text()"" />
                  </StreetName>
                  <AdditionalStreetName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:AdditionalStreetName/text()"" />
                  </AdditionalStreetName>
                  <CityName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:CityName/text()"" />
                  </CityName>
                  <PostalZone>
                    <xsl:value-of select=""substring(s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:PostalZone/text(),1,20)"" />
                  </PostalZone>
                  <CountrySubentity>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s3:CountrySubentity/text()"" />
                  </CountrySubentity>
                  <AddressLine>
                    <Line>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:AddressLine/s3:Line/text()"" />
                    </Line>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:AddressLine/text()"" />
                  </AddressLine>
                  <Country>
                    <IdentificationCode>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:Country/s3:IdentificationCode/text()"" />
                    </IdentificationCode>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/s2:Country/text()"" />
                  </Country>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PostalAddress/text()"" />
                </PostalAddress>
                <PartyTaxScheme>
                  <CompanyID>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/s3:CompanyID/text()"" />
                  </CompanyID>
                  <TaxScheme>
                    <ID>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/s3:ID/text()"" />
                    </ID>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/text()"" />
                  </TaxScheme>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyTaxScheme/text()"" />
                </PartyTaxScheme>
                <PartyLegalEntity>
                  <RegistrationName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text()"" />
                  </RegistrationName>
                  <CompanyID>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text()"" />
                  </CompanyID>
                  <xsl:if test=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"">
                    <SchemeID>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"" />
                    </SchemeID>
                  </xsl:if>
                  <CompanyLegalForm>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/s3:CompanyLegalForm/text()"" />
                  </CompanyLegalForm>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:PartyLegalEntity/text()"" />
                </PartyLegalEntity>
                <Contact>
                  <Name>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:Contact/s3:Name/text()"" />
                  </Name>
                  <Telephone>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:Contact/s3:Telephone/text()"" />
                  </Telephone>
                  <ElectronicMail>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:Contact/s3:ElectronicMail/text()"" />
                  </ElectronicMail>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/s2:Party/s2:Contact/text()"" />
                </Contact>
                <xsl:value-of select=""s4:Invoice/s2:AccountingSupplierParty/s2:Party/text()"" />
              </Party>
              <xsl:value-of select=""s4:CreditNote/s2:AccountingSupplierParty/text()"" />
            </AccountingSupplierParty>
          </xsl:if>
          <xsl:if test=""(s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s3:EndpointID/text() !='') and (s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text() != '')"">
            <AccountingCustomerParty>
              <Party>
                <EndpointID>
                  <xsl:value-of select=""normalize-space(s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s3:EndpointID/text())"" />
                </EndpointID>
                <SchemeID>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s3:EndpointID/@schemeID"" />
                </SchemeID>
                <PartyIdentification>
                  <ID>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/s3:ID/text()"" />
                  </ID>
                  <xsl:if test=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/s3:ID/@schemeID"">
                    <SchemeID>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/s3:ID/@schemeID"" />
                    </SchemeID>
                  </xsl:if>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyIdentification/text()"" />
                </PartyIdentification>
                <PartyName>
                  <Name>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyName/s3:Name/text()"" />
                  </Name>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyName/text()"" />
                </PartyName>
                <PostalAddress>
                  <StreetName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:StreetName/text()"" />
                  </StreetName>
                  <AdditionalStreetName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:AdditionalStreetName/text()"" />
                  </AdditionalStreetName>
                  <CityName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:CityName/text()"" />
                  </CityName>
                  <PostalZone>
                    <xsl:value-of select=""substring(s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:PostalZone/text(),1,20)"" />
                  </PostalZone>
                  <CountrySubentity>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s3:CountrySubentity/text()"" />
                  </CountrySubentity>
                  <AddressLine>
                    <Line>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:AddressLine/s3:Line/text()"" />
                    </Line>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:AddressLine/text()"" />
                  </AddressLine>
                  <Country>
                    <IdentificationCode>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:Country/s3:IdentificationCode/text()"" />
                    </IdentificationCode>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/s2:Country/text()"" />
                  </Country>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PostalAddress/text()"" />
                </PostalAddress>
                <PartyTaxScheme>
                  <CompanyID>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/s3:CompanyID/text()"" />
                  </CompanyID>
                  <TaxScheme>
                    <ID>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/s3:ID/text()"" />
                    </ID>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/s2:TaxScheme/text()"" />
                  </TaxScheme>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyTaxScheme/text()"" />
                </PartyTaxScheme>
                <PartyLegalEntity>
                  <RegistrationName>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:RegistrationName/text()"" />
                  </RegistrationName>
                  <CompanyID>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/text()"" />
                  </CompanyID>
                  <xsl:if test=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"">
                    <SchemeID>
                      <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/s3:CompanyID/@schemeID"" />
                    </SchemeID>
                  </xsl:if>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:PartyLegalEntity/text()"" />
                </PartyLegalEntity>
                <Contact>
                  <Name>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:Contact/s3:Name/text()"" />
                  </Name>
                  <Telephone>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:Contact/s3:Telephone/text()"" />
                  </Telephone>
                  <ElectronicMail>
                    <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:Contact/s3:ElectronicMail/text()"" />
                  </ElectronicMail>
                  <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/s2:Contact/text()"" />
                </Contact>
                <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/s2:Party/text()"" />
              </Party>
              <xsl:value-of select=""s4:CreditNote/s2:AccountingCustomerParty/text()"" />
            </AccountingCustomerParty>
          </xsl:if>
          <xsl:if test=""(s4:CreditNote/s2:PayeeParty/s4:Invoice/s2:PayeeParty/s2:PartyIdentification/s3:ID/text() !='') and (s4:CreditNote/s2:PayeeParty/s2:PartyName/s3:Name/text() !='')"">
            <PayeeParty>
              <PartyIdentification>
                <ID>
                  <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyIdentification/s3:ID/text()"" />
                </ID>
                <xsl:if test=""s4:CreditNote/s2:PayeeParty/s2:PartyIdentification/s3:ID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyIdentification/s3:ID/@schemeID"" />
                  </SchemeID>
                </xsl:if>
                <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyIdentification/text()"" />
              </PartyIdentification>
              <PartyName>
                <Name>
                  <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyName/s3:Name/text()"" />
                </Name>
                <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyName/text()"" />
              </PartyName>
              <PartyLegalEntity>
                <CompanyID>
                  <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyLegalEntity/s3:CompanyID/text()"" />
                </CompanyID>
                <xsl:if test=""s4:CreditNote/s2:PayeeParty/s2:PartyLegalEntity/s3:CompanyID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyLegalEntity/s3:CompanyID/@schemeID"" />
                  </SchemeID>
                </xsl:if>
                <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/s2:PartyLegalEntity/text()"" />
              </PartyLegalEntity>
              <xsl:value-of select=""s4:CreditNote/s2:PayeeParty/text()"" />
            </PayeeParty>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PartyName/text()"">
            <TaxRepresentativeParty>
              <PartyName>
                <Name>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PartyName/s3:Name/text()"" />
                </Name>
                <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PartyName/text()"" />
              </PartyName>
              <PostalAddress>
                <StreetName>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s3:StreetName/text()"" />
                </StreetName>
                <AdditionalStreetName>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s3:AdditionalStreetName/text()"" />
                </AdditionalStreetName>
                <CityName>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s3:CityName/text()"" />
                </CityName>
                <PostalZone>
                  <xsl:value-of select=""substring(s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s3:PostalZone/text(),1,20)"" />
                </PostalZone>
                <CountrySubentity>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s3:CountrySubentity/text()"" />
                </CountrySubentity>
                <AddressLine>
                  <Line>
                    <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s2:AddressLine/s3:Line/text()"" />
                  </Line>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s2:AddressLine/text()"" />
                </AddressLine>
                <Country>
                  <IdentificationCode>
                    <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s2:Country/s3:IdentificationCode/text()"" />
                  </IdentificationCode>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/s2:Country/text()"" />
                </Country>
                <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PostalAddress/text()"" />
              </PostalAddress>
              <PartyTaxScheme>
                <CompanyID>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PartyTaxScheme/s3:CompanyID/text()"" />
                </CompanyID>
                <TaxScheme>
                  <ID>
                    <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PartyTaxScheme/s2:TaxScheme/s3:ID/text()"" />
                  </ID>
                  <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PartyTaxScheme/s2:TaxScheme/text()"" />
                </TaxScheme>
                <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/s2:PartyTaxScheme/text()"" />
              </PartyTaxScheme>
              <xsl:value-of select=""s4:CreditNote/s2:TaxRepresentativeParty/text()"" />
            </TaxRepresentativeParty>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:Delivery"">
            <Delivery>
              <ActualDeliveryDate>
                <xsl:value-of select=""s4:CreditNote/s2:Delivery/s3:ActualDeliveryDate/text()"" />
              </ActualDeliveryDate>
              <DeliveryLocation>
                <ID>
                  <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s3:ID/text()"" />
                </ID>
                <xsl:if test=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s3:ID/@schemeID"">
                  <SchemeID>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s3:ID/@schemeID"" />
                  </SchemeID>
                </xsl:if>
                <Address>
                  <StreetName>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:StreetName/text()"" />
                  </StreetName>
                  <AdditionalStreetName>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:AdditionalStreetName/text()"" />
                  </AdditionalStreetName>
                  <CityName>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:CityName/text()"" />
                  </CityName>
                  <PostalZone>
                    <xsl:value-of select=""substring(s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:PostalZone/text(),1,20)"" />
                  </PostalZone>
                  <CountrySubentity>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s3:CountrySubentity/text()"" />
                  </CountrySubentity>
                  <AddressLine>
                    <Line>
                      <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:AddressLine/s3:Line/text()"" />
                    </Line>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:AddressLine/text()"" />
                  </AddressLine>
                  <Country>
                    <IdentificationCode>
                      <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:Country/s3:IdentificationCode/text()"" />
                    </IdentificationCode>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/s2:Country/text()"" />
                  </Country>
                  <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/s2:Address/text()"" />
                </Address>
                <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryLocation/text()"" />
              </DeliveryLocation>
              <DeliveryParty>
                <PartyName>
                  <Name>
                    <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryParty/s2:PartyName/s3:Name/text()"" />
                  </Name>
                  <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryParty/s2:PartyName/text()"" />
                </PartyName>
                <xsl:value-of select=""s4:CreditNote/s2:Delivery/s2:DeliveryParty/text()"" />
              </DeliveryParty>
              <xsl:value-of select=""s4:CreditNote/s2:Delivery/text()"" />
            </Delivery>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:PaymentMeans/s3:PaymentMeansCode/text()"">
            <PaymentMeans>
              <PaymentMeansCode>
                <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s3:PaymentMeansCode/text()"" />
              </PaymentMeansCode>
              <Name>
                <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s3:PaymentMeansCode/@name"" />
              </Name>
              <PaymentID>
                <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s3:PaymentID/text()"" />
              </PaymentID>
              <CardAccount>
                <PrimaryAccountNumberID>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:CardAccount/s3:PrimaryAccountNumberID/text()"" />
                </PrimaryAccountNumberID>
                <NetworkID>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:CardAccount/s3:NetworkID/text()"" />
                </NetworkID>
                <HolderName>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:CardAccount/s3:HolderName/text()"" />
                </HolderName>
                <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:CardAccount/text()"" />
              </CardAccount>
              <PayeeFinancialAccount>
                <ID>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PayeeFinancialAccount/s3:ID/text()"" />
                </ID>
                <Name>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PayeeFinancialAccount/s3:Name/text()"" />
                </Name>
                <FinancialInstitutionBranch>
                  <ID>
                    <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PayeeFinancialAccount/s2:FinancialInstitutionBranch/s3:ID/text()"" />
                  </ID>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PayeeFinancialAccount/s2:FinancialInstitutionBranch/text()"" />
                </FinancialInstitutionBranch>
                <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PayeeFinancialAccount/text()"" />
              </PayeeFinancialAccount>
              <PaymentMandate>
                <ID>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PaymentMandate/s3:ID/text()"" />
                </ID>
                <PayerFinancialAccount>
                  <ID>
                    <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PaymentMandate/s2:PayerFinancialAccount/s3:ID/text()"" />
                  </ID>
                  <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PaymentMandate/s2:PayerFinancialAccount/text()"" />
                </PayerFinancialAccount>
                <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/s2:PaymentMandate/text()"" />
              </PaymentMandate>
              <xsl:value-of select=""s4:CreditNote/s2:PaymentMeans/text()"" />
            </PaymentMeans>
          </xsl:if>
          <xsl:if test=""s4:CreditNote/s2:PaymentTerms/s3:Note/text()"">
            <PaymentTerms>
              <Note>
                <xsl:value-of select=""s4:CreditNote/s2:PaymentTerms/s3:Note/text()"" />
              </Note>
              <xsl:value-of select=""s4:CreditNote/s2:PaymentTerms/text()"" />
            </PaymentTerms>
          </xsl:if>
          <xsl:if test=""(s4:CreditNote/s2:AllowanceCharge/s3:ChargeIndicator/text() !='') and (s4:CreditNote/s2:AllowanceCharge/s3:Amount/text() !='') and (s4:CreditNote/s2:AllowanceCharge/s3:Amount/@currencyID !='')"">
            <AllowanceCharge>
              <ChargeIndicator>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:ChargeIndicator/text()"" />
              </ChargeIndicator>
              <AllowanceChargeReasonCode>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:AllowanceChargeReasonCode/text()"" />
              </AllowanceChargeReasonCode>
              <AllowanceChargeReason>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:AllowanceChargeReason/text()"" />
              </AllowanceChargeReason>
              <MultiplierFactorNumeric>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:MultiplierFactorNumeric/text()"" />
              </MultiplierFactorNumeric>
              <Amount>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:Amount/text()"" />
              </Amount>
              <CurrencyIDA>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:Amount/@currencyID"" />
              </CurrencyIDA>
              <BaseAmount>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:BaseAmount/text()"" />
              </BaseAmount>
              <CurrencyIDB>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s3:BaseAmount/@currencyID"" />
              </CurrencyIDB>
              <TaxCategory>
                <ID>
                  <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s2:TaxCategory/s3:ID/text()"" />
                </ID>
                <Percent>
                  <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s2:TaxCategory/s3:Percent/text()"" />
                </Percent>
                <TaxScheme>
                  <ID>
                    <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s2:TaxCategory/s2:TaxScheme/s3:ID/text()"" />
                  </ID>
                  <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s2:TaxCategory/s2:TaxScheme/text()"" />
                </TaxScheme>
                <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/s2:TaxCategory/text()"" />
              </TaxCategory>
              <xsl:value-of select=""s4:CreditNote/s2:AllowanceCharge/text()"" />
            </AllowanceCharge>
          </xsl:if>
          <xsl:if test=""(s4:CreditNote/s2:TaxTotal/s3:TaxAmount/text() !='') and (s4:CreditNote/s2:TaxTotal/s3:TaxAmount/@currencyID !='')"">
            <xsl:for-each select=""s4:CreditNote/s2:TaxTotal"">
              <TaxTotal>
                <TaxAmount>
                  <xsl:value-of select=""s3:TaxAmount/text()"" />
                </TaxAmount>
                <CurrencyID>
                  <xsl:value-of select=""s3:TaxAmount/@currencyID"" />
                </CurrencyID>
                <xsl:if test=""(s2:TaxSubtotal/s3:TaxableAmount/@currencyID) and (s2:TaxSubtotal/s3:TaxAmount/@currencyID)"">
                  <xsl:for-each select=""s2:TaxSubtotal"">
                    <TaxSubtotal>
                      <TaxableAmount>
                        <xsl:value-of select=""s3:TaxableAmount/text()"" />
                      </TaxableAmount>
                      <CurrencyIDA1>
                        <xsl:value-of select=""s3:TaxableAmount/@currencyID"" />
                      </CurrencyIDA1>
                      <TaxAmount>
                        <xsl:value-of select=""s3:TaxAmount/text()"" />
                      </TaxAmount>
                      <CurrencyIDA2>
                        <xsl:value-of select=""s3:TaxAmount/@currencyID"" />
                      </CurrencyIDA2>
                      <TaxCategory>
                        <ID>
                          <xsl:value-of select=""s2:TaxCategory/s3:ID/text()"" />
                        </ID>
                        <Percent>
                          <xsl:value-of select=""s2:TaxCategory/s3:Percent/text()"" />
                        </Percent>
                        <TaxExemptionReasonCode>
                          <xsl:value-of select=""s2:TaxCategory/s3:TaxExemptionReasonCode/text()"" />
                        </TaxExemptionReasonCode>
                        <TaxExemptionReason>
                          <xsl:value-of select=""s2:TaxCategory/s3:TaxExemptionReason/text()"" />
                        </TaxExemptionReason>
                        <TaxScheme>
                          <ID>
                            <xsl:value-of select=""s2:TaxCategory/s2:TaxScheme/s3:ID/text()"" />
                          </ID>
                          <xsl:value-of select=""s2:TaxCategory/s2:TaxScheme/text()"" />
                        </TaxScheme>
                        <xsl:value-of select=""s2:TaxCategory/text()"" />
                      </TaxCategory>
                      <xsl:value-of select=""./text()"" />
                    </TaxSubtotal>
                  </xsl:for-each>
                </xsl:if>
                <xsl:value-of select=""./text()"" />
              </TaxTotal>
            </xsl:for-each>
          </xsl:if>
          <xsl:if test=""(s4:CreditNote/s2:LegalMonetaryTotal/s3:LineExtensionAmount/text() !='') and (s4:CreditNote/s2:LegalMonetaryTotal/s3:LineExtensionAmount/@currencyID !='') and (s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/text() !='') and (s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/@currencyID !='') and (s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/text() !='') and (s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/@currencyID !='')"">
            <LegalMonetaryTotal>
              <LineExtensionAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:LineExtensionAmount/text()"" />
              </LineExtensionAmount>
              <CurrencyIDL>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:LineExtensionAmount/@currencyID"" />
              </CurrencyIDL>
              <TaxExclusiveAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/text()"" />
              </TaxExclusiveAmount>
              <CurrencyIDT1>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxExclusiveAmount/@currencyID"" />
              </CurrencyIDT1>
              <TaxInclusiveAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/text()"" />
              </TaxInclusiveAmount>
              <CurrencyIDT2>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:TaxInclusiveAmount/@currencyID"" />
              </CurrencyIDT2>
              <AllowanceTotalAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:AllowanceTotalAmount/text()"" />
              </AllowanceTotalAmount>
              <CurrencyIDA>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:AllowanceTotalAmount/@currencyID"" />
              </CurrencyIDA>
              <ChargeTotalAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:ChargeTotalAmount/text()"" />
              </ChargeTotalAmount>
              <CurrencyIDC>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:ChargeTotalAmount/@currencyID"" />
              </CurrencyIDC>
              <PrepaidAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:PrepaidAmount/text()"" />
              </PrepaidAmount>
              <CurrencyIDP1>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:PrepaidAmount/@currencyID"" />
              </CurrencyIDP1>
              <PayableRoundingAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:PayableRoundingAmount/text()"" />
              </PayableRoundingAmount>
              <CurrencyIDP2>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:PayableRoundingAmount/@currencyID"" />
              </CurrencyIDP2>
              <PayableAmount>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:PayableAmount/text()"" />
              </PayableAmount>
              <CurrencyIDP3>
                <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/s3:PayableAmount/@currencyID"" />
              </CurrencyIDP3>
              <xsl:value-of select=""s4:CreditNote/s2:LegalMonetaryTotal/text()"" />
            </LegalMonetaryTotal>
          </xsl:if>
          
          <xsl:if test=""s4:CreditNote/s2:CreditNoteLine/s3:ID/text()"">
            <xsl:for-each select=""s4:CreditNote/s2:CreditNoteLine"">
              <InvoiceLine>
                <ID>
                  <xsl:value-of select=""s3:ID/text()"" />
                </ID>
                <Note>
                  <xsl:value-of select=""substring(s3:Note/text(),1,255)"" />
                </Note>
                <InvoicedQuantity>
                  <xsl:value-of select=""s3:CreditedQuantity/text()"" />
                </InvoicedQuantity>
                <UnitCode>
                  <xsl:value-of select=""s3:CreditedQuantity/@unitCode"" />
                </UnitCode>
                <LineExtensionAmount>
                  <xsl:value-of select=""s3:LineExtensionAmount/text()"" />
                </LineExtensionAmount>
                <CurrencyID>
                  <xsl:value-of select=""s3:LineExtensionAmount/@currencyID"" />
                </CurrencyID>
                <AccountingCost>
                  <xsl:value-of select=""s3:AccountingCost/text()"" />
                </AccountingCost>
                <xsl:if test=""s2:InvoicePeriod/s3:StartDate"">
                <InvoicePeriod>
                  <StartDate>
                    <xsl:value-of select=""s2:InvoicePeriod/s3:StartDate/text()"" />
                  </StartDate>
                  <EndDate>
                    <xsl:value-of select=""s2:InvoicePeriod/s3:EndDate/text()"" />
                  </EndDate>
                  <xsl:value-of select=""s2:InvoicePeriod/text()"" />
                </InvoicePeriod>
                </xsl:if>
                <OrderLineReference>
                  <LineID>
                    <xsl:value-of select=""s2:OrderLineReference/s3:LineID/text()"" />
                  </LineID>
                  <xsl:value-of select=""s2:OrderLineReference/text()"" />
                </OrderLineReference>
                <xsl:if test=""s2:DocumentReference/s3:ID"">
                <DocumentReference>
                  <ID>
                    <xsl:value-of select=""s2:DocumentReference/s3:ID/text()"" />
                  </ID>
                  <xsl:if test=""s2:DocumentReference/s3:ID/@schemeID"">
                    <SchemeID>
                      <xsl:value-of select=""s2:DocumentReference/s3:ID/@schemeID"" />
                    </SchemeID>
                  </xsl:if>
                  <DocumentTypeCode>
                    <xsl:value-of select=""s2:DocumentReference/s3:DocumentTypeCode/text()"" />
                  </DocumentTypeCode>
                  <xsl:value-of select=""s2:DocumentReference/text()"" />
                </DocumentReference>
                </xsl:if>
                <xsl:if test=""s2:AllowanceCharge"">
                  <AllowanceCharge>
                    <ChargeIndicator>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:ChargeIndicator/text()"" />
                    </ChargeIndicator>
                    <AllowanceChargeReasonCode>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:AllowanceChargeReasonCode/text()"" />
                    </AllowanceChargeReasonCode>
                    <AllowanceChargeReason>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:AllowanceChargeReason/text()"" />
                    </AllowanceChargeReason>
                    <MultiplierFactorNumeric>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:MultiplierFactorNumeric/text()"" />
                    </MultiplierFactorNumeric>
                    <Amount>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:Amount/text()"" />
                    </Amount>
                    <CurrencyIDA>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:Amount/@currencyID"" />
                    </CurrencyIDA>
                    <BaseAmount>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:BaseAmount/text()"" />
                    </BaseAmount>
                    <CurrencyIDB>
                      <xsl:value-of select=""s2:AllowanceCharge/s3:BaseAmount/@currencyID"" />
                    </CurrencyIDB>
                    <xsl:value-of select=""s2:AllowanceCharge/text()"" />
                  </AllowanceCharge>
                </xsl:if>
                <Item>
                  <Description>
                    <xsl:value-of select=""normalize-space(substring(s2:Item/s3:Description/text(),1,255))"" />
                  </Description>
                  <Name>
                    <xsl:value-of select=""normalize-space(substring(s2:Item/s3:Name/text(),1,255))"" />
                  </Name>
                  <xsl:if test=""s2:Item/s2:BuyersItemIdentification"">
                    <BuyersItemIdentification>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:BuyersItemIdentification/s3:ID/text()"" />
                      </ID>
                      <xsl:value-of select=""s2:Item/s2:BuyersItemIdentification/text()"" />
                    </BuyersItemIdentification>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:SellersItemIdentification"">
                    <SellersItemIdentification>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:SellersItemIdentification/s3:ID/text()"" />
                      </ID>
                      <xsl:value-of select=""s2:Item/s2:SellersItemIdentification/text()"" />
                    </SellersItemIdentification>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:StandardItemIdentification"">
                    <StandardItemIdentification>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:StandardItemIdentification/s3:ID/text()"" />
                      </ID>
                      <xsl:if test=""s2:Item/s2:StandardItemIdentification/s3:ID/@schemeID"">
                        <SchemeID>
                          <xsl:value-of select=""s2:Item/s2:StandardItemIdentification/s3:ID/@schemeID"" />
                        </SchemeID>
                      </xsl:if>
                      <xsl:value-of select=""s2:Item/s2:StandardItemIdentification/text()"" />
                    </StandardItemIdentification>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:OriginCountry"">
                    <OriginCountry>
                      <IdentificationCode>
                        <xsl:value-of select=""s2:Item/s2:OriginCountry/s3:IdentificationCode/text()"" />
                      </IdentificationCode>
                      <xsl:if test=""s2:Item/s2:OriginCountry/s3:IdentificationCode/@listID"">
                        <ListID>
                          <xsl:value-of select=""s2:Item/s2:OriginCountry/s3:IdentificationCode/@listID"" />
                        </ListID>
                      </xsl:if>
                      <xsl:value-of select=""s2:Item/s2:OriginCountry/text()"" />
                    </OriginCountry>
                  </xsl:if>
                  <xsl:if test=""(s2:Item/s2:CommodityClassification/s3:ItemClassificationCode/@listID !='')"">
                    <xsl:for-each select=""s2:Item/s2:CommodityClassification"">
                      <CommodityClassification>
                        <ItemClassificationCode>
                          <xsl:value-of select=""s3:ItemClassificationCode/text()"" />
                        </ItemClassificationCode>
                        <ListID>
                          <xsl:value-of select=""s3:ItemClassificationCode/@listID"" />
                        </ListID>
                        <xsl:value-of select=""./text()"" />
                      </CommodityClassification>
                    </xsl:for-each>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:ClassifiedTaxCategory"">
                    <ClassifiedTaxCategory>
                      <ID>
                        <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s3:ID/text()"" />
                      </ID>
                      <Percent>
                        <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s3:Percent/text()"" />
                      </Percent>
                      <TaxScheme>
                        <ID>
                          <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s2:TaxScheme/s3:ID/text()"" />
                        </ID>
                        <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/s2:TaxScheme/text()"" />
                      </TaxScheme>
                      <xsl:value-of select=""s2:Item/s2:ClassifiedTaxCategory/text()"" />
                    </ClassifiedTaxCategory>
                  </xsl:if>
                  <xsl:if test=""s2:Item/s2:AdditionalItemProperty/s3:Name/text()"">
                    <AdditionalItemProperty>
                      <Name>
                        <xsl:value-of select=""s2:Item/s2:AdditionalItemProperty/s3:Name/text()"" />
                      </Name>
                      <Value>
                        <xsl:value-of select=""s2:Item/s2:AdditionalItemProperty/s3:Value/text()"" />
                      </Value>
                      <xsl:value-of select=""s2:Item/s2:AdditionalItemProperty/text()"" />
                    </AdditionalItemProperty>
                  </xsl:if>
                  <xsl:value-of select=""s2:Item/text()"" />
                </Item>
                
                <xsl:if test=""s2:Price/s3:PriceAmount"">
                  <Price>
                    <PriceAmount>
                      <xsl:value-of select=""s2:Price/s3:PriceAmount/text()"" />
                    </PriceAmount>
                    <CurrencyID>
                      <xsl:value-of select=""s2:Price/s3:PriceAmount/@currencyID"" />
                    </CurrencyID>
                    <xsl:if test=""s2:Price/s3:BaseQuantity"">
                      <BaseQuantity>
                        <xsl:value-of select=""s2:Price/s3:BaseQuantity/text()"" />
                      </BaseQuantity>
                    </xsl:if>
                    <xsl:if test=""s2:Price/s2:AllowanceCharge"">
                      <AllowanceCharge>
                        <ChargeIndicator>
                          <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:ChargeIndicator/text()"" />
                        </ChargeIndicator>
                        <Amount>
                          <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:Amount/text()"" />
                        </Amount>
                        <CurrencyIDA>
                          <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:Amount/@currencyID"" />
                        </CurrencyIDA>
                        <BaseAmount>
                          <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:BaseAmount/text()"" />
                        </BaseAmount>
                        <CurrencyIDB>
                          <xsl:value-of select=""s2:Price/s2:AllowanceCharge/s3:BaseAmount/@currencyID"" />
                        </CurrencyIDB>
                        <xsl:value-of select=""s2:Price/s2:AllowanceCharge/text()"" />
                      </AllowanceCharge>
                    </xsl:if>
                    <!--<xsl:value-of select=""s2:Price/text()"" />-->
                  </Price>
                </xsl:if>
                <!--<xsl:value-of select=""./text()"" />-->
              </InvoiceLine>

            </xsl:for-each>
          </xsl:if>
          <!--<xsl:value-of select=""s0:Invoice/text()"" />-->
        </Invoice>
      </xsl:if>
      <xsl:value-of select=""./text()"" />
    </ns0:StandardBusinessDocument>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[

public string DateCurrentDate()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
}

public string DateToday()
{
	DateTime dt = DateTime.Now;
	return dt.ToString(""yyyyMMdd"", System.Globalization.CultureInfo.InvariantCulture);
}

public string AttachmentSize(string param1)
{
	if(param1 == """")
{
return ""0"";
}
return param1;
}

public string GetAttachmentSize(string base64BinaryStr, string mime, string issueDate, string BU, string CompanyId,string Invoice)
        {

            long l = 0;            
            string format = GetFileFormat(mime);
            if (format != ""false"")
            {
                string baseDir="""";
                string MachineName=System.Environment.MachineName;
                if(MachineName ==""SPBTSUA16S"")
                  {
                   baseDir = @""\\UGTPDBS01\FileStore\BTS\PEPPOL\AGD\InBound\AttachmentLive"";
                  }
                  if(MachineName ==""SPBTSPA16S"")
                  {
                   baseDir = @""\\CSFS\FileStore\BTS\PEPPOL\AGD\InBound\AttachmentLive"";
                  }
                  if(MachineName ==""BIZTALKDEV"")
                  {
                   baseDir = @""\\DGTPDBS01\FileStore\BTS\PEPPOL\AGD\InBound\AttachmentLive"";
                  }

                string fileName = Invoice+""_"" + issueDate + ""_"" + BU + ""_"" + CompanyId + ""."" + format;
                string path = System.IO.Path.Combine(baseDir, fileName);
                byte[] bytes = Convert.FromBase64String(base64BinaryStr);
                System.IO.FileStream stream = new System.IO.FileStream(@path, System.IO.FileMode.CreateNew);
                System.IO.BinaryWriter writer = new System.IO.BinaryWriter(stream);
                writer.Write(bytes, 0, bytes.Length);
                writer.Close();

                long length = new System.IO.FileInfo(path).Length;
                System.IO.File.Delete(path);
                l = length;
            }
            return l.ToString();
        }
        
        public string GetFileFormat(string mime)
        {

            if (mime == ""application/pdf"")
            {
                string pdf = ""pdf"";
                return pdf;
            }
            if (mime == ""image/png"")
            {
                string png = ""png"";
                return png;
            }
            if (mime == ""image/jpeg"")
            {
                string jpeg = ""jpeg"";
                return jpeg;
            }
            if (mime == ""text/csv"")
            {
                string txt = ""txt"";
                return txt;
            }
            if (mime == ""application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"")
            {
                string xlsx = ""xlsx"";
                return xlsx;
            }
            if (mime == ""application/vnd.oasis.opendocument.spreadsheet"")
            {
                string ods = ""ods"";
                return ods;
            }
            return ""false"";
        }
        public string GetGUID()
        {
            return System.Guid.NewGuid().ToString();
        }

 public string GetPeppolInvoicePath(string Z,string DateCurrentDate, string PeppolInbound, string DocType, string BackSlash)
                {
                    return Z + BackSlash + DateCurrentDate+ BackSlash+ PeppolInbound + BackSlash + DocType + BackSlash;
                }
   public string ReplaceSpecialChars(string InvoiceNumber)
        {
            return System.Text.RegularExpressions.Regex.Replace(InvoiceNumber, ""[^a-zA-Z0-9_.]+"", ""-"", System.Text.RegularExpressions.RegexOptions.Compiled);
        }
        public string ReturnElectronicEmail(string ContactMail)
        {
            if (ContactMail.Length > 100)
            {
                string ElectronicMail = ContactMail.Substring(0, 100);
                ElectronicMail = ElectronicMail.Remove(ElectronicMail.LastIndexOf(';')) + ';';

                return ElectronicMail;
            }
            return ContactMail;

        }
       public string PrintLog(string keyname,string param)
       {
        System.Diagnostics.EventLog.WriteEntry(keyname,param);
        return ""OK"";
       }
]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Sp.PCFPeppol.Schemas.PeppolInput";
        
        private const global::Sp.PCFPeppol.Schemas.PeppolInput _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Sp.PCFPeppol.Schemas.PCFPeppolInternalXML";
        
        private const global::Sp.PCFPeppol.Schemas.PCFPeppolInternalXML _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Sp.PCFPeppol.Schemas.PeppolInput";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Sp.PCFPeppol.Schemas.PCFPeppolInternalXML";
                return _TrgSchemas;
            }
        }
    }
}
