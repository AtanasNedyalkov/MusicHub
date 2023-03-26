﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub.Data.Models;

public class Writer
{
    public Writer()
    {
        this.Songs = new HashSet<Song>();
    }

    [Key]
	public int Id { get; set; }

    public string? Pseudonym { get; set; }

    [MaxLength(ValidationConstants.WriterNameMaxLength)]
    public string Name { get; set; }

    public virtual ICollection<Song> Songs { get; set; }
}
