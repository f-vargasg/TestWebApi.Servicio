
namespace WinTestConsumeWebApi
{
    partial class FrmPrincTestWebApi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincTestWebApi));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tlsStrMenuPrinc = new System.Windows.Forms.ToolStrip();
            this.tlsStrButTest = new System.Windows.Forms.ToolStripButton();
            this.tlsStrButExit = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tlsStrMenuPrinc.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensaje:";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(128, 31);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(686, 26);
            this.txtMsg.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMsg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 124);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Location = new System.Drawing.Point(3, 142);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 364);
            this.panel2.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(3, 2);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(895, 358);
            this.txtOutput.TabIndex = 2;
            // 
            // tlsStrMenuPrinc
            // 
            this.tlsStrMenuPrinc.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlsStrMenuPrinc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsStrButTest,
            this.tlsStrButExit});
            this.tlsStrMenuPrinc.Location = new System.Drawing.Point(0, 0);
            this.tlsStrMenuPrinc.Name = "tlsStrMenuPrinc";
            this.tlsStrMenuPrinc.Size = new System.Drawing.Size(901, 27);
            this.tlsStrMenuPrinc.TabIndex = 4;
            this.tlsStrMenuPrinc.Text = "toolStrip1";
            // 
            // tlsStrButTest
            // 
            this.tlsStrButTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrButTest.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrButTest.Image")));
            this.tlsStrButTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrButTest.Name = "tlsStrButTest";
            this.tlsStrButTest.Size = new System.Drawing.Size(29, 24);
            this.tlsStrButTest.Text = "toolStripButton1";
            this.tlsStrButTest.ToolTipText = "Test";
            this.tlsStrButTest.Click += new System.EventHandler(this.tlsStrButTest_Click);
            // 
            // tlsStrButExit
            // 
            this.tlsStrButExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsStrButExit.Image = ((System.Drawing.Image)(resources.GetObject("tlsStrButExit.Image")));
            this.tlsStrButExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsStrButExit.Name = "tlsStrButExit";
            this.tlsStrButExit.Size = new System.Drawing.Size(29, 24);
            this.tlsStrButExit.Text = "toolStripButton2";
            this.tlsStrButExit.ToolTipText = "Exit";
            this.tlsStrButExit.Click += new System.EventHandler(this.tlsStrButExit_Click);
            // 
            // FrmPrincTestWebApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 503);
            this.Controls.Add(this.tlsStrMenuPrinc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPrincTestWebApi";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tlsStrMenuPrinc.ResumeLayout(false);
            this.tlsStrMenuPrinc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ToolStrip tlsStrMenuPrinc;
        private System.Windows.Forms.ToolStripButton tlsStrButTest;
        private System.Windows.Forms.ToolStripButton tlsStrButExit;
    }
}

