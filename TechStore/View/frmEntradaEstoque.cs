﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStore.View
{
    public partial class frmEntradaEstoque : Form
    {
        public frmEntradaEstoque()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbId.Text = "";
            tbProduto.Text = "";
        }
    }
}
