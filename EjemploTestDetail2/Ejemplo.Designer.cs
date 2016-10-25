namespace EjemploTestDetail2
{
    partial class Ejemplo
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
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.GrupoIdtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NombreGrupotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EstudiantesdataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.EstudianteIdcomboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(241, 111);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 0;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "GrupoId";
            // 
            // GrupoIdtextBox
            // 
            this.GrupoIdtextBox.Location = new System.Drawing.Point(81, 20);
            this.GrupoIdtextBox.Name = "GrupoIdtextBox";
            this.GrupoIdtextBox.Size = new System.Drawing.Size(155, 20);
            this.GrupoIdtextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NombreGrupotextBox
            // 
            this.NombreGrupotextBox.Location = new System.Drawing.Point(81, 61);
            this.NombreGrupotextBox.Name = "NombreGrupotextBox";
            this.NombreGrupotextBox.Size = new System.Drawing.Size(235, 20);
            this.NombreGrupotextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // EstudiantesdataGridView
            // 
            this.EstudiantesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstudiantesdataGridView.Location = new System.Drawing.Point(12, 148);
            this.EstudiantesdataGridView.Name = "EstudiantesdataGridView";
            this.EstudiantesdataGridView.Size = new System.Drawing.Size(304, 150);
            this.EstudiantesdataGridView.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "EstudianteId";
            // 
            // EstudianteIdcomboBox
            // 
            this.EstudianteIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstudianteIdcomboBox.FormattingEnabled = true;
            this.EstudianteIdcomboBox.Location = new System.Drawing.Point(81, 111);
            this.EstudianteIdcomboBox.Name = "EstudianteIdcomboBox";
            this.EstudianteIdcomboBox.Size = new System.Drawing.Size(155, 21);
            this.EstudianteIdcomboBox.TabIndex = 8;
            this.EstudianteIdcomboBox.SelectedIndexChanged += new System.EventHandler(this.EstudianteIdcomboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(242, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "AgregarEstudiantes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Ejemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 346);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EstudianteIdcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EstudiantesdataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombreGrupotextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GrupoIdtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgregarBtn);
            this.Name = "Ejemplo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ejemplo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EstudiantesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GrupoIdtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NombreGrupotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView EstudiantesdataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EstudianteIdcomboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

