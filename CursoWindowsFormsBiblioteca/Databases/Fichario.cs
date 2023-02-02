﻿using System;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class Fichario
    {
        public string diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;

            try
            {
                if (!File.Exists(Diretorio))
                {
                    Directory.CreateDirectory(Diretorio);
                }

                diretorio = Diretorio;

                mensagem = "Conexao criada com sucesso!";

            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexao com erro! " + ex.Message;

            }
        }

        public void Incluir(string id, string jsonunit)
        {
            status = true;
            try
            {
                if (File.Exists(diretorio + "\\" + id + ".json"))
                {
                    status = false;
                    mensagem = "Unclusão não permitida por que o identificador já existe!";
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + id + ".json", jsonunit);
                    status = true;
                    mensagem = "Inclusão realizada com sucesso!";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Unclusão não permitida por que o identificador já existe! " + ex.Message;
            }
        }
    }
}
