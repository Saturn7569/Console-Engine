// THIS FILE IS JUST TO COPY AND PASTE THIS IS NOT A PROJECT
// to see how this works go to:
// creating a basic window

using System;

using ConsoleEngine;

namespace Main {
    public class Program {
        public static void Main(string[] args) {
            RenderGrid screen = new(5,5,'-');

            screen.InitWindow("Basic Game Grid");

            while (true) {
                GameDraw(screen);

                ConsoleKey inp = screen.CheckKeyPressed();
                if (inp == ConsoleKey.E) break;
            }

            void GameDraw(RenderGrid screen) {
                screen.Clear('-');
                screen.DrawUI("This is a basic window");
                screen.Render();
            }
        }
    }
}
