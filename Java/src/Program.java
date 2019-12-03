
public class Program {

	public static void main(String[] args) throws InterruptedException {
		
		MyData data = new MyData();
		
		MyThread th1 = new MyThread(data);
		MyThread th2 = new MyThread(data);
		
		th1.setName("Thread 1");
		th1.start();
		th2.setName("Thread 2");
		th2.start();
	
		th1.join();
		th2.join();
		
		System.out.println("Finish: "+ data.getCounter());
	}

}
