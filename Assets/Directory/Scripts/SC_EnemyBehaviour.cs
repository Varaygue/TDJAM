using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_EnemyBehaviour : MonoBehaviour
{
    public float movementSpeed = 5;
    public float enemyHP = 3;
    public Animator enemyAnim;
    public float deathTimer = 1;
    public float animationReset =0.5f;
    public GameObject GameManager;
    public bool enemyDeath;
    // Start is called before the first frame update
    void Start()
    {
        enemyDeath=false;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(-movementSpeed*Time.deltaTime,0,0);
        
        if(enemyHP==0&&!enemyDeath)
        {
            enemyDeath=true;
        }
        if(enemyHP<=0)
        {
            EnemyDeath();
        }

        if(deathTimer<=0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Arrow")&&!enemyDeath)
        {
            enemyHP = enemyHP-1;
        }
    }

    public void EnemyDeath()
    {
        movementSpeed=0;
        deathTimer -= Time.deltaTime;
    }
}
