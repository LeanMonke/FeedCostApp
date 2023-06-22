using System;
using System.Collections.Generic;
using System.Text;

namespace FeedCostApp
{
    class CowManager
    {
        private List<Cow> cows;
        private List<string> breeds;
        private List<string> foodTypes;
        private List<float> foodCosts;

        public CowManager()
        {
            this.cows = new List<Cow>();
            this.breeds = new List<string>()
            {
                "Freisan"
            };
            this.foodTypes = new List<string>()
            {
                "silage"
            };
            this.foodCosts = new List<float>()
            {
                0f
            };
        }
        public float CalculateBreedFeedCost()
        {
            return 0;
        }
    }
}
