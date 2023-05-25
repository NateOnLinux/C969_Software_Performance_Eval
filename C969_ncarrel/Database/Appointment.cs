using System;
using System.Linq;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Windows.Forms;

namespace C969_ncarrel.Database
{
    public class Appointment : Connection
    {
        //all vars are named the exact same as in the database for readability
        public int appointmentId;
        public int customerId;
        public int userId;
        public string title;
        public string description;
        public string location;
        public string contact;
        public string type;
        public string url;
        public DateTime start;
        public DateTime end;

        QueryDB ApptConnection;
        BindingList<Appointment> blAppointments;
        public bool ConflictCheck(int appointmentId, DateTime start, DateTime end) //NOTE `start` & `end` are both Utc. 
        {
            TimeSpan startHours = new TimeSpan(8, 0, 0); //THIS IS LOCAL
            TimeSpan endHours = new TimeSpan(18, 0, 0); //THIS IS LOCAL
            //start.Second and end.Second should == 0 here but type 'TimeSpan' is easier to work with in this context anyways
            TimeSpan apptStart = new TimeSpan(start.ToLocalTime().Hour,start.ToLocalTime().Minute,0);
            TimeSpan apptEnd = new TimeSpan(end.ToLocalTime().Hour,end.ToLocalTime().Minute,0);
            var userId = C969_ncarrel.Login.mainScreen.UserId;
            var sqlString =
                $"SELECT appointmentId FROM appointment WHERE NOT appointmentId = '{appointmentId}' AND userId = {userId} AND start <= '{end:yyyy-MM-dd HH:mm:ss}' AND end >= '{start:yyyy-MM-dd HH:mm:ss}'";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                var conflictAppt = Convert.ToInt32(reader.GetValue(0));
                if (appointmentId == conflictAppt)
                    return false;
                MessageBox.Show($"There is a time conflict with Appointment {conflictAppt}. Please select a different time.\nYour appointment was not saved.", "New Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reader.Close();
                return true;
            }
            else 
            if (apptEnd < apptStart)
            {
                MessageBox.Show($"Start time cannot be after End time.\nYour appointment was not saved.", "New Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                reader.Close();
                return true;
            }
            else
            if (apptStart < startHours || apptStart > endHours || apptEnd < startHours || apptEnd > endHours)
            {
                MessageBox.Show($"The time range {apptStart:g} - {apptEnd:g} does not fall within the set business hours of 8:00 - 18:00");
                reader.Close();
                return true;
            }
            else
            {
                if (end.Date != start.Date) //Appointments spanning multiple days aren't mentioned in the requirements, so I'm not allowing them.
                {
                    MessageBox.Show("Appointments must start and end on the same day.\nYour appointment was not saved.", "New Appointment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
        }

        public bool CheckNext15()
        {
            var userId = C969_ncarrel.Login.mainScreen.UserId;
            var sqlString = 
                $"SELECT a.customerName,a.customerId,b.userId,b.start "
                + $"FROM customer a "
                + $"LEFT JOIN appointment b on a.customerId = b.customerId "
                + $"WHERE userId={userId} "
                + $"AND (start<'{DateTime.Now.AddMinutes(15).ToUniversalTime():yyyy-MM-dd HH:mm:ss}' " //Add 15 minutes to DateTime.Now then convert the time to Utc
                + $"AND start>'{DateTime.Now.ToUniversalTime():yyyy-MM-dd HH:mm:ss}')";
            cmd = new MySqlCommand(sqlString, connection);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                MessageBox.Show($"You have an appointment with {reader.GetValue(0)} at {DateTime.Parse(reader.GetValue(3).ToString()).ToLocalTime():HH:mm} today");
                reader.Close();
                return true;
            }
            else
            {
                reader.Close();
                return false;
            }
        }
        
        public bool Create(Appointment newAppointment)
        {
            var userName = new User().GetUserName(C969_ncarrel.Login.mainScreen.UserId);
            var sqlString =
                $"INSERT INTO appointment(customerId,userId,title,description,location,contact,type,url,start,end,createDate,createdBy,lastUpdate,lastUpdateBy) "
                + $"VALUES ({newAppointment.customerId},{newAppointment.userId},'{MySqlHelper.EscapeString(newAppointment.title)}',"
                + $"'{MySqlHelper.EscapeString(newAppointment.description)}','{MySqlHelper.EscapeString(newAppointment.location)}',"
                + $"'{MySqlHelper.EscapeString(newAppointment.contact)}','{MySqlHelper.EscapeString(newAppointment.type)}',"
                + $"'{MySqlHelper.EscapeString(newAppointment.url)}','{newAppointment.start:yyyy-MM-dd HH:mm:ss}'," //newAppointment.start and newAppointment.end have already been converted to Utc,
                + $"'{newAppointment.end:yyyy-MM-dd HH:mm:ss}',now(),'{userName}',now(),'{userName}');";            //all times writen to the database must be Utc
            ApptConnection = new QueryDB();
            try
            {
                if (ConflictCheck(-1, newAppointment.start, newAppointment.end)) //Creating a new appointment so just set apptId to -1 for conflict check
                    return false;
                else
                {
                    _ = ApptConnection.Query(sqlString);
                    return true;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Please check that all required fields have been filled. \n{e}");
                return false;
            }
        }

        public void Delete(int appointmentId)
        {
            //using appointmentID parameter, "DELETE FROM appointment WHERE appointmentId={appointmentID};
            ApptConnection = new QueryDB();
            string sqlString = $"DELETE FROM appointment WHERE appointmentId={appointmentId}";
            var warning = MessageBox.Show($"Are you sure you want to delete appointment {appointmentId}?", $"Delete {appointmentId}?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            switch (warning)
            {
                case DialogResult.Yes:
                    _ = ApptConnection.Query(sqlString);
                    MessageBox.Show($"Successfully deleted appointment {appointmentId}");
                    break;
                default:
                    MessageBox.Show($"No appointments were deleted");
                    break;
            }
        }

        public bool Update(int appointmentId, Appointment appointment)
        {
            try
            {
                ApptConnection = new QueryDB();
                var userName = new User().GetUserName(C969_ncarrel.Login.mainScreen.UserId);
                var sqlString = $"UPDATE appointment SET customerId={appointment.customerId},title='"
                    + MySqlHelper.EscapeString(appointment.title)
                    + "',description='"
                    + MySqlHelper.EscapeString(appointment.description)
                    + "',location='"
                    + MySqlHelper.EscapeString(appointment.location)
                    + "',contact='"
                    + MySqlHelper.EscapeString(appointment.contact)
                    + "',type='"
                    + MySqlHelper.EscapeString(appointment.type)
                    + "',url='"
                    + MySqlHelper.EscapeString(appointment.url)
                    + $"',start='{appointment.start:yyyy-MM-dd HH:mm:ss}',end='{appointment.end:yyyy-MM-dd HH:mm:ss}',lastUpdate=now(),lastUpdateBy='{userName}' " //The start/end times here are already Utc
                    + $"WHERE appointmentId={appointmentId};";
                if (ConflictCheck(appointmentId, appointment.start, appointment.end))
                    return false;
                else
                {
                    _ = ApptConnection.Query(sqlString);
                    return true;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show($"Please check that all required fields have been filled. \n{e}");
                return false;
            }
        }

        public BindingList<Appointment> GetAppointments()
        {
            ApptConnection = new QueryDB();
            blAppointments = new BindingList<Appointment>();
            string sqlString = "SELECT * FROM appointment";
            var dataIn = ApptConnection.Query(sqlString);
            foreach (var collumnIn in dataIn)
            {
                var appointment = new Appointment();

                appointment.appointmentId = int.Parse(collumnIn[0]);
                appointment.customerId = int.Parse(collumnIn[1]);
                appointment.userId = int.Parse(collumnIn[2]);
                appointment.title = collumnIn[3];
                appointment.description = collumnIn[4];
                appointment.location = collumnIn[5];
                appointment.contact = collumnIn[6];
                appointment.type = collumnIn[7];
                appointment.url = collumnIn[8];
                appointment.start = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(collumnIn[9]), TimeZoneInfo.Local);
                appointment.end = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(collumnIn[10]), TimeZoneInfo.Local);
                blAppointments.Add(appointment);
            }
            return blAppointments;
        }

        public Appointment GetAppointments(int appointmentId) //Get a specific appointment if given the ID
        {
            ApptConnection = new QueryDB();
            string sqlString = $"SELECT * FROM appointment WHERE appointmentId={appointmentId};";
            var dataIn = ApptConnection.Query(sqlString);
            var appointment = new Appointment();
            foreach (var collumnIn in dataIn) //alternatively, "appointment.(field) = dataIn[0][i];"
            {
                appointment.appointmentId = int.Parse(collumnIn[0]);
                appointment.customerId = int.Parse(collumnIn[1]);
                appointment.userId = int.Parse(collumnIn[2]);
                appointment.title = collumnIn[3];
                appointment.description = collumnIn[4];
                appointment.location = collumnIn[5];
                appointment.contact = collumnIn[6];
                appointment.type = collumnIn[7];
                appointment.url = collumnIn[8];
                appointment.start = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(collumnIn[9]), TimeZoneInfo.Local);
                appointment.end = TimeZoneInfo.ConvertTimeFromUtc(DateTime.Parse(collumnIn[10]), TimeZoneInfo.Local);
            }
            return appointment;
        }
    }
}
