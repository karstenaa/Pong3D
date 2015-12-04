using UnityEngine;
using System.Collections;

public class WallDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        print(other.tag);
        if(other.tag == "Ball")
        {
            transform.parent.parent.Find("Car").GetComponent<Car>().hit();
        }
    }
}
