﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pregunta1.Models
{
    public enum Places
    {
        Santa_Cruz,
        Montero,
        Concepcion,
        Warnes,
        Porongo
    };
    public class Marin
    {
        [Key]
        public int marinID { get; set; }

        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]
        public string FriendofMarin { get; set; }

        [Required]
        public Places place { get; set; }

        //Validacion para correos
        [DataType(DataType.EmailAddress, ErrorMessage = "Email no valido")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Cumpleaños")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:dd-MM-yyy)", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

    }
}