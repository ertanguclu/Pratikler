﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek
{
    public class NewFocus : Otomobil
    {
        public override Marka HangiMarkaninAraci()
        {
            return Marka.Ford;
        }
    }
}
