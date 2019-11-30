﻿//******************************************************************************
// <copyright file="license.md" company="RawCMS project  (https://github.com/arduosoft/RawCMS)">
// Copyright (c) 2019 RawCMS project  (https://github.com/arduosoft/RawCMS)
// RawCMS project is released under GPL3 terms, see LICENSE file on repository root at  https://github.com/arduosoft/RawCMS .
// </copyright>
// <author>Daniele Fontani, Emanuele Bucarelli, Francesco Mina'</author>
// <autogenerated>true</autogenerated>
//******************************************************************************

namespace RawCMS.Library.Schema.Validation
{
    public class DateTimeValidation : BaseJavascriptValidator
    {
        public override string Type => "date";

        public override string Javascript
        {
            get
            {
                return @"

            ";
            }
        }

        //public override List<Error> Validate(JObject input, Field field)
        //{
        //    List<Error> errors = new List<Error>();
        //    if (field.Options != null)
        //    {
        //        if (input[field.Name] == null)
        //        {
        //            return errors; //null check is done on main validation
        //        }

        //        if (!DateTime.TryParse(input[field.Name].ToString(), out DateTime value))
        //        {
        //            errors.Add(new Error()
        //            {
        //                Code = "INVALID VALUE",
        //                Title = "Field " + field.Name + " has invalid format "
        //            });
        //            return errors;
        //        }

        //        if (field.Options["max"] != null)
        //        {
        //            if (DateTime.TryParse(field.Options["max"].ToString(), out DateTime max))
        //            {
        //                if (input[field.Name] != null && max.Subtract(value).TotalMilliseconds < 0)
        //                {
        //                    errors.Add(new Error()
        //                    {
        //                        Code = "INVALID VALUE",
        //                        Title = "Field " + field.Name + " too big"
        //                    });
        //                }
        //            }
        //        }

        //        if (field.Options["min"] != null)
        //        {
        //            ;
        //            if (DateTime.TryParse(field.Options["min"].ToString(), out DateTime min))
        //            {
        //                if (input[field.Name] != null && min.Subtract(value).TotalMilliseconds > 0)
        //                {
        //                    errors.Add(new Error()
        //                    {
        //                        Code = "INVALID VALUE",
        //                        Title = "Field " + field.Name + " too small"
        //                    });
        //                }
        //            }
        //        }
        //    }
        //    return errors;
        //}
    }
}