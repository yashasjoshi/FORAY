using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AdditiveLevelUnload1 : 	MonoBehaviour {

	public string LevelToUnload;

	public void unloadLevel1() {
		//Load the level from LevelToLoad
		SceneManager.UnloadSceneAsync(LevelToUnload);
	}
}
