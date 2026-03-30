namespace MusicCollectionApp
{
    partial class MusicCollectionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.removeTrackButton = new System.Windows.Forms.Button();
            this.searchByArtistButton = new System.Windows.Forms.Button();
            this.sortByYearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 12);
            this.listView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(639, 368);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // addTrackButton
            // 
            this.addTrackButton.Location = new System.Drawing.Point(13, 394);
            this.addTrackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(133, 45);
            this.addTrackButton.TabIndex = 1;
            this.addTrackButton.Text = "Добавить трек";
            // 
            // removeTrackButton
            // 
            this.removeTrackButton.Location = new System.Drawing.Point(160, 394);
            this.removeTrackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeTrackButton.Name = "removeTrackButton";
            this.removeTrackButton.Size = new System.Drawing.Size(133, 45);
            this.removeTrackButton.TabIndex = 2;
            this.removeTrackButton.Text = "Удалить трек";
            // 
            // searchByArtistButton
            // 
            this.searchByArtistButton.Location = new System.Drawing.Point(307, 394);
            this.searchByArtistButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchByArtistButton.Name = "searchByArtistButton";
            this.searchByArtistButton.Size = new System.Drawing.Size(160, 45);
            this.searchByArtistButton.TabIndex = 3;
            this.searchByArtistButton.Text = "Поиск по исполнителю";
            // 
            // sortByYearButton
            // 
            this.sortByYearButton.Location = new System.Drawing.Point(480, 394);
            this.sortByYearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sortByYearButton.Name = "sortByYearButton";
            this.sortByYearButton.Size = new System.Drawing.Size(160, 45);
            this.sortByYearButton.TabIndex = 4;
            this.sortByYearButton.Text = "Сортировать по году";
            // 
            // MusicCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 492);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.addTrackButton);
            this.Controls.Add(this.removeTrackButton);
            this.Controls.Add(this.searchByArtistButton);
            this.Controls.Add(this.sortByYearButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusicCollectionForm";
            this.Text = "Управление музыкальной коллекцией";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.Button removeTrackButton;
        private System.Windows.Forms.Button searchByArtistButton;
        private System.Windows.Forms.Button sortByYearButton;
    }
}
