<?php header("Content-Type: text/xml; charset=utf-8");
echo "<?xml version=\"1.0\" encoding=\"utf-8\"?>"; ?>
<definitions xmlns:soap="http://schemas.xmlsoap.org/wsdl/soap/"
             xmlns:soapenc="http://schemas.xmlsoap.org/soap/encoding/"
             xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
             xmlns:mime="http://schemas.xmlsoap.org/wsdl/mime/"
             xmlns:tns="http://localhost/"
             xmlns:xs="http://www.w3.org/2001/XMLSchema"
             xmlns:soap12="http://schemas.xmlsoap.org/wsdl/soap12/"
             xmlns:http="http://schemas.xmlsoap.org/wsdl/http/"
             name="MyServiceWsdl"
             xmlns="http://schemas.xmlsoap.org/wsdl/"
			 targetNamespace="http://localhost/">
	<!-- Типы данных, используемые в качестве аргументов и возвращаемых значений -->
	<types>
		<xs:schema elementFormDefault="qualified"
                   xmlns:tns="http://localhost/"
                   xmlns:xs="http://www.w3.org/2001/XMLSchema"
                   targetNamespace="http://localhost/">				   
				    <xs:element name="ИмяМетода_Request">					
						<xs:complexType>
							<!--Объявление формата аргументов сервиса-->
						</xs:complexType>
					</xs:element>
					<xs:element name="ИмяМетода_Response">					
						<xs:complexType>
							<!--Объявление формата возвращаемого значения-->							
						</xs:complexType>
					</xs:element>					
		 </xs:schema>
	</types>
	<!-- Сообщения процедуры  -->
    <message name="ИмяМетода_RequestMessage">
        <part name="parameters" element="tns:ИмяМетода_Request" />
    </message>
    <message name="ИмяМетода_ResponseMessage">
        <part name="parameters" element="tns:ИмяМетода_Response" />
    </message>	
	
	 <!-- Привязка процедуры к сообщениям -->
    <portType name="MyServicePortType">
        <operation name="ИмяМетода">
            <input message="tns:ИмяМетода_RequestMessage" />
            <output message="tns:ИмяМетода_ResponseMessage" />
        </operation>		
    </portType>
	<!--Формат процедур веб-сервиса -->
    <binding name="MyServiceBinding" type="tns:MyServicePortType">
        <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
		<!--Объявление списка процедур-->
        <operation name="ИмяМетода">
            <soap:operation soapAction="" />
            <input>
                <soap:body use="literal" />
            </input>
            <output>
                <soap:body use="literal" />
            </output>
        </operation>
    </binding>
	<!--Определение сервиса -->
    <service name="MyService">
        <port name="MyServicePort" binding="tns:MyServiceBinding">
            <soap:address location="полный_путь_к_странице_сервиса"/>
        </port>
    </service>
</definitions>