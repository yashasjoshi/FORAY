using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdditiveUnload : MonoBehaviour {

	public string LevelToUnload;

	public void unloadLevel() {
			SceneManager.UnloadSceneAsync (LevelToUnload);
	}
}
