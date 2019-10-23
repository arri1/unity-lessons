using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingController : MonoBehaviour
{
    private static PoolingController instance;
 
 
    public static PoolingController getInstance()
    {

        if (instance == null)
            instance = FindObjectOfType<PoolingController>();
        return instance;
    }
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private List<GameObject> bullets;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetBullet()
    {
        GameObject bullet;
        if (bullets.Count == 0)

        {
            bullet = Instantiate(bulletPrefab);
            
        }
        else
        {
            bullet = bullets[0];
            bullets.Remove(bullet);
            bullet.transform.parent = null;
        }
        
        

        return bullet;
    }

    public void AddToPool(GameObject bullet)
    {
        bullets.Add(bullet);
        bullet.SetActive(false);
        bullet.transform.SetParent(transform);
    }
}
