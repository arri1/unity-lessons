using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem partical;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnParticleCollision(GameObject other)
    {
        Debug.Log("wqeqw");
    }
}