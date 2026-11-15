namespace WEEK06_WORK07
{
    partial class DataGridView
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
            this.dgv_equipment = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_showall = new System.Windows.Forms.Button();
            this.lbl_selectedItemStatus = new System.Windows.Forms.Label();
            this.cmb_selectedItemStatus = new System.Windows.Forms.ComboBox();
            this.btn_updateStatus = new System.Windows.Forms.Button();
            this.lbl_assetTag = new System.Windows.Forms.Label();
            this.lbl_equipment = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.txt_assetTag = new System.Windows.Forms.TextBox();
            this.txt_equipment = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.btn_addEquipment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_equipment
            // 
            this.dgv_equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_equipment.Location = new System.Drawing.Point(27, 82);
            this.dgv_equipment.Name = "dgv_equipment";
            this.dgv_equipment.RowHeadersWidth = 51;
            this.dgv_equipment.RowTemplate.Height = 24;
            this.dgv_equipment.Size = new System.Drawing.Size(731, 118);
            this.dgv_equipment.TabIndex = 0;
            this.dgv_equipment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(83, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(349, 22);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(24, 32);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(53, 16);
            this.lbl_search.TabIndex = 2;
            this.lbl_search.Text = "Search:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(461, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_showall
            // 
            this.btn_showall.Location = new System.Drawing.Point(567, 29);
            this.btn_showall.Name = "btn_showall";
            this.btn_showall.Size = new System.Drawing.Size(100, 23);
            this.btn_showall.TabIndex = 4;
            this.btn_showall.Text = "Show All";
            this.btn_showall.UseVisualStyleBackColor = true;
            this.btn_showall.Click += new System.EventHandler(this.btn_showall_Click);
            // 
            // lbl_selectedItemStatus
            // 
            this.lbl_selectedItemStatus.AutoSize = true;
            this.lbl_selectedItemStatus.Location = new System.Drawing.Point(24, 227);
            this.lbl_selectedItemStatus.Name = "lbl_selectedItemStatus";
            this.lbl_selectedItemStatus.Size = new System.Drawing.Size(129, 16);
            this.lbl_selectedItemStatus.TabIndex = 5;
            this.lbl_selectedItemStatus.Text = "Selected Item Status";
            // 
            // cmb_selectedItemStatus
            // 
            this.cmb_selectedItemStatus.FormattingEnabled = true;
            this.cmb_selectedItemStatus.Items.AddRange(new object[] {
            "Available",
            "Checked Out",
            "Under Maintenance"});
            this.cmb_selectedItemStatus.Location = new System.Drawing.Point(159, 224);
            this.cmb_selectedItemStatus.Name = "cmb_selectedItemStatus";
            this.cmb_selectedItemStatus.Size = new System.Drawing.Size(160, 24);
            this.cmb_selectedItemStatus.TabIndex = 6;
            this.cmb_selectedItemStatus.SelectedIndexChanged += new System.EventHandler(this.cmb_selectedItemStatus_SelectedIndexChanged);
            // 
            // btn_updateStatus
            // 
            this.btn_updateStatus.Location = new System.Drawing.Point(353, 224);
            this.btn_updateStatus.Name = "btn_updateStatus";
            this.btn_updateStatus.Size = new System.Drawing.Size(134, 24);
            this.btn_updateStatus.TabIndex = 7;
            this.btn_updateStatus.Text = "Update Status";
            this.btn_updateStatus.UseVisualStyleBackColor = true;
            this.btn_updateStatus.Click += new System.EventHandler(this.btn_updateStatus_Click);
            // 
            // lbl_assetTag
            // 
            this.lbl_assetTag.AutoSize = true;
            this.lbl_assetTag.Location = new System.Drawing.Point(27, 320);
            this.lbl_assetTag.Name = "lbl_assetTag";
            this.lbl_assetTag.Size = new System.Drawing.Size(69, 16);
            this.lbl_assetTag.TabIndex = 8;
            this.lbl_assetTag.Text = "Asset Tag";
            // 
            // lbl_equipment
            // 
            this.lbl_equipment.AutoSize = true;
            this.lbl_equipment.Location = new System.Drawing.Point(211, 319);
            this.lbl_equipment.Name = "lbl_equipment";
            this.lbl_equipment.Size = new System.Drawing.Size(71, 16);
            this.lbl_equipment.TabIndex = 9;
            this.lbl_equipment.Text = "Equipment";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(394, 320);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(62, 16);
            this.lbl_category.TabIndex = 10;
            this.lbl_category.Text = "Category";
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(581, 319);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(58, 16);
            this.lbl_location.TabIndex = 11;
            this.lbl_location.Text = "Location";
            // 
            // txt_assetTag
            // 
            this.txt_assetTag.Location = new System.Drawing.Point(30, 339);
            this.txt_assetTag.Name = "txt_assetTag";
            this.txt_assetTag.Size = new System.Drawing.Size(164, 22);
            this.txt_assetTag.TabIndex = 12;
            // 
            // txt_equipment
            // 
            this.txt_equipment.Location = new System.Drawing.Point(214, 338);
            this.txt_equipment.Name = "txt_equipment";
            this.txt_equipment.Size = new System.Drawing.Size(164, 22);
            this.txt_equipment.TabIndex = 13;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(397, 338);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(164, 22);
            this.txt_category.TabIndex = 14;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(584, 339);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(164, 22);
            this.txt_location.TabIndex = 15;
            // 
            // btn_addEquipment
            // 
            this.btn_addEquipment.Location = new System.Drawing.Point(584, 367);
            this.btn_addEquipment.Name = "btn_addEquipment";
            this.btn_addEquipment.Size = new System.Drawing.Size(164, 23);
            this.btn_addEquipment.TabIndex = 16;
            this.btn_addEquipment.Text = "+ Add Equipment";
            this.btn_addEquipment.UseVisualStyleBackColor = true;
            this.btn_addEquipment.Click += new System.EventHandler(this.btn_addEquipment_Click);
            // 
            // DataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_addEquipment);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_equipment);
            this.Controls.Add(this.txt_assetTag);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_equipment);
            this.Controls.Add(this.lbl_assetTag);
            this.Controls.Add(this.btn_updateStatus);
            this.Controls.Add(this.cmb_selectedItemStatus);
            this.Controls.Add(this.lbl_selectedItemStatus);
            this.Controls.Add(this.btn_showall);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_equipment);
            this.Name = "DataGridView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_equipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_equipment;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_showall;
        private System.Windows.Forms.Label lbl_selectedItemStatus;
        private System.Windows.Forms.ComboBox cmb_selectedItemStatus;
        private System.Windows.Forms.Button btn_updateStatus;
        private System.Windows.Forms.Label lbl_assetTag;
        private System.Windows.Forms.Label lbl_equipment;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.TextBox txt_assetTag;
        private System.Windows.Forms.TextBox txt_equipment;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Button btn_addEquipment;
    }
}

