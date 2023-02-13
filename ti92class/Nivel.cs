using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ti92class
{
    public class Nivel
    {
        private int id;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }


        // Metodos construtores
        public Nivel() { }
        public Nivel(string _nome, string _sigla) 
        {
            Nome= _nome;
            Sigla= _sigla;
        }
        public Nivel(int  _id,string _nome, string _sigla) 
        {
            Id= _id;
            Nome= _nome;
            Sigla= _sigla;
        }
        // metodos da classe

        public void Inserir()
        {
            // gravar um novo nivel na tabela niveis
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert niveis (nome, sigla) values ('" + Nome + "', '" + Sigla + "')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Nivel> Listar()
        {
            // 0 - entrega uma lista de todos os níveis (cria um espaço do tipo lista)
            List<Nivel>Lista = new List<Nivel>();
            // Logica que recupera todos os níveis da tabela
            // 1 - Abrir conexão no banco de dados
            var cmd = Banco.Abrir();
            // 2 - Definir Tipo de comando SQL (text/store procedure)
            cmd.CommandType = CommandType.Text;
            // 3 -Atribuir comando SQL (texto)
            cmd.CommandText = "select * from niveis order by nome asc";
            // 4 - Executar o comando e armazenar o retorno do banco em um objeto MysqlDataReader
            var dr = cmd.ExecuteReader();
            // 5 - prencher o List com o retorno do banco, se houver
            while (dr.Read()) //enquanto houver proximo registro
            {
                Lista.Add(new Nivel(dr.GetInt32(0),dr.GetString(1),dr.GetString(2))); 
            }
            // retorna a lista prenchida
            return Lista;
        }
        public static Nivel ObterPorId(int _id)
        {
            Nivel nivel = null;
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from niveis where id =" + _id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nivel.Id = dr.GetInt32(0);
                nivel.Nome = dr.GetString(1);
                nivel.Sigla= dr.GetString(2);
            }
            return nivel;
        }
        public static void Atualizar(Nivel nivel) 
        { 
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText= "update niveis set nome = '" +
                nivel.Nome+"', sigla = '"+nivel.Sigla +
                "' where id = "+ nivel.Id;

        }
        public bool Excluir(int _id) 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delet from niveis where id = " + _id;
            bool result = cmd.ExecuteNonQuery()==1?true:false;
            return result;
        }
        public static List<Nivel> BuscarPorNome(string _parte)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from niveis where nome like '%"+_parte+"%' order by nome;";
            var dr = cmd.ExecuteReader();
            List<Nivel> lista = new List<Nivel>();
            while (dr.Read())
            {
                lista.Add(new Nivel(
                         dr.GetInt32(0),dr.GetString(1),dr.GetString(2)                        
                    )
                );
            }
            return lista;
        }

    }
}