using System.ComponentModel;

namespace FolderScanner.View
{
    partial class ReportDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.InformationLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ControlsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedItemInfoBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SpaceUsedLabel = new System.Windows.Forms.Label();
            this.SpaceUsedLabelValue = new System.Windows.Forms.Label();
            this.PathLabelValue = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.ItemLabelValue = new System.Windows.Forms.Label();
            this.GeneralInformationBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UsersCountLabelValue = new System.Windows.Forms.Label();
            this.UsersCountLabel = new System.Windows.Forms.Label();
            this.GeneralSpaceUsedLabelValue = new System.Windows.Forms.Label();
            this.GeneralSpaceUsedLabel = new System.Windows.Forms.Label();
            this.MainLayout.SuspendLayout();
            this.InformationLayout.SuspendLayout();
            this.SelectedItemInfoBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.GeneralInformationBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 2;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.15789F));
            this.MainLayout.Controls.Add(this.ItemsListBox, 0, 0);
            this.MainLayout.Controls.Add(this.InformationLayout, 1, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 1;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Size = new System.Drawing.Size(461, 364);
            this.MainLayout.TabIndex = 0;
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(10, 10);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(10);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(149, 344);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // InformationLayout
            // 
            this.InformationLayout.ColumnCount = 1;
            this.InformationLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InformationLayout.Controls.Add(this.ControlsLayout, 0, 2);
            this.InformationLayout.Controls.Add(this.SelectedItemInfoBox, 0, 1);
            this.InformationLayout.Controls.Add(this.GeneralInformationBox, 0, 0);
            this.InformationLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationLayout.Location = new System.Drawing.Point(172, 3);
            this.InformationLayout.Name = "InformationLayout";
            this.InformationLayout.RowCount = 3;
            this.InformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.84357F));
            this.InformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.67598F));
            this.InformationLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.37717F));
            this.InformationLayout.Size = new System.Drawing.Size(286, 358);
            this.InformationLayout.TabIndex = 1;
            // 
            // ControlsLayout
            // 
            this.ControlsLayout.ColumnCount = 3;
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlsLayout.Location = new System.Drawing.Point(3, 302);
            this.ControlsLayout.Name = "ControlsLayout";
            this.ControlsLayout.RowCount = 1;
            this.ControlsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsLayout.Size = new System.Drawing.Size(280, 53);
            this.ControlsLayout.TabIndex = 2;
            // 
            // SelectedItemInfoBox
            // 
            this.SelectedItemInfoBox.Controls.Add(this.tableLayoutPanel2);
            this.SelectedItemInfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemInfoBox.Location = new System.Drawing.Point(3, 117);
            this.SelectedItemInfoBox.Name = "SelectedItemInfoBox";
            this.SelectedItemInfoBox.Size = new System.Drawing.Size(280, 179);
            this.SelectedItemInfoBox.TabIndex = 1;
            this.SelectedItemInfoBox.TabStop = false;
            this.SelectedItemInfoBox.Text = "Selected item information";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.PathLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SpaceUsedLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SpaceUsedLabelValue, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PathLabelValue, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ItemLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ItemLabelValue, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(274, 158);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // PathLabel
            // 
            this.PathLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathLabel.Location = new System.Drawing.Point(3, 104);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(130, 54);
            this.PathLabel.TabIndex = 4;
            this.PathLabel.Text = "Path";
            this.PathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpaceUsedLabel
            // 
            this.SpaceUsedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceUsedLabel.Location = new System.Drawing.Point(3, 0);
            this.SpaceUsedLabel.Name = "SpaceUsedLabel";
            this.SpaceUsedLabel.Size = new System.Drawing.Size(130, 52);
            this.SpaceUsedLabel.TabIndex = 1;
            this.SpaceUsedLabel.Text = "Space Used";
            this.SpaceUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SpaceUsedLabelValue
            // 
            this.SpaceUsedLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpaceUsedLabelValue.Location = new System.Drawing.Point(139, 0);
            this.SpaceUsedLabelValue.Name = "SpaceUsedLabelValue";
            this.SpaceUsedLabelValue.Size = new System.Drawing.Size(132, 52);
            this.SpaceUsedLabelValue.TabIndex = 2;
            this.SpaceUsedLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PathLabelValue
            // 
            this.PathLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PathLabelValue.Location = new System.Drawing.Point(139, 104);
            this.PathLabelValue.Name = "PathLabelValue";
            this.PathLabelValue.Size = new System.Drawing.Size(132, 54);
            this.PathLabelValue.TabIndex = 3;
            this.PathLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemLabel
            // 
            this.ItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemLabel.Location = new System.Drawing.Point(3, 52);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(130, 52);
            this.ItemLabel.TabIndex = 5;
            this.ItemLabel.Text = "Item";
            this.ItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemLabelValue
            // 
            this.ItemLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemLabelValue.Location = new System.Drawing.Point(139, 52);
            this.ItemLabelValue.Name = "ItemLabelValue";
            this.ItemLabelValue.Size = new System.Drawing.Size(132, 52);
            this.ItemLabelValue.TabIndex = 6;
            this.ItemLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneralInformationBox
            // 
            this.GeneralInformationBox.Controls.Add(this.tableLayoutPanel1);
            this.GeneralInformationBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralInformationBox.Location = new System.Drawing.Point(3, 3);
            this.GeneralInformationBox.Name = "GeneralInformationBox";
            this.GeneralInformationBox.Size = new System.Drawing.Size(280, 108);
            this.GeneralInformationBox.TabIndex = 0;
            this.GeneralInformationBox.TabStop = false;
            this.GeneralInformationBox.Text = "General information";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.UsersCountLabelValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.UsersCountLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.GeneralSpaceUsedLabelValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.GeneralSpaceUsedLabel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(274, 87);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UsersCountLabelValue
            // 
            this.UsersCountLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersCountLabelValue.Location = new System.Drawing.Point(140, 43);
            this.UsersCountLabelValue.Name = "UsersCountLabelValue";
            this.UsersCountLabelValue.Size = new System.Drawing.Size(131, 44);
            this.UsersCountLabelValue.TabIndex = 3;
            this.UsersCountLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UsersCountLabel
            // 
            this.UsersCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersCountLabel.Location = new System.Drawing.Point(3, 43);
            this.UsersCountLabel.Name = "UsersCountLabel";
            this.UsersCountLabel.Size = new System.Drawing.Size(131, 44);
            this.UsersCountLabel.TabIndex = 2;
            this.UsersCountLabel.Text = "Users count";
            this.UsersCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GeneralSpaceUsedLabelValue
            // 
            this.GeneralSpaceUsedLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralSpaceUsedLabelValue.Location = new System.Drawing.Point(140, 0);
            this.GeneralSpaceUsedLabelValue.Name = "GeneralSpaceUsedLabelValue";
            this.GeneralSpaceUsedLabelValue.Size = new System.Drawing.Size(131, 43);
            this.GeneralSpaceUsedLabelValue.TabIndex = 1;
            this.GeneralSpaceUsedLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GeneralSpaceUsedLabel
            // 
            this.GeneralSpaceUsedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneralSpaceUsedLabel.Location = new System.Drawing.Point(3, 0);
            this.GeneralSpaceUsedLabel.Name = "GeneralSpaceUsedLabel";
            this.GeneralSpaceUsedLabel.Size = new System.Drawing.Size(131, 43);
            this.GeneralSpaceUsedLabel.TabIndex = 0;
            this.GeneralSpaceUsedLabel.Text = "Space Used";
            this.GeneralSpaceUsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 364);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportDialog";
            this.Text = "ReportDialog";
            this.Load += new System.EventHandler(this.ReportDialog_Load);
            this.MainLayout.ResumeLayout(false);
            this.InformationLayout.ResumeLayout(false);
            this.SelectedItemInfoBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.GeneralInformationBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label ItemLabelValue;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label PathLabelValue;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label GeneralSpaceUsedLabel;
        private System.Windows.Forms.Label GeneralSpaceUsedLabelValue;
        private System.Windows.Forms.Label SpaceUsedLabel;
        private System.Windows.Forms.Label UsersCountLabelValue;
        private System.Windows.Forms.Label SpaceUsedLabelValue;
        private System.Windows.Forms.Label UsersCountLabel;

        private System.Windows.Forms.TableLayoutPanel ControlsLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.GroupBox SelectedItemInfoBox;
        private System.Windows.Forms.GroupBox GeneralInformationBox;

        private System.Windows.Forms.ListBox ItemsListBox;
        
        private System.Windows.Forms.TableLayoutPanel InformationLayout;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        #endregion
    }
}