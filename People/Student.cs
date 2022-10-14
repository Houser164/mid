public class Student : People
{
    public string LevelOfEducation;
    public string School;

    public Student (string prefixName,
    string name,
    string surName,
    string age,
    string religion,
     string allergy,
     string LevelOfEducation, 
    string School)
    : base(prefixName, name, surName, age, religion, allergy)

    {
        this.LevelOfEducation = LevelOfEducation;
    
        this.School = School;
    }

    public string GetLevelOfEducation(){
    return this.LevelOfEducation;}

    public string GetSchool(){
    return this.School;}


}