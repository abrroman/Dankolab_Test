using System.Collections.Generic;
using UnityEngine;

namespace Dankolab.Test {
    public class ScrollLoader : MonoBehaviour {
        [SerializeField]
        private GameObject scrollButton;

        [SerializeField]
        private GameObject scrollContainer;

        [SerializeField]
        private List<GameObject> scrollElements;

        private void OnEnable() {
            for (var i = 0; i < Settings.ElementsAmount; i++) {
                scrollElements.Add(Instantiate(scrollButton, scrollContainer.transform));
            }
        }

        private void OnDisable() {
            foreach (var elem in scrollElements) {
                Destroy(elem);
            }
        }
    }
}