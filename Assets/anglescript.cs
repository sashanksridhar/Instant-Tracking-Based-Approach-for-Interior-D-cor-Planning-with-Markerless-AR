using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class anglescript : MonoBehaviour {
    private GameObject gm;
    public Slider sliderx;
    public Slider slidery;
    public Slider sliderz;
    // Use this for initialization
    void Start () {
        gm = GameObject.Find(sceneselect.text);
        gm.transform.rotation = Quaternion.Euler(sliderx.value, slidery.value, sliderz.value);
        
    }
	
	// Update is called once per frame
	void Update () {
        sliderx.onValueChanged.AddListener(delegate { valchange(); });
        slidery.onValueChanged.AddListener(delegate { valchange(); });
        sliderz.onValueChanged.AddListener(delegate { valchange(); });
    }
    void valchange()
    {
        gm.transform.rotation = Quaternion.Euler(sliderx.value, slidery.value, sliderz.value);
    }
}
