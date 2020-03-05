using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Aluno : Entity
    {
        public int turmaId { get; set; }
        public string nome { get; set; }
        public Turma turma { get; set; }
        public List<Prova> provas { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();
            
            if (turmaId == 0)
                erros.Add("A turma precisa ser informada!");
            if (string.IsNullOrEmpty(nome))
                erros.Add("O nome precisa ser informado!");

            return erros.ToArray();
        }
    }
}
