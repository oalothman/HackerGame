using UnityEngine;

public class HackerGameScript : MonoBehaviour
{

    //GameState
    int level;
    //MainMenu, Password, Win/Loss
    enum Screen
    {
        MainMenu, Password, Win
    };
    Screen currentScreen = Screen.MainMenu;
    string[] level1Passwords = {"cash", "card", "beef", "call", "soon"};
    string[] level2Passwords = { "jewelry", "museum", "planned", "asked", "helped" };
    string[] level3Passwords = { "invitation", "confetti", "wrapped", "pinata", "balloon" };
    string[] level4Passwords = { "evolution", "electronics", "rhythm", "eclipse", "photosynthesis" };
    string[] level5Passwords = { "glacier", "metamorphasis", "conscience", "handkercheif", "communication" };
    // NBK: cash, card, beef, call, soon
    // Ministry of Defence: jewelry, museum, planned, asked, helped
    // Coded Headquarters: invitation, confetti, wrapped, pinata, balloon
    // Moons's Satellite: evolution, electronics, rhythm, eclipse, photosynthesis
    // FBI: glacier, metamorphasis, conscience, handkercheif, communication
    // Start is called before the first frame update

    string password;

    private void Start()
    {
        ShowMainMenu("Othman");
    }

    void OnUserInput(string input)
    {
        if(input == "menu")
           {
            ShowMainMenu("Othman");
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

    private void CheckPassword(string input)
    {
        if(input == password)
        {
            Terminal.WriteLine("Congragulations!");
            DisplayWinScreen();
        }
        else
        {
            Terminal.WriteLine("Wrong Password. Try again or type menu to go back to the main menu.");
        }
    }

    void SelectLevel(string inputLevel)
    {
        if (inputLevel == "1")
        {
            level = 1;
            StartGame();
        }
        else if (inputLevel == "2")
        {
            level = 2;
            StartGame();
        }
        else if (inputLevel == "3")
        {
            level = 3;
            StartGame();
        }
        else if (inputLevel == "4")
        {
            level = 4;
            StartGame();
        }
        else
        {
            level = 5;
            StartGame();
        }
    }

    private void StartGame()
    {
        Terminal.ClearScreen();
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level: " + level);
        Terminal.WriteLine("Please input the password.");
        switch (level)
        {
            case 1:

                password = level1Passwords[Random.Range(0, level1Passwords.Length)];
                
                break;

            case 2:

                password = level2Passwords[Random.Range(0, level2Passwords.Length)];
              
                break;
            case 3:
               
                password = level3Passwords[Random.Range(0, level3Passwords.Length)];
               
                break;
            case 4:
               
                password = level4Passwords[Random.Range(0, level4Passwords.Length)];
              
                break;
            case 5:

                password = level5Passwords[Random.Range(0, level5Passwords.Length)];
            
                break;
            default:
                print("invalid level selected");
                break;
        }
        Terminal.WriteLine("Please insert the password: " + password.Anagram());

    }

    private void RunMainMenu(string levelSelection)
    {
            SelectLevel(levelSelection);
    }

    private void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        //Terminal.ClearScreen();
        ShowLevelReward();

    }

    private void ShowLevelReward()
    {
  
    }

    void ShowMainMenu(string name)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine($"Welcome Agent {name}.");
        Terminal.WriteLine("What would you like to hack into today?");
        Terminal.WriteLine("Enter a number from 1-5 to access the  following organizations:");
        Terminal.WriteLine("1 NBK");
        Terminal.WriteLine("2 The Ministry of Defence");
        Terminal.WriteLine("3 Coded Headquarters");
        Terminal.WriteLine("4 The moon's satellite");
        Terminal.WriteLine("5 Federal Bureau of Investigation");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
