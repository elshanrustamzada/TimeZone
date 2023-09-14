let count = 6;
let productsCount = $("#loadMore").next().val()
$(document).on("click", "#loadMore", function () {
    $.ajax({
        url: "/Products/LoadMore/",
        type: "get",
        data: {
            skip:count
        },
        success: function (res) {
            $("#myProducts").append(res);
            count += 6;
            if (productsCount <= count)
            {
                $("#loadMore").remove()
            }
        }
    });
});