using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dankolab.Test {
    public class AmountSlider : MonoBehaviour {
        [SerializeField]
        private Slider _slider;

        [SerializeField]
        private TextMeshProUGUI _valueText;

        public void OnValueChanged() {
            Settings.SetElementsAmount((int)_slider.value);
        }

        private void Awake() {
            if (!_slider) {
                _slider = GetComponent<Slider>();
            }

            _slider.value = Settings.DEFAULT_AMOUNT;
        }

        private void Update() {
            _valueText.text = _slider.value.ToString();
        }
    }
}