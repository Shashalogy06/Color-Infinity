using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager1 : MonoBehaviour {

	// Use this for initialization
	public Canvas gameover;
	public Canvas pauseC;
	void Start () {
		gameover.enabled = false;
		pauseC.enabled = false;
		//finalscore = GetComponent<Text> ();
	}
	

	public void retry()
	{
		Time.timeScale = 1f;
		gameover.enabled = false;
		SceneManager.LoadScene ("Scene");
	}
	public void home()
	{
		Time.timeScale = 0;
		gameover.enabled = false;
		SceneManager.LoadScene ("front");
		Time.timeScale = 1f;
	}
	public void resume()
	{
		Time.timeScale = 1f;
		pauseC.enabled = false;
	}
	public void pause()
	{
		Time.timeScale = 0;
		pauseC.enabled = true;
	}
}
