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
using System.Security.Cryptography;

namespace SecretSafety
{
    public partial class FormDashboard : System.Windows.Forms.Form
    {
        String userfile;

        public FormDashboard(String username, String password)
        {
            InitializeComponent();

            SHA256 sha = SHA256.Create();
            byte[] key = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            userfile = username + ".secretsafety.txt";
            try
            {
                StreamReader sr = new StreamReader(userfile);
                String line = sr.ReadLine();
                while (line != null)
                {
                    String[] items = line.Split('\t');
                    list_passwords.Items.Add(items[0]).SubItems.AddRange(new[] { items[1], items[2] });
                    line = sr.ReadLine();
                }
                sr.Close();
            } catch (FileNotFoundException e) {

            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            FormAdd f3 = new FormAdd(this);
            //this.Hide();
            f3.ShowDialog();
        }

        public void add_password(string username, string password, string note)
        {
            list_passwords.Items.Add(username).SubItems.AddRange(new[] { password, note });
        }

        private void bn_save_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(userfile, false, Encoding.UTF8);
            foreach(ListViewItem item in list_passwords.Items)
            {
                sw.Write(item.Text);
                sw.Write("\t");
                sw.Write(item.SubItems[1].Text);
                sw.Write("\t");
                sw.WriteLine(item.SubItems[2].Text);
            }
            sw.Close();
        }

        private void list_passwords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
