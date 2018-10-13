using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loa : MonoBehaviour {

    // Use this for initialization
    public GameObject bed;
    public GameObject cabinet;
    public GameObject chair;
    public GameObject table;
    public GameObject sofa;
    public GameObject gm1;
	void Start () {
        
        print(sceneselect.text);
        bed = GameObject.Find("bed");
        bed.SetActive(false);
       cabinet = GameObject.Find("cabinet");
        cabinet.SetActive(false);
        chair= GameObject.Find("chair");
        chair.SetActive(false);
        table = GameObject.Find("table");
        table.SetActive(false);
        sofa= GameObject.Find("sofa");
        sofa.SetActive(false);
        switch(sceneselect.text)
        {
            case "bed":
                bed.SetActive(true);
                bed.transform.parent = gm1.transform;
                bed.transform.position = new Vector3(0, 0, 0);
                break;
            case "chair":
                chair.SetActive(true);
                chair.transform.parent = gm1.transform;
                chair.transform.position = new Vector3(0, 0, 0);
                break;
            case "cabinet":
                cabinet.SetActive(true);
                cabinet.transform.parent = gm1.transform;
                cabinet.transform.position = new Vector3(0, 0, 0);
                break;
            case "sofa":
                sofa.SetActive(true);
                sofa.transform.parent = gm1.transform;
                sofa.transform.position = new Vector3(0, 0, 0);
                break;
            case "table":
                table.SetActive(true);
                table.transform.parent = gm1.transform;
                table.transform.position = new Vector3(0, 0, 0);
                break;

        }
        // gm1 = GameObject.Find("InstantTrackable");
        //gm.transform.parent = gm1.transform;


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
