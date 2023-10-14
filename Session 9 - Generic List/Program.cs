

// alt arbejder fra typen object

int i = 5;

object o;




List<Person> lp = new List<Person>();

int id = 9;


foreach (var  item in lp)
{
    if(item.Id == id)
    {
        lp.Remove(item);
    }
}



public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public int MyProperty { get; set; }
} 
