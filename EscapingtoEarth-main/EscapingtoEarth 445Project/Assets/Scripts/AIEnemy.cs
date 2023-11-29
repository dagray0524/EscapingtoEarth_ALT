using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 PlayerPosition;
        public float speed;
    [SerializeField]
    private bool DevChaseActive;
    private Vector3 RayCastDirection;

    private float distance;
    void Start()
    {
        
        DevChaseActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPosition = player.gameObject.transform.position;
        EnemyDetection();
        //Debug.Log(PlayerPosition);

    }
    
   
    private void Chase()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    }
 
     void EnemyDetection()
    {
         RayCastDirection = PlayerPosition - transform.position;
        if(Physics.Raycast(transform.position, transform.TransformDirection(RayCastDirection), out RaycastHit hitinfo, 20f) || Physics.Raycast(transform.position, transform.TransformDirection(RayCastDirection), out hitinfo, 20f))
        {
            Debug.Log("Hit something");
            Debug.DrawRay(transform.position, transform.TransformDirection(RayCastDirection) * hitinfo.distance, Color.red);
            ///Debug.DrawRay(transform.position, transform.TransformDirection(RayCastDirection) * hitinfo.distance, Color.red);
            if (DevChaseActive)
            {
                Chase();
            }
        }
        else
        {
            Debug.Log("Nothing");
            Debug.DrawRay(transform.position, transform.TransformDirection(RayCastDirection) * 20f, Color.green);
           // Debug.DrawRay(transform.position, transform.TransformDirection(RayCastDirection) * 20f, Color.green);
        }
    }
}
