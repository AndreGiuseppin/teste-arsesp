var cadastrar = {

    DadosUsuarioDto: undefined,

    adicionarUsuario: function () {
        $.ajax({
            method: "POST",
            url: "/Cadastro/CadastrarUsuario",
            data: cadastrar.DadosUsuarioDto,
            dataType: "json",
            success: function (data) {

            },
            error: function (error) {

            }
        });
    },

    PreencherDadosUsuarioDto: function () {
        cadastrar.DadosUsuarioDto = {
            Nome: $('#Nome').val(),
            TelefoneResidencial: $('#TelefoneResidencial').val(),
            TelefoneCelular: $('#TelefoneCelular').val()
        }
    },

    listarUsuarios: function () {
        $('#tableUsuarios').DataTable({
            autoWidth: false,
            ordering: false,
            pageLength: 5,
            ajax: {
                type: "GET",
                dataType: "json",
                url: "/Cadastro/ListarUsuarios",
                dataSrc: "",
            },
            columns: [                
                { data: 'Nome' },
                { data: 'TelefoneResidencial' },
                { data: 'TelefoneCelular' },
                { data: '' },
            ],
            "columnDefs": [{
                "targets": 0,
                render: function (data, type, row) {
                    return '<center><button class="btn btn-dagnger btn-sm" onclick="cadastrar.deletarUsuario(' + row.Id + ')">Excluir</button><center>'
                }
            }],
        });
    },

    deletarUsuario: function (id) {
        $.ajax({
            method: "POST",
            url: "/Cadastro/DeletarUsuario",
            data: { id: id },
            dataType: "json",
            success: function (data) {
                $('#tableUsuarios').DataTable().destroy();
                cadastrar.listarUsuarios();
            },
            error: function (error) {

            }
        });
    },
};

$(document).ready(function () {
    cadastrar.listarUsuarios();

    $('#btnAdicionar').click(function () {
        cadastrar.PreencherDadosUsuarioDto();
        cadastrar.adicionarUsuario();
    });
});