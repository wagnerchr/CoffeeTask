﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CoffeeTask.Entities
{
    [Table("task")]
    public class TaskEntity
    {
        public TaskEntity() { }

        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("priority")]
        public int? Priority { get; set; }

        [Column("creation_date")]
        public DateTime CreationDate { get; set; }

        [Column("due_date")]
        public DateTime? DueDate { get; set; }
    }
}
