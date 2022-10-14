public class Register
{
    //เลือกว่าเป็นอะไร CurrentStudent Student Teacher
    enum FirstOccupation
    {
    CurrentStudent = 1,
    Student,
    Teacher
    }

 public string Occupation(){
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please input your occupation");
        Console.WriteLine("1 = CurrentStudent");
        Console.WriteLine("2 = Student");
        Console.WriteLine("3 = Teacher");
        FirstOccupation selectOccupation = (FirstOccupation)int.Parse(Console.ReadLine());
        switch (selectOccupation) {
            case FirstOccupation.CurrentStudent:
                return "CurrentStudent";
                break;
            case FirstOccupation.Student:
                return "Student";
                break;
            case FirstOccupation.Teacher:
                return "Teacher";
                break;
            default:
                break;
        }
        return "Error";
 }
    
    
    //เลือกคำนำหน้า Mr Ms Mrs
    enum FirstPrefix 
    {
    Mr = 1,
    Ms,
    Mrs
    }

 public string Prefix(){
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please input your prefix");
        Console.WriteLine("1 = Mr.");
        Console.WriteLine("2 = Ms.");
        Console.WriteLine("3 = Mrs.");
        FirstPrefix selectPrefix = (FirstPrefix)int.Parse(Console.ReadLine());
        switch (selectPrefix) {
            case FirstPrefix.Mr:
                return "Mr.";
                break;
            case FirstPrefix.Ms:
                return "Ms.";
                break;
            case FirstPrefix.Mrs:
                return "Mrs.";
                break;
            default:
                break;
        }
        return "Error";
 }

   //เลือกศาสนา
    enum FirstReligion
    {   
    Buddhist = 1,
    Christ,
    Islam,
    ETC
    }

    public string religion(){
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please input your religion");
        Console.WriteLine("1 = Buddhist");
        Console.WriteLine("2 = Christ");
        Console.WriteLine("3 = Islam");
        Console.WriteLine("4 = ETC.");
        FirstReligion selectreligion = (FirstReligion)int.Parse(Console.ReadLine());
        switch (selectreligion) {
            case FirstReligion.Buddhist:
                return "Buddhist";
                break;
            case FirstReligion.Christ:
                return "Christ";
                break;
            case FirstReligion.Islam:
                return "Islam";
                break;
            case FirstReligion.ETC:
                return "ETC.";    
            default:
                break;
        }
        return "Error";
 }

 //เลือกชั้นปี
    enum FirstLevelOfEducation 
    {
    M4 = 1,
    M5,
    M6
    }

   public string LevelOfEducation(){
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please input your level of education");
        Console.WriteLine("1 = M.4");
        Console.WriteLine("2 = M.5");
        Console.WriteLine("3 = M.6");
        FirstLevelOfEducation selectLevelOfEducation = (FirstLevelOfEducation)int.Parse(Console.ReadLine());
        switch (selectLevelOfEducation) {
            case FirstLevelOfEducation.M4:
                return "M.4";
                break;
            case FirstLevelOfEducation.M5:
                return "M.5";
                break;
            case FirstLevelOfEducation.M6:
                return "M.6";
                break;
            default:
                break;
        }
        return "Error";
 }

 //เลือกตำแหน่ง
    enum FirstPosition
    {
    Dean = 1,
    head_of_department,
    full_time_teacher
    }

   public string Position(){
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("Please input your Position");
        Console.WriteLine("1 = Dean");
        Console.WriteLine("2 = head_of_department");
        Console.WriteLine("3 = full_time_teacher");
        FirstPosition selectPosition = (FirstPosition)int.Parse(Console.ReadLine());
        switch (selectPosition) {
            case FirstPosition.Dean:
                return "Dean";
                break;
            case FirstPosition.head_of_department:
                return "head of department";
                break;
            case FirstPosition.full_time_teacher:
                return "full time teacher";
                break;
            default:
                break;
        }
        return "Error";
 }



    public string name()
    {
        Console.Write("Please input your name : ");
        return Console.ReadLine(); 
    }

    public string surname()
    {
        Console.Write("Please input your surname : ");
        return Console.ReadLine(); 
    }

    public string studentID()
    {
        Console.Write("Please input your studentID : ");
        return Console.ReadLine(); 
    }

    public string age()
    {
        Console.Write("Please input your age : ");
        return Console.ReadLine(); 
    }

    public string allergy()
    {
        Console.Write("Please input your allergy : ");
        return Console.ReadLine(); 
    }


    public string School()
    {
        Console.Write("Please input your school : ");
        return Console.ReadLine(); 
    }


    public string Car()
    {
    Console.WriteLine("Did you drive your car? (yes / no) : ");
    String Car =  Console.ReadLine();
    if (Car == "yes") {    
        Console.WriteLine("What is your carId?");
        return "car";
    }
    else {
        return "no";
    }
    
    }

    public int CarId()
    {
        Console.Write("Please input your carID : ");
        return int.Parse(Console.ReadLine());
    }

    public string admin()
    {
    Console.WriteLine("Are you admin? (yes / no)");
    String admin =  Console.ReadLine();
    if (admin == "yes") {     
        return "admin";
    }
    else {
        return "notadmin";
    }
    }

    public string password()
    {
        Console.Write("Please input your password : ");
        return Console.ReadLine();

    }
      public string mail()
    {
        Console.Write("Please input your email : ");
        return Console.ReadLine();

    }

    public void Check ()

    {
        string adminx = admin();
        string carx = Car();


        if ( adminx == "admin" && carx == "car" ) 
        {
        //CurrentStudent currentStudent = new CurrentStudent (Prefix(), name(), surname(), studentID(), age(), allergy(), religion(), admin(), password());
        Teacher Teacher = new Teacher  (Prefix(), name(), surname(), age(), Position(), allergy(), religion(), Car(), CarId(), mail(), password());

        } else if ( admin() == "admin" && carx != "car")
        {
        //CurrentStudent currentStudent = new CurrentStudent (Prefix(), name(), surname(), studentID(), age(), allergy(), religion());
        Teacher Teacher = new Teacher  (Prefix(), name(), surname(), age(), Position(), allergy(), religion(), mail(), password());
        }
          else if ( admin() != "admin" && carx == "car") 
        {
        Teacher Teacher = new Teacher  (Prefix(), name(), surname(), age(), Position(), allergy(), religion(), Car(), CarId());

        } else if ( admin() != "admin" && carx != "car")
        {
        Teacher Teacher = new Teacher  (Prefix(), name(), surname(), age(), Position(), allergy(), religion());
        }
    }
    

    //  public void checkCar ()
    // {
    //     if ( Car() == "car") 
    //     {
    //     Teacher Teacher = new Teacher  (Prefix(), name(), surname(), age(), Position(), allergy(), religion(), admin(), password(), Car(), CarId());

    //     } else
    //     {
    //     Teacher Teacher = new Teacher  (Prefix(), name(), surname(), age(), Position(), allergy(), religion());
    //     }
    // }

    // public void checkAdmin_Car()
    // {
    //     if (!=admin() && !=Car())
    //     {
    //     Teacher Teacher = new Teacher  (Prefix(), name(), surname(), age(), Position(), allergy(), religion());
    //     }
    //     else if (!=admin() && Car() )
    //     {
            
    //     }
    // }

    // public Student ()
    // {
    //     Student Student = new Student (Prefix(), name(), surname(), age(), LevelOfEducation(), allergy(), religion(), School());
    // }

   
        
    }

   





 
 




