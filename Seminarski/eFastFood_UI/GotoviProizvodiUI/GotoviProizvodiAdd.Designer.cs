﻿namespace eFastFood_UI.GotoviProizvodiUI
{
    partial class GotoviProizvodiAdd
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
            this.components = new System.ComponentModel.Container();
            this.dodajButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.nazivInput = new System.Windows.Forms.TextBox();
            this.cijenaInput = new System.Windows.Forms.TextBox();
            this.opisInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.vrijemePripremeInput = new System.Windows.Forms.TextBox();
            this.slikaButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.slikaInput = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.kategorijaComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dodajButton.Location = new System.Drawing.Point(63, 274);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(75, 30);
            this.dodajButton.TabIndex = 5;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.odustaniButton.Location = new System.Drawing.Point(211, 274);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(75, 30);
            this.odustaniButton.TabIndex = 6;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.OdustaniButton_Click);
            // 
            // nazivInput
            // 
            this.nazivInput.Location = new System.Drawing.Point(86, 9);
            this.nazivInput.Name = "nazivInput";
            this.nazivInput.Size = new System.Drawing.Size(173, 20);
            this.nazivInput.TabIndex = 0;
            this.nazivInput.Validating += new System.ComponentModel.CancelEventHandler(this.NazivInput_Validating);
            // 
            // cijenaInput
            // 
            this.cijenaInput.Location = new System.Drawing.Point(85, 34);
            this.cijenaInput.Name = "cijenaInput";
            this.cijenaInput.Size = new System.Drawing.Size(173, 20);
            this.cijenaInput.TabIndex = 1;
            this.cijenaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CijenaInput_KeyPress);
            this.cijenaInput.Validating += new System.ComponentModel.CancelEventHandler(this.CijenaInput_Validating);
            // 
            // opisInput
            // 
            this.opisInput.Location = new System.Drawing.Point(85, 59);
            this.opisInput.Multiline = true;
            this.opisInput.Name = "opisInput";
            this.opisInput.Size = new System.Drawing.Size(237, 55);
            this.opisInput.TabIndex = 2;
            this.opisInput.Validating += new System.ComponentModel.CancelEventHandler(this.OpisInput_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(35, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vrijeme pripreme (minute)";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // vrijemePripremeInput
            // 
            this.vrijemePripremeInput.Location = new System.Drawing.Point(170, 133);
            this.vrijemePripremeInput.Name = "vrijemePripremeInput";
            this.vrijemePripremeInput.Size = new System.Drawing.Size(41, 20);
            this.vrijemePripremeInput.TabIndex = 3;
            this.vrijemePripremeInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CijenaInput_KeyPress);
            // 
            // slikaButton
            // 
            this.slikaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.slikaButton.Location = new System.Drawing.Point(472, 274);
            this.slikaButton.Name = "slikaButton";
            this.slikaButton.Size = new System.Drawing.Size(67, 30);
            this.slikaButton.TabIndex = 4;
            this.slikaButton.Text = "Odaberi";
            this.slikaButton.UseVisualStyleBackColor = true;
            this.slikaButton.Click += new System.EventHandler(this.SlikaButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(413, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Slika";
            // 
            // slikaInput
            // 
            this.slikaInput.Location = new System.Drawing.Point(63, 233);
            this.slikaInput.Name = "slikaInput";
            this.slikaInput.ReadOnly = true;
            this.slikaInput.Size = new System.Drawing.Size(223, 20);
            this.slikaInput.TabIndex = 10;
            this.slikaInput.Visible = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label6.Location = new System.Drawing.Point(24, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kategorija";
            // 
            // kategorijaComboBox
            // 
            this.kategorijaComboBox.DisplayMember = "Text";
            this.kategorijaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategorijaComboBox.FormattingEnabled = true;
            this.kategorijaComboBox.Location = new System.Drawing.Point(99, 159);
            this.kategorijaComboBox.Name = "kategorijaComboBox";
            this.kategorijaComboBox.Size = new System.Drawing.Size(223, 21);
            this.kategorijaComboBox.TabIndex = 12;
            this.kategorijaComboBox.ValueMember = "ID";
            this.kategorijaComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.KategorijaComboBox_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.kategorijaComboBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.vrijemePripremeInput);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.opisInput);
            this.panel1.Controls.Add(this.cijenaInput);
            this.panel1.Controls.Add(this.nazivInput);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 224);
            this.panel1.TabIndex = 13;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::eFastFood_UI.Properties.Resources._default;
            this.pictureBox.Location = new System.Drawing.Point(350, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 256);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 14;
            this.pictureBox.TabStop = false;
            // 
            // GotoviProizvodiAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 341);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.slikaInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.slikaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GotoviProizvodiAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj gotovi proizvod";
            this.Load += new System.EventHandler(this.GotoviProizvodiAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.TextBox nazivInput;
        private System.Windows.Forms.TextBox cijenaInput;
        private System.Windows.Forms.TextBox opisInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox vrijemePripremeInput;
        private System.Windows.Forms.TextBox slikaInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button slikaButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox kategorijaComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}