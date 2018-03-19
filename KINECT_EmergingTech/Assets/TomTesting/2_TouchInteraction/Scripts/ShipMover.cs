using UnityEngine;
using System.Collections;

public class ShipMover : MonoBehaviour 
{
    private Rigidbody rb;
    float randomX;
    public GameObject nextShip;
    public GameObject spawnSite;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void Update () 
	{
        randomX = Random.Range(-33, 33);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            Instantiate(nextShip, spawnSite.transform.transform.position, spawnSite.transform.rotation);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        rb.AddForce(new Vector3(randomX, 20, 0));
    }
}
