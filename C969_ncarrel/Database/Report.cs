using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace C969_ncarrel.Database
{
    public class Report : Connection
    {
        //private string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), DateTime.UtcNow.ToString("yyyyMMdd-HHmmss") + ".report");
        private QueryDB ReportConnecton;
        private readonly Appointment Appointments = new Appointment();
        private readonly Customer Customers = new Customer();
        private BindingList<Appointment> ListAppointments;
        private BindingList<Customer> ListCustomers;
        public void GenerateReport()
        {
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\reports\ ");
            var FileName = DateTime.UtcNow.ToString("yyyyMMdd-HHmmss") + ".report";
            var FileLocation = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\reports\";
            ListAppointments = Appointments.GetAppointments();
            ListCustomers = Customers.GetCustomers();
            //I tried sharing a single FileStream for all 3 methods however the object gets disposed within the StreamWriter
            GetAppointmentsMonthly(new FileStream(Path.Combine(FileLocation, FileName),FileMode.Append, FileAccess.Write));
            GetConsultantSchedules(new FileStream(Path.Combine(FileLocation, FileName), FileMode.Append, FileAccess.Write));
            GetCustomerCountries(new FileStream(Path.Combine(FileLocation, FileName), FileMode.Append, FileAccess.Write));
        }
        public void GetAppointmentsMonthly(FileStream Path)
        {
            var occurrencesByMonth = new Dictionary<string, int>();
            using (StreamWriter reports = new StreamWriter(Path))
            {
                reports.WriteLine("##Apointments per month:");
                // I used a Lambda expression here to parse the elements of ListAppointments with "ToList().ForEach((a) => {});"
                ListAppointments.ToList().ForEach(a =>
                {
                    var month = new System.Globalization.DateTimeFormatInfo().GetMonthName(a.start.Month).ToString();
                    if (occurrencesByMonth.ContainsKey(month))
                        occurrencesByMonth[month]++;
                    else
                        occurrencesByMonth[month] = 1;
                });
                foreach (var monthKey in occurrencesByMonth)
                    reports.WriteLine($"{monthKey.Key}: {monthKey.Value}");
            }            
        }
        public void GetConsultantSchedules(FileStream Path)
        {
            var consultantSchedules = new Dictionary<string, List<Appointment>>();
            ReportConnecton = new QueryDB();
            var sqlString = "SELECT userId,userName FROM user";
            var consultantList = ReportConnecton.Query(sqlString);
            var users = new List<User>();
            foreach (var consultant in consultantList)
            {
                var user = new User();
                user.userId = int.Parse(consultant[0]);
                user.userName = consultant[1];
                users.Add(user);
            }
            using (StreamWriter reports = new StreamWriter(Path))
            {
                reports.WriteLine("\n\n##Consultant Schedules:");
                ListAppointments = Appointments.GetAppointments();
                users.ForEach(u =>
                {
                    ListAppointments.ToList().ForEach(a =>
                    {
                        if (u.userId == a.userId)
                        {
                            List<Appointment> appointmentLists = new List<Appointment>();

                            if (consultantSchedules.ContainsKey(u.userName))
                                consultantSchedules[u.userName].Add(a);
                            else
                            {
                                appointmentLists.Add(a);
                                consultantSchedules[u.userName] = appointmentLists;
                            }
                        }
                    });
                });
                Func<List<Appointment>, string> GetAppointments = lA =>
                {
                    var outString = $"User ID: {lA[0].userId}\nTitle | Customer | Type | Start | End\n";
                    lA.ForEach(a =>
                    {
                        outString += $"{a.title} | {a.customerId} | {a.type} |{a.start:G} | {a.end:G}\n";
                    });
                    return outString;
                };
                foreach (var userKey in consultantSchedules)
                {
                    reports.WriteLine(GetAppointments(userKey.Value));
                }
            }
        }
        public void GetCustomerCountries(FileStream Path)
        {
            ReportConnecton = new QueryDB();
            var sqlString = "SELECT countryId,country FROM country";
            var listList = ReportConnecton.Query(sqlString);
            var countryList = new List<Country>();
            foreach (var listCountry in listList)
            {
                var country = new Country();
                country.countryId = int.Parse(listCountry[0]);
                country.country = listCountry[1];
                countryList.Add(country);
            }
            using(StreamWriter reports = new StreamWriter(Path))
            {
                reports.WriteLine($"\n##Customers per Country:");
                var countryByCustomers = new Dictionary<string,int>();
                countryList.ToList().ForEach(c =>
                {
                    if (countryByCustomers.ContainsKey(c.country))
                        countryByCustomers[c.country]++;
                    else
                        countryByCustomers[c.country] = 1;
                });
                foreach (var countryKey in countryByCustomers)
                    reports.WriteLine($"{countryKey.Key}: {countryKey.Value}");
            }
        }
    }
}
