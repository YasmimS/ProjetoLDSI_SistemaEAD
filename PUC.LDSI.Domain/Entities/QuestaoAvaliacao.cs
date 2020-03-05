using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoAvaliacao : Entity
    {
        public int avaliacaoId { get; set; }
        public int tipo { get; set; }
        public string enunciado { get; set; }
        public Avaliacao avaliacao { get; set; }
        public List<QuestaoProva> questoesProvas { get; set; }
        public List<OpcaoAvaliacao> opcoesAvaliacoes { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (avaliacaoId == 0)
                erros.Add("A avaliação precisa ser informada!");
            if (tipo == 0)
                erros.Add("O tipo precisa ser informado, são: 1 (Múltipla Escolha) ou 2 (Verdadeiro ou Falso)!");
            if (string.IsNullOrEmpty(enunciado))
                erros.Add("O enunciado precisa ser informado!");

            return erros.ToArray();
        }
    }
}
