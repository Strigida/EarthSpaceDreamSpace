using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health;
    public string enemyType;

    UnityEngine.AI.NavMeshAgent agent;

    private Transform player;
    private bool isDead;

	// Use this for initialization
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
        agent.SetDestination(player.position);
        //Debug.Log(agent.path.status);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "hand")
            Destroy(gameObject);
        Debug.Log("Hand colided with Enemy", transform);
    }
}
