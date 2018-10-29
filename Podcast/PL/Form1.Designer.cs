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
            this.components = new System.ComponentModel.Container();
            this.lvPodcast = new System.Windows.Forms.ListView();
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddPodcast = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.cbUpdate = new System.Windows.Forms.ComboBox();
            this.cbChangeCategory = new System.Windows.Forms.ComboBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnSavePodChanges = new System.Windows.Forms.Button();
            this.btnDeletePodcast = new System.Windows.Forms.Button();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbCategories = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnSaveCategoryChanges = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.lvPodcastEpisodes = new System.Windows.Forms.ListView();
            this.lblPodcastEpisode = new System.Windows.Forms.Label();
            this.tbEpisodeSummary = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lvPodcast
            // 
            this.lvPodcast.BackColor = System.Drawing.Color.Honeydew;
            this.lvPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.lvPodcast.FullRowSelect = true;
            this.lvPodcast.Location = new System.Drawing.Point(13, 14);
            this.lvPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvPodcast.MultiSelect = false;
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(502, 192);
            this.lvPodcast.TabIndex = 0;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
            this.lvPodcast.SelectedIndexChanged += new System.EventHandler(this.lvPodcast_SelectedIndexChanged);
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
            this.Kategori.Width = 177;
            // 
            // btnAddPodcast
            // 
            this.btnAddPodcast.Location = new System.Drawing.Point(98, 250);
            this.btnAddPodcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(63, 21);
            this.btnAddPodcast.TabIndex = 1;
            this.btnAddPodcast.Text = "Ny";
            this.btnAddPodcast.UseVisualStyleBackColor = true;
            this.btnAddPodcast.Click += new System.EventHandler(this.btnAddPodcast_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(11, 220);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(68, 20);
            this.tbUrl.TabIndex = 2;
            // 
            // cbUpdate
            // 
            this.cbUpdate.FormattingEnabled = true;
            this.cbUpdate.Items.AddRange(new object[] {
            "5 Minutes",
            "10 Minutes",
            "15 Minutes"});
            this.cbUpdate.Location = new System.Drawing.Point(147, 336);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(103, 21);
            this.cbUpdate.TabIndex = 3;
            // 
            // cbChangeCategory
            // 
            this.cbChangeCategory.FormattingEnabled = true;
            this.cbChangeCategory.Location = new System.Drawing.Point(220, 218);
            this.cbChangeCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbChangeCategory.Name = "cbChangeCategory";
            this.cbChangeCategory.Size = new System.Drawing.Size(82, 21);
            this.cbChangeCategory.TabIndex = 4;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(8, 205);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "URL:";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(95, 203);
            this.lblUpdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(108, 13);
            this.lblUpdate.TabIndex = 6;
            this.lblUpdate.Text = "Updateringsfrekvens:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(217, 203);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Kategori:";
            // 
            // btnSavePodChanges
            // 
            this.btnSavePodChanges.Location = new System.Drawing.Point(176, 250);
            this.btnSavePodChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSavePodChanges.Name = "btnSavePodChanges";
            this.btnSavePodChanges.Size = new System.Drawing.Size(50, 21);
            this.btnSavePodChanges.TabIndex = 8;
            this.btnSavePodChanges.Text = "Spara";
            this.btnSavePodChanges.UseVisualStyleBackColor = true;
            this.btnSavePodChanges.Click += new System.EventHandler(this.btnSavePodChanges_Click);
            // 
            // btnDeletePodcast
            // 
            this.btnDeletePodcast.Location = new System.Drawing.Point(251, 250);
            this.btnDeletePodcast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletePodcast.Name = "btnDeletePodcast";
            this.btnDeletePodcast.Size = new System.Drawing.Size(50, 21);
            this.btnDeletePodcast.TabIndex = 9;
            this.btnDeletePodcast.Text = "Ta Bort";
            this.btnDeletePodcast.UseVisualStyleBackColor = true;
            this.btnDeletePodcast.Click += new System.EventHandler(this.btnDeletePodcast_Click);
            // 
            // lvCategory
            // 
            this.lvCategory.BackColor = System.Drawing.Color.Honeydew;
            this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvCategory.Location = new System.Drawing.Point(599, 9);
            this.lvCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(280, 144);
            this.lvCategory.TabIndex = 11;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            this.lvCategory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kategorier";
            this.columnHeader1.Width = 411;
            // 
            // tbCategories
            // 
            this.tbCategories.Location = new System.Drawing.Point(599, 158);
            this.tbCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCategories.Name = "tbCategories";
            this.tbCategories.Size = new System.Drawing.Size(280, 20);
            this.tbCategories.TabIndex = 12;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(599, 179);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(81, 21);
            this.btnAddCategory.TabIndex = 13;
            this.btnAddCategory.Text = "Ny";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnSaveCategoryChanges
            // 
            this.btnSaveCategoryChanges.Location = new System.Drawing.Point(696, 179);
            this.btnSaveCategoryChanges.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveCategoryChanges.Name = "btnSaveCategoryChanges";
            this.btnSaveCategoryChanges.Size = new System.Drawing.Size(86, 21);
            this.btnSaveCategoryChanges.TabIndex = 14;
            this.btnSaveCategoryChanges.Text = "Spara";
            this.btnSaveCategoryChanges.UseVisualStyleBackColor = true;
            this.btnSaveCategoryChanges.Click += new System.EventHandler(this.btnSaveCategoryChanges_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(801, 179);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(79, 21);
            this.btnDeleteCategory.TabIndex = 15;
            this.btnDeleteCategory.Text = "Ta Bort";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Location = new System.Drawing.Point(8, 472);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(204, 13);
            this.lblPodcast.TabIndex = 16;
            this.lblPodcast.Text = "Label för att visa vilken pod man markerat";
            // 
            // lvPodcastEpisodes
            // 
            this.lvPodcastEpisodes.BackColor = System.Drawing.Color.Honeydew;
            this.lvPodcastEpisodes.Location = new System.Drawing.Point(12, 495);
            this.lvPodcastEpisodes.Name = "lvPodcastEpisodes";
            this.lvPodcastEpisodes.Size = new System.Drawing.Size(752, 145);
            this.lvPodcastEpisodes.TabIndex = 17;
            this.lvPodcastEpisodes.UseCompatibleStateImageBehavior = false;
            this.lvPodcastEpisodes.View = System.Windows.Forms.View.List;
            this.lvPodcastEpisodes.SelectedIndexChanged += new System.EventHandler(this.lvPodcastEpisodes_SelectedIndexChanged);
            // 
            // lblPodcastEpisode
            // 
            this.lblPodcastEpisode.AutoSize = true;
            this.lblPodcastEpisode.Location = new System.Drawing.Point(809, 382);
            this.lblPodcastEpisode.Name = "lblPodcastEpisode";
            this.lblPodcastEpisode.Size = new System.Drawing.Size(232, 13);
            this.lblPodcastEpisode.TabIndex = 18;
            this.lblPodcastEpisode.Text = "Label för att visa vilket podavsnitt man markerat";
            // 
            // tbEpisodeSummary
            // 
            this.tbEpisodeSummary.BackColor = System.Drawing.Color.Honeydew;
            this.tbEpisodeSummary.Location = new System.Drawing.Point(813, 405);
            this.tbEpisodeSummary.Multiline = true;
            this.tbEpisodeSummary.Name = "tbEpisodeSummary";
            this.tbEpisodeSummary.ReadOnly = true;
            this.tbEpisodeSummary.Size = new System.Drawing.Size(501, 235);
            this.tbEpisodeSummary.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1326, 651);
            this.Controls.Add(this.tbEpisodeSummary);
            this.Controls.Add(this.lblPodcastEpisode);
            this.Controls.Add(this.lvPodcastEpisodes);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSaveCategoryChanges);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.tbCategories);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.btnDeletePodcast);
            this.Controls.Add(this.btnSavePodChanges);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.cbChangeCategory);
            this.Controls.Add(this.cbUpdate);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnAddPodcast);
            this.Controls.Add(this.lvPodcast);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "RSS PODCAST FEEDREADER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPodcast;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.Button btnAddPodcast;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ComboBox cbUpdate;
        private System.Windows.Forms.ComboBox cbChangeCategory;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnSavePodChanges;
        private System.Windows.Forms.Button btnDeletePodcast;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.TextBox tbCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnSaveCategoryChanges;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.ListView lvPodcastEpisodes;
        private System.Windows.Forms.Label lblPodcastEpisode;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.TextBox tbEpisodeSummary;
        private System.Windows.Forms.Timer timer1;
    }
}

