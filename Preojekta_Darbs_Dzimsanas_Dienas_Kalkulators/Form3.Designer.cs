
namespace Preojekta_Darbs_Dzimsanas_Dienas_Kalkulators
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.butRez = new System.Windows.Forms.Button();
            this.labRez = new System.Windows.Forms.Label();
            this.butBack2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(57, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izvēlies personu:";
            // 
            // comBox
            // 
            this.comBox.BackColor = System.Drawing.Color.White;
            this.comBox.FormattingEnabled = true;
            this.comBox.Location = new System.Drawing.Point(391, 89);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(207, 28);
            this.comBox.TabIndex = 1;
            this.comBox.SelectedIndexChanged += new System.EventHandler(this.comBox_SelectedIndexChanged);
            // 
            // butRez
            // 
            this.butRez.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRez.Location = new System.Drawing.Point(63, 276);
            this.butRez.Name = "butRez";
            this.butRez.Size = new System.Drawing.Size(535, 57);
            this.butRez.TabIndex = 2;
            this.butRez.Text = "Kalkulē";
            this.butRez.UseVisualStyleBackColor = false;
            this.butRez.Click += new System.EventHandler(this.butRez_Click);
            // 
            // labRez
            // 
            this.labRez.AutoSize = true;
            this.labRez.BackColor = System.Drawing.Color.SeaGreen;
            this.labRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labRez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labRez.Location = new System.Drawing.Point(415, 184);
            this.labRez.Name = "labRez";
            this.labRez.Size = new System.Drawing.Size(148, 37);
            this.labRez.TabIndex = 3;
            this.labRez.Text = "Rezulāts";
            this.labRez.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // butBack2
            // 
            this.butBack2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butBack2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butBack2.Location = new System.Drawing.Point(63, 403);
            this.butBack2.Name = "butBack2";
            this.butBack2.Size = new System.Drawing.Size(535, 64);
            this.butBack2.TabIndex = 4;
            this.butBack2.Text = "Atgriezties sākumekrānā";
            this.butBack2.UseVisualStyleBackColor = false;
            this.butBack2.Click += new System.EventHandler(this.butBack2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Preojekta_Darbs_Dzimsanas_Dienas_Kalkulators.Properties.Resources.matematika;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 615);
            this.Controls.Add(this.butBack2);
            this.Controls.Add(this.labRez);
            this.Controls.Add(this.butRez);
            this.Controls.Add(this.comBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Dzimšanas Dienu Kalkulātors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBox;
        private System.Windows.Forms.Button butRez;
        private System.Windows.Forms.Label labRez;
        private System.Windows.Forms.Button butBack2;
    }
}