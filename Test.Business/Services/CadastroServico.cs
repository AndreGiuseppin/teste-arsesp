using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Business.Dto;
using Test.Data.Context;
using Test.Data.Repository;

namespace Test.Business.Services
{
    public class CadastroServico
    {
        public void CadastrarUsuario(ContatoDto contato)
        {
            ContatoRepository contatoRepository = new ContatoRepository();

            var contatoDados = new Contato
            {
                Nome = contato.Nome,
                TelefoneResidencial = contato.TelefoneResidencial,
                TelefoneCelular = contato.TelefoneCelular
            };

            contatoRepository.CadastrarUsuario(contatoDados);
        }

        public ContatoDto ListarUsuarios()
        {
            ContatoRepository contatoRepository = new ContatoRepository();
            ContatoDto contatoDto = new ContatoDto();

            var retorno = contatoRepository.ListarUsuarios();

            foreach (var item in retorno)
            {
                contatoDto = new ContatoDto
                {
                    Nome = item.Nome,
                    TelefoneResidencial = item.TelefoneResidencial,
                    TelefoneCelular = item.TelefoneCelular
                };
            }

            return contatoDto;
        }

        public void DeletarUsuario(int id)
        {
            ContatoRepository contatoRepository = new ContatoRepository();
            contatoRepository.DeletarUsuario(id);
        }
    }
}
