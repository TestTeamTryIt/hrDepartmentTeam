
namespace hrDepartment
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.empPhoto = new System.Windows.Forms.PictureBox();
            this.photoDel = new System.Windows.Forms.Button();
            this.photoSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.photoAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empList = new System.Windows.Forms.ListBox();
            this.depDel = new System.Windows.Forms.Button();
            this.depSave = new System.Windows.Forms.Button();
            this.depAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.depName = new System.Windows.Forms.TextBox();
            this.deps = new System.Windows.Forms.Label();
            this.depList = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearFields = new System.Windows.Forms.Button();
            this.empDel = new System.Windows.Forms.Button();
            this.empSave = new System.Windows.Forms.Button();
            this.empAdd = new System.Windows.Forms.Button();
            this.empSalary = new System.Windows.Forms.NumericUpDown();
            this.empBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.empPos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empAddr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.empName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.empPhoto);
            this.groupBox1.Controls.Add(this.photoDel);
            this.groupBox1.Controls.Add(this.photoSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.photoAdd);
            this.groupBox1.Location = new System.Drawing.Point(388, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 576);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фото";
            // 
            // empPhoto
            // 
            this.empPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.empPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.empPhoto.Image = global::hrDepartment.Properties.Resources.profile;
            this.empPhoto.InitialImage = null;
            this.empPhoto.Location = new System.Drawing.Point(6, 42);
            this.empPhoto.Name = "empPhoto";
            this.empPhoto.Size = new System.Drawing.Size(306, 270);
            this.empPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.empPhoto.TabIndex = 0;
            this.empPhoto.TabStop = false;
            // 
            // photoDel
            // 
            this.photoDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoDel.Location = new System.Drawing.Point(210, 522);
            this.photoDel.Name = "photoDel";
            this.photoDel.Size = new System.Drawing.Size(90, 40);
            this.photoDel.TabIndex = 4;
            this.photoDel.Text = "Del";
            this.photoDel.UseVisualStyleBackColor = true;
            // 
            // photoSave
            // 
            this.photoSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoSave.Location = new System.Drawing.Point(114, 522);
            this.photoSave.Name = "photoSave";
            this.photoSave.Size = new System.Drawing.Size(90, 40);
            this.photoSave.TabIndex = 4;
            this.photoSave.Text = "Save";
            this.photoSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Фото сотрудника";
            // 
            // photoAdd
            // 
            this.photoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoAdd.Location = new System.Drawing.Point(18, 522);
            this.photoAdd.Name = "photoAdd";
            this.photoAdd.Size = new System.Drawing.Size(90, 40);
            this.photoAdd.TabIndex = 4;
            this.photoAdd.Text = "Add";
            this.photoAdd.UseVisualStyleBackColor = true;
            this.photoAdd.Click += new System.EventHandler(this.photoAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empList);
            this.groupBox2.Controls.Add(this.depDel);
            this.groupBox2.Controls.Add(this.depSave);
            this.groupBox2.Controls.Add(this.depAdd);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.depName);
            this.groupBox2.Controls.Add(this.deps);
            this.groupBox2.Controls.Add(this.depList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(381, 590);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сотрудники";
            // 
            // empList
            // 
            this.empList.FormattingEnabled = true;
            this.empList.ItemHeight = 15;
            this.empList.Location = new System.Drawing.Point(6, 187);
            this.empList.Name = "empList";
            this.empList.ScrollAlwaysVisible = true;
            this.empList.Size = new System.Drawing.Size(368, 364);
            this.empList.TabIndex = 5;
            this.empList.SelectedIndexChanged += new System.EventHandler(this.empList_SelectedIndexChanged);
            // 
            // depDel
            // 
            this.depDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depDel.Location = new System.Drawing.Point(240, 100);
            this.depDel.Name = "depDel";
            this.depDel.Size = new System.Drawing.Size(90, 25);
            this.depDel.TabIndex = 4;
            this.depDel.Text = "Del";
            this.depDel.UseVisualStyleBackColor = true;
            // 
            // depSave
            // 
            this.depSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depSave.Location = new System.Drawing.Point(144, 100);
            this.depSave.Name = "depSave";
            this.depSave.Size = new System.Drawing.Size(90, 25);
            this.depSave.TabIndex = 4;
            this.depSave.Text = "Save";
            this.depSave.UseVisualStyleBackColor = true;
            // 
            // depAdd
            // 
            this.depAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depAdd.Location = new System.Drawing.Point(48, 100);
            this.depAdd.Name = "depAdd";
            this.depAdd.Size = new System.Drawing.Size(90, 25);
            this.depAdd.TabIndex = 4;
            this.depAdd.Text = "Add";
            this.depAdd.UseVisualStyleBackColor = true;
            this.depAdd.Click += new System.EventHandler(this.depAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Список сотрудников:";
            // 
            // depName
            // 
            this.depName.Location = new System.Drawing.Point(7, 73);
            this.depName.Name = "depName";
            this.depName.Size = new System.Drawing.Size(367, 21);
            this.depName.TabIndex = 3;
            // 
            // deps
            // 
            this.deps.AutoSize = true;
            this.deps.Location = new System.Drawing.Point(6, 24);
            this.deps.Name = "deps";
            this.deps.Size = new System.Drawing.Size(147, 15);
            this.deps.TabIndex = 1;
            this.deps.Text = "Список департаментов:";
            // 
            // depList
            // 
            this.depList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depList.FormattingEnabled = true;
            this.depList.Location = new System.Drawing.Point(7, 42);
            this.depList.Name = "depList";
            this.depList.Size = new System.Drawing.Size(367, 23);
            this.depList.TabIndex = 0;
            this.depList.SelectedIndexChanged += new System.EventHandler(this.depList_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clearFields);
            this.groupBox3.Controls.Add(this.empDel);
            this.groupBox3.Controls.Add(this.empSave);
            this.groupBox3.Controls.Add(this.empAdd);
            this.groupBox3.Controls.Add(this.empSalary);
            this.groupBox3.Controls.Add(this.empBirth);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.empPos);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.empEmail);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.empPhone);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.empAddr);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.empName);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(712, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 590);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация";
            // 
            // clearFields
            // 
            this.clearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearFields.Location = new System.Drawing.Point(80, 384);
            this.clearFields.Name = "clearFields";
            this.clearFields.Size = new System.Drawing.Size(192, 40);
            this.clearFields.TabIndex = 4;
            this.clearFields.Text = "Очистить форму";
            this.clearFields.UseVisualStyleBackColor = true;
            // 
            // empDel
            // 
            this.empDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empDel.Location = new System.Drawing.Point(80, 522);
            this.empDel.Name = "empDel";
            this.empDel.Size = new System.Drawing.Size(192, 40);
            this.empDel.TabIndex = 4;
            this.empDel.Text = "Удалить сотрудника";
            this.empDel.UseVisualStyleBackColor = true;
            // 
            // empSave
            // 
            this.empSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empSave.Location = new System.Drawing.Point(80, 476);
            this.empSave.Name = "empSave";
            this.empSave.Size = new System.Drawing.Size(192, 40);
            this.empSave.TabIndex = 4;
            this.empSave.Text = "Сохранить сотрудника";
            this.empSave.UseVisualStyleBackColor = true;
            // 
            // empAdd
            // 
            this.empAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.empAdd.Location = new System.Drawing.Point(80, 430);
            this.empAdd.Name = "empAdd";
            this.empAdd.Size = new System.Drawing.Size(192, 40);
            this.empAdd.TabIndex = 4;
            this.empAdd.Text = "Добавить сотрудника";
            this.empAdd.UseVisualStyleBackColor = true;
            // 
            // empSalary
            // 
            this.empSalary.Location = new System.Drawing.Point(193, 304);
            this.empSalary.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.empSalary.Name = "empSalary";
            this.empSalary.Size = new System.Drawing.Size(148, 21);
            this.empSalary.TabIndex = 5;
            // 
            // empBirth
            // 
            this.empBirth.Location = new System.Drawing.Point(6, 87);
            this.empBirth.Name = "empBirth";
            this.empBirth.Size = new System.Drawing.Size(338, 21);
            this.empBirth.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Дата рождения:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(120, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Зарплата:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Должность:";
            // 
            // empPos
            // 
            this.empPos.Location = new System.Drawing.Point(6, 263);
            this.empPos.Name = "empPos";
            this.empPos.Size = new System.Drawing.Size(338, 21);
            this.empPos.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email:";
            // 
            // empEmail
            // 
            this.empEmail.Location = new System.Drawing.Point(6, 219);
            this.empEmail.Name = "empEmail";
            this.empEmail.Size = new System.Drawing.Size(338, 21);
            this.empEmail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Телефон:";
            // 
            // empPhone
            // 
            this.empPhone.Location = new System.Drawing.Point(6, 175);
            this.empPhone.Name = "empPhone";
            this.empPhone.Size = new System.Drawing.Size(338, 21);
            this.empPhone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Адрес:";
            // 
            // empAddr
            // 
            this.empAddr.Location = new System.Drawing.Point(6, 131);
            this.empAddr.Name = "empAddr";
            this.empAddr.Size = new System.Drawing.Size(338, 21);
            this.empAddr.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Фамилия, имя:";
            // 
            // empName
            // 
            this.empName.Location = new System.Drawing.Point(6, 44);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(338, 21);
            this.empName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 590);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Система управления отделом кадров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label deps;
        private System.Windows.Forms.ComboBox depList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button photoDel;
        private System.Windows.Forms.Button photoSave;
        private System.Windows.Forms.Button depDel;
        private System.Windows.Forms.Button photoAdd;
        private System.Windows.Forms.Button depSave;
        private System.Windows.Forms.Button depAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depName;
        private System.Windows.Forms.PictureBox empPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox empList;
        private System.Windows.Forms.DateTimePicker empBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empAddr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.Button clearFields;
        private System.Windows.Forms.Button empDel;
        private System.Windows.Forms.Button empSave;
        private System.Windows.Forms.Button empAdd;
        private System.Windows.Forms.NumericUpDown empSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox empPos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empEmail;
    }
}

