﻿namespace CursoWindowsForms
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            this.Tls_Principal = new System.Windows.Forms.ToolStrip();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ApagatoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Tls_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tls_Principal
            // 
            this.Tls_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripButton,
            this.ApagatoolStripButton1});
            this.Tls_Principal.Location = new System.Drawing.Point(0, 0);
            this.Tls_Principal.Name = "Tls_Principal";
            this.Tls_Principal.Size = new System.Drawing.Size(329, 25);
            this.Tls_Principal.TabIndex = 61;
            this.Tls_Principal.Text = "toolStrip1";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            // 
            // ApagatoolStripButton1
            // 
            this.ApagatoolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ApagatoolStripButton1.Image = global::CursoWindowsForms.Properties.Resources.ExcluirBarra;
            this.ApagatoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ApagatoolStripButton1.Name = "ApagatoolStripButton1";
            this.ApagatoolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ApagatoolStripButton1.Text = "toolStripButton1";
            this.ApagatoolStripButton1.Click += new System.EventHandler(this.ApagatoolStripButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 238);
            this.listBox1.TabIndex = 62;
            // 
            // Frm_Busca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 281);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Tls_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Busca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Busca";
            this.Load += new System.EventHandler(this.Frm_Busca_Load);
            this.Tls_Principal.ResumeLayout(false);
            this.Tls_Principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Tls_Principal;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripButton ApagatoolStripButton1;
        private System.Windows.Forms.ListBox listBox1;
    }
}