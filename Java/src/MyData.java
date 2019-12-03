
public class MyData {
	private int counter;
	
	public int getCounter() {
		
		return counter;
	}
	
	public synchronized int increaseCounter() {
		
		return counter++;
	}
}
