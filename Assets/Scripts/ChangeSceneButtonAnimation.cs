using Assets.Scripts;
using UnityEngine;

public class ChangeSceneButtonAnimation : MonoBehaviour
{
    [SerializeField] private Scenes _scene;
    [SerializeField] private AnimationSceneLoader _loader;

    private void OnMouseDown()
    {
        _loader.LoadScene(_scene);
    }
}
