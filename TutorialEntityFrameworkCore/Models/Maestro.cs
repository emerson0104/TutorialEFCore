using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TutorialEntityFrameworkCore.Models
{
    class Maestro
    {
        [Key]
        public int TeacherId { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }

        public Maestro()
        {
            TeacherId = 0;
            name = string.Empty;
            lastName = string.Empty;
        }
    }
}
