using System;
using System.Collections.Generic;

namespace ACC.Fundos.Contract.ResponseDTO
{
    public class RetornoDTO<T>
    {
        public T Retorno { get; set; }
        public string Identificador { get; set; }
        public bool Sucesso { get; set; }
        public List<Exception> Exception { get; set; }
    }
}
