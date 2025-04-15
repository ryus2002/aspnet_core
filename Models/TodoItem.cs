using System;
using System.ComponentModel.DataAnnotations;

namespace MyFirstWebApp.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "待辦事項")]
        public string Title { get; set; }

        [Display(Name = "描述")]
        public string Description { get; set; }

        [Display(Name = "是否完成")]
        public bool IsDone { get; set; }

        [Display(Name = "創建日期")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}