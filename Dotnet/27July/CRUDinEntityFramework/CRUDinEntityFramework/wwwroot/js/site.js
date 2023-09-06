// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function SaveUser() {
    var url = "/User/Create";
    var objectUser = {};
    objectUser.Name = $('#textUserName').val();
    objectUser.Email = $('#textUserEmail').val();
    objectUser.Password = $('#textUserPass').val();
  
    if (objectUser) {
        $.ajax({
            url: url,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            data: JSON.stringify(objectUser),
            type: "Post",
            success: function (result) {
                alert(result)
                console.log(result)
            },
            error: function (msg) {
                alert(msg);
            }
        });
    }


}

