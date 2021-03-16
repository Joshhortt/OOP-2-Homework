// 10 - HOMEWORK - Extension Methods
// Create a chain using extension methods and Fluent Design pattern.

namespace ExtensionMethodHomework
{
	public class Person
    {
		public string Name { get; set; }
		public int Weigth { get; set; }
		public int Height { get; set; }
		public int HasAge { get; set; }

	
        private Person()
        {
        }

        public static Person Create()
        {
            return new Person() { Name = "My Person", Weigth = 75, Height = 170, HasAge = 18 };
            
        }

        public Person WithName(string name)
        {
            Name = name;
            return this;
        }

        public Person OfSize(int weigth, int height)
        {
            Weigth = weigth;
            Height = height;
            return this;
        }

        public Person WithAge()
        {
            HasAge = 18;
            return this;
        }

        public override string ToString()
        {
            return string.Format("\nName: {0}\nWeigth: {1}\nHeight: {2}\nAge: {3}", Name, Weigth, Height, HasAge);
        }
    }
}
