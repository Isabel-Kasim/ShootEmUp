using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    public bool playText;
    public TextMeshProUGUI normalText;
    private string message;

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public IEnumerator WaitText()
    {
        playText = false;
        int randomWait = Random.Range(0, 7);
        Debug.Log("Time: " + randomWait + " seconds");
        yield return new WaitForSeconds(randomWait);
        Messages();
        playText = true;

    }

    public void Messages()
    {
        int messageChoice = Random.Range(0, 10);
        if (messageChoice == 0)
        {
            message = "Ţ̸̺̇̍͋̉̔̑̆h̷͇̲̬̝̳̗̞̘̤̹̀̀͛̌̄́̅͂̒̚͝ĭ̴̼̬̪͖̦̟͎̬̅̊͑s̴̨̨̨͉̱͉͍̹͍͖̠̃̄̐̂̀̀̓̕ ̴͓͖̻͍̂̔͂̅̋͠i̵̺̯̬̊̀̈́̀̅̕ş̵̲͚̥̪̀̆̉́͒͋͐͌̎̓̀n̴̡̠͔̅͊̔̉̉̽͘͝͠'̶̳͚̝̠͕̙̬̟͗̋͋͗ṯ̷͈̗̪̅́͋̍̚ͅ ̸̪̺̟̭̜̐̈́͒̉̈́͒͛͒j̴̙̠̲͕͙̅̾̌ư̶̭̖̭̘̩̳̌̏̊̾̊͘͠ș̶̫͚͚͕̏́͋͛̈́͠ͅt̶̬̝̙͈̙͎̳̺͉̙̄͛̈́̉̎̈́̚͘͜ ̸̧̛̠̝̠̣̜̠͔̽̉́͜͝ả̸̡̨̟̗͍̭͔̰̦̬̥̂͋̍̂̍̄͘͝ ̷̢̩̪̣͇̫̀̽̀̑̓g̴̢͖͎̰͈̯̩̋͆̊͂̔̕a̶̖͎̜̺̗͓͊̓͗̎͛̏̅͆ͅͅm̵̹̰̽̍̋̽͆͊̐͝ë̶͙̥̰́̔̈́";
            //normalText.text = message.ToString();
        }
        if (messageChoice == 1 || messageChoice == 4 || messageChoice == 5 || messageChoice == 6 || messageChoice == 7 || messageChoice == 8 || messageChoice == 9)
        {
            message = "Hello, and welcome to the shoot em up game. Now I know what you're thinking...boy oh boy am I late to the party. I really do want to say I'm sorry for delaying so much, but I hope this can make up for it. Enjoy the game.                     - Isabel";
        }
        if (messageChoice == 2)
        {
            message = "Q̷̡̰̻̯͈̣͔͚̂͌̒̊ͅų̷̡̣̞͈͈̝͍̣̖̑͒̃̓̑͘̕͠a̶̞̜̭̘͓̫͉̣͉̥̍̍r̸̡̰̼̘͙̼̄̈́͋̇͐̅̕ȁ̷̡̧͓͈͎̟̗͖͂̓́n̵͕͚̦̕t̴̡̰͇̩̥̦̟͈̹̳̖̉ì̴̡̱͍͕̙͓̀̈́̈́͐̀n̴̲͎̜͉̼̤͂̑͋̎̈́̑͆e̴͖͐̏̂";
        }
        if (messageChoice == 3)
        {
            message = "You thought you could win?";
        }

        normalText.text = message.ToString();
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (playText)
        {
            StartCoroutine(WaitText());
        }


    }
}
