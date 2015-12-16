using UnityEngine;
using System.Collections;

namespace Completed
{	
	public class Loader : MonoBehaviour 
	{
		public GameObject gameManager;					//GameManager prefab to instantiate.
		
		
		void Awake ()
		{
			if (GameManager.instance == null)			//Check if a GameManager has already been assigned to static variable GameManager.instance or if it's still null
				Instantiate(gameManager);				//Instantiate gameManager prefab
		}
	}
}