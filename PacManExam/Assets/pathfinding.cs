using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pathfinding : MonoBehaviour
{
    public GameObject pacman;
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        pacman = GameObject.Find("PacGuy");
        agent = this.transform.gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(pacman.transform.position);
    }
}
