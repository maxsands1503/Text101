using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	
	public Text text;
	
	private enum States {cell, mirror, sheets_0, locks_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
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
		text.text = "Fuck yeah";
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
		}
	}
}
