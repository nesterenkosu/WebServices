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
					<!--HelloWorld()-->
				    <xs:element name="HelloWorld_Request">					
						<xs:complexType>
							<!--Объявление формата аргументов сервиса-->
						</xs:complexType>
					</xs:element>
					<xs:element name="HelloWorld_Response">					
						<xs:complexType>
							<!--Объявление формата возвращаемого значения-->
							<xs:sequence>
							<xs:element name="answer" type="xs:string" minOccurs="1" maxOccurs="1"/>
							</xs:sequence>
						</xs:complexType>
					</xs:element>
					<!--GreetUser(name,age)-->
					<xs:element name="GreetUser_Request">					
						<xs:complexType>
							<!--Объявление формата аргументов сервиса-->
							<xs:sequence>
							<xs:element name="name" type="xs:string" minOccurs="1" maxOccurs="1"/>
							<xs:element name="age" type="xs:int" minOccurs="1" maxOccurs="1"/>
							</xs:sequence>
						</xs:complexType>
					</xs:element>
					<xs:element name="GreetUser_Response">					
						<xs:complexType>
							<!--Объявление формата возвращаемого значения-->
							<xs:sequence>
							<xs:element name="answer" type="xs:string" minOccurs="1" maxOccurs="1"/>
							</xs:sequence>
						</xs:complexType>
					</xs:element>
					<!--GetCityInfo(name)-->
					<xs:element name="GetCityInfo_Request">					
						<xs:complexType>
							<!--Объявление формата аргументов сервиса-->
							<xs:sequence>
							<xs:element name="name" type="xs:string" minOccurs="1" maxOccurs="1"/>							
							</xs:sequence>
						</xs:complexType>
					</xs:element>
					<xs:element name="GetCityInfo_Response">					
						<xs:complexType>
							<!--Объявление формата возвращаемого значения-->
							<xs:sequence>
							<xs:element name="answer" type="tns:cityinfo" minOccurs="1" maxOccurs="1"/>
							</xs:sequence>
						</xs:complexType>
					</xs:element>
					<xs:complexType name="cityinfo">
						<xs:sequence>
							<xs:element name="code" type="xs:int" minOccurs="1" maxOccurs="1"/>
							<xs:element name="population" type="xs:int" minOccurs="1" maxOccurs="1"/>
							<xs:element name="area" type="xs:int" minOccurs="1" maxOccurs="1"/>
						</xs:sequence>
					</xs:complexType>
		 </xs:schema>
	</types>
	<!-- Сообщения процедуры  -->
    <message name="HelloWorld_RequestMessage">
        <part name="parameters" element="tns:HelloWorld_Request" />
    </message>
    <message name="HelloWorld_ResponseMessage">
        <part name="parameters" element="tns:HelloWorld_Response" />
    </message>	
	<message name="GreetUser_RequestMessage">
        <part name="parameters" element="tns:GreetUser_Request" />
    </message>
    <message name="GreetUser_ResponseMessage">
        <part name="parameters" element="tns:GreetUser_Response" />
    </message>
	<message name="GetCityInfo_RequestMessage">
        <part name="parameters" element="tns:GetCityInfo_Request" />
    </message>
    <message name="GetCityInfo_ResponseMessage">
        <part name="parameters" element="tns:GetCityInfo_Response" />
    </message>
	
	 <!-- Привязка процедуры к сообщениям -->
    <portType name="MyServicePortType">
        <operation name="HelloWorld">
            <input message="tns:HelloWorld_RequestMessage" />
            <output message="tns:HelloWorld_ResponseMessage" />
        </operation>
		<operation name="GreetUser">
            <input message="tns:GreetUser_RequestMessage" />
            <output message="tns:GreetUser_ResponseMessage" />
        </operation>
		<operation name="GetCityInfo">
            <input message="tns:GetCityInfo_RequestMessage" />
            <output message="tns:GetCityInfo_ResponseMessage" />
        </operation>		
    </portType>
	<!--Формат процедур веб-сервиса -->
    <binding name="MyServiceBinding" type="tns:MyServicePortType">
        <soap:binding transport="http://schemas.xmlsoap.org/soap/http" />
		<!--Объявление списка процедур-->
        <operation name="HelloWorld">
            <soap:operation soapAction="" />
            <input>
                <soap:body use="literal" />
            </input>
            <output>
                <soap:body use="literal" />
            </output>
        </operation>
		<operation name="GreetUser">
            <soap:operation soapAction="" />
            <input>
                <soap:body use="literal" />
            </input>
            <output>
                <soap:body use="literal" />
            </output>
        </operation>
		<operation name="GetCityInfo">
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
            <soap:address location="http://<?=$_SERVER["HTTP_HOST"]?>/server.php"/>
        </port>
    </service>
</definitions>