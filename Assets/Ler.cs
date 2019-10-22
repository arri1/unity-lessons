using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var a = 1;
        var b = 2;
        var c = a-b;
        Debug.Log(c);
        if (c>0) Debug.Log("c polozhitelnoe");
        else
            Debug.Log("c 0 ili otrcatelnoe");
        var d=new int[5]{0,1,2,3,4};
        Debug.Log(d[0]);
        int sum=0;
        for(int i = 0;i<5;i++)
        {
            sum=sum+d[i];
        }
        Debug.Log(sum);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
