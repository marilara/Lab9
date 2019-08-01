using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Final
{
    class Student
    {
        public string Name;
        public string HomeTown;
        public string FavoriteFood;
        public string FavoriteBand;

        public Student(string name, string homeTown, string favoriteFood, string favoriteBand)
        {
            Name = name;
            HomeTown = homeTown;
            FavoriteFood = favoriteFood;
            FavoriteBand = favoriteBand;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetHomeTown()
        {
            return HomeTown;
        }

        public string GetFavoriteFood()
        {
            return FavoriteFood;
        }

        public string GetFavoriteBand()
        {
            return FavoriteBand;
        }
    }
}