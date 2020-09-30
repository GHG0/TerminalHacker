using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
		ShowMainMenu();
    }
    
    //Mainmenue is asking what you would like to hack
    void ShowMainMenu(){
    	Terminal.ClearScreen();
    	var greeting = "Hello Deven";
    	Terminal.WriteLine(greeting);
	    Terminal.WriteLine("What would you like to hack?");
	    Terminal.WriteLine("");
	    Terminal.WriteLine("1 for Hospital");
	    Terminal.WriteLine("2 for FBI");
	    Terminal.WriteLine("3 for NSA");
	    Terminal.WriteLine("Enter your selection below");	
	}
    // Update is called once per frame
    void Update(){
        
    }
}
