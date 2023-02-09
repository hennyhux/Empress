using System;
using Empress_Game_Engine;

public static class Program
{
    [STAThread]
    private static void Main()
    {
        using (GameRoot game = new GameRoot())
        {
            game.Run();
        }
    }
}