﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKLab2
{
    public partial class Cost : Form
    {
        public Cost()
        {
            InitializeComponent();
        }

        public string LabelCost
        {
            get { return labelCost.Text; }
            set { labelCost.Text = value; }
        }
    }
}
