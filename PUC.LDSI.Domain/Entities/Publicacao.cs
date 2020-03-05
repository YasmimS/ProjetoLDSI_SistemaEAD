using System;
using System.Collections.Generic;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Publicacao : Entity
    {
        public int avalicaoId { get; set; }
        public int turmaId { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public int valorProva { get; set; }
        public Avaliacao avaliacao { get; set; }
        public Turma turma { get; set; }

        public override string[] Validate()
        {
            var erros = new List<string>();

            if (avalicaoId == 0)
                erros.Add("A avaliação precisa ser informada!");
            if (turmaId == 0)
                erros.Add("A turma precisa ser informada!");
            if (dataInicio.Equals(DateTime.MinValue))
                erros.Add("A data de inicio precisa ser informada!");
            if (dataFim.Equals(DateTime.MinValue))
                erros.Add("A data de fim precisa ser informada!");
            if (valorProva == 0)
                erros.Add("O valor da prova precisa ser informado!");

            return erros.ToArray();
        }
    }
}
