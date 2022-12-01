﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERPv1.Infrastructure.Extensions
{
    public static class EnumExtension
    {
        public static IEnumerable<SelectListItem>GetEnumSelectList<T>()
        {
            return (Enum.GetValues(typeof(T)).Cast<int>()
                   .Select(e => new SelectListItem()
                    {
                        Text = Enum.GetName(typeof(T), e),
                        Value = e.ToString()
                    })).ToList();
        }
    }
}
