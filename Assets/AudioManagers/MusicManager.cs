using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Allows the use of lists.

[RequireComponent (typeof (AudioSource))]

public class MusicManager : MonoBehaviour 
{

	public List <AudioClip> musicPlaylist;					// The list of songs that will be randomly chosen to play upon level load
	public static MusicManager instance = null;					// For the singleton pattern

	private AudioSource song;								// The chosen song from the list will be put in here
	private int repeatCheck = -1;							// Will check to make sure that a song on the list isn't chosen twice in a row
	private int randomSong;									// DO NOT INITIALIZE
	

	// Singleton Pattern
	void Awake ()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}
	
	// Function used to play the music
	public void Start () 
	{
		randomSong = Random.Range(0,4);						// Choose a random song from the list

		song = gameObject.GetComponent<AudioSource>();
		song.clip = musicPlaylist [randomSong];
		song.Play ();
		
	    repeatCheck = randomSong;
	}

	public void MusicChange ()
	{
		while (randomSong == repeatCheck)					// If chosen song is already playing...
		{
			randomSong = Random.Range (0,4);				// ...then choose again until the song is different. 
		}

		song = gameObject.GetComponent<AudioSource>();
		song.clip = musicPlaylist [randomSong];
		song.Play ();
		
		repeatCheck = randomSong;
	}
}
