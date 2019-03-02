/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */

using System;
using System.Linq;
using StreamIPTV.Persistencia;

namespace StreamIPTV.Negocio {
	
    public class Registro {
        public SQLite _BD;
        
        public Registro() {
            _BD = new SQLite("dados.db");
        }  
    }
}