using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tashedefx = 0, tashedefy = 0, tas1x = 0, tas1y = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            //BOYAMA YAPAN KOD AMA KULLANMIYORUM.
            /*System.Drawing.Graphics cizim;
            cizim = this.CreateGraphics();
            SolidBrush kalem1 = new SolidBrush(Color.DarkGreen);
            SolidBrush kalem2 = new SolidBrush(Color.DarkGray);
            int a = 0;
            for (int i = 0; i < 300; i = i + 100)
            {
                for (int k = 0; k <= 5; k++)
                {
                    if (a == 0)
                    {
                        cizim.FillRectangle(kalem1, i, (k * 50), 50, 50);
                        cizim.FillRectangle(kalem2, i + 50, (k * 50), 50, 50);
                        a = 1;
                    }
                    else
                    {
                        cizim.FillRectangle(kalem2, i, (k * 50), 50, 50);
                        cizim.FillRectangle(kalem1, i + 50, (k * 50), 50, 50);
                        a = 0;
                    }

                }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void btnAna_MouseDown(object sender, MouseEventArgs e)
        {
          
                if (e.Button == MouseButtons.Left)
                {
                    btnAna.DoDragDrop(btnAna.Image, DragDropEffects.All);
                    
                }
                
            
        }
        
        private void a1btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
            
        }

        private void a1btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                a1btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                a1btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                a1btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                a1btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                a1btn.Image = btnTas4.Image;
                butonTik = 0;
            }
        }





        int butonTik=0;
        private void btnAna_Click(object sender, EventArgs e)
        {
            
        }

        private void b1btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                b1btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                b1btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                b1btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                b1btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                b1btn.Image = btnTas4.Image;
                butonTik = 0;
            }
        }

        private void b1btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
            
        }

        private void btnTas1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnTas2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTas3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTas4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAna_DragLeave(object sender, EventArgs e)
        {
            butonTik = 1;
        }

        private void btnAna_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void btnAna_DragOver(object sender, DragEventArgs e)
        {
            btnAna.Enabled = false;
        }

        private void btnTas1_DragLeave(object sender, EventArgs e)
        {
            butonTik = 2;
        }

        private void btnTas1_DragOver(object sender, DragEventArgs e)
        {
            btnTas1.Enabled = false;
        }

        private void btnTas1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnTas1.DoDragDrop(btnTas1.Image, DragDropEffects.All);

            }
        }

        private void btnTas2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnTas2.DoDragDrop(btnTas2.Image, DragDropEffects.All);

            }
        }

        private void btnTas3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnTas3.DoDragDrop(btnTas3.Image, DragDropEffects.All);

            }
        }

        private void btnTas4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                btnTas4.DoDragDrop(btnTas4.Image, DragDropEffects.All);

            }
        }

        private void btnTas2_DragLeave(object sender, EventArgs e)
        {
            butonTik = 3;
        }

        private void btnTas2_DragOver(object sender, DragEventArgs e)
        {
            btnTas2.Enabled = false;
        }

        private void btnTas3_DragOver(object sender, DragEventArgs e)
        {
            btnTas3.Enabled = false;
        }

        private void btnTas3_DragLeave(object sender, EventArgs e)
        {
            butonTik = 4;
        }

        private void btnTas4_DragOver(object sender, DragEventArgs e)
        {
            btnTas4.Enabled = false;
        }

        private void btnTas4_DragLeave(object sender, EventArgs e)
        {
            butonTik = 5;
        }

        private void c1btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void c1btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                c1btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
                c1btn.Image = btnTas1.Image;
            else if (butonTik == 3)
                c1btn.Image = btnTas2.Image;
            else if (butonTik == 4)
                c1btn.Image = btnTas3.Image;
            else if (butonTik == 5)
                c1btn.Image = btnTas4.Image;
        }

        private void d1btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                d1btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                d1btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                d1btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                d1btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                d1btn.Image = btnTas4.Image;
                butonTik = 0;
            }
        }

        private void d1btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void button1_DragOver(object sender, DragEventArgs e)
        {

        }

        private void button2_DragOver(object sender, DragEventArgs e)
        {

        }

        private void button3_DragOver(object sender, DragEventArgs e)
        {

        }

        private void f1btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void e1btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                e1btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                e1btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                e1btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                e1btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                e1btn.Image = btnTas4.Image;
                butonTik = 0;
            }
        }

        private void f1btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                f1btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                f1btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                f1btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                f1btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                f1btn.Image = btnTas4.Image;
                butonTik = 0;
            }
        }

        private void e1btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void d6btn_Click(object sender, EventArgs e)
        {

        }

        private void a2btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                a2btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                a2btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                a2btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                a2btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                a2btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void b2btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                b2btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                b2btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                b2btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                b2btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                b2btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void c2btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                c2btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                c2btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                c2btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                c2btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                c2btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void d2btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                d2btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                d2btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                d2btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                d2btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                d2btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void e2btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                e2btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                e2btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                e2btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                e2btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                e2btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void f2btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                f2btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                f2btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                f2btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                f2btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                f2btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void a3btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                a3btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                a3btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                a3btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                a3btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                a3btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void b3btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                b3btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                b3btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                b3btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                b3btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                b3btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void c3btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                c3btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                c3btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                c3btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                c3btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                c3btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void d3btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                d3btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                d3btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                d3btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                d3btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                d3btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void e3btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                e3btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                e3btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                e3btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                e3btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                e3btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void f3btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                f3btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                f3btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                f3btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                f3btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                f3btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void a4btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                a4btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                a4btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                a4btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                a4btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                a4btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void b4btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                b4btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                b4btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                b4btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                b4btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                b4btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void c4btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                c4btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                c4btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                c4btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                c4btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                c4btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void d4btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                d4btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                d4btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                d4btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                d4btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                d4btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void e4btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                e4btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                e4btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                e4btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                e4btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                e4btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void f4btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                f4btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                f4btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                f4btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                f4btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                f4btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void a5btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                a5btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                a5btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                a5btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                a5btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                a5btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void b5btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                b5btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                b5btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                b5btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                b5btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                b5btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void c5btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                c5btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                c5btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                c5btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                c5btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                c5btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void d5btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                d5btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                d5btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                d5btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                d5btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                d5btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void e5btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                e5btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                e5btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                e5btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                e5btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                e5btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void f5btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                f5btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                f5btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                f5btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                f5btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                f5btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void a6btn_DragDrop(object sender, DragEventArgs e)
        {
            if (butonTik == 1)
            {
                a6btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                a6btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                a6btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                a6btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                a6btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void b6btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                b6btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                b6btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                b6btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                b6btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                b6btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void c6btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                c6btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                c6btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                c6btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                c6btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                c6btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void d6btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                d6btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                d6btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                d6btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                d6btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                d6btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void e6btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                e6btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                e6btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                e6btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                e6btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                e6btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void f6btn_DragDrop(object sender, DragEventArgs e)
        {

            if (butonTik == 1)
            {
                f6btn.Image = btnAna.Image;
                butonTik = 0;
            }
            else if (butonTik == 2)
            {
                f6btn.Image = btnTas1.Image;
                butonTik = 0;
            }
            else if (butonTik == 3)
            {
                f6btn.Image = btnTas2.Image;
                butonTik = 0;
            }
            else if (butonTik == 4)
            {
                f6btn.Image = btnTas3.Image;
                butonTik = 0;
            }
            else if (butonTik == 5)
            {
                f6btn.Image = btnTas4.Image;
                butonTik = 0;
            }

        }

        private void a2btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }

          
        }

        private void a3btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }

           
        }

        private void a4btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }


        }

        private void a5btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }


           
        }

        private void a6btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }


           
        }

        private void b6btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void b5btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void b4btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void b3btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void b2btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void c6btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void c5btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void c4btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void c3btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void c2btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void d2btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void d3btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void d4btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void d5btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void d6btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void e2btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void e3btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void e4btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void e5btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void e6btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void f2btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void a1btn_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void b1btn_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void a1btn_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //anataş x kordinat bulma
            if(a1btn.Image==btnAna.Image)
            {
                tashedefx = 1;
                tashedefy = 1;
                a1btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (b1btn.Image == btnAna.Image)
            {
                tashedefx = 2;
                tashedefy = 1;
                b1btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (c1btn.Image == btnAna.Image)
            {
                tashedefx = 3;
                tashedefy = 1;
                c1btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (d1btn.Image == btnAna.Image)
            {
                tashedefx = 4;
                tashedefy = 1;
                d1btn.Text = (tashedefx.ToString() +","+ tashedefy.ToString());
            }
            else if (e1btn.Image == btnAna.Image)
            {
                tashedefx = 5;
                tashedefy = 1;
                e1btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (f1btn.Image == btnAna.Image)
            {
                tashedefx = 6;
                tashedefy = 1;
                f1btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            //anataş y2 x kordinat
            else if (a2btn.Image == btnAna.Image)
            {
                tashedefx = 1;
                tashedefy = 2;
                a2btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (b2btn.Image == btnAna.Image)
            {
                tashedefx = 2;
                tashedefy = 2;
                b2btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (c2btn.Image == btnAna.Image)
            {
                tashedefx = 3;
                tashedefy = 2;
                c2btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (d2btn.Image == btnAna.Image)
            {
                tashedefx = 4;
                tashedefy = 2;
                d2btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (e2btn.Image == btnAna.Image)
            {
                tashedefx = 5;
                tashedefy = 2;
                e2btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (f2btn.Image == btnAna.Image)
            {
                tashedefx = 6;
                tashedefy = 2;
                f2btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            //y3 x kordinat
            else if (a3btn.Image == btnAna.Image)
            {
                tashedefx = 1;
                tashedefy = 3;
                a3btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (b3btn.Image == btnAna.Image)
            {
                tashedefx = 2;
                tashedefy = 3;
                b3btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (c3btn.Image == btnAna.Image)
            {
                tashedefx = 3;
                tashedefy = 3;
                c3btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (d3btn.Image == btnAna.Image)
            {
                tashedefx = 4;
                tashedefy = 3;
                d3btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (e3btn.Image == btnAna.Image)
            {
                tashedefx = 5;
                tashedefy = 3;
                e3btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (f3btn.Image == btnAna.Image)
            {
                tashedefx = 6;
                tashedefy = 3;
                f3btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            //y4 x kordinat
            else if (a4btn.Image == btnAna.Image)
            {
                tashedefx = 1;
                tashedefy = 4;
                a4btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (b4btn.Image == btnAna.Image)
            {
                tashedefx = 2;
                tashedefy = 4;
                b4btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (c4btn.Image == btnAna.Image)
            {
                tashedefx = 3;
                tashedefy = 4;
                c4btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (d4btn.Image == btnAna.Image)
            {
                tashedefx = 4;
                tashedefy = 4;
                d4btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (e4btn.Image == btnAna.Image)
            {
                tashedefx = 5;
                tashedefy = 4;
                e4btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (f4btn.Image == btnAna.Image)
            {
                tashedefx = 6;
                tashedefy = 4;
                f4btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            //y5 x kordinat
            else if (a5btn.Image == btnAna.Image)
            {
                tashedefx = 1;
                tashedefy = 5;
                a5btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (b5btn.Image == btnAna.Image)
            {
                tashedefx = 2;
                tashedefy = 5;
                b5btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (c5btn.Image == btnAna.Image)
            {
                tashedefx = 3;
                tashedefy = 5;
                c5btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (d5btn.Image == btnAna.Image)
            {
                tashedefx = 4;
                tashedefy = 5;
                d5btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (e5btn.Image == btnAna.Image)
            {
                tashedefx = 5;
                tashedefy = 5;
                e5btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (f5btn.Image == btnAna.Image)
            {
                tashedefx = 6;
                tashedefy = 5;
                f5btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            //y6 x kordinat
            else if (a6btn.Image == btnAna.Image)
            {
                tashedefx = 1;
                tashedefy = 6;
                a6btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (b6btn.Image == btnAna.Image)
            {
                tashedefx = 2;
                tashedefy = 6;
                b6btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (c6btn.Image == btnAna.Image)
            {
                tashedefx = 3;
                tashedefy = 6;
                c6btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (d6btn.Image == btnAna.Image)
            {
                tashedefx = 4;
                tashedefy = 6;
                d6btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (e6btn.Image == btnAna.Image)
            {
                tashedefx = 5;
                tashedefy = 6;
                e6btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }
            else if (f6btn.Image == btnAna.Image)
            {
                tashedefx = 6;
                tashedefy = 6;
                f6btn.Text = (tashedefx.ToString() + "," + tashedefy.ToString());
            }

            //TAS1 1. SATIR KORDİNATLARI
            if (a1btn.Image == btnTas1.Image)
            {
                tas1x = 1;
                tas1y = 1;
                a1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b1btn.Image == btnTas1.Image)
            {
                tas1x = 2;
                tas1y = 1;
                b1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c1btn.Image == btnTas1.Image)
            {
                tas1x = 3;
                tas1y = 1;
                c1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d1btn.Image == btnTas1.Image)
            {
                tas1x = 4;
                tas1y = 1;
                d1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e1btn.Image == btnTas1.Image)
            {
                tas1x = 5;
                tas1y = 1;
                e1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f1btn.Image == btnTas1.Image)
            {
                tas1x = 6;
                tas1y = 1;
                f1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS1 2. SATIR KORDİNATLARI
            else if (a2btn.Image == btnTas1.Image)
            {
                tas1x = 1;
                tas1y = 2;
                a2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b2btn.Image == btnTas1.Image)
            {
                tas1x = 2;
                tas1y = 2;
                b2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c2btn.Image == btnTas1.Image)
            {
                tas1x = 3;
                tas1y = 2;
                c2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d2btn.Image == btnTas1.Image)
            {
                tas1x = 4;
                tas1y = 2;
                d2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e2btn.Image == btnTas1.Image)
            {
                tas1x = 5;
                tas1y = 2;
                e2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f2btn.Image == btnTas1.Image)
            {
                tas1x = 6;
                tas1y = 2;
                f2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS1 3. SATIR KORDİNATLARI
            else if (a3btn.Image == btnTas1.Image)
            {
                tas1x = 1;
                tas1y = 3;
                a3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b3btn.Image == btnTas1.Image)
            {
                tas1x = 2;
                tas1y = 3;
                b3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c3btn.Image == btnTas1.Image)
            {
                tas1x = 3;
                tas1y = 3;
                c3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d3btn.Image == btnTas1.Image)
            {
                tas1x = 4;
                tas1y = 3;
                d3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e3btn.Image == btnTas1.Image)
            {
                tas1x = 5;
                tas1y = 3;
                e3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f3btn.Image == btnTas1.Image)
            {
                tas1x = 6;
                tas1y = 3;
                f3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }

            //TAS1 4. SATIR KORDİNATLARI
            else if (a4btn.Image == btnTas1.Image)
            {
                tas1x = 1;
                tas1y = 4;
                a4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b4btn.Image == btnTas1.Image)
            {
                tas1x = 2;
                tas1y = 4;
                b4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c4btn.Image == btnTas1.Image)
            {
                tas1x = 3;
                tas1y = 4;
                c4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d4btn.Image == btnTas1.Image)
            {
                tas1x = 4;
                tas1y = 4;
                d4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e4btn.Image == btnTas1.Image)
            {
                tas1x = 5;
                tas1y = 4;
                e4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f4btn.Image == btnTas1.Image)
            {
                tas1x = 6;
                tas1y = 4;
                f4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS1 5. SATIR KORDİNATLARI
            else if (a5btn.Image == btnTas1.Image)
            {
                tas1x = 1;
                tas1y = 5;
                a5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b5btn.Image == btnTas1.Image)
            {
                tas1x = 2;
                tas1y = 5;
                b5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c5btn.Image == btnTas1.Image)
            {
                tas1x = 3;
                tas1y = 5;
                c5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d5btn.Image == btnTas1.Image)
            {
                tas1x = 4;
                tas1y = 5;
                d5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e5btn.Image == btnTas1.Image)
            {
                tas1x = 5;
                tas1y = 5;
                e5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f5btn.Image == btnTas1.Image)
            {
                tas1x = 6;
                tas1y = 5;
                f5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS1 6. SATIR KORDİNATLARI
            else if (a6btn.Image == btnTas1.Image)
            {
                tas1x = 1;
                tas1y = 6;
                a6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b6btn.Image == btnTas1.Image)
            {
                tas1x = 2;
                tas1y = 6;
                b6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c6btn.Image == btnTas1.Image)
            {
                tas1x = 3;
                tas1y = 6;
                c6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d6btn.Image == btnTas1.Image)
            {
                tas1x = 4;
                tas1y = 6;
                d6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e6btn.Image == btnTas1.Image)
            {
                tas1x = 5;
                tas1y = 6;
                e6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f6btn.Image == btnTas1.Image)
            {
                tas1x = 6;
                tas1y = 6;
                f6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS2 1. SATIR KORDİNATLARI
            if (a1btn.Image == btnTas2.Image)
            {
                tas1x = 1;
                tas1y = 1;
                a1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b1btn.Image == btnTas2.Image)
            {
                tas1x = 2;
                tas1y = 1;
                b1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c1btn.Image == btnTas2.Image)
            {
                tas1x = 3;
                tas1y = 1;
                c1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d1btn.Image == btnTas2.Image)
            {
                tas1x = 4;
                tas1y = 1;
                d1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e1btn.Image == btnTas2.Image)
            {
                tas1x = 5;
                tas1y = 1;
                e1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f1btn.Image == btnTas2.Image)
            {
                tas1x = 6;
                tas1y = 1;
                f1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS2 2. SATIR KORDİNATLARI
            else if (a2btn.Image == btnTas2.Image)
            {
                tas1x = 1;
                tas1y = 2;
                a2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b2btn.Image == btnTas2.Image)
            {
                tas1x = 2;
                tas1y = 2;
                b2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c2btn.Image == btnTas2.Image)
            {
                tas1x = 3;
                tas1y = 2;
                c2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d2btn.Image == btnTas2.Image)
            {
                tas1x = 4;
                tas1y = 2;
                d2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e2btn.Image == btnTas2.Image)
            {
                tas1x = 5;
                tas1y = 2;
                e2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f2btn.Image == btnTas2.Image)
            {
                tas1x = 6;
                tas1y = 2;
                f2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS2 3. SATIR KORDİNATLARI
            else if (a3btn.Image == btnTas2.Image)
            {
                tas1x = 1;
                tas1y = 3;
                a3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b3btn.Image == btnTas2.Image)
            {
                tas1x = 2;
                tas1y = 3;
                b3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c3btn.Image == btnTas2.Image)
            {
                tas1x = 3;
                tas1y = 3;
                c3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d3btn.Image == btnTas2.Image)
            {
                tas1x = 4;
                tas1y = 3;
                d3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e3btn.Image == btnTas2.Image)
            {
                tas1x = 5;
                tas1y = 3;
                e3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f3btn.Image == btnTas2.Image)
            {
                tas1x = 6;
                tas1y = 3;
                f3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }

            //TAS2 4. SATIR KORDİNATLARI
            else if (a4btn.Image == btnTas2.Image)
            {
                tas1x = 1;
                tas1y = 4;
                a4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b4btn.Image == btnTas2.Image)
            {
                tas1x = 2;
                tas1y = 4;
                b4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c4btn.Image == btnTas2.Image)
            {
                tas1x = 3;
                tas1y = 4;
                c4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d4btn.Image == btnTas2.Image)
            {
                tas1x = 4;
                tas1y = 4;
                d4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e4btn.Image == btnTas2.Image)
            {
                tas1x = 5;
                tas1y = 4;
                e4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f4btn.Image == btnTas2.Image)
            {
                tas1x = 6;
                tas1y = 4;
                f4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS2 5. SATIR KORDİNATLARI
            else if (a5btn.Image == btnTas2.Image)
            {
                tas1x = 1;
                tas1y = 5;
                a5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b5btn.Image == btnTas2.Image)
            {
                tas1x = 2;
                tas1y = 5;
                b5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c5btn.Image == btnTas2.Image)
            {
                tas1x = 3;
                tas1y = 5;
                c5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d5btn.Image == btnTas2.Image)
            {
                tas1x = 4;
                tas1y = 5;
                d5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e5btn.Image == btnTas2.Image)
            {
                tas1x = 5;
                tas1y = 5;
                e5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f5btn.Image == btnTas2.Image)
            {
                tas1x = 6;
                tas1y = 5;
                f5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS2 6. SATIR KORDİNATLARI
            else if (a6btn.Image == btnTas2.Image)
            {
                tas1x = 1;
                tas1y = 6;
                a6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b6btn.Image == btnTas2.Image)
            {
                tas1x = 2;
                tas1y = 6;
                b6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c6btn.Image == btnTas2.Image)
            {
                tas1x = 3;
                tas1y = 6;
                c6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d6btn.Image == btnTas2.Image)
            {
                tas1x = 4;
                tas1y = 6;
                d6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e6btn.Image == btnTas2.Image)
            {
                tas1x = 5;
                tas1y = 6;
                e6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f6btn.Image == btnTas2.Image)
            {
                tas1x = 6;
                tas1y = 6;
                f6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS3 1. SATIR KORDİNATLARI
            if (a1btn.Image == btnTas3.Image)
            {
                tas1x = 1;
                tas1y = 1;
                a1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b1btn.Image == btnTas3.Image)
            {
                tas1x = 2;
                tas1y = 1;
                b1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c1btn.Image == btnTas3.Image)
            {
                tas1x = 3;
                tas1y = 1;
                c1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d1btn.Image == btnTas3.Image)
            {
                tas1x = 4;
                tas1y = 1;
                d1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e1btn.Image == btnTas3.Image)
            {
                tas1x = 5;
                tas1y = 1;
                e1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f1btn.Image == btnTas3.Image)
            {
                tas1x = 6;
                tas1y = 1;
                f1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS3 2. SATIR KORDİNATLARI
            else if (a2btn.Image == btnTas3.Image)
            {
                tas1x = 1;
                tas1y = 2;
                a2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b2btn.Image == btnTas3.Image)
            {
                tas1x = 2;
                tas1y = 2;
                b2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c2btn.Image == btnTas3.Image)
            {
                tas1x = 3;
                tas1y = 2;
                c2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d2btn.Image == btnTas3.Image)
            {
                tas1x = 4;
                tas1y = 2;
                d2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e2btn.Image == btnTas3.Image)
            {
                tas1x = 5;
                tas1y = 2;
                e2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f2btn.Image == btnTas3.Image)
            {
                tas1x = 6;
                tas1y = 2;
                f2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS3 3. SATIR KORDİNATLARI
            else if (a3btn.Image == btnTas3.Image)
            {
                tas1x = 1;
                tas1y = 3;
                a3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b3btn.Image == btnTas3.Image)
            {
                tas1x = 2;
                tas1y = 3;
                b3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c3btn.Image == btnTas3.Image)
            {
                tas1x = 3;
                tas1y = 3;
                c3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d3btn.Image == btnTas3.Image)
            {
                tas1x = 4;
                tas1y = 3;
                d3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e3btn.Image == btnTas3.Image)
            {
                tas1x = 5;
                tas1y = 3;
                e3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f3btn.Image == btnTas3.Image)
            {
                tas1x = 6;
                tas1y = 3;
                f3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }

            //TAS3 4. SATIR KORDİNATLARI
            else if (a4btn.Image == btnTas3.Image)
            {
                tas1x = 1;
                tas1y = 4;
                a4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b4btn.Image == btnTas3.Image)
            {
                tas1x = 2;
                tas1y = 4;
                b4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c4btn.Image == btnTas3.Image)
            {
                tas1x = 3;
                tas1y = 4;
                c4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d4btn.Image == btnTas3.Image)
            {
                tas1x = 4;
                tas1y = 4;
                d4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e4btn.Image == btnTas3.Image)
            {
                tas1x = 5;
                tas1y = 4;
                e4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f4btn.Image == btnTas3.Image)
            {
                tas1x = 6;
                tas1y = 4;
                f4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS3 5. SATIR KORDİNATLARI
            else if (a5btn.Image == btnTas3.Image)
            {
                tas1x = 1;
                tas1y = 5;
                a5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b5btn.Image == btnTas3.Image)
            {
                tas1x = 2;
                tas1y = 5;
                b5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c5btn.Image == btnTas3.Image)
            {
                tas1x = 3;
                tas1y = 5;
                c5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d5btn.Image == btnTas3.Image)
            {
                tas1x = 4;
                tas1y = 5;
                d5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e5btn.Image == btnTas3.Image)
            {
                tas1x = 5;
                tas1y = 5;
                e5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f5btn.Image == btnTas3.Image)
            {
                tas1x = 6;
                tas1y = 5;
                f5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS3 6. SATIR KORDİNATLARI
            else if (a6btn.Image == btnTas3.Image)
            {
                tas1x = 1;
                tas1y = 6;
                a6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b6btn.Image == btnTas3.Image)
            {
                tas1x = 2;
                tas1y = 6;
                b6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c6btn.Image == btnTas3.Image)
            {
                tas1x = 3;
                tas1y = 6;
                c6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d6btn.Image == btnTas3.Image)
            {
                tas1x = 4;
                tas1y = 6;
                d6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e6btn.Image == btnTas3.Image)
            {
                tas1x = 5;
                tas1y = 6;
                e6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f6btn.Image == btnTas3.Image)
            {
                tas1x = 6;
                tas1y = 6;
                f6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS4 1. SATIR KORDİNATLARI
            if (a1btn.Image == btnTas4.Image)
            {
                tas1x = 1;
                tas1y = 1;
                a1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b1btn.Image == btnTas4.Image)
            {
                tas1x = 2;
                tas1y = 1;
                b1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c1btn.Image == btnTas4.Image)
            {
                tas1x = 3;
                tas1y = 1;
                c1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d1btn.Image == btnTas4.Image)
            {
                tas1x = 4;
                tas1y = 1;
                d1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e1btn.Image == btnTas4.Image)
            {
                tas1x = 5;
                tas1y = 1;
                e1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f1btn.Image == btnTas4.Image)
            {
                tas1x = 6;
                tas1y = 1;
                f1btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS4 2. SATIR KORDİNATLARI
            else if (a2btn.Image == btnTas4.Image)
            {
                tas1x = 1;
                tas1y = 2;
                a2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b2btn.Image == btnTas4.Image)
            {
                tas1x = 2;
                tas1y = 2;
                b2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c2btn.Image == btnTas4.Image)
            {
                tas1x = 3;
                tas1y = 2;
                c2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d2btn.Image == btnTas4.Image)
            {
                tas1x = 4;
                tas1y = 2;
                d2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e2btn.Image == btnTas4.Image)
            {
                tas1x = 5;
                tas1y = 2;
                e2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f2btn.Image == btnTas4.Image)
            {
                tas1x = 6;
                tas1y = 2;
                f2btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS4 3. SATIR KORDİNATLARI
            else if (a3btn.Image == btnTas4.Image)
            {
                tas1x = 1;
                tas1y = 3;
                a3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b3btn.Image == btnTas4.Image)
            {
                tas1x = 2;
                tas1y = 3;
                b3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c3btn.Image == btnTas4.Image)
            {
                tas1x = 3;
                tas1y = 3;
                c3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d3btn.Image == btnTas4.Image)
            {
                tas1x = 4;
                tas1y = 3;
                d3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e3btn.Image == btnTas4.Image)
            {
                tas1x = 5;
                tas1y = 3;
                e3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f3btn.Image == btnTas4.Image)
            {
                tas1x = 6;
                tas1y = 3;
                f3btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }

            //TAS4 4. SATIR KORDİNATLARI
            else if (a4btn.Image == btnTas4.Image)
            {
                tas1x = 1;
                tas1y = 4;
                a4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b4btn.Image == btnTas4.Image)
            {
                tas1x = 2;
                tas1y = 4;
                b4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c4btn.Image == btnTas4.Image)
            {
                tas1x = 3;
                tas1y = 4;
                c4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d4btn.Image == btnTas4.Image)
            {
                tas1x = 4;
                tas1y = 4;
                d4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e4btn.Image == btnTas4.Image)
            {
                tas1x = 5;
                tas1y = 4;
                e4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f4btn.Image == btnTas4.Image)
            {
                tas1x = 6;
                tas1y = 4;
                f4btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS4 5. SATIR KORDİNATLARI
            else if (a5btn.Image == btnTas4.Image)
            {
                tas1x = 1;
                tas1y = 5;
                a5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b5btn.Image == btnTas4.Image)
            {
                tas1x = 2;
                tas1y = 5;
                b5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c5btn.Image == btnTas4.Image)
            {
                tas1x = 3;
                tas1y = 5;
                c5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d5btn.Image == btnTas4.Image)
            {
                tas1x = 4;
                tas1y = 5;
                d5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e5btn.Image == btnTas4.Image)
            {
                tas1x = 5;
                tas1y = 5;
                e5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f5btn.Image == btnTas4.Image)
            {
                tas1x = 6;
                tas1y = 5;
                f5btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            //TAS4 6. SATIR KORDİNATLARI
            else if (a6btn.Image == btnTas4.Image)
            {
                tas1x = 1;
                tas1y = 6;
                a6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (b6btn.Image == btnTas4.Image)
            {
                tas1x = 2;
                tas1y = 6;
                b6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (c6btn.Image == btnTas4.Image)
            {
                tas1x = 3;
                tas1y = 6;
                c6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (d6btn.Image == btnTas4.Image)
            {
                tas1x = 4;
                tas1y = 6;
                d6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (e6btn.Image == btnTas4.Image)
            {
                tas1x = 5;
                tas1y = 6;
                e6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
            else if (f6btn.Image == btnTas4.Image)
            {
                tas1x = 6;
                tas1y = 6;
                f6btn.Text = (tas1x.ToString() + "," + tas1y.ToString());
            }
        }


        private void f3btn_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void f3btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void f4btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void f5btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void f6btn_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }
    }
}
