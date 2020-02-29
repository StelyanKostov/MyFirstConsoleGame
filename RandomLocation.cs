using System;

namespace Game
{
    public static class RandomLocation
    {
        static public int Create()
        {
            Random radnomPlace = new Random();
            int place = radnomPlace.Next(0, Map.Lenght);
            return place;
        }
    }
}
