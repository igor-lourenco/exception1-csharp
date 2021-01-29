using System;
using System.Collections.Generic;
using System.Text;

namespace Exception1.Entidades.Exceptions {
    class DominioException : ApplicationException{

        public DominioException(string mensagem) : base(mensagem) {

        }
    }
}
