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
    
    public class RegistroCanal : IEnumerable<Canal> {
        private Registro registro = new Registro();
        
        public RegistroCanal() {
        
        }

        public void AdicionarC(Canal canal) {
            registro._BD.AdicionarCanal(canal);
        }
        
        public void AlterarC(int IdCanal, Canal canal) {
            registro._BD.AlterarCanal(IdCanal, canal);
        }

        public IEnumerator<Canal> GetEnumerator() {
            return registro._BD.ObterCanais().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return registro._BD.ObterCanais().GetEnumerator();
        }

        public IEnumerable<Canal> ObterCanais(string Filtro) {
            Filtro = Filtro.ToLower().Trim();
            
            if(string.IsNullOrEmpty(Filtro)) {
                return registro._BD.ObterCanais();
            } else {
                List<Canal> aux = new List<Canal>();
                
                foreach(Canal canal in registro._BD.ObterCanais())
                    if (ValidoC(canal, Filtro))
                        aux.Add(canal);
                return aux;
            }
        }
        
        public Canal ObterCanal(int IdCanal) {
            return registro._BD.ObterCanal(IdCanal);
        }


        public void ExcluirC(int IdCanal) {
            registro._BD.ExcluirCanal(IdCanal);
        }
        
        private bool ValidoC(Canal canal, string Filtro){
            return canal.NomeCanal.ToLower().Contains(Filtro);
        }
    }
}