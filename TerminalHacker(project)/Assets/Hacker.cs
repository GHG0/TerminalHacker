using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hacker : MonoBehaviour{
	//gamestate
	int level;
	enum Screen {Main, Pass, Win}
	Screen currentScreen;
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
	//when the button is pressed
	void OnUserInput(string input){
		if(input == "menu"){ //always go to menu
			ShowMainMenu();
			currentScreen = Screen.Main;
		}
		//setting the gamestate with input
		else if (currentScreen == Screen.Main){
			RunMainMenu(input);

		}
	}
	void RunMainMenu(string input){
		if(input == "1"){
			level = 1;
			StartGame();
		}else if(input == "2"){
			level = 2;
			StartGame();
		}else if(input == "3"){
			level = 3;
			StartGame();
		}
		else{
			Terminal.WriteLine("Please enter a valid level.");
			
		}
	}
	
	
	void StartGame(){
		currentScreen = Screen.Pass;
		Terminal.WriteLine("you have chosen "+level);


	}

}
