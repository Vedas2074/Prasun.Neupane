class Array
{
    void Learn1DArray()
    {
       byte[] array1 = new byte[10];
       array1[0] = 11; 
       array1[1] = 22;
       array1[2] = 33;
       float[] array2 = new float[] {2.1f, 23.5f,44.6f};
       var x = array2.Length;
       char[] array3 = {'a','b','c','A','B','C'};
       float[] subArray1 = array2[0..1]; //While slicing array we can use range operator
    }

    void LearnMulDArray()
    {
        //2D array
        int[,] numbers1 = new int[3,4];
        numbers1[0,0] = 345;
        numbers1[2,3] = 346;

        decimal[,] numbers2 ={{2.3m,2.4m},{2.5m,2.6m}};
    }

    void LearnJaggedArray()
    {
        short[][] numbers = new short[4][];
        numbers[0] = new short[]{2,3,4};
        numbers[1] = new short[]{2,3,4};
        numbers[2] =new short[]{2,3,4,5};
    }
}