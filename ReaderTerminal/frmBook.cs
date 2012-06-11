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

        }
        public frmBook(String bookName, String publisher, String author, String discription)
        {
            InitializeComponent();
            textBox1.Text = bookName;
            textBox2.Text = publisher;
            textBox3.Text = author;
            textBox4.Text = discription;
        }
    }
}
