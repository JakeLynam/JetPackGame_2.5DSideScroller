using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour 
{
	public void LoadToScene (int SceneToLoad)
	{
		Application.LoadLevel (SceneToLoad);
	}

	
}
