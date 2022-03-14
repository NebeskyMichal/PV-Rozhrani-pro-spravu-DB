
namespace SkolniKurzy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuCreate = new System.Windows.Forms.Button();
            this.menuUpdate = new System.Windows.Forms.Button();
            this.menuDrop = new System.Windows.Forms.Button();
            this.menuSave = new System.Windows.Forms.Button();
            this.menuBox = new System.Windows.Forms.GroupBox();
            this.quitButton = new System.Windows.Forms.Button();
            this.createBox = new System.Windows.Forms.GroupBox();
            this.createBack = new System.Windows.Forms.Button();
            this.ucitel = new System.Windows.Forms.Button();
            this.zapis = new System.Windows.Forms.Button();
            this.kurz = new System.Windows.Forms.Button();
            this.student = new System.Windows.Forms.Button();
            this.ucitelBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ucitelBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ucBox3 = new System.Windows.Forms.TextBox();
            this.ucSubtim = new System.Windows.Forms.Button();
            this.ucBox2 = new System.Windows.Forms.TextBox();
            this.ucBox1 = new System.Windows.Forms.TextBox();
            this.zapisBox = new System.Windows.Forms.GroupBox();
            this.zapisGridView = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.zapBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.zapBox3 = new System.Windows.Forms.TextBox();
            this.zapBox2 = new System.Windows.Forms.TextBox();
            this.zapBox1 = new System.Windows.Forms.TextBox();
            this.zapButton = new System.Windows.Forms.Button();
            this.zapisBack = new System.Windows.Forms.Button();
            this.studentBox = new System.Windows.Forms.GroupBox();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.studBack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studBox2 = new System.Windows.Forms.TextBox();
            this.studBox1 = new System.Windows.Forms.TextBox();
            this.studButton = new System.Windows.Forms.Button();
            this.kurzBox = new System.Windows.Forms.GroupBox();
            this.kurzGridView = new System.Windows.Forms.DataGridView();
            this.kurzBack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kurzBox2 = new System.Windows.Forms.TextBox();
            this.kurzBox1 = new System.Windows.Forms.TextBox();
            this.kurzButton = new System.Windows.Forms.Button();
            this.menuBox.SuspendLayout();
            this.createBox.SuspendLayout();
            this.ucitelBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.zapisBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zapisGridView)).BeginInit();
            this.studentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            this.kurzBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kurzGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Linux Libertine G", 47F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuCreate
            // 
            this.menuCreate.Location = new System.Drawing.Point(292, 33);
            this.menuCreate.Name = "menuCreate";
            this.menuCreate.Size = new System.Drawing.Size(178, 30);
            this.menuCreate.TabIndex = 1;
            this.menuCreate.Text = "Vytvorit";
            this.menuCreate.UseVisualStyleBackColor = true;
            this.menuCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuUpdate
            // 
            this.menuUpdate.Location = new System.Drawing.Point(292, 86);
            this.menuUpdate.Name = "menuUpdate";
            this.menuUpdate.Size = new System.Drawing.Size(178, 30);
            this.menuUpdate.TabIndex = 2;
            this.menuUpdate.Text = "Upravit";
            this.menuUpdate.UseVisualStyleBackColor = true;
            this.menuUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuDrop
            // 
            this.menuDrop.Location = new System.Drawing.Point(292, 150);
            this.menuDrop.Name = "menuDrop";
            this.menuDrop.Size = new System.Drawing.Size(178, 30);
            this.menuDrop.TabIndex = 3;
            this.menuDrop.Text = "Smazat";
            this.menuDrop.UseVisualStyleBackColor = true;
            this.menuDrop.Click += new System.EventHandler(this.menuDrop_Click);
            // 
            // menuSave
            // 
            this.menuSave.Location = new System.Drawing.Point(292, 208);
            this.menuSave.Name = "menuSave";
            this.menuSave.Size = new System.Drawing.Size(178, 30);
            this.menuSave.TabIndex = 4;
            this.menuSave.Text = "Ulozit informace o zapisech";
            this.menuSave.UseVisualStyleBackColor = true;
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuBox
            // 
            this.menuBox.Controls.Add(this.quitButton);
            this.menuBox.Controls.Add(this.label1);
            this.menuBox.Controls.Add(this.menuCreate);
            this.menuBox.Controls.Add(this.menuSave);
            this.menuBox.Controls.Add(this.menuUpdate);
            this.menuBox.Controls.Add(this.menuDrop);
            this.menuBox.Location = new System.Drawing.Point(0, 0);
            this.menuBox.Name = "menuBox";
            this.menuBox.Size = new System.Drawing.Size(776, 341);
            this.menuBox.TabIndex = 6;
            this.menuBox.TabStop = false;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(295, 264);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(178, 30);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Ukončit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // createBox
            // 
            this.createBox.Controls.Add(this.createBack);
            this.createBox.Controls.Add(this.ucitel);
            this.createBox.Controls.Add(this.zapis);
            this.createBox.Controls.Add(this.kurz);
            this.createBox.Controls.Add(this.student);
            this.createBox.Location = new System.Drawing.Point(0, 0);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(776, 341);
            this.createBox.TabIndex = 5;
            this.createBox.TabStop = false;
            this.createBox.Enter += new System.EventHandler(this.createBox_Enter);
            // 
            // createBack
            // 
            this.createBack.Location = new System.Drawing.Point(295, 284);
            this.createBack.Name = "createBack";
            this.createBack.Size = new System.Drawing.Size(175, 23);
            this.createBack.TabIndex = 5;
            this.createBack.Text = "zpět";
            this.createBack.UseVisualStyleBackColor = true;
            this.createBack.Click += new System.EventHandler(this.createBack_Click);
            // 
            // ucitel
            // 
            this.ucitel.Location = new System.Drawing.Point(295, 42);
            this.ucitel.Name = "ucitel";
            this.ucitel.Size = new System.Drawing.Size(178, 30);
            this.ucitel.TabIndex = 1;
            this.ucitel.Text = "ucitel";
            this.ucitel.UseVisualStyleBackColor = true;
            this.ucitel.Click += new System.EventHandler(this.button5_Click);
            // 
            // zapis
            // 
            this.zapis.Location = new System.Drawing.Point(295, 217);
            this.zapis.Name = "zapis";
            this.zapis.Size = new System.Drawing.Size(178, 30);
            this.zapis.TabIndex = 4;
            this.zapis.Text = "zapis_kurzu";
            this.zapis.UseVisualStyleBackColor = true;
            this.zapis.Click += new System.EventHandler(this.zapis_Click);
            // 
            // kurz
            // 
            this.kurz.Location = new System.Drawing.Point(295, 95);
            this.kurz.Name = "kurz";
            this.kurz.Size = new System.Drawing.Size(178, 30);
            this.kurz.TabIndex = 2;
            this.kurz.Text = "kurz";
            this.kurz.UseVisualStyleBackColor = true;
            this.kurz.Click += new System.EventHandler(this.button7_Click);
            // 
            // student
            // 
            this.student.Location = new System.Drawing.Point(295, 159);
            this.student.Name = "student";
            this.student.Size = new System.Drawing.Size(178, 30);
            this.student.TabIndex = 3;
            this.student.Text = "student";
            this.student.UseVisualStyleBackColor = true;
            this.student.Click += new System.EventHandler(this.student_Click);
            // 
            // ucitelBox
            // 
            this.ucitelBox.Controls.Add(this.dataGridView1);
            this.ucitelBox.Controls.Add(this.ucitelBack);
            this.ucitelBox.Controls.Add(this.label4);
            this.ucitelBox.Controls.Add(this.label3);
            this.ucitelBox.Controls.Add(this.label2);
            this.ucitelBox.Controls.Add(this.ucBox3);
            this.ucitelBox.Controls.Add(this.ucSubtim);
            this.ucitelBox.Controls.Add(this.ucBox2);
            this.ucitelBox.Controls.Add(this.ucBox1);
            this.ucitelBox.Location = new System.Drawing.Point(0, 0);
            this.ucitelBox.Name = "ucitelBox";
            this.ucitelBox.Size = new System.Drawing.Size(776, 341);
            this.ucitelBox.TabIndex = 7;
            this.ucitelBox.TabStop = false;
            this.ucitelBox.Text = "ucitel";
            this.ucitelBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ucitelBack
            // 
            this.ucitelBack.Location = new System.Drawing.Point(584, 284);
            this.ucitelBack.Name = "ucitelBack";
            this.ucitelBack.Size = new System.Drawing.Size(175, 23);
            this.ucitelBack.TabIndex = 12;
            this.ucitelBack.Text = "zpět";
            this.ucitelBack.UseVisualStyleBackColor = true;
            this.ucitelBack.Click += new System.EventHandler(this.ucitelBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "datum_narozeni";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "prijmeni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "jmeno";
            // 
            // ucBox3
            // 
            this.ucBox3.Location = new System.Drawing.Point(491, 69);
            this.ucBox3.Name = "ucBox3";
            this.ucBox3.Size = new System.Drawing.Size(100, 20);
            this.ucBox3.TabIndex = 3;
            // 
            // ucSubtim
            // 
            this.ucSubtim.Location = new System.Drawing.Point(338, 131);
            this.ucSubtim.Name = "ucSubtim";
            this.ucSubtim.Size = new System.Drawing.Size(75, 23);
            this.ucSubtim.TabIndex = 0;
            this.ucSubtim.Text = "Potvrdit";
            this.ucSubtim.UseVisualStyleBackColor = true;
            this.ucSubtim.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ucBox2
            // 
            this.ucBox2.Location = new System.Drawing.Point(324, 69);
            this.ucBox2.Name = "ucBox2";
            this.ucBox2.Size = new System.Drawing.Size(100, 20);
            this.ucBox2.TabIndex = 2;
            // 
            // ucBox1
            // 
            this.ucBox1.Location = new System.Drawing.Point(158, 69);
            this.ucBox1.Name = "ucBox1";
            this.ucBox1.Size = new System.Drawing.Size(100, 20);
            this.ucBox1.TabIndex = 1;
            // 
            // zapisBox
            // 
            this.zapisBox.Controls.Add(this.zapisGridView);
            this.zapisBox.Controls.Add(this.label12);
            this.zapisBox.Controls.Add(this.zapBox4);
            this.zapisBox.Controls.Add(this.label9);
            this.zapisBox.Controls.Add(this.label10);
            this.zapisBox.Controls.Add(this.label11);
            this.zapisBox.Controls.Add(this.zapBox3);
            this.zapisBox.Controls.Add(this.zapBox2);
            this.zapisBox.Controls.Add(this.zapBox1);
            this.zapisBox.Controls.Add(this.zapButton);
            this.zapisBox.Controls.Add(this.zapisBack);
            this.zapisBox.Location = new System.Drawing.Point(0, 0);
            this.zapisBox.Name = "zapisBox";
            this.zapisBox.Size = new System.Drawing.Size(776, 341);
            this.zapisBox.TabIndex = 8;
            this.zapisBox.TabStop = false;
            this.zapisBox.Text = "zapis_kurzu";
            this.zapisBox.Enter += new System.EventHandler(this.zapisBox_Enter);
            // 
            // zapisGridView
            // 
            this.zapisGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.zapisGridView.Location = new System.Drawing.Point(12, 174);
            this.zapisGridView.Name = "zapisGridView";
            this.zapisGridView.Size = new System.Drawing.Size(535, 150);
            this.zapisGridView.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(563, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "cena_kurzu";
            // 
            // zapBox4
            // 
            this.zapBox4.Location = new System.Drawing.Point(549, 81);
            this.zapBox4.Name = "zapBox4";
            this.zapBox4.Size = new System.Drawing.Size(100, 20);
            this.zapBox4.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "datum_konani";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "student_id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(155, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "kurz_id";
            // 
            // zapBox3
            // 
            this.zapBox3.Location = new System.Drawing.Point(403, 81);
            this.zapBox3.Name = "zapBox3";
            this.zapBox3.Size = new System.Drawing.Size(100, 20);
            this.zapBox3.TabIndex = 3;
            // 
            // zapBox2
            // 
            this.zapBox2.Location = new System.Drawing.Point(262, 81);
            this.zapBox2.Name = "zapBox2";
            this.zapBox2.Size = new System.Drawing.Size(100, 20);
            this.zapBox2.TabIndex = 2;
            // 
            // zapBox1
            // 
            this.zapBox1.Location = new System.Drawing.Point(123, 81);
            this.zapBox1.Name = "zapBox1";
            this.zapBox1.Size = new System.Drawing.Size(100, 20);
            this.zapBox1.TabIndex = 1;
            // 
            // zapButton
            // 
            this.zapButton.Location = new System.Drawing.Point(338, 142);
            this.zapButton.Name = "zapButton";
            this.zapButton.Size = new System.Drawing.Size(75, 23);
            this.zapButton.TabIndex = 0;
            this.zapButton.Text = "Potvrdit";
            this.zapButton.UseVisualStyleBackColor = true;
            this.zapButton.Click += new System.EventHandler(this.zapButton_Click);
            // 
            // zapisBack
            // 
            this.zapisBack.Location = new System.Drawing.Point(584, 301);
            this.zapisBack.Name = "zapisBack";
            this.zapisBack.Size = new System.Drawing.Size(175, 23);
            this.zapisBack.TabIndex = 9;
            this.zapisBack.Text = "zpět";
            this.zapisBack.UseVisualStyleBackColor = true;
            this.zapisBack.Click += new System.EventHandler(this.zapisBack_Click);
            // 
            // studentBox
            // 
            this.studentBox.Controls.Add(this.studentGridView);
            this.studentBox.Controls.Add(this.studBack);
            this.studentBox.Controls.Add(this.label5);
            this.studentBox.Controls.Add(this.label8);
            this.studentBox.Controls.Add(this.studBox2);
            this.studentBox.Controls.Add(this.studBox1);
            this.studentBox.Controls.Add(this.studButton);
            this.studentBox.Location = new System.Drawing.Point(0, 0);
            this.studentBox.Name = "studentBox";
            this.studentBox.Size = new System.Drawing.Size(776, 341);
            this.studentBox.TabIndex = 9;
            this.studentBox.TabStop = false;
            this.studentBox.Text = "student";
            this.studentBox.Enter += new System.EventHandler(this.studentBox_Enter);
            // 
            // studentGridView
            // 
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Location = new System.Drawing.Point(56, 174);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.Size = new System.Drawing.Size(340, 150);
            this.studentGridView.TabIndex = 11;
            // 
            // studBack
            // 
            this.studBack.Location = new System.Drawing.Point(584, 284);
            this.studBack.Name = "studBack";
            this.studBack.Size = new System.Drawing.Size(175, 23);
            this.studBack.TabIndex = 10;
            this.studBack.Text = "zpět";
            this.studBack.UseVisualStyleBackColor = true;
            this.studBack.Click += new System.EventHandler(this.studBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "prijmeni";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(268, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "jmeno";
            // 
            // studBox2
            // 
            this.studBox2.Location = new System.Drawing.Point(414, 58);
            this.studBox2.Name = "studBox2";
            this.studBox2.Size = new System.Drawing.Size(100, 20);
            this.studBox2.TabIndex = 2;
            // 
            // studBox1
            // 
            this.studBox1.Location = new System.Drawing.Point(236, 58);
            this.studBox1.Name = "studBox1";
            this.studBox1.Size = new System.Drawing.Size(100, 20);
            this.studBox1.TabIndex = 1;
            // 
            // studButton
            // 
            this.studButton.Location = new System.Drawing.Point(338, 132);
            this.studButton.Name = "studButton";
            this.studButton.Size = new System.Drawing.Size(75, 23);
            this.studButton.TabIndex = 0;
            this.studButton.Text = "Potvrdit";
            this.studButton.UseVisualStyleBackColor = true;
            this.studButton.Click += new System.EventHandler(this.studButton_Click);
            // 
            // kurzBox
            // 
            this.kurzBox.Controls.Add(this.kurzGridView);
            this.kurzBox.Controls.Add(this.kurzBack);
            this.kurzBox.Controls.Add(this.label6);
            this.kurzBox.Controls.Add(this.label7);
            this.kurzBox.Controls.Add(this.kurzBox2);
            this.kurzBox.Controls.Add(this.kurzBox1);
            this.kurzBox.Controls.Add(this.kurzButton);
            this.kurzBox.Location = new System.Drawing.Point(0, 0);
            this.kurzBox.Name = "kurzBox";
            this.kurzBox.Size = new System.Drawing.Size(782, 349);
            this.kurzBox.TabIndex = 8;
            this.kurzBox.TabStop = false;
            this.kurzBox.Text = "kurz";
            this.kurzBox.Visible = false;
            this.kurzBox.Enter += new System.EventHandler(this.kurzBox_Enter);
            // 
            // kurzGridView
            // 
            this.kurzGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kurzGridView.Location = new System.Drawing.Point(18, 185);
            this.kurzGridView.Name = "kurzGridView";
            this.kurzGridView.Size = new System.Drawing.Size(535, 150);
            this.kurzGridView.TabIndex = 14;
            // 
            // kurzBack
            // 
            this.kurzBack.Location = new System.Drawing.Point(584, 301);
            this.kurzBack.Name = "kurzBack";
            this.kurzBack.Size = new System.Drawing.Size(175, 23);
            this.kurzBack.TabIndex = 11;
            this.kurzBack.Text = "zpět";
            this.kurzBack.UseVisualStyleBackColor = true;
            this.kurzBack.Click += new System.EventHandler(this.kurzBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "nazev";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "ucitel_id";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kurzBox2
            // 
            this.kurzBox2.Location = new System.Drawing.Point(438, 57);
            this.kurzBox2.Name = "kurzBox2";
            this.kurzBox2.Size = new System.Drawing.Size(100, 20);
            this.kurzBox2.TabIndex = 2;
            // 
            // kurzBox1
            // 
            this.kurzBox1.Location = new System.Drawing.Point(260, 57);
            this.kurzBox1.Name = "kurzBox1";
            this.kurzBox1.Size = new System.Drawing.Size(100, 20);
            this.kurzBox1.TabIndex = 1;
            // 
            // kurzButton
            // 
            this.kurzButton.Location = new System.Drawing.Point(355, 150);
            this.kurzButton.Name = "kurzButton";
            this.kurzButton.Size = new System.Drawing.Size(75, 23);
            this.kurzButton.TabIndex = 0;
            this.kurzButton.Text = "Potvrdit";
            this.kurzButton.UseVisualStyleBackColor = true;
            this.kurzButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.menuBox);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.zapisBox);
            this.Controls.Add(this.ucitelBox);
            this.Controls.Add(this.studentBox);
            this.Controls.Add(this.kurzBox);
            this.Name = "Form1";
            this.Text = "SkolniKurzy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuBox.ResumeLayout(false);
            this.createBox.ResumeLayout(false);
            this.ucitelBox.ResumeLayout(false);
            this.ucitelBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.zapisBox.ResumeLayout(false);
            this.zapisBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zapisGridView)).EndInit();
            this.studentBox.ResumeLayout(false);
            this.studentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            this.kurzBox.ResumeLayout(false);
            this.kurzBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kurzGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button menuCreate;
        private System.Windows.Forms.Button menuUpdate;
        private System.Windows.Forms.Button menuDrop;
        private System.Windows.Forms.Button menuSave;
        private System.Windows.Forms.GroupBox menuBox;
        private System.Windows.Forms.GroupBox createBox;
        private System.Windows.Forms.Button ucitel;
        private System.Windows.Forms.Button zapis;
        private System.Windows.Forms.Button kurz;
        private System.Windows.Forms.Button student;
        private System.Windows.Forms.GroupBox ucitelBox;
        private System.Windows.Forms.Button ucSubtim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ucBox3;
        private System.Windows.Forms.TextBox ucBox2;
        private System.Windows.Forms.TextBox ucBox1;
        private System.Windows.Forms.GroupBox kurzBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox kurzBox2;
        private System.Windows.Forms.TextBox kurzBox1;
        private System.Windows.Forms.Button kurzButton;
        private System.Windows.Forms.GroupBox studentBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studBox2;
        private System.Windows.Forms.TextBox studBox1;
        private System.Windows.Forms.Button studButton;
        private System.Windows.Forms.GroupBox zapisBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox zapBox3;
        private System.Windows.Forms.TextBox zapBox2;
        private System.Windows.Forms.TextBox zapBox1;
        private System.Windows.Forms.Button zapButton;
        private System.Windows.Forms.TextBox zapBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button createBack;
        private System.Windows.Forms.Button zapisBack;
        private System.Windows.Forms.Button studBack;
        private System.Windows.Forms.Button kurzBack;
        private System.Windows.Forms.Button ucitelBack;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView kurzGridView;
        private System.Windows.Forms.DataGridView studentGridView;
        private System.Windows.Forms.DataGridView zapisGridView;
        private System.Windows.Forms.Button quitButton;
    }
}

