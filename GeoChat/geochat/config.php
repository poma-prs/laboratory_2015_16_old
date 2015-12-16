<?
	$link = mysql_connect('localhost', '046370212_geo', '1234321')
    or die('Не удалось соединиться: ' . mysql_error());
	mysql_select_db('scrumstudio_geochat') or die('Не удалось выбрать базу данных'.mysql_error());
	mysql_query("SET NAMES utf8");
	mysql_query("SET CHARACTER SET utf8");
?>