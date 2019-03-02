/*
 * FAETERJ Petrópolis – Programação em Ambiente Visual
 * Alexandra Miguel Raibolt da Silva
 * 2017.1
 */

using System;
using System.Linq;

namespace StreamIPTV.Negocio {
	
    public class Canal {
        private int _IdCanal;
        
        public int IdCanal {
            get {
        		return _IdCanal;
        	}
        	
            set {
        		_IdCanal = value;
        	}
        }
        
        private string _LogoCanal;
        
        public string LogoCanal {
            get {
        		return _LogoCanal;
        	}
        	
            set {
        		_LogoCanal = value;
        	}
        }
        
        private string _NomeCanal;
        
        public string NomeCanal {
            get {
        		return _NomeCanal;
        	}
        	
            set {
        		_NomeCanal = value;
        	}
        }
        
        private string _GrupoCanal;
        
        public string GrupoCanal {
            get {
        		return _GrupoCanal;
        	}
        	
            set {
        		_GrupoCanal = value;
        	}
        }
        
        private string _CodigoDesbloqueioCanal;
        
        public string CodigoDesbloqueioCanal {
            get {
        		return _CodigoDesbloqueioCanal;
        	}
        	
            set {
        		_CodigoDesbloqueioCanal = value;
        	}
        }
                
        private string _URLCanal;
        
        public string URLCanal {
            get {
        		return _URLCanal;
        	}
        	
            set {
        		_URLCanal = value;
        	}
        }
    }
}
