using UnityEngine; 
using System.Collections; 

public class BattaryTracker : MonoBehaviour { 
	public GameObject point1;
	public GameObject point2;
	public GameObject point3;
	public GameObject battary1;
	public GameObject battary2;


	// Use this for initialization 
	void Start () { 
		battary2.SetActive (false);
	} 

	// Update is called once per frame 
	void Update () { 
		if (Input.GetKeyDown ("space")) {
			if (point1.activeSelf) {
				point1.SetActive (false); 
			} else if (point2.activeSelf) {
				point2.SetActive (false);
			} else if (point3.activeSelf) {
				point3.SetActive (false);
			} else if (battary1.activeSelf) {
				battary1.SetActive (false);
				battary2.SetActive (true);
			}
		} 
	} 
}