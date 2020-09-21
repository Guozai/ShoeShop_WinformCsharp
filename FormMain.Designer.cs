namespace Shoe_Shop
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.pictureBoxShoe = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPriceLow = new System.Windows.Forms.TextBox();
            this.buttonSearchByName = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPriceHigh = new System.Windows.Forms.TextBox();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSearchByPrice = new System.Windows.Forms.Button();
            this.buttonDisplayAllShoes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoe)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxShoe
            // 
            this.pictureBoxShoe.Location = new System.Drawing.Point(278, 97);
            this.pictureBoxShoe.Name = "pictureBoxShoe";
            this.pictureBoxShoe.Size = new System.Drawing.Size(272, 178);
            this.pictureBoxShoe.TabIndex = 0;
            this.pictureBoxShoe.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(358, 357);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(65, 12);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "labelPrice";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(344, 292);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 20);
            this.comboBoxColor.TabIndex = 3;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(248, 388);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 4;
            this.buttonPrevious.Text = "<<<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(490, 388);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = ">>>";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(369, 388);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 6;
            this.buttonBuy.Text = "BUY";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemOpen,
            this.toolStripSeparator,
            this.MenuItemSave,
            this.MenuItemSaveAs,
            this.toolStripSeparator1,
            this.MenuItemExit});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.文件FToolStripMenuItem.Text = "File(&F)";
            // 
            // MenuItemOpen
            // 
            this.MenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemOpen.Image")));
            this.MenuItemOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuItemOpen.Name = "MenuItemOpen";
            this.MenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MenuItemOpen.Size = new System.Drawing.Size(180, 22);
            this.MenuItemOpen.Text = "Open(&O)";
            this.MenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemSave
            // 
            this.MenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("MenuItemSave.Image")));
            this.MenuItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuItemSave.Name = "MenuItemSave";
            this.MenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MenuItemSave.Size = new System.Drawing.Size(180, 22);
            this.MenuItemSave.Text = "Save(&S)";
            this.MenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            // 
            // MenuItemSaveAs
            // 
            this.MenuItemSaveAs.Name = "MenuItemSaveAs";
            this.MenuItemSaveAs.Size = new System.Drawing.Size(180, 22);
            this.MenuItemSaveAs.Text = "Save As(&A)";
            this.MenuItemSaveAs.Click += new System.EventHandler(this.MenuItemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.MenuItemExit.Text = "Exit(&X)";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.MenuItemAbout});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(64, 21);
            this.帮助HToolStripMenuItem.Text = "Help(&H)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(180, 22);
            this.MenuItemAbout.Text = "About(&A)...";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(342, 328);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 12);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "labelName";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(32, 68);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(111, 21);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxPriceLow
            // 
            this.textBoxPriceLow.Location = new System.Drawing.Point(32, 134);
            this.textBoxPriceLow.Name = "textBoxPriceLow";
            this.textBoxPriceLow.Size = new System.Drawing.Size(36, 21);
            this.textBoxPriceLow.TabIndex = 10;
            this.textBoxPriceLow.Text = "0";
            // 
            // buttonSearchByName
            // 
            this.buttonSearchByName.Location = new System.Drawing.Point(162, 68);
            this.buttonSearchByName.Name = "buttonSearchByName";
            this.buttonSearchByName.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByName.TabIndex = 11;
            this.buttonSearchByName.Text = "Search";
            this.buttonSearchByName.UseVisualStyleBackColor = true;
            this.buttonSearchByName.Click += new System.EventHandler(this.buttonSearchByName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Shoe Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "-";
            // 
            // textBoxPriceHigh
            // 
            this.textBoxPriceHigh.Location = new System.Drawing.Point(107, 134);
            this.textBoxPriceHigh.Name = "textBoxPriceHigh";
            this.textBoxPriceHigh.Size = new System.Drawing.Size(36, 21);
            this.textBoxPriceHigh.TabIndex = 15;
            this.textBoxPriceHigh.Text = "100";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(567, 56);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.ReadOnly = true;
            this.textBoxMoney.Size = new System.Drawing.Size(100, 21);
            this.textBoxMoney.TabIndex = 16;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(685, 54);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "My Money in Hand $";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "$";
            // 
            // buttonSearchByPrice
            // 
            this.buttonSearchByPrice.Location = new System.Drawing.Point(162, 134);
            this.buttonSearchByPrice.Name = "buttonSearchByPrice";
            this.buttonSearchByPrice.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByPrice.TabIndex = 22;
            this.buttonSearchByPrice.Text = "Search";
            this.buttonSearchByPrice.UseVisualStyleBackColor = true;
            this.buttonSearchByPrice.Click += new System.EventHandler(this.buttonSearchByPrice_Click);
            // 
            // buttonDisplayAllShoes
            // 
            this.buttonDisplayAllShoes.Location = new System.Drawing.Point(32, 204);
            this.buttonDisplayAllShoes.Name = "buttonDisplayAllShoes";
            this.buttonDisplayAllShoes.Size = new System.Drawing.Size(205, 23);
            this.buttonDisplayAllShoes.TabIndex = 23;
            this.buttonDisplayAllShoes.Text = "Display All Shoes";
            this.buttonDisplayAllShoes.UseVisualStyleBackColor = true;
            this.buttonDisplayAllShoes.Click += new System.EventHandler(this.buttonDisplayAllShoes_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDisplayAllShoes);
            this.Controls.Add(this.buttonSearchByPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.textBoxPriceHigh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchByName);
            this.Controls.Add(this.textBoxPriceLow);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBoxShoe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Shoe Shop";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShoe)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxShoe;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSave;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPriceLow;
        private System.Windows.Forms.Button buttonSearchByName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPriceHigh;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonSearchByPrice;
        private System.Windows.Forms.Button buttonDisplayAllShoes;
    }
}