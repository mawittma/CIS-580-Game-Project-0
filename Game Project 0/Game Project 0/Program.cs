﻿using System;

namespace Game_Project_0
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new TitleScreen())
                game.Run();
        }
    }
}