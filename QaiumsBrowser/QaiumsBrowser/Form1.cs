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
using System.Drawing.Imaging;



namespace QaiumsBrowser
{
    public partial class QaiumsBrowser : Form
    {
        int WebBrowsermin, tabControl1min; 
        public QaiumsBrowser()
        {
            InitializeComponent();
            WebBrowsermin = this.Width - web.Width;
            tabControl1min = this.Width - tabControl1.Width;
        }
        WebBrowser web = new WebBrowser();
        int i = 0;
       /*
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);           //This WndProc() is for making border around the form. 
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        */

        /*
        private void otherWeb_NewWindow(object sender, CancelEventArgs e)

        {
          e.Cancel = true;
          otherWeb.Navigate(otherURL);
        }
 
        private void otherWeb_Navigating(object sender, WebBrowserNavigatingEventArgs e)

        {
            otherURL = e.Url.ToString();
        }
         
         second sec=new second();
         * sec.ShowDialog();
          
         
        
        */

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(comboBox1.Text);
           
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
            
            
           
        }


        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Stop();
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoHome();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          tabControl1.SelectedTab.Text = ((WebBrowser) tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
             
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible=true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("NewTab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
           i += 1;


        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            web.Width = this.Width-WebBrowsermin;
            tabControl1.Width = this.Width;


         
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("NewTab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1; 
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count - 1 > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count-1);
                i -= 1;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyDown(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(comboBox1.Text);
                if (!comboBox1.Items.Contains(comboBox1.Text))
                {
                    comboBox1.Items.Add(comboBox1.Text);
                }
            }
        
        }

        private void SportNews_Click(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("Sports News");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
            //SportsNews sec = new SportsNews();
            //sec.ShowDialog();

        }

        private void infoTecnology_Click(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("Info Technology");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
        }

        private void International_Click_1(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("Info Technology");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
        }

        private void Bangladesh_Click(object sender, EventArgs e)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl1.TabPages.Add("Info Technology");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
        }

        

       
       
       

        
    }
}
