
namespace Project_scheduler
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJelentes = new System.Windows.Forms.Button();
            this.btnKanban = new System.Windows.Forms.Button();
            this.FoPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.btnJelentes);
            this.panel1.Controls.Add(this.btnKanban);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 783);
            this.panel1.TabIndex = 0;
            // 
            // btnJelentes
            // 
            this.btnJelentes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.btnJelentes.FlatAppearance.BorderSize = 0;
            this.btnJelentes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.btnJelentes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJelentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJelentes.ForeColor = System.Drawing.Color.White;
            this.btnJelentes.Location = new System.Drawing.Point(0, 217);
            this.btnJelentes.Name = "btnJelentes";
            this.btnJelentes.Size = new System.Drawing.Size(165, 45);
            this.btnJelentes.TabIndex = 1;
            this.btnJelentes.Text = "Jelentés";
            this.btnJelentes.UseVisualStyleBackColor = false;
            // 
            // btnKanban
            // 
            this.btnKanban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.btnKanban.FlatAppearance.BorderSize = 0;
            this.btnKanban.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(83)))), ((int)(((byte)(71)))));
            this.btnKanban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKanban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKanban.ForeColor = System.Drawing.Color.White;
            this.btnKanban.Location = new System.Drawing.Point(0, 149);
            this.btnKanban.Name = "btnKanban";
            this.btnKanban.Size = new System.Drawing.Size(165, 45);
            this.btnKanban.TabIndex = 0;
            this.btnKanban.Text = "Kanban";
            this.btnKanban.UseVisualStyleBackColor = false;
            this.btnKanban.Click += new System.EventHandler(this.btnKanban_Click);
            // 
            // FoPanel
            // 
            this.FoPanel.BackgroundImage = global::Project_scheduler.Properties.Resources.form_hatter3;
            this.FoPanel.Location = new System.Drawing.Point(164, 0);
            this.FoPanel.Name = "FoPanel";
            this.FoPanel.Size = new System.Drawing.Size(1150, 783);
            this.FoPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1314, 779);
            this.Controls.Add(this.FoPanel);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1332, 826);
            this.MinimumSize = new System.Drawing.Size(1332, 826);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKanban;
        private System.Windows.Forms.Button btnJelentes;
        public System.Windows.Forms.Panel FoPanel;
    }
}

