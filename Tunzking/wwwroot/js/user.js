$(document).ready(function () {
    loadDataTable();
});
var dataTable;

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/user/getall'},
        "columns": [
            { data: 'firstName', "width": "10%" },
            { data: 'email', "width": "15%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'role', "width": "10%" },
            {
                data: {id: "id", lockoutEnd: "lockoutEnd"},
                "render": function (data) {
                    var today = new Date().getTime();
                    var lockout = new Date(data.lockoutEnd).getTime();

                    if (lockout > today) {
                        return `<div class="w-75 btn-group" role="group">
                            <a onclick=LockUnlock('${data.id}') class="btn btn-outline-danger mx-2">Lock</a>
                        </div>`
                    }
                    else {
                        return `<div class="w-75 btn-group" role="group">
                            <a onclick=LockUnlock('${data.id}') class="btn btn-outline-success mx-2">Unlock</a>
                        </div>`
                    }

                },
                "width": "10%"
            }

        ]
    });
}

function LockUnlock(id) {
    $.ajax({
        type: "POST",
        url: '/Admin/User/LockUnLock',
        data: JSON.stringify(id),
        contentType: "application/json",
        success: function (data) {
            if (data.success) {
                toastr.success(data.message);
                dataTable.ajax.reload();
            }
        }
    });
}