using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoProva : Entity
    {
        public int opcaoAvaliacaoId { get; set; }
        public int questaoProvaId { get; set; }
        public bool resposta { get; set; }
        public OpcaoAvaliacao opcaoAvaliacao { get; set; }
        public QuestaoProva questaoProva { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (opcaoAvaliacaoId == 0)
                erros.Add("A opção da avaliação precisa ser informada!");
            if (questaoProvaId == 0)
                erros.Add("A questão da prova precisa ser informada!");

            return erros.ToArray();
        }
    }
}
