using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("spawn_test");
    }
}
