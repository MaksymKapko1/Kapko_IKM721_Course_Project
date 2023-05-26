namespace Kapko_IKM721_Course_Project
{
    public partial class Form1 : Form
    {
        private bool Mode;
        private MajorWork MajorObject;
        public Form1()
        {
            InitializeComponent();
        }

        private void tClock_Tick(object sender, EventArgs e)
        {
            tClock.Stop();
            MessageBox.Show("������ 25 ������", "�����");
            tClock.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            About A = new About(); 

            A.tAbout.Start();
            A.ShowDialog();
        
            MajorObject = new MajorWork();
            this.Mode = true;
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                MajorObject.Write(tbInput.Text);
                MajorObject.Task();
                label1.Text = MajorObject.Read();
                tbInput.Enabled = true;
                tbInput.Focus();
                tClock.Start();
                bStart.Text = "����";
                this.Mode = false;
            }
            else
            {
                tbInput.Enabled = false;
                tClock.Stop();
                bStart.Text = "����";
                this.Mode = true;
            }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            tClock.Stop();
            tClock.Start();
            if ((e.KeyChar >= '0') & (e.KeyChar <= '9') | (e.KeyChar == (char)8))
            {
                return;
            }
            else
            {
                tClock.Stop();
                MessageBox.Show("������������ ������", "�������");
                tClock.Start();
                e.KeyChar = (char)0;
            }
        }
    }
}