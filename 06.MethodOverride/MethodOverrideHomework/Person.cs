namespace MethodOverrideHomework
{
	public class Person
        {
		    public int Id { get; set; }
		    public string FirstName { get; set; }
            public string LastName { get; set; }
           
            public override string ToString()
            {
                return $"Your Id is: " + this.Id + " Your first name is: " + this.FirstName + " Your last name is: " + this.LastName;
            }
        }
    }
