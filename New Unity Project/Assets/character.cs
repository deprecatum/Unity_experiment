using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	struct armor{
		int weight=0;
		int defense=0;
	}

	struct arm{
		int damage=1;
		int penetration = 0;
	}

	static string name;
	static int hp;

	static armor armor_set[6];

	static arm hands[2];


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
