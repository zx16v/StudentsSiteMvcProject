function UpdateCounter() {
    var lastpageVal = $("#lastPage").data("value");
    localStorage.setItem('LastPage', lastpageVal);
    UpdatePaging();
}

$(document).ready(function (e) {
    $("#Previous").click(function () {
        if (getSetPage("Previous"))
            $("form").submit();
    });
    $("#Next").click(function () {
        if (getSetPage("Next"))
            $("form").submit();
    });
});

function UpdatePaging() {
    var LastPageCount = localStorage.getItem('LastPage');
    $("#LastPage").val(LastPageCount);
    $("#CurrentPage").val(1);
}

function getSetPage(Dirceton) {
    var CurrentPage = parseInt($("#CurrentPage").val());
    var LastPage = parseInt($("#LastPage").val());
    if (CurrentPage == 1 && Dirceton == "Previous") {
        return false;
    }
    if (CurrentPage == LastPage && Dirceton == "Next") {
        return false;
    }
    if (Dirceton == "Previous") {
        CurrentPage--;
    }
    else if (Dirceton == "Next") {
        CurrentPage++;
    }
    else alert("Something Wronggg!");
    $("#CurrentPage").val(CurrentPage);
    return true;
}

$(document).ready(function () {
    $("#CitesNames").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Home/GetCities",
                type: "POST",
            dataType: "json",
            cache: false,
            data: { term: request.term },
            success: function (data) {
                response($.map(data, function (item) {
                    return { label: item.CityName, value: item.CityName, id:item.Id };
                }))
            },
            error: function (jqXHR, textStatus, errorThrown) {
                alert("error handler!");
            }
        })
},
    messages: {
    noResults: "", results: ""
},

select: function (event, ui) {
    // Set autocomplete element to display the label
    this.value = ui.item.label;
    // Store value in hidden field
    $("#CityId_hidden").val(ui.item.id);
    $("#CityIdhidden").val(ui.item.id);
    return false;
}
});

})
