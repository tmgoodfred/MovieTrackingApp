namespace MovieTrackingApp.Screens
{
    partial class MainScreen
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
            tabController = new TabControl();
            watchlistTab = new TabPage();
            watchedTab = new TabPage();
            searchBtn = new Button();
            searchTxt = new TextBox();
            label1 = new Label();
            logoutBtn = new Button();
            watchlistDataGrid = new DataGridView();
            watchedDataGrid = new DataGridView();
            tabController.SuspendLayout();
            watchlistTab.SuspendLayout();
            watchedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)watchlistDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)watchedDataGrid).BeginInit();
            SuspendLayout();
            // 
            // tabController
            // 
            tabController.Controls.Add(watchlistTab);
            tabController.Controls.Add(watchedTab);
            tabController.Location = new Point(41, 51);
            tabController.Name = "tabController";
            tabController.SelectedIndex = 0;
            tabController.Size = new Size(1662, 777);
            tabController.TabIndex = 0;
            // 
            // watchlistTab
            // 
            watchlistTab.Controls.Add(watchlistDataGrid);
            watchlistTab.Location = new Point(4, 24);
            watchlistTab.Name = "watchlistTab";
            watchlistTab.Padding = new Padding(3);
            watchlistTab.Size = new Size(1654, 749);
            watchlistTab.TabIndex = 0;
            watchlistTab.Text = "Watchlist";
            watchlistTab.UseVisualStyleBackColor = true;
            // 
            // watchedTab
            // 
            watchedTab.Controls.Add(watchedDataGrid);
            watchedTab.Location = new Point(4, 24);
            watchedTab.Name = "watchedTab";
            watchedTab.Padding = new Padding(3);
            watchedTab.Size = new Size(1654, 749);
            watchedTab.TabIndex = 1;
            watchedTab.Text = "Watched";
            watchedTab.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(1624, 22);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 1;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchTxt
            // 
            searchTxt.Location = new Point(1280, 22);
            searchTxt.Name = "searchTxt";
            searchTxt.Size = new Size(338, 23);
            searchTxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 22);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 3;
            label1.Text = "Welcome in";
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(41, 830);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(75, 23);
            logoutBtn.TabIndex = 4;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // watchlistDataGrid
            // 
            watchlistDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            watchlistDataGrid.Location = new Point(6, 6);
            watchlistDataGrid.Name = "watchlistDataGrid";
            watchlistDataGrid.Size = new Size(1642, 737);
            watchlistDataGrid.TabIndex = 0;
            // 
            // watchedDataGrid
            // 
            watchedDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            watchedDataGrid.Location = new Point(6, 6);
            watchedDataGrid.Name = "watchedDataGrid";
            watchedDataGrid.Size = new Size(1642, 737);
            watchedDataGrid.TabIndex = 0;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 861);
            Controls.Add(logoutBtn);
            Controls.Add(label1);
            Controls.Add(searchTxt);
            Controls.Add(searchBtn);
            Controls.Add(tabController);
            Name = "MainScreen";
            Text = "MainScreen";
            tabController.ResumeLayout(false);
            watchlistTab.ResumeLayout(false);
            watchedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)watchlistDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)watchedDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabController;
        private TabPage watchlistTab;
        private TabPage watchedTab;
        private Button searchBtn;
        private TextBox searchTxt;
        private Label label1;
        private Button logoutBtn;
        private DataGridView watchlistDataGrid;
        private DataGridView watchedDataGrid;
    }
}