using Polymorphism;

/*1. Here we can see the power of polymorphism. It is about that we can put all types of members in a
 single collection (list). That means we can threat our derived classes as their base type in such situations
 and we can use them via this base class.
 Using it on this way in a collection is one of the main benefits of polymorphism, otherwise we have to
 make collection for each type.*/

//Note: Here we threat all type of members as a Member but not as their concrete type.

List<Member> members = new List<Member>()
{
    new Lector("Velizar", "Gerasimov", 32, 1, "Sofia, Cheresha 3"),
    new Administrator("Nicole", "Karamitreva", 29),
    new Student("Daniel", "Petrov", 18, 6)
};


/*2. The second big advantage is that we can use now this collection as an input parameter to a method.
 So as it was mentioned, it is used only one list that contains all types of members. In runtime .NET sees
 the concrete member type (Administrator, Lector or Student) and calls its particular overridden methods. This 
 is a polymorphism, all these objects can take the form of their base class for the need of the collection or
 as an input parameter in a method, but in runtime the system will recognize the specific derived class and
 will call it's particular overridden methods.*/

/* IMPORTANT: Because of polymorphism we can override a base class methods with a new implementation. */

/* When you create a list of Member objects and add instances of Lector, Administrator, and Student to it, each object is treated as a Member within the list. However, at runtime, the actual type of each object (whether it's a Lector, Administrator, or Student) is preserved. This allows the overridden methods in the derived classes to be called appropriately.

Here's a quick summary of the benefits:

 - Unified Collection: You can store different types of objects in a single collection.
 - Method Flexibility: You can pass this collection to methods that operate on the base class type, 
and the correct overridden methods will be called at runtime.
*/

static void ShowAllMembers(List<Member> members)
{
    foreach (var member in members)
    {
        Console.WriteLine(member.Attend());
        Console.WriteLine(member.Report());
        Console.WriteLine(member.Schedule());
    }
}

//Note: Each of the derived classes has these methods and implement them with own behavior.


//========================================WITHOUT POLYMORPHISM=============================================

/*IMPORTANT: If we do not have the ability to use polymorphism we have to make separate list for each type: */
//For example: 

List<Lector> lectors = new List<Lector>();
List<Administrator> administrators = new List<Administrator>();
List<Student> students = new List<Student>();

/*That means we cannot use anymore the ShowAllMembers as it is above because we have not one but three lists, 
 * so we have to make one method that accepts three lists or to make three methods for each list which is totally
 * wrong and inconvenient. */

//UGLY and WRONG - Variant 1 (one method with 3 different lists):
static void ShowAllMembersInWrongWay(List<Lector> lectors, List<Administrator> administrators, List<Student> students)
{ }

//UGLY and WRONG - Variant 2 (3 separate methods):
static void ShowLectorMembers(List<Lector> lectors) { }
static void ShowAdministratorMembers(List<Administrator> administrators) { }
static void ShowStudentMembers(List<Student> students) { }




