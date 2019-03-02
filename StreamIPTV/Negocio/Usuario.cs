/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */

using System;
using System.Linq;

namespace StreamIPTV.Negocio {
	
    public class Usuario {
        private int _IdUsuario;
        
        public int IdUsuario {
            get {
        		return _IdUsuario;
        	}
        	
            set {
        		_IdUsuario = value;
        	}
        }
        
        private string _LoginUsuario;
        
        public string LoginUsuario {
            get {
        		return _LoginUsuario;
        	}
        	
            set {
        		_LoginUsuario = value;
        	}
        }
        
        private string _SenhaUsuario;
        
        public string SenhaUsuario {
            get {
        		return _SenhaUsuario;
        	}
        	
            set {
        		_SenhaUsuario = value;
        	}
        }
        
        private string _NomeUsuario;
        
        public string NomeUsuario {
            get {
        		return _NomeUsuario;
        	}
        	
            set {
        		_NomeUsuario = value;
        	}
        }
    }
}
