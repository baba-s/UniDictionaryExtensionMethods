using System.Collections;
using System.Collections.Generic;

namespace Kogane
{
	/// <summary>
	/// Dictionary 型の拡張メソッドを管理するクラス
	/// </summary>
	public static class DictionaryExt
	{
		//================================================================================
		// 関数(static)
		//================================================================================
		/// <summary>
		/// 指定したキーに関連付けられている値を取得します。キーが存在しない場合は既定値を返します
		/// </summary>
		public static TValue GetOrDefault<TKey, TValue>( this Dictionary<TKey, TValue> self, TKey key )
		{
			return self.GetOrDefault( key, default );
		}

		/// <summary>
		/// 指定したキーに関連付けられている値を取得します。キーが存在しない場合は既定値を返します
		/// </summary>
		public static TValue GetOrDefault<TKey, TValue>( this Dictionary<TKey, TValue> self, TKey key, TValue defaultValue )
		{
			return self.TryGetValue( key, out var value ) ? value : defaultValue;
		}
	}
}