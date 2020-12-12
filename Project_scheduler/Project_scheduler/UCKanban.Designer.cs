
namespace Project_scheduler
{
    partial class UCKanban
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_All = new System.Windows.Forms.Panel();
            this.lb_Idoszak = new System.Windows.Forms.Label();
            this.lb_Ev = new System.Windows.Forms.Label();
            this.lb_Backlog = new System.Windows.Forms.Label();
            this.lb_Kiv = new System.Windows.Forms.Label();
            this.lb_Foly = new System.Windows.Forms.Label();
            this.lb_Kesz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_All
            // 
            this.panel_All.Location = new System.Drawing.Point(22, 152);
            this.panel_All.Name = "panel_All";
            this.panel_All.Size = new System.Drawing.Size(1101, 607);
            this.panel_All.TabIndex = 8;
            // 
            // lb_Idoszak
            // 
            this.lb_Idoszak.AutoSize = true;
            this.lb_Idoszak.BackColor = System.Drawing.Color.Transparent;
            this.lb_Idoszak.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Idoszak.Location = new System.Drawing.Point(472, 51);
            this.lb_Idoszak.Name = "lb_Idoszak";
            this.lb_Idoszak.Size = new System.Drawing.Size(209, 36);
            this.lb_Idoszak.TabIndex = 7;
            this.lb_Idoszak.Text = "12.14. - 12.20.";
            // 
            // lb_Ev
            // 
            this.lb_Ev.AutoSize = true;
            this.lb_Ev.BackColor = System.Drawing.Color.Transparent;
            this.lb_Ev.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ev.Location = new System.Drawing.Point(524, 14);
            this.lb_Ev.Name = "lb_Ev";
            this.lb_Ev.Size = new System.Drawing.Size(112, 46);
            this.lb_Ev.TabIndex = 6;
            this.lb_Ev.Text = "2020";
            // 
            // lb_Backlog
            // 
            this.lb_Backlog.AutoSize = true;
            this.lb_Backlog.BackColor = System.Drawing.Color.Transparent;
            this.lb_Backlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Backlog.Location = new System.Drawing.Point(108, 120);
            this.lb_Backlog.Name = "lb_Backlog";
            this.lb_Backlog.Size = new System.Drawing.Size(82, 25);
            this.lb_Backlog.TabIndex = 12;
            this.lb_Backlog.Text = "Backlog";
            // 
            // lb_Kiv
            // 
            this.lb_Kiv.AutoSize = true;
            this.lb_Kiv.BackColor = System.Drawing.Color.Transparent;
            this.lb_Kiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Kiv.Location = new System.Drawing.Point(378, 120);
            this.lb_Kiv.Name = "lb_Kiv";
            this.lb_Kiv.Size = new System.Drawing.Size(112, 25);
            this.lb_Kiv.TabIndex = 13;
            this.lb_Kiv.Text = "Kiválasztva";
            // 
            // lb_Foly
            // 
            this.lb_Foly.AutoSize = true;
            this.lb_Foly.BackColor = System.Drawing.Color.Transparent;
            this.lb_Foly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Foly.Location = new System.Drawing.Point(651, 120);
            this.lb_Foly.Name = "lb_Foly";
            this.lb_Foly.Size = new System.Drawing.Size(114, 25);
            this.lb_Foly.TabIndex = 14;
            this.lb_Foly.Text = "Folyamatba";
            // 
            // lb_Kesz
            // 
            this.lb_Kesz.AutoSize = true;
            this.lb_Kesz.BackColor = System.Drawing.Color.Transparent;
            this.lb_Kesz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Kesz.Location = new System.Drawing.Point(957, 120);
            this.lb_Kesz.Name = "lb_Kesz";
            this.lb_Kesz.Size = new System.Drawing.Size(57, 25);
            this.lb_Kesz.TabIndex = 15;
            this.lb_Kesz.Text = "Kész";
            // 
            // UCKanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lb_Kesz);
            this.Controls.Add(this.lb_Foly);
            this.Controls.Add(this.lb_Kiv);
            this.Controls.Add(this.lb_Backlog);
            this.Controls.Add(this.panel_All);
            this.Controls.Add(this.lb_Idoszak);
            this.Controls.Add(this.lb_Ev);
            this.Name = "UCKanban";
            this.Size = new System.Drawing.Size(1150, 783);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_All;
        private System.Windows.Forms.Label lb_Idoszak;
        private System.Windows.Forms.Label lb_Ev;
        private System.Windows.Forms.Label lb_Backlog;
        private System.Windows.Forms.Label lb_Kiv;
        private System.Windows.Forms.Label lb_Foly;
        private System.Windows.Forms.Label lb_Kesz;
    }
}
