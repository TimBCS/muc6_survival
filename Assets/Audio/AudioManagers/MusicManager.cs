using UnityEngine;
using System.Collections;
using System.Collections.Generic; // Able to use lists
using UnityEngine.Audio; //Able to reference mixers

//The GameObject requires an Audio Source.
[RequireComponent (typeof (AudioSource))]

public class MusicManager : MonoBehaviour 
{
	public List <AudioClip> music;
	public List <AudioMixerGroup> mixers;
	public AudioClip gameOverSong;
	public AudioMixerGroup gameOverMixer;
	public static MusicManager instance = null;

	private int songAndMixer;
	private int repeatCheck;
	private AudioSource chosenSong;


	void Awake () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		DontDestroyOnLoad (gameObject);
	}

	void Start () 
	{
		songAndMixer = Random.Range(0, 5);

		chosenSong = gameObject.GetComponent<AudioSource>();
		chosenSong.clip = music [songAndMixer];
		chosenSong.outputAudioMixerGroup = mixers [songAndMixer];
		chosenSong.Play();

		repeatCheck = songAndMixer;
	}

	public void MusicChange()
	{
		while (repeatCheck == songAndMixer) 
		{
			songAndMixer = Random.Range(0, music.Count);
		}

		chosenSong = gameObject.GetComponent<AudioSource>();
		chosenSong.clip = music [songAndMixer];
		chosenSong.outputAudioMixerGroup = mixers [songAndMixer];
		chosenSong.Play();

		repeatCheck = songAndMixer;
	}

	public void GameOverSong ()
	{
		chosenSong = gameObject.GetComponent<AudioSource>();
		chosenSong.clip = gameOverSong;
		chosenSong.outputAudioMixerGroup = gameOverMixer;
		chosenSong.Play();
	}
}
