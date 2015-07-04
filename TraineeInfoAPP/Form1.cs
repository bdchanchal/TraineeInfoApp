using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraineeInfoAPP
{
    //Chanchal Zoarder
    //SEID- 106121
    //Team- Top Coder
    public partial class TraineeInfoUI : Form
    {
        Hashtable traineeHashtable = new Hashtable();
        public int count = 0;

        public TraineeInfoUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {


            if (entrySEIDTextBox.Text != "" && entryTraineeDetailsTextBox.Text != "")
            {
                string entryKey = entrySEIDTextBox.Text;
                string entryValue = entryTraineeDetailsTextBox.Text;

                traineeHashtable.Add(entryKey, entryValue);
                totalTraineeTextBox.Text = traineeHashtable.Count.ToString();
                
                count++;
                ClearTextBox();
             }
            else
            {
                MessageBox.Show("Insert Info.");
            }



        }

        public void ClearTextBox()
        {
            entrySEIDTextBox.Text = null;
            entryTraineeDetailsTextBox.Text = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (count!=0 && searchSEIDTextBox.Text!="")
            {
                string searchKey = searchSEIDTextBox.Text;
                
                if (traineeHashtable.Contains(searchKey))
                {
                    searchTraineeDetailsTextBox.Text = traineeHashtable[searchKey].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid SEID!");
                }
                searchSEIDTextBox.Text = null;
            }
            else
            {
                MessageBox.Show("Insert SEID.");
            }
        }
    }
}
