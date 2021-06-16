namespace CursoBizTalk.Esquemas.ClienteSalida {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://CursoBizTalk.Esquemas.ClienteSalida.ClienteSalida",@"ClienteSalida")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ClienteSalida"})]
    public sealed class ClienteSalida : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://CursoBizTalk.Esquemas.ClienteSalida.ClienteSalida"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://CursoBizTalk.Esquemas.ClienteSalida.ClienteSalida"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ClienteSalida"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Identificacion"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""NumeroIdentificacion"" type=""xs:string"" />
              <xs:element name=""TipoIdentificacion"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DatosBasicos"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""NombreCompleto"" type=""xs:string"" />
              <xs:element name=""Nacionalidad"" type=""xs:string"" />
              <xs:element name=""FechaNacimiento"" type=""xs:date"" />
              <xs:element name=""Pais"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Proceso"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""FechaTransaccion"" type=""xs:dateTime"" />
              <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Proceso"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""DatosVenta"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""SumaVenta"" type=""xs:string"" />
              <xs:element name=""TotalItems"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ClienteSalida() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ClienteSalida";
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
