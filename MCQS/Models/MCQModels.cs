using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MCQS.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Category Name")]
        public string  Name { get; set; }

    }
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Question")]
        public string QString { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
    public class Option
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Option")]
        public string Name { get; set; }


        public bool IsCorrect { get; set; }
        public int QuectionId { get; set; }
        public Question Question { get; set; }

    }
}
