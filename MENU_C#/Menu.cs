using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MENU_C_
{
    internal class Menu : MenuFunction
    {
        private int active_menu;
        private List<string> menu_items;
        public Menu()
        {
            active_menu = 0;
            menu_items = new List<string>
        {
            "Створити словник",
            "Додавати слово та перелад",
            "Замінити слово або переклад",
            "Видалити слово або переклад",
            "Шукати переклад слова",
            "Вихід"
        };
        }
        public void PrintMenu()//вивід меню
        {
            Console.Clear();

            int windowHeight = Console.WindowHeight;
            int menuHeight = menu_items.Count;
            int menuWidth = menu_items.Max(item => item.Length);
            int startY = (windowHeight - menuHeight) / 2;

            ConsoleColor originalForegroundColor = Console.ForegroundColor;

            for (int i = 0; i < menu_items.Count; i++)
            {
                int leftMargin = (Console.WindowWidth - menuWidth) / 2;
                Console.SetCursorPosition(leftMargin, startY + i);

                if (i == active_menu)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(menu_items[i]);
                }
                else
                {
                    Console.ForegroundColor = originalForegroundColor;
                    Console.WriteLine(menu_items[i]);
                }
            }

            Console.ForegroundColor = originalForegroundColor;
        }
        public void ProcessMenu()//прокрутка меню
        {
            Console.CursorVisible = false;
            int menuItemsCount = menu_items.Count;
            ConsoleKey key;

            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        active_menu = (active_menu - 1 + menuItemsCount) % menuItemsCount;
                        break;

                    case ConsoleKey.DownArrow:
                        active_menu = (active_menu + 1) % menuItemsCount;
                        break;

                    case ConsoleKey.Enter:
                        HandleMenuItemSelection(active_menu);
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Програма завершує роботу.");
                        return;

                    default:
                        break;
                }
            } while (key != ConsoleKey.Escape);
        }
        public void CenterText(string text)//вивід тексту по центру
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int leftMargin = (windowWidth - textLength) / 2;
            Console.SetCursorPosition(leftMargin, Console.CursorTop);
            Console.WriteLine(text);
        }
        private void HandleMenuItemSelection(int selectedIndex)//функціонал
        {
            Console.Clear();

            switch (selectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
                case 5:
                    CenterText("Програма завершує роботу.");
                    Environment.Exit(0);
                    return;
                default:
                    break;
            }

            CenterText("Натисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }
    }
}

