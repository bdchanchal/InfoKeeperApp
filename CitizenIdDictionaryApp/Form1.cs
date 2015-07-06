using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenIdDictionaryApp
{
    public partial class DictionryUI : Form
    {
        Dictionary<int,string> citizenDitionary = new Dictionary<int, string>();
        public int id;
        public string details;
        public int searchId;
        public int count = 0;
        public DictionryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "" && detailsTextBox.Text != "")
            {
                id = Convert.ToInt32(idTextBox.Text);
                details = detailsTextBox.Text;

                citizenDitionary.Add(id, details);

                idTextBox.Text = null;
                detailsTextBox.Text = null;
                MessageBox.Show("Saved Successfully");
                count++;
            }
            else
            {
                MessageBox.Show("Please Enter ID and Details.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchIDTextBox.Text != "" && count != 0)
            {
                searchId = Convert.ToInt32(searchIDTextBox.Text);

                if (citizenDitionary.ContainsKey(searchId))
                {
                    MessageBox.Show(citizenDitionary[searchId]);
                    searchIDTextBox.Text = null;
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                MessageBox.Show("You must save Information first and write search ID here");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            if (count != 0)
            {
                foreach (KeyValuePair<int, string> a in citizenDitionary)
                {
                    MessageBox.Show(a.Key + " " + a.Value);
                }
            }
            else
            {
                MessageBox.Show("No Information has been saved yet");
            }
        }

    }
}
