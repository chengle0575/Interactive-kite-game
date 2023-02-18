using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weightcounter : MonoBehaviour
{
    public Text weightamout;
    public Text balancetext;
 
    public static double zhuweight;
    public static double zhiweight;
    public static double theweight;

    public static double leftweight;
    public static double rightweight;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zhuweight = bamoowearnew.hengzhuweight + bamotwearnew.shuzhuweight+ bamothrwearnew.piezhuweight+ bamofourwearnew.nazhuweight+ wearnewbam2.hengzhuweight+ bamttwearnew.shuzhuweight+ bamtthrwearnew.piezhuweight+ bamtfourwearnew.nazhuweight+ bamthro.hengzhuweight+ bamthrtwo.shuzhuweight+ bamthrthr.piezhuweight+ bamthrfour.nazhuweight+ bamfourone.hengzhuweight+ bamfourtwo.shuzhuweight+ bamfourthr.piezhuweight+ bamfourfour.nazhuweight;

        zhiweight = omian.hengzhiweight+ otwomian.shuzhiweight+ othrmian.piezhiweight+ ofourmian.nazhiweight+ tonegaoli.hengzhiweight+ ttwogaoli.shuzhiweight+ tthreegaoli.piezhiweight+ tfourgaoli.nazhiweight+ thronejuan.hengzhiweight+ thrtwojuan.shuzhiweight+ thrthrjuan.piezhiweight+ thrfourjuan.nazhiweight+ fouronewufangbu.hengzhiweight+ fourtwowufangbu.shuzhiweight+ fourthrwufangbu.piezhiweight+ fourfourwufangbu.nazhiweight;

        theweight = zhuweight + zhiweight;

        weightamout.text = "重量="+theweight;



        leftweight = bamothrwearnew.piezhuweight + bamtthrwearnew.piezhuweight+ bamthrthr.piezhuweight+ bamfourthr.piezhuweight+ othrmian.piezhiweight+ tthreegaoli.piezhiweight+ thrthrjuan.piezhiweight+ fourthrwufangbu.piezhiweight;
        rightweight = bamofourwearnew.nazhuweight+ bamtfourwearnew.nazhuweight+ bamthrfour.nazhuweight+ bamfourfour.nazhuweight+ ofourmian.nazhiweight+ tfourgaoli.nazhiweight+ thrfourjuan.nazhiweight + fourfourwufangbu.nazhiweight;

        if (leftweight < rightweight)
        {
            balancetext.text = "右侧太沉，不平衡啦";
        }
        if(leftweight > rightweight)
        {
            balancetext.text = "左侧太沉，不平衡啦";
        }
        if (leftweight == rightweight)
        {
            balancetext.text = "恰好平衡";
        }



    }



}
