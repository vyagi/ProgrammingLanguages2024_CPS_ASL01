﻿using System.ComponentModel.DataAnnotations;

namespace CodeFirstEf;

public class Author
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Name { get; set; }

    public ICollection<Book> Books { get; set; }
}