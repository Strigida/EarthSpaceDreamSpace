using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health;
    public string enemyType;
    public float distanceToPlayer;

    UnityEngine.AI.NavMeshAgent agent;

    private Transform player;
    private bool isDead;
    
	void Start () {
        isDead = false;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        Debug.Log("started Enemy Script", transform);
	}
	
	// Update is called once per frame
	void Update () {
		if (isDead)
        {
            Debug.Log("Enemy Dead.");
            return;
        }

        transform.LookAt(player);
        agent.SetDestination(player.position);
        /*distanceToPlayer = Vector3.Distance(player.transform.position, agent.transform.position);
        if(distanceToPlayer <= 1f)
        {
            Debug.Log("Stopping.");
            return;
        }
        else if(distanceToPlayer > 1f)
        {
            Debug.Log("Chasing player;");
            
        }*/
        //Debug.Log(agent.path.status);
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Not the Droid Collisions you're looking for...");

        if (other.gameObject.tag == "hand")
        {
            Destroy(gameObject);
            isDead = true;
            Debug.Log("Hand collided with Enemy", transform);
        }
    }
}
