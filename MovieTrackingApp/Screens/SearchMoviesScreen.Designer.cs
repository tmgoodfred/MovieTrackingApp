namespace MovieTrackingApp.Screens
{
    partial class SearchMoviesScreen
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
            searchedMoviesDataGrid = new DataGridView();
            backBtn = new Button();
            searchTxt = new TextBox();
            searchBtn = new Button();
            addToWatchlistBtn = new Button();
            viewDetailsBtn = new Button();
            addToWatchedBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)searchedMoviesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // searchedMoviesDataGrid
            // 
            searchedMoviesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            searchedMoviesDataGrid.Location = new Point(51, 46);
            searchedMoviesDataGrid.Name = "searchedMoviesDataGrid";
            searchedMoviesDataGrid.Size = new Size(1632, 763);
            searchedMoviesDataGrid.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(51, 826);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(75, 23);
            backBtn.TabIndex = 1;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(1275, 12);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(327, 23);
            searchTxt.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(1608, 12);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // addToWatchlistBtn
            // 
            addToWatchlistBtn.Location = new Point(693, 826);
            addToWatchlistBtn.Name = "addToWatchlistBtn";
            addToWatchlistBtn.Size = new Size(105, 23);
            addToWatchlistBtn.TabIndex = 4;
            addToWatchlistBtn.Text = "Add To Watchlist";
            addToWatchlistBtn.UseVisualStyleBackColor = true;
            addToWatchlistBtn.Click += addToWatchlistBtn_Click;
            // 
            // viewDetailsBtn
            // 
            viewDetailsBtn.Location = new Point(844, 826);
            viewDetailsBtn.Name = "viewDetailsBtn";
            viewDetailsBtn.Size = new Size(85, 23);
            viewDetailsBtn.TabIndex = 5;
            viewDetailsBtn.Text = "View Details";
            viewDetailsBtn.UseVisualStyleBackColor = true;
            viewDetailsBtn.Click += viewDetailsBtn_Click;
            // 
            // addToWatchedBtn
            // 
            addToWatchedBtn.Location = new Point(967, 826);
            addToWatchedBtn.Name = "addToWatchedBtn";
            addToWatchedBtn.Size = new Size(106, 23);
            addToWatchedBtn.TabIndex = 6;
            addToWatchedBtn.Text = "Add To Watched";
            addToWatchedBtn.UseVisualStyleBackColor = true;
            addToWatchedBtn.Click += addToWatchedBtn_Click;
            // 
            // SearchMoviesScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 861);
            Controls.Add(addToWatchedBtn);
            Controls.Add(viewDetailsBtn);
            Controls.Add(addToWatchlistBtn);
            Controls.Add(searchBtn);
            Controls.Add(searchTxt);
            Controls.Add(backBtn);
            Controls.Add(searchedMoviesDataGrid);
            Name = "SearchMoviesScreen";
            Text = "Search";
            ((System.ComponentModel.ISupportInitialize)searchedMoviesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView searchedMoviesDataGrid;
        private Button backBtn;
        private TextBox searchTxt;
        private Button searchBtn;
        private Button addToWatchlistBtn;
        private Button viewDetailsBtn;
        private Button addToWatchedBtn;
    }
}