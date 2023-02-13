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
        public int Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public DateTime Data { get; set; }

        public bool Ativo { get; set; }

        public Cliente(string _nome, int _cpf, string _email, DateTime _data, bool _ativo)
        {
            Nome = _nome;
            Cpf = _cpf;
            Email = _email;
            Data = _data;
            Ativo = _ativo;
        }
        public Cliente(int _id,string _nome, int _cpf, string _email, DateTime _data, bool _ativo)
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
        public static List<Usuario> Listar()
        {
            List<Usuario> Lista = new List<Usuario>();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome asc";
            var dr = cmd.ExecuteReader();
            while (dr.Read()) //enquanto houver proximo registro
            {
                Lista.Add
                (new Usuario(dr.GetInt32(0), dr.GetString(1), dr.GetString(2), Nivel.ObterPorId(dr.GetInt32(3)), dr.GetString(4), dr.GetBoolean(5)));
            }
            // retorna a lista prenchida
            return Lista;
        }
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis where id =" + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                Nivel.ObterPorId(dr.GetInt32(3));
                usuario.Senha = dr.GetString(4);
                usuario.Ativo = dr.GetBoolean(5);
            }

            return usuario;

        }
        public static void Atualizar(Nivel nivel)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update usuarios set nome = '" +
                nivel.Nome + "', sigla = '" + nivel.Sigla +
                "' where id = " + nivel.Id;

        }
        public bool Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delet from niveis where id = " + _id;
            bool result = cmd.ExecuteNonQuery() == 1 ? true : false;
            return result;
        }
        public static List<Usuario> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from usuarios where nome like '%" + _parte + "%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();
            while (dr.Read())
            {
                lista.Add(new Usuario(
                         dr.GetInt32(0), dr.GetString(1), dr.GetString(2), Nivel.ObterPorId(dr.GetInt32(3)), dr.GetString(4), dr.GetBoolean(5)));
            }
            return lista;
        }

    }
}