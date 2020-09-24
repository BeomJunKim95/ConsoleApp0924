using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0924
{
	class SingleTone1
	{
		static SingleTone1 instance; //이게 static이 아니면 staic메서드인 CreateInstance()가 호출을 못함
		private SingleTone1() // 기본 생성자를 프라이빗으로 해서 바깥에서 new를 못함 (인스턴스 생성)
							  // 인스턴스를 하나만 만들어서 공통으로 쓰게 하는게 싱글톤
		{
		}

		public static SingleTone1 CreateInstance() // 생성자를 만들어 주는거기 떄문에 반환타입은 생성자의 타입인 클래스명
		{
			//SingleTone1 instance; // 이게 전역으로 가야 메서드가 끝날때 사라지지 않는다
			if (instance == null)
				instance = new SingleTone1(); // 클래스 내부이기 때문에 private이여도 new할수있음

			return instance; // 이미 인스턴스가 생성 되어 있으면 if문을 건너 뛰고 이미 생성된 인스턴스를 반환
		}
		public void Method()
		{
			Console.WriteLine("메서드 실행");
		}
	}

	class Test
	{
		static void Main()
		{
			//인스턴스를 밖에서 맘대로 new를 하지못하게 할수 없을까?
			//인스턴스를 생성할때마다 생성자에 접근을 해야하는데 생성자를 Private으로 두면 클래스 외부에서 접근이 불가능
			//그렇게 클래스 내부에서 생성자를 만들어주는 메서드를 만들고 외부에서는 new를 쓰지못하게 해 한개의 인스턴스만 사용할수 있게 하는게 싱글톤 방식

			//SingleTone1 c1 = new SingleTone1(); // new를 할수없음
			SingleTone1 c1 = SingleTone1.CreateInstance(); // 이렇게 싱글톤 방식으로 인스턴스를 생성해주는 메서드를 바로 호출
			c1.Method();

			SingleTone1 c2 = SingleTone1.CreateInstance();
			c2.Method();

			c2 = SingleTone1.CreateInstance();
			c2.Method();
		}
	}
}
