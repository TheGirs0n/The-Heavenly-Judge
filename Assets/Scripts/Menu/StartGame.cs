using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class StartGame : MonoBehaviour
    {
        public void StartGameButton()
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
