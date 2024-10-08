﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // AbstractFactory
    public interface IInternaltionalFactory
    {
        ILanguage CreateLanguage();
        ICapitalCity CreateCapitalCity();
    }
}
