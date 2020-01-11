using System;


namespace FitnesTrekerByEvgenyYakushev.Bl.Model
{
      public class Food
    {
       public string Name { get; }
        public double Callories { get; }

        /// <summary>
        /// Белки
        /// </summary>

        public double Proteins { get;}

       /// <summary>
       /// Жиры
       /// </summary>

       public double Fats { get;}

        /// <summary>
        /// Углеводы
        /// </summary>

        public double Carbohydrates  { get;}

        /// <summary>
        /// Калории за 100 грамм продукта
        /// </summary>

        public double Calories { get;}

       private double CalloriesOneGramm { get { return Calories / 100.0; } }


       private double ProteinsOneGramm { get { return Proteins / 100.0; } }

       private double FatsOneGramm { get { return Fats / 100.0; } }

       private double CarbohydratesOneGramm { get { return Carbohydrates / 100.0; } }

        public Food(string name) : this(name, 0, 0, 0, 0)
        {
        }
        

        public Food(string name, double callories, double proteins, double fats, double carbohydrates)
        {
            //TODO:Проверка


            Name = name;
            Callories = callories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;

           


        }

        




            






    }
}

