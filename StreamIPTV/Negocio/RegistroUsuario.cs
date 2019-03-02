/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace StreamIPTV.Negocio {
	
    public class RegistroUsuario : IEnumerable<Usuario> {
		private Registro registro = new Registro();
        
        public RegistroUsuario() {
        
        }

        public void AdicionarU(Usuario usuario) {
            registro._BD.AdicionarUsuario(usuario);
        }
        
        public void AlterarU(int IdUsuario, Usuario usuario) {
            registro._BD.AlterarUsuario(IdUsuario, usuario);
        }

        public IEnumerator<Usuario> GetEnumerator() {
            return registro._BD.ObterUsuarios().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return registro._BD.ObterUsuarios().GetEnumerator();
        }

        public IEnumerable<Usuario> ObterUsuarios(string Filtro) {
            Filtro = Filtro.ToLower().Trim();
            
            if(string.IsNullOrEmpty(Filtro)) {
                return registro._BD.ObterUsuarios();
            } else {
                List<Usuario> aux = new List<Usuario>();
                
                foreach (Usuario usuario in registro._BD.ObterUsuarios())
                    if(ValidoU(usuario, Filtro))
                        aux.Add(usuario);
                return aux;
            }
        }
        
        public Usuario ObterUsuario(int IdUsuario) {
            return registro._BD.ObterUsuario(IdUsuario);
        }


        public void ExcluirU(int IdUsuario) {
            registro._BD.ExcluirUsuario(IdUsuario);
        }
        
        private bool ValidoU(Usuario usuario, string Filtro){
            return usuario.NomeUsuario.ToLower().Contains(Filtro) || usuario.LoginUsuario.ToLower().Contains(Filtro);
        }
    }
}