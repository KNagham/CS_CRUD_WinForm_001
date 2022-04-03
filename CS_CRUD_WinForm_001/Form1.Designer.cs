namespace CS_CRUD_WinForm_001
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAlter = new System.Windows.Forms.TextBox();
            this.txtFach = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.checkBoxAbgeschlossen = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fach";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Note";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Abgeschlossen";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(223, 59);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(154, 27);
            this.txtVorname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(154, 27);
            this.txtName.TabIndex = 8;
            // 
            // txtAlter
            // 
            this.txtAlter.Location = new System.Drawing.Point(223, 157);
            this.txtAlter.Name = "txtAlter";
            this.txtAlter.Size = new System.Drawing.Size(154, 27);
            this.txtAlter.TabIndex = 9;
            // 
            // txtFach
            // 
            this.txtFach.Location = new System.Drawing.Point(223, 197);
            this.txtFach.Name = "txtFach";
            this.txtFach.Size = new System.Drawing.Size(154, 27);
            this.txtFach.TabIndex = 10;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(223, 237);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(154, 27);
            this.txtNote.TabIndex = 11;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(108, 357);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(94, 29);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // checkBoxAbgeschlossen
            // 
            this.checkBoxAbgeschlossen.AutoSize = true;
            this.checkBoxAbgeschlossen.Location = new System.Drawing.Point(223, 286);
            this.checkBoxAbgeschlossen.Name = "checkBoxAbgeschlossen";
            this.checkBoxAbgeschlossen.Size = new System.Drawing.Size(18, 17);
            this.checkBoxAbgeschlossen.TabIndex = 14;
            this.checkBoxAbgeschlossen.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(257, 357);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(223, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(154, 27);
            this.txtId.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkBoxAbgeschlossen);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtFach);
            this.Controls.Add(this.txtAlter);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtVorname;
        private TextBox txtName;
        private TextBox txtAlter;
        private TextBox txtFach;
        private TextBox txtNote;
        private Button btnInsert;
        private CheckBox checkBoxAbgeschlossen;
        private Button btnUpdate;
        private TextBox txtId;
    }
}