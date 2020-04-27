using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	public void LoadNextScene()
	{
		CachedPlayerData.CachePlayerData();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
