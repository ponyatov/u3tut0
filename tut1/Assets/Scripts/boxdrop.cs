using UnityEngine;
using System.Collections;

public class boxdrop : MonoBehaviour {

	public Vector3 drift;

	void Update(){
		transform.Translate (drift*Time.deltaTime);
	}

	void OnCollisionEnter(Collision coll) {
		Debug.Log (coll.gameObject);
	}

}
