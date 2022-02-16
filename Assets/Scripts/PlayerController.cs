using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 myInputs;

    public Rigidbody rb;
    public Vector3 velocity;
    public float speed = 5f;

    public GameObject bulletPrefab;
    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myInputs.x = Input.GetAxis("Horizontal");
        myInputs.z = Input.GetAxis("Vertical");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, firePoint.position, transform.rotation);
        }
    }

    private void FixedUpdate()
    {
        velocity = rb.velocity;
        velocity.x = myInputs.x * speed;
        velocity.z = myInputs.z * speed;
        rb.velocity = velocity;
    }
}
