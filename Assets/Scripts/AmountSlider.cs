using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dankolab.Test {
    public class AmountSlider : MonoBehaviour {
        [SerializeField]
        private Slider slider;

        [SerializeField]
        private TextMeshProUGUI valueText;

        private void Awake() {
            if (!slider) {
                slider = GetComponent<Slider>();
            }

            slider.value = Settings.DEFAULT_AMOUNT;
        }

        void Update() {
            valueText.text = slider.value.ToString();
        }

        public void OnValueChanged() {
            Settings.SetElementsAmount((int)slider.value);
        }
    }
}