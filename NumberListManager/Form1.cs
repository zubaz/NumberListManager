using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberListManager
{
    public partial class NumberListManager : Form
    {
        //creats random numbers to be used with the generate button
        Random generator = new Random();

        //quicksort function this is used to sort my randomly generated numbers when radsort has been clicked
        public void Quicksort( int left, int right)
        {
            int i = left, j = right;
            int pivot = Convert.ToInt32( listNumbers.Items [(left + right) / 2]);

            while (i <= j)
            {
                while (Convert.ToInt32(listNumbers.Items[i]).CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (Convert.ToInt32(listNumbers.Items[j]).CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = Convert.ToInt32(listNumbers.Items[i]);
                    listNumbers.Items[i] = Convert.ToInt32(listNumbers.Items[j]);
                    listNumbers.Items[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort( left, j);
            }

            if (i < right)
            {
                Quicksort( i, right);
            }
        }
        // methods to sort list
        private void listSort()
        {
            // if list is empty will stop program from breaking
            if (listNumbers.Items.Count > 0)
            {
               
                Quicksort( 0, listNumbers.Items.Count - 1);
              
            }
            
        }
        //enabling/disabling buttons ect..
        private void UpdateUI()
        {
            int count = listNumbers.Items.Count;
            if (count > 0)
            {
            
                if (listNumbers.SelectedItems.Count > 0)
                {
                    lblSelected.Text = listNumbers.SelectedItem.ToString();
                   
                }
                else
                {
                    lblSelected.Text = "";
                  
                }

                lblLastEntry.Text = listNumbers.Items[count - 1].ToString();
                lblFirstEntry.Text = listNumbers.Items[0].ToString();
                lblStatus.Text = count + " Items";
                btnDelete.Enabled = true;
                btnClear.Enabled = true;
                btnShuffle.Enabled = true;
                btnSearch.Enabled = true;
            }
            else
            {
                
                lblLastEntry.Text = "";
                lblFirstEntry.Text = "";
                lblStatus.Text = "Empty";
                btnDelete.Enabled = false;
                btnClear.Enabled = false;
                btnShuffle.Enabled = false;
                btnSearch.Enabled = false;
            }
        }
        public NumberListManager()
        {
            InitializeComponent();
        }

        private void txtListBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string newLine = Environment.NewLine;

            listNumbers.Items.Clear();
            for (int i = 1; i <= 30; i++)
            {
                int tal = generator.Next(0, 101);
               
                int tmp = 0;
 
                while (LinearSearch(tal, 0, ref tmp) > -1)
                {
                    tal = generator.Next(0, 101);
                }
                listNumbers.Items.Add(tal.ToString());

            }
            if (radSorted.Checked)
                listSort();
            UpdateUI();
        }
        private void btnSearch_Click(object sender, EventArgs e)

        {

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("The search query is empty.");
                return;
            }
            if (radBinary.Checked && radUnsorted.Checked)
            {
                MessageBox.Show("You cannot prefrom a binary search on an unsorted list.");
                return;
            }


            int searchNumber;
            try
            {
                searchNumber = Convert.ToInt32(txtSearch.Text);
            }
            catch
            {
                MessageBox.Show("Only numbers please");
                return;
            }

            int searchResult, probes = 0;

            if (radLinear.Checked)
            {
                searchResult = LinearSearch(searchNumber, 0, ref probes);
            }
            else
            {
                searchResult = BinarySearch(searchNumber, 0, ref probes);
            }
            
            if (searchResult > -1)
            {
                MessageBox.Show(searchNumber + " was found at index " + searchResult + ".\n\nIt took " + probes + " probes.");
            }
            else
            {
                MessageBox.Show(searchNumber + " was not found. ");
            }
        }
        // Search functions   
        private int LinearSearch(int item, int start, ref int probes)
        {
           
            int n = listNumbers.Items.Count;
            // goes through the list one item at a time 
            for (int i = start; i < n; i++)
            {
                probes++;
                //does the current item match the search?
                if (Convert.ToInt32(listNumbers.Items[i]) == item)
                {
                    return i;
                }
            }
            //not found
            return -1;

        }


        private int BinarySearch(int item, int start, ref int probes)
        {
            int max = listNumbers.Items.Count;

            if (item > Convert.ToInt32(listNumbers.Items[max - 1]))
            {
                return -1;
            }

            while (start <= max)
            {
                int mid = (start + max) / 2;

                probes++;

                if (item == Convert.ToInt32(listNumbers.Items[mid]))
                {
                    return mid;
                }

                if (item < Convert.ToInt32(listNumbers.Items[mid]))
                {
                    max = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }

            }
            return -1;
         

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (listNumbers.Items.Count == 30)
            {
                MessageBox.Show("The list is full");
                return;
            }

            int insert;
            try
            {
                insert = Convert.ToInt32(txtInsert.Text);
            }
            catch
            {
                MessageBox.Show("Only numbers please");
                return;
            }
            if (insert > 100 || insert < 0)
            {
                MessageBox.Show("Numbers must be from 0 to 100 plaese");
                return;
            }
            if (listNumbers.Items.Contains(insert))
            {
                MessageBox.Show("No duplicates please");
                return;
            }
            listNumbers.Items.Add(insert);

            if (radSorted.Checked)
            {
                listSort();

            }
            UpdateUI();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listNumbers.Items.Clear();
            UpdateUI();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listNumbers.Items.Count > 0)
            {
                if (listNumbers.SelectedItems.Count > 0)
                {
                    listNumbers.Items.RemoveAt(listNumbers.SelectedIndex);
                    UpdateUI();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radSort_CheckedChanged(object sender, EventArgs e)
        {
            if (radSorted.Checked)
            {
                listSort();
            }
            else if (radUnsorted.Checked)
            {
                Random rng = new Random();
                int count = listNumbers.Items.Count;
                listNumbers.BeginUpdate();
                while (count > 1)
                {
                    count--;
                    int k = rng.Next(count + 1);
                    object value = listNumbers.Items[k];
                    listNumbers.Items[k] = listNumbers.Items[count];
                    listNumbers.Items[count] = value;
                }
                listNumbers.EndUpdate();
                listNumbers.Invalidate();
            }
            UpdateUI();
        }
     
        private void radUnsorted_CheckedChanged(object sender, EventArgs e)
        {
            radSort_CheckedChanged(sender, e);
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            int count = listNumbers.Items.Count;
            listNumbers.BeginUpdate();
            while (count > 1)
            {
                count--;
                int k = rng.Next(count + 1);
                object value = listNumbers.Items[k];
                listNumbers.Items[k] = listNumbers.Items[count];
                listNumbers.Items[count] = value;
            }
            listNumbers.EndUpdate();
            listNumbers.Invalidate();
            UpdateUI();     
        }
    
private void NumberListManager_Load(object sender, EventArgs e)
        {
            UpdateUI();
            picBin.AllowDrop = true;
        }

        private void listNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateUI();

            if (listNumbers.Items.Count > 0)
                listNumbers.DoDragDrop(listNumbers.Items, DragDropEffects.Move);
        }

        private void picBin_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void picBin_DragDrop(object sender, DragEventArgs e)
        {
            if (listNumbers.Items.Count > 0)
            {
                if (listNumbers.SelectedItems.Count > 0)
                {
                    listNumbers.Items.RemoveAt(listNumbers.SelectedIndex);
                    UpdateUI();
                }
            }
        }
    }
}


