using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Sp=Spire.Doc;

namespace WordAddIn
{
    public partial class FlashMan
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btn_Save_As_Pdf(object sender, RibbonControlEventArgs e)
        {
            string sfilepath ="";
            //获取pdf保存路劲
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (this.folderBrowserDialog1.SelectedPath.Trim() != "")
                {
                    sfilepath = this.folderBrowserDialog1.SelectedPath.Trim();
                }
                else { MessageBox.Show("路径无效"); return; }
            }
            else { return; }
            //获取当前文档
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;

            string sfileName_Document = doc.Name;
            doc.ExportAsFixedFormat(sfilepath, Word.WdExportFormat.wdExportFormatPDF, true);
        }

        private void gallery1_Click(object sender, RibbonControlEventArgs e)
        {
          
        }


        private void button5_Click(object sender, RibbonControlEventArgs e)
        {
            ////获取当前文档
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            ////获取文档路径
            //string sfileName_path = doc.Path + @"\"+DateTime.Now.ToLongDateString() +"-"+ doc.Name;
            //doc.SaveAs2(sfileName_path);

            //var WordApp = Globals.ThisAddIn.Application;
            //WordApp.ActiveDocument.InlineShapes.AddPicture("");
            //WordApp.ActiveDocument.Paragraphs.Add(0);

            Sp.Document document = new Sp.Document(doc.FullName);
            MessageBox.Show("OK");
            




        }
    }
}
