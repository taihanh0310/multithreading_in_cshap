# multithreading_in_cshap

## 1. Cơ bản về Thread
> Thread hay còn gọi là tiểu trình là khái niệm trong lập trình. Thread cho phép chương trình thực hiện đồng thời nhiều tác vụ.
Thread cho phép chương trình thực hiện đồng thời nhiều tác vụ và giúp quá trình tương tác với người dùng không bị gián đoạn, lập trình song song và là kỹ thuật không thể thiếu trong các ứng dụng về mạng.

> Process có thể hiểu là <b>instance</b> của chương trình máy tính được thực thi, dựa trên hệ điều hành, hoàn toàn độc lập với các tiến trình khác.
> Thread là một <b> nhóm lệnh </b> được tạo ra để thực thi một tác vụ trong <b> process </b> chúng chia sẽ dữ liệu với nhau để xử lý.

## 2. Tạo và thực thi Thread
> * Tạo phương thức (gọi là phương thức callback) sẽ thực thi ghi thread được gọi: Phương thức này phải không có tham số hoặc chỉ có một tham số là kiểu object và kiểu trả về là void.
> * Tạo đối tượng Thread và truyền một delegate ThreadStart chứa phương thức sẽ thực thi vào contructor của Thread.
> * Chạy Thread: gọi phương thức Start() của đối tượng tạo thread vừa tạo.

<p>Code mẫu:</p>
<pre>
	<code>
		class Program
		{
			static void Main()
			{
				Thread t = new Thread(new ThreadStart(MethodA));
				t.Start();
				MethodB();
		 
			}
		 
			static void MethodA()
			{
				for (int i = 0; i < 100; i++)
					Console.Write("0");
			}
			static void MethodB()
			{
				for (int i = 0; i < 100; i++)
					Console.Write("1");
			}
		}
	</code>
</pre>

## 3. Truyền tham số cho Thread
## 4. Property ThreadState và ThreadPriority
### 4.1: ThreadState
### 4.2: ThreadPriority
## 5. Các phương thức thông dụng của Thread
## 6. Foreground và Background Thread
## 7. Thread Pooling
## 8. Đồng bộ hóa và clocking
## 9. Deadlock
> * Đồng bộ hóa khi sử dụng Thread là một công việc cần thiết, tuy nhiên nếu không cẩn thận trong cách sử dụng & thực thi code thì rất dễ xảy ra tình trạng chương trình dừng hoạt động vô thời gian.
Cái này người ta đặt tên là Deadlock.

> Deadlock xảy ra khi có ít nhất <b> hai Thread </b> cùng đợi Thread kia giải phóng, thật trùng hợp là cả hai lại đang giữ key của nhau.

<p>Code mẫu</p>

<pre>
	<code>
		class ThreadDeadlock
		{
			static object syncObj1 = new object();
			static object syncObj2 = new object();
		 
			static void Main()
			{
				Thread t1 = new Thread(Foo);
				Thread t2 = new Thread(Bar);
		 
				t1.Start();
				t2.Start();
			}
		 
			static void Foo()
			{
				Console.WriteLine("Inside Foo method");
				lock (syncObj1)
				{
					Console.WriteLine("Foo: lock(syncObj1)");
					Thread.Sleep(100);
					lock (syncObj2)
					{
						Console.WriteLine("Foo: lock(syncObj2)");
					}
				}
		 
			}
			static void Bar()
			{
				Console.WriteLine("Inside Bar method");
				lock (syncObj2)
				{
					Console.WriteLine("Bar: lock(syncObj2)");
					Thread.Sleep(100);
					lock (syncObj1)
					{
						Console.WriteLine("Bar: lock(syncObj1)");
					}
				}
			}
		}
	</code>
</pre>

<p> Kết quả </p>
<pre>
	Inside Foo method

	Foo: lock(syncObj1)

	Inside Bar method

	Bar: lock(syncObj2)
</pre>

https://yinyangit.wordpress.com/2011/04/11/c-thread-basic/
http://daringfireball.net/projects/markdown/syntax


### Threading Basic
<ul>
	<li> Creating a thread in C# </li>
	<li> Pausing a thread </li>
	<li> Making a thread wait</li>
	<li> Aborting a thread </li>
	<li> Determining thread state </li>
	<li> Thread priority</li>
	<li> Foreground and background thread </li>
	<li> Passing parameters to a thread </li>
	<li> Locking with a C# lock keywork </li>
	<li> Locking with a Monitor construct </li>
	<li> Handing exceptions </li>
</ul>