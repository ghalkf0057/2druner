using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttors : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("maingamesscenes");
    }

    public void Restart()
    {
        SceneManager.LoadScene("maingamesscenes");
    }
}