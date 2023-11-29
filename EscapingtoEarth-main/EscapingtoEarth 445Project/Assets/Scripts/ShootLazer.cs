using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLazer : MonoBehaviour
{
    public float range = 10f;
    public float damage = 5f;

    Ray shootRay;
    RaycastHit shootHit;
    int shootableMask;
    LineRenderer gunLine;


void Awake () {
shootableMask = LayerMask.GetMask ("Shootable");
gunLine = GetComponent<LineRenderer>();
shootRay.origin = transform.position;
shootRay.direction = -transform.forward;
gunLine.SetPosition(0,transform.position);
if(Physics.Raycast (shootRay, out shootHit,range, shootableMask)){
    //Add hiting enemie part here.
    gunLine.SetPosition(1,shootHit.point);
}    
else gunLine.SetPosition(1, shootRay.origin+shootRay.direction*range);
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
