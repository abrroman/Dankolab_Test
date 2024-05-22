using UnityEngine;

namespace Dankolab.Test {
    public class ExitButton : MonoBehaviour {
        [SerializeField]
        private GameObject _mainMenu;

        public void OnExitButtonClick() {
            gameObject.SetActive(false);
            _mainMenu.SetActive(true);
        }
    }
}