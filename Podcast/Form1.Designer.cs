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
            this.SuspendLayout();
            // 
            // lvPodcast
            // 
            this.lvPodcast.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Avsnitt,
            this.Namn,
            this.Frekvens,
            this.Kategori});
            this.lvPodcast.Location = new System.Drawing.Point(89, 28);
            this.lvPodcast.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvPodcast.Name = "lvPodcast";
            this.lvPodcast.Size = new System.Drawing.Size(658, 315);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 587);
            this.Controls.Add(this.lvPodcast);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPodcast;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Kategori;
    }
}

