using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FolderScanner.View
{
    public partial class ConfigurationDialog : Form
    {
        
        public delegate void NewItem(Utils.MemoryUnit item);
        public event NewItem? ApplyNewUnit;
        
        public ConfigurationDialog()
        {
            InitializeComponent();
            foreach (var value in Enum.GetValues(typeof(Utils.MemoryUnit)))
            {
                UnitsComboBox.Items.Add(value);
            }
            UnitsComboBox.SelectedIndex = 0;

            // failed
            //CurrentItemLabelValue.DataBindings.Add(new Binding("Text", Owner, "MemoryUnit"));
        }


        private void ConfigurationDialog_Load(object sender, EventArgs e)
        {
            CurrentItemLabelValue.Text = ((MainWindow)Owner).MemoryUnit.ToString();
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var res =  Enum.Parse(typeof(Utils.MemoryUnit), UnitsComboBox.SelectedItem.ToString());
                CurrentItemLabelValue.Text = res.ToString();
                ApplyNewUnit?.Invoke((Utils.MemoryUnit)res);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Failed to get new value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("ApplyBtn_Click: " + exception.Message);
            }
        }
    }
}