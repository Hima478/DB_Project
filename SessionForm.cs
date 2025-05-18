using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conference_Management_System
{
    public partial class SessionForm : Form
    {
        public SessionForm()
        {
            InitializeComponent();
            readSessions();

        }
        private void readSessions()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SESSION ID");
            dt.Columns.Add("SESSION LOCATION");
            dt.Columns.Add("CONFERENCE YEAR");
            dt.Columns.Add("CONFERENCE CITY");
            dt.Columns.Add("CONFERENCE LOCATION");
            dt.Columns.Add("CHAIRMAN NAME");
            dt.Columns.Add("CHAIRMAN ID");
            dt.Columns.Add("START TIME");
            dt.Columns.Add("END TIME");

            var repo = new Repos.SessionRepo();
            var sessions = repo.GetSessions();
            foreach (var session in sessions)
            {
                dt.Rows.Add(session.SESSIONID, session.SESSION_LOCATION, session.YEAR, session.CITY, session.LOCATION, session.NAME, session.CHAIRMANID, session.START_TIME, session.END_TIME);
            }
            this.sessionTable.DataSource = dt;
        }

        private void btnAddSession_Click(object sender, EventArgs e)
        {
            CreateSession createSession = new CreateSession();
            if (createSession.ShowDialog() == DialogResult.OK)
            {
                readSessions();
            }
        }

        private void btnSearchSession_Click(object sender, EventArgs e)
        {
            SearchSession searchSession = new SearchSession();
            searchSession.ShowDialog();
        }
    }
}
