using Assets.Scripts;
using UnityEngine;

public class ChangeSceneButton : MonoBehaviour
{
    [SerializeField] private Scenes _scene;
    [SerializeField] private SceneLoader _sceneLoader;

    private void OnMouseDown()
    {
        _sceneLoader.LoadScene(_scene);
    }
}
