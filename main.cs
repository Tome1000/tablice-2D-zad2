using System;

    class Program
    {
        static void Main()
        {

            string inputFirst = Console.ReadLine();
            string[] inputFirstSplit = inputFirst.Split(' ');
            int rowsFirst = int.Parse(inputFirstSplit[0]);
            int columnsFirst = int.Parse(inputFirstSplit[1]);

            string contentFirst = Console.ReadLine();
            string[] contentFirstSplit = contentFirst.Split(' ');
            int[] contentFirstInt = new int[rowsFirst * columnsFirst];
            int[,] matrixFirst = new int[rowsFirst, columnsFirst];

            string inputSecond = Console.ReadLine();
            string[] inputSecondSplit = inputSecond.Split(' ');
            int rowsSecond = int.Parse(inputSecondSplit[0]);
            int columnsSecond = int.Parse(inputSecondSplit[1]);

            string contentSecond = Console.ReadLine();
            string[] contentSecondSplit = contentSecond.Split(' ');
            int[] contentSecondInt = new int[rowsSecond * columnsSecond];
            int[,] matrixSecond = new int[rowsSecond, columnsSecond];
            int sumOfMatrixElements = 0;
            int nextIndex = 0;
            
            if (columnsFirst != rowsSecond)
            {
                Console.Write("impossible");
            }
            else if (rowsSecond > 10 || columnsSecond > 10 || rowsFirst > 10 || columnsFirst > 10)
            {
            Console.Write(' ');
            }
            else
            { 

            //matrix making code

                foreach (string i in contentFirstSplit)
                {
                contentFirstInt[nextIndex] = int.Parse(i);
                nextIndex++;
                }

                for (int a = rowsFirst - 1; a >= 0; a--)
                {
                    for (int b = columnsFirst - 1; b >= 0; b--)
                    {
                    nextIndex--;
                    matrixFirst[a, b] = contentFirstInt[nextIndex];
                    }
                }

            //end

                nextIndex = -1;

                foreach (string i in contentSecondSplit)
                {
                nextIndex++;
                contentSecondInt[nextIndex] = int.Parse(i);
               
                }
          
                for (int a = rowsSecond - 1; a >= 0; a--)
                {
                    for (int b = columnsSecond - 1; b >= 0; b--)
                    {

                        if (nextIndex >= 0)
                        {
                        matrixSecond[a, b] = contentSecondInt[nextIndex];
                        }
                        nextIndex--;
             
                    }   

                }

                if (1==1)
                {
                    for (int a = 0; a <= rowsFirst - 1; a++)
                    {
                        for (int b = 0; b <= columnsSecond - 1; b++)
                        {
                            sumOfMatrixElements = 0;
                            for (int c = 0; c <= columnsFirst - 1; c++)
                            {

                                sumOfMatrixElements = sumOfMatrixElements + matrixFirst[a, c] * matrixSecond[c, b];

                            }
                            if (sumOfMatrixElements != 0)
                                Console.Write(sumOfMatrixElements  + " ");

                        }
                        Console.WriteLine();
                    }
                }            
            }
        }     
    }


    
