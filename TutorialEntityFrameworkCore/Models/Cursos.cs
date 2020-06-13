using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TutorialEntityFrameworkCore.Models
{
    class Cursos
    {[Key]
        public int CursoId { get; set; }
        public string NombreCurso { get; set; }
    }
}
