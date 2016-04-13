using System.ComponentModel.DataAnnotations;

namespace MVCHomework.Models
{
    public enum CategoryType
    {
        /// <summary>
        /// 支出
        /// </summary>
        [Display(Name = "支出")]
        Pay = 1,

        /// <summary>
        /// 收入
        /// </summary>
        [Display(Name = "收入")]
        Income = 2
    }
}