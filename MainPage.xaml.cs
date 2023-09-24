using SQLite;

namespace UNDAC_App
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            StartDBconn();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        public void StartDBconn()
        {
            var systempath = AppDomain.CurrentDomain.BaseDirectory;
            var fullpath = Path.Combine(systempath, "UNDAC.db");

            string filename = "UNDAC.db";
            SQLiteConnection conn = new SQLiteConnection(fullpath);

            DBmessage.Text = "Database File & Connection created successfully!";
        }
    }
}