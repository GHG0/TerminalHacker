using UnityEngine;
public class Hacker : MonoBehaviour{
	//Game Config data
	string menhint = "you may type 'menu' at any time.";
	string[] l1={"health", "apple", "water", "life", "care"};
	string[] l2={"justice","federal","investigation","computerhack"};
	string[] l3={"hiddenheadquarters","government-espionage","intelligence","cybersecurity"};
	//gamestate
	int level;
	enum Screen {Main, Pass, Win}
	Screen currentScreen;
	string Password;
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
	    Terminal.WriteLine("3 for CIA");
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
		else if (currentScreen == Screen.Pass){
			CheckPassword(input);
		}
		else if (currentScreen == Screen.Win){
			Winner();
		}

	}
	void RunMainMenu(string input){
		bool levelnum = (input == "1"||input == "2"||input == "3");
		if (levelnum){
			level = int.Parse(input);
			AskPass();
		}
		else{
			Terminal.WriteLine("Please enter a valid level.");
			Terminal.WriteLine(menhint);
			
		}
	}
	
	
	void AskPass(){
		currentScreen = Screen.Pass;
		Terminal.ClearScreen();
		setpass();
		Terminal.WriteLine("enter password, hint:");
		Terminal.WriteLine(Password.Anagram());
		Terminal.WriteLine(menhint);
	}

	void setpass(){
		switch(level){
			case 1:
				Password = l1[Random.Range(0,l1.Length)];
				break;
			case 2:
				Password = l2[Random.Range(0,l2.Length)];
				break;
			case 3:
				Password = l3[Random.Range(0,l3.Length)];
				break;
			default:
				Debug.LogError("INVALID LEVEL NUMBER");
				break;
		}
	}
	void CheckPassword(string input){
		if (input == Password){
			Winner();
		}
		else{AskPass();}
	}
	void Winner(){
		currentScreen = Screen.Win;
		Terminal.ClearScreen();
		Terminal.WriteLine("You Got it! You Hacked into lvl."+level+"!");
		ShowReward();
	}
	void ShowReward(){
		switch(level){
			case 1:
				Terminal.WriteLine("Have an apple!");
				Terminal.WriteLine(@"
	/
    |
  ,,,,,
 //    \\
||      ||
||      ||
 \\____//
"				);
				break;
			case 2:
				Terminal.WriteLine("You have been apprehended");
				Terminal.WriteLine(@"
 _    .----.       .----.
( )  //--\  \.---./  /--\\
 T  ((    ) @)   (@ (    ))
 |   \\__/  /'---'\  \__//
 |E   '----' cuffs '----'
 				");
				break;
			case 3:
				Terminal.WriteLine("YOU WERE CAUGHT! TREASON!");
				Terminal.WriteLine(@"
________
||\  /||
|| \/ ||
||	  ||
||(  )||
==@==@==


				");
				break;
			default:
				Terminal.WriteLine(menhint);
				break;
		}
	}
}


