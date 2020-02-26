using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	public void loadscene1()
	{
		SceneManager.LoadScene (1);
	}

	public void loadscene2()
	{
		SceneManager.LoadScene (2);
	}

	public void loadscene3()
	{
		SceneManager.LoadScene (3);
	}

	public void MasterScene()
	{
		SceneManager.LoadScene (0);
	}

	public void Quit()
	{
		Application.Quit();
		Debug.Log ("quit");
	}
}
