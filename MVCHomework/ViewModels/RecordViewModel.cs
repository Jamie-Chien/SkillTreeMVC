using MVCHomework.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MVCHomework.ViewModels
{
    public class RecordViewModel
    {
        /// <summary>
        /// 編號
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// 型別
        /// </summary>
        [Required]
        public CategoryType Category { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        [Required]
        public decimal Money { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        public string Description { get; set; }
    }
}