using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {
	public AudioClip[] levelMusicChangeArray;
	private AudioSource audioSource;
	private int activeSceneIndex;

	void Awake(){
		DontDestroyOnLoad (gameObject);
		Debug.Log ("DontDestroyOnLoad"+name);
	}

	void Start(){
		audioSource = GetComponent<AudioSource> ();
	}
	//-------------OnLevelWasLoaded()-------------In Unity 5
	void OnEnable()
	{
		SceneManager.activeSceneChanged += OnSceneLoaded;
	}

	void OnDisable()
	{
		SceneManager.activeSceneChanged -= OnSceneLoaded;
	}
	private void OnSceneLoaded(Scene lastScene, Scene newScene)
	{
		AudioClip audioClip = levelMusicChangeArray[newScene.buildIndex];
		Debug.Log ("Music Loaded at Scene" + newScene.buildIndex);
		if (!audioClip) return;
		audioSource.clip = audioClip;
		audioSource.loop = true;
		audioSource.Play();
	}
	//------------------------------------------------------
}
