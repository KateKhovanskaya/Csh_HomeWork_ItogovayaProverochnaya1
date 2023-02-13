string[] arr={"hello", "2", "world", ":-)"};
int rezCount = LengthRezaltArr(arr);
Console.Write($"[{String.Join(",", FillRezultArr(rezCount))}]");
//----------------Методы----------------
//Определение длинв результативного массива
int LengthRezaltArr(string[]arr){
    int rezCount=0;
    for(int i=0;i<arr.Length;i++){
        if(arr[i].Length<=3){
         rezCount++;
         }
    }
    return rezCount;
}

//Заполнение результативного массива
string[] FillRezultArr(int rezCount){
    string[] rezArr=new string[rezCount];
    int j=0;
    for(int i=0;i<arr.Length;i++){
        if(arr[i].Length<=3){
            rezArr[j]=arr[i];
            j++;
        }
    }
    return rezArr;
}