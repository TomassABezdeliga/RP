
namespace Preojekta_Darbs_Dzimsanas_Dienas_Kalkulators
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
            this.butJauns = new System.Windows.Forms.Button();
            this.butKalk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butJauns
            // 
            this.butJauns.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butJauns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butJauns.Location = new System.Drawing.Point(73, 157);
            this.butJauns.Name = "butJauns";
            this.butJauns.Size = new System.Drawing.Size(498, 85);
            this.butJauns.TabIndex = 0;
            this.butJauns.Text = "Ievadīt jaunu personu";
            this.butJauns.UseVisualStyleBackColor = false;
            this.butJauns.Click += new System.EventHandler(this.butJauns_Click);
            // 
            // butKalk
            // 
            this.butKalk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butKalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butKalk.Location = new System.Drawing.Point(73, 314);
            this.butKalk.Name = "butKalk";
            this.butKalk.Size = new System.Drawing.Size(498, 85);
            this.butKalk.TabIndex = 1;
            this.butKalk.Text = "Kalkulē dzimšanas dienu";
            this.butKalk.UseVisualStyleBackColor = false;
            this.butKalk.Click += new System.EventHandler(this.butKalk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Preojekta_Darbs_Dzimsanas_Dienas_Kalkulators.Properties.Resources.matematika;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 615);
            this.Controls.Add(this.butKalk);
            this.Controls.Add(this.butJauns);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Dzimšanas Dienu Kalkulātors";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butJauns;
        private System.Windows.Forms.Button butKalk;
    }
}

