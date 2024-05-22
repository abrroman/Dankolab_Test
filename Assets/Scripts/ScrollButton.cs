using UnityEngine;

namespace Dankolab.Test {
    public class ScrollButton : MonoBehaviour {
        public void OnButtonClick() {
            Destroy(gameObject);
        }
    }
}