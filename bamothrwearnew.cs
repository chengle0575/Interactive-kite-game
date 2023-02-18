using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bamothrwearnew : MonoBehaviour
{

    public static double piezhuweight;
    public GameObject material;
    public GameObject tuzhi;
    public float distance_;
    public Image dresson;
    public int threshold0;
    Vector2 startpos;
    Vector2 currentpos;



    // Start is called before the first frame update
    void Start()
    {
        startpos = material.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distance_ = Vector3.Distance(material.transform.position, tuzhi.transform.position);

        currentpos = material.transform.position;


        if (startpos != currentpos)
        {
            if (distance_ < threshold0)
            {
                dresson.sprite = Resources.Load<Sprite>("pie1");
                piezhuweight = 12.4;
            }


        }
        else
        {
            piezhuweight = 0;
        }


    }
}
