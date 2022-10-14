public class Teacher : People 
{
    private string Position;
    private string Car;
    private int CarId;
    private string admin;
    private string password;

// admin && car
     public Teacher (string prefixName, 
    string name,
    string surName,
    string age,
    string religion,
     string allergy,
     string Position,
      string Car, 
      int CarId,
      string admin,
      string password)
    : base(prefixName, name, surName, age, religion, allergy)
    {
        this.Position = Position;
        this.Car = Car;
        this.CarId = CarId;
        this.admin = admin;
        this.password = password;
    }

    public string GetPosition(){
    return this.Position;}
    public string GetCar(){
    return this.Car;}
    public int GetCarId(){
    return this.CarId;}
    public string Getadmin(){
    return this.admin;}
    public string Getpassword(){
    return this.password;}

// admin != car
public Teacher (string prefixName,
    string name,
    string surName,
    string age,
    string religion,
     string allergy,
     string Position,
      string admin,
      string password)
    : base(prefixName, name, surName, age, religion, allergy)
    {
        this.Position = Position;
        this.admin = admin;
        this.password = password;
    }
// !admin && !car
public Teacher (string prefixName, 
    string name,
    string surName,
    string age,
    string religion,
     string allergy,
     string Position)
    : base(prefixName, name, surName, age, religion, allergy)
    {
        this.Position = Position;
    }
    // !admin && car
    public Teacher (string prefixName, 
    string name,
    string surName,
    string age,
    string religion,
     string allergy,
     string Position,
     string Car,
     int CarId)
    : base(prefixName, name, surName, age, religion, allergy)
    {
        this.Position = Position;
        this.Car = Car;
        this.CarId = CarId;
    }
}
 