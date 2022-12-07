using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectPooling : MonoBehaviour
{
    GameObject enemyhit;
    bool hit = false;
    Collider enemy;
    // Start is called before the first frame update
    void Start()
    {
    }
    void OnTriggerEnter(Collider other)
    {
        hit = true;
        Debug.Log("WINNNN");
    }
    private void OnTriggerExit(Collider other)
    {
        hit = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (hit)
        {
            this.gameObject.SetActive(false);
            this.transform.position.Set(1.0f, 1.0f, 1.0f);
        }
    }
}
