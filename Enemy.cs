using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health;
    public string enemyType;

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
            return;
        }

        transform.LookAt(player);
        if(Vector3.Distance(agent.transform.position, player.transform.position) <= 0.5f)
        {
            return;
        }
        else if(Vector3.Distance(agent.transform.position, player.transform.position) > 0.5f)
        {
            agent.SetDestination(player.position);
        }
        //Debug.Log(agent.path.status);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
        {
            Destroy(gameObject);
            isDead = true;
            Debug.Log("Hand colided with Enemy", transform);
        }
    }
}
