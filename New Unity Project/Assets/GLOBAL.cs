using UnityEngine;
using System.Collections;

public class GLOBAL : MonoBehaviour {
		
	//set the no destroy flag

	
	const uint x;
	const uint y;
	
	uint grid[x][y];

	//character object
	static character[] characters;

	static item[] inventory;

	struct item{
		//uint item_amount;
		string name;
		uint id;
		int equip_slot=0;
		int[] values; //be it attack,restore etc
	}  

		
	void play_music();	

	void load_data();

	void save_data();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
