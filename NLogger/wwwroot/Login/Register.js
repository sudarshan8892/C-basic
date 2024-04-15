$(document).ready(function () {
    SetGeolocation();
});
var SetGeolocation = function () {
    var lat;
    var long;

    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        lat = "Geolocation is not supported by this browser.";
        long = "Geolocation is not supported by this browser.";
    }

    function showPosition(position) {
        lat = position.coords.latitude;
        long = position.coords.longitude;
        // You can now use lat and long here
        console.log(lat, long);
    }
};
    var RegisterNewUser = function () {
         alert("click");
        if (!$("#Registerform").valid())
        {
            return;
        }
        alert("okay");
        var _register = $("#Registerform").serialize();
        console.log(_register);
        $("#btnregister").prop("disabled", true);
        $("#btnregister").val("Registering...");
        $("#btnregister").LoadingOverlay("show");
        $.ajax(
            {

                type: "Post",
                url: "/Home/Register",
                data: _register,
             
                success: function (result)
                {
                    $("#btnregister").LoadingOverlay("hide", true);
                    $('#btnregister').removeAttr('disabled');
                    $("#btnregister").val("Register");
                    if (result.isSuccess) {
                        debugger
                        window.location.href = "/Home/Login";
                    } else {
                        alert("error");
                    }

                },
                error: function () 
                {

                    $("#btnRegister").val("Register");
                    $('#btnRegister').removeAttr('disabled');
                    alert("An error occurred while processing your request.");

                }
            });

    }






var LoginUser = function () {
    
    var Email = $("#Email").val();
    if (Email === null || Email === '') {
        alert("please  Enter Email...")
        return;

        // FieldValidationAlert()
    }
    var Password = $("#Password").val();
    if (Password === null || Password === null) {
        alert(" Please Enter Password..... ")
        return;

    }

    var _formLogin = $("#frmLogin").serialize();
    $("#btnLogin").prop('disabled', true);
    $("#btnLogin").LoadingOverlay("show");
    $.ajax(
        {
            data: _formLogin,
            type: "Post",
            url: "/Home/Login",
            success: function (result) {
                $("#btnLogin").LoadingOverlay("hide", true);
                $('#btnLogin').removeAttr('disabled');
                if (result.isSuccess) {
                    debugger
                    window.location.href = "/Home/Index";
                } else {
                    alert("error");
                }

            },
            error: function () {
                alert("some error..!")
            }

        });

}