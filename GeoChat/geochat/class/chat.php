<?
include_once("../config.php");
interface Chat {
	private static curUser;
	private static cash;
	private static curUserTo;
	private static function paySearch($phone);
	private static function getBanList($phone);
	private static function cPhoto($file);
	private static function cVideo($file);
	private static function cAudio($file);
	private static function cSticker($id);
	private static function cText($text);
	public static function send();
	public static function gets();
}
?>