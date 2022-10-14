using System.Collections.Generic;
using System;
class PeopleList {
    private List<People> peopleList;
    public PeopleList() {
        this.peopleList = new List<People>();
    }

    public void AddNewPerson(People people) {
        this.peopleList.Add(people);
    }

    public void FetchPersonList() {
        Console.WriteLine("List People");
        Console.WriteLine("************");

        foreach(People people in this.peopleList) {
            if (people is Student) {
                Console.WriteLine("Name {0} \n Type: Student \n", people.GetName());
            } else if (people is Teacher) {
                Console.WriteLine("Name {0} \n Type: Teacher \n", people.GetName());
            }
        }
    }
}
