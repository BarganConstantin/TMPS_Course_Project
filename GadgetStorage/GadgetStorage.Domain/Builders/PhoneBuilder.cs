﻿using GadgetStorage.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetStorage.Domain.Builders
{
    public class PhoneBuilder : AbstractPhoneBuilder
    {
        public override AbstractPhone Build()
        {
            return new Phone(this);
        }
    }
}
