using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using DevExpress.Xpf.Grid;

using DevExpress.XtraPrinting;
using DevExpress.Export;
using System.Windows;
using System.IO;
using Test2.Commands;
using Test2.Interfaces;

namespace Test2.ViewModels
{
    public abstract  class ViewModel : IExport
    {


        public ICommand RefreshCommand
        {
            get;
            private set;
        }
        public ICommand OpenAddWindowCommand
        {
            get;
            private set;
        }
        public ICommand OpenEditWindowCommand
        {
            get;
            private set;
        }
        public ICommand SaveModelCommand
        {
            get;
            private set;
        }
        public ICommand CloseWindowCommand
        {
            get;
            private set;
        }
        public ICommand OpenDeleteWindowCommand
        {
            get;
            private set;
        }
        public ICommand DeleteModelCommand
        {
            get;
            private set;
        }
        public ICommand ExportCommand
        {
            get;
            private set;
        }
        public ViewModel()
        {
            OpenAddWindowCommand = new OpenAddWindowCommand(this);
            ExportCommand = new ExportCommand(this);
            SaveModelCommand = new SaveModelCommand(this);

        }

        public void ExportToExcel(ContentControl contentControl)
        {
            var contentPresenter = ExportHelper.FindVisualChild<ContentPresenter>(contentControl);

            UIElement visualWindowContent = (UIElement)VisualTreeHelper.GetChild(contentPresenter, 0);

            GridControl gridControl = ExportHelper.FindVisualChild<GridControl>(visualWindowContent);
            //GridView gridView = ExportHelper.FindVisualChild<GridView>(visualWindowContent);
            TableView view = ExportHelper.FindVisualChild<TableView>(contentPresenter);

            for (int i = 0; i < gridControl.VisibleRowCount; i++)
            {
                gridControl.SetMasterRowExpanded(i, true);

            }
            XlsxExportOptionsEx options = new XlsxExportOptionsEx();
            options.ExportType = ExportType.WYSIWYG;

            XlsExportOptionsEx xlsExportOptions = new XlsExportOptionsEx();
            xlsExportOptions.ExportType = ExportType.WYSIWYG;
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |Pdf File (.pdf)|*.pdf";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            view.ExportToXls(exportFilePath, xlsExportOptions);

                            break;
                        case ".xlsx":
                            view.ExportToXlsx(exportFilePath, options);
                            break;
                        case ".pdf":
                            view.ExportToPdf(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            System.Windows.Forms.MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        System.Windows.Forms.MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public abstract void refreshData();
        public abstract void reloadModel();
        public abstract bool canSaveEditOrDelete();
        public abstract void openAddWindow();
        public abstract void openEditWindow();
        public abstract void openDeleteWindow();
        public abstract void save();
        public abstract void delete();
        public abstract void closeWindow();
    }
}
