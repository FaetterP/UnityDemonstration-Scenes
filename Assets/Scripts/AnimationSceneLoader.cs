using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    class AnimationSceneLoader : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        public void LoadScene(Scenes scene)
        {
            StartCoroutine(Load(scene));
        }

        private IEnumerator Load(Scenes scene)
        {
            _animator.SetTrigger("end");
            yield return new WaitForSeconds(_animator.GetCurrentAnimatorClipInfo(0)[0].clip.length);
            SceneManager.LoadScene((int)scene);
        }
    }
}
