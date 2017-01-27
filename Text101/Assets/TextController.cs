using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {cell, 
						mirror,
						sheets_0,
						locks_0,
						cell_mirror,
						sheets_1,
						lock_1,
						freedom, 
						corridor_0,
						stairs_0,
						floor, 
						closet_door,
						corridor_1,
						stairs_1,
						in_closet,
						corridor_2,
						stairs_2,
						corridor_3,
						courtyard,
						stairs_pick,
						};
	public bool HasUniform;
	public bool HasPick;					
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	//1st state
	void state_cell(){
		text.text = "You are in a prison cell, and you want to escape. There are " + 
				"some dirty sheets on the bed, a mirror on the wall, and the door" +
				" is locked from the outside. \n\n" + 
				"Press 'M' to view mirror, 'S' to view sheets and 'L' to view the lock.";
		if(Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		}
		if(Input.GetKeyDown(KeyCode.L)){
			myState = States.locks_0;
		}
		if(Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets_0;
		}		
	}
	//2nd state
	void state_sheets_0(){
		text.text = "You can't believe you sleep in these things. Surely it's " +
					"time somebody changed them. The pleasures of prison life  "+
					"I guess! \n\n" +
					"Press 'R' to return to your cell";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	void state_mirror(){
		text.text = "There is a broken piece of mirror, do you take it? \n\n" +
		"Press 'R' to return or 'T' to take the mirror. ";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		} else if (Input.GetKeyDown(KeyCode.T)){
			myState = States.cell_mirror;
		}
	}
	void state_locks_0(){
		text.text = "Pop and lock baby. You don't have the tools to crack this.";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
	void state_cell_mirror(){
		text.text = "You got a hunk of broken glass. What do you think you should do with it? \n\n" +
					"Press S to look at the sheets or L to inspect the lock again.";
					if(Input.GetKeyDown(KeyCode.S)){
						myState = States.sheets_1;
					} else if(Input.GetKeyDown(KeyCode.L)){
						myState = States.lock_1;
					}
	}
	void state_sheets_1(){
		text.text = "These things are still filthy, you don't even want to touch em.\n\n" +
					"Press 'R' to return.";
		if(Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_mirror;
		}			
	}
	void state_lock_1(){
		text.text = "It looks like you might be able to break the mirror to fit into the lock" + 
					", care to try that out?\n\n"
					+"Press 'N' to return and  'Y' to try it out.";
		if(Input.GetKeyDown(KeyCode.N)){
			myState = States.cell_mirror;
		}else if(Input.GetKeyDown(KeyCode.Y)){	
			myState = States.freedom;
		}		
	}
	void state_freedom(){
		text.text = "You hear the lock click, you're now able to enter the corridor.\n\n" +
		"Press 'C' to enter the corridor";
		if(Input.GetKeyDown(KeyCode.C)){
			myState = States.corridor_0;
		}
	}
	void state_corridor_0(){
		text.text = "You are one step closer to freedoom. check out your surroundings" + 
		"There is a door marked Janitor's Closet a floor with some garbage and a door marked 'Stairs'. \n\n" +
		"To inspect the Janitor's Closet press 'J', to inspect the floor press 'F' and to check the stairs 'S'.";
		
	}
	void state_stairs_0(){
		text.text = "This door is locked, if only there was a way to get it open!";
	}
	void state_floor(){
		text.text = "There seems to be a lot of garbage, but alas, is that a hair clip? \n\n" + 
		"Press 'P' to pick it up.";
	}
	void state_stairs_pick(){
		if(HasUniform != false){
		text.text = "You use the hair pin to pick the lock, you ascend the stairs and are in another corridor.\n\n" +
		"Press 'C' to continue";
		}else{
			text.text = "You were caught by a guard! Maybe try being in a uniform to be more incognito.\n\n" +
			"GAME OVER\n\n" + 
			"Press 'R' to restart.";
		}
		
	}
	void state_closet_door(){
		text.text = "There is a janitor's uniform press 'P' to put it on\n\n" +
		"Press 'R' to return to the corridor." ;
	}
	void state_corridor_uniform(){
		text.text = "You are now disguised and can roam about the prison without alerting suspicion. \n\n" +
		"Press 'S' to check the stairs and 'F' to check the floors"
	}
	void state_corridor_1(){
		text.text = "";
	}
	void state_stairs_1(){
		text.text = "";
	}
	void state_in_closet(){
		text.text = "";
	}
	void state_corridor_2(){
		text.text = "";
	}
	void state_stairs_2(){
		text.text = "";
	}
	void state_corridor_3(){
		text.text = "";
	}
	void state_courtyard(){
		text.text = "";
	}
		
	// Update is called once per frame
	void Update () {
		if (myState == States.cell){
			state_cell ();
		} else if(myState == States.sheets_0){
			state_sheets_0();
		} else if (myState == States.mirror){
			state_mirror();
		} else if (myState == States.locks_0){
			state_locks_0();
		}else if (myState == States.cell_mirror){
			state_cell_mirror();
		}else if (myState == States.sheets_1){
			state_sheets_1();
		}else if(myState == States.freedom){
			state_freedom();
		}else if(myState == States.lock_1){
			state_lock_1();
		}else if (myState == States.corridor_0){
			state_corridor_0();
		}else if (myState == States.stairs_0){
			state_stairs_0();
		}else if (myState == States.floor){
			state_floor();
		}else if (myState == States.closet_door){
			state_closet_door();
		}else if (myState == States.corridor_1){
			state_corridor_1();
		}else if (myState == States.stairs_1){
			state_stairs_1();
		}else if (myState == States.in_closet){
			state_in_closet();
		}else if (myState == States.corridor_2){
			state_corridor_2();
		}else if (myState == States.stairs_2){
			state_stairs_2();
		}else if (myState == States.corridor_3){
			state_corridor_3();
		}else if (myState == States.courtyard){
			state_courtyard();
		}else if (myState == States.stairs_pick){
			state_stairs_pick();
		}
		
	}
}