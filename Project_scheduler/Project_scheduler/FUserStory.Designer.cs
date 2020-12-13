
namespace Project_scheduler
{
    partial class FUserStory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Person = new System.Windows.Forms.Label();
            this.cb_Tulajdonos = new System.Windows.Forms.ComboBox();
            this.cb_Idoszak = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Fontossag = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Allapot = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pERSONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(585, 27);
            this.panel2.TabIndex = 1;
            // 
            // lb_Person
            // 
            this.lb_Person.AutoSize = true;
            this.lb_Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Person.Location = new System.Drawing.Point(24, 146);
            this.lb_Person.Name = "lb_Person";
            this.lb_Person.Size = new System.Drawing.Size(100, 20);
            this.lb_Person.TabIndex = 2;
            this.lb_Person.Text = "Tulajdonos: ";
            // 
            // cb_Tulajdonos
            // 
            this.cb_Tulajdonos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.cb_Tulajdonos.FormattingEnabled = true;
            this.cb_Tulajdonos.Location = new System.Drawing.Point(130, 146);
            this.cb_Tulajdonos.Name = "cb_Tulajdonos";
            this.cb_Tulajdonos.Size = new System.Drawing.Size(133, 24);
            this.cb_Tulajdonos.TabIndex = 3;
            // 
            // cb_Idoszak
            // 
            this.cb_Idoszak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.cb_Idoszak.FormattingEnabled = true;
            this.cb_Idoszak.Location = new System.Drawing.Point(419, 146);
            this.cb_Idoszak.Name = "cb_Idoszak";
            this.cb_Idoszak.Size = new System.Drawing.Size(143, 24);
            this.cb_Idoszak.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Időszak: ";
            // 
            // cb_Fontossag
            // 
            this.cb_Fontossag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.cb_Fontossag.FormattingEnabled = true;
            this.cb_Fontossag.Items.AddRange(new object[] {
            "Alacsony",
            "Közepes",
            "Magas"});
            this.cb_Fontossag.Location = new System.Drawing.Point(419, 205);
            this.cb_Fontossag.Name = "cb_Fontossag";
            this.cb_Fontossag.Size = new System.Drawing.Size(143, 24);
            this.cb_Fontossag.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fontosság: ";
            // 
            // cb_Allapot
            // 
            this.cb_Allapot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.cb_Allapot.FormattingEnabled = true;
            this.cb_Allapot.Items.AddRange(new object[] {
            "Backlog",
            "Kiválasztva",
            "Folyamatban",
            "Kész"});
            this.cb_Allapot.Location = new System.Drawing.Point(130, 205);
            this.cb_Allapot.Name = "cb_Allapot";
            this.cb_Allapot.Size = new System.Drawing.Size(133, 24);
            this.cb_Allapot.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Állapot: ";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(29, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 79);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(468, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pERSONBindingSource1
            // 
            this.pERSONBindingSource1.DataSource = typeof(Project_scheduler.PERSON);
            // 
            // pERSONBindingSource
            // 
            this.pERSONBindingSource.DataSource = typeof(Project_scheduler.PERSON);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(28, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Törlés";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FUserStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(585, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_Fontossag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Allapot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Idoszak);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Tulajdonos);
            this.Controls.Add(this.lb_Person);
            this.Controls.Add(this.panel2);
            this.Name = "FUserStory";
            this.Text = "FUserStory";
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Person;
        private System.Windows.Forms.ComboBox cb_Tulajdonos;
        private System.Windows.Forms.BindingSource pERSONBindingSource;
        private System.Windows.Forms.ComboBox cb_Idoszak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Fontossag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Allapot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource pERSONBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}