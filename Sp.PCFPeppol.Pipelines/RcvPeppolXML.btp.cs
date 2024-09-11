namespace Sp.PCFPeppol.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class RcvPeppolXML : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s>        <Component>          <Name>Sp.PCF.ArchiveMessage.PCFArchivePipelineComponent,Sp.PCF.Archiv"+
"eMessage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=729508834c3a21c6</Name>          <Compone"+
"ntName>PCF Archive Message</ComponentName>          <Description>PCF Archive Message Pipeline Compon"+
"ent</Description>          <Version>1.0</Version>          <Properties>            <Property Name=\"A"+
"rchivePath\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Propert"+
"y Name=\"CreateDateFolder\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Pro"+
"perty>            <Property Name=\"ArchivePath2\">              <Value xsi:type=\"xsd:string\" />       "+
"     </Property>            <Property Name=\"CreateDateFolder2\">              <Value xsi:type=\"xsd:bo"+
"olean\">false</Value>            </Property>            <Property Name=\"ArchiveFileExt\">             "+
" <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"ArchiveFileDomain"+
"\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"Ar"+
"chiveFileUsername\">              <Value xsi:type=\"xsd:string\" />            </Property>            <"+
"Property Name=\"ArchiveFilePassword\">              <Value xsi:type=\"xsd:string\" />            </Prope"+
"rty>          </Properties>          <CachedDisplayName>PCF Archive Message</CachedDisplayName>     "+
"     <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <"+
"Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" minOccurs=\"0\" maxOccu"+
"rs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" />      <Components> "+
"       <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline"+
".Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <Comp"+
"onentName>XML disassembler</ComponentName>          <Description>Streaming XML disassembler</Descrip"+
"tion>          <Version>1.0</Version>          <Properties>            <Property Name=\"EnvelopeSpecN"+
"ames\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Property Name"+
"=\"EnvelopeSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />            </Property>"+
"            <Property Name=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\">Sp.PCFPepp"+
"ol.Schemas.PeppolInput, Sp.PCFPeppol.Schemas, Version=1.0.0.0, Culture=neutral, PublicKeyToken=14d94"+
"ee4447a4c2e</Value>            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">"+
"              <Value xsi:type=\"xsd:string\">http://www.unece.org/cefact/namespaces/StandardBusinessDo"+
"cumentHeader</Value>            </Property>            <Property Name=\"AllowUnrecognizedMessage\">   "+
"           <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>            <Property N"+
"ame=\"ValidateDocument\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </Proper"+
"ty>            <Property Name=\"RecoverableInterchangeProcessing\">              <Value xsi:type=\"xsd:"+
"boolean\">false</Value>            </Property>            <Property Name=\"HiddenProperties\">         "+
"     <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces</Value> "+
"           </Property>          </Properties>          <CachedDisplayName>XML disassembler</CachedDi"+
"splayName>          <CachedIsManaged>true</CachedIsManaged>        </Component>      </Components>  "+
"  </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Validate\" minOccurs"+
"=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-4a5040674ad6\" />      <Compone"+
"nts />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"4\" Name=\"ResolvePart"+
"y\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />  "+
"    <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "d08f1a86-55db-470e-90b1-e6b43f914400";
        
        public RcvPeppolXML()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4103-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Sp.PCF.ArchiveMessage.PCFArchivePipelineComponent,Sp.PCF.ArchiveMessage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=729508834c3a21c6");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"ArchivePath\">  "+
"    <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"CreateDateFolder\">      <Value"+
" xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ArchivePath2\">      <Value x"+
"si:type=\"xsd:string\" />    </Property>    <Property Name=\"CreateDateFolder2\">      <Value xsi:type=\""+
"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ArchiveFileExt\">      <Value xsi:type=\""+
"xsd:string\" />    </Property>    <Property Name=\"ArchiveFileDomain\">      <Value xsi:type=\"xsd:strin"+
"g\" />    </Property>    <Property Name=\"ArchiveFileUsername\">      <Value xsi:type=\"xsd:string\" />  "+
"  </Property>    <Property Name=\"ArchiveFilePassword\">      <Value xsi:type=\"xsd:string\" />    </Pro"+
"perty>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNamesp"+
"aces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">   "+
"   <Value xsi:type=\"xsd:string\">Sp.PCFPeppol.Schemas.PeppolInput, Sp.PCFPeppol.Schemas, Version=1.0."+
"0.0, Culture=neutral, PublicKeyToken=14d94ee4447a4c2e</Value>    </Property>    <Property Name=\"Docu"+
"mentSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://www.unece.org/cefact/namespaces/"+
"StandardBusinessDocumentHeader</Value>    </Property>    <Property Name=\"AllowUnrecognizedMessage\"> "+
"     <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"ValidateDocument\""+
">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"RecoverableInte"+
"rchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Nam"+
"e=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,DocumentSpecTar"+
"getNamespaces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
