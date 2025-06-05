using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    private void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    private void Update()
    {
        navMeshAgent.SetDestination(player.position);
        if (Vector3.Distance(transform.position, player.position) <= 2f)
        {
            // Jouer l'animation d'attaque ici
        }

    }
}