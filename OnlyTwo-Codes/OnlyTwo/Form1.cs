﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlyTwo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        //Metin İçerisinde Kelime Arama
        private void FindButton_Click(object sender, EventArgs e)
        {
            int index = 0;
            PlainRichTextBox.Text = PlainRichTextBox.Text.ToLower();
            FindTextBox.Text = FindTextBox.Text.ToLower();

            while (index < PlainRichTextBox.Text.LastIndexOf(FindTextBox.Text))
            {
                PlainRichTextBox.Find(FindTextBox.Text, index, PlainRichTextBox.TextLength, RichTextBoxFinds.None);
                PlainRichTextBox.SelectionBackColor = Color.Yellow;
                index = PlainRichTextBox.Text.IndexOf(FindTextBox.Text, index) + 1;
            }          
        }
    }
}
