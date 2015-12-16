<?
include_once("../config.php");

interface makeChat {
	public function showChat();
}
class navMenu{
    
    function __construct($task) {
        switch ($task) {
            case "map":
                $this->searchMap();
            break;
            case "chat":
                $this->openChat();
            break;
            case "settings":
                $this->userSetting();
            break;
            case "show":
                $this->show();
            break;
            default: 
                echo "Ошибка case";
            break;
        }
    }
    function show() {
	    echo "<div id='nav'>".
	    "<button class='navbtn' id='map'>Карта</button>".
	    "<button class='navbtn' id='chat'>Чат</button>".
	    "<button class='navbtn' id='settings'>Настройки</button>";    
	}
    function searchMap() {
         echo "<div class='place'>";
        echo "Карта";
        echo "</div>";
        $this->show();
    }
	function openChat() {
	     echo "<div class='place'>";
	    echo "Чат";
	    echo "</div>";
	    $this->show();
	}
	function userSetting() {
	    echo "<div class='place'>";
	    echo "Настройки";
	    echo "</div>";
	    $this->show();
	}
	
	//function resolve($task) {
	    
	//}
}
$task = $_POST['task'];
$nav = new navMenu($task);

?>