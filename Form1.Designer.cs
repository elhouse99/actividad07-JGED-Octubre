using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace actividad07_JGED_Octubre
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
            btnEncender = new Button();
            btnApagar = new Button();
            SuspendLayout();
            // 
            // btnEncender
            // 
            btnEncender.Location = new Point(120, 160);
            btnEncender.Name = "btnEncender";
            btnEncender.Size = new Size(120, 50);
            btnEncender.TabIndex = 0;
            btnEncender.Text = "Encender";
            btnEncender.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(320, 160);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(120, 50);
            btnApagar.TabIndex = 1;
            btnApagar.Text = "Apagar";
            btnApagar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 370);
            Controls.Add(btnApagar);
            Controls.Add(btnEncender);
            Name = "Form1";
            Text = "Control Arduino";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEncender;
        private Button btnApagar;
    }
}