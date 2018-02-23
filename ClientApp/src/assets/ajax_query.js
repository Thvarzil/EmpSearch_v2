


$("#search_submit").on("click", function(){

    var search_term = $("#search_term").val();
    console.log(search_term);

    $.ajax({
        type: 'GET',
        url: "~/Controllers/db_query.cs?searchterm="+search_term,
        data: {},
        contentType: "application/json; charset=utf8",
        dataType: "json",
        success: function(msg){
            alert(msg);
        }
    })
});
   



