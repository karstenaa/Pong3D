using UnityEngine;
using System.Collections;

public class BallGenerator : MonoBehaviour {

    public GameObject ballPrefab;
    public float ballRate = 5f;
    private float nextBall = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time > nextBall)
        {
            nextBall = Time.time + ballRate;
            GameObject ball = Instantiate(ballPrefab);
        }
	}
}
