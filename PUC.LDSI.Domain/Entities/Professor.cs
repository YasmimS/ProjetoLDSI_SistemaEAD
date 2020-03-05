using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Professor : Entity
    {
        public string nome { get; set; }
        public List<Avaliacao> avaliacoes { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O nome precisa ser informado!");

            return erros.ToArray();
        }
    }
}
