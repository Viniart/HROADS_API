using senai_hroads_webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_hroads_webApi.Interfaces
{
    interface IHabilidadeRepository
    {

        List<Habilidade> Listar();

        Habilidade BuscarPorId(int id);

        void Cadastrar(Habilidade novaHabilidade);

        void Atualizar(int id, Habilidade habilidadeAtualizada);

        void Deletar(int id);
    }
}
