using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //game state
    int level;
    string password;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }

        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }
    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "aish";
            StartGame();

        }
        else if (input == "2")
        {
            level = 2;
            password = "ravi";
            StartGame();
        }

        else if (input == "007")
        {
            Terminal.WriteLine("Mr.Bond please enter a valid level 1 or 2");
        }
        else
        {
            Terminal.WriteLine("Please enter level either 1 or 2");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have coosen level" + level);
        Terminal.WriteLine("Please enter your password: ");
    }
    void CheckPassword(string input)
    {
        if (input == password)
        {
            Terminal.WriteLine("well done");
        }
        else
        {
            Terminal.WriteLine("sorry wrong password");
        }

    }

}
