using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {
	public float _autoLoadNextLevelAfter;
	void Start(){
		Invoke ("LoadNextLevel", _autoLoadNextLevelAfter);
	}
	public void LoadLevel(string name){
		Debug.Log ("Clicked Level load requested for : "+name);
		//Application.LoadLevel (name);
		SceneManager.LoadScene(name);
	}
	public void QuitRequest(){
		Debug.Log ("Requested for quit");
		Application.Quit();
	}
	public void LoadNextLevel(){
		//Application.LoadLevel (Application.loadedLevel + 1); //loaded level return int
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
	}

}