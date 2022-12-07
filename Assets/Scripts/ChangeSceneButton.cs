using Assets.Scripts;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour
{
    [SerializeField] private Scenes _scene;

    private void OnMouseDown()
    {
        SceneManager.LoadScene((int)_scene);
    }
}
