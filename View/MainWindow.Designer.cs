namespace FolderScanner.View
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InformationTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SpaceUsedLabel = new System.Windows.Forms.Label();
            this.HomeDirectoryLabelValue = new System.Windows.Forms.Label();
            this.HomeDirectoryLabel = new System.Windows.Forms.Label();
            this.CaptionLabelValue = new System.Windows.Forms.Label();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.NameLabelValue = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LockoutLabelValue = new System.Windows.Forms.Label();
            this.LockoutLabel = new System.Windows.Forms.Label();
            this.DisabledLabelValue = new System.Windows.Forms.Label();
            this.DisabledLabel = new System.Windows.Forms.Label();
            this.SizeUsageLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SpaceUsedLabelValue = new System.Windows.Forms.Label();
            this.ConfigSizeBtn = new System.Windows.Forms.Button();
            this.ItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UsersSelectionLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsList = new System.Windows.Forms.ComboBox();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.BriefReportBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.CurrentStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PathStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PathStripLabelValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainLayout.SuspendLayout();
            this.InformationTableLayout.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
            this.GroupBoxLayout.SuspendLayout();
            this.SizeUsageLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.ItemsDataGridView)).BeginInit();
            this.ControlsLayout.SuspendLayout();
            this.UsersSelectionLayout.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.InformationTableLayout, 0, 1);
            this.MainLayout.Controls.Add(this.ControlsLayout, 0, 0);
            this.MainLayout.Controls.Add(this.statusStrip1, 0, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.MainLayout.Size = new System.Drawing.Size(844, 411);
            this.MainLayout.TabIndex = 0;
            // 
            // InformationTableLayout
            // 
            this.InformationTableLayout.ColumnCount = 2;
            this.InformationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.InformationTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.InformationTableLayout.Controls.Add(this.InformationGroupBox, 1, 0);
            this.InformationTableLayout.Controls.Add(this.ItemsDataGridView, 0, 0);
            this.InformationTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationTableLayout.Location = new System.Drawing.Point(3, 61);
            this.InformationTableLayout.Name = "InformationTableLayout";
            this.InformationTableLayout.Padding = new System.Windows.Forms.Padding(2);
            this.InformationTableLayout.RowCount = 1;
            this.InformationTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationTableLayout.Size = new System.Drawing.Size(838, 323);
            this.InformationTableLayout.TabIndex = 0;
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.GroupBoxLayout);
            this.InformationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationGroupBox.Location = new System.Drawing.Point(547, 5);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.InformationGroupBox.Size = new System.Drawing.Size(286, 313);
            this.InformationGroupBox.TabIndex = 1;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Information box";
            // 
            // GroupBoxLayout
            // 
            this.GroupBoxLayout.ColumnCount = 2;
            this.GroupBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.74257F));
            this.GroupBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.25743F));
            this.GroupBoxLayout.Controls.Add(this.SpaceUsedLabel, 0, 5);
            this.GroupBoxLayout.Controls.Add(this.HomeDirectoryLabelValue, 1, 4);
            this.GroupBoxLayout.Controls.Add(this.HomeDirectoryLabel, 0, 4);
            this.GroupBoxLayout.Controls.Add(this.CaptionLabelValue, 1, 3);
            this.GroupBoxLayout.Controls.Add(this.CaptionLabel, 0, 3);
            this.GroupBoxLayout.Controls.Add(this.NameLabelValue, 1, 2);
            this.GroupBoxLayout.Controls.Add(this.NameLabel, 0, 2);
            this.GroupBoxLayout.Controls.Add(this.LockoutLabelValue, 1, 1);
            this.GroupBoxLayout.Controls.Add(this.LockoutLabel, 0, 1);
            this.GroupBoxLayout.Controls.Add(this.DisabledLabelValue, 1, 0);
            this.GroupBoxLayout.Controls.Add(this.DisabledLabel, 0, 0);
            this.GroupBoxLayout.Controls.Add(this.SizeUsageLayout, 1, 5);
            this.GroupBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBoxLayout.Location = new System.Drawing.Point(8, 23);
            this.GroupBoxLayout.Name = "GroupBoxLayout";
            this.GroupBoxLayout.RowCount = 6;
            this.GroupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.GroupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.GroupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.GroupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.GroupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.GroupBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.GroupBoxLayout.Size = new System.Drawing.Size(270, 282);
            this.GroupBoxLayout.TabIndex = 0;
            // 
            // SpaceUsedLabel
            // 
            this.SpaceUsedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceUsedLabel.Location = new System.Drawing.Point(3, 230);
            this.SpaceUsedLabel.Name = "SpaceUsedLabel";
            this.SpaceUsedLabel.Size = new System.Drawing.Size(114, 52);
            this.SpaceUsedLabel.TabIndex = 13;
            this.SpaceUsedLabel.Text = "Space used";
            this.SpaceUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HomeDirectoryLabelValue
            // 
            this.HomeDirectoryLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeDirectoryLabelValue.Location = new System.Drawing.Point(123, 184);
            this.HomeDirectoryLabelValue.Name = "HomeDirectoryLabelValue";
            this.HomeDirectoryLabelValue.Size = new System.Drawing.Size(144, 46);
            this.HomeDirectoryLabelValue.TabIndex = 11;
            this.HomeDirectoryLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeDirectoryLabel
            // 
            this.HomeDirectoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeDirectoryLabel.Location = new System.Drawing.Point(3, 184);
            this.HomeDirectoryLabel.Name = "HomeDirectoryLabel";
            this.HomeDirectoryLabel.Size = new System.Drawing.Size(114, 46);
            this.HomeDirectoryLabel.TabIndex = 10;
            this.HomeDirectoryLabel.Text = "HomeDirectory";
            this.HomeDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CaptionLabelValue
            // 
            this.CaptionLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaptionLabelValue.Location = new System.Drawing.Point(123, 138);
            this.CaptionLabelValue.Name = "CaptionLabelValue";
            this.CaptionLabelValue.Size = new System.Drawing.Size(144, 46);
            this.CaptionLabelValue.TabIndex = 9;
            this.CaptionLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CaptionLabel.Location = new System.Drawing.Point(3, 138);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(114, 46);
            this.CaptionLabel.TabIndex = 8;
            this.CaptionLabel.Text = "Caption";
            this.CaptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameLabelValue
            // 
            this.NameLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabelValue.Location = new System.Drawing.Point(123, 92);
            this.NameLabelValue.Name = "NameLabelValue";
            this.NameLabelValue.Size = new System.Drawing.Size(144, 46);
            this.NameLabelValue.TabIndex = 7;
            this.NameLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameLabel
            // 
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Location = new System.Drawing.Point(3, 92);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(114, 46);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LockoutLabelValue
            // 
            this.LockoutLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LockoutLabelValue.Location = new System.Drawing.Point(123, 46);
            this.LockoutLabelValue.Name = "LockoutLabelValue";
            this.LockoutLabelValue.Size = new System.Drawing.Size(144, 46);
            this.LockoutLabelValue.TabIndex = 3;
            this.LockoutLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LockoutLabel
            // 
            this.LockoutLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LockoutLabel.Location = new System.Drawing.Point(3, 46);
            this.LockoutLabel.Name = "LockoutLabel";
            this.LockoutLabel.Size = new System.Drawing.Size(114, 46);
            this.LockoutLabel.TabIndex = 2;
            this.LockoutLabel.Text = "Lockout";
            this.LockoutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DisabledLabelValue
            // 
            this.DisabledLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisabledLabelValue.Location = new System.Drawing.Point(123, 0);
            this.DisabledLabelValue.Name = "DisabledLabelValue";
            this.DisabledLabelValue.Size = new System.Drawing.Size(144, 46);
            this.DisabledLabelValue.TabIndex = 1;
            this.DisabledLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DisabledLabel
            // 
            this.DisabledLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisabledLabel.Location = new System.Drawing.Point(3, 0);
            this.DisabledLabel.Name = "DisabledLabel";
            this.DisabledLabel.Size = new System.Drawing.Size(114, 46);
            this.DisabledLabel.TabIndex = 0;
            this.DisabledLabel.Text = "Disabled";
            this.DisabledLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SizeUsageLayout
            // 
            this.SizeUsageLayout.ColumnCount = 2;
            this.SizeUsageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.30864F));
            this.SizeUsageLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.69136F));
            this.SizeUsageLayout.Controls.Add(this.SpaceUsedLabelValue, 0, 0);
            this.SizeUsageLayout.Controls.Add(this.ConfigSizeBtn, 1, 0);
            this.SizeUsageLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SizeUsageLayout.Location = new System.Drawing.Point(121, 231);
            this.SizeUsageLayout.Margin = new System.Windows.Forms.Padding(1);
            this.SizeUsageLayout.Name = "SizeUsageLayout";
            this.SizeUsageLayout.RowCount = 1;
            this.SizeUsageLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SizeUsageLayout.Size = new System.Drawing.Size(148, 50);
            this.SizeUsageLayout.TabIndex = 14;
            // 
            // SpaceUsedLabelValue
            // 
            this.SpaceUsedLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceUsedLabelValue.Location = new System.Drawing.Point(3, 0);
            this.SpaceUsedLabelValue.Name = "SpaceUsedLabelValue";
            this.SpaceUsedLabelValue.Size = new System.Drawing.Size(105, 50);
            this.SpaceUsedLabelValue.TabIndex = 12;
            this.SpaceUsedLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfigSizeBtn
            // 
            this.ConfigSizeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigSizeBtn.Image = ((System.Drawing.Image) (resources.GetObject("ConfigSizeBtn.Image")));
            this.ConfigSizeBtn.Location = new System.Drawing.Point(114, 3);
            this.ConfigSizeBtn.Name = "ConfigSizeBtn";
            this.ConfigSizeBtn.Size = new System.Drawing.Size(31, 44);
            this.ConfigSizeBtn.TabIndex = 0;
            this.ConfigSizeBtn.UseVisualStyleBackColor = true;
            this.ConfigSizeBtn.Click += new System.EventHandler(this.ConfigSizeBtn_Click);
            // 
            // ItemsDataGridView
            // 
            this.ItemsDataGridView.AllowUserToAddRows = false;
            this.ItemsDataGridView.AllowUserToDeleteRows = false;
            this.ItemsDataGridView.AllowUserToOrderColumns = true;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.ItemName, this.ItemDate, this.ItemType, this.ItemSize});
            this.ItemsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsDataGridView.Location = new System.Drawing.Point(8, 8);
            this.ItemsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.ItemsDataGridView.MultiSelect = false;
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.ReadOnly = true;
            this.ItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsDataGridView.Size = new System.Drawing.Size(530, 307);
            this.ItemsDataGridView.TabIndex = 2;
            this.ItemsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsDataGridView_CellDoubleClick);
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemDate
            // 
            this.ItemDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDate.HeaderText = "Last Access Time";
            this.ItemDate.Name = "ItemDate";
            this.ItemDate.ReadOnly = true;
            // 
            // ItemType
            // 
            this.ItemType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemType.HeaderText = "Type";
            this.ItemType.Name = "ItemType";
            this.ItemType.ReadOnly = true;
            // 
            // ItemSize
            // 
            this.ItemSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemSize.HeaderText = "Size Bytes";
            this.ItemSize.Name = "ItemSize";
            this.ItemSize.ReadOnly = true;
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.ColumnCount = 3;
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.67532F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.37663F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81818F));
            this.ControlsLayout.Controls.Add(this.UsersSelectionLayout, 0, 0);
            this.ControlsLayout.Controls.Add(this.BriefReportBtn, 2, 0);
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(3, 3);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 1;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsLayout.Size = new System.Drawing.Size(838, 52);
            this.ControlsLayout.TabIndex = 1;
            // 
            // UsersSelectionLayout
            // 
            this.UsersSelectionLayout.ColumnCount = 2;
            this.UsersSelectionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UsersSelectionLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UsersSelectionLayout.Controls.Add(this.ItemsList, 1, 1);
            this.UsersSelectionLayout.Controls.Add(this.UsersLabel, 0, 1);
            this.UsersSelectionLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersSelectionLayout.Location = new System.Drawing.Point(3, 3);
            this.UsersSelectionLayout.Name = "UsersSelectionLayout";
            this.UsersSelectionLayout.RowCount = 2;
            this.UsersSelectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.UsersSelectionLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.UsersSelectionLayout.Size = new System.Drawing.Size(284, 46);
            this.UsersSelectionLayout.TabIndex = 1;
            // 
            // ItemsList
            // 
            this.ItemsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(145, 16);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(136, 24);
            this.ItemsList.TabIndex = 0;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // UsersLabel
            // 
            this.UsersLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersLabel.Font = new System.Drawing.Font("Liberation Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.UsersLabel.Location = new System.Drawing.Point(3, 13);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(136, 33);
            this.UsersLabel.TabIndex = 1;
            this.UsersLabel.Text = "Users and Folders";
            this.UsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BriefReportBtn
            // 
            this.BriefReportBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BriefReportBtn.Enabled = false;
            this.BriefReportBtn.Location = new System.Drawing.Point(573, 3);
            this.BriefReportBtn.Name = "BriefReportBtn";
            this.BriefReportBtn.Size = new System.Drawing.Size(262, 46);
            this.BriefReportBtn.TabIndex = 2;
            this.BriefReportBtn.Text = "Get brief report";
            this.BriefReportBtn.UseVisualStyleBackColor = true;
            this.BriefReportBtn.Click += new System.EventHandler(this.BriefReportBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.CurrentStripLabel, this.PathStripLabel, this.PathStripLabelValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CurrentStripLabel
            // 
            this.CurrentStripLabel.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CurrentStripLabel.Name = "CurrentStripLabel";
            this.CurrentStripLabel.Size = new System.Drawing.Size(49, 19);
            this.CurrentStripLabel.Text = "Current";
            // 
            // PathStripLabel
            // 
            this.PathStripLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides) (((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.PathStripLabel.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.PathStripLabel.Name = "PathStripLabel";
            this.PathStripLabel.Size = new System.Drawing.Size(38, 19);
            this.PathStripLabel.Text = "Path:";
            // 
            // PathStripLabelValue
            // 
            this.PathStripLabelValue.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides) (((System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.PathStripLabelValue.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.PathStripLabelValue.Name = "PathStripLabelValue";
            this.PathStripLabelValue.Size = new System.Drawing.Size(4, 19);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 411);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "MainWindow";
            this.Text = "Folders scaner";
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.InformationTableLayout.ResumeLayout(false);
            this.InformationGroupBox.ResumeLayout(false);
            this.GroupBoxLayout.ResumeLayout(false);
            this.SizeUsageLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.ItemsDataGridView)).EndInit();
            this.ControlsLayout.ResumeLayout(false);
            this.UsersSelectionLayout.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripStatusLabel PathStripLabel;
        private System.Windows.Forms.ToolStripStatusLabel PathStripLabelValue; 
        private System.Windows.Forms.ToolStripStatusLabel CurrentStripLabel;

        private System.Windows.Forms.StatusStrip statusStrip1;

        private System.Windows.Forms.Button ConfigSizeBtn;
        private System.Windows.Forms.Label SpaceUsedLabelValue;

        private System.Windows.Forms.TableLayoutPanel SizeUsageLayout;


        private System.Windows.Forms.TableLayoutPanel MainLayout;
        
        private System.Windows.Forms.Button BriefReportBtn;
        private System.Windows.Forms.TableLayoutPanel ControlsLayout;
        private System.Windows.Forms.TableLayoutPanel UsersSelectionLayout;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.ComboBox ItemsList;

        private System.Windows.Forms.TableLayoutPanel InformationTableLayout;
        private System.Windows.Forms.DataGridView ItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemSize;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        
        private System.Windows.Forms.TableLayoutPanel GroupBoxLayout;
        private System.Windows.Forms.Label SpaceUsedLabel;
        private System.Windows.Forms.Label HomeDirectoryLabelValue;
        private System.Windows.Forms.Label HomeDirectoryLabel;
        private System.Windows.Forms.Label CaptionLabelValue;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Label NameLabelValue;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LockoutLabelValue;
        private System.Windows.Forms.Label LockoutLabel;
        private System.Windows.Forms.Label DisabledLabelValue;
        private System.Windows.Forms.Label DisabledLabel;
        
        #endregion
    }
}