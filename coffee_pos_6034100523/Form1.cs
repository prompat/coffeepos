using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace coffee_pos_6034100523
{
    public partial class Form1 : Form
    {
        string G = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Form1()
        {
            InitializeComponent();
        }
        public void Guy(string Menu, string Bath)
        {
            string[] What = {Menu,Bath};
            var Guy = new ListViewItem(What);
            listView1.Items.Add(Guy);
            me();


        }
        double prices;
        public string[] me()
        {
            prices = 0;
            string[] JAAA = new string[listView1.Items.Count];
            int item = listView1.Items.Count;
            for (int i = 0; i < item; i++)
            {
                prices += double.Parse(listView1.Items[i].SubItems[1].Text);
                JAAA[i] = listView1.Items[i].SubItems[0].Text.ToString();
            }
            Label_show.Text = prices.ToString();
            return JAAA;
        }
        public void GG()
        {
            string[] on = me();
            string[] ho = me();
            string CC = "Coffee_Pos" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string Prompat = "Coffee_Pos";
            Prompat += "\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                Prompat += on[i] + new string(' ', 5) + "\r\n";

            }
            Prompat += "\r\n";
            Prompat += "Total Price :" + Label_show.Text;
            System.IO.File.WriteAllText(G + @"\" + CC + ".txt", Prompat);
            textBox1.Text += Prompat + "\r\n" + "\r\n" + "\r\n" + "Save File at " + on + @"\" + G + "Guy.txt";
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPage2);
        }

        private void button_hot1_Click(object sender, EventArgs e)
        {
            Guy("Esspresso(HOT)", "35");
        }
        
        private void button_hot2_Click(object sender, EventArgs e)
        {
            Guy("Americano(HOT)", "35");
        }

        private void button_hot3_Click(object sender, EventArgs e)
        {
            Guy("Latte(HOT)", "35");
        }

        private void button_hot4_Click(object sender, EventArgs e)
        {
            Guy("Mocha)", "35");
        }

        private void button_hot5_Click(object sender, EventArgs e)
        {
            Guy("Cappuccino(HOT)", "35");
        }

        private void button_hot6_Click(object sender, EventArgs e)
        {
            Guy("GreenTea(HOT)", "20");
        }

        private void button_hot7_Click(object sender, EventArgs e)
        {
            Guy("ThaiTea(HOT)", "20");
        }

        private void button_hot8_Click(object sender, EventArgs e)
        {
            Guy("Cocoa(HOT)", "20");
        }

        private void button_hot9_Click(object sender, EventArgs e)
        {
            Guy("Milk(HOT)", "20");
        }

        private void button_hot10_Click(object sender, EventArgs e)
        {
            Guy("Milk(HOT)", "20");
        }
        private void button_hot11_Click(object sender, EventArgs e)
        {
            Guy("Milk(HOT)", "20");
        }
        private void button_hot12_Click(object sender, EventArgs e)
        {
            Guy("Milk(HOT)", "20");
        }

        private void button_ice1_Click(object sender, EventArgs e)
        {
            Guy("Esspresso(Ice)", "45");
        }
        private void button_ice2_Click(object sender, EventArgs e)
        {
            Guy("Americano(Ice)", "45");
        }

        private void button_ice3_Click(object sender, EventArgs e)
        {
            Guy("Latte(ICE)", "45");
        }

        private void button_ice4_Click(object sender, EventArgs e)
        {
            Guy("Mocha(ICE)", "45");
        }

        private void button_ice5_Click(object sender, EventArgs e)
        {
            Guy("Capuccino(ICE)", "45");
        }

        private void button_ice6_Click(object sender, EventArgs e)
        {
            Guy("Green Tea(ICE)", "25");
        }

        private void button_ice7_Click(object sender, EventArgs e)
        {
            Guy("Thai cha(ICE)", "25");
        }

        private void button_ice8_Click(object sender, EventArgs e)
        {
            Guy("CoCoa(ICE)", "25");
        }

        private void button_ice9_Click(object sender, EventArgs e)
        {
            Guy("Milk(ICE)", "25");
        }

        private void button_ice10_Click(object sender, EventArgs e)
        {
            Guy("Milk Tea(ICE)", "25");
        }
        private void button_ice11_Click(object sender, EventArgs e)
        {
            Guy("Lemon Tea(ICE)", "25");
        }

        private void button_ice12_Click(object sender, EventArgs e)
        {
            Guy("Milo(ICE)", "25");
        }

        private void button_ice13_Click(object sender, EventArgs e)
        {
            Guy("Nescafe(ICE)", "25");
        }

        private void button_ice14_Click(object sender, EventArgs e)
        {
            Guy("Nestea Tea(ICE)", "25");
        }

        private void button_ice15_Click(object sender, EventArgs e)
        {
            Guy("Italian Soda(ICE)", "25");
        }

        private void button_ice16_Click(object sender, EventArgs e)
        {
            Guy("Red lime Soda(ICE)", "25");
        }

        private void button_ice17_Click(object sender, EventArgs e)
        {
            Guy("Honey lime Soda(ICE)", "25");
        }
        private void button_frappe1_Click_1(object sender, EventArgs e)
        {
            Guy("Esspresso(Frappe)", "50");
        }

        private void button_frappe2_Click(object sender, EventArgs e)
        {
            Guy("Americano(Frappe)", "50");
        }

        private void button_frappe3_Click(object sender, EventArgs e)
        {
            Guy("Mocha(Frappe)", "50");
        }

        private void button_frappe4_Click(object sender, EventArgs e)
        {
            Guy("Capuccino(Frappe)", "50");
        }

        private void button_frappe5_Click(object sender, EventArgs e)
        {
            Guy("Green Tea(Frappe)", "30");
        }

        private void button_frappe6_Click(object sender, EventArgs e)
        {
            Guy("Thai cha(Frappe)", "30");
        }

        private void button_frappe7_Click(object sender, EventArgs e)
        {
            Guy("CoCoa(Frappe)", "30");
        }

        private void button_frappe8_Click(object sender, EventArgs e)
        {
            Guy("Milk(Frappe)", "30");
        }

        private void button_frappe9_Click(object sender, EventArgs e)
        {
            Guy("Milk Tea(Frappe)", "30");
        }

        private void button_frappe10_Click(object sender, EventArgs e)
        {
            Guy("Lemon Tea(Frappe)", "30");
        }

        private void button_frappe11_Click(object sender, EventArgs e)
        {
            Guy("Milo(Frappe)", "30");
        }

        private void button_frappe12_Click(object sender, EventArgs e)
        {
            Guy("Nescafe(Frappe)", "30");
        }

        private void button_frappe13_Click(object sender, EventArgs e)
        {
            Guy("Nestea Tea(Frappe)", "30");
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            ok = false;
            tabControl1.Controls.Remove(tabPage2);
            Label_show.Text = "";
            textBox1.Text = "";
        }
        bool ok = false;
        private void button_payment_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (ok == false)
            {
                tabControl1.TabPages.Insert(1, tabPage2);
                ok = true;
                tabControl1.SelectedTab = tabPage2;

            }
            else tabControl1.SelectedTab = tabPage2;

            if (listView1.Items.Count > 0)
                GG();
        }
    }
}
