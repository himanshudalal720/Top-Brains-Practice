using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalManagementSystem
{
    // Custom Exceptions


    class DoctorNotAvailableException : Exception
    {
        public DoctorNotAvailableException(string message) : base(message) { }
    }

    class InvalidAppointmentException : Exception
    {
        public InvalidAppointmentException(string message) : base(message) { }
    }

    class PatientNotFoundException : Exception
    {
        public PatientNotFoundException(string message) : base(message) { }
    }

    class DuplicateMedicalRecordException : Exception
    {
        public DuplicateMedicalRecordException(string message) : base(message) { }
    }

    // Interface for Billing

    interface IBillable
    {
        double CalculateBill();
    }

    // Base Class: Person

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Doctor Class

    class Doctor : Person, IBillable
    {
        public string Specialization { get; set; }
        public double ConsultationFee { get; set; }
        public int TotalAppointments { get; set; }

        public double CalculateBill()
        {
            return ConsultationFee;
        }
    }

    // Patient Class

    class Patient : Person
    {
        public string Disease { get; set; }
    }

    // Medical Record (Encapsulation)

    class MedicalRecord
    {
        private string diagnosis;

        public int RecordId { get; set; }
        public int PatientId { get; set; }

        public string Diagnosis
        {
            get { return diagnosis; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Diagnosis cannot be empty");
                diagnosis = value;
            }
        }
    }

    // Appointment Class

    class Appointment
    {
        public int AppointmentId { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppointmentDate { get; set; }
    }

    // Program

    class Program
    {
        static List<Doctor> doctors = new List<Doctor>();
        static List<Patient> patients = new List<Patient>();
        static List<Appointment> appointments = new List<Appointment>();
        static Dictionary<int, MedicalRecord> medicalRecords = new Dictionary<int, MedicalRecord>();

        static void Main()
        {
            SeedData();

            try
            {
                ScheduleAppointment(1, 1, DateTime.Now.AddDays(1));
                ScheduleAppointment(1, 2, DateTime.Now.AddDays(2));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            RunLINQQueries();

            Console.ReadLine();
        }

        // Seed Initial Data

        static void SeedData()
        {
            doctors.Add(new Doctor { Id = 1, Name = "Dr. Sharma", Specialization = "Cardiology", ConsultationFee = 1000 });
            doctors.Add(new Doctor { Id = 2, Name = "Dr. Mehta", Specialization = "Neurology", ConsultationFee = 1500 });

            patients.Add(new Patient { Id = 1, Name = "Amit", Disease = "Heart Disease" });
            patients.Add(new Patient { Id = 2, Name = "Ravi", Disease = "Migraine" });
        }

        // Appointment Scheduling

        static void ScheduleAppointment(int doctorId, int patientId, DateTime date)
        {
            var doctor = doctors.FirstOrDefault(d => d.Id == doctorId);
            var patient = patients.FirstOrDefault(p => p.Id == patientId);

            if (doctor == null)
                throw new DoctorNotAvailableException("Doctor not found");

            if (patient == null)
                throw new PatientNotFoundException("Patient not found");

            // Prevent overlapping (same doctor, same time)
            bool overlap = appointments.Any(a =>
                a.Doctor.Id == doctorId &&
                a.AppointmentDate == date);

            if (overlap)
                throw new InvalidAppointmentException("Doctor already has appointment at this time");

            var appointment = new Appointment
            {
                AppointmentId = appointments.Count + 1,
                Doctor = doctor,
                Patient = patient,
                AppointmentDate = date
            };

            appointments.Add(appointment);
            doctor.TotalAppointments++;

            Console.WriteLine("Appointment Scheduled Successfully");
        }

        // LINQ Queries

        static void RunLINQQueries()
        {
            Console.WriteLine("\n--- Doctors with more than 0 appointments ---");
            var busyDoctors = doctors.Where(d => d.TotalAppointments > 0);
            foreach (var d in busyDoctors)
                Console.WriteLine(d.Name);

            Console.WriteLine("\n--- Patients treated in last 30 days ---");
            var recentPatients = appointments
                .Where(a => a.AppointmentDate >= DateTime.Now.AddDays(-30))
                .Select(a => a.Patient.Name)
                .Distinct();

            foreach (var p in recentPatients)
                Console.WriteLine(p);

            Console.WriteLine("\n--- Group Appointments by Doctor ---");
            var groupByDoctor = appointments.GroupBy(a => a.Doctor.Name);

            foreach (var group in groupByDoctor)
                Console.WriteLine($"{group.Key} - {group.Count()} appointments");

            Console.WriteLine("\n--- Top 3 Highest Earning Doctors ---");
            var topDoctors = doctors
                .OrderByDescending(d => d.TotalAppointments * d.ConsultationFee)
                .Take(3);

            foreach (var d in topDoctors)
                Console.WriteLine($"{d.Name} - Earnings: {d.TotalAppointments * d.ConsultationFee}");

            Console.WriteLine("\n--- Patients by Disease (Heart Disease) ---");
            var heartPatients = patients.Where(p => p.Disease == "Heart Disease");
            foreach (var p in heartPatients)
                Console.WriteLine(p.Name);

            Console.WriteLine("\n--- Total Revenue ---");
            double totalRevenue = doctors.Sum(d => d.TotalAppointments * d.ConsultationFee);
            Console.WriteLine(totalRevenue);

            Console.WriteLine("\n--- Appointment Report ---");
            var report = appointments.Select(a => new
            {
                DoctorName = a.Doctor.Name,
                PatientName = a.Patient.Name,
                Date = a.AppointmentDate
            });

            foreach (var r in report)
                Console.WriteLine($"{r.DoctorName} treated {r.PatientName} on {r.Date}");
        }
    }
}
