using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoAvaliacao : Entity
    {
        public int questaoAvaliacaoId { get; set; }
        public string descricao { get; set; }
        public bool verdadeira { get; set; }
        public QuestaoAvaliacao questaoAvaliacao { get; set; }
        public List<OpcaoProva> opcoesProvas { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (questaoAvaliacaoId == 0)
                erros.Add("A questão da avaliação precisa ser informada!");
            if (string.IsNullOrEmpty(descricao))
                erros.Add("A descrição da opção avaliação precisa ser informada!");

            return erros.ToArray();
        }
    }
}
