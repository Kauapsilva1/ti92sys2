using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public class Cliente
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }

        public DateTime Data { get; set; }

        public bool Ativo { get; set; }

        public Cliente(string _nome, string _cpf, string _email, DateTime _data, bool _ativo)
        {
            Nome = _nome;
            Cpf = _cpf;
            Email = _email;
            Data = _data;
            Ativo = _ativo;
        }
        public Cliente(int _id,string _nome, string _cpf, string _email, DateTime _data, bool _ativo)
        {
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Email = _email;
            Data = _data;
            Ativo = _ativo;
        }


        public void Inserir()
        {
            // gravar um novo nivel na tabela niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) values ('" + Nome + "', '" + Cpf + "','" + Email + "','" + Data + "','" + Ativo + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> Lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) //enquanto houver proximo registro
            {
                Lista.Add
                (new Cliente(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), (dr.GetString(3)), dr.GetDateTime(4), dr.GetBoolean(5)));
            }
            return Lista;
        }
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes where id =" + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cliente.Id = dr.GetInt32(0);
                cliente.Nome = dr.GetString(1);
                cliente.Cpf = dr.GetString(2);
                cliente.Email = dr.GetString(3);
                cliente.Data = dr.GetDateTime(4);
                cliente.Ativo = dr.GetBoolean(5);
            }

            return cliente;

        }
        public static void Atualizar(Cliente cliente)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update clientes set nome = '" +
                cliente.Nome + "', cpf = '" + cliente.Cpf +
                "', '"+ cliente.Email +"', cpf = '" + cliente.Cpf +
                "', '"+cliente.Data+"', '"+cliente.Ativo+"'  where id = " + cliente.Id;

        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "deleted from clientes where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Cliente> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Cliente> lista = new List<Cliente>();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                         dr.GetInt32(0), dr.GetString(1), dr.GetString(2), dr.GetString(3), dr.GetDateTime(4), dr.GetBoolean(5)));
            }
            return lista;
        }

    }
}