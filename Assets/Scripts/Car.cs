using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
    public int hitPoint = 1;
    public float speed = 10f;
    private Rigidbody rigidBody;
    private Collider coll;
    private float nextFire = 0f;
    private float fireRate = 3f;
    private bool isFire = false;
    void Awake()
    {
        coll = GetComponent<Collider>();
        rigidBody = GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    protected virtual float moveX()
    {
        return 0.0f;
    }
    protected virtual float moveZ()
    {
        return 0.0f;
    }
    protected virtual bool isFireButton()
    {
        return false;
    }
    public void hit()
    {
        if (--hitPoint == 0)
        {
            transform.parent.Find("Wall").GetComponent<Collider>().enabled = true;
            transform.parent.Find("Wall").GetComponent<Renderer>().enabled = true;
            Destroy(gameObject);
        }
    }
    private void fire()
    {
        if(isFireButton() && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            isFire = true;
            GetComponent<Renderer>().material = (Material)Resources.Load("Materials/CarFire");
        }
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(moveX(), 0.0f, moveZ());
        rigidBody.velocity = movement * speed;
        fire();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball" && isFire)
        {
            isFire = false;
            GetComponent<Renderer>().material = (Material)Resources.Load("Materials/CarDefault");
            collision.rigidbody.velocity *= 2f;
        }
    }
}
