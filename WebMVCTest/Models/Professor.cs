using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVCTest.Models
{
    public class Professor
    {
        public int ProfessorId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Disciplina> Disciplinas { get; set; }
    }
}