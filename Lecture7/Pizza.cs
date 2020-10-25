using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture7 {
    class Pizza {

        //instance variables
        private string size;
        private int cheese;
        private int pepperoni;
        private int ham;

        //constructor
        public Pizza() { }
        public Pizza (string size, int cheese, int pepperoni, int ham) {
            this.size = size;
            this.cheese = cheese;
            this.pepperoni = pepperoni;
            this.ham = ham;
        }

        //set and get size
        public void SetSize(string size) {
            this.size = size;
        }
        public string GetSize() {
            return size;
        }

        //set and get cheese
        public void SetCheese(int cheese) {
            this.cheese = cheese;
        }
        public int GetCheese() {
            return cheese;
        }

        //set and get pepperoni
        public void SetPepperoni(int pepperoni) {
            this.pepperoni = pepperoni;
        }
        public int GetPepperoni() {
            return pepperoni;
        }

        //set and get ham
        public void SetHam(int ham) {
            this.ham = ham;
        }
        public int GetHam() {
            return ham;
        }

        /// <summary>
        /// Calculate cost of pizza
        /// </summary>
        /// <returns>cost</returns>
        public double CalculateCost() {

            //check pizza size
            switch (size.ToLower()) {
                case "small":
                    return 10 + (2 * cheese) + (2 * pepperoni) + (2 * ham);
                case "medium":
                    return 12 + (2 * cheese) + (2 * pepperoni) + (2 * ham);
                case "large":
                    return 14 + (2 * cheese) + (2 * pepperoni) + (2 * ham);
                default:
                    Console.WriteLine("Unknown size");
                    break;
            }
            return 0;

        }

        /// <summary>
        /// Convert to a string
        /// </summary>
        /// <returns>object as string</returns>
        public override string ToString() {
            return "Size: " + size + "\nCheese: " + cheese + "\nPepperoni: " + pepperoni + "\nHam: " + ham + "\nCost: " + CalculateCost();
        }

    }
}
