using UnityEngine;
using System.Collections;

public class keypress : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) {
			Debug.LogWarning("Jump");
		}
	}
}
