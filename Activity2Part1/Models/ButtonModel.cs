﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity2Part1.Models
{
    public class ButtonModel
    {

        public bool state { get; set; }

        public ButtonModel(bool state)
        {
            this.state = state;
        }
    }
}