namespace Sp.PCFPeppol.Orchestrations {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.uspGRNPoll_TypedPolling_InterfacePCFPeppolGRNQueuePoll+TypedPollingResultSet0", typeof(global::Sp.PCFPeppol.Schemas.uspGRNPoll_TypedPolling_InterfacePCFPeppolGRNQueuePoll.TypedPollingResultSet0))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.PeppolInput", typeof(global::Sp.PCFPeppol.Schemas.PeppolInput))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Sp.PCFPeppol.Schemas.uspPCFInvoiceDraft_TypedProcedure_dbo+InterfacePCFPeppolInvoiceDraft", typeof(global::Sp.PCFPeppol.Schemas.uspPCFInvoiceDraft_TypedProcedure_dbo.InterfacePCFPeppolInvoiceDraft))]
    public sealed class Map_PCFPeppolDocId_uspReq : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s3 s2 s1 s4 s5 s0 s6"" version=""1.0"" xmlns:s0=""http://schemas.microsoft.com/Sql/2008/05/TypedPolling/InterfacePCFPeppolGRNQueuePoll"" xmlns:ns4=""http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePCFPeppolInvoiceDraft"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo"" xmlns:s3=""urn:oasis:names:specification:ubl:schema:xsd:CreditNote-2"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s1=""http://www.unece.org/cefact/namespaces/StandardBusinessDocumentHeader"" xmlns:s4=""urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"" xmlns:s5=""urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"" xmlns:ns3=""http://schemas.microsoft.com/Sql/2008/05/Types/TableTypes/dbo"" xmlns:s6=""urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <ns0:InterfacePCFPeppolInvoiceDraft>
      <xsl:if test=""InputMessagePart_0/s0:TypedPollingResultSet0/s0:InstanceIdentifier"">
        <ns0:InstanceIdentifier>
          <xsl:value-of select=""InputMessagePart_0/s0:TypedPollingResultSet0/s0:InstanceIdentifier/text()"" />
        </ns0:InstanceIdentifier>
      </xsl:if>
      <ns0:InvoiceLineList>
        <ns3:INVOICELINETYPE>
          <ns3:ID>
            <xsl:value-of select=""InputMessagePart_1/s1:StandardBusinessDocument/s4:Invoice/s6:InvoiceLine/s5:ID/text()"" />
          </ns3:ID>
          <ns3:InvoicedQuantity>
            <xsl:value-of select=""InputMessagePart_1/s1:StandardBusinessDocument/s4:Invoice/s6:InvoiceLine/s5:InvoicedQuantity/text()"" />
          </ns3:InvoicedQuantity>
        </ns3:INVOICELINETYPE>
      </ns0:InvoiceLineList>
    </ns0:InterfacePCFPeppolInvoiceDraft>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Sp.PCFPeppol.Schemas.uspGRNPoll_TypedPolling_InterfacePCFPeppolGRNQueuePoll+TypedPollingResultSet0";
        
        private const global::Sp.PCFPeppol.Schemas.uspGRNPoll_TypedPolling_InterfacePCFPeppolGRNQueuePoll.TypedPollingResultSet0 _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Sp.PCFPeppol.Schemas.PeppolInput";
        
        private const global::Sp.PCFPeppol.Schemas.PeppolInput _srcSchemaTypeReference1 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"Sp.PCFPeppol.Schemas.uspGRNPoll_TypedPolling_InterfacePCFPeppolGRNQueuePoll+TypedPollingResultSet0";
                _SrcSchemas[1] = @"Sp.PCFPeppol.Schemas.PeppolInput";
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
