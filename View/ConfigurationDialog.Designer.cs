using System.ComponentModel;

namespace FolderScanner.View
{
    partial class ConfigurationDialog
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
            this.ButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.Informationlabel = new System.Windows.Forms.Label();
            this.SelectedItemLayout = new System.Windows.Forms.TableLayoutPanel();
            this.CurrentItemLabelValue = new System.Windows.Forms.Label();
            this.CurrentItemLabel = new System.Windows.Forms.Label();
            this.SelectLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.MainLayout.SuspendLayout();
            this.ButtonLayout.SuspendLayout();
            this.SelectedItemLayout.SuspendLayout();
            this.SelectLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayout.Controls.Add(this.ButtonLayout, 0, 3);
            this.MainLayout.Controls.Add(this.Informationlabel, 0, 0);
            this.MainLayout.Controls.Add(this.SelectedItemLayout, 0, 1);
            this.MainLayout.Controls.Add(this.SelectLayout, 0, 2);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 4;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.16854F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.83146F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.MainLayout.Size = new System.Drawing.Size(298, 213);
            this.MainLayout.TabIndex = 0;
            // 
            // ButtonLayout
            // 
            this.ButtonLayout.ColumnCount = 3;
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonLayout.Controls.Add(this.ApplyBtn, 1, 0);
            this.ButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLayout.Location = new System.Drawing.Point(3, 170);
            this.ButtonLayout.Name = "ButtonLayout";
            this.ButtonLayout.RowCount = 1;
            this.ButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonLayout.Size = new System.Drawing.Size(292, 40);
            this.ButtonLayout.TabIndex = 3;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyBtn.Location = new System.Drawing.Point(100, 3);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(91, 34);
            this.ApplyBtn.TabIndex = 0;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // Informationlabel
            // 
            this.Informationlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Informationlabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Informationlabel.Location = new System.Drawing.Point(3, 0);
            this.Informationlabel.Name = "Informationlabel";
            this.Informationlabel.Size = new System.Drawing.Size(292, 80);
            this.Informationlabel.TabIndex = 0;
            this.Informationlabel.Text = "Here you can set memory measurement unit to display";
            this.Informationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectedItemLayout
            // 
            this.SelectedItemLayout.ColumnCount = 2;
            this.SelectedItemLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectedItemLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectedItemLayout.Controls.Add(this.CurrentItemLabelValue, 0, 0);
            this.SelectedItemLayout.Controls.Add(this.CurrentItemLabel, 0, 0);
            this.SelectedItemLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedItemLayout.Location = new System.Drawing.Point(3, 83);
            this.SelectedItemLayout.Name = "SelectedItemLayout";
            this.SelectedItemLayout.RowCount = 1;
            this.SelectedItemLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectedItemLayout.Size = new System.Drawing.Size(292, 37);
            this.SelectedItemLayout.TabIndex = 1;
            // 
            // CurrentItemLabelValue
            // 
            this.CurrentItemLabelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentItemLabelValue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CurrentItemLabelValue.Location = new System.Drawing.Point(149, 0);
            this.CurrentItemLabelValue.Name = "CurrentItemLabelValue";
            this.CurrentItemLabelValue.Size = new System.Drawing.Size(140, 37);
            this.CurrentItemLabelValue.TabIndex = 2;
            this.CurrentItemLabelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentItemLabel
            // 
            this.CurrentItemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentItemLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CurrentItemLabel.Location = new System.Drawing.Point(3, 0);
            this.CurrentItemLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.CurrentItemLabel.Name = "CurrentItemLabel";
            this.CurrentItemLabel.Size = new System.Drawing.Size(143, 37);
            this.CurrentItemLabel.TabIndex = 1;
            this.CurrentItemLabel.Text = "Current:";
            this.CurrentItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SelectLayout
            // 
            this.SelectLayout.ColumnCount = 3;
            this.SelectLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SelectLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SelectLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SelectLayout.Controls.Add(this.UnitsComboBox, 1, 0);
            this.SelectLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectLayout.Location = new System.Drawing.Point(3, 126);
            this.SelectLayout.Name = "SelectLayout";
            this.SelectLayout.RowCount = 1;
            this.SelectLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectLayout.Size = new System.Drawing.Size(292, 38);
            this.SelectLayout.TabIndex = 2;
            // 
            // UnitsComboBox
            // 
            this.UnitsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UnitsComboBox.FormattingEnabled = true;
            this.UnitsComboBox.Location = new System.Drawing.Point(76, 3);
            this.UnitsComboBox.Name = "UnitsComboBox";
            this.UnitsComboBox.Size = new System.Drawing.Size(140, 24);
            this.UnitsComboBox.TabIndex = 0;
            // 
            // ConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 213);
            this.Controls.Add(this.MainLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigurationDialog";
            this.Text = "ConfigurationDialog";
            this.Load += new System.EventHandler(this.ConfigurationDialog_Load);
            this.MainLayout.ResumeLayout(false);
            this.ButtonLayout.ResumeLayout(false);
            this.SelectedItemLayout.ResumeLayout(false);
            this.SelectLayout.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.ComboBox UnitsComboBox;

        private System.Windows.Forms.Label Informationlabel;
        private System.Windows.Forms.Label CurrentItemLabel;
        private System.Windows.Forms.Label CurrentItemLabelValue;

        private System.Windows.Forms.TableLayoutPanel ButtonLayout;
        private System.Windows.Forms.TableLayoutPanel SelectLayout;
        private System.Windows.Forms.TableLayoutPanel SelectedItemLayout;
        private System.Windows.Forms.TableLayoutPanel MainLayout;

        #endregion
    }
}