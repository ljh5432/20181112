﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private Button btn;

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                btn = new Button();
                btn.DialogResult = DialogResult.OK;
                btn.Name = string.Format("btn_{0}", (i + 1));
                btn.Text = string.Format("확인 : {0}", (i+1));
                btn.Size = new Size(100, 50);
                btn.Location = new Point((100 * i ) + 30, 30);
                btn.Cursor = Cursors.Hand;

                Controls.Add(btn);
                btn.Click += btn_click;
            }
            
        }

        private void btn_click(object o, EventArgs a)
        {
            string names = "";
            foreach (Control ct in Controls)
            {
                // names += ct.Name + " ";
                if(ct.Name != "btn_3")
                {
                    ct.BackColor = Color.Silver;
                }                
            }
            // MessageBox.Show(names);

            btn = (Button) o;
            btn.BackColor = (btn.BackColor == Color.Green) ? btn.BackColor = Color.Silver : btn.BackColor = Color.Green;                     
        }
    }
}
