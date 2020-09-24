using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0924
{
	class Program
	{
		static void Main(string[] args)
		{
			#region 1. 예외처리구문 정의
			//try // 예외 처리 구문 : try ~ catch
			//    // try안에 선언되면 try안에서 밖에 못씀
			//{
			//	int p = 0;
			//	int k = 10 / p;  //0으로 나눌수 없어 예외 발생
			//	Console.WriteLine(k);
			//}
			//catch //예외가 발생했을때만 사용 아니면 다음으로 넘어간다
			//{
			//	Console.WriteLine("0으로 나눌수 없습니다");
			//}
			//string eee = Console.ReadLine(); // 예외가 발생해도 try~catch구문을 사용하면 끝나지않고 다음 코드로 넘어온다
			#endregion

			#region 2. 예외처리 종류 구분하는법
			//try // 예외 처리 구문 : try ~ catch
			//{
			//	int[] arr = new int[5] { 1, 2, 0, 4, 5 };
			//	Console.Write("몇번째 배열의 값으로 계산할까요? : ");
			//	int idx = int.Parse(Console.ReadLine());

			//	int p = arr[idx];
			//	int k = 10 / p;  
			//	Console.WriteLine(k);
			//}
			//catch (DivideByZeroException) //예외의 종류에 따라 구분을 하고싶으면 catch절을 사용 (if ~ else if 와 비슷)
			//{
			//	Console.WriteLine("0으로 나눌수 없습니다");
			//}
			//catch (IndexOutOfRangeException)
			//{
			//	Console.WriteLine("0~4 범위안의 수를 입력하세요.");
			//}
			////catch (Exception) //try~catch구문의 보험처럼 쓰인다 모든 에러는 Exception의 자식이니 이게 다 잡아줄거임
			////{
			////	Console.WriteLine("처리중 오류가 발생했습니다. 다시한번 시도해주세요.");
			////}
			//catch (Exception err) //err변수를 생성후 ==> 이것이 else문과 비슷
			//{
			//	Console.WriteLine(err.Message);// 예외를 출력해주는 Message를 사용해 뭐 때문에 오류가 난지 보여준다
			//}
			//// 이것만 써도 대부분 오류처리가 다된다 위에 catch절을 사용하는 이유는 최대한 사용자 친화적인 멘트를 보여주기위해

			//string eee = Console.ReadLine(); // 예외가 발생해도 try~catch구문을 사용하면 끝나지않고 다음 코드로 넘어온다
			#endregion

			#region 예외 발생 : Throw
			// 각각의 메서드에서 예외처리 하지말고 throw로 던져서 공통된 한자리에서만 예외처리를 한다면 더 좋기때문에 쓰는것이다
			// 결론은 다 던져서 한곳에서 공통된 방식으로 예외처리를 하면 좋다 ex) Main 함수
			try
			{
				BBB(); //메서드로 생성
				string eee = Console.ReadLine(); // 예외가 발생해도 try~catch구문을 사용하면 끝나지않고 다음 코드로 넘어온다
			}
			catch (Exception err)
			{
				Console.WriteLine(err.Message);
			}
			Console.ReadLine();
			#endregion
		}
		private static void BBB()
		{
			AAA();
		}
		static void AAA()
		{
			//try // 예외 처리 구문 : try ~ catch
			//{
				int[] arr = new int[5] { 1, 2, 0, 4, 5 };
				Console.Write("몇번째 배열의 값으로 계산할까요? : ");
				int idx = int.Parse(Console.ReadLine());

				if (idx < 0 || idx > 4)
				{
					//만약 throw를 했을때 아래 캐치문이 없다면 자신을 호출한 쪽으로 보내 호출한 쪽의 캐치문을 사용
					throw new /*Application*/Exception("0~4의 수 입력하세요"); // 한줄처리 (비지니스 로직 처리할때 쓴다)
					
					//Console.WriteLine("0~4의 수 입력하세요");
					//return;
				}

				int p = arr[idx];
				int k = 10 / p;
				Console.WriteLine(k);
			//}
			//catch (Exception err)
			//{
			//	throw err;
			//}
		}

	}
	
}

