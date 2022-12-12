using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    class AsyncSceneLoader : SceneLoader
    {
        [SerializeField] private GameObject _loadingGroup;
        [SerializeField] private Text _loadingText;
        [SerializeField] private Slider _loadingSlider;

        [SerializeField] private Animator _animator;

        override public void LoadScene(Scenes scene)
        {
            StartCoroutine(Load(scene));
        }

        private IEnumerator Load(Scenes scene)
        {
            _animator.SetTrigger("end");
            yield return new WaitForSeconds(_animator.GetCurrentAnimatorClipInfo(0)[0].clip.length);

            _loadingGroup.SetActive(true);
            AsyncOperation loading = SceneManager.LoadSceneAsync((int)scene);
            while (loading.isDone == false)
            {
                _loadingSlider.value = loading.progress;
                int progress = (int)(loading.progress * 100);
                _loadingText.text = $"{progress}%";
                yield return 0;
            }
        }
    }
}
