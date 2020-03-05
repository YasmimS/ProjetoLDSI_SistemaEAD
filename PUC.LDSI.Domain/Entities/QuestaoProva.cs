using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoProva : Entity
    {
        public int questaoAvaliacaoId { get; set; }
        public int provaId { get; set; }
        public decimal nota { get; set; }
        public QuestaoAvaliacao questaoAvaliacao { get; set; }
        public Prova prova { get; set; }
        public List<OpcaoProva> opcoesProvas { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (questaoAvaliacaoId == 0)
                erros.Add("A questão da avaliação precisa ser informada!");
            if (provaId == 0)
                erros.Add("A prova precisa ser informada!");

            return erros.ToArray();
        }
    }
}
