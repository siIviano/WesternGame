using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float enemySpeed;
    public Rigidbody enemyRb;

    public Transform targetToFollow;

    public int moneyLoot = 10;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();

        targetToFollow = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetToFollow);
    }

    private void FixedUpdate()
    {
        enemyRb.MovePosition(transform.position + transform.forward * enemySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.gameObject);
        ResourceManager.instance.WinMoney(moneyLoot);
    }
}
