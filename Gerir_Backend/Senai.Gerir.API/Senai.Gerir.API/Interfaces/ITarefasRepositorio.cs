using Senai.Gerir.API.Dominios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Gerir.API.Interfaces
{
    interface ITarefaRepositorio
    {
        Tarefa Cadastrar(Tarefa tarefa);
        List<Tarefa> ListarTodos(Guid IdUsuarios);
        Tarefa AlterarStatus(Guid IdTarefa);
        void Remover(Guid Idtarefa);
        Tarefa Editar(Tarefa tarefa);
        Tarefa BuscarporId(Guid Idtarefa);
    }
}