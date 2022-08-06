int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;

}

int [] array = {12,21,39,2311,33,13,74,23,313};
array[0] = 12;




/* int a1 = 12;
int b1 = 21;
int c1 = 39;
int a2 = 2311;
int b2 = 33;
int c2 = 13;
int a3 = 74;
int b3 = 23;
int c3 = 313;
*/


int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);

Console.WriteLine(max);
