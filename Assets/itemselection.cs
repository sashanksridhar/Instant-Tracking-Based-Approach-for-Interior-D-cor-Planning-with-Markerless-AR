using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class itemselection : MonoBehaviour {
    public List<string> Items = new List<string>();
    public Button item;
    
    private int index = 0;
	// Use this for initialization
    public void rightSelect()
    {
        if (index == Items.Count -1)
        {
            index = 0;
        }
        else
        {
            index = index + 1;
        }
        item.GetComponentInChildren<Text>().text = Items[index];
    }
    public void leftSelect()
    {
        if (index == 0)
        {
            index = Items.Count;
        }
        if(index>0)
        {
            index--;
        }
        item.GetComponentInChildren<Text>().text = Items[index];
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
