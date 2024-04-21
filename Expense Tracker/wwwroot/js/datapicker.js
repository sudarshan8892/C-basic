function onApply(args) {

    $.ajax({
        type: 'post',
        url: "/Home/Index",
        contentType: 'application/json; charset=utf-8',
        data: JSON.stringify({ 'gameName': args.model.startDate + ' - ' + args.model.endDate }), // Convert data to JSON string
        dataType: "json",
        success: function results(result) {
            alert(result);
        },
        error: function (a, b, c) {
            alert("Error!")
        }
    });
}
