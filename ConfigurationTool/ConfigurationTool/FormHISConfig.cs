using DevComponents.DotNetBar.SuperGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigurationTool
{
    public partial class FormHISConfig : Form
    {
        private Configuration _Xml;
        private string _FilName;

        public FormHISConfig()
        {
            InitializeComponent();

        }

        private void btnAddConnect_Click(object sender, EventArgs e)
        {

        }


        private void superGridControl1_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (gridConnString.PrimaryGrid.ActiveRow.Tag is ConnectionStringSettings connectionString)
            {
                btnEdit.Enabled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (FormAddParameter form = new FormAddParameter())
            {

                if (superTabControl1.SelectedTab == superTabItem1)
                {
                    form.Name = (gridConnString.PrimaryGrid.ActiveRow as GridRow).Cells[0].Value.ToString();
                    form.Value = (gridConnString.PrimaryGrid.ActiveRow as GridRow).Cells[1].Value.ToString();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (superTabControl1.SelectedTab == superTabItem1)
                        {
                            ConnectionStringSettings connectionStringSettings = new ConnectionStringSettings();
                            connectionStringSettings.Name = form.Name;
                            connectionStringSettings.ConnectionString = form.Value;
                            //_Xml.ConnectionStrings.ConnectionStrings.Add(connectionStringSettings);
                            var connectionStrings = _Xml.ConnectionStrings;
                            connectionStrings.ConnectionStrings[form.Name].ConnectionString = form.Value;
                            _Xml.Save();

                            (gridConnString.PrimaryGrid.ActiveRow as GridRow).Cells[1].Value = form.Value;
                        }
                    }
                }
                else

                {
                    form.Name = (superGridControl2.PrimaryGrid.ActiveRow as GridRow).Cells[0].Value.ToString();
                    form.Value = (superGridControl2.PrimaryGrid.ActiveRow as GridRow).Cells[1].Value.ToString();
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var appSettings = _Xml.AppSettings;
                        appSettings.Settings[form.Name].Value = form.Value;
                        _Xml.Save();

                        (superGridControl2.PrimaryGrid.ActiveRow as GridRow).Cells[1].Value = form.Value;

                    }
                }

            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {

        }

        private void superGridControl2_RowClick(object sender, GridRowClickEventArgs e)
        {
            if (superGridControl2.PrimaryGrid.ActiveRow.Tag is KeyValueConfigurationElement connectionString)
            {
                btnEdit.Enabled = true;
            }
        }

        private void superGridControl1_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private void superGridControl2_RowDoubleClick(object sender, GridRowDoubleClickEventArgs e)
        {
            btnEdit_Click(null, null);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            superGridControl2.PrimaryGrid.Rows.Clear();
            gridConnString.PrimaryGrid.Rows.Clear();
            var dic = GetHISConfig();
            if (dic.Key == null)
            {
                return;
            }
            _Xml = dic.Value;
            _FilName = dic.Key;
            // var DBList = xml.SelectSingleNode("connectionStrings");
            var connectionStrings = _Xml.ConnectionStrings;
            foreach (ConnectionStringSettings item in connectionStrings.ConnectionStrings)
            {
                GridRow row = new GridRow(new object[] { item.Name, item.ConnectionString });
                row.Tag = item;
                gridConnString.PrimaryGrid.Rows.Add(row);
            }
            var appsettings = _Xml.AppSettings;
            foreach (KeyValueConfigurationElement item in appsettings.Settings)
            {
                GridRow row = new GridRow(new object[] { item.Key, item.Value });
                row.Tag = item;
                superGridControl2.PrimaryGrid.Rows.Add(row);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveHISConfig(_FilName);
        }

        public KeyValuePair<string, Configuration> GetHISConfig()
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.config)|*.config|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileMap.ExeConfigFilename = openFileDialog.FileName;
                Configuration config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
                return new KeyValuePair<string, Configuration>(openFileDialog.FileName, config);
            }
            return new KeyValuePair<string, Configuration>();
        }

        /// <summary>
        /// 另存为文件
        /// </summary>
        public void SaveHISConfig(string filName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.RestoreDirectory = true;//保存对话框是否记忆上次打开的目录
            saveFileDialog.CheckPathExists = true;//检查目录
            saveFileDialog.FileName = System.Configuration.ConfigurationManager.AppSettings["HISConfig"];//设置默认文件名
            saveFileDialog.Filter = "config files (*.config)|*.config|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                string pLocalFilePath = filName;
                Copy(pLocalFilePath, path);
            }
        }
        public static bool Copy(string pLocalFilePath, string pSaveFilePath)
        {

            if (System.IO.File.Exists(pLocalFilePath))
            {
                System.IO.File.Copy(pLocalFilePath, pSaveFilePath, true);
            }
            return true;
        }
    }
}
