﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4 {
    interface IObserver {
        void update(Observable obs, Object o);
    }
}
