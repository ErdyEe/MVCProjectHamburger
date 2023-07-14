
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

function GetExtraIngredientList() {
    $.ajax({

        url: "/User/Order/GetExtraIngredient",
        type: "get",
        success: function (response) {
            $("#list").html(response);
            $("#shoppingCart").html("");
        }
    });
}
function OrderCreate() {
    $.ajax({

        url: "/User/Order/AddToOrder",
        type: "post",
        success: function (response) {
            $("#shoppingCart").html(response);
        }
    });
}

function OrderrCreate(sid) {
    let ogrenci = {
        id: sid,
        name: $("#updateName").val(),
        creationDate: $("#updateCreationDate").val(),
        schoolId: $("#updateSchoolId").val(),
        class: $("#updateClass").val()
    }

    $.ajax({
        url: "/Ajax/Update/",
        type: "post",
        data: ogrenci,
        success: function (response) {
            if (response == "ok") {
                $("#update").html("");
                $("#create").html("");
                $("#error").html("");
                GetList();
            }
            else {
                $("#error").html("<h3>Güncellenirken bir hata oluştu</h3>");
            }
        }
    });
}

