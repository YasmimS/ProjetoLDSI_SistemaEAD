using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Prova : Entity
    {
        public int avaliacaoId { get; set; }
        public int alunoId { get; set; }
        public DateTime dataProva { get; set; }
        public decimal notaObtida { get; set; }
        public Avaliacao avaliacao { get; set; }
        public Aluno aluno { get; set; }
        public List<QuestaoProva> questoesProvas { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (avaliacaoId == 0)
                erros.Add("A avaliação precisa ser informada!");
            if (alunoId == 0)
                erros.Add("O aluno precisa ser informado!");
            if (dataProva.Equals(DateTime.MinValue))
                erros.Add("A data da prova precisa ser informada!");

            return erros.ToArray();
        }
    }
}
