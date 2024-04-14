// THIS FILE IS JUST TO COPY AND PASTE THIS IS NOT A PROJECT
// to see how this works go to:
// a coin minigame

using ConsoleEngine;
using ConsoleEngine.EntityManagement;

namespace Main {
    public class Program {
        public static void Main(string[] args) {
            RenderGrid screen = new(5,5,'-');

            int score = 0;

            screen.InitWindow("Game");

            Entity player = new(2,2,'&');
            Entity coin = new(GetRandomVal(0, screen.WIDTH-1), GetRandomVal(0, screen.HEIGHT), '§');

            while (true) {
                GameDraw(screen);

                ConsoleKey inp = screen.CheckKeyPressed();
                if (inp == ConsoleKey.E) break;

                MovePlayer(inp);

                if (player.CheckCollision(coin)) {
                    score++;
                    ReloadLevel();
                }
            }

            void MovePlayer(ConsoleKey inp) {
                if (inp == ConsoleKey.D) {
                    player.position.x++;
                    if (player.position.x >= screen.WIDTH) {
                        player.position.x = screen.WIDTH - 1;
                    }
                }
                else if (inp == ConsoleKey.A) {
                    player.position.x--;
                    if (player.position.x < 0) {
                        player.position.x = 0;
                    }
                }
                else if (inp == ConsoleKey.S) {
                    player.position.y++;
                    if (player.position.y >= screen.HEIGHT) {
                        player.position.y = screen.HEIGHT - 1;
                    }
                }
                else if (inp == ConsoleKey.W) {
                    player.position.y--;
                    if (player.position.y < 0) {
                        player.position.y = 0;
                    }
                }
            }

            void ReloadLevel() {
                player.position.Set(2,2);
                coin.position.Set(GetRandomVal(0, screen.WIDTH-1), GetRandomVal(0, screen.HEIGHT));
            }

            void GameDraw(RenderGrid screen) {
                screen.Clear('-');
                screen.DrawUI("Score: "+score);
                coin.Draw(screen);
                player.Draw(screen);
                screen.Render();
            }

            int GetRandomVal(int x, int y) {
                return new Random().Next(x, y);
            }
        }
    }
}
