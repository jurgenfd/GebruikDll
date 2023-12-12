using CODE_TempleOfDoom_DownloadableContent;
using System;

namespace GebruikDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.ReadLine();
        }

        Enemy enemy;
        public Program()
        {
            enemy = new HorizontallyMovingEnemy(5, 1, 1, 1, 10)
            {
                // Subscribe(this); // JFD: enemy is niet langer observable zoals in Martijn's screencast
                CurrentField = new Field(1, 1) // Verplicht te initialiseren
            };

            enemy.OnDeath += ReportDeath;

            for (int i = 0; i < 10; i++)
            {
                enemy.Move();
                showEnemy();
            }

            for (int i = 0; i < 10; i++)
            {
                enemy.DoDamage(1); // JFD GetHurt in Martijn's screencast
                showEnemy();
                if (enemy.NumberOfLives <= 0)
                {
                    break;
                }
            }
        }

        private void ReportDeath(object? sender, EventArgs e)
        {
            Console.WriteLine($"enemy KILLED at: {enemy.CurrentXLocation} Y: {enemy.CurrentYLocation}");
        }

        private void showEnemy()
        {
            Console.WriteLine($"X: {enemy.CurrentXLocation} Y: {enemy.CurrentYLocation} lives: {enemy.NumberOfLives} ");
        }
    }
}