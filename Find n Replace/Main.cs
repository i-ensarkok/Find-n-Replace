using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_n_Replace
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
        }
        List<string> pathList = new List<string>();
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select a file";
                ofd.Multiselect = true;
                //ofd.Filter = "Text Files (*.txt) | *.txt | All Files(*.*) | *.*";
                DialogResult dr = ofd.ShowDialog();

                if (dr == DialogResult.OK)
                {

                    foreach (String file in ofd.FileNames)
                    {
                        StreamReader sr = new StreamReader(ofd.FileName);
                        //Infolbl.Text = ofd.FileName;                
                        pathList.Add(file);
                        pathBox.Items.Add(file);

                        //label3.Text = file;
                        //Infolbl.Text = sr.ReadToEnd();
                        sr.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dosya seçiminde hata oluştu!");
                
            }
        }

        
        private void findNreplaceBtn_Click(object sender, EventArgs e)
        {
            List<String> done = new List<string>();
            if (pathBox.SelectedItem != null)
            {
                foreach (String file in pathBox.SelectedItems)
                {
                    //MessageBox.Show(file);
                    try
                    {
                        string text = File.ReadAllText(file);
                        if (text.Contains(findBox.Text))
                        {
                            text = text.Replace(findBox.Text, replaceBox.Text);
                            File.WriteAllText(file, text);
                            done.Add(file);
                        }
                        else
                        {
                            MessageBox.Show("Böyle bir değer yok!");
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Değiştirmede hata oluştu!");
                    }
                }
                
                MessageBox.Show("İşlem tamamlandı.");
            }
            foreach(String file in done)
            {
                pathBox.Items.Remove(file);
            }
            
            
        }

        private void pathBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void pathBox_DragDrop(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, true);
                pathBox.Items.Add(s[0]);
            }
        }
       /* private string BelgeyiOku(string dosya_yolu)
        {
            StreamReader dosyaOku = new StreamReader(dosya_yolu, Encoding.GetEncoding("windows-1254"));
            string yazi = dosyaOku.ReadLine();
            while (yazi != null)
            {
                
                yazi = dosyaOku.ReadLine();
            }
            dosyaOku.Close();
            return yazi;
        }
       */

        private void removeBtn_Click(object sender, EventArgs e)
        {
            pathBox.Items.Remove(pathBox.SelectedItem);
        }


        private void pathBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                //MessageBox.Show("Delete Key Pressed ");
                pathBox.Items.Remove(pathBox.SelectedItem);
            }
            if (e.Control && e.KeyCode == Keys.A)
            {             
                for (int i = 0; i < pathBox.Items.Count; i++)
                {                 
                    pathBox.SetSelected(i, true);
                }
                
            }
        }

        private void pathBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(pathBox.SelectedItem != null)
                {
                    StreamReader sr = new StreamReader(pathBox.SelectedItem.ToString());
                    previewBox.Text = sr.ReadToEnd();
                    sr.Close();
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Önizleme hatası!");
            }
            
        }
    }
}
