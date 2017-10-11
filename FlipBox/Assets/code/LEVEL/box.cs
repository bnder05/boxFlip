using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour {

    public levelData datalevel;
    public Color seleact;
    public Renderer m;
    Color c;
    void Start () {
        m = GetComponent<MeshRenderer>();
        c = m.material.color;
        datalevel = GameObject.FindGameObjectWithTag("level").GetComponent<levelData>();
	}
    private void OnMouseEnter()
    {
        m.material.color =Color.red;
    }
    private void OnMouseExit()
    {
        m.material.color =c;

    }
    private void OnMouseDown()
    {
        Instantiate(datalevel.boxSeleact, transform.position, Quaternion.identity,transform.parent);
          Destroy(this.gameObject);
        if (datalevel.boxSeleact == null || datalevel.GameOpjactInt ==0) print("i dont have box"); return;

    }
    // Update is called once per frame
    void Update () {
        if(datalevel.GameOpjactInt != 0) { datalevel.boxSeleact = datalevel.BoxsLevel[datalevel.GameOpjactInt]; } else { datalevel.boxSeleact = datalevel.BoxsLevel[0]; }

    }
}
