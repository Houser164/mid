public class CurrentStudent : People
{
    private string admin;
    private string password;
    public string StudentID;
    public CurrentStudent 
    (
    string prefixName,
    string name,
    string surName,
    string StudentID,
    string age,
    string religion,
    string allergy,
    string admin,
    string password
    )
    
    : base(prefixName, name, surName, age, religion, allergy)
    {
        this.StudentID = StudentID;
        this.StudentID = admin;
        this.StudentID = password;
    }
    public string GetStudentID(){
    return this.StudentID;}
    public string Getadmin(){
    return this.admin;}
    public string Getpassword(){
    return this.password;}

     public CurrentStudent (
    string prefixName,
    string name,
    string surName,
    string StudentID,
    string age,
    string religion,
    string allergy)

    : base(prefixName, name, surName, age, religion, allergy)
    {
        this.StudentID = StudentID;
    }
    

}