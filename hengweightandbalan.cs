using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hengweightandbalan : MonoBehaviour
{
    public static float hengweight;

    public static float zhuweight;
    public static float zhiweight;
    public static float xianweight;

    public GameObject hengzhu;
    public GameObject hengzhi;
    public GameObject hengxian;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zhuweight=
        hengweight = zhuweight + zhiweight + xianweight;
    }
}
