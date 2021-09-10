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
        string sourcePhotoPath;
        string defPhotoPath;
        string name;
        XDocument doc1;
        XDocument doc2;
        Random rand;

        public Form1()
        {
            InitializeComponent();
            path1 = @"..\..\Data\departments.xml";
            path2 = @"..\..\Data\emloyees.xml";
            defPhotoPath = @"..\..\Images\profile.png";
            doc1 = XDocument.Load(path1);
            doc2 = XDocument.Load(path2);
            rand = new Random(DateTime.Now.Millisecond);
        }

        private void depList_Load()
        {
            var deps = doc1.Element("root").Elements("department").ToList();
            foreach (var dep in deps)
                depList.Items.Add(dep.Attribute("name").Value);
            if (depList.Items.Count > 0)
                depList.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            depList_Load();
        }

        private void depAdd_Click(object sender, EventArgs e)
        {
            name = depName.Text;
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Назва департаменту не вказана!", "Упс!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!depList.Items.Contains(name))
            {
                depList.Items.Add(name);
                doc1.Element("root").Add(
                    new XElement("department",
                    new XAttribute("name", name)));
                doc1.Save(path1);
                depList.SelectedItem = name;
                depName.Clear();
                MessageBox.Show($"Департамент {name} додано", "Сповіщення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Департамент '{name}' вже існує", "Сповіщення",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void depSave_Click(object sender, EventArgs e)
        {
            if (depList.Items.Count == 0)
            {
                MessageBox.Show("Департаменти відсутні!", "Упс!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                name = depList.SelectedItem.ToString();
                string newName = depName.Text;
                if (String.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Нова назва департаменту не вказана!", "Упс!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!depList.Items.Contains(newName))
                {
                    doc1.Element("root").Elements("department")
                        .Where(n => n.Attribute("name").Value == name).First()
                        .Attribute("name").Value = depName.Text;
                        doc1.Save(path1);
                        depList.Items.Clear();
                        depList_Load();
                        depList.SelectedItem = newName;
                    depList.SelectedIndex = depList.FindStringExact(newName);
                    depName.Clear();
                    var emps = doc2.Root.Elements("employee")
                        .Where(n=>n.Attribute("dep_name").Value == name)
                        .ToList();
                    if (emps.Count > 0)
                    {
                        foreach (var emp in emps)                            
                        {
                            emp.Attribute("dep_name").Value = newName;
                        }
                        doc2.Save(path2);
                        empList.Items.Clear();
                        foreach (var emp in emps)
                        {
                            empList.Items.Add(emp.Attribute("name").Value);
                        }
                        MessageBox.Show($"Департамент '{name}' перейменовано\n" +
                        $"Нова назва '{newName}'", "Сповіщення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Департамент '{newName}' вже існує", "Сповіщення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void depDel_Click(object sender, EventArgs e)
        {
            if (depList.Items.Count == 0)
            {
                MessageBox.Show("Департаменти відсутні!", "Упс!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (MessageBox.Show("Ви дійсно збираєтесь видалити відділ?", "Увага!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    name = depList.SelectedItem.ToString();
                    doc1.Element("root").Elements("department")
                        .Where(n => n.Attribute("name").Value == name).First().Remove();
                    doc1.Save(path1);
                    depList.Items.Remove(name);
                    if (depList.Items.Count > 0)
                        depList.SelectedIndex = 0;
                    depName.Clear();
                    var emps = doc2.Root.Elements("employee")
                        .Where(n => n.Attribute("dep_name").Value == name).ToList();
                    if (emps.Count > 0)
                    {
                        emps.Remove();
                        doc2.Save(path2);
                    }
                    MessageBox.Show($"Департамент '{name}' видалено", "Сповіщення",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }                                  
            }
        }

        private void depList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearFields();
            depListShowEmps();
        }

        private void depListShowEmps()
        {
            string dep_name = depList.SelectedItem.ToString();
            var emps = doc2.Element("root").Elements("employee")
                .Where(emp => emp.Attribute("dep_name").Value == dep_name).ToList();
            empList.Items.Clear();
            foreach (var emp in emps)
            {
                empList.Items.Add(emp.Attribute("name").Value);
            }
        }

        private void empList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(empList.SelectedItem != null)
            {
                string dep_name = depList.SelectedItem.ToString();
                string emp_name = empList.SelectedItem.ToString();
                var emps = doc2.Root.Elements("employee")
                    .Where(emp => emp.Attribute("dep_name").Value == dep_name &&
                    emp.Attribute("name").Value == emp_name).ToList()
                    .FirstOrDefault();

                if (emps != null)
                {
                    string file = emps.Attribute("photo").Value;
                    string path = @"..\..\Images\" + file;
                    try
                    {
                        empPhoto.Image = Image.FromFile(path);
                    }
                    catch (Exception)
                    {
                        empPhoto.Image = Image.FromFile(defPhotoPath);
                    }
                    empName.Text = emps.Attribute("name").Value;
                    empBirth.Text = emps.Attribute("birth").Value;
                    empAddr.Text = emps.Attribute("addr").Value;
                    empPhone.Text = emps.Attribute("phone").Value;
                    empEmail.Text = emps.Attribute("email").Value;
                    empPos.Text = emps.Attribute("pos").Value;
                    empSalary.Text = emps.Attribute("sal").Value;
                }
            }           
        }

        private void photoAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|ALL Files (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                sourcePhotoPath = ofd.FileName;
                string randomName = $"{rand.Next(0, 999999):000000}";
                photoPath = @"..\..\Images\" + randomName + Path.GetExtension(sourcePhotoPath);
                empPhoto.Image = Image.FromFile(sourcePhotoPath);
            }
        }

        private void ClearFields()
        {
            empPhoto.Image = Image.FromFile(defPhotoPath);
            empList.SelectedIndex = -1;
            empName.Clear();
            empBirth.Value = DateTime.Now;
            empAddr.Clear();
            empPhone.Clear();
            empEmail.Clear();
            empPos.Clear();
            empSalary.Value = 0.0M;
        }

        private void clearFields_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void empAdd_Click(object sender, EventArgs e)
        {
            if (empName.Text != "")
            {
                string dName = depList.SelectedItem.ToString();
                string eName = empName.Text;
                string eBirth = empBirth.Value.ToString();
                string eAddr = empAddr.Text;
                string ePhone = empPhone.Text;
                string eMail = empEmail.Text;
                string ePos = empPos.Text;
                string eSalary = empSalary.Value.ToString();
                string ePhoto;
                var emps = doc2.Root.Elements("employee")
                    .Where(emp => emp.Attribute("dep_name").Value == dName &&
                    emp.Attribute("name").Value == eName).FirstOrDefault();
                if (emps == null)
                {
                    if (photoPath != null) //if photo was changed
                    {
                        File.Copy(sourcePhotoPath, photoPath); //copy photo to @"..\..\Images\"
                        ePhoto = Path.GetFileName(photoPath); // set copied photo name to save
                        photoPath = null;
                    }

                    else
                        ePhoto = "";

                    doc2.Element("root").Add(new XElement("employee",
                        new XAttribute("dep_name", dName),
                        new XAttribute("name", eName),
                        new XAttribute("birth", eBirth),
                        new XAttribute("addr", eAddr),
                        new XAttribute("phone", ePhone),
                        new XAttribute("email", eMail),
                        new XAttribute("pos", ePos),
                        new XAttribute("sal", eSalary),
                        new XAttribute("photo", ePhoto)
                        ));
                    doc2.Save(path2);
                    depListShowEmps();
                    ClearFields();
                    MessageBox.Show("Нового співробітника додано успішно", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Вказаний співробітник вже існує!", "Увага!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Введіть прізвище та ім'я співробітника!", "Увага!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void empDel_Click(object sender, EventArgs e)
        {
            int index = empList.SelectedIndex;
            if (index > -1)
            {
                var emps = doc2.Root.Elements("employee")
                        .Where(n => n.Attribute("dep_name").Value == depList.SelectedItem.ToString())
                        .ToList();
                if (MessageBox.Show($"Ви дійсно збираєтесь видалити співробітника\n" +
                    $"{emps[index].Attribute("name").Value}?", "Увага!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //string tempPhotoPath = @"..\..\Images\" + emps[index].Attribute("photo").Value;
                    emps[index].Remove();
                    doc2.Save(path2);
                    depListShowEmps();
                    ClearFields();
                    //File.Delete(tempPhotoPath);
                    MessageBox.Show("Дані співробітника видалено успішно", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Жодного співробітника не обрано!\n" +
                    "Оберіть співробітника зі списку.", "Увага!",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void empDataChange_Click(object sender, EventArgs e)
        {
            int index = empList.SelectedIndex;
            if (index > -1)
            {
                var emps = doc2.Root.Elements("employee")
                        .Where(n => n.Attribute("dep_name").Value == depList.SelectedItem.ToString())
                        .ToList();

                if (MessageBox.Show($"Ви дійсно збираєтесь змінити дані співробітника\n" +
                    $"{emps[index].Attribute("name").Value}?", "Увага!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    emps[index].Attribute("name").Value = empName.Text;
                    emps[index].Attribute("birth").Value = empBirth.Value.ToString();
                    emps[index].Attribute("addr").Value = empAddr.Text;
                    emps[index].Attribute("phone").Value = empPhone.Text;
                    emps[index].Attribute("email").Value = empEmail.Text;
                    emps[index].Attribute("pos").Value = empPos.Text;
                    emps[index].Attribute("sal").Value = empSalary.Value.ToString();

                    if (photoPath != null) //if photo was changed
                    {
                        File.Copy(sourcePhotoPath, photoPath); //copy photo to @"..\..\Images\"
                        empPhoto.Image = Image.FromFile(photoPath); //set copied photo name to show
                        emps[index].Attribute("photo").Value = Path.GetFileName(photoPath); //set copied photo name to save
                        photoPath = null;
                    }
                    doc2.Save(path2);
                    depListShowEmps();
                    ClearFields();
                    MessageBox.Show("Дані співробітника змінені успішно", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Інфоормація не змінена!", "Увага!", 
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Інфоормація не змінена!\n" +
                    "Оберіть співробітника зі списку", "Увага!",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void photoDel_Click(object sender, EventArgs e)
        {
            int index = empList.SelectedIndex;
            if (index > -1)
            {
                var emps = doc2.Root.Elements("employee")
                        .Where(n => n.Attribute("dep_name").Value == depList.SelectedItem.ToString())
                        .ToList();

                if (MessageBox.Show($"Ви дійсно збираєтесь видалити фото співробітника\n" +
                    $"{emps[index].Attribute("name").Value}?", "Увага!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //string tempPhotoPath = @"..\..\Images\" + emps[index].Attribute("photo").Value;
                    emps[index].Attribute("photo").Value = "";
                    empPhoto.Image = Image.FromFile(defPhotoPath);
                    //File.Delete(tempPhotoPath);
                    doc2.Save(path2);
                    MessageBox.Show($"Фото співробітника {emps[index].Attribute("name").Value}\n" +
                        $"успішно видалене", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else
                    MessageBox.Show("Інфоормація не змінена!", "Увага!",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            MessageBox.Show("Інфоормація не змінена!\n" +
                "Оберіть співробітника зі списку", "Увага!",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
