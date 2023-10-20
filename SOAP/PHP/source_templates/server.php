<?php
	//Определение типа отдаваемого содержимого
	header("Content-type: text/xml;charset=utf-8");
	
	//Предотвращение кэширования страницы
	header("Cache-Control: no-store, no-cache");
	header("Expires: ".date("r"));
	
	//Предотвращение кэширования WSDL-файла
	ini_set("soap.wsdl_cache_enabled","0");
	
	
	class myservice {
		public function ИмяМетода() {
		}
	}
	
	$server=new SoapServer("http://$_SERVER[HTTP_HOST]/myservice.wsdl.php");
	
	$server->setClass("myservice");
	
	$server->handle();
