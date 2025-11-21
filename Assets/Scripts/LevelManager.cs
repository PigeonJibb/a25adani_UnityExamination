using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadNewLevel()
    {
        if (SceneManager.GetActiveScene().name == "Examination_level1")
        {
            SceneManager.LoadScene("Examination_level2");
        }
        else
            SceneManager.LoadScene("Examination_level1");
    }
}
