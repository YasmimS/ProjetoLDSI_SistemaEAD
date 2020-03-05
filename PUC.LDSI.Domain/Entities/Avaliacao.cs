using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Avaliacao : Entity
    {
        public int professorId { get; set; }
        public string disciplina { get; set; }
        public string materia { get; set; }
        public string descricao { get; set; }
        public Professor professor { get; set; }
        public List<QuestaoAvaliacao> questoesAvaliacoes { get; set; }
        public List<Prova> provas { get; set; }
        public List<Publicacao> publicacoes { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (professorId == 0)
                erros.Add("O professor(a) precisa ser informado(a)!");
            if (string.IsNullOrEmpty(disciplina))
                erros.Add("A disciplina precisa ser informada!");
            if (string.IsNullOrEmpty(materia))
                erros.Add("A matéria precisa ser informada!");
            if (string.IsNullOrEmpty(descricao))
                erros.Add("A descrição precisa ser informada!");

            return erros.ToArray();
        }
    }
}
