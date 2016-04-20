using MVCHomework.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVCHomework.ViewModels
{
    public class RecordViewModel
    {
        /// <summary>
        /// 類別
        /// </summary>
        [Required]
        [Display(Name = "類別")]
        public CategoryType Category { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [Required,
        Display(Name = "金額")]
        public int Money { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Required,
        Display(Name = "日期")]
        public DateTime Date { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Required,
        Display(Name = "備註")]
        public string Description { get; set; }
    }
}