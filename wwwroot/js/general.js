$(document).ready( function () {

    $('#dataTable').DataTable({
        "language": {
            "decimal":        "",
            "emptyTable":     "No se encontraron registros",
            "info":           "Mostrando _START_ a _END_ de _TOTAL_ registros",
            "infoEmpty":      "Mostrando 0 a 0 de 0 registros",
            "infoFiltered":   "(filtrado de un total de _MAX_ registros)",
            "infoPostFix":    "",
            "thousands":      ",",
            "lengthMenu":     "Mostrar _MENU_ registros",
            "loadingRecords": "Cargando...",
            "processing":     "Procesando...",
            "search":         "Buscar:",
            "zeroRecords":    "No se encontraron registros en la búsqueda",
            "paginate": {
                "first":      "Primero",
                "last":       "Último",
                "next":       "Próximo",
                "previous":   "Anterior"
            },
            "aria": {
                "sortAscending":  ": ordenar columna ascendente",
                "sortDescending": ": ordenar columna descendente"
            }
        }
    });

} );