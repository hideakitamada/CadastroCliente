﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presenter
{
    public class ClienteDTO
    {
        public System.Guid Id { get; set; }
        public string Nome { get; set; }
        public string CEP { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
