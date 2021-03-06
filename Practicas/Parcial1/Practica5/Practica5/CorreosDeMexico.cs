﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Practica5 {
    class CorreosDeMexico : Observable {
        System.Timers.Timer aTimer = new System.Timers.Timer();
        String message = "CMEX Update";

        public CorreosDeMexico() {
            aTimer.Elapsed += new ElapsedEventHandler(dailyUpdate);
            aTimer.Interval = 12000;
            aTimer.Enabled = true;
        }

        public void dailyUpdate(object source, ElapsedEventArgs e) {
            notify(message);
        }
    }
}
