using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distance : MonoBehaviour
{

    public GameObject tuzhi;
    public float Distance_;
    public Vector3 startscale;
    public int threshold1;
    public int threshold2;

    // Start is called before the first frame update
    void Start()
    {
        startscale = transform.localScale;
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance_ = Vector3.Distance(tuzhi.transform.position,Input.mousePosition);

        if (threshold1<Distance_&Distance_<threshold2)
        {
            transform.localScale = 6 * startscale/5;
         
        }
        else
        {
            transform.localScale = startscale;
        }
    }
}
