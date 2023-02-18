using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class draggable : MonoBehaviour
{


    bool startdrag;

    //public GUI tryer;
    public GameObject material1;
    public GameObject material2;
    public GameObject material3;
    public GameObject material4;
    public GameObject[] materials;
    public Vector2[] startPoses;

    public GameObject tuzhi;
    public float distance_;
    public int threshold0;
    int j, r;
   



    // Start is called before the first frame update
    void Start()

    {
     
        materials = new GameObject[4];
        materials[0] = material1;
        materials[1] = material2;
        materials[2] = material3;
        materials[3] = material4;

        startPoses = new Vector2[4];
        startPoses[0] = material1.transform.position;
        startPoses[1] = material2.transform.position;
        startPoses[2] = material3.transform.position;
        startPoses[3] = material4.transform.position;


        Debug.Log("this is startpos"+ material1.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float x00 = Input.mousePosition.x - 711;
        float y00 = Input.mousePosition.y - 499;



        if (startdrag == true) 
            {

            materials[0].transform.position = new Vector3(x00, y00, 0);
           Debug.Log("worldmouse" + materials[0].transform.position);
           
        }

            distance_ = Vector3.Distance(materials[0].transform.position, tuzhi.transform.position);
        
        
    }

    public void StartDragUI()
    {
        startdrag = true;
    }

    public void StopDragUI()
    {

        startdrag = false;

        if (distance_ >= threshold0)
        {
            materials[0].transform.position = startPoses[0];
            return;
        }

        for (j = 1; j < 4; j = j + 1)
        {
            float other_distance = Vector3.Distance(materials[j].transform.position, tuzhi.transform.position);

            if (other_distance < threshold0)
            {
                materials[j].transform.position = startPoses[j];
            }
        }





    }







}
