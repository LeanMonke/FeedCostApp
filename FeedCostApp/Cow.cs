using System;
using System.Collections.Generic;
using System.Text;

namespace FeedCostApp
{
    class Cow
    {
        //cow atributes
        private string breed;
        private DateTime dob;
        private string id;
        private string foodType;
        private List<float> dailyFoodConsumed;

        //constructor
        public Cow(string breed, DateTime dob,string foodType)
        {
            this.breed = breed;
            this.dob = dob;
            this.foodType = foodType;
        }

        //adds daily consumption to a daily food consumed list
        public void AddConsumption(float consumption)
        {
            dailyFoodConsumed.Add(consumption);
        }
        //calculates the total food consumed in a week 
        public float CalculateFoodConsumption()
        {
            float totalFoodAmount = 0;

            if (dailyFoodConsumed.Count < 7)
            {
                for (int index = 0; index < dailyFoodConsumed.Count; index++)
                            {
                    totalFoodAmount += dailyFoodConsumed[index];
                            }
            }
            else
            {
                for (int index = dailyFoodConsumed.Count -7; index < dailyFoodConsumed.Count; index++)
                {
                    totalFoodAmount += dailyFoodConsumed[index];
                }
            }
            
            return totalFoodAmount;
        }
        //calculates the total cost for a week of feed
        public float CalculateFoodCost(float foodCost)
        {
            return CalculateFoodConsumption()*foodCost;
        }
    }
}
