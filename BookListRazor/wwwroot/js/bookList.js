$(document).ready(function () {
    $('#bookListTable').DataTable({
        ajax: {
            url: 'api/Book',
            dataSrc: 'data'
        }, columns: [
            { data: 'name' },
            { data: 'author' },
            { data: 'isbn' },
            {
                "data": "id",
                render: function (data) {
                    return `
                        <div class='text-center'>
                        <a href="/BookList/Edit/?id=${data}" class='btn btn-success' style='width:100px'>Edit</a>
                        <a onclick=Delete('/api/book?id='+${data}) class='btn btn-danger' style='width:100px'>Delete</a>
                        </div>
`
                }
            }
        ]

    });
});
function Delete(url) {
    swal
        ({
        
            title: "Are you sure?",
            text: "Once deleted it cannot be recovered",
            icon: "warning",
            dangermode:true
        }).then((willDelete) => {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        DataTable.ajax.reload();
                    }
                }
            })
    })
}