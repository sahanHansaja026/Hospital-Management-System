# Hospital Management System - WinForms (.NET) + SQL Server

This project is a Windows Forms-based Hospital Management System developed using the .NET Framework (C#) and connected to Microsoft SQL Server. It is designed to manage various operations in a hospital such as managing patients, doctors, staff, appointments, reports, and more.

----------------------------------------

**Project Structure:**

Main files and their purposes:

- Program.cs – Main entry point of the application.
- Login.cs – Handles user login process.
- Landing.cs – Landing page after successful login.
- control panel.cs – Main dashboard to access all modules.
- Doctors.cs – Manage doctor-related information.
- Staff.cs – Manage staff information.
- Patients.cs – Register and manage patient data.
- appoiment.cs – Schedule and manage appointments.
- searchappoiments.cs – Search and filter appointments.
- Report.cs – View and generate medical or patient reports.
- searchreport.cs – Search for specific reports.
- Department.cs – Manage different hospital departments.
- users.cs – Manage system users.
- userinput.cs – Collect and validate user input.
- Function.cs – Contains reusable functions like database connection handling.
- Error.cs – Display or log system errors.
- DView.cs, Pview.cs, Rview.cs, Sview.cs, aview.cs – Different data view components for doctors, patients, reports, staff, and appointments.
- searchDoctor.cs, searchpatients.cs, SearchStaff.cs – Search interfaces for different entities.

----------------------------------------

**Technologies Used:**

Frontend: Windows Forms (.NET Framework)

Backend: C#

Database: Microsoft SQL Server

IDE: Visual Studio

----------------------------------------

**Key Features:**

- User login system with role-based access
- Patient, Doctor, Staff registration and management
- Appointment scheduling and management
- Department management
- Report generation and viewing
- Search functionality across all modules
- Error handling interface
- Central control panel/dashboard

----------------------------------------

**How to Set Up the Project:**

1. Clone or download the project to your local machine.

2. Open the solution file (.sln) in Visual Studio.

3. Set up the SQL Server:
   - Create a new database (e.g., HospitalDB).
   - Use a provided SQL script to create tables (if available).
   - Update your SQL connection string inside Function.cs:
     Example:
     string connStr = "Data Source=YOUR_SERVER_NAME;Initial Catalog=HospitalDB;Integrated Security=True;";

4. Build the project and run the application.

----------------------------------------

🎬 Video Playlist (YouTube):
You can watch the complete video series that explains how this system works and how it was developed:
Watch the playlist here

https://www.youtube.com/playlist?list=PLnzcX5Om_yrofuYpQ7CkE3k9FQOv5UWbr

----------------------------------------

**Author:**

Madawala Maddumage Sahan Hansaja  
Email: sahanhansaja026@gmail.com  
Institution: SLTC Research University
