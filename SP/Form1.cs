namespace SP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo("calc.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myProcess.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //закрытие процесса
            myProcess.CloseMainWindow();
            //очистка ресурсов зарезервированных процессом
            myProcess.Close();
        }
    }
}