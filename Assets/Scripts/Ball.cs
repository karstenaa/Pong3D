using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    private Rigidbody rigidBody;
    void Awake ()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start () {
        rigidBody.velocity = new Vector3(Random.Range(-1f,1f), 0f, Random.Range(-1f,1f)) * 5f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        if(rigidBody.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.name == "Plane")
        {
            GetComponent<Collider>().material = (PhysicMaterial) Resources.Load("PhysicMaterials/Bouncy");  
        }
    }
}
