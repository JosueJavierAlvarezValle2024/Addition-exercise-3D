namespace Addition_exercise_3D
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            int[] dimensions = { 7, 5, 3 };

            
            int[] array1D = new int[dimensions[0]];
            
            int[,] array2D = new int[dimensions[1], dimensions[2]];
            
            int[,,] array3D = new int[dimensions[0], dimensions[1], dimensions[2]];


            FillArray(array1D);
            FillArray(array2D);
            FillArray(array3D);


            ShowArrangement(txtArray1D, array1D);
            ShowArrangement(txtArray2D, array2D);
            ShowArrangement(txtArray3D, array3D);

            
            int additionArray1D = AddArray(array1D);
            int additionArray2D = AddArray(array2D);
            int additionArray3D = AddArray(array3D);

           
            txtSumArray1D.Text = additionArray1D.ToString();
            txtSumArray2D.Text = additionArray2D.ToString();
            txtSumArray3D.Text = additionArray3D.ToString();
        }

        
        private void FillArray(int[] arrangement)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrangement.Length; i++)
            {
                arrangement[i] = rnd.Next(1, 100); 
            }
        }

        
        private void FillArray(int[,] arrangement)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrangement.GetLength(0); i++)
            {
                for (int j = 0; j < arrangement.GetLength(1); j++)
                {
                    arrangement[i, j] = rnd.Next(1, 100); 
                }
            }
        }

        
        private void FillArray(int[,,] arrangement)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrangement.GetLength(0); i++)
            {
                for (int j = 0; j < arrangement.GetLength(1); j++)
                {
                    for (int k = 0; k < arrangement.GetLength(2); k++)
                    {
                        arrangement[i, j, k] = rnd.Next(1, 100); 
                    }
                }
            }
        }

       
        private void ShowArrangement(TextBox textBox, int[] arrangement)
        {
            textBox.Clear();
            foreach (var item in arrangement)
            {
                textBox.AppendText(item.ToString() + " ");
            }
        }

        
        private void ShowArrangement(TextBox textBox, int[,] arrangement)
        {
            textBox.Clear();
            for (int i = 0; i < arrangement.GetLength(0); i++)
            {
                for (int j = 0; j < arrangement.GetLength(1); j++)
                {
                    textBox.AppendText(arrangement[i, j].ToString() + " ");
                }
                textBox.AppendText(Environment.NewLine);
            }
        }

        
        private void ShowArrangement(TextBox textBox, int[,,] arrangement)
        {
            textBox.Clear();
            for (int i = 0; i < arrangement.GetLength(0); i++)
            {
                for (int j = 0; j < arrangement.GetLength(1); j++)
                {
                    for (int k = 0; k < arrangement.GetLength(2); k++)
                    {
                        textBox.AppendText(arrangement[i, j, k].ToString() + " ");
                    }
                    textBox.AppendText(Environment.NewLine);
                }
                textBox.AppendText(Environment.NewLine);
            }
        }

        
        private int AddArray(int[] arrangement)
        {
            int addition = 0;
            foreach (var item in arrangement)
            {
                addition += item;
            }
            return addition;
        }

       
        private int AddArray(int[,] arrangement)
        {
            int addition = 0;
            for (int i = 0; i < arrangement.GetLength(0); i++)
            {
                for (int j = 0; j < arrangement.GetLength(1); j++)
                {
                    addition += arrangement[i, j];
                }
            }
            return addition;
        }

        
        private int AddArray(int[,,] arrangement)
        {
            int addition = 0;
            for (int i = 0; i < arrangement.GetLength(0); i++)
            {
                for (int j = 0; j < arrangement.GetLength(1); j++)
                {
                    for (int k = 0; k < arrangement.GetLength(2); k++)
                    {
                        addition += arrangement[i, j, k];
                    }
                }
            }
            return addition;
        }
    }
}
