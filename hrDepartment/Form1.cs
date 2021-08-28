using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace hrDepartment
{
    public partial class Form1 : Form
    {
        string path1;
        string path2;
        string photoPath;

        XDocument doc1;
        XDocument doc2;
        public Form1()
        {
            InitializeComponent();
            path1 = @"..\..\Data\departments.xml";
            path2 = @"..\..\Data\emloyees.xml";
            doc1 = XDocument.Load(path1);
            doc1 = XDocument.Load(path2);

        }

         private void Form1_Load(object sender, EventArgs e)
        {
            var deps = doc1.Element("root").Elements("departments").ToList();
            foreach (var dep in deps)
            {
                depList.Items.Add(dep.Attribute("name").Value);
            }
            if (depList.Items.Count > 0)
            {
                depList.SelectedIndex = 0;
                //depList.Items.Add
            }
        }

        private void depAdd_Click(object sender, EventArgs e)
        {
            string name = depName.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Имя департамента не указано!", "Упс!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void depList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dep_name = depList.SelectedText;
            var emps = doc2.Element("root").Elements("employee")
                .Where(emp => emp.Attribute("dep_name").Value == dep_name).ToList();
            foreach (var emp in emps)
            {
                depList.Items.Clear();
                depList.Items.Add(emp.Attribute("name").Value);
            }
        }

        private void empList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string emp_name = empList.SelectedItem.ToString();
            var emps = doc2.Element("root").Elements("employee")
                .Where(emp => emp.Attribute("name").Value == emp_name).ToList()
                .FirstOrDefault();
            if (empSalary != null)
            {
                string file = emps.Attribute("photo").Value;
                string path = @"..\..\Data\" + file;
                empPhoto.Image = Image.FromFile("path");
                empName.Text = emps.Attribute("name").Value;
                empBirth.Text = emps.Attribute("birth").Value;
                empAddr.Text = emps.Attribute("addr").Value;
                empPhone.Text = emps.Attribute("phone").Value;
                empEmail.Text = emps.Attribute("email").Value;
                empPos.Text = emps.Attribute("pos").Value;
                empSalary.Text = emps.Attribute("sal").Value;
            }
        }

        private void photoAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|ALL Files (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                photoPath = ofd.FileName;
                empPhoto.Image = Image.FromFile(photoPath);
            }
        }
    }
}
