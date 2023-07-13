
$(document).ready(GetMenuList());

function GetMenuList() {
    $.ajax({

        url: "/User/Order/GetMenu",
        type: "get",
        success: function (response) {
            $("#list").html(response);
            $("#shoppingCart").html("");
        }
    });
}
