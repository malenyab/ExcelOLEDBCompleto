namespace TestExcel
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btnsubir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbHeaderYes = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblextension = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblestatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btnsuma = new System.Windows.Forms.Button();
            this.Btndivicion = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(644, 345);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblestatus);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblextension);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lblnombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rbHeaderYes);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Btnsubir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 286);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btndivicion);
            this.tabPage2.Controls.Add(this.Btnsuma);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btnsubir
            // 
            this.Btnsubir.Location = new System.Drawing.Point(260, 39);
            this.Btnsubir.Name = "Btnsubir";
            this.Btnsubir.Size = new System.Drawing.Size(105, 34);
            this.Btnsubir.TabIndex = 0;
            this.Btnsubir.Text = "Subri archivo";
            this.Btnsubir.UseVisualStyleBackColor = true;
            this.Btnsubir.Click += new System.EventHandler(this.Btnsubir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Deseas usar la primera fila como nombre de columna?";
            // 
            // rbHeaderYes
            // 
            this.rbHeaderYes.AutoSize = true;
            this.rbHeaderYes.Location = new System.Drawing.Point(328, 90);
            this.rbHeaderYes.Name = "rbHeaderYes";
            this.rbHeaderYes.Size = new System.Drawing.Size(37, 17);
            this.rbHeaderYes.TabIndex = 2;
            this.rbHeaderYes.Text = "Sí";
            this.rbHeaderYes.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre del libro de Excel";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(328, 124);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 13);
            this.lblnombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extención del libro de Excel";
            // 
            // lblextension
            // 
            this.lblextension.AutoSize = true;
            this.lblextension.Location = new System.Drawing.Point(328, 156);
            this.lblextension.Name = "lblextension";
            this.lblextension.Size = new System.Drawing.Size(0, 13);
            this.lblextension.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estatus";
            // 
            // lblestatus
            // 
            this.lblestatus.AutoSize = true;
            this.lblestatus.Location = new System.Drawing.Point(331, 188);
            this.lblestatus.Name = "lblestatus";
            this.lblestatus.Size = new System.Drawing.Size(0, 13);
            this.lblestatus.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btnsuma
            // 
            this.Btnsuma.Location = new System.Drawing.Point(26, 21);
            this.Btnsuma.Name = "Btnsuma";
            this.Btnsuma.Size = new System.Drawing.Size(91, 23);
            this.Btnsuma.TabIndex = 1;
            this.Btnsuma.Text = "Realizar suma";
            this.Btnsuma.UseVisualStyleBackColor = true;
            this.Btnsuma.Click += new System.EventHandler(this.Btnsuma_Click);
            // 
            // Btndivicion
            // 
            this.Btndivicion.Location = new System.Drawing.Point(149, 21);
            this.Btndivicion.Name = "Btndivicion";
            this.Btndivicion.Size = new System.Drawing.Size(91, 23);
            this.Btndivicion.TabIndex = 2;
            this.Btndivicion.Text = "Realizar suma";
            this.Btndivicion.UseVisualStyleBackColor = true;
            this.Btndivicion.Click += new System.EventHandler(this.Btndivicion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 369);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblestatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblextension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rbHeaderYes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnsubir;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btnsuma;
        private System.Windows.Forms.Button Btndivicion;
    }
}

