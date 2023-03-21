using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atestat2021
{
    
    public partial class Form1 : Form
    {
        int st = 0;
        string a ="";
        string b = "";
        string c = "";

        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "madap@gmail.com" && textBox2.Text == "12@34@")
            {
                tabControl1.SelectedTab = tabPage3;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Inccorect username or password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning).ToString();
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
            button6.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int s=0,x=0,p=9;
            comandaTableAdapter.cerinta10(s.ToString(), p.ToString(), x.ToString(), comboBox1.SelectedIndex.ToString());
            int s1 = 6570, ok1 = 0,ok2=0,ok3=0;
            if (comboBox1.Text == "1")
                ok1 = 1;
            if (comboBox1.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox1.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                a += label4.Text+" "+"X1"+'\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                a += label4.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                a += label4.Text+ " " + "X3" + '\n';
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int s1 = 5900, ok1 = 0,ok2=0,ok3=0;
            if (comboBox2.Text == "1")
                ok1 = 1;
            if (comboBox2.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox2.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                a+= label5.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                a += label5.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                a+= label5.Text + " " + "X3" + '\n';
            }
                
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int s1 = 5000, ok1 = 0,ok2=0,ok3=0;
            if (comboBox3.Text == "1")
                ok1 = 1;
            if (comboBox3.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox3.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }

            if (ok1 == 1)
            {
                st = st + s1;
                a += label6.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                a+= label6.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                a += label6.Text + " " + "X3" + '\n';
            }
                
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int s1 = 2000, ok1 = 0,ok2=0,ok3=0;
            if (comboBox4.Text == "1")
                ok1 = 1;
            if (comboBox4.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox4.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                b += label7.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                b += label7.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                b += label7.Text + " " + "X3" + '\n';
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int s1 = 2000, ok1 = 0,ok2=0,ok3=0;
            if (comboBox5.Text == "1")
                ok1 = 1;
            if (comboBox5.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox5.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                b+= label8.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                b += label8.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                b += label8.Text + " " + "X3" + '\n';
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int s1 = 550, ok1 = 0,ok2=0,ok3=0;
            if (comboBox6.Text == "1")
                ok1 = 1;
            if (comboBox6.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox6.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                b += label9.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                b += label9.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                b += label9.Text + " " + "X3" + '\n';
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int s1 = 350, ok1 = 0,ok2=0,ok3=0;
            if (comboBox7.Text == "1")
                ok1 = 1;
            if (comboBox7.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox7.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                b+= label10.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                b += label10.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                b += label10.Text + " " + "X3" + '\n';
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            int s1 = 1200, ok1 = 0,ok2=0,ok3=0;
            if (comboBox8.Text == "1")
                ok1 = 1;
            if (comboBox8.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox8.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                c += label11.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                c += label11.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                c+= label11.Text + " " + "X3" + '\n';
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int s1 = 100, ok1 = 0,ok2=0,ok3=0;
            if (comboBox10.Text == "1")
                ok1 = 1;
            if (comboBox10.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox10.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                c += label12.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                c+= label12.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                c += label12.Text + " " + "X3" + '\n';
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int s1 = 500, ok1 = 0,ok2=0,ok3=0;
            if (comboBox10.Text == "1")
                ok1 = 1;
            if (comboBox10.Text == "2")
            {
                s1 = 2 * s1;
                ok2 = 1;
            }
            if (comboBox10.Text == "3")
            {
                s1 = 3 * s1;
                ok3 = 1;
            }
            if (ok1 == 1)
            {
                st = st + s1;
                c += label13.Text + " " + "X1" + '\n';
            }
            if (ok2 == 1)
            {
                st = st + s1;
                c += label13.Text + " " + "X2" + '\n';
            }
            if (ok3 == 1)
            {
                st = st + s1;
                c += label13.Text + " " + "X3" + '\n';
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage8;
            richTextBox1.Text = "";
            richTextBox1.Text += a+b+c;
            textBox3.Text= st.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage5;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }


        private void button19_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage6;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage7;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage9;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage10;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("VA MULTUMIM PENTRU COMANDA", "MESSAGE", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage4;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage11;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'atestat2021DataSet.produs' table. You can move, or remove it, as needed.
            this.produsTableAdapter.Fill(this.atestat2021DataSet.produs);
            // TODO: This line of code loads data into the 'atestat2021DataSet.factura' table. You can move, or remove it, as needed.
            this.facturaTableAdapter.Fill(this.atestat2021DataSet.factura);
            // TODO: This line of code loads data into the 'atestat2021DataSet.comanda' table. You can move, or remove it, as needed.
            this.comandaTableAdapter.Fill(this.atestat2021DataSet.comanda);
            // TODO: This line of code loads data into the 'atestat2021DataSet.clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.atestat2021DataSet.clienti);

        }

        private void button30_Click(object sender, EventArgs e)
        {
            clientiTableAdapter.cerinta1(atestat2021DataSet.clienti, textBox4.Text.ToString(), textBox5.Text.ToString());
            DataTable dt = atestat2021DataSet.clienti;
            richTextBox2.Text = "";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox2.Text += dt.Rows[i]["denumire"].ToString()+'\n';
            clientiTableAdapter.cerinta6(atestat2021DataSet.clienti, textBox4.Text.ToString(), textBox5.Text.ToString());
            DataTable dt1 = atestat2021DataSet.clienti;
            richTextBox3.Text = "";
            for (int i = 0; i < dt1.Rows.Count; i++)
                richTextBox3.Text += "e_mail:"+dt.Rows[i]["e_mail"].ToString() +'\n'+"telefon:0"+dt.Rows[i]["telefon"].ToString()+'\n'+"parola:"+dt.Rows[i]["parola"].ToString()+'\n';
            
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string x=facturaTableAdapter.cerinta3(comboBox11.SelectedItem.ToString()).ToString();
            textBox6.Text = x;


        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x =facturaTableAdapter.cerinta5(int.Parse(comboBox12.SelectedItem.ToString())).ToString();
            textBox7.Text = x;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            facturaTableAdapter.cerinta18(atestat2021DataSet.factura, int.Parse(comboBox13.SelectedItem.ToString())).ToString();
            DataTable dt = atestat2021DataSet.factura;
            richTextBox4.Text = "";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox4.Text += dt.Rows[i]["nume"].ToString()+dt.Rows[i]["prenume"]+'\n';

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = facturaTableAdapter.cerinta4(int.Parse(comboBox14.SelectedItem.ToString())).ToString();
            textBox8.Text = x;
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = facturaTableAdapter.cerinta15(int.Parse(comboBox15.SelectedItem.ToString())).ToString();
            textBox9.Text = x;
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = facturaTableAdapter.cerinta16(int.Parse(comboBox16.SelectedItem.ToString())).ToString();
            textBox10.Text = x;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox11.Text= facturaTableAdapter.cerinta14().ToString();
            produsTableAdapter.cerinta13(atestat2021DataSet.produs);
            DataTable dt = atestat2021DataSet.produs;
            richTextBox5.Text="";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox5.Text +="Produsul "+(i+1)+'\n'+"denumire: "+ dt.Rows[i]["denumire"].ToString() +'\n'+ "pret: "+dt.Rows[i]["pret"]+" RON" +'\n';
        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            produsTableAdapter.cerinta7(atestat2021DataSet.produs, (comboBox17.SelectedItem.ToString()));
            DataTable dt = atestat2021DataSet.produs;
            richTextBox6.Text = "";
            for(int i=0;i<dt.Rows.Count;i++)
                richTextBox6.Text+="id produs: "+dt.Rows[i]["idp"].ToString()+'\n'+"categorie: "+dt.Rows[i]["categorie"]+'\n'+"pret: "+dt.Rows[i]["pret"]+" RON"+'\n'+"descriere: "+dt.Rows[i]["descriere"]+'\n';
        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox12.Text = produsTableAdapter.cerinta8(comboBox18.SelectedItem.ToString()).ToString() ;
            produsTableAdapter.cerinta9(atestat2021DataSet.produs,(comboBox18.SelectedItem.ToString()));
            DataTable dt = atestat2021DataSet.produs;
            richTextBox7.Text = "";
            for (int i = 0; i < dt.Rows.Count; i++)
                richTextBox7.Text += "Produsul " + (i + 1) + '\n' + "denumire: " + dt.Rows[i]["denumire"].ToString() + '\n' + "pret: " + dt.Rows[i]["pret"] + " RON" + '\n' + "descriere: " + dt.Rows[i]["descriere"] + '\n';
   

        }

        private void button32_Click(object sender, EventArgs e)
        {
            produsTableAdapter.cerinta17(atestat2021DataSet.produs);
            DataTable bt = atestat2021DataSet.produs;
            richTextBox6.Text = "";
            for (int i = 0; i < bt.Rows.Count; i++)
                richTextBox8.Text += bt.Rows[i]["denumire"].ToString() + bt.Rows[i]["Suma"] + '\n';
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

  
        
    }
}
