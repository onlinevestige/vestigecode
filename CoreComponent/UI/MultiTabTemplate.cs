﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CoreComponent.UI
{
    public partial class MultiTabTemplate : Form
    {
        public MultiTabTemplate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            CoreComponent.Core.BusinessObjects.Common.CloseThisForm(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CoreComponent.Core.BusinessObjects.Common.CloseThisForm(this);
        }

     
    }
}
