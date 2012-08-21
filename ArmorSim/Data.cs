using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;

namespace ArmorSim
{
	public class Option : ICloneable
	{
		[Category("0係数")]
		public double 好み係数 { get; set; }
		[Category("0係数")]
		public double 耐久度係数 { get; set; }
		[Category("0係数")]
		public double 物理係数 { get; set; }
		[Category("0係数")]
		public double 打撃係数 { get; set; }
		[Category("0係数")]
		public double 斬撃係数 { get; set; }
		[Category("0係数")]
		public double 刺突係数 { get; set; }
		[Category("0係数")]
		public double 魔法係数 { get; set; }
		[Category("0係数")]
		public double 炎係数 { get; set; }
		[Category("0係数")]
		public double 雷係数 { get; set; }
		[Category("0係数")]
		public double 強靭係数 { get; set; }
		[Category("0係数")]
		public double 出血係数 { get; set; }
		[Category("0係数")]
		public double 毒係数 { get; set; }
		[Category("0係数")]
		public double 呪係数 { get; set; }
		[Category("1下限")]
		public double 好み下限 { get; set; }
		[Category("1下限")]
		public double 耐久度下限 { get; set; }
		[Category("1下限")]
		public double 物理下限 { get; set; }
		[Category("1下限")]
		public double 打撃下限 { get; set; }
		[Category("1下限")]
		public double 斬撃下限 { get; set; }
		[Category("1下限")]
		public double 刺突下限 { get; set; }
		[Category("1下限")]
		public double 魔法下限 { get; set; }
		[Category("1下限")]
		public double 炎下限 { get; set; }
		[Category("1下限")]
		public double 雷下限 { get; set; }
		[Category("1下限")]
		public double 強靭下限 { get; set; }
		[Category("1下限")]
		public double 出血下限 { get; set; }
		[Category("1下限")]
		public double 毒下限 { get; set; }
		[Category("1下限")]
		public double 呪下限 { get; set; }
		/// <summary>コンストラクタ</summary>
		public Option()
		{
			物理係数 = 0.06;
			打撃係数 = 斬撃係数 = 刺突係数 = 0.02;
			魔法係数 = 0.08;
			炎係数 = 雷係数 = 0.1;
			強靭係数 = 0.02;
			出血係数 = 0;
			毒係数 = 呪係数 = 0.01;
		}
		public object Clone()
		{
			return MemberwiseClone();
		}
	}
	public enum EPart
	{
		兜 = 0,
		鎧,
		手甲,
		足甲,
		なし,
	}
	public enum EType
	{
		通常,
		光,
		不可,
	}
	public enum ECond
	{
		全て = 0,
		なし,
		固定,
	}
	public class Item
	{
		public EPart 部位 { get; set; }
		public string 名称 { get; set; }
		public EType 強化 { get; set; }
		public bool 原盤 { get; set; }
		public int 重量 { get; set; }
		public double 好み { get; set; }
		public double 耐久度 { get; set; }
		public double 物理 { get; set; }
		public double 打撃 { get; set; }
		public double 斬撃 { get; set; }
		public double 刺突 { get; set; }
		public double 魔法 { get; set; }
		public double 炎 { get; set; }
		public double 雷 { get; set; }
		public double 強靭 { get; set; }
		public double 出血 { get; set; }
		public double 毒 { get; set; }
		public double 呪 { get; set; }
		public static Item Empty = new Item();
		/// <summary>コンストラクタ</summary>
		public Item() { 部位 = EPart.なし; }
		/// <summary>コンストラクタ</summary>
		public Item(string[] ss)
		{
			int i = 0;
			部位 = (EPart)int.Parse(ss[++i]);
			名称 = ss[++i];
			強化 = (EType)Enum.Parse(typeof(EType), ss[++i]);
			原盤 = ss[++i] != "0";
			重量 = (int)Math.Round(double.Parse(ss[++i]) * Data.Coe);
			好み = double.Parse(ss[++i]);
			耐久度 = double.Parse(ss[++i]);
			物理 = double.Parse(ss[++i]);
			打撃 = double.Parse(ss[++i]);
			斬撃 = double.Parse(ss[++i]);
			刺突 = double.Parse(ss[++i]);
			魔法 = double.Parse(ss[++i]);
			炎 = double.Parse(ss[++i]);
			雷 = double.Parse(ss[++i]);
			強靭 = double.Parse(ss[++i]);
			出血 = double.Parse(ss[++i]);
			毒 = double.Parse(ss[++i]);
			呪 = double.Parse(ss[++i]);
		}
		public string 表示名()
		{
			if (部位 == EPart.なし) return "なし";
			var s = 名称;
			if (強化 == EType.光) s += "+5";
			else if (強化 == EType.通常) s += 原盤 ? "+10" : "+9";
			return s;
		}
	}
	public class Answer : IComparable<Answer>
	{
		public int 順位 { get; set; }
		public double 重量 { get; set; }
		public double 値 { get; set; }
		public int id兜 { get; set; }
		public int id鎧 { get; set; }
		public int id手甲 { get; set; }
		public int id足甲 { get; set; }
		/// <summary>コンストラクタ</summary>
		public Answer() { }
		/// <summary>コンストラクタ</summary>
		public Answer(double w, double v, int i1, int i2, int i3, int i4)
		{
			重量 = w;
			値 = v;
			id兜 = i1;
			id鎧 = i2;
			id手甲 = i3;
			id足甲 = i4;
		}
		public string 説明()
		{
			return string.Format("{0,2}位 重量={1,-4} 値={2,-5}", 順位, 重量, 値);
		}
		public string Result(Data dd)
		{
			var sb = new StringBuilder();
			var it1 = id兜 < 0 ? Item.Empty : dd.List兜[id兜];
			var it2 = id鎧 < 0 ? Item.Empty : dd.List鎧[id鎧];
			var it3 = id手甲 < 0 ? Item.Empty : dd.List手甲[id手甲];
			var it4 = id足甲 < 0 ? Item.Empty : dd.List足甲[id足甲];
			sb.AppendLine(説明());
			sb.AppendLine(" 兜:" + it1.表示名());
			sb.AppendLine(" 鎧:" + it2.表示名());
			sb.AppendLine(" 手:" + it3.表示名());
			sb.AppendLine(" 足:" + it4.表示名());
			//sb.AppendLine();
			var dt = dd.GetSum(it1, it2, it3, it4);
			sb.AppendFormat(" 好み={0} 耐久度={1} 物理={2} 打撃={3} 斬撃={4} 刺突={5} 魔法={6} 炎={7} 雷={8} 強靭={9} 出血={10} 毒={11} 呪={12}",
				dt[0], dt[1], dt[2], dt[3], dt[4], dt[5], dt[6], dt[7], dt[8], dt[9], dt[10], dt[11], dt[12]);
			return sb.ToString();
		}
		public int CompareTo(Answer other)
		{
			return other.値.CompareTo(値);
		}
	}
	public class Data
	{
		public const int Coe = 40000;
		internal int _装備以外重量;
		public double 装備以外重量
		{
			get { return (double)_装備以外重量 / Coe; }
			set { _装備以外重量 = (int)Math.Round(value * Coe); }
		}
		public int 持久力 { get; set; }
		public int 順位数 { get; set; }
		internal int _装備重量;
		public double 装備重量
		{
			get { return (double)_装備重量 / Coe; }
			set { _装備重量 = (int)Math.Round(value * Coe); }
		}
		public int 割合 { get; set; }
		public bool 原盤 { get; set; }
		public bool 寵愛と加護の指輪 { get; set; }
		public bool ハベルの指輪 { get; set; }
		public bool 通常 { get; set; }
		public bool 光 { get; set; }
		public bool 不可 { get; set; }
		public ECond 兜条件 { get; set; }
		public ECond 鎧条件 { get; set; }
		public ECond 手甲条件 { get; set; }
		public ECond 足甲条件 { get; set; }
		public string 固定兜 { get; set; }
		public string 固定鎧 { get; set; }
		public string 固定手甲 { get; set; }
		public string 固定足甲 { get; set; }
		public List<Item> List兜;
		public List<Item> List鎧;
		public List<Item> List手甲;
		public List<Item> List足甲;
		public Option Option;
		public List<Answer> ListAnswer;
		/// <summary>コンストラクタ</summary>
		public Data()
		{
			持久力 = 0;
			順位数 = 10;
			装備以外重量 = 10.5;
			装備重量 = 48;
			割合 = 1;
			ハベルの指輪 = 原盤 = false;
			通常 = 光 = 不可 = true;
			List兜 = new List<Item>();
			List鎧 = new List<Item>();
			List手甲 = new List<Item>();
			List足甲 = new List<Item>();
			Option = new Option();
			ListAnswer = new List<Answer>();
		}
		/// <summary>コンストラクタ</summary>
		public Data(string csv) : this()
		{
			List<Item>[] lsts = { List兜, List鎧, List手甲, List足甲 };
			using (var sr = new StreamReader(csv, Encoding.GetEncoding(932)))
			{
				string s = sr.ReadLine(); // ヘッダ
				while ((s = sr.ReadLine()) != null)
				{
					var ss = s.Split(',');
					if (ss[0] == "0" || ss.Length < 19) continue;
					try
					{
						var it = new Item(ss);
						lsts[int.Parse(ss[1])].Add(it);
					}
					catch
					{
						continue;
					}
				}
			}
		}
		public double[] GetSum(Item it1, Item it2, Item it3, Item it4)
		{
			double d1 = it1.好み + it2.好み + it3.好み + it4.好み;
			double d2 = it1.耐久度 + it2.耐久度 + it3.耐久度 + it4.耐久度;
			double d3 = it1.物理 + it2.物理 + it3.物理 + it4.物理;
			double d4 = it1.打撃 + it2.打撃 + it3.打撃 + it4.打撃;
			double d5 = it1.斬撃 + it2.斬撃 + it3.斬撃 + it4.斬撃;
			double d6 = it1.刺突 + it2.刺突 + it3.刺突 + it4.刺突;
			double d7 = it1.魔法 + it2.魔法 + it3.魔法 + it4.魔法;
			double d8 = it1.炎 + it2.炎 + it3.炎 + it4.炎;
			double d9 = it1.雷 + it2.雷 + it3.雷 + it4.雷;
			double d10 = it1.強靭 + it2.強靭 + it3.強靭 + it4.強靭;
			double d11 = it1.出血 + it2.出血 + it3.出血 + it4.出血;
			double d12 = it1.毒 + it2.毒 + it3.毒 + it4.毒;
			double d13 = it1.呪 + it2.呪 + it3.呪 + it4.呪;
			return new double[] { d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13 };
		}
		public double Calc(Item it1, Item it2, Item it3, Item it4)
		{
			var dt = GetSum(it1, it2, it3, it4);
			if (dt[0] < Option.好み下限) return double.MinValue;
			if (dt[1] < Option.耐久度下限) return double.MinValue;
			if (dt[2] < Option.物理下限) return double.MinValue;
			if (dt[3] < Option.打撃下限) return double.MinValue;
			if (dt[4] < Option.斬撃下限) return double.MinValue;
			if (dt[5] < Option.刺突下限) return double.MinValue;
			if (dt[6] < Option.魔法下限) return double.MinValue;
			if (dt[7] < Option.炎下限) return double.MinValue;
			if (dt[8] < Option.雷下限) return double.MinValue;
			if (dt[9] < Option.強靭下限) return double.MinValue;
			if (dt[10] < Option.出血下限) return double.MinValue;
			if (dt[11] < Option.毒下限) return double.MinValue;
			if (dt[12] < Option.呪下限) return double.MinValue;
			return dt[0] * Option.好み係数
				+ dt[1] * Option.耐久度係数
				+ dt[2] * Option.物理係数
				+ dt[3] * Option.打撃係数
				+ dt[4] * Option.斬撃係数
				+ dt[5] * Option.刺突係数
				+ dt[6] * Option.魔法係数
				+ dt[7] * Option.炎係数
				+ dt[8] * Option.雷係数
				+ dt[9] * Option.強靭係数
				+ dt[10] * Option.出血係数
				+ dt[11] * Option.毒係数
				+ dt[12] * Option.呪係数;
		}
		public void Solve(int[] sels)
		{
			var lst = new LinkedList<Answer>();
			int limit0 = GetLimit();
			for (int i1 = -(int)兜条件 % 2; i1 < List兜.Count; ++i1)
			{
				if (兜条件 == ECond.なし && i1 == 0) break;
				if (兜条件 == ECond.固定 && i1 != sels[0] - 1) continue;
				var it1 = i1 < 0 ? Item.Empty : List兜[i1];
				int limit = it1.名称 == "父の仮面" ? (int)Math.Round(limit0 * 1.15) : limit0;
				int wgt1 = _装備以外重量 + it1.重量;
				if (!IsMatch(it1, 兜条件) || wgt1 > limit) continue;
				for (int i2 = -(int)鎧条件 % 2; i2 < List鎧.Count; ++i2)
				{
					if (鎧条件 == ECond.なし && i2 == 0) break;
					if (鎧条件 == ECond.固定 && i2 != sels[1] - 1) continue;
					var it2 = i2 < 0 ? Item.Empty : List鎧[i2];
					int wgt2 = wgt1 + it2.重量;
					if (!IsMatch(it2, 鎧条件) || wgt2 > limit) continue;
					for (int i3 = -(int)手甲条件 % 2; i3 < List手甲.Count; ++i3)
					{
						if (手甲条件 == ECond.なし && i3 == 0) break;
						if (手甲条件 == ECond.固定 && i3 != sels[2] - 1) continue;
						var it3 = i3 < 0 ? Item.Empty : List手甲[i3];
						int wgt3 = wgt2 + it3.重量;
						if (!IsMatch(it3, 手甲条件) || wgt3 > limit) continue;
						for (int i4 = -(int)足甲条件 % 2; i4 < List足甲.Count; ++i4)
						{
							if (足甲条件 == ECond.なし && i4 == 0) break;
							if (足甲条件 == ECond.固定 && i4 != sels[3] - 1) continue;
							var it4 = i4 < 0 ? Item.Empty : List足甲[i4];
							int wgt4 = wgt3 + it4.重量;
							if (!IsMatch(it4, 足甲条件) || wgt4 > limit) continue;
							var val = Calc(it1, it2, it3, it4);
							if (val == double.MinValue) continue;
							if (lst.Count == 順位数)
							{
								if (val <= lst.Last.Value.値) continue;
								lst.RemoveLast();
							}
							var pos = lst.First;
							while (pos != null && val < pos.Value.値) pos = pos.Next;
							var ans = new Answer((double)wgt4 / Coe, val, i1, i2, i3, i4);
							if (pos == null)
								lst.AddLast(ans);
							else lst.AddBefore(pos, ans);
						}
					}
				}
			}
			ListAnswer.Clear();
			foreach (var ans in lst) ListAnswer.Add(ans);
			for (int i = 0; i < ListAnswer.Count; ++i) ListAnswer[i].順位 = i + 1;
		}
		public bool IsMatch(Item it, ECond cnd)
		{
			if (it.部位 == EPart.なし || cnd == ECond.固定) return true;
			if (it.強化 == EType.通常 && !通常) return false;
			if (it.強化 == EType.光 && !光) return false;
			if (it.強化 == EType.不可 && !不可) return false;
			if (it.原盤 && !原盤) return false;
			if (!it.原盤 && 原盤 && it.強化 == EType.通常) return false;
			return true;
		}
		public int GetLimit()
		{
			int limit = _装備重量;
			if (寵愛と加護の指輪) limit = (int)Math.Round(limit * 1.2);
			if (ハベルの指輪) limit = (int)Math.Round(limit * 1.5);
			if (割合 == 1) limit /= 2;
			else if (割合 == 2) limit /= 4;
			return limit;
		}
		public static Data Load(string fnam)
		{
			Data dd;
			try
			{
				var xs = new XmlSerializer(typeof(Data));
				using (var sr = new StreamReader(fnam))
					dd = (Data)xs.Deserialize(sr);
			}
			catch
			{
				throw;
			}
			return dd;
		}
		public void Save(string fnam)
		{
			var xs = new XmlSerializer(typeof(Data));
			using (var sw = new StreamWriter(fnam))
				xs.Serialize(sw, this);
		}
	}
}
