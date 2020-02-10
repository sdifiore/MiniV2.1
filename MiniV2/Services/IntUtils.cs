using System;

namespace MiniV2.Services
{
    public static class IntUtils
    {
        public static int RandomInt(int min, int max)
        {
            var random = new Random();

            return random.Next(min, max);
        }
    }
}