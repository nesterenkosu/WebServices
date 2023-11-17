<?php
	//Определение типа отдаваемого содержимого
	header("Content-type: text/xml;charset=utf-8");
	
	//Предотвращение кэширования страницы
	header("Cache-Control: no-store, no-cache");
	header("Expires: ".date("r"));
	
	//Предотвращение кэширования WSDL-файла
	ini_set("soap.wsdl_cache_enabled","0");
	
	
	class myservice {
		public function HelloWorld() {
			return Array("answer"=>"Hello, world!");
		}
		
		public function GreetUser($args) {
			if($args->age < 18)
				throw new SoapFault("sender","Прости, {$args->name} но ты слишком молод");
			else
				return Array("answer"=>"Добро пожаловать, {$args->name} !");
		}
		
		public function GetCityInfo($args) {
			$db_cities=Array(
				"Челябинск"=>Array(
					"code"=>74,
					"population"=>1182517,
					"area"=>500
				),
				"Екатеринбург"=>Array(
					"code"=>66,
					"population"=>1539371,
					"area"=>1110
				),
				"Москва"=>Array(
					"code"=>77,
					"population"=>13104177,
					"area"=>2561
				)
			);
			
			$cityname=trim($args->name);
			
			if(isset($db_cities[$cityname]))
				return Array("answer"=>$db_cities[$cityname]);
			else
				throw new SoapFault("sender","Информация по городу {$cityname} отсутствует");
		}
	}
	
	$server=new SoapServer("http://$_SERVER[HTTP_HOST]/myservice.wsdl.php");
	
	$server->setClass("myservice");
	
	$server->handle();
