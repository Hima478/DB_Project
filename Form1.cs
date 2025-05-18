namespace Conference_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConference_Click(object sender, EventArgs e)
        {
            ConferenceForm conferenceForm = new ConferenceForm();
            this.Hide();
            conferenceForm.Show();
            conferenceForm.FormClosed += (s, args) => this.Show(); // Show the main form when the conference form is closed

        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            SessionForm sessionForm = new SessionForm();
            this.Hide();
            sessionForm.Show();
            sessionForm.FormClosed += (s, args) => this.Show(); // Show the main form when the session form is closed
        }
    }
}
