using UnityEngine;
using System.Collections;
using System.Collections.Generic; //Allows use of lists
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class SoundManager : MonoBehaviour 
{
	public List <AudioClip> foodSFX;
	public List <AudioClip> playerMoveSFX;
	public List <AudioClip> drinkSFX;
	public List <AudioClip> playerHurtSFX;
	public List <AudioClip> bushHitSFX;
	public AudioClip deathSFX;
	public AudioMixerGroup foodMix;
	public AudioMixerGroup playerMoveMix;
	public AudioMixerGroup drinkMix;
	public AudioMixerGroup playerHurtMix;
	public AudioMixerGroup bushHitMix;
	public AudioMixerGroup deathMix;

	public static SoundManager instance = null;

	private AudioSource chosenSound;


	void Awake () 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);

		DontDestroyOnLoad(gameObject);
	}
	

	public void PlayFoodSound () 
	{
		float randomPitch = Random.Range (.95f, 1.05f);

		chosenSound = gameObject.GetComponent<AudioSource>();
		chosenSound.clip = foodSFX [Random.Range (0, foodSFX.Count)];
		chosenSound.pitch = randomPitch;
		chosenSound.outputAudioMixerGroup = foodMix;
		chosenSound.Play();
	}

	public void PlayMoveSound ()
	{
		float randomPitch = Random.Range (.95f, 1.05f);

		chosenSound = gameObject.GetComponent<AudioSource>();
		chosenSound.clip = playerMoveSFX [Random.Range (0, playerMoveSFX.Count)];
		chosenSound.pitch = randomPitch;
		chosenSound.outputAudioMixerGroup = playerMoveMix;
		chosenSound.Play();
	}

	public void PlayDrinkSound ()
	{
		float randomPitch = Random.Range (.95f, 1.05f);

		chosenSound = gameObject.GetComponent<AudioSource>();
		chosenSound.clip = drinkSFX [Random.Range (0, drinkSFX.Count)];
		chosenSound.pitch = randomPitch;
		chosenSound.outputAudioMixerGroup = drinkMix;
		chosenSound.Play();
	}

	public void PlayHurtSound ()
	{
		float randomPitch = Random.Range (.95f, 1.05f);

		chosenSound = gameObject.GetComponent<AudioSource>();
		chosenSound.clip = playerHurtSFX [Random.Range (0, playerHurtSFX.Count)];
		chosenSound.pitch = randomPitch;
		chosenSound.outputAudioMixerGroup = playerHurtMix;
		chosenSound.Play();
	}

	public void PlayBushSound()
	{
		float randomPitch = Random.Range (.95f, 1.05f);

		chosenSound = gameObject.GetComponent<AudioSource>();
		chosenSound.clip = bushHitSFX [Random.Range (0, bushHitSFX.Count)];
		chosenSound.pitch = randomPitch;
		chosenSound.outputAudioMixerGroup = bushHitMix;
		chosenSound.Play();
	}

	public void PlayDeathSound()
	{
		chosenSound = gameObject.GetComponent<AudioSource>();
		chosenSound.clip = deathSFX;
		chosenSound.outputAudioMixerGroup = deathMix;
		chosenSound.Play();
	}
}
