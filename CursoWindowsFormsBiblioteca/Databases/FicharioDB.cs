using System;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string Tabela;
        public LocalDBClass db;

        public FicharioDB(string tabela)
        {
            status = true;

            try
            {
                db = new LocalDBClass();
                Tabela = tabela;
                mensagem = "Conexão com a tabela criada com sucesso!";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com a tabela com erro! " + ex.Message;
            }
        }

        public void Incluir(string id, string jsonunit)
        {
            status = true;
            try
            {

                var SQL = "INSERT INTO " + Tabela + "(id, json) values ('" + id + "','" + jsonunit + "')";
                db.SQLComand(SQL);

                status = true;
                mensagem = "Inclusão realizada com sucesso! Identificador: " + id + ".";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Inclusão não permitida por que o identificador já existe! " + ex.Message;
            }
        }
        public string Buscar(string id)
        {
            status = true;
            try
            {
                var SQL = "SELECT ID, JSON FROM " + Tabela + " WHERE id = '" + id + "'";
                var dt = db.SQLQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    mensagem = "Identificador encontrado!";
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existe!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }

            return "";
        }


    }
}
