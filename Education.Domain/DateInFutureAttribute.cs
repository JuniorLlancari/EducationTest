using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Education.Domain
{
    public class DateInFutureAttribute:ValidationAttribute
    {
        private readonly Func<DateTime> _dateTimeNowProvider;

        public DateInFutureAttribute() :this(()=>DateTime.Now)
        {

        }

        public DateInFutureAttribute(Func<DateTime> dateTimeNowProvider)
        {
            _dateTimeNowProvider=dateTimeNowProvider;
            ErrorMessage = "La fecha debe ser mayor al dia actual";
        }
        public override bool IsValid(object obj)
        {
            bool isValid = false;
            if(obj is DateTime dateTime)
            {
                isValid = dateTime > _dateTimeNowProvider();
            }
            return isValid;
        }
    }
}
