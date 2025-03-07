/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* dailyTemperatures(int* temperatures, int temperaturesSize, int* returnSize) {
    int* result= (int*)calloc(temperaturesSize, sizeof(int));
    int stack[temperaturesSize];
    int top= -1;
    int previndex;
    // yaha se asal shuru he
    for(int i= 0;i<temperaturesSize;i++){
        while (top >= 0 && temperatures[i] > temperatures[stack[top]]) {
            previndex= stack[top--];
            result[previndex]= i - previndex;

        }
        stack[++top]= i;
    }
    *returnSize= temperaturesSize;
    return result;
    }

