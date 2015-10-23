using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent (typeof (AudioSource))]

public class MusicManager : MonoBehaviour 
{

	public List <AudioClip> musicPlaylist;
	public static MusicManager Instance;
	public bool random;
	private AudioSource src;
	private int repeatCheck = -1;


	// Use this for initialization
	void Awake ()
	{
		if (Instance != null && Instance != this)
			Destroy (gameObject);

		Instance = this;

		DontDestroyOnLoad (gameObject);
		src = this.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		int randomSong;

		if (Input.GetKeyDown ("space")) 
		{
			randomSong = Random.Range(0,4);
			while (randomSong == repeatCheck)
			{
				randomSong = Random.Range (0,4);
			}

			src.clip = musicPlaylist [randomSong];
			src.Play ();
			
		    repeatCheck = randomSong;
		}
	}
}
