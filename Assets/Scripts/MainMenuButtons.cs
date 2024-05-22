using UnityEngine;

namespace Dankolab.Test {
    public class MainMenuButtons : MonoBehaviour {
        [SerializeField]
        private GameObject _settingsMenu;

        [SerializeField]
        private GameObject _scrollGame;

        public void OnPlayButtonClick() {
            gameObject.SetActive(false);
            _scrollGame.SetActive(true);
        }

        public void OnSettingsButtonClick() {
            gameObject.SetActive(false);
            _settingsMenu.SetActive(true);
        }
    }
}