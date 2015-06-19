using UnityEngine;
using System.Collections;

public class generator : MonoBehaviour {

	public GameObject elem;

	void Start(){
		GameObject inst = new GameObject();

		inst = Instantiate(elem,transform.position,transform.rotation) as GameObject;
	}
	
}
