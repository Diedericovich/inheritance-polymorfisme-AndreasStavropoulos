
namespace Animals
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
            this.grpBoxAnimals = new System.Windows.Forms.GroupBox();
            this.radBtnHuman = new System.Windows.Forms.RadioButton();
            this.radBtnParrot = new System.Windows.Forms.RadioButton();
            this.radBtnCat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTalk = new System.Windows.Forms.Button();
            this.btnPet = new System.Windows.Forms.Button();
            this.btnEat = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ListBox();
            this.grpBoxAnimals.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxAnimals
            // 
            this.grpBoxAnimals.Controls.Add(this.radBtnHuman);
            this.grpBoxAnimals.Controls.Add(this.radBtnParrot);
            this.grpBoxAnimals.Controls.Add(this.radBtnCat);
            this.grpBoxAnimals.Location = new System.Drawing.Point(29, 41);
            this.grpBoxAnimals.Name = "grpBoxAnimals";
            this.grpBoxAnimals.Size = new System.Drawing.Size(213, 207);
            this.grpBoxAnimals.TabIndex = 1;
            this.grpBoxAnimals.TabStop = false;
            this.grpBoxAnimals.Text = "Animals";
            // 
            // radBtnHuman
            // 
            this.radBtnHuman.AutoSize = true;
            this.radBtnHuman.Location = new System.Drawing.Point(17, 151);
            this.radBtnHuman.Name = "radBtnHuman";
            this.radBtnHuman.Size = new System.Drawing.Size(100, 29);
            this.radBtnHuman.TabIndex = 2;
            this.radBtnHuman.TabStop = true;
            this.radBtnHuman.Text = "Human";
            this.radBtnHuman.UseVisualStyleBackColor = true;
            this.radBtnHuman.CheckedChanged += new System.EventHandler(this.radBtnHuman_CheckedChanged);
            // 
            // radBtnParrot
            // 
            this.radBtnParrot.AutoSize = true;
            this.radBtnParrot.Location = new System.Drawing.Point(17, 101);
            this.radBtnParrot.Name = "radBtnParrot";
            this.radBtnParrot.Size = new System.Drawing.Size(89, 29);
            this.radBtnParrot.TabIndex = 1;
            this.radBtnParrot.TabStop = true;
            this.radBtnParrot.Text = "Parrot";
            this.radBtnParrot.UseVisualStyleBackColor = true;
            this.radBtnParrot.CheckedChanged += new System.EventHandler(this.radBtnParrot_CheckedChanged);
            // 
            // radBtnCat
            // 
            this.radBtnCat.AutoSize = true;
            this.radBtnCat.Location = new System.Drawing.Point(17, 52);
            this.radBtnCat.Name = "radBtnCat";
            this.radBtnCat.Size = new System.Drawing.Size(68, 29);
            this.radBtnCat.TabIndex = 0;
            this.radBtnCat.TabStop = true;
            this.radBtnCat.Text = "Cat";
            this.radBtnCat.UseVisualStyleBackColor = true;
            this.radBtnCat.CheckedChanged += new System.EventHandler(this.radBtnCat_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Give a name:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(265, 71);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(340, 29);
            this.txtBoxName.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(659, 71);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(211, 150);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose a sentence ";
            // 
            // btnTalk
            // 
            this.btnTalk.Location = new System.Drawing.Point(374, 437);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(191, 83);
            this.btnTalk.TabIndex = 7;
            this.btnTalk.Text = "Talk!";
            this.btnTalk.UseVisualStyleBackColor = true;
            this.btnTalk.Click += new System.EventHandler(this.btnTalk_Click);
            // 
            // btnPet
            // 
            this.btnPet.Location = new System.Drawing.Point(51, 557);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(191, 96);
            this.btnPet.TabIndex = 8;
            this.btnPet.Text = "Pet";
            this.btnPet.UseVisualStyleBackColor = true;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnEat
            // 
            this.btnEat.Location = new System.Drawing.Point(374, 557);
            this.btnEat.Name = "btnEat";
            this.btnEat.Size = new System.Drawing.Size(191, 96);
            this.btnEat.TabIndex = 9;
            this.btnEat.Text = "Eat";
            this.btnEat.UseVisualStyleBackColor = true;
            this.btnEat.Click += new System.EventHandler(this.btnEat_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(679, 544);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(191, 96);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Items.AddRange(new object[] {
            "Hello",
            "How are you today?",
            "Are you hungry?",
            "What\'s your name?",
            "How much is 10 + 12?",
            "Which colour is your hair?",
            "Do you have hair?"});
            this.comboBox1.Location = new System.Drawing.Point(46, 420);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.ScrollAlwaysVisible = true;
            this.comboBox1.Size = new System.Drawing.Size(218, 100);
            this.comboBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 685);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEat);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.btnTalk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBoxAnimals);
            this.Name = "Form1";
            this.Text = "Animals";
            this.grpBoxAnimals.ResumeLayout(false);
            this.grpBoxAnimals.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAnimals;
        private System.Windows.Forms.RadioButton radBtnHuman;
        private System.Windows.Forms.RadioButton radBtnParrot;
        private System.Windows.Forms.RadioButton radBtnCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTalk;
        private System.Windows.Forms.Button btnPet;
        private System.Windows.Forms.Button btnEat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox comboBox1;
    }
}

