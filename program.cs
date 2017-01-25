using System;

class Program
{
    static void Main()
  {
	// 入力を促すメッセージを表示して、文字を入力してもらう
	Console.Write("あなたのお名前は? : ");
	var name = Console.ReadLine();

	// 入力を促すメッセージを表示して、数値を入力してもらう
	Console.Write("あなたの年齢は? : ");
	var age = int.Parse(Console.ReadLine());

	// メッセージの出力
	Console.WriteLine("{0} ({1}歳)さん、ようこそお越しくださいました。", name, age);
   } 
}
