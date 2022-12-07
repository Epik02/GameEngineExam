using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 0.01f;
    Vector3 bruh;
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) == true)
        {
            Debug.Log("yassss");
            //this.transform.GetComponent<Rigidbody>().velocity.Set(0.0f, 0.0f, speed) ;
           // bruh = new Vector3(transform.position + speed);
            //this.GetComponent<Rigidbody>().velocity.Set(0.0f, 0.0f, speed);
            this.transform.SetPositionAndRotation(transform.position, transform.rotation);
        }
    }
}
