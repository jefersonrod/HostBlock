using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostBlock
{
    public partial class Form1 : Form
    {
        String pathHost = @"C:\Windows\System32\drivers\etc\hosts";
        
        public Form1()
        {
            InitializeComponent();
            lbPathHosts.Text = pathHost;
        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenHostFile();
        }

        private void OpenHostFile()
        {
            rtbHosts.Text = "";
            String content;
            String text = "";
            try
            {
                StreamReader str = new StreamReader(pathHost);

                while ((content = str.ReadLine()) != null)
                {
                    text = content;
                    rtbHosts.AppendText(text);
                    rtbHosts.AppendText("\n");
                }
                str.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
            
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveHostFile();
        }

        private void SaveHostFile()
        {
            try
            {
                String content = rtbHosts.Text;
                StreamWriter rec = new StreamWriter(pathHost);
                rec.WriteLine(content);
                rec.Close();
                MessageBox.Show("File saved OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddUrlBlock();
        }

        private void AddUrlBlock()
        {
            if (rtbHosts.Text.Contains("#"))
            {
                rtbHosts.AppendText("127.0.0.1  " + tbURLBlockHosts.Text);
                rtbHosts.AppendText("\n");
            }
            else
            {
                MessageBox.Show("Hosts file not loaded");
            }
            
        }

        private void tbURLBlockHosts_MouseClick(object sender, MouseEventArgs e)
        {
            tbURLBlockHosts.Text = "";
        }

        private void btUnlock_Click(object sender, EventArgs e)
        {
            UnlockEdit();
        }

        private void UnlockEdit()
        {
            String content = rtbHosts.Text;
            rtbHosts.ReadOnly = false;
            rtbHosts.Text = "";
            rtbHosts.Text = content;
        }
    }
}
