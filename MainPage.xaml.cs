namespace TouchBugSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        int test1Count = 0, test2Count = 0;
        private void TestBtn1_Clicked(object sender, EventArgs e)
        {
            test1Count++;
            lblT1.Text = test1Count.ToString();
        }
        private void TestBtn2_Clicked(object sender, EventArgs e)
        {
            test2Count++;
            lblT2.Text = test2Count.ToString();
        }
    }

}
