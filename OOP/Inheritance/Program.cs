using Inheritance;

//Object instantiations: 

Lector lector = new Lector("Jason", "Blake", 28, 1, "Test Address");
Doctor doctor = new Doctor("Michael", "Drake", 33, "Surgeon");
Student student = new Student("Veronika", "Storm", 45, 5);

/*
 * Inheritance helps us to have CODE REUSE, because all derived classes can use the methods and data
 * from the Person class which is the base class. This is one of the main advantages of inheritance.
*/

/*
 * Technically we can put all this objects in one collection from type Person, because all them are inheriting
 * Person and there is "is-a" relationship.
 */

List<Person> people = new List<Person> { lector, doctor, student };

/*
 * So this is something which is very powerful and leads us to the next important pillar of OOP 
 * which is POLYMORPHISM. Please see the next example project "Polymorphism".
*/


