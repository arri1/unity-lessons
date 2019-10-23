using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshPlayer : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Camera mainCam;
    [SerializeField] private Transform barrel;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                Debug.Log(hit.point);
                agent.SetDestination(hit.point);
                
            }
        }
        if (Input.GetButton("Fire2"))
        {
            fire();
        }
    }

    void fire()
    {
        
        GameObject bullet = PoolingController.getInstance().GetBullet();
        bullet.GetComponent<BulletScript>().Fire(barrel);        
        
    }
}