<? 
include_once("../config.php");
interface Chat { 
private static $curUser; 
private static $cash; 
private static $curUserTo; 
private static function paySearch($phone); 
private static function getBanList($phone); 
private static function cPhoto(pFile $file); 
private static function cVideo(vFile $file); 
private static function cAudio(aFile $file); 
private static function cSticker($id); 
private static function cText($text); 
public static function send(); 
public static function gets(); 
}  

abstract class message {
	abstract protected $type;
	abstract protected $files;
	 public function append($file) {
		//array_push($this->$files,$file);
		echo "append";
	}
}
class textMessage extends message {
	protected $text;
	public init($text) {
		$this->$text=$text;
		$type='text';
	}
	public out() {
		echo $text;
	}
}
class audioMessage extends message {
	protected $audio;
	public init($file) {
		$this->append($file);
		$type='audio';
	}
	public out() {
		echo $audio;
	}
}
class videoMessage extends message {
	protected $video;
	public init($file) {
		$this->append($file);
		$type='video';
	}
	public out() {
		echo $video;
	}
}
class stickMessage extends message {
	
	protected $stick_id;
	public init($id) {
		$this->$stick_id=$id;
		$type='stick';
	}
	public out() {
		echo $id;
	}
}
$msg = new textMessage();
abstract class File {
	abstract protected $filename;
	abstract protected $filetype;
	abstract protected $size;
	public init($file) {
		echo "init";
	}
	public get() {
		echo "get";
	}
}
class aFile extends File {
	protected $length;
	public getLen() {
		echo 'a';
	}
}
class vFile extends File {
	protected $length;
	protected $rez;
	public getLen() {
		echo 'a';
	}
	public getRez() {
		echo 'a';
	}
}
class pFile extends File {
	protected $rez;
	public getRez() {
		echo 'a';
	}
}
class mail { 
	public function getMail(){
		echo "getmail";	
	} 

	public function sendMail($msg){ 
		echo "sendmail";
	} 
} 
class Chat { 
private static $curUser; 
private static $cash; 
private static $curUserTo; 
private static function paySearch($phone){echo "a";} 
private static function getBanList($phone){echo "a";}  
private static function cPhoto(pFile $file){echo "a";} 
private static function cVideo(vFile $file){echo "a";}  
private static function cAudio(aFile $file){echo "a";}  
private static function cSticker($id){echo "a";}  
private static function cText($text){echo "a";}  
public static function send($msg){echo "a";}  
public static function gets($msg){echo "a";}  
}
$chatNow = new Chat();
?>