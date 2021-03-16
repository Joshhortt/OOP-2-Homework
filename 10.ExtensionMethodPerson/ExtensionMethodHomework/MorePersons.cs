// 10 - HOMEWORK - Extension Methods
// Create a chain using extension methods and Fluent Design pattern.

namespace ExtensionMethodHomework
{
	public static class MorePersons
    {
        public static Person OfSmallSize(this Person person)
        {
            person.Weigth = 50;
            person.Height = 150;
            person.HasAge = 18;
            return person;
        }

        public static Person OfMediumSize(this Person person)
        {
            person.Weigth = 75;
            person.Height = 170;
            person.HasAge = 18;
            return person;
        }

        public static Person OfLargeSize(this Person person)
        {
            person.Weigth = 100;
            person.Height = 190;
            person.HasAge = 18;
            return person;
        }

        public static Person OfSize(this Person person, int weigth, int height, int hasAge)
        {
            person.Weigth = weigth;
            person.Height = height;
            person.HasAge = hasAge;

            return person;
        }
    }
}
