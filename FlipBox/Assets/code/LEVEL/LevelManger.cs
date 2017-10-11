using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManger : MonoBehaviour {

    levelData datalevel;



    private void Start()
    {
        datalevel = GetComponent<levelData>();
        int v = datalevel.Waiht / 2 ;
        int b = datalevel.Hight / 2;
        gameObject.transform.position = new Vector3(-v, b, 0f);


        for(int x=0;x <= datalevel.Waiht;x++)
        {
            for (int y = 0; y <= datalevel.Waiht; y++)
            {
                Instantiate(datalevel.boxLevel, new Vector3(v - x, b - y, 0f), Quaternion.identity, transform);
                if(x > datalevel.Waiht) { y++; }
            }
        }
    }


}
