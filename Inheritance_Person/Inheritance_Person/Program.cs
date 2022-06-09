using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Person
{
    /*
     * 2.  Declare the abstract Person class that describes a human and the Student class that derives from Person. 
     * The attributes in each instance of type Person should include: name, age and id. 
     * The attributes in each instance of type Student should include, in addition to those that inherited from class Person, the attribute average. 
     * Create a third class Employee that inherits from Person but includes a field for department and company name. 
     * In the Person class, write an abstract method, ToString(), that returns the fields of an object. 
     * Write getters and setters for the attributes of all three classes. 
     * Then create a container to store Person objects and use the ToString() method to demonstrate how polymorphism works. (60 points)
     */
    public abstract class Person
    {
        private string name;
        private int age;
        private int id;
        private int x;
        private string y;
        private string z;

        //public Person(string newName, int newAge, int newID, int newX, string newY, string newZ)
        //{
        //    setName(newName);
        //    setAge(newAge);
        //    setID(newID);
        //    setX(newX);
        //    setY(newY);
        //    setZ(newZ);
        //} Left these constructors in because i was confused as to how they were used

        public void setName(string newName)
        {
            name = newName;
        }

        public void setAge(int newAge)
        {
            age = newAge;
        }

        public void setID(int newID)
        {
            id = newID;
        }

        public void setX(int newX)
        {
            x = newX;
        }

        public void setY(string newY)
        {
            y = newY;
        }

        public void setZ(string newZ)
        {
            z = newZ;
        }

        public string getName() { return name; }
        public int getAge() { return age; }
        public int getID() { return id; }
        public int getX() { return x; }
        public string getY() { return y; }
        public string getZ() { return z; }

        public abstract string ToString();
    }

    public class Student : Person
    {
        private string name;
        private int age;
        private int id;
        private int average;

        //public Student(string newName, int newAge, int newID, int newX, string newY, string newZ, int newAvg) : base(newName, newAge, newID, newX, newY, newZ)
        //{
        //    //setName(newName);
        //    //setAge(newAge);
        //    //setID(newID);
        //    setAvg(newAvg);
        //}

        public void setName(string newName)
        {
            name = newName;
        }

        public void setAge(int newAge)
        {
            age = newAge;
        }

        public void setID(int newID)
        {
            id = newID;
        }

        public void setAvg(int newAvg)
        {
            average = newAvg;
        }

        public string getName() { return name; }
        public int getAge() { return age; }
        public int getID() { return id; }
        public int getAvg() { return average; }

        public override string ToString()
        {
            string StudRet = "";
            StudRet = "Student Name: " + getName() + "\n" + "Student Age: " + getAge() + "\n" + "Student ID: " 
                + getID() + "\n" + "Student Average: " + getAvg() + "\n";
            return StudRet;

        }
    }

    public class Employee : Person
    {
        private string name;
        private int age;
        private int id;
        private string department;
        private string company;

        //public Employee(string newName, int newAge, int newID, int newX, string newY, string newZ, string newDept, string newComp) : base(newName, newAge, newID, newX, newY, newZ)
        //{
        //    setName(newName);
        //    setAge(newAge);
        //    setID(newID);
        //    setDept(newDept);
        //    setComp(newComp);
        //}

        public void setName(string newName)
        {
            name = newName;
        }

        public void setAge(int newAge)
        {
            age = newAge;
        }

        public void setID(int newID)
        {
            id = newID;
        }

        public void setDept(string newDept)
        {
            department = newDept;
        }

        public void setComp(string newComp)
        {
            company = newComp;
        }

        public string getName() { return name; }
        public int getAge() { return age; }
        public int getID() { return id; }
        public string getDept() { return department; }
        public string getComp() { return company; }

        public override string ToString()
        {
            string EmpRet = "";
            EmpRet = "Employee Name: " + getName() + "\n" + "Employee Age: " + getAge() + "\n" + "Employee ID: " + getID() + "\n" 
                + "Employee Department: " + getDept() + "\n" + "Company: " + getComp();
            return EmpRet;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setName("Eric");
            s1.setAge(25);
            s1.setID(1);
            s1.setAvg(5);
            s1.ToString();
            Console.WriteLine(s1.ToString());

            Employee e1 = new Employee();
            e1.setName("Eric");
            e1.setID(1);
            e1.setAge(25);
            e1.setDept("Writer");
            e1.setComp("Yahoo");
            Console.WriteLine(e1.ToString());

            Console.ReadLine();
        }
    }
}
