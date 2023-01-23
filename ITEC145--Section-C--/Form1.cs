namespace ITEC145__Section_C__
{
    


    public partial class Form1 : Form
    {
        List<string> strings = new List<string>();
        OpenFileDialog ofd = new OpenFileDialog();
        const int STRINGSPLITCOUNT = 6;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                ofd.ShowDialog();     
                
                //txtRead.Text = ofd.FileName;          //How to show the path of the file

                StreamReader Reader = new StreamReader(ofd.FileName);

                while(!Reader.EndOfStream)
                {
                    string x = Reader.ReadLine();
                    strings.AddRange(x.Split(", "));    //The regular .Add() function doesn't work for substrings, so addrange must be used
                    count++;
                }

                txtRead.Text = $"{count} Lines added to List";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);            //Shows exception message
            }
        }

        private void AddRow()
        {
            double rowsNeeded = strings.Count / STRINGSPLITCOUNT;

            for(int i = 0; i < rowsNeeded; i++)
            {
                dataGridView1.Rows.Add();
            }

        }

        private void btnToGrid_Click(object sender, EventArgs e)
        {
            AddRow();

            int count = 0;
            int r = 0;          //Row integer 
            int c = 0;          //Column integer

                for(int i = 0; i < strings.Count; i++)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[r].Cells[c];
                    dataGridView1.CurrentCell.Value = strings[i];
                    c++;

                    if(c == STRINGSPLITCOUNT)
                    {
                        c = 0;
                        r++;
                    }
                    count++;
                }
            txtCopy.Text = $"{count} Strings loaded to Datagrid";
            dataGridView1.Refresh();

            //string finalString = "";
            //int stringPart = 0;


            //dataGridView1.Rows.Clear();

            //for(int i = 0; i < strings.Count; i++)
            //{
            //    strings[stringPart] += finalString;

            //    if (stringPart == STRINGSPLITCOUNT)
            //    {
            //        stringPart = 0;
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