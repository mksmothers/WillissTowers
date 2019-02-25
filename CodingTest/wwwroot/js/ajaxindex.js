$('#getdata').click(function () {
    var url = $('#repo').data('url');
    $('#content').html('');
    $.ajax({
        url: url,
        type: "GET",
        dataType: "json",
        traditional: true,
        contentType: "application/json; charset=utf-8",
        success: function (json) {
            $('#content').html(json);
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError);
        }
    });
})  