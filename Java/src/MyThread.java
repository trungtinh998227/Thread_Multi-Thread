

public class MyThread extends Thread {
	MyData data;
	public MyThread(MyData data) {
		this.data = data;
	}
	
	@Override
	public void run() {
		
		for (int i=0; i< 1000000; i++) {
			data.increaseCounter();
			
		}
		
		System.out.println(Thread.currentThread().getName());
	}
}
