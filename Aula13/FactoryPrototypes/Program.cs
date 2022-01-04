﻿using System;

namespace FactoryPrototype
{
    public class Program
    {
        private static void Main()
        {
            Level original;
            Level shallow;
            Level deep;

            original = new Level('A', new int[] {10, 20, 30 ,40});
            shallow = original.ShallowCopy();

            deep = original.DeepCopy();

            original.IncScores();
            original.SetCategory('X');

            Console.WriteLine($"Original:\n\t{original}");
            Console.WriteLine($"Shallow:\n\t{shallow}");
            Console.WriteLine($"Deep:\n\t{deep}");
        }
    }
}
