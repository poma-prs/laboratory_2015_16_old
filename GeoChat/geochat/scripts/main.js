function nav(task) {
    var obj = {"task" : task};
    $.ajax({
        url:     "../geochat/class/interfaceUser.php", 
        type:     "POST", 
        dataType: "html", 
        data: obj, 
        success: function(response) { 
            $("#content").html(response);
        },
        error: function(response) { 
            $("#content").html("Ошибка ajax");
        }
    });
}

$(document).on('click',"#map", function(){nav("map");});
$(document).on('click',"#chat", function(){nav("chat");});
$(document).on('click',"#settings", function(){nav("settings");});

function enter() {
    var form = $("#reg").serialize();
    //var phone = $('#reg').val();
    var phone = $("input[name='phone']").val();
    var re = /^\d[\d\(\)\ -]{4,14}\d$/;
    var valid = re.test(phone);
    //alert(phone);
    if(!valid) {
        $('#reg').append("Некорректный номер!");
    } else {
    $.ajax({
        url:     "../geochat/class/autoUser.php", 
        type:     "POST", 
        dataType: "html", 
        data: form, 
        success: function(response) { 
            $("#content").html(response);
            nav('show');
        },
        error: function(response) { 
            $("#content").html("Ошибка ajax");
        }
    });
    }
}
