using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    [SerializeField] private int _sceneNumber;

    private void OnMouseDown()
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
