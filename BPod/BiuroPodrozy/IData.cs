﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiuroPodrozy
{
    interface IData
    {
        void UstawDate(DateTime data);
        bool SprawdzDate();
    }
}
