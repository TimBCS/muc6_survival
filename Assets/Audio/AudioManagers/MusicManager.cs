using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Able to use lists
using UnityEditor.Audio; //Able to reference mixers

//The GameObject requires an Audio Source.
[RequireComponent (typeof (AudioSource))]

public class MusicManager : MonoBehaviour 
{

	public List <AudioClip> music;
	public List <AudioMixerGroup> mixers;
	public static MusicManager instance = null;

	private int songAndMixer;


	void Awake () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
