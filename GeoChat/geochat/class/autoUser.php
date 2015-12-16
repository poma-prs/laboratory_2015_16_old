<?
include_once("../config.php");

class autoUser {
    private static $phone;
    private static $status;
    private static $response;
    function __construct() {
        $phone = -1;
        $status = -1; 
        $response = -1; 
    }
    private function autorization($phone){
        $query = "SELECT * FROM users WHERE phone=".$phone;
        $exquery = mysql_query($query) or die();
        $row = mysql_fetch_array($exquery);
        if(!$row) {
            return $this->regUser($phone);
        }
        return "authOk";
    }
	private function regUser($phone) {
	    $query = "INSERT into users (phone) VALUES('".$phone."')";
        $exquery = mysql_query($query) or die();
        return "regOk";
	}
	private function makeresponse($status) {
	    switch ($status) {
            case "regOk":
                echo "Поздравляем с регистрацией!\n";
            break;
            case "authOk":
                echo "Успешный вход!";
            break;
            default: 
                echo "Ошибка mysql";
            break;
        }
	}
	public function get() {
	    $phone = $_POST['phone'];
	    $status = $this->autorization($phone);
	    $this->makeresponse($status);
	}
}
$auth = new autoUser();
$auth->get();

?>