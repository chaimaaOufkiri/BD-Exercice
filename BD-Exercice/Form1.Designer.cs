
namespace BD_Exercice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.textBoxAuteur = new System.Windows.Forms.TextBox();
            this.comboBoxNom = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAfficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(179, 199);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 34);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 34);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(46, 199);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(112, 34);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(576, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 34);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(436, 199);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(112, 34);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.BackColor = System.Drawing.SystemColors.Window;
            this.lblNom.Location = new System.Drawing.Point(46, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(115, 25);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom du livre";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.BackColor = System.Drawing.SystemColors.Window;
            this.lblPrix.Location = new System.Drawing.Point(46, 73);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(40, 25);
            this.lblPrix.TabIndex = 6;
            this.lblPrix.Text = "Prix";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.BackColor = System.Drawing.SystemColors.Window;
            this.lblAuteur.Location = new System.Drawing.Point(46, 135);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(65, 25);
            this.lblAuteur.TabIndex = 7;
            this.lblAuteur.Text = "Auteur";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Location = new System.Drawing.Point(279, 70);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.Size = new System.Drawing.Size(150, 31);
            this.textBoxPrix.TabIndex = 8;
            // 
            // textBoxAuteur
            // 
            this.textBoxAuteur.Location = new System.Drawing.Point(279, 129);
            this.textBoxAuteur.Name = "textBoxAuteur";
            this.textBoxAuteur.Size = new System.Drawing.Size(150, 31);
            this.textBoxAuteur.TabIndex = 9;
            // 
            // comboBoxNom
            // 
            this.comboBoxNom.FormattingEnabled = true;
            this.comboBoxNom.Items.AddRange(new object[] {
            "livre1",
            "livre2"});
            this.comboBoxNom.Location = new System.Drawing.Point(279, 12);
            this.comboBoxNom.Name = "comboBoxNom";
            this.comboBoxNom.Size = new System.Drawing.Size(182, 33);
            this.comboBoxNom.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(514, 120);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(576, 301);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(145, 46);
            this.btnAfficher.TabIndex = 12;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxNom);
            this.Controls.Add(this.textBoxAuteur);
            this.Controls.Add(this.textBoxPrix);
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblAuteur;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.TextBox textBoxAuteur;
        private System.Windows.Forms.ComboBox comboBoxNom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAfficher;
    }
}

