using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsGrade
{
    public partial class Form1 : Form
    {
        int score;
        double grade;
        public Form1()
        {
            InitializeComponent();
        }

        private void oOK_Click(object sender, EventArgs e)
        {
            score = Convert.ToInt32(tScore.Text);
            if (score<=49)
            {
                grade = 0;
            }
            else if (score<= 54 )
            {
                grade = 1;  
            }
            else if (score<= 59 )
            {
                grade = 1.5;
            }
            else if (score<= 64) 
            {
                grade = 2;
            }
            else if (score <= 69)
            {
                grade = 2.5;
            }
            else if (score <= 74)
            {
                grade = 3;
            }
            else if (score <= 79)
            {
                grade = 3.5;
            }
            else if (score <= 100)
            {
                grade = 4;

            }
            else
            {
                
            }
        
            lashow.Text = "คุณมีผลการเรียนเป็น : "+grade.ToString();
        }
    }
}
