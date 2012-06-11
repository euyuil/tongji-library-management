using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ReaderTerminal
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        public frmBook(String bookName, String publisher,
            String author, String discription)
        {
            InitializeComponent();
            textBox1.Text = bookName;
            textBox2.Text = publisher;
            textBox3.Text = author;
            textBox4.Text = discription;
            for (int i = 0; information[i] != null; ++i)
            {
                textBox5.Text = textBox5.Text + information[i] + System.Environment.NewLine;
            }
        }
    }
}
