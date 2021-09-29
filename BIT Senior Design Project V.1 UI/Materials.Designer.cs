
namespace BIT_Senior_Design_Project_V._1_UI
{
    partial class Materials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Materials));
            this.lblMaterialsHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMaterialsHeading
            // 
            this.lblMaterialsHeading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMaterialsHeading.AutoSize = true;
            this.lblMaterialsHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterialsHeading.Location = new System.Drawing.Point(687, 22);
            this.lblMaterialsHeading.Name = "lblMaterialsHeading";
            this.lblMaterialsHeading.Size = new System.Drawing.Size(227, 55);
            this.lblMaterialsHeading.TabIndex = 0;
            this.lblMaterialsHeading.Text = "Materials";
            this.lblMaterialsHeading.Click += new System.EventHandler(this.lblMaterialsHeading_Click);
            // 
            // Materials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.lblMaterialsHeading);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Materials";
            this.Text = "Materials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaterialsHeading;
    }
}