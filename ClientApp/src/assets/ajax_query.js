


$("#search_submit").on("click", function(){
    // Clear search results display to make room for new results
    $("#result").empty();

    var search_term = $("#search_term").val();
    console.log(search_term);

    $.ajax({
        type: 'GET',
        url: "api/Controllers/db_query/db_search/"+search_term,
        data: {},
        contentType: "application/json; charset=utf8",
        dataType: "json",
        success: function(htmlString){
            // Takes string returned by controller, and sets display HTML to it
            $("#result_container").html(htmlString);
        }
    })
});
   



