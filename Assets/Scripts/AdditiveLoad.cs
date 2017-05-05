using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdditiveLoad : MonoBehaviour {

	public bool Load;
	public string LevelToLoad;
	public bool Unload;
	public string LevelToUnload;

	public void loadUnloadLevel() {

		if (Load) {
			SceneManager.LoadSceneAsync (LevelToLoad, LoadSceneMode.Additive);
		}
		if (Unload) {
			SceneManager.UnloadSceneAsync (LevelToUnload);
		}



	}
}
