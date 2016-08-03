
$(function () {
    $('#result').on('click', '.pagination a', function (e) {
        var _this = $(e.target);
        var pageingex = _this.data("page");
        $('#result .pagination li').removeClass("active");
        _this.parent.addClass("active");
        $('#PageNumber').val(pageingex);

        console.log($('form').attr("action"));
        $.ajax({
            url: $('form').attr("action"),
            data: $('form').serializeArray(),
            type: 'POST',
            success: function (res) {
                $.getScript("/Scripts/jquery-2.2.0.min.js", function () {
                    alert("Running jquery.js");

                });
                $.getScript("/Scripts/paging.js", function () {
                    alert("Running paging.js");
                    $("#data-ajax").html(res);
                });
                //console.log(res);
            }
        });
        e.preventDefault();
        // $('form').submit();
    })

})
 


