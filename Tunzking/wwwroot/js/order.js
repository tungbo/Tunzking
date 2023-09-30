$(document).ready(function () {
    loadDataTable();
});
var dataTable;

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/order/getall'},
        "columns": [
            { data: 'id', "width": "5%" },
            { data: 'firstName', "width": "10%" },
            { data: 'phoneNumber', "width": "15%" },
            { data: 'applicationUser.email', "width": "15%" },
            { data: 'orderStatus', "width": "10%" },
            { data: 'orderTotal', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                            <a href="/admin/order/details?orderId=${data}" class="btn btn-outline-info mx-2"><i class="ri-edit-box-line"></i></a>
                        </div>`
                },
                "width": "10%"
            }

        ]
    });
}
