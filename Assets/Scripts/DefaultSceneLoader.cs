using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class DefaultSceneLoader : SceneLoader
    {
        public override void LoadScene(Scenes scene)
        {
            SceneManager.LoadScene((int)scene);
        }
    }
}
