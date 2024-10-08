<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var s0 userCSharp" version="1.0" xmlns:ns3="http://schemas.microsoft.com/Sql/2008/05/ProceduresResultSets/dbo/InterfacePCFPeppolAttachment" xmlns:s0="http://Sp.PCFPeppol.Schemas.InvoiceAttachment" xmlns:ns0="http://schemas.microsoft.com/Sql/2008/05/TypedProcedures/dbo" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/s0:AdditionalDocumentReference" />
  </xsl:template>
  <xsl:template match="/s0:AdditionalDocumentReference">
    <xsl:variable name="var:v1" select="userCSharp:StringConcat(string(Attachment/MimeCode/text()))" />
    <ns0:InterfacePCFPeppolAttachment>
      <xsl:if test="Attachment/EmbeddedDocumentBinaryObject">
        <ns0:filepath>
          <xsl:value-of select="Attachment/EmbeddedDocumentBinaryObject/text()" />
        </ns0:filepath>
      </xsl:if>
      <xsl:if test="Attachment/FileName">
        <ns0:filename>
          <xsl:value-of select="Attachment/FileName/text()" />
        </ns0:filename>
      </xsl:if>
      <ns0:filename>
        <xsl:value-of select="$var:v1" />
      </ns0:filename>
    </ns0:InterfacePCFPeppolAttachment>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp"><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>