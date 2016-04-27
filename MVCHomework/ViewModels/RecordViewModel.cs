using MVCHomework.Models;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using MVCHomework.Infra;

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
        [Required]
        [Display(Name = "金額")]
        [DataType(DataType.Currency)]
        [Range(1, int.MaxValue, ErrorMessage = "金額必須為正整數")]
        public int Money { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Required]
        [DataType(DataType.Date)]
        [CurrentDateValidation]
        [Display(Name = "日期")]
        public DateTime Date { get; set; }

        /// <summary>
        /// 備註
        /// </summary>
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(100, ErrorMessage = "最多只能輸入100個字元")]
        [DisplayName("備註")]
        public string Description { get; set; }
    }
}