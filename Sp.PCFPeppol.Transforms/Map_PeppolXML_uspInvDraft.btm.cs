namespace Sp.PCFPeppol.Transforms {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.uspPCFInvoiceDraft_TypedProcedure_dbo+InterfacePCFPeppolInvoiceDraft", typeof(global::Sp.PCFPeppol.Schemas.uspPCFInvoiceDraft_TypedProcedure_dbo.InterfacePCFPeppolInvoiceDraft))]
    public sealed class Map_PeppolXML_uspInvDraft : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s4 s0 s3 s2 s1"" version=""1.0"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePCFPeppolInvoiceDraft"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s1=""urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2"" xmlns:s2=""http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader"" xmlns:s0=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" xmlns:s4=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:s3=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:StandardBusinessDocument"" />
  </xsl:template>
  <xsl:template match=""/s2:StandardBusinessDocument"">
    <ns0:InterfacePCFPeppolInvoiceDraft>
      <ns0:InstanceIdentifier>
        <xsl:value-of select=""s2:StandardBusinessDocumentHeader/DocumentIdentification/InstanceIdentifier/text()"" />
      </ns0:InstanceIdentifier>
      <ns0:InvoiceLineList>
        <ns3:INVOICELINETYPE>
          <xsl:for-each select=""s0:Invoice/s3:InvoiceLine"">
            <ns3:ID>
              <xsl:value-of select=""s0:Invoice/s3:InvoiceLine/s4:ID/text()"" />
            </ns3:ID>
            <ns3:InvoicedQuantity>
              <xsl:value-of select=""s0:Invoice/s3:InvoiceLine/s4:InvoicedQuantity/text()"" />
            </ns3:InvoicedQuantity>
          </xsl:for-each>
        </ns3:INVOICELINETYPE>
      </ns0:InvoiceLineList>
    </ns0:InterfacePCFPeppolInvoiceDraft>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Sp.PCFPeppol.Schemas.PeppolInput";
        
        private const global::Sp.PCFPeppol.Schemas.PeppolInput _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Sp.PCFPeppol.Schemas.uspPCFInvoiceDraft_TypedProcedure_dbo+InterfacePCFPeppolInvoiceDraft";
        
        private const global::Sp.PCFPeppol.Schemas.uspPCFInvoiceDraft_TypedProcedure_dbo.InterfacePCFPeppolInvoiceDraft _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"Sp.PCFPeppol.Schemas.uspPCFInvoiceDraft_TypedProcedure_dbo+InterfacePCFPeppolInvoiceDraft";
                return _TrgSchemas;
            }
        }
    }
}
