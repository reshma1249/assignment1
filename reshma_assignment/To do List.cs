using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Xml;
using System.IO;

namespace reshma_assignment
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }
        //Reference: http://csharp.net-informations.com/xml/how-to-read-xml.htm
        private void list_Load(object sender, EventArgs e)
        {
                using (XmlTextReader xmlReader = new XmlTextReader("savefile.xml"))
                {
                    while (xmlReader.Read())
                    {
                        switch (xmlReader.NodeType)
                        {
                            case XmlNodeType.Element:
                                break;
                            case XmlNodeType.Text:
                                chkBoxList.Items.Add(xmlReader.Value);
                                break;
                            case XmlNodeType.EndElement:
                                break;
                        }
                    }
                }
                statusCount.Text = chkBoxList.Items.Count.ToString() + " Items";
                statusCheck.Text = ""; 
            
           
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemAuthor_Click(object sender, EventArgs e)
        {
            abtAuthor author = new abtAuthor();
            author.Show();
        }
        //Reference: https://msdn.microsoft.com/en-us/library/system.windows.forms.checkedlistbox(v=vs.90).aspx

        private void btnAdd_Click(object sender, EventArgs e)
        {
          try
            {
            
            if (txtBoxList.Text != "")
            {
                if (chkBoxList.CheckedItems.Contains(txtBoxList.Text) == false)
                    chkBoxList.Items.Add(txtBoxList.Text);
                txtBoxList.Text = "";
                statusCount.Text = chkBoxList.Items.Count.ToString() + " Items";
 
            }
}
          catch (Exception exception)
          {
              MessageBox.Show(exception.Message);
          }
 


        }
        //Reference: http://stackoverflow.com/questions/16370325/how-to-loop-through-checkedlistbox-and-remove-selected-items-in-c-sharp
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                while (chkBoxList.CheckedItems.Count > 0)
                {
                    chkBoxList.Items.Remove(chkBoxList.CheckedItems[0]);
                    statusCount.Text = chkBoxList.Items.Count.ToString() + " Items";

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
 
        }
        //Reference:http://tutplusplus.blogspot.in/2010/11/c-tutorial-save-text-to-xml-file-save.html
        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlTextWriter xwriter = new XmlTextWriter("savefile.xml", Encoding.Unicode);
            xwriter.WriteStartDocument();
            xwriter.WriteStartElement("TodoList");

            
            foreach (String item in chkBoxList.Items)
            {
                xwriter.WriteStartElement("Item");
                xwriter.WriteString(item);
                xwriter.WriteEndElement();
            }

            xwriter.WriteEndElement();
            xwriter.WriteEndDocument();
            xwriter.Close();
        }

        //Reference: http://stackoverflow.com/questions/14872577/iterate-through-checkedlistbox-testing-for-checked-cast-error
        
        private void chkBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkBoxList.SelectedIndex >= 0)
            {
                if (chkBoxList.GetItemChecked(chkBoxList.SelectedIndex))
                {
                    statusCheck.Text = "Completed";
                }
                else
                {
                    statusCheck.Text = "Not Completed";
                }
            }

        }


        }
        }

      
       
    

