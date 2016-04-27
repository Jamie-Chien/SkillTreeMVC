using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCHomework.Infra
{
    public class CurrentDateValidation : ValidationAttribute
    {
        public CurrentDateValidation() : base()
        {
            ErrorMessage = "不可大於今日";
        }

        public override bool IsValid(object value)
        {
            bool isPass = false;
            if (value == null)
            {
                isPass = true;
            }
            else if (value is DateTime)
            {
                isPass = ((DateTime)value) <= DateTime.Now;
            }
            return isPass;
        }
    }
}