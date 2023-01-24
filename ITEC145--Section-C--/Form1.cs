using System.Configuration;

namespace ITEC145__Section_C__
{
    public partial class Form1 : Form
    {
        List<string> strings = new List<string>();
        OpenFileDialog ofd = new OpenFileDialog();
        const int COLUMNS = 6;                         //Constant for amount of columns in my datagrid. And how to sort data.
        List<string> delStrings = new List<string>();

        int rowCount = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;                          //Thought I'd try splitting the data before adding to list.
                ofd.ShowDialog();     
                
                //txtRead.Text = ofd.FileName;          //How to show the path of the file

                StreamReader Reader = new StreamReader(ofd.FileName);

                while(!Reader.EndOfStream)
                {
                    string x = Reader.ReadLine();
                    strings.AddRange(x.Split(", "));    //The regular .Add() function doesn't work for arrays, so .AddRange must be used, took awhile to figure this out...
                    count++;
                }  
                txtRead.Text = $"{count*COLUMNS} Records added to List";       
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);            //Shows exception message to help with debug
            }
        }

        private void AddRow()                           //Method to work out the amount of rows needed in datagrid
        {
            double rowsNeeded = strings.Count / COLUMNS;           //Amount of strings diveded by the amount of columns

            for(int i = 0; i < rowsNeeded; i++)
            {
                dataGridView1.Rows.Add();       //How to add a new row to a datagrid.
            }

        }

        private int LoadToGrid(ref int rowCount, ref int count)
        {
            //dataGridView1.Rows.Clear();         //Clears datasheet
            AddRow();                           //Method to add rows needed executes

            count = 0;
            int r = 0;          //To keep track of a cells Row integer 
            int c = 0;          //To keep track of a cells Column integer

            if (rowCount == 0)
            {
                for (int i = 0; i < strings.Count; i++)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[c]; //How to select a specific cell in a datagrid
                    dataGridView1.CurrentCell.Value = strings[i];               //Adds the string in list index
                    c++;                                                        //After entering data, move to next column

                    if (c == COLUMNS)                                   //If current column equals the total amount of columns
                    {
                        c = 0;                                          //Columns reset
                        r++;                                            //move to next row
                    }
                    count++;
                }

                rowCount = r;
                return count;
                
            }
            else 
            {
                r = rowCount;
                for (int i = 0; i < strings.Count; i++)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[c]; //How to select a specific cell in a datagrid
                    dataGridView1.CurrentCell.Value = strings[i];               //Adds the string in list index
                    c++;                                                        //After entering data, move to next column

                    if (c == COLUMNS)                                   //If current column equals the total amount of columns
                    {
                        c = 0;                                          //Columns reset
                        r++;                                            //move to next row
                    }
                    count++;
                }

                rowCount = r;
                return count;
            }
        }

        private void btnToGrid_Click(object sender, EventArgs e)
        {
            int count = 0;
            LoadToGrid(ref rowCount, ref count);
            
            txtCopy.Text = $"{count/COLUMNS} Records loaded to Datagrid";
            //dataGridView1.Refresh();                                    //Refreshes datasheet, doesnt seem to be needed



            //Partial Code for reassembling the strings
            //but I felt like I was taking a shortcut so I did something else instead.

            //string finalString = "";
            //int stringPart = 0;


            //dataGridView1.Rows.Clear();

            //for(int i = 0; i < strings.Count; i++)
            //{
            //    strings[stringPart] += finalString;       //Concatenating each string based on array index

            //    if (stringPart == STRINGSPLITCOUNT)
            //    {
            //        stringPart = 0;                       //Once all strings in a row have been entered, start again.
            //    }

            //    stringPart++;
            //}


            //for (int i = 0; !Reader.EndOfStream; i++)           //Whilst the reader is not end of stream, read each line
            //{
            //    string line = Reader.ReadLine();

            //    dataGridView1.Rows.Add(line.Split(", "));       //Splits the line up and adds to each column

            //    count++;
            //}



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //Tried to get buttons to appear/disappear depending on what was clicked, but would work intermittently
            
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveDatagrid_Click(object sender, EventArgs e)
        {
            strings.Clear();        //Clears strings list before refilling it
            

            //Took me a few hours to figure out this tiny section :(
            foreach(DataGridViewRow row in dataGridView1.Rows)      //Checks each row in my datagrid
            {
                foreach(DataGridViewCell cell in row.Cells)         //Before checking next row, checks all cells in row 

                if(cell.Value != null)                              //Used to prevent empty cells being added
                    strings.Add(cell.Value.ToString());
            }
            //Took me a few hours to figure out this tiny section :( ^^^^^^^^^^^^^^^^
            
            try
            {
                StreamWriter Writer = new StreamWriter("newnamelog.txt");  //Makes namelog file in programs directory
            
            foreach(string s in strings)
            {
                Writer.WriteLine(s);            //Writes each string from string array to file  
            }                                   //(Could concatenatate them with using my COLUMNS constant if I wanted output file to look nice)

            int count = 0;
            rowCount = 0;                       //Resets row counter as datagrid is about to be cleared
            dataGridView1.Rows.Clear();
            LoadToGrid(ref rowCount, ref count);    //refills datagrid
            Writer.Close();
            MessageBox.Show($"Saved {count} records to file newnamelog.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow values in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.Remove(values);
                }
                rowCount--;         //As I have deleted a row, I need to decrement rowCount to prevent indexing errors
            }
            catch
            {
                rowCount = 0;       //If someone tries to get row count to negatives, this stops it.
                MessageBox.Show("There are no rows to delete!");
            }
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            strings.Clear();       
        }

        private void btnClearDatagrid_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            rowCount = 0;
            
        }
    }
}