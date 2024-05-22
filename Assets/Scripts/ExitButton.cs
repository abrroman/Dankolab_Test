using UnityEngine;

namespace Dankolab.Test {
    public class ExitButton : MonoBehaviour {
        [SerializeField]
        private GameObject mainMenu;

        public void OnExitButtonClick() {
            gameObject.SetActive(false);
            mainMenu.SetActive(true);
        }
    }
}