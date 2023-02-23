
namespace optionApp
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.btnPaleta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelContainer.Location = new System.Drawing.Point(148, -1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(654, 450);
            this.panelContainer.TabIndex = 0;
            // 
            // panelControls
            // 
            this.panelControls.Controls.Add(this.button1);
            this.panelControls.Controls.Add(this.label1);
            this.panelControls.Controls.Add(this.btnPaleta);
            this.panelControls.Location = new System.Drawing.Point(12, -1);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(144, 450);
            this.panelControls.TabIndex = 1;
            // 
            // btnPaleta
            // 
            this.btnPaleta.Location = new System.Drawing.Point(8, 42);
            this.btnPaleta.Name = "btnPaleta";
            this.btnPaleta.Size = new System.Drawing.Size(122, 42);
            this.btnPaleta.TabIndex = 0;
            this.btnPaleta.Text = "Palette";
            this.btnPaleta.UseVisualStyleBackColor = true;
            this.btnPaleta.Click += new System.EventHandler(this.btnPaleta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Text Editor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelContainer);
            this.Name = "Form1";
            this.Text = "CarlosDev-App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPaleta;
        private System.Windows.Forms.Button button1;
    }
}

