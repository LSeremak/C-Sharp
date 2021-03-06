﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt0
{
    class Diary
    {

        // Stan (zmienne - pola)
        List<float> ratings = new List<float>();


        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        public float MaxRating()
        {
            return ratings.Max();
        }


        public float  MinRating()
        {
            return ratings.Min();
        }
    }
}
