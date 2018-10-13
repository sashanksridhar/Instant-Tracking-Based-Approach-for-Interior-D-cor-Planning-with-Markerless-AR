using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class sceneselect : MonoBehaviour {
    public static string text;
    public GameObject gm;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void changeScene()
    {
        text = gm.GetComponentInChildren<Text>().text;
        SceneManager.LoadScene(1);
    }

}
