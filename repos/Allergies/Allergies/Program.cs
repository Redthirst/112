using System;

namespace Allergies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Allergies p = new("Mark", "Eggs Peanuts Shellfish Pollen");
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.IsAllergicTo("Strawberries"));
            p.AddAllergy("Strawberries");
            Console.WriteLine(p.IsAllergicTo("Strawberries"));
            p.AddAllergy("Strawberries");
            p.DeleteAllergy(8);
            Console.WriteLine(p.IsAllergicTo(8));

        }
    }
    public class Allergies
    {
        [Flags]
        public enum Allergen
        {
            Eggs = 1,
            Peanuts = 2,
            Shellfish = 4,
            Strawberries = 8,
            Tomatoes = 16,
            Chocolate = 32,
            Pollen = 64,
            Cats = 128
        }
        private string _name { get; set; }
        private int _score { get; set; } = 0;

        public Allergies(string name)
        {
            _name = name;
        }
        public Allergies(string name, int score)
        {
            _name = name;
            _score = score;
        }
        public Allergies(string name, string allergies)
        {
            _name = name;

            int a = 0;
            List<string> list = allergies.Split(' ').ToList();
            foreach (string s in list)
            {
                a += (int)(Allergen)Enum.Parse(typeof(Allergen), s);
            }
            _score = a;
        }
        public override string ToString()
        {
            var f = (Allergen)this._score;
            List<string> li = f.ToString().Split(", ").ToList();
            string m = li.Last();
            Console.WriteLine(li.Last());
            li.Remove(m);
            Console.WriteLine(li.Last());
            string s = String.Join(", ", li);

            if (this._score == 0)
            {
                return $"{this._name} has no allergies!";
            }
            else
            {
                return $"{this._name} is allergic to {s} and {m}.";
            }
        }
        public bool IsAllergicTo(string al)
        {
            var f = (Allergen)this._score;
            List<string> list = f.ToString().Split(", ").ToList();
            if (list.Contains(al))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsAllergicTo(int al)
        {
            var f = (Allergen)this._score;
            var m = (Allergen)al;
            List<string> list = f.ToString().Split(", ").ToList();
            if (list.Contains(m.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddAllergy(int al)
        {
            var f = (Allergen)this._score;
            var m = (Allergen)al;
            List<string> list = f.ToString().Split(", ").ToList();

            if (Enum.IsDefined(typeof(Allergen), al) && list.Contains(m.ToString()) == false)
            {
                this._score += al;
            }
            else if (list.Contains(m.ToString()))
            {
                Console.WriteLine("Allergen already added");
            }
            else
            {
                Console.WriteLine("Wrong allergen");
            }

        }

        public void AddAllergy(string al)
        {
            var f = (Allergen)this._score;
            Allergen s = (Allergen)Enum.Parse(typeof(Allergen), al);
            List<string> list = f.ToString().Split(", ").ToList();

            if (Enum.IsDefined(typeof(Allergen), al) && list.Contains(al) == false)
            {
                this._score += (int)s;
            }
            else if (list.Contains(al))
            {
                Console.WriteLine("Allergen already added");
            }
            else
            {
                Console.WriteLine("Wrong allergen");
            }

        }
        public void DeleteAllergy(int al)
        {
            var f = (Allergen)this._score;
            var m = (Allergen)al;
            List<string> list = f.ToString().Split(", ").ToList();

            if (Enum.IsDefined(typeof(Allergen), al) && list.Contains(m.ToString()))
            {
                this._score -= al;
            }
            else if (list.Contains(m.ToString()) == false)
            {
                Console.WriteLine("Allergen isn't listed");
            }
            else
            {
                Console.WriteLine("Wrong allergen");
            }

        }

        public void DeleteAllergy(string al)
        {
            var f = (Allergen)this._score;
            Allergen s = (Allergen)Enum.Parse(typeof(Allergen), al);
            List<string> list = f.ToString().Split(", ").ToList();

            if (Enum.IsDefined(typeof(Allergen), al) && list.Contains(al))
            {
                this._score -= (int)s;
            }
            else if (list.Contains(al) == false)
            {
                Console.WriteLine("Allergen isn't listed");
            }
            else
            {
                Console.WriteLine("Wrong allergen");
            }
        }
    }
}
