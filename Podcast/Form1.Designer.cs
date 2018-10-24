namespace Podcast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvFeed = new System.Windows.Forms.ListView();
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbURL = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lbUpdateFrequency = new System.Windows.Forms.Label();
            this.cbUpdateFrequency = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lbAvsnitt = new System.Windows.Forms.Label();
            this.lvEpisodes = new System.Windows.Forms.ListView();
            this.btSave = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.tbCreateCategory = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.btSaveCategory = new System.Windows.Forms.Button();
            this.btRemove2 = new System.Windows.Forms.Button();
            this.lbPodcastInfo = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvFeed
            // 
            this.lvFeed.BackColor = System.Drawing.Color.BurlyWood;
            this.lvFeed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.lvFeed.Location = new System.Drawing.Point(13, 24);
            this.lvFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvFeed.Name = "lvFeed";
            this.lvFeed.Size = new System.Drawing.Size(499, 242);
            this.lvFeed.TabIndex = 0;
            this.lvFeed.UseCompatibleStateImageBehavior = false;
            this.lvFeed.View = System.Windows.Forms.View.Details;
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            this.Avsnitt.Width = 106;
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 156;
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            this.Frekvens.Width = 156;
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(208, 356);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(12, 281);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(44, 17);
            this.lbURL.TabIndex = 2;
            this.lbURL.Text = "URL: ";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(12, 301);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(216, 22);
            this.tbURL.TabIndex = 3;
            this.tbURL.Text = "http://";
            // 
            // lbUpdateFrequency
            // 
            this.lbUpdateFrequency.AutoSize = true;
            this.lbUpdateFrequency.Location = new System.Drawing.Point(241, 281);
            this.lbUpdateFrequency.Name = "lbUpdateFrequency";
            this.lbUpdateFrequency.Size = new System.Drawing.Size(151, 17);
            this.lbUpdateFrequency.TabIndex = 4;
            this.lbUpdateFrequency.Text = "Uppdateringsfrekvens:";
            // 
            // cbUpdateFrequency
            // 
            this.cbUpdateFrequency.FormattingEnabled = true;
            this.cbUpdateFrequency.Items.AddRange(new object[] {
            "Var femte minut",
            "Var tionde minut",
            "Var femtonde minut"});
            this.cbUpdateFrequency.Location = new System.Drawing.Point(244, 299);
            this.cbUpdateFrequency.Name = "cbUpdateFrequency";
            this.cbUpdateFrequency.Size = new System.Drawing.Size(148, 24);
            this.cbUpdateFrequency.TabIndex = 5;
            this.cbUpdateFrequency.SelectedIndexChanged += new System.EventHandler(this.cbUpdateFrequency_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(411, 281);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(65, 17);
            this.lbCategory.TabIndex = 6;
            this.lbCategory.Text = "Kategori:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "Humor",
            "Historia"});
            this.cbCategory.Location = new System.Drawing.Point(414, 299);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(98, 24);
            this.cbCategory.TabIndex = 7;
            // 
            // lbAvsnitt
            // 
            this.lbAvsnitt.AutoSize = true;
            this.lbAvsnitt.Location = new System.Drawing.Point(12, 426);
            this.lbAvsnitt.Name = "lbAvsnitt";
            this.lbAvsnitt.Size = new System.Drawing.Size(54, 17);
            this.lbAvsnitt.TabIndex = 8;
            this.lbAvsnitt.Text = "Avsnitt:";
            // 
            // lvEpisodes
            // 
            this.lvEpisodes.Location = new System.Drawing.Point(12, 465);
            this.lvEpisodes.Name = "lvEpisodes";
            this.lvEpisodes.Size = new System.Drawing.Size(500, 181);
            this.lvEpisodes.TabIndex = 9;
            this.lvEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(315, 356);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(96, 28);
            this.btSave.TabIndex = 10;
            this.btSave.Text = "Spara";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(418, 356);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(94, 28);
            this.btRemove.TabIndex = 11;
            this.btRemove.Text = "Ta bort...";
            this.btRemove.UseVisualStyleBackColor = true;
            // 
            // lvCategory
            // 
            this.lvCategory.Location = new System.Drawing.Point(674, 24);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(365, 242);
            this.lvCategory.TabIndex = 12;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            // 
            // tbCreateCategory
            // 
            this.tbCreateCategory.Location = new System.Drawing.Point(674, 281);
            this.tbCreateCategory.Name = "tbCreateCategory";
            this.tbCreateCategory.Size = new System.Drawing.Size(354, 22);
            this.tbCreateCategory.TabIndex = 13;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(679, 323);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(75, 23);
            this.btCreate.TabIndex = 14;
            this.btCreate.Text = "Ny";
            this.btCreate.UseVisualStyleBackColor = true;
            // 
            // btSaveCategory
            // 
            this.btSaveCategory.Location = new System.Drawing.Point(774, 323);
            this.btSaveCategory.Name = "btSaveCategory";
            this.btSaveCategory.Size = new System.Drawing.Size(75, 23);
            this.btSaveCategory.TabIndex = 15;
            this.btSaveCategory.Text = "Spara";
            this.btSaveCategory.UseVisualStyleBackColor = true;
            // 
            // btRemove2
            // 
            this.btRemove2.Location = new System.Drawing.Point(872, 324);
            this.btRemove2.Name = "btRemove2";
            this.btRemove2.Size = new System.Drawing.Size(75, 23);
            this.btRemove2.TabIndex = 16;
            this.btRemove2.Text = "Ta bort...";
            this.btRemove2.UseVisualStyleBackColor = true;
            // 
            // lbPodcastInfo
            // 
            this.lbPodcastInfo.AutoSize = true;
            this.lbPodcastInfo.Location = new System.Drawing.Point(688, 367);
            this.lbPodcastInfo.Name = "lbPodcastInfo";
            this.lbPodcastInfo.Size = new System.Drawing.Size(149, 17);
            this.lbPodcastInfo.TabIndex = 17;
            this.lbPodcastInfo.Text = "Namn på vald podcast";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Location = new System.Drawing.Point(688, 405);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(184, 17);
            this.lbDescription.TabIndex = 18;
            this.lbDescription.Text = "Beskrivning av vald podcast";
            this.lbDescription.Click += new System.EventHandler(this.lbDescription_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1068, 703);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbPodcastInfo);
            this.Controls.Add(this.btRemove2);
            this.Controls.Add(this.btSaveCategory);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.tbCreateCategory);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lvEpisodes);
            this.Controls.Add(this.lbAvsnitt);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.cbUpdateFrequency);
            this.Controls.Add(this.lbUpdateFrequency);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvFeed);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFeed;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lbUpdateFrequency;
        private System.Windows.Forms.ComboBox cbUpdateFrequency;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lbAvsnitt;
        private System.Windows.Forms.ListView lvEpisodes;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.TextBox tbCreateCategory;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btSaveCategory;
        private System.Windows.Forms.Button btRemove2;
        private System.Windows.Forms.Label lbPodcastInfo;
        private System.Windows.Forms.Label lbDescription;
    }
}

