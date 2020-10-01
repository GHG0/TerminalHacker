using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
		ShowMainMenu();
    }
    
    //Mainmenu is asking what you would like to hack
    void ShowMainMenu(){
    	Terminal.ClearScreen();
   	    Terminal.WriteLine("What would you like to hack?");
	    Terminal.WriteLine("");
	    Terminal.WriteLine("1 for Hospital");
	    Terminal.WriteLine("2 for FBI");
	    Terminal.WriteLine("3 for NSA");
	    Terminal.WriteLine("Enter your selection below");
	}
	//when the enter button is pressed
	void OnUserInput(string input){
		if(input == "menu"){
			ShowMainMenu();
		}
		else{
			Terminal.WriteLine("Please enter a valid level.");
			
		}
	}

}
