//$('#search_icon').on('click', function (e) {
//    // TODO: Validate input

//    var searchInput = {
//        searchTerm: $('#search_input').val().trim()
//    };

//    $.ajax({
//        type: "POST",
//        url: "/Search",
//        content: "application/json; charset=utf-8",
//        dataType: "json",
//        data: searchTerm,
//        success: function (data) {
//            alert(data);
//        },
//        error: function () {
//            alert("error");
//        }
//    })
//});
//$.post("SearchController/Search", { SearchTerm: $("#search_input").val()}, function (data) {
//    console.log("here");

//});