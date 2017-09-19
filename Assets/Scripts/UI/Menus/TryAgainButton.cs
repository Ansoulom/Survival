using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainButton : MonoBehaviour
{
    public string Scene;


    public void StartGame()
    {
        SceneManager.LoadScene(Scene);
    }
}
