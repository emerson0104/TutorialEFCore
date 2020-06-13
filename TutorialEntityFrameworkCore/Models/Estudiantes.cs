using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TutorialEntityFrameworkCore.Models
{
    class Estudiantes
    {[Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }


    }
}
