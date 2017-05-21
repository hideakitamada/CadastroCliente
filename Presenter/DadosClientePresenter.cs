using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Dados;

namespace Presenter
{
    public class DadosClientePresenter
    {
        /// <summary>
        ///Mensagem de retorno dos métodos utilizados como descrição de erro ou de sucesso a execução
        /// </summary>
        public string msg { get; set; }

        /// <summary>
        /// Lista os cliente por nome
        /// </summary>
        /// <param name="nome">Parâmetro do Tipo string</param>
        /// <returns>Lista de dados Cliente</returns>
        public List<ClienteDTO> ListarClientes(string nome)
        {
            List<ClienteDTO> lClienteDTO = new List<ClienteDTO>();

            using (localEntities db = new localEntities())
            {
                List<Cliente> lClientes = new List<Cliente>();

                if (string.IsNullOrEmpty(nome))
                    lClientes = db.Cliente.ToList();
                else
                    lClientes = db.Cliente.Where(x => x.Nome.ToUpper().Contains(nome.ToUpper())).ToList();

                lClientes.ForEach(x => lClienteDTO.Add(RetornaDados(x)));
            }

            return lClienteDTO;
        }

        /// <summary>
        /// Realiza a busca do cliente conforme ID
        /// </summary>
        /// <param name="id">Parâmetro do tipo Guid</param>
        /// <returns>Retorna o dado do cliente do tipo DTO</returns>
        public ClienteDTO RetornaClienteDTO(Guid id)
        {
            ClienteDTO clienteDTO = new ClienteDTO();
            Cliente cliente = RetornaCliente(id);

            clienteDTO = (cliente != null ? this.RetornaDados(cliente) : null);

            return clienteDTO;
        }

        /// <summary>
        /// Realiza a busca do cliente conforme ID
        /// </summary>
        /// <param name="id">Parâmetro do tipo Guid</param>
        /// <returns>Retorna os dados do cliente do Tipo Cliente</returns>
        private Cliente RetornaCliente(Guid id)
        {
            Cliente cliente = new Cliente();

            using (localEntities db = new localEntities())
            {
                cliente = db.Cliente.Where(x => x.Id.Equals(id)).FirstOrDefault();
            }

            return cliente;
        }

        /// <summary>
        /// Transforma os dados ClienteDTO para Cliente
        /// </summary>
        /// <param name="dados">Parâmetro do tipo Cliente</param>
        /// <returns>Retorna os dados do cliente do Tipo Cliente</returns>
        private Cliente RetornaDados(ClienteDTO dados)
        {
            return new Cliente
            {
                Celular = dados.Celular,
                CEP = dados.CEP,
                Email = dados.Email,
                Endereco = dados.Endereco,
                Id = dados.Id,
                Nome = dados.Nome,
                Telefone = dados.Telefone
            };
        }

        /// <summary>
        /// Transforma os dados Cliente para ClienteDTO
        /// </summary>
        /// <param name="dados">Parâmetro do tipo Cliente</param>
        /// <returns>Retorna os dados do cliente do Tipo ClienteDTO</returns>
        private ClienteDTO RetornaDados(Cliente dados)
        {
            return new ClienteDTO
            {
                Celular = dados.Celular,
                CEP = dados.CEP,
                Email = dados.Email,
                Endereco = dados.Endereco,
                Id = dados.Id,
                Nome = dados.Nome,
                Telefone = dados.Telefone
            };
        }

        /// <summary>
        /// Exclui o Regitro do cliente
        /// </summary>
        /// <param name="idCliente">Parâmetro do tipo Guid</param>
        /// <returns>Retorna o sucesso na execução</returns>
        public bool ExcluirCliente(Guid idCliente)
        {
            bool sucesso = false;

            try
            {
                using (localEntities db = new localEntities())
                {
                    Cliente cliente = this.RetornaCliente(idCliente);
                    if (cliente != null)
                    {
                        //db.Cliente.Remove(cliente);
                        db.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        sucesso = true;

                        msg = "Registro do cliente excluir com sucesso";
                    }
                }
            }
            catch (Exception ex)
            {
                sucesso = false;

                msg = "Erro ao excluir registro do Cliente!!!" + Environment.NewLine +
                    "Mensagem: " + ex.Message + Environment.NewLine +
                    "InnerException: " + ex.InnerException;
            }

            return sucesso;
        }

        /// <summary>
        /// Persiste os dados do Cliente
        /// </summary>
        /// <param name="dadosDto">Parâmetro do tipo ClienteDTO</param>
        /// <returns>Retorna o sucesso na execução</returns>
        public bool PersistirCliente(ClienteDTO dadosDto)
        {
            bool sucesso = false;

            try
            {
                Cliente cliente = RetornaDados(dadosDto);

                using (localEntities db = new localEntities())
                {
                    if (db.Cliente.Count(x => x.Id.Equals(cliente.Id)) > 0)
                    {
                        //db.Cliente.Attach(cliente);
                        db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                        msg = "Cliente alterado com Sucesso!";
                        sucesso = true;
                    }
                    else
                    {
                        if (db.Cliente.Count(x => x.Nome.ToUpper().Equals(cliente.Nome.ToUpper())) > 0)
                            msg = "Já existe uma Cliente com esse nome!";
                        else
                        {
                            //db.Cliente.Add(cliente);
                            db.Entry(cliente).State = System.Data.Entity.EntityState.Added;
                            msg = "Cliente cadastrado com Sucesso!";
                            sucesso = true;
                        }
                    }

                    if (sucesso)
                        db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                sucesso = false;
                msg = "Erro ao persistir dados do cliente!!!" + Environment.NewLine +
                    "Mensagem: " + ex.Message + Environment.NewLine +
                    "InnerException: " + ex.InnerException;
            }

            return sucesso;
        }
    }
}
