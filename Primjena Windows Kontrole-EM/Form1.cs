﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primjena_Windows_Kontrole_EM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProgramiCombobox.Text == "Notepad")
                System.Diagnostics.Process.Start(@"C:\Windows\System32\Notepad.exe");
            else
                System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");

          
        }
    }
}
