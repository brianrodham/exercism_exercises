using System;

public class CircularBuffer<T>
{
    private T[] buffer;
    private int elementCount = 0;
    private Pointer readPointer;
    private Pointer writePointer;

    public CircularBuffer(int capacity)
    {
        buffer = new T[capacity];
        readPointer = new Pointer(capacity);
        writePointer = new Pointer(capacity);
    }

    public T Read()
    {
        if(elementCount == 0)
        {
            throw new InvalidOperationException();
        }
        elementCount--;
        T item = buffer[readPointer.Get()];
        buffer[readPointer.Yield()] = default(T);
        return item;
    }

    public void Write(T value, bool checkLength = true)
    {
        if(checkLength && elementCount == buffer.Length)
        {
            throw new InvalidOperationException();
        }
        buffer[writePointer.Yield()] = value;
        elementCount++;
    }

    public void Overwrite(T value)
    {
        if(elementCount < buffer.Length)
        {
            Write(value, true);
        }
        else {
            buffer[readPointer.Yield()] = value;
        }
    }

    public void Clear()
    {
        if(elementCount != 0)
        {
            Read();    
        }       
    }
}

class Pointer {
    private int value = 0;
    private int max = 0;
    public Pointer(int max){
        this.max = max;
    }
    public int Get(){
        return value;
    }
    public int Yield() {
        var val = value++;
        if(value >= max){
            value = 0;
        }
        return val;
    }
}