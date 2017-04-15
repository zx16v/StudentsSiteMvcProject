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

