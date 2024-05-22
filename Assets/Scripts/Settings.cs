namespace Dankolab.Test {
    public static class Settings {
        public const int DEFAULT_AMOUNT = 5;

        private static int _elementsAmount = 5;

        public static int ElementsAmount => _elementsAmount;

        public static void SetElementsAmount(int amount) {
            _elementsAmount = amount;
        }
    }
}