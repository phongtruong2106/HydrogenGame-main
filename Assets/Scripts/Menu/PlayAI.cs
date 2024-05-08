using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAI : MonoBehaviour
{
    [SerializeField] protected string sceneName;
    public virtual void OpenScense()
    {
        SceneManager.LoadScene(sceneName);
    }
}