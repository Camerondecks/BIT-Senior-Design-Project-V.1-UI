
namespace BIT_Senior_Design_Project_V._1_UI
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnCustomerInfo = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventory.FlatAppearance.BorderSize = 2;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnInventory.Location = new System.Drawing.Point(454, 2);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(444, 255);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnCustomerInfo
            // 
            this.btnCustomerInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerInfo.FlatAppearance.BorderSize = 2;
            this.btnCustomerInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerInfo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnCustomerInfo.Location = new System.Drawing.Point(4, 2);
            this.btnCustomerInfo.Name = "btnCustomerInfo";
            this.btnCustomerInfo.Size = new System.Drawing.Size(444, 255);
            this.btnCustomerInfo.TabIndex = 2;
            this.btnCustomerInfo.Text = "Customer Information";
            this.btnCustomerInfo.UseVisualStyleBackColor = false;
            this.btnCustomerInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.BackColor = System.Drawing.Color.Transparent;
            this.btnMaterials.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMaterials.FlatAppearance.BorderSize = 2;
            this.btnMaterials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterials.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterials.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnMaterials.Location = new System.Drawing.Point(4, 263);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Size = new System.Drawing.Size(444, 253);
            this.btnMaterials.TabIndex = 3;
            this.btnMaterials.Text = "Materials";
            this.btnMaterials.UseVisualStyleBackColor = false;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.Transparent;
            this.btnSales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSales.FlatAppearance.BorderSize = 2;
            this.btnSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnSales.Location = new System.Drawing.Point(454, 263);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(444, 253);
            this.btnSales.TabIndex = 4;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(902, 517);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnMaterials);
            this.Controls.Add(this.btnCustomerInfo);
            this.Controls.Add(this.btnInventory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broad Force Archery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnCustomerInfo;
        private System.Windows.Forms.Button btnMaterials;
        private System.Windows.Forms.Button btnSales;
    }
}

