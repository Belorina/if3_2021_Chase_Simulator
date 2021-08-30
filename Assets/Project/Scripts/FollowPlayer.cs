using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;    //  represente le joueur 
    private NavMeshAgent agent; // agant = enemy 

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();   // aller recuperer le component et la metre dans la variable
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }
}
