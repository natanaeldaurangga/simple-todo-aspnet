using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Entities
{
    [Table("todos")]
    public class Todo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // [Column(name:"id")] // bisa dikasih nama column seperti ini
        public int Id { get; set; }

        [Required]
        public string? Task { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    }
}