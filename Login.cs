using System.Collections.Generic;
using System;

public class Login
{
    static Register Test = new Register();
    //เลือกเมนูคนยังไม่่ login
    enum FirstNotLogin
    {
    Register = 1,
    ShowAttendanceStatistics,
    Login
    }

   public string NotLogin(){
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please enter what you want to do.");
        Console.WriteLine("1 = Register");
        Console.WriteLine("2 = Show Attendance Statistics");
        Console.WriteLine("3 = Login");
        FirstNotLogin selectNotLogin = (FirstNotLogin)int.Parse(Console.ReadLine());
        switch (selectNotLogin) {
            case FirstNotLogin.Register:
                return "Register";
                break;
            case FirstNotLogin.ShowAttendanceStatistics:
                return "Show Attendance Statistics";
                break;
            case FirstNotLogin.Login:
                return "Login";
                break;
            default:
                break;
        }
        return "Error";
 }

    //เลือกเมนูคนlogin แล้ว
    enum FirstAlreadyLogin
    {
    Register = 1,
    Show_all_current_students,
    Show_all_students, 
    Show_all_teacher,
    LogOut
    }

   public string AlreadyLogin()
   {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please enter what you want to do.");
        Console.WriteLine("1 = Register");
        Console.WriteLine("2 = Show all current students participating in the program.");
        Console.WriteLine("3 = Show all student participating in the program.");
        Console.WriteLine("4 = Show all teacher participating in the program.");
        Console.WriteLine("5 = LogOut");
        FirstAlreadyLogin selectAlreadyLogin = (FirstAlreadyLogin)int.Parse(Console.ReadLine());
        switch (selectAlreadyLogin) 
        {
            case FirstAlreadyLogin.Register:
                Test.Check();
                return "Register";
                break;
            case FirstAlreadyLogin.Show_all_current_students:
                return "Show all current students participating in the program.";
                break;
            case FirstAlreadyLogin.Show_all_students:
                return "Show all student participating in the program.";
                break;
            case FirstAlreadyLogin.Show_all_teacher:
                return "Show all teacher participating in the program.";
                break;
            case FirstAlreadyLogin.LogOut:
                return "LogOut";
                break;
            default:
                break;
        }
        return "Error";
    }

    public void Login1()
    {
        Console.WriteLine("Did you already login? (yes / no) : ");
        String login =  Console.ReadLine();
         if (login == "yes")
        {     
            Console.Clear();
        AlreadyLogin();
        }
        else if (login == "no") 
        {
            Console.Clear();
        NotLogin();
        }
        else 
        {
        Console.WriteLine("error :(");
        }

    }

    //1.1.3 เลือกเมนูหลัก
    enum FirstMain_Menu
    {
    login_menu = 1,
    Registration_for_the_event,
    The_menu_shows_the_statistics_of_the_participants, 
    The_menu_shows_all_current_students_participating_in_the_program,
    The_menu_shows_all_students_participating_in_the_program,
    The_menu_shows_all_teacher_participating_in_the_program,
    logOut_menu

    }
     public string Main_Menu()
   {
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please enter what you want to do.");
        Console.WriteLine("1 = Login menu");
        Console.WriteLine("2 = Registration for the event");
        Console.WriteLine("3 = The menu shows the statistics of the participants.");
        Console.WriteLine("4 = The menu shows all current students participating in the program.");
        Console.WriteLine("5 = The menu shows all students participating in the program.");
        Console.WriteLine("6 = The menu shows all teacher participating in the program.");
        Console.WriteLine("7 = LogOut");
        FirstMain_Menu selectMain_Menu = (FirstMain_Menu)int.Parse(Console.ReadLine());
        switch (selectMain_Menu) 
        {
            case FirstMain_Menu.login_menu:
                return "login_menu";
                break;
            case FirstMain_Menu.Registration_for_the_event:
            Test.Check();
                return "Registration for the event";
                break;
            case FirstMain_Menu.The_menu_shows_the_statistics_of_the_participants:
                return "The menu shows the statistics of the participants.";
                break;
            case FirstMain_Menu.The_menu_shows_all_current_students_participating_in_the_program:
                return "The menu shows all current students participating in the program.";
                break;
            case FirstMain_Menu.The_menu_shows_all_students_participating_in_the_program:
                return "The menu shows all students participating in the program.";
                break;
            case FirstMain_Menu.The_menu_shows_all_teacher_participating_in_the_program:
                return "The menu shows all teacher participating in the program.";
                break;
            case FirstMain_Menu.logOut_menu:
                return "login_menu";
                break;
            default:
                break;
        }
        return "Error";
    }






}