using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonInteractor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Update");
    }

    public void PointerExit()
    {
        Debug.Log("Pointer Exit");
    }

    public void PointerEnter()
    {
        Debug.Log("Pointer Enter");
        SceneManager.LoadScene("scene-menu");
   }

    public void PointerDown()
    {
        Debug.Log("Pointer Down");
    }
}
