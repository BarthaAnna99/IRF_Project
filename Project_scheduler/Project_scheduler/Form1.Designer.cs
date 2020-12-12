
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_Idoszak = new System.Windows.Forms.Label();
            this.lb_Ev = new System.Windows.Forms.Label();
            this.panel_Backlog = new System.Windows.Forms.Panel();
            this.panel_Kiv = new System.Windows.Forms.Panel();
            this.panel_Foly = new System.Windows.Forms.Panel();
            this.panel_Kesz = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 686);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.panel_Kesz);
            this.panel2.Controls.Add(this.panel_Foly);
            this.panel2.Controls.Add(this.panel_Kiv);
            this.panel2.Controls.Add(this.panel_Backlog);
            this.panel2.Controls.Add(this.lb_Idoszak);
            this.panel2.Controls.Add(this.lb_Ev);
            this.panel2.Location = new System.Drawing.Point(164, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 689);
            this.panel2.TabIndex = 1;
            // 
            // lb_Idoszak
            // 
            this.lb_Idoszak.AutoSize = true;
            this.lb_Idoszak.BackColor = System.Drawing.Color.Transparent;
            this.lb_Idoszak.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Idoszak.Location = new System.Drawing.Point(419, 55);
            this.lb_Idoszak.Name = "lb_Idoszak";
            this.lb_Idoszak.Size = new System.Drawing.Size(226, 38);
            this.lb_Idoszak.TabIndex = 1;
            this.lb_Idoszak.Text = "12.14. - 12.20.";
            // 
            // lb_Ev
            // 
            this.lb_Ev.AutoSize = true;
            this.lb_Ev.BackColor = System.Drawing.Color.Transparent;
            this.lb_Ev.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ev.Location = new System.Drawing.Point(483, 9);
            this.lb_Ev.Name = "lb_Ev";
            this.lb_Ev.Size = new System.Drawing.Size(112, 46);
            this.lb_Ev.TabIndex = 0;
            this.lb_Ev.Text = "2020";
            // 
            // panel_Backlog
            // 
            this.panel_Backlog.Location = new System.Drawing.Point(22, 147);
            this.panel_Backlog.Name = "panel_Backlog";
            this.panel_Backlog.Size = new System.Drawing.Size(245, 522);
            this.panel_Backlog.TabIndex = 2;
            // 
            // panel_Kiv
            // 
            this.panel_Kiv.Location = new System.Drawing.Point(283, 147);
            this.panel_Kiv.Name = "panel_Kiv";
            this.panel_Kiv.Size = new System.Drawing.Size(245, 522);
            this.panel_Kiv.TabIndex = 3;
            // 
            // panel_Foly
            // 
            this.panel_Foly.Location = new System.Drawing.Point(544, 147);
            this.panel_Foly.Name = "panel_Foly";
            this.panel_Foly.Size = new System.Drawing.Size(245, 522);
            this.panel_Foly.TabIndex = 4;
            // 
            // panel_Kesz
            // 
            this.panel_Kesz.Location = new System.Drawing.Point(805, 147);
            this.panel_Kesz.Name = "panel_Kesz";
            this.panel_Kesz.Size = new System.Drawing.Size(245, 522);
            this.panel_Kesz.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1237, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_Ev;
        private System.Windows.Forms.Label lb_Idoszak;
        private System.Windows.Forms.Panel panel_Kesz;
        private System.Windows.Forms.Panel panel_Foly;
        private System.Windows.Forms.Panel panel_Kiv;
        private System.Windows.Forms.Panel panel_Backlog;
    }
}

