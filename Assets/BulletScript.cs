using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody _rigidbody;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fire(Transform barrel)
    {
        gameObject.SetActive(true);
        transform.position = barrel.position;
        _rigidbody.velocity=barrel.forward*10;
    }

    private void OnCollisionEnter(Collision other)
    {
        PoolingController.getInstance().AddToPool(gameObject);
        
    }
}
