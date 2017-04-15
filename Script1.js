// JavaScript source code

$(document).ready(function () {
   $('a.delete').click(OnDeleteClick());
 });
function OnDeleteClick(e) {
    var studentId = e.target.id;
    var fullName = e.target.name;
    var flag = confirm('You are about to delete student ' + fullName + ' permanently.Are you sure you want to delete this record?');
    if (flag) {
        $.ajax({
            cache: false,
            url: '@Url.Action("DeleteAJAX")',
            type: 'POST',
            data: { studentid: studentId },
            dataType: 'json',
            success: function (result) { alert(result); $("#" + studentId).parent().parent().remove(); },
            error: function () { alert('Error!'); }
        });

        return false;
    }
}