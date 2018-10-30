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
            this.lblCategories = new System.Windows.Forms.Label();
            this.lvCategory = new System.Windows.Forms.ListView();
            this.tbCategories = new System.Windows.Forms.TextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnSaveCategoryChanges = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.lblPodcast = new System.Windows.Forms.Label();
            this.lvlPodcastEpisodes = new System.Windows.Forms.ListView();
            this.lblPodcastEpisode = new System.Windows.Forms.Label();
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
            this.lvPodcast.Location = new System.Drawing.Point(12, 11);
            this.lvPodcast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(668, 236);
            this.lvPodcast.TabIndex = 0;
            this.lvPodcast.UseCompatibleStateImageBehavior = false;
            this.lvPodcast.View = System.Windows.Forms.View.Details;
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
            this.btnAddPodcast.Location = new System.Drawing.Point(131, 308);
            this.btnAddPodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPodcast.Name = "btnAddPodcast";
            this.btnAddPodcast.Size = new System.Drawing.Size(84, 26);
            this.btnAddPodcast.TabIndex = 1;
            this.btnAddPodcast.Text = "Ny";
            this.btnAddPodcast.UseVisualStyleBackColor = true;
            this.btnAddPodcast.Click += new System.EventHandler(this.btnAddPodcast_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(14, 270);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(89, 22);
            this.tbUrl.TabIndex = 2;
            // 
            // cbUpdate
            // 
            this.cbUpdate.FormattingEnabled = true;
            this.cbUpdate.Items.AddRange(new object[] {
            "Var femte minut",
            "Var tionde minut"});
            this.cbUpdate.Location = new System.Drawing.Point(131, 269);
            this.cbUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(136, 24);
            this.cbUpdate.TabIndex = 3;
            // 
            // cbChangeCategory
            // 
            this.cbChangeCategory.FormattingEnabled = true;
            this.cbChangeCategory.Items.AddRange(new object[] {
            "Historia",
            "Humor"});
            this.cbChangeCategory.Location = new System.Drawing.Point(293, 269);
            this.cbChangeCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChangeCategory.Name = "cbChangeCategory";
            this.cbChangeCategory.Size = new System.Drawing.Size(108, 24);
            this.cbChangeCategory.TabIndex = 4;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(11, 252);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(40, 17);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "URL:";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(127, 250);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(143, 17);
            this.lblUpdate.TabIndex = 6;
            this.lblUpdate.Text = "Updateringsfrekvens:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(290, 250);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(65, 17);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Kategori:";
            // 
            // btnSavePodChanges
            // 
            this.btnSavePodChanges.Location = new System.Drawing.Point(235, 308);
            this.btnSavePodChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePodChanges.Name = "btnSavePodChanges";
            this.btnSavePodChanges.Size = new System.Drawing.Size(67, 26);
            this.btnSavePodChanges.TabIndex = 8;
            this.btnSavePodChanges.Text = "Spara";
            this.btnSavePodChanges.UseVisualStyleBackColor = true;
            // 
            // btnDeletePodcast
            // 
            this.btnDeletePodcast.Location = new System.Drawing.Point(334, 308);
            this.btnDeletePodcast.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletePodcast.Name = "btnDeletePodcast";
            this.btnDeletePodcast.Size = new System.Drawing.Size(67, 26);
            this.btnDeletePodcast.TabIndex = 9;
            this.btnDeletePodcast.Text = "Ta Bort";
            this.btnDeletePodcast.UseVisualStyleBackColor = true;
            // 
            // lblCategories
            // 
            this.lblCategories.AutoSize = true;
            this.lblCategories.Location = new System.Drawing.Point(795, 11);
            this.lblCategories.Name = "lblCategories";
            this.lblCategories.Size = new System.Drawing.Size(74, 17);
            this.lblCategories.TabIndex = 10;
            this.lblCategories.Text = "Kategorier";
            // 
            // lvCategory
            // 
            this.lvCategory.BackColor = System.Drawing.Color.Honeydew;
            this.lvCategory.Location = new System.Drawing.Point(798, 30);
            this.lvCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvCategory.Name = "lvCategory";
            this.lvCategory.Size = new System.Drawing.Size(372, 158);
            this.lvCategory.TabIndex = 11;
            this.lvCategory.UseCompatibleStateImageBehavior = false;
            // 
            // tbCategories
            // 
            this.tbCategories.Location = new System.Drawing.Point(798, 194);
            this.tbCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCategories.Name = "tbCategories";
            this.tbCategories.Size = new System.Drawing.Size(372, 22);
            this.tbCategories.TabIndex = 12;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(798, 221);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(108, 26);
            this.btnAddCategory.TabIndex = 13;
            this.btnAddCategory.Text = "Ny";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // btnSaveCategoryChanges
            // 
            this.btnSaveCategoryChanges.Location = new System.Drawing.Point(928, 221);
            this.btnSaveCategoryChanges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveCategoryChanges.Name = "btnSaveCategoryChanges";
            this.btnSaveCategoryChanges.Size = new System.Drawing.Size(115, 26);
            this.btnSaveCategoryChanges.TabIndex = 14;
            this.btnSaveCategoryChanges.Text = "Spara";
            this.btnSaveCategoryChanges.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(1068, 221);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(105, 26);
            this.btnDeleteCategory.TabIndex = 15;
            this.btnDeleteCategory.Text = "Ta Bort";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // lblPodcast
            // 
            this.lblPodcast.AutoSize = true;
            this.lblPodcast.Location = new System.Drawing.Point(11, 368);
            this.lblPodcast.Name = "lblPodcast";
            this.lblPodcast.Size = new System.Drawing.Size(272, 17);
            this.lblPodcast.TabIndex = 16;
            this.lblPodcast.Text = "Label för att visa vilken pod man markerat";
            // 
            // lvlPodcastEpisodes
            // 
            this.lvlPodcastEpisodes.BackColor = System.Drawing.Color.Honeydew;
            this.lvlPodcastEpisodes.Location = new System.Drawing.Point(11, 396);
            this.lvlPodcastEpisodes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvlPodcastEpisodes.Name = "lvlPodcastEpisodes";
            this.lvlPodcastEpisodes.Size = new System.Drawing.Size(669, 117);
            this.lvlPodcastEpisodes.TabIndex = 17;
            this.lvlPodcastEpisodes.UseCompatibleStateImageBehavior = false;
            // 
            // lblPodcastEpisode
            // 
            this.lblPodcastEpisode.AutoSize = true;
            this.lblPodcastEpisode.Location = new System.Drawing.Point(795, 295);
            this.lblPodcastEpisode.Name = "lblPodcastEpisode";
            this.lblPodcastEpisode.Size = new System.Drawing.Size(309, 17);
            this.lblPodcastEpisode.TabIndex = 18;
            this.lblPodcastEpisode.Text = "Label för att visa vilket podavsnitt man markerat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1244, 524);
            this.Controls.Add(this.lblPodcastEpisode);
            this.Controls.Add(this.lvlPodcastEpisodes);
            this.Controls.Add(this.lblPodcast);
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnSaveCategoryChanges);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.tbCategories);
            this.Controls.Add(this.lvCategory);
            this.Controls.Add(this.lblCategories);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lblCategories;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.TextBox tbCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnSaveCategoryChanges;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Label lblPodcast;
        private System.Windows.Forms.ListView lvlPodcastEpisodes;
        private System.Windows.Forms.Label lblPodcastEpisode;
    }
}

