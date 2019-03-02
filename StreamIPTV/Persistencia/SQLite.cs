/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using StreamIPTV.Negocio;

namespace StreamIPTV.Persistencia {
	
    public class SQLite {
        private string _StrConexao;

        public SQLite(string Banco) {
            _StrConexao = string.Format("Data Source={0};Version=3", Banco);
            
            /* Se o banco não existir */
            if(!System.IO.File.Exists(Banco)) {
            	/* Chama o método para criar o Banco de Dados SQL */
                CriarBanco(Banco);
            }
        }

        private void CriarBanco(string nomeBanco) {
        	/* Cria o Banco de Dados SQL */
            SQLiteConnection.CreateFile(nomeBanco);
            
            /* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
            	
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para criar a tabela Usuário */
                using (SQLiteCommand SQL = new SQLiteCommand("CREATE TABLE Usuario (idUsuario INTEGER PRIMARY KEY AUTOINCREMENT, loginUsuario VARCHAR(13) NOT NULL, senhaUsuario VARCHAR(13) NOT NULL, nomeUsuario VARCHAR(100) NOT NULL, CONSTRAINT loginUnique UNIQUE (loginUsuario))")) {
                    SQL.Connection = conexao;
                    SQL.ExecuteNonQuery();
                }
                
                /* Comando SQL para criar a tabela Canal */
                using (SQLiteCommand SQL = new SQLiteCommand("CREATE TABLE Canal (idCanal INTEGER PRIMARY KEY AUTOINCREMENT, logoCanal BLOB, nomeCanal VARCHAR(100) NOT NULL, grupoCanal VARCHAR(50) NOT NULL, codigoDesbloqueioCanal VARCHAR(4), URLCanal VARCHAR(100) NOT NULL, CONSTRAINT nomeUnique UNIQUE (nomeCanal), CONSTRAINT URLUnique UNIQUE (URLCanal))")) {
                    SQL.Connection = conexao;
                    SQL.ExecuteNonQuery();
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
        }
        
        public void AdicionarUsuario(Usuario usuario){
        	/* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
        		
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para adicionar usuário */
                using (SQLiteCommand SQL = new SQLiteCommand("INSERT INTO Usuario (loginUsuario, senhaUsuario, nomeUsuario) VALUES (@loginUsuario, @senhaUsuario, @nomeUsuario)")) {
                    SQL.Connection = conexao;
                    SQL.Prepare();
                    SQL.Parameters.AddWithValue("@loginUsuario", usuario.LoginUsuario);
                    SQL.Parameters.AddWithValue("@senhaUsuario", usuario.SenhaUsuario);
                    SQL.Parameters.AddWithValue("@nomeUsuario", usuario.NomeUsuario);
                    SQL.ExecuteNonQuery();
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
        }
        
        public void AlterarUsuario(int idUsuario, Usuario usuario) {
        	/* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
        		
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para alterar/atualizar usuário */
                using (SQLiteCommand SQL = new SQLiteCommand("UPDATE Usuario SET loginUsuario=@loginUsuario, senhaUsuario=@senhaUsuario, nomeUsuario=@nomeUsuario WHERE idUsuario=@idUsuario")) {
                    SQL.Connection = conexao;
                    SQL.Prepare();
                    SQL.Parameters.AddWithValue("@loginUsuario", usuario.LoginUsuario);
                    SQL.Parameters.AddWithValue("@senhaUsuario", usuario.SenhaUsuario);
                    SQL.Parameters.AddWithValue("@nomeUsuario", usuario.NomeUsuario);
                    SQL.Parameters.AddWithValue("@idUsuario", idUsuario);
                    SQL.ExecuteNonQuery();
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
        }

        public IEnumerable<Usuario> ObterUsuarios() {
            List<Usuario> list = new List<Usuario>();
            
            /* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
            	
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para selecionar usuários ordenado-os por ordem alfabética */
                SQLiteCommand SQL = new SQLiteCommand("SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario FROM Usuario ORDER BY nomeUsuario");
                SQL.Connection = conexao;
                
                using (SQLiteDataReader dataReader = SQL.ExecuteReader()) {
                    while (dataReader.Read()) {
                        Usuario usuario = new Usuario();
                        
                        usuario.IdUsuario = dataReader.GetInt32(0);
                        usuario.LoginUsuario = dataReader.GetString(1);
                        usuario.SenhaUsuario = dataReader.GetString(2);
                        usuario.NomeUsuario = dataReader.GetString(3);
                        
                        list.Add(usuario);
                    }
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
            
            return list;
        }
        
        public Usuario ObterUsuario(int idUsuario) {
            Usuario usuario = null;
            
            /* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
            	
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para selecionar usuário pelo ID */
                SQLiteCommand SQL = new SQLiteCommand("SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario FROM Usuario WHERE idUsuario=@idUsuario");
                SQL.Connection = conexao;
                SQL.Prepare();
                SQL.Parameters.AddWithValue("@idUsuario", idUsuario);
                
                using (SQLiteDataReader dataReader = SQL.ExecuteReader()) {
                    if (dataReader.Read()) {
                        usuario = new Usuario();
                        
                        usuario.IdUsuario = dataReader.GetInt32(0);
                        usuario.LoginUsuario = dataReader.GetString(1);
                        usuario.SenhaUsuario = dataReader.GetString(2);
                        usuario.NomeUsuario = dataReader.GetString(3);
                    }
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
            
            return usuario;
        }
        
        public void ExcluirUsuario(int idUsuario) {
        	/* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
        		
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para excluir usuário pelo ID */ 
                using (SQLiteCommand SQL = new SQLiteCommand("DELETE FROM Usuario WHERE idUsuario=@idUsuario")) {
                    SQL.Connection = conexao;
                    SQL.Prepare();
                    SQL.Parameters.AddWithValue("@idUsuario", idUsuario);
                    SQL.ExecuteNonQuery();
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
        }
        
        public void AdicionarCanal(Canal canal){
        	/* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
        		
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para adicionar canal */
                using (SQLiteCommand SQL = new SQLiteCommand("INSERT INTO Canal (logoCanal, nomeCanal, grupoCanal, codigoDesbloqueioCanal, URLCanal) VALUES (@logoCanal, @nomeCanal, @grupoCanal, @codigoDesbloqueioCanal, @URLCanal)")) {
                    SQL.Connection = conexao;
                    SQL.Prepare();
                    SQL.Parameters.AddWithValue("@logoCanal", canal.LogoCanal);
                    SQL.Parameters.AddWithValue("@nomeCanal", canal.NomeCanal);
                    SQL.Parameters.AddWithValue("@grupoCanal", canal.GrupoCanal);
                    SQL.Parameters.AddWithValue("@codigoDesbloqueioCanal", canal.CodigoDesbloqueioCanal);
                    SQL.Parameters.AddWithValue("@URLCanal", canal.URLCanal);
                    SQL.ExecuteNonQuery();
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
        }
        
        public void AlterarCanal(int idCanal, Canal canal) {
        	/* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
        		
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para alterar/atualizar canal */
                using (SQLiteCommand SQL = new SQLiteCommand("UPDATE Canal SET logoCanal=@logoCanal, nomeCanal=@nomeCanal, grupoCanal=@grupoCanal, codigoDesbloqueioCanal=@codigoDesbloqueioCanal, URLCanal=@URLCanal WHERE idCanal=@idCanal")) {
                    SQL.Connection = conexao;
                    SQL.Prepare();
                    SQL.Parameters.AddWithValue("@logoCanal", canal.LogoCanal);
                    SQL.Parameters.AddWithValue("@nomeCanal", canal.NomeCanal);
                    SQL.Parameters.AddWithValue("@grupoCanal", canal.GrupoCanal);
                    SQL.Parameters.AddWithValue("@codigoDesbloqueioCanal", canal.CodigoDesbloqueioCanal);
                    SQL.Parameters.AddWithValue("@URLCanal", canal.URLCanal);
                    SQL.Parameters.AddWithValue("@idCanal", idCanal);
                    SQL.ExecuteNonQuery();
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
        }

        public IEnumerable<Canal> ObterCanais() {
            List<Canal> list = new List<Canal>();
            
            /* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
            	
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para selecionar canais ordenado-os por ordem alfabética */
                SQLiteCommand SQL = new SQLiteCommand("SELECT idCanal, logoCanal, nomeCanal, grupoCanal, codigoDesbloqueioCanal, URLCanal FROM Canal ORDER BY nomeCanal");
                SQL.Connection = conexao;
                
                using (SQLiteDataReader dataReader = SQL.ExecuteReader()) {
                    while (dataReader.Read()) {
                        Canal canal = new Canal();
                        
                        canal.IdCanal = dataReader.GetInt32(0);
                        //canal.LogoCanal = (byte[])dataReader.GetValue(1);
                        canal.NomeCanal = dataReader.GetString(2);
                        canal.GrupoCanal = dataReader.GetString(3);
                        canal.CodigoDesbloqueioCanal = dataReader.GetString(4);
                        canal.URLCanal = dataReader.GetString(5);
                        
                        list.Add(canal);
                    }
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
            
            return list;
        }
        
        public Canal ObterCanal(int idCanal) {
            Canal canal = null;
            
            /* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
            	
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para selecionar canal pelo ID */
                SQLiteCommand SQL = new SQLiteCommand("SELECT idCanal, logoCanal, nomeCanal, grupoCanal, codigoDesbloqueioCanal, URLCanal FROM Canal WHERE idCanal=@idCanal");
                SQL.Connection = conexao;
                SQL.Prepare();
                SQL.Parameters.AddWithValue("@idCanal", idCanal);
                
                using (SQLiteDataReader dataReader = SQL.ExecuteReader()) {
                    if (dataReader.Read()) {
                        canal = new Canal();
                        
                        canal.IdCanal = dataReader.GetInt32(0);
                        //canal.LogoCanal = (byte[])dataReader.GetValue(1);
                        canal.NomeCanal = dataReader.GetString(2);
                        canal.GrupoCanal = dataReader.GetString(3);
                        canal.CodigoDesbloqueioCanal = dataReader.GetString(4);
                        canal.URLCanal = dataReader.GetString(5);
                    }
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
            
            return canal;
        }
        
        public void ExcluirCanal(int idCanal) {
        	/* Cria conexão com o Banco de Dados SQL */
            using (SQLiteConnection conexao = new SQLiteConnection(_StrConexao)) {
        		
            	/* Abre conexão com o Banco de Dados SQL */
                conexao.Open();
                
                /* Comando SQL para excluir canal pelo ID */ 
                using (SQLiteCommand SQL = new SQLiteCommand("DELETE FROM Canal WHERE idCanal=@idCanal")) {
                    SQL.Connection = conexao;
                    SQL.Prepare();
                    SQL.Parameters.AddWithValue("@idCanal", idCanal);
                    SQL.ExecuteNonQuery();
                }
                
                /* Fecha conexão com o Banco de Dados SQL */
                conexao.Close();
            }
        }
    }
}