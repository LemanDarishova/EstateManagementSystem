﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ems.Core.Wrappers.Concrete;

public class ResponseValidationResult
{
    public string ErrorMessage { get; set; }
    public string PropertyName { get; set; }
}
