using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Models
{
    public class Filme
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Genero deve ter no máximo 30 caracteres")]
        public string Genero { get; set; }
        [Range(1,600,ErrorMessage = "A duração deve ser osde 1 à 600 minutos")]
        public int Duracao { get; set; }
    
    }
}
