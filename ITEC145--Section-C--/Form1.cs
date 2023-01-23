namespace ITEC145__Section_C__
{
    


    public partial class Form1 : Form
    {
        List<string> strings = new List<string>();
        OpenFileDialog ofd = new OpenFileDialog();
        const int COLUMNS = 6;                         //Constant for amount of columns in my datagrid. And how to sort data.

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {                                                   //Thought I'd try splitting the data before adding to list.
                int count = 0;
                ofd.ShowDialog();     
                
                //txtRead.Text = ofd.FileName;          //How to show the path of the file

                StreamReader Reader = new StreamReader(ofd.FileName);

                while(!Reader.EndOfStream)
                {
                    string x = Reader.ReadLine();
                    strings.AddRange(x.Split(", "));    //The regular .Add() function doesn't work for arrays, so .AddRange must be used
                    count++;
                }   





                txtRead.Text = $"{count*COLUMNS} Strings added to List";       
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

        private int LoadToGrid(ref int count)
        {
            dataGridView1.Rows.Clear();         //Clears datasheet
            AddRow();                           //Method to add rows needed executes

            count = 0;
            int r = 0;          //To keep track of a cells Row integer 
            int c = 0;          //To keep track of a cells Column integer

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
            return count;
        }

        private void btnToGrid_Click(object sender, EventArgs e)
        {
            int count = 0;

            LoadToGrid(ref count);
            
            txtCopy.Text = $"{count} Strings loaded to Datagrid";
            //dataGridView1.Refresh();                                    //Refreshes datasheet, doesnt seem to be needed



            //Partial Code for reassembling the strings
            //but I felt like I was cheating so did above instead.

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
    }
}