using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform port1;
    public Transform port2;
    public GameObject Portal1;
    public GameObject Portal2;


    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            collision.gameObject.transform.position = port2.transform.position;
            Debug.Log("Do something else here");
        }
    }
    private void OnTriggerEnter2D1(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            collision.gameObject.transform.position = port2.transform.position;
            Debug.Log("Do something else here");
        }
    }
    public void Teleportate()
    {
        
    }
}
