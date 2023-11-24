using System.Collections.Generic;

namespace Practice7_1_1 {
    public static class KeyValuePairExtensions {

        /// <summary>
        /// 分解構文を有効にします。
        /// </summary>
        /// <example>
        /// <code><![CDATA[
        /// foreach ((int wCD, string wName) in wDictionary) {
        /// }
        /// ]]></code>
        /// </example>
        public static void Deconstruct<TKey, TValue>(this KeyValuePair<TKey, TValue> vPair, out TKey vKey, out TValue vValue) {
            vKey = vPair.Key;
            vValue = vPair.Value;
        }
    }
}
