using System.Collections.Generic;
using UnityEngine;

namespace Dankolab.Test {
    public class ScrollLoader : MonoBehaviour {
        [SerializeField]
        private GameObject _scrollButton;

        [SerializeField]
        private GameObject _scrollContainer;

        [SerializeField]
        private List<GameObject> _scrollElements;

        private void OnEnable() {
            for (var i = 0; i < Settings.ElementsAmount; i++) {
                _scrollElements.Add(Instantiate(_scrollButton, _scrollContainer.transform));
            }
        }

        private void OnDisable() {
            foreach (var elem in _scrollElements) {
                Destroy(elem);
            }
        }
    }
}