using UnityEngine;

namespace Assets.Scripts
{
    abstract class SceneLoader : MonoBehaviour
    {
        abstract public void LoadScene(Scenes scene);
    }
}
