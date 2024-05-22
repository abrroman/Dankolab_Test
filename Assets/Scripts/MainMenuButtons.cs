using UnityEngine;

namespace Dankolab.Test {
    public class MainMenuButtons : MonoBehaviour {
        [SerializeField]
        private GameObject settingsMenu;

        [SerializeField]
        private GameObject scrollGame;


        public void OnPlayButtonClick() {
            gameObject.SetActive(false);
            scrollGame.SetActive(true);
        }

        public void OnSettingsButtonClick() {
            gameObject.SetActive(false);
            settingsMenu.SetActive(true);
        }
    }
}