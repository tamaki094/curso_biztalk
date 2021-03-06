
#pragma warning disable 162

namespace CursoBiztalk.Orquestaciones
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(CursoBiztalk.Orquestaciones.__messagetype_CursoBizTalk_Esquemas_Cliente)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Cliente : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Cliente(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Cliente(PortType_Cliente p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Cliente p = new PortType_Cliente(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Cliente),
            typeof(__messagetype_CursoBizTalk_Esquemas_Cliente),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(CursoBiztalk.Orquestaciones.__messagetype_CursoBizTalk_Esquemas_Cliente)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Salida : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Salida(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Salida(PortType_Salida p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Salida p = new PortType_Salida(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(PortType_Salida),
            typeof(__messagetype_CursoBizTalk_Esquemas_Cliente),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 137 "C:\Users\ea33010\documents\visual studio 2013\Projects\CursoBizTalk\CursoBiztalk.Orquestaciones\ProcesarCliente.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Port_Cliente", "Operation_1", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(CursoBiztalk.Orquestaciones.PortType_Cliente),
            typeof(CursoBiztalk.Orquestaciones.PortType_Salida)
        },
        new System.String[] {
            "Port_Cliente",
            "Port_Salida"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class ProcesarCliente : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(ProcesarCliente));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static ProcesarCliente()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __ProcesarCliente_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public ProcesarCliente(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "ProcesarCliente", tracker)
        {
            ConstructorHelper();
        }

        public ProcesarCliente(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "ProcesarCliente")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>d5aab3da-5e21-41da-ab62-a9bee406302b</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>c4f8bfd2-2b7e-4823-9c0c-4b7d28fbc5c2</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Rcv_Entrada</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6a8661bd-8838-4dd0-9018-181c74eab900</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Rcv_Salida</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'ProcesarCliente'</ActionName><IsAtomic>0</IsAtomic><Line>137</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>147</Line><Position>22</Position><ShapeID>'c4f8bfd2-2b7e-4823-9c0c-4b7d28fbc5c2'</ShapeID>
<Messages>
	<MsgInfo><name>Cliente</name><part>part</part><schema>CursoBizTalk.Esquemas.Cliente</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>149</Line><Position>13</Position><ShapeID>'6a8661bd-8838-4dd0-9018-181c74eab900'</ShapeID>
<Messages>
	<MsgInfo><name>Cliente</name><part>part</part><schema>CursoBizTalk.Esquemas.Cliente</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='514d3f0b-9378-4f8a-b8d4-74137cda393f' LowerBound='1.1' HigherBound='35.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='CursoBiztalk.Orquestaciones' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='e1b71a36-adc0-4233-9d4d-0faca4383e58' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Cliente' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='0d3eed83-8ce7-4e0c-942c-b7a116d89180' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='9d85143f-462a-4e54-9445-e75fbd023d6d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.42'>
                    <om:Property Name='Ref' Value='CursoBizTalk.Esquemas.Cliente' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='97593424-e7be-4a2e-b168-8d21beb67d1a' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Salida' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='b25b42c9-2b54-45e0-b776-15ecc36a0bdf' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='eb9364df-454e-49ae-9db6-082d407b9bee' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.42'>
                    <om:Property Name='Ref' Value='CursoBizTalk.Esquemas.Cliente' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='b7a337a0-126c-49fe-822a-c0165329e41f' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='34.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='ProcesarCliente' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='d5aab3da-5e21-41da-ab62-a9bee406302b' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='c4f8bfd2-2b7e-4823-9c0c-4b7d28fbc5c2' ParentLink='ServiceBody_Statement' LowerBound='28.1' HigherBound='30.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Port_Cliente' />
                    <om:Property Name='MessageName' Value='Cliente' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Rcv_Entrada' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='6a8661bd-8838-4dd0-9018-181c74eab900' ParentLink='ServiceBody_Statement' LowerBound='30.1' HigherBound='32.1'>
                    <om:Property Name='PortName' Value='Port_Salida' />
                    <om:Property Name='MessageName' Value='Cliente' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Rcv_Salida' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='921deea2-f956-457a-834e-a6ad35e08aef' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='CursoBiztalk.Orquestaciones.PortType_Cliente' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Cliente' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='2cb24f55-4d7b-4e0c-88db-be61e6874a7d' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c553384e-f915-4e61-ad8d-5310112d88fb' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='CursoBiztalk.Orquestaciones.PortType_Salida' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Port_Salida' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='68d9ae8b-6b49-4d69-93c9-4049086d8870' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='d5005bb9-09bd-4692-8d28-13c0a91d195e' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='CursoBizTalk.Esquemas.Cliente' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Cliente' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __ProcesarCliente_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __ProcesarCliente_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcesarCliente")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcesarCliente __svc__ = (ProcesarCliente)_service;
                __ProcesarCliente_root_0 __ctx0__ = (__ProcesarCliente_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Port_Cliente != null)
                {
                    __svc__.Port_Cliente.Close(this, null);
                    __svc__.Port_Cliente = null;
                }
                if (__svc__.Port_Salida != null)
                {
                    __svc__.Port_Salida.Close(this, null);
                    __svc__.Port_Salida = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __ProcesarCliente_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __ProcesarCliente_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "ProcesarCliente")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                ProcesarCliente __svc__ = (ProcesarCliente)_service;
                __ProcesarCliente_1 __ctx1__ = (__ProcesarCliente_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Cliente != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Cliente);
                    __ctx1__.__Cliente = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Cliente")]
            public __messagetype_CursoBizTalk_Esquemas_Cliente __Cliente;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Cliente")]
        internal PortType_Cliente Port_Cliente;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Port_Salida")]
        internal PortType_Salida Port_Salida;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Cliente.Operation_1},
                                               typeof(ProcesarCliente).GetField("Port_Cliente", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcesarCliente), "Port_Cliente"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Salida.Operation_1},
                                               typeof(ProcesarCliente).GetField("Port_Salida", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(ProcesarCliente), "Port_Salida"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "c4f8bfd2-2b7e-4823-9c0c-4b7d28fbc5c2", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "c4f8bfd2-2b7e-4823-9c0c-4b7d28fbc5c2", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "6a8661bd-8838-4dd0-9018-181c74eab900", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "6a8661bd-8838-4dd0-9018-181c74eab900", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,5,5,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,4,5,5,5,5,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __ProcesarCliente_root_0 __ctx0__ = (__ProcesarCliente_root_0)_stateMgrs[0];
            __ProcesarCliente_1 __ctx1__ = (__ProcesarCliente_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Port_Cliente = new PortType_Cliente(0, this);
                Port_Salida = new PortType_Salida(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Port_Cliente, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __ProcesarCliente_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __ProcesarCliente_root_0 __ctx0__ = (__ProcesarCliente_root_0)_stateMgrs[0];
            __ProcesarCliente_1 __ctx1__ = (__ProcesarCliente_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Port_Cliente.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Cliente != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Cliente);
                __ctx1__.__Cliente = new __messagetype_CursoBizTalk_Esquemas_Cliente("Cliente", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Cliente);
                Port_Cliente.ReceiveMessage(0, __msgEnv__, __ctx1__.__Cliente, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (Port_Cliente != null)
                {
                    Port_Cliente.Close(__ctx1__, __seg__);
                    Port_Cliente = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Cliente);
                    __edata.PortName = @"Port_Cliente";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Port_Salida.SendMessage(0, __ctx1__.__Cliente, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Port_Salida != null)
                {
                    Port_Salida.Close(__ctx1__, __seg__);
                    Port_Salida = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Cliente);
                    __edata.PortName = @"Port_Salida";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Cliente != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Cliente);
                    __ctx1__.__Cliente = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 12;
            case 12:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
    }

    [System.SerializableAttribute]
    sealed public class __CursoBizTalk_Esquemas_Cliente__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static CursoBizTalk.Esquemas.Cliente _schema = new CursoBizTalk.Esquemas.Cliente();

        public __CursoBizTalk_Esquemas_Cliente__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "CursoBizTalk.Esquemas.Cliente",
        new System.Type[]{
            typeof(CursoBizTalk.Esquemas.Cliente)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__CursoBizTalk_Esquemas_Cliente__)
        },
        0,
        @"http://CursoBizTalk.Esquemas.Cliente#Cliente"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_CursoBizTalk_Esquemas_Cliente : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __CursoBizTalk_Esquemas_Cliente__ part;

        private void __CreatePartWrappers()
        {
            part = new __CursoBizTalk_Esquemas_Cliente__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_CursoBizTalk_Esquemas_Cliente(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
