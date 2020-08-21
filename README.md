# UniDictionaryExtensionMethods

Dictionary 型の拡張メソッド

## GetOrDefault

```cs
using Kogane;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    private void Awake()
    {
        var dictionary = new Dictionary<int, string>();

        // 指定したキーの要素を取得
        // 指定したキーが存在しない場合は既定値もしくは引数の最後に渡した値が返ってきます
        Debug.Log( dictionary.GetOrDefault( 1 ) ); // Null
        Debug.Log( dictionary.GetOrDefault( 1, "フシギダネ" ) ); // フシギダネ
    }
}
```
