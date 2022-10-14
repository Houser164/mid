public class People
{
    public string prefixName;
    public string name;
    public string surName;
    public string age;
    public string religion;
    public string allergy;

    public People (string prefixName, 
    string name, 
    string surName, 
    string age,
    string religion,
    string allergy )
    
    {
        this.prefixName = prefixName;
    
        this.name = name;
    
        this.surName = surName;
    
        this.age = age;
    
        this.religion = religion;
    
        this.allergy = allergy;
    }
    public string GetPrefixName(){
    return this.prefixName;}

    public string GetName(){
    return this.name;}

    public string GetsurName(){
    return this.surName;}

    public string Getage(){
    return this.age;}

    public string Getreligion(){
    return this.religion;}

    public string Getallergy(){
    return this.allergy;}

}