using Inheritance;

//Object instantiations: 

Lector lector = new Lector("Jason", "Blake", 28, 1, "Test Address");
Administrator administrator = new Administrator("Michael", "Drake", 33);
Student student = new Student("Veronika", "Storm", 45, 5);

/*
 * Inheritance helps us to have CODE REUSE, because all derived classes can use the methods and data
 * from the Member class which is the base class. This is one of the main advantages of inheritance.
*/

/*
 * Technically we can put all this objects in one collection from type Member, because all them are inheriting
 * Member and there is "is-a" relationship.
 */

List<Member> members = new List<Member> { lector, administrator, student };

/*
 * So this is something which is very powerful and leads us to the next important pillar of OOP 
 * which is POLYMORPHISM. Please see the next example project "Polymorphism".
*/

//IMPORTANT: Inheritance gives us 2 main things: 1. CODE REUSE and 2. POLYMORPHISM 

