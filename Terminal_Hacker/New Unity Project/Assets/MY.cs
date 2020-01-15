using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu ()
    {
        print("Hello Console, how are ya");
        string greeting = "Hello there";
        Terminal.WriteLine(greeting);
        
        Terminal.WriteLine("What would you like to do?");
        Terminal.WriteLine("This");
        Terminal.WriteLine("OR this");
        Terminal.WriteLine("OORRRR THIS?");

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
