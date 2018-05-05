using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanage : MonoBehaviour {

	// Use this for initialization
	//public Canvas retry;
	//public Canvas pause;
	bool checksound;
	void Start () {
		//front.enabled = true;
		checksound=false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void pplay()
	{
		Time.timeScale = 1f;
		//retry.enabled = false;
		//pause.enabled = false;
		SceneManager.LoadScene ("Scene");
	}
	public void ssound()
	{
		if (checksound == false) {
			AudioListener.pause = true;
			checksound = true;
		} else {
			AudioListener.pause = false;
			checksound = false;
		}
	}
	public void hhelp()
	{
		SceneManager.LoadScene ("help");
	}
	public void exit()
	{
		Application.Quit ();
	}
	public void home()
	{
		Time.timeScale = 0f;
		//gameover.enabled = false;
		SceneManager.LoadScene ("front");
		Time.timeScale = 1f;
	}
}
