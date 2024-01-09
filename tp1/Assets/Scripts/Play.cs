using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }
}